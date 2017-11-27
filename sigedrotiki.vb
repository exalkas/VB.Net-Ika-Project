Imports system.IO
Imports C1.C1Excel
Imports C1.C1Preview
Public Class sigedrotiki

    Private Sub sigedrotiki_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icnt1 As Integer
        Me.C1DateEdit1.Value = Today
        Me.C1DateEdit2.Value = Today
        Me.C1TextBox2.Value = "Επιλέξτε Φαρμακείο"


        Me.C1FlexGrid1.DataSource = Nothing

        Me.C1ExpressTable1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_farmakeia.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        Me.C1ExpressTable1.DbTableName = "temp_sin_result"
        Me.table_farmakeia.DbTableName = "farmakeia"


        Me.C1ExpressTable1.ExpressConnection.Fill()
        Me.table_farmakeia.ExpressConnection.Fill()

        Me.C1FlexGrid1.DataSource = Me.C1ExpressTable1

        Me.C1FlexGrid1.Cols(1).Caption = "Ημερομηνία"
        Me.C1FlexGrid1.Cols(2).Caption = "Αριθμός Συνταγών"
        Me.C1FlexGrid1.Cols(3).Caption = "Συνταγές Κλινικών"
        Me.C1FlexGrid1.Cols(4).Caption = "Σύνολο του 0%"
        Me.C1FlexGrid1.Cols(5).Caption = "Σύνολο του 10%"
        Me.C1FlexGrid1.Cols(6).Caption = "Σύνολο του 25%"

        Me.C1FlexGrid1.Cols(4).Format = "C2"
        Me.C1FlexGrid1.Cols(5).Format = "C2"
        Me.C1FlexGrid1.Cols(6).Format = "C2"

        For icnt1 = 1 To Me.C1FlexGrid1.Rows.Count - 1
            Me.C1FlexGrid1.Rows.Remove(1)
        Next
        Me.C1TextBox1.Focus()
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Dim tot As Decimal
        'Check for errors
        If Me.C1TextBox2.Text = "Επιλέξτε Φαρμακείο" Then
            MessageBox.Show("Παρακαλώ επιλέξτε κάποιο Φαρμακείο")
            Exit Sub
        End If

        If Me.C1DateEdit1.Value > Me.C1DateEdit2.Value Then
            MessageBox.Show("Η 1η ημερομηνία είναι μεγαλύτερη από τη 2η.Παρακαλώ διορθώστε")
            Exit Sub
        End If

        'Go
        Me.SqlConnection1.Open()

        SqlCommand1.Parameters.Clear()
        With SqlCommand1
            .Parameters.AddWithValue("dmy1", Me.C1DateEdit1.Value)
            .Parameters.AddWithValue("dmy2", Me.C1DateEdit2.Value)
            .Parameters.AddWithValue("farmakeio", C1TextBox1.Text)
        End With

        Try
            SqlCommand1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            SqlConnection1.Close()
        End Try
        Me.C1ExpressTable1.DataTable.DataSet.Fill()
        Me.C1TextBox3.Value = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 2, Me.C1FlexGrid1.Rows.Count - 1, 2, C1.Win.C1FlexGrid.AggregateFlags.None)
        Me.C1TextBox13.Value = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 3, Me.C1FlexGrid1.Rows.Count - 1, 3, C1.Win.C1FlexGrid.AggregateFlags.None)
        Me.C1TextBox4.Value = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 4, Me.C1FlexGrid1.Rows.Count - 1, 4, C1.Win.C1FlexGrid.AggregateFlags.None)
        Me.C1TextBox9.Value = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 5, Me.C1FlexGrid1.Rows.Count - 1, 5, C1.Win.C1FlexGrid.AggregateFlags.None)
        Me.C1TextBox12.Value = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 6, Me.C1FlexGrid1.Rows.Count - 1, 6, C1.Win.C1FlexGrid.AggregateFlags.None)
        Me.C1TextBox5.Value = 0
        Me.C1TextBox8.Value = Me.C1TextBox9.Value * (10 / 100)
        Me.C1TextBox11.Value = Me.C1TextBox12.Value * (25 / 100)
        Me.C1TextBox6.Value = Me.C1TextBox4.Value - Me.C1TextBox5.Value
        Me.C1TextBox7.Value = Me.C1TextBox9.Value - Me.C1TextBox8.Value
        Me.C1TextBox10.Value = Me.C1TextBox12.Value - Me.C1TextBox11.Value
        tot = Me.C1TextBox6.Value + Me.C1TextBox7.Value + Me.C1TextBox10.Value
        Me.C1TextBox14.Value = tot
    End Sub

    Private Sub C1TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1DateEdit1.Focus()
    End Sub

    Private Sub C1TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1TextBox1.TextChanged
        If Len(Me.C1TextBox1.Text) = 9 Then
            Me.table_farmakeia.FillFilter = "[afm]='" & Me.C1TextBox1.Text & "'"
            Me.table_farmakeia.DataTable.DataSet.Fill()
            If Me.table_farmakeia.DataTable.Rows.Count > 0 Then
                Me.C1TextBox2.Value = Me.table_farmakeia.DataTable.Rows.Item(0).Item(1)
            Else
                Me.C1TextBox2.Value = "Επιλέξτε Φαρμακείο"
            End If
        Else
            Me.C1TextBox2.Value = "Επιλέξτε Φαρμακείο"
        End If
    End Sub

    Private Sub C1DateEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DateEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1DateEdit2.Focus()
    End Sub
    Private Sub C1DateEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DateEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Dim icnt1 As Integer, icnt2 As Integer
        If Me.C1FlexGrid1.Rows.Count > 65000 Then
            MessageBox.Show("Οι εγγραφές που έχετε επιλέξει είναι περισσότερες από 65.000 και δεν είναι δυνατόν να εξαχθούν στο Excel.")
            Exit Sub
        End If

        If Me.C1FlexGrid1.Rows.Count < 2 Then
            MessageBox.Show("Δεν υπάρχουν εγγραφές για εξαγωγή.")
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
        sheet.Name = "Συγκεντρωτική"

        Dim styleOdd As XLStyle = New XLStyle(book)
        styleOdd.Font = New Font("Tahoma", 9, FontStyle.Italic)
        styleOdd.ForeColor = Color.Blue
        Dim styleEven As XLStyle = New XLStyle(book)
        styleEven.Font = New Font("Tahoma", 9, FontStyle.Bold)
        styleEven.ForeColor = Color.Red

        For icnt1 = 0 To Me.C1FlexGrid1.Cols.Count - 1
            Dim cell1 As XLCell = sheet(0, icnt1)
            cell1.Value = Me.C1FlexGrid1.Cols(icnt1).Caption
        Next

        For icnt1 = 1 To Me.C1FlexGrid1.Rows.Count - 1
            For icnt2 = 1 To Me.C1FlexGrid1.Cols.Count - 1
                Dim cell As XLCell = sheet(icnt1 + 1, icnt2)
                If icnt2 = 1 Then
                    cell.Value = Me.C1FlexGrid1.Item(icnt1, icnt2).ToString
                Else
                    cell.Value = Me.C1FlexGrid1.Item(icnt1, icnt2)
                End If

            Next
        Next
        ' save the book
        book.Save(dlg.FileName)
        System.Diagnostics.Process.Start(dlg.FileName)
    End Sub

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button3.Click
        If Me.C1FlexGrid1.Rows.Count < 2 Then
            MessageBox.Show("Δεν υπάρχουν διαθέσιμες εγγραφές για εκτύπωση.")
            Exit Sub
        End If

        printform.Show()
    End Sub
End Class
