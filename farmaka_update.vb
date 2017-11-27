Public Class farmaka_update

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        If Me.C1TextBox1.Text = "" Or Me.C1TextBox3.Text = "" Or Me.C1TextBox4.Text = "" Or Me.C1TextBox5.Text = "" Then
            MessageBox.Show("Τα πεδία Κωδικός ΕΟΦ, Ονομασία Φαρμάκου, Κωδικός Εταιρείας και Ονομασία Εταιρείας είναι υποχρεωτικά. Παρακαλώ συμπληρώστε αυτά που λείπουν.")
            Exit Sub
        End If
        If Me.C1TextBox6.Value = 0 Or Me.C1TextBox7.Value = 0 Or Me.C1TextBox8.Value = 0 Then
            MessageBox.Show("Οι τιμές του φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
            Exit Sub
        End If
        SqlConnection1.Open()
        Try
            SqlCommand1.Parameters.Clear()
            With SqlCommand1
                .Parameters.AddWithValue("code_eof", Me.C1TextBox1.Text)
                .Parameters.AddWithValue("code", C1TextBox2.Text)
                .Parameters.AddWithValue("onoma", C1TextBox3.Text)
                .Parameters.AddWithValue("code_comp", C1TextBox4.Text)
                .Parameters.AddWithValue("company", Me.C1TextBox5.Text)
                .Parameters.AddWithValue("price_x", C1TextBox6.Value)
                .Parameters.AddWithValue("price_n", C1TextBox7.Value)
                .Parameters.AddWithValue("price", C1TextBox8.Value)
                .Parameters.AddWithValue("usr", usr_id)
            End With

            SqlCommand1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            SqlConnection1.Close()
        End Try
        farmaka.C1ExpressTable1.DataTable.DataSet.Fill()
        MessageBox.Show("Επιτυχής Αλλαγή.")
        Me.Close()
    End Sub

    Private Sub farmaka_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.C1TextBox6.Value = 0
        Me.C1TextBox7.Value = 0
        Me.C1TextBox8.Value = 0
    End Sub
    Private Sub C1TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox2.Focus()
    End Sub


    Private Sub C1TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox3.Focus()
    End Sub

    Private Sub C1TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox4.Focus()
    End Sub

    Private Sub C1TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox5.Focus()
    End Sub
    Private Sub C1TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox6.Focus()
    End Sub
    Private Sub C1TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox7.Focus()
        If Me.C1TextBox6.Value < 0 Then Me.C1TextBox6.Value = 0
    End Sub

    Private Sub C1TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox8.Focus()
        If Me.C1TextBox7.Value < 0 Then Me.C1TextBox7.Value = 0
    End Sub
    Private Sub C1TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
        If Me.C1TextBox8.Value < 0 Then Me.C1TextBox8.Value = 0
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        clear_farmaka_update()
    End Sub
End Class