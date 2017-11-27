Public Class farmakeia_add

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        If Me.C1TextBox1.Text = "" Or Me.C1TextBox2.Text = "" Or Me.C1TextBox3.Text = "" Then
            MessageBox.Show("Όλα τα πεδία είναι υποχρεωτικά. Παρακαλώ συμπληρώστε.")
            Exit Sub
        End If

        SqlConnection1.Open()
        Try
            SqlCommand1.Parameters.Clear()
            With SqlCommand1
                .Parameters.AddWithValue("afm", Me.C1TextBox1.Text)
                .Parameters.AddWithValue("onoma", C1TextBox2.Text)
                .Parameters.AddWithValue("poli", C1TextBox3.Text)
                .Parameters.AddWithValue("usr", usr_id)
            End With

            SqlCommand1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            SqlConnection1.Close()
        End Try
        farmakeia.C1ExpressTable1.DataTable.DataSet.Fill()
        MessageBox.Show("Επιτυχής Καταχώριση.")
        Me.Close()
    End Sub

    Private Sub farmakeia_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        clear_farmakeia_add()
    End Sub
    Private Sub C1TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox2.Focus()
    End Sub

    Private Sub C1TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox3.Focus()
    End Sub

    Private Sub C1TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
    End Sub
End Class