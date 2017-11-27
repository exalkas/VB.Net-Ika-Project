Public Class asfalismenoi_update

    Private Sub asfalismenoi_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        If Me.C1TextBox2.Text = "" Or Me.C1TextBox3.Text = "" Then
            MessageBox.Show("Τα πεδία Κωδικός, Επίθετο και Όνομα είναι υποχρεωτικά. Παρακαλώ συμπληρώστε αυτά που λείπουν.")
            Exit Sub
        End If

        SqlConnection1.Open()
        Try
            SqlCommand1.Parameters.Clear()
            With SqlCommand1
                .Parameters.AddWithValue("code", Me.C1TextBox1.Text)
                .Parameters.AddWithValue("epitheto", C1TextBox2.Text)
                .Parameters.AddWithValue("onoma", C1TextBox3.Text)
                .Parameters.AddWithValue("pateras", C1TextBox4.Text)
                .Parameters.AddWithValue("mitera", C1TextBox5.Value)
                .Parameters.AddWithValue("dmy", Me.C1TextBox6.Value)
                .Parameters.AddWithValue("adres", Me.C1TextBox7.Text)
                '.Parameters.AddWithValue("arithmos", Me.C1TextBox8.Text)
                '.Parameters.AddWithValue("poli", C1TextBox9.Text)
                '.Parameters.AddWithValue("tk", C1TextBox10.Text)
                '.Parameters.AddWithValue("afm", C1TextBox11.Value)
                '.Parameters.AddWithValue("dimotologio", C1TextBox12.Value)
            End With

            SqlCommand1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            SqlConnection1.Close()
        End Try
        asfalismenoi.C1ExpressTable1.DataTable.DataSet.Fill()
        MessageBox.Show("Επιτυχής Αλλαγή.")
        Me.Close()
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
    End Sub

    Private Sub C1TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
    End Sub

    Private Sub C1TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox9.Focus()
    End Sub

    Private Sub C1TextBox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox10.Focus()
    End Sub

    Private Sub C1TextBox10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox10.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox11.Focus()
    End Sub

    Private Sub C1TextBox11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox12.Focus()
    End Sub

    Private Sub C1TextBox12_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        clear_asfalismenoi_update()
    End Sub
End Class