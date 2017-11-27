Imports system.IO
Imports C1.C1Excel

Public Class farmakeia

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button3.Click
        If Me.C1TrueDBGrid1.RowCount < 1 Then
            MessageBox.Show("Δεν υπάρχουν διαθέσιμες εγγραφές για διαγραφή.")
            Exit Sub
        End If

        If MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε το φαρμακείο με ΑΦΜ:" & _
        Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row), "Διαχείριση φαρμακείων", MessageBoxButtons.YesNo) _
        = Windows.Forms.DialogResult.Yes Then

            SqlCommand1.Parameters.Clear()
            With SqlCommand1
                .Parameters.AddWithValue("afm", Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row))
                .Parameters.AddWithValue("onoma", Me.C1TrueDBGrid1.Columns(1).CellText(Me.C1TrueDBGrid1.Row))
                .Parameters.AddWithValue("poli", Me.C1TrueDBGrid1.Columns(2).CellText(Me.C1TrueDBGrid1.Row))
            End With
            SqlConnection1.Open()
            Try
                SqlCommand1.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Sub
            Finally
                SqlConnection1.Close()
            End Try
            Me.C1ExpressTable1.DataTable.DataSet.Fill()
        End If
    End Sub

    Private Sub C1Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button5.Click
        If Me.C1TrueDBGrid1.RowCount < 1 Then
            MessageBox.Show("Δεν υπάρχουν διαθέσιμες εγγραφές για εκτύπωση.")
            Exit Sub
        End If
        With Me.C1TrueDBGrid1.PrintInfo
            Dim fntFont As Font
            fntFont = New Font(.PageHeaderStyle.Font.Name, .PageHeaderStyle.Font.Size, FontStyle.Italic)
            .PageHeaderStyle.Font = fntFont
            .PageSettings.Landscape = True
            .PageHeader = "Διαχείριση Φαρμακείων: Εκτύπωση στις " & Today
            ' Column headers will be on every page.   
            .RepeatColumnHeaders = True     ' Display page numbers (centered).   
            .PageFooter = "Σελίδα: \p"     ' Invoke print preview.   
            .UseGridColors = True
            .PrintPreview()
        End With
    End Sub

    Private Sub C1Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button4.Click
        Dim icnt1 As Integer, icnt2 As Integer

        If Me.C1TrueDBGrid1.RowCount < 2 Then
            MessageBox.Show("Δεν υπάρχουν διαθέσιμες εγγραφές για εξαγωγή.")
            Exit Sub
        End If

        If Me.C1TrueDBGrid1.RowCount > 65000 Then
            MessageBox.Show("Οι εγγραφές που έχετε επιλέξει είναι περισσότερες από 65.000 και δεν είναι δυνατόν να εξαχθούν στο Excel.")
            Exit Sub
        End If

        ' choose file
        Dim dlg As New SaveFileDialog()
        dlg.DefaultExt = "xls"
        dlg.FileName = "*.xls"
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim book As C1XLBook = New C1XLBook()

        ' step 2: get the sheet that was created by default, give it a name
        Dim sheet As XLSheet = book.Sheets(0)
        sheet.Name = "Φαρμακεία"

        Dim styleOdd As XLStyle = New XLStyle(book)
        styleOdd.Font = New Font("Tahoma", 9, FontStyle.Italic)
        styleOdd.ForeColor = Color.Blue
        Dim styleEven As XLStyle = New XLStyle(book)
        styleEven.Font = New Font("Tahoma", 9, FontStyle.Bold)
        styleEven.ForeColor = Color.Red

        For icnt1 = 0 To Me.C1TrueDBGrid1.Columns.Count - 1
            Dim cell1 As XLCell = sheet(0, icnt1)
            cell1.Value = Me.C1TrueDBGrid1.Columns(icnt1).Caption
        Next

        For icnt1 = 0 To Me.C1TrueDBGrid1.RowCount
            For icnt2 = 0 To Me.C1TrueDBGrid1.Columns.Count - 1
                Dim cell As XLCell = sheet(icnt1 + 1, icnt2)
                cell.Value = Me.C1TrueDBGrid1.Columns.Item(icnt2).CellValue(icnt1)
            Next
        Next
        ' save the book
        book.Save(dlg.FileName)
        System.Diagnostics.Process.Start(dlg.FileName)
    End Sub

    Private Sub farmakeia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1TrueDBGrid1.DataSource = Nothing

        Me.C1ExpressTable1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        Me.C1ExpressTable1.DbTableName = "farmakeia"

        Me.C1ExpressTable1.ExpressConnection.Fill()

        Me.C1TrueDBGrid1.DataSource = Me.C1ExpressTable1

        'Me.C1TrueDBGrid1.Splits(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.C1TrueDBGrid1.Columns(0).Caption = "ΑΦΜ Φαρμακείου"
        Me.C1TrueDBGrid1.Columns(1).Caption = "Ονομασία"
        Me.C1TrueDBGrid1.Columns(2).Caption = "Πόλη"
        Me.C1TrueDBGrid1.Columns(3).Caption = "Χρήστης"

        Me.C1TextBox1.Value = Me.C1TrueDBGrid1.RowCount
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        farmakeia_add.Show()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        farmakeia_update.Show()
    End Sub

    Private Sub C1ExpressTable1_AfterFill(ByVal sender As Object, ByVal e As C1.Data.FillEventArgs) Handles C1ExpressTable1.AfterFill
        Me.C1TextBox1.Value = Me.C1TrueDBGrid1.RowCount
    End Sub
End Class