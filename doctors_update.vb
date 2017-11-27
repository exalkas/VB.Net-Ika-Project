Public Class doctors_update

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        If Me.C1TextBox2.Text = "" Or Me.C1TextBox3.Text = "" Or Me.C1TextBox4.Text = "" Or Me.C1TextBox5.Text = "" Then
            MessageBox.Show("Τα πεδία Επίθετο, Όνομα, Όνομα Πατρός και Τύπος Ιατρού είναι υποχρεωτικά. Παρακαλώ συμπληρώστε αυτά που λείπουν.")
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
                .Parameters.AddWithValue("started", Me.C1DateEdit1.Value)
                If Me.CheckBox1.Checked = True Then
                    .Parameters.AddWithValue("old_new", "0")
                Else
                    .Parameters.AddWithValue("old_new", "1")
                End If
                .Parameters.AddWithValue("type_doc", Me.C1TextBox5.Text)
                .Parameters.AddWithValue("usr", usr_id)
            End With

            SqlCommand1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            SqlConnection1.Close()
        End Try
        doctors.C1ExpressTable1.DataTable.DataSet.Fill()
        MessageBox.Show("Επιτυχής Αλλαγή.")
        Me.Close()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        clear_doctors_update()
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
        If e.KeyCode = Keys.Enter Then Me.C1DateEdit1.Focus()
    End Sub
    Private Sub C1TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
    End Sub

    Private Sub C1DateEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DateEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox5.Focus()
    End Sub

    Private Sub doctors_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
    End Sub
End Class