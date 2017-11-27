Public Class parameters

    Private Sub parameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If clear_afm = False Then
            Me.CheckBox1.Checked = False
        Else
            Me.CheckBox1.Checked = True
        End If
        If add_enter = False Then
            Me.CheckBox2.Checked = False
        Else
            Me.CheckBox2.Checked = True
        End If
        If clear_checks = False Then
            Me.CheckBox3.Checked = False
        Else
            Me.CheckBox3.Checked = True
        End If
        If keep_dates = False Then
            Me.CheckBox4.Checked = False
        Else
            Me.CheckBox4.Checked = True
        End If

    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Dim istr As String, istr2 As String, istr3 As String, istr4 As String
        If Me.CheckBox1.Checked = True Then
            istr = "TRUE"
            clear_afm = True
        Else
            istr = "FALSE"
            clear_afm = False
        End If

        If Me.CheckBox2.Checked = True Then
            istr2 = "TRUE"
            add_enter = True
        Else
            istr2 = "FALSE"
            add_enter = False
        End If

        If Me.CheckBox3.Checked = True Then
            istr3 = "TRUE"
            clear_checks = True
        Else
            istr3 = "FALSE"
            clear_checks = False
        End If

        If Me.CheckBox4.Checked = True Then
            istr4 = "TRUE"
            keep_dates = True
        Else
            istr4 = "FALSE"
            keep_dates = False
        End If

        My.Settings.clearafm = istr
        My.Settings.addenter = istr2
        My.Settings.clearchecks = istr3
        My.Settings.keepdates = istr4
        MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν επιτυχώς.")
        Me.Close()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Me.Close()
    End Sub
End Class