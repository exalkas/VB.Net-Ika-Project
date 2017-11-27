Public Class login
    Dim usrs As New C1.Data.Express.C1ExpressTable
    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Me.Close()
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        usrs.FillFilter = "[onoma]='" & Trim(Me.C1TextBox1.Text) & "'" & " and [pwd]='" & Trim(Me.C1TextBox2.Value) & "'"
        'usrs.DataTable.DataSet.Fill()
        usrs.ExpressConnection.DataSet.Fill()
        If usrs.DataTable.Rows.Count = 1 Then
            If usrs.DataTable.Rows(0).Item(0).ToString = Me.C1TextBox1.Text And usrs.DataTable.Rows(0).Item(1).ToString = Me.C1TextBox2.Value Then
                usr_id = usrs.DataTable.Rows.Item(0).Item(0)
                main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Λάθος Όνομα Χρήστη ή Κωδικός")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        usrs.ConnectionType = C1.Data.SchemaObjects.ConnectionTypeEnum.SqlServer
        usrs.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        usrs.DbTableName = "usrs"
        usrs.ExpressConnection.DataSet.Fill()

    End Sub
    Private Sub C1TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox2.Focus()
    End Sub


    Private Sub C1TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
    End Sub
End Class