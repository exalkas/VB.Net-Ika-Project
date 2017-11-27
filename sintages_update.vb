Public Class sintages_update
    Private Sub C1TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox3.Focus()
    End Sub

    Private Sub C1TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1TextBox2.TextChanged
        Me.table_iatroi.FillFilter = "[code]='" & Me.C1TextBox2.Text & "'"
        Me.table_iatroi.DataTable.DataSet.Fill()
        'if me.table_iatroi.DataTable.Rows.Item is dbnull.Value
        If Me.table_iatroi.DataTable.Rows.Count > 0 Then
            Me.C1Labeliatroi.Text = Me.table_iatroi.DataTable.Rows.Item(0).Item(1) & " " & _
Me.table_iatroi.DataTable.Rows.Item(0).Item(2) & " " & _
Me.table_iatroi.DataTable.Rows.Item(0).Item(4) & " " & _
Me.table_iatroi.DataTable.Rows.Item(0).Item(6)
        Else
            Me.C1Labeliatroi.Text = "Επιλέξτε Ιατρό"
        End If

    End Sub

    Private Sub sintages_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.C1Combo1.DataSource = Nothing
        Me.C1Combo2.DataSource = Nothing
        Me.C1Combo3.DataSource = Nothing

        Me.table_asfalismenoi.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_farmaka1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_farmaka2.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_farmaka2.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_farmaka3.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_farmakeia.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_iatroi.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_simetoxi1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_simetoxi2.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_simetoxi3.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        Me.table_asfalismenoi.DbTableName = "asfalismenoi"
        Me.table_farmaka1.DbTableName = "farmaka"
        Me.table_farmaka2.DbTableName = "farmaka"
        Me.table_farmaka3.DbTableName = "farmaka"
        Me.table_farmakeia.DbTableName = "farmakeia"
        Me.table_iatroi.DbTableName = "iatroi"
        Me.table_simetoxi1.DbTableName = "simmetoxes"
        Me.table_simetoxi2.DbTableName = "simmetoxes"
        Me.table_simetoxi3.DbTableName = "simmetoxes"

        Me.C1Combo1.DataSource = table_simetoxi1
        Me.C1Combo2.DataSource = table_simetoxi2
        Me.C1Combo3.DataSource = table_simetoxi3

        Me.table_asfalismenoi.ExpressConnection.Fill()
        Me.table_farmaka1.ExpressConnection.Fill()
        Me.table_farmaka2.ExpressConnection.Fill()
        Me.table_farmaka3.ExpressConnection.Fill()
        Me.table_farmakeia.ExpressConnection.Fill()
        Me.table_iatroi.ExpressConnection.Fill()
        Me.table_simetoxi1.ExpressConnection.Fill()
        Me.table_simetoxi2.ExpressConnection.Fill()
        Me.table_simetoxi3.ExpressConnection.Fill()

        Me.C1Combo1.Columns(0).Caption = "Ποσοστό"
        Me.C1Combo1.ColumnWidth = 135
        Me.C1Combo1.DisplayMember = "pososto"
        Me.C1Combo1.ValueMember = "pososto"
        Me.C1Combo2.Columns(0).Caption = "Ποσοστό"
        Me.C1Combo2.ColumnWidth = 135
        Me.C1Combo2.DisplayMember = "pososto"
        Me.C1Combo2.ValueMember = "pososto"
        Me.C1Combo3.Columns(0).Caption = "Ποσοστό"
        Me.C1Combo3.ColumnWidth = 135
        Me.C1Combo3.DisplayMember = "pososto"
        Me.C1Combo3.ValueMember = "pososto"

        Me.C1TextBox16.ValueIsDbNull = False
        Me.C1TextBox19.ValueIsDbNull = False
        Me.C1TextBox20.ValueIsDbNull = False

    End Sub

    Private Sub C1TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox4.Focus()
    End Sub

    Private Sub C1TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1TextBox3.TextChanged
        If Len(Me.C1TextBox3.Text) = 7 Then
            Me.table_asfalismenoi.FillFilter = "[code]='" & Me.C1TextBox3.Text & "'"
            Me.table_asfalismenoi.DataTable.DataSet.Fill()

            If Me.table_asfalismenoi.DataTable.Rows.Count > 0 Then
                Me.C1Labelasfalismenoi.Text = Me.table_asfalismenoi.DataTable.Rows.Item(0).Item(1) & " " & _
    Me.table_asfalismenoi.DataTable.Rows.Item(0).Item(2) & " " & _
    Me.table_asfalismenoi.DataTable.Rows.Item(0).Item(5)
            Else
                Me.C1Labelasfalismenoi.Text = "Επιλέξτε Ασφαλισμένο"
            End If
        Else
            Me.C1Labelasfalismenoi.Text = "Επιλέξτε Ασφαλισμένο"
        End If
    End Sub

    Private Sub C1TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1DateEdit1.Focus()
    End Sub

    Private Sub C1TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1TextBox4.TextChanged
        If Len(Me.C1TextBox4.Text) = 9 Then
            Me.table_farmakeia.FillFilter = "[afm]='" & Me.C1TextBox4.Text & "'"
            Me.table_farmakeia.DataTable.DataSet.Fill()

            If Me.table_farmakeia.DataTable.Rows.Count > 0 Then
                Me.C1Labelfarmakeia.Text = Me.table_farmakeia.DataTable.Rows.Item(0).Item(1) & " " & _
    Me.table_farmakeia.DataTable.Rows.Item(0).Item(2)
            Else
                Me.C1Labelfarmakeia.Text = "Επιλέξτε ΑΦΜ Φαρμακείου"
            End If
        Else
            Me.C1Labelfarmakeia.Text = "Επιλέξτε ΑΦΜ Φαρμακείου"
        End If
    End Sub

    Private Sub C1TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox6.Focus()
    End Sub

    Private Sub C1TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox30.Focus()
    End Sub

    Private Sub C1TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1TextBox7.TextChanged
        If Len(Me.C1TextBox7.Text) = 13 Then
            If add_enter = True Then Me.C1TextBox30.Focus()
            Me.table_farmaka1.FillFilter = "[code]='" & Mid(Me.C1TextBox7.Text, 4, 9) & "'"
            Me.table_farmaka1.DataTable.DataSet.Fill()
            'if me.table_iatroi.DataTable.Rows.Item is dbnull.Value
            If Me.table_farmaka1.DataTable.Rows.Count > 0 Then
                Me.C1Labelfarmako1.Text = Me.table_farmaka1.DataTable.Rows.Item(0).Item(2)
                Me.C1TextBox16.Value = Me.table_farmaka1.DataTable.Rows.Item(0).Item(7)
                Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
                Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
                calc_totals_update()
            Else
                Me.C1Labelfarmako1.Text = "Επιλέξτε το 1ο Φάρμακο"
                Me.C1TextBox16.Value = 0
                Me.C1TextBox17.Value = 0
                Me.C1TextBox18.Value = 0
                calc_totals_update()
            End If
        Else
            Me.C1Labelfarmako1.Text = "Επιλέξτε το 1ο Φάρμακο"
            Me.C1TextBox16.Value = 0
            Me.C1TextBox17.Value = 0
            Me.C1TextBox18.Value = 0
            calc_totals_update()
        End If
    End Sub

    Private Sub C1NumericEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1NumericEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Combo2.Focus()
    End Sub
    Private Sub C1NumericEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1NumericEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Combo3.Focus()
    End Sub
    Private Sub C1NumericEdit3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1NumericEdit3.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox15.Focus()
    End Sub
    Private Sub C1NumericEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1NumericEdit1.TextChanged
        If Len(Me.C1NumericEdit1.Text) > 2 Then
            Me.C1NumericEdit1.Value = 99
            Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
            calc_totals_update()
            Exit Sub
        End If
        If Me.C1NumericEdit1.Value < 0 Then
            Me.C1NumericEdit1.Value = 0
            Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
            calc_totals_update()
            Exit Sub
            'Else
            '    Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            '    Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
        End If
    End Sub

    Private Sub C1NumericEdit1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NumericEdit1.ValueChanged
        If Me.C1TextBox16.Value Is DBNull.Value Then Exit Sub
        If Me.C1TextBox16.Value >= 0 Then
            If Me.C1NumericEdit1.Value < 0 Then
                Me.C1NumericEdit1.Value = 0
                Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
                Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
                calc_totals_update()
            Else
                Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
                Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
                calc_totals_update()
            End If
        End If
    End Sub

    Private Sub C1Combo1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Combo1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1NumericEdit1.Focus()
    End Sub
    Private Sub C1Combo3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Combo3.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1NumericEdit3.Focus()
    End Sub
    Private Sub C1Combo1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo1.SelectedValueChanged
        If Me.C1TextBox16.Value Is DBNull.Value Then Exit Sub
        If Me.C1TextBox16.Value >= 0 Then
            Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
            calc_totals_update()
        End If
    End Sub

    Private Sub C1TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox2.Focus()
    End Sub
    Private Sub C1TextBox15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox15.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Button1.Focus()
        Me.C1TextBox23.Value = Me.C1TextBox14.Value - Me.C1TextBox15.Value
    End Sub
    Private Sub C1DateEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DateEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1DateEdit2.Focus()
    End Sub

    Private Sub C1DateEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DateEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox5.Focus()
    End Sub

    Private Sub C1TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox7.Focus()
    End Sub

    Private Sub C1TextBox30_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox30.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox31.Focus()
        If Len(Me.C1TextBox30.Text) = 12 Then
            Me.C1NumericEdit1.Value = Me.C1NumericEdit1.Value + 1
            If add_enter = True Then Me.C1TextBox31.Focus()
        End If
    End Sub
    Private Sub C1TextBox31_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox31.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox32.Focus()
        If Len(Me.C1TextBox31.Text) = 12 Then
            Me.C1NumericEdit1.Value = Me.C1NumericEdit1.Value + 1
            If add_enter = True Then Me.C1TextBox32.Focus()
        End If
    End Sub
    Private Sub C1TextBox32_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox32.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox33.Focus()
        If Len(Me.C1TextBox32.Text) = 12 Then
            Me.C1NumericEdit1.Value = Me.C1NumericEdit1.Value + 1
            If add_enter = True Then Me.C1TextBox33.Focus()
        End If
    End Sub
    Private Sub C1TextBox33_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox33.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox21.Focus()
        If Len(Me.C1TextBox33.Text) = 12 Then
            Me.C1NumericEdit1.Value = Me.C1NumericEdit1.Value + 1
            If add_enter = True Then Me.C1TextBox21.Focus()
        End If
    End Sub
    Private Sub C1TextBox21_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox21.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox34.Focus()
    End Sub
    Private Sub C1TextBox34_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox34.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox35.Focus()
        If Len(Me.C1TextBox34.Text) = 12 Then
            Me.C1NumericEdit2.Value = Me.C1NumericEdit2.Value + 1
            If add_enter = True Then Me.C1TextBox35.Focus()
        End If

    End Sub
    Private Sub C1TextBox35_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox35.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox36.Focus()
        If Len(Me.C1TextBox35.Text) = 12 Then
            Me.C1NumericEdit2.Value = Me.C1NumericEdit2.Value + 1
            If add_enter = True Then Me.C1TextBox36.Focus()
        End If

    End Sub
    Private Sub C1TextBox36_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox36.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox37.Focus()
        If Len(Me.C1TextBox36.Text) = 12 Then
            Me.C1NumericEdit2.Value = Me.C1NumericEdit2.Value + 1
            If add_enter = True Then Me.C1TextBox37.Focus()
        End If

    End Sub
    Private Sub C1TextBox37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox37.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox22.Focus()
        If Len(Me.C1TextBox37.Text) = 12 Then
            Me.C1NumericEdit2.Value = Me.C1NumericEdit2.Value + 1
            If add_enter = True Then Me.C1TextBox22.Focus()
        End If

    End Sub
    Private Sub C1TextBox22_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox22.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox38.Focus()
    End Sub
    Private Sub C1TextBox38_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox38.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox39.Focus()
        If Len(Me.C1TextBox38.Text) = 12 Then
            Me.C1NumericEdit3.Value = Me.C1NumericEdit3.Value + 1
            If add_enter = True Then Me.C1TextBox39.Focus()
        End If

    End Sub
    Private Sub C1TextBox39_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox39.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox40.Focus()
        If Len(Me.C1TextBox39.Text) = 12 Then
            Me.C1NumericEdit3.Value = Me.C1NumericEdit3.Value + 1
            If add_enter = True Then Me.C1TextBox40.Focus()
        End If

    End Sub
    Private Sub C1TextBox40_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox40.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1TextBox41.Focus()
        If Len(Me.C1TextBox40.Text) = 12 Then
            Me.C1NumericEdit3.Value = Me.C1NumericEdit3.Value + 1
            If add_enter = True Then Me.C1TextBox41.Focus()
        End If

    End Sub
    Private Sub C1TextBox41_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox41.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1Combo1.Focus()
        If Len(Me.C1TextBox41.Text) = 12 Then
            Me.C1NumericEdit3.Value = Me.C1NumericEdit3.Value + 1
            If add_enter = True Then Me.C1Combo1.Focus()
        End If

    End Sub

    Private Sub C1Combo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Combo2.KeyDown
        If e.KeyCode = Keys.Enter Then Me.C1NumericEdit2.Focus()
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        clear_form_sintages_update()
    End Sub

    Private Sub C1TextBox21_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox21.TextChanged
        If Len(Me.C1TextBox21.Text) = 13 Then
            If add_enter = True Then Me.C1TextBox34.Focus()
            Me.table_farmaka2.FillFilter = "[code]='" & Mid(Me.C1TextBox21.Text, 4, 9) & "'"
            Me.table_farmaka2.DataTable.DataSet.Fill()
            'if me.table_iatroi.DataTable.Rows.Item is dbnull.Value
            If Me.table_farmaka2.DataTable.Rows.Count > 0 Then
                Me.C1Labelfarmako2.Text = Me.table_farmaka2.DataTable.Rows.Item(0).Item(2)
                Me.C1TextBox19.Value = Me.table_farmaka2.DataTable.Rows.Item(0).Item(7)
                Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
                Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
                calc_totals_update()
            Else
                Me.C1Labelfarmako2.Text = "Επιλέξτε το 2ο Φάρμακο"
                Me.C1TextBox19.Value = 0
                Me.C1TextBox8.Value = 0
                Me.C1TextBox9.Value = 0
                calc_totals_update()
            End If
        Else
            Me.C1Labelfarmako2.Text = "Επιλέξτε το 2ο Φάρμακο"
            Me.C1TextBox19.Value = 0
            Me.C1TextBox8.Value = 0
            Me.C1TextBox9.Value = 0
            calc_totals_update()
        End If
    End Sub

    Private Sub C1Combo2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo2.SelectedValueChanged
        If Me.C1TextBox19.Value Is DBNull.Value Then Exit Sub
        If Me.C1TextBox19.Value >= 0 Then
            Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
            Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
            calc_totals_update()
        End If
    End Sub

    Private Sub C1NumericEdit2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NumericEdit2.TextChanged
        If Len(Me.C1NumericEdit2.Text) > 2 Then
            Me.C1NumericEdit2.Value = 99
            Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
            Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
            calc_totals_update()
            Exit Sub
        End If
        If Me.C1NumericEdit2.Value < 0 Then
            Me.C1NumericEdit2.Value = 0
            Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
            Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
            calc_totals_update()
            Exit Sub
            'Else
            '    Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            '    Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
        End If
    End Sub

    Private Sub C1NumericEdit2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NumericEdit2.ValueChanged
        If Me.C1TextBox19.Value Is DBNull.Value Then Exit Sub
        If Me.C1TextBox19.Value >= 0 Then
            If Me.C1NumericEdit2.Value < 0 Then
                Me.C1NumericEdit2.Value = 0
                Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
                Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
                calc_totals_update()
            Else
                Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
                Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
                calc_totals_update()
            End If
        End If
    End Sub

    Private Sub C1TextBox22_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox22.TextChanged
        If Len(Me.C1TextBox22.Text) = 13 Then
            If add_enter = True Then Me.C1TextBox38.Focus()
            Me.table_farmaka3.FillFilter = "[code]='" & Mid(Me.C1TextBox22.Text, 4, 9) & "'"
            Me.table_farmaka3.DataTable.DataSet.Fill()
            'if me.table_iatroi.DataTable.Rows.Item is dbnull.Value
            If Me.table_farmaka3.DataTable.Rows.Count > 0 Then
                Me.C1Labelfarmako3.Text = Me.table_farmaka3.DataTable.Rows.Item(0).Item(2)
                Me.C1TextBox20.Value = Me.table_farmaka3.DataTable.Rows.Item(0).Item(7)
                Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
                Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
                calc_totals_update()
            Else
                Me.C1Labelfarmako3.Text = "Επιλέξτε το 3ο Φάρμακο"
                Me.C1TextBox20.Value = 0
                Me.C1TextBox10.Value = 0
                Me.C1TextBox11.Value = 0
                calc_totals_update()
            End If
        Else
            Me.C1Labelfarmako3.Text = "Επιλέξτε το 3ο Φάρμακο"
            Me.C1TextBox20.Value = 0
            Me.C1TextBox10.Value = 0
            Me.C1TextBox11.Value = 0
            calc_totals_update()
        End If
    End Sub

    Private Sub C1NumericEdit3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NumericEdit3.TextChanged
        If Len(Me.C1NumericEdit3.Text) > 2 Then
            Me.C1NumericEdit3.Value = 99
            Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
            Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
            calc_totals_update()
            Exit Sub
        End If
        If Me.C1NumericEdit3.Value < 0 Then
            Me.C1NumericEdit3.Value = 0
            Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
            Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
            calc_totals_update()
            Exit Sub
            'Else
            '    Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            '    Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
        End If
    End Sub

    Private Sub C1NumericEdit3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NumericEdit3.ValueChanged
        If Me.C1TextBox20.Value Is DBNull.Value Then Exit Sub
        If Me.C1TextBox20.Value >= 0 Then
            If Me.C1NumericEdit3.Value < 0 Then
                Me.C1NumericEdit3.Value = 0
                Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
                Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
                calc_totals_update()
            Else
                Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
                Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
                calc_totals_update()
            End If
        End If
    End Sub

    Private Sub C1Combo3_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Combo3.SelectedValueChanged
        If Me.C1TextBox20.Value Is DBNull.Value Then Exit Sub
        If Me.C1TextBox20.Value >= 0 Then
            Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
            Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
            calc_totals_update()
        End If
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Dim farma1 As String, farma2 As String, farma3 As String
        Dim box11 As String, box12 As String, box13 As String, box14 As String
        Dim box21 As String, box22 As String, box23 As String, box24 As String
        Dim box31 As String, box32 As String, box33 As String, box34 As String
        Dim price1 As Decimal, price2 As Decimal, price3 As Decimal
        Dim amount1 As Int16, amount2 As Int16, amount3 As Int16
        Dim sim1 As Int16, sim2 As Int16, sim3 As Int16
        Dim total1 As Decimal, total2 As Decimal, total3 As Decimal
        Dim kliniki As String

        'initialize
        farma1 = ""
        farma2 = ""
        farma3 = ""
        box11 = ""
        box12 = ""
        box13 = ""
        box14 = ""
        box21 = ""
        box22 = ""
        box23 = ""
        box24 = ""
        box31 = ""
        box32 = ""
        box33 = ""
        box34 = ""
        price1 = 0
        price2 = 0
        price3 = 0
        amount1 = 0
        amount2 = 0
        amount3 = 0
        sim1 = 0
        sim2 = 0
        sim3 = 0
        total1 = 0
        total2 = 0
        total3 = 0
        kliniki = ""

        'Check for Errors
        If Me.C1TextBox1.Text = "" Or Me.C1TextBox2.Text = "" Or Me.C1TextBox3.Text = "" Or Me.C1TextBox4.Text = "" Then
            MessageBox.Show("Κάποιο από τα πεδία: Κωδικός Συνταγής, Ιατρός, Ασφαλισμένος, ΑΦΜ Φαρμακείου δεν είναι συμπληρωμένο. Παρακαλώ συμπληρώστε το και ξαναπροσπαθήστε.")
            Exit Sub
        End If

        If Me.C1Labelfarmakeia.Text = "Επιλέξτε ΑΦΜ Φαρμακείου" Then
            MessageBox.Show("Δεν έχετε επιλέξει φαρμακείο που να υπάρχει στην βάση δεδομένων. Παρακαλώ συμπληρώστε τα στοιχεία του.")
            Exit Sub
        End If

        If Len(Me.C1TextBox1.Text) < 10 Then
            MessageBox.Show("Έχετε εισάγει Κωδικό Συνταγής με λιγότερα από 10 ψηφία. Παρακαλώ διορθώστε.")
            Exit Sub
        End If

        If Me.C1TextBox12.Value = 0 Or Me.C1TextBox14.Value = 0 Then
            MessageBox.Show("Το συνολικό ποσό της συνταγής ή το αιτούμενο ποσό είναι 0. Παρακαλώ διορθώστε.")
            Exit Sub
        End If

        If Me.CheckBox6.Checked = False Then
            If Me.C1Labelfarmako1.Text = "Επιλέξτε το 1ο Φάρμακο" And Me.C1TextBox7.Text <> "" Then
                MessageBox.Show("Στο 1ο φάρμακο έχετε εισάγει χαρακτήρες που δεν αντιστοιχούν σε φάρμακο στη βάση δεδομένων. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
        End If
        If Me.CheckBox7.Checked = False Then
            If Me.C1Labelfarmako2.Text = "Επιλέξτε το 2ο Φάρμακο" And Me.C1TextBox21.Text <> "" Then
                MessageBox.Show("Στο 1ο φάρμακο έχετε εισάγει χαρακτήρες που δεν αντιστοιχούν σε φάρμακο στη βάση δεδομένων. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
        End If
        If Me.CheckBox8.Checked = False Then
            If Me.C1Labelfarmako3.Text = "Επιλέξτε το 3ο Φάρμακο" And Me.C1TextBox22.Text <> "" Then
                MessageBox.Show("Στο 1ο φάρμακο έχετε εισάγει χαρακτήρες που δεν αντιστοιχούν σε φάρμακο στη βάση δεδομένων. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
        End If

        'Assign Values
        '1o Farmako
        If Me.CheckBox6.Checked = True Then
            If Me.C1TextBox16.Value > 0 Then
                price1 = Me.C1TextBox16.Value
            Else
                MessageBox.Show("Η τιμή στο 1ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If Me.C1NumericEdit1.Value > 0 Then
                amount1 = Me.C1NumericEdit1.Value
            Else
                MessageBox.Show("Η ποσότητα στο 1ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If Me.C1TextBox17.Value > 0 Then
                total1 = Me.C1TextBox17.Value
            Else
                MessageBox.Show("Το σύνολο του 1ου φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If (Me.C1Combo1.SelectedValue Is DBNull.Value) Or (Me.C1TextBox18.Value = 0 And Me.C1Combo1.SelectedValue > 0) Or (Me.C1TextBox18.Value > 0 And Me.C1Combo1.SelectedValue = 0) Then
                MessageBox.Show("Το ποσό συμμετοχής για το 1ο φάρμακο δεν είναι σωστό. Παρακαλώ διορθώστε.")
                Exit Sub
            Else
                sim1 = Me.C1Combo1.SelectedValue
            End If
            farma1 = "111111111"
            box11 = "empty"
            box12 = "empty"
            box13 = "empty"
            box14 = "empty"
        Else
            '   MessageBox.Show(Me.table_farmaka1.DataTable.Rows.Count)
            If Mid(Me.C1TextBox7.Text, 4, 9) = Me.table_farmaka1.DataTable.Rows.Item(0).Item(1) Then
                farma1 = Mid(Me.C1TextBox7.Text, 4, 9)
                If Me.C1TextBox30.Text <> "" Then
                    box11 = Me.C1TextBox30.Text
                Else
                    box11 = "empty"
                End If
                If Me.C1TextBox31.Text <> "" Then
                    box12 = Me.C1TextBox31.Text
                Else
                    box12 = "empty"
                End If
                If Me.C1TextBox32.Text <> "" Then
                    box13 = Me.C1TextBox32.Text
                Else
                    box13 = "empty"
                End If
                If Me.C1TextBox33.Text <> "" Then
                    box14 = Me.C1TextBox33.Text
                Else
                    box14 = "empty"
                End If
                If Me.C1TextBox16.Value > 0 Then
                    price1 = Me.C1TextBox16.Value
                Else
                    MessageBox.Show("Η τιμή στο 1ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If Me.C1TextBox16.Value <> Me.table_farmaka1.DataTable.Rows.Item(0).Item(7) Then
                    MessageBox.Show("Τα στοιχεία του 1ου φάρμακου δεν συμφωνούν με την τιμή του. Παρακαλώ διορθώστε.")
                End If
                If Me.C1NumericEdit1.Value > 0 Then
                    amount1 = Me.C1NumericEdit1.Value
                Else
                    MessageBox.Show("Η ποσότητα στο 1ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If Me.C1TextBox17.Value > 0 Then
                    total1 = Me.C1TextBox17.Value
                Else
                    MessageBox.Show("Το σύνολο του 1ου φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If (Me.C1Combo1.SelectedValue Is DBNull.Value) Or (Me.C1TextBox18.Value = 0 And Me.C1Combo1.SelectedValue > 0) Or (Me.C1TextBox18.Value > 0 And Me.C1Combo1.SelectedValue = 0) Then
                    MessageBox.Show("Το ποσό συμμετοχής για το 1ο φάρμακο δεν είναι σωστό. Παρακαλώ διορθώστε.")
                    Exit Sub
                Else
                    sim1 = Me.C1Combo1.SelectedValue
                End If
            Else
                farma1 = "empty"
                box11 = "empty"
                box12 = "empty"
                box13 = "empty"
                box14 = "empty"
            End If
        End If

        '2o Farmako
        If Me.CheckBox7.Checked = True Then
            If Me.C1TextBox19.Value > 0 Then
                price2 = Me.C1TextBox19.Value
            Else
                MessageBox.Show("Η τιμή στο 2ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If Me.C1NumericEdit2.Value > 0 Then
                amount2 = Me.C1NumericEdit2.Value
            Else
                MessageBox.Show("Η ποσότητα στο 2ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If Me.C1TextBox8.Value > 0 Then
                total2 = Me.C1TextBox8.Value
            Else
                MessageBox.Show("Το σύνολο του 2ου φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If (Me.C1Combo2.SelectedValue Is DBNull.Value) Or (Me.C1TextBox9.Value = 0 And Me.C1Combo2.SelectedValue > 0) Or (Me.C1TextBox9.Value > 0 And Me.C1Combo2.SelectedValue = 0) Then
                MessageBox.Show("Το ποσό συμμετοχής για το 2ο φάρμακο δεν είναι σωστό. Παρακαλώ διορθώστε.")
                Exit Sub
            Else
                sim2 = Me.C1Combo2.SelectedValue
            End If
            farma2 = "111111112"
            box21 = "empty"
            box22 = "empty"
            box23 = "empty"
            box24 = "empty"
        Else
            If Mid(Me.C1TextBox21.Text, 4, 9) = Me.table_farmaka2.DataTable.Rows.Item(0).Item(1) Then
                farma2 = Mid(Me.C1TextBox21.Text, 4, 9)
                If Me.C1TextBox34.Text <> "" Then
                    box21 = Me.C1TextBox34.Text
                Else
                    box21 = "empty"
                End If
                If Me.C1TextBox35.Text <> "" Then
                    box22 = Me.C1TextBox35.Text
                Else
                    box22 = "empty"
                End If
                If Me.C1TextBox36.Text <> "" Then
                    box23 = Me.C1TextBox36.Text
                Else
                    box23 = "empty"
                End If
                If Me.C1TextBox37.Text <> "" Then
                    box24 = Me.C1TextBox37.Text
                Else
                    box24 = "empty"
                End If
                If Me.C1TextBox19.Value > 0 Then
                    price2 = Me.C1TextBox19.Value
                Else
                    MessageBox.Show("Η τιμή στο 2ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If Me.C1TextBox19.Value <> Me.table_farmaka2.DataTable.Rows.Item(0).Item(7) Then
                    MessageBox.Show("Τα στοιχεία του 2ου φάρμακου δεν συμφωνούν με την τιμή του. Παρακαλώ διορθώστε.")
                End If
                If Me.C1NumericEdit2.Value > 0 Then
                    amount2 = Me.C1NumericEdit2.Value
                Else
                    MessageBox.Show("Η ποσότητα στο 2ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If Me.C1TextBox8.Value > 0 Then
                    total2 = Me.C1TextBox8.Value
                Else
                    MessageBox.Show("Το σύνολο του 2ου φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If (Me.C1Combo2.SelectedValue Is DBNull.Value) Or (Me.C1TextBox9.Value = 0 And Me.C1Combo2.SelectedValue > 0) Or (Me.C1TextBox9.Value > 0 And Me.C1Combo2.SelectedValue = 0) Then
                    MessageBox.Show("Το ποσό συμμετοχής για το 2ο φάρμακο δεν είναι σωστό. Παρακαλώ διορθώστε.")
                    Exit Sub
                Else
                    sim2 = Me.C1Combo2.SelectedValue
                End If
            Else
                farma2 = "empty"
                box21 = "empty"
                box22 = "empty"
                box23 = "empty"
                box24 = "empty"
            End If
        End If

        '3o Farmako
        If Me.CheckBox8.Checked = True Then
            If Me.C1TextBox20.Value > 0 Then
                price3 = Me.C1TextBox20.Value
            Else
                MessageBox.Show("Η τιμή στο 3ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If Me.C1NumericEdit3.Value > 0 Then
                amount3 = Me.C1NumericEdit3.Value
            Else
                MessageBox.Show("Η ποσότητα στο 3ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If Me.C1TextBox10.Value > 0 Then
                total3 = Me.C1TextBox10.Value
            Else
                MessageBox.Show("Το σύνολο του 3ου φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
                Exit Sub
            End If
            If (Me.C1Combo3.SelectedValue Is DBNull.Value) Or (Me.C1TextBox11.Value = 0 And Me.C1Combo3.SelectedValue > 0) Or (Me.C1TextBox11.Value > 0 And Me.C1Combo3.SelectedValue = 0) Then
                MessageBox.Show("Το ποσό συμμετοχής για το 1ο φάρμακο δεν είναι σωστό. Παρακαλώ διορθώστε.")
                Exit Sub
            Else
                sim3 = Me.C1Combo3.SelectedValue
            End If
            farma3 = "111111113"
            box31 = "empty"
            box32 = "empty"
            box33 = "empty"
            box34 = "empty"
        Else
            If Mid(Me.C1TextBox22.Text, 4, 9) = Me.table_farmaka3.DataTable.Rows.Item(0).Item(1) Then
                farma3 = Mid(Me.C1TextBox22.Text, 4, 9)
                If Me.C1TextBox38.Text <> "" Then
                    box31 = Me.C1TextBox38.Text
                Else
                    box31 = "empty"
                End If
                If Me.C1TextBox39.Text <> "" Then
                    box32 = Me.C1TextBox39.Text
                Else
                    box32 = "empty"
                End If
                If Me.C1TextBox40.Text <> "" Then
                    box33 = Me.C1TextBox40.Text
                Else
                    box33 = "empty"
                End If
                If Me.C1TextBox41.Text <> "" Then
                    box34 = Me.C1TextBox41.Text
                Else
                    box34 = "empty"
                End If
                If Me.C1TextBox20.Value > 0 Then
                    price3 = Me.C1TextBox20.Value
                Else
                    MessageBox.Show("Η τιμή στο 3ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If Me.C1TextBox20.Value <> Me.table_farmaka3.DataTable.Rows.Item(0).Item(7) Then
                    MessageBox.Show("Τα στοιχεία του 3ου φάρμακου δεν συμφωνούν με την τιμή του. Παρακαλώ διορθώστε.")
                End If
                If Me.C1NumericEdit3.Value > 0 Then
                    amount3 = Me.C1NumericEdit3.Value
                Else
                    MessageBox.Show("Η ποσότητα στο 3ο φάρμακο είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If Me.C1TextBox10.Value > 0 Then
                    total3 = Me.C1TextBox10.Value
                Else
                    MessageBox.Show("Το σύνολο του 3ο φαρμάκου είναι 0. Παρακαλώ διορθώστε.")
                    Exit Sub
                End If
                If (Me.C1Combo3.SelectedValue Is DBNull.Value) Or (Me.C1TextBox11.Value = 0 And Me.C1Combo3.SelectedValue > 0) Or (Me.C1TextBox11.Value > 0 And Me.C1Combo3.SelectedValue = 0) Then
                    MessageBox.Show("Το ποσό συμμετοχής για το 3ο φάρμακο δεν είναι σωστό. Παρακαλώ διορθώστε.")
                    Exit Sub
                Else
                    sim3 = Me.C1Combo3.SelectedValue
                End If
            Else
                farma3 = "empty"
                box31 = "empty"
                box32 = "empty"
                box33 = "empty"
                box34 = "empty"
            End If
        End If

        If Me.CheckBox1.Checked = False Then
            kliniki = 0
        Else
            kliniki = 1
        End If

        SqlConnection1.Open()
        Try
            SqlCommand1.Parameters.Clear()
            With SqlCommand1
                .Parameters.AddWithValue("code", old_code)
                .Parameters.AddWithValue("doctor", C1TextBox2.Text)
                .Parameters.AddWithValue("asfalismenos", C1TextBox3.Text)
                .Parameters.AddWithValue("farmakeio", C1TextBox4.Text)
                .Parameters.AddWithValue("dmy_issue", Me.C1DateEdit1.Value)
                .Parameters.AddWithValue("dmy_exec", Me.C1DateEdit2.Value)
                .Parameters.AddWithValue("diagnosi", C1TextBox5.Text)
                .Parameters.AddWithValue("remarks", C1TextBox6.Text)
                .Parameters.AddWithValue("total", C1TextBox12.Value)
                .Parameters.AddWithValue("total_simmetoxi", C1TextBox13.Value)
                .Parameters.AddWithValue("total_pay", C1TextBox14.Value)
                .Parameters.AddWithValue("differ", C1TextBox23.Value)
                .Parameters.AddWithValue("kliniki", kliniki)

                .Parameters.AddWithValue("code_farmako1", farma1)
                .Parameters.AddWithValue("amount1", amount1)
                .Parameters.AddWithValue("price1", price1)
                .Parameters.AddWithValue("total1", total1)
                .Parameters.AddWithValue("amount_simmetoxi1", Me.C1TextBox18.Value)
                .Parameters.AddWithValue("pososto1", sim1)
                .Parameters.AddWithValue("box11", box11)
                .Parameters.AddWithValue("box12", box12)
                .Parameters.AddWithValue("box13", box13)
                .Parameters.AddWithValue("box14", box14)

                .Parameters.AddWithValue("code_farmako2", farma2)
                .Parameters.AddWithValue("amount2", amount2)
                .Parameters.AddWithValue("price2", price2)
                .Parameters.AddWithValue("total2", total2)
                .Parameters.AddWithValue("amount_simmetoxi2", Me.C1TextBox9.Value)
                .Parameters.AddWithValue("pososto2", sim2)
                .Parameters.AddWithValue("box21", box21)
                .Parameters.AddWithValue("box22", box22)
                .Parameters.AddWithValue("box23", box23)
                .Parameters.AddWithValue("box24", box24)

                .Parameters.AddWithValue("code_farmako3", farma3)
                .Parameters.AddWithValue("amount3", amount3)
                .Parameters.AddWithValue("price3", price3)
                .Parameters.AddWithValue("total3", total3)
                .Parameters.AddWithValue("amount_simmetoxi3", Me.C1TextBox11.Value)
                .Parameters.AddWithValue("pososto3", sim3)
                .Parameters.AddWithValue("box31", box31)
                .Parameters.AddWithValue("box32", box32)
                .Parameters.AddWithValue("box33", box33)
                .Parameters.AddWithValue("box34", box34)
                .Parameters.AddWithValue("usr", usr_id)
            End With


            SqlCommand1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            SqlConnection1.Close()
        End Try
        sintages.C1ExpressTable1.DataTable.DataSet.Fill()
        MessageBox.Show("Επιτυχής Αλλαγή.")
        Me.Close()
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim res1 As Integer, res2 As Integer, istr1 As String, istr2 As String
        If Me.CheckBox2.Checked = True Then
            If Len(Me.C1TextBox6.Text) > 0 Then
                Me.C1TextBox6.Text = Me.C1TextBox6.Text & ", Δεν αντιστοιχεί ο κωδικός ασφαλισμένου"
            Else
                Me.C1TextBox6.Text = "Δεν αντιστοιχεί ο κωδικός ασφαλισμένου"
            End If
        Else
            If Len(Me.C1TextBox6.Text) > 0 Then
                res1 = InStr(Me.C1TextBox6.Text, ", Δεν αντιστοιχεί ο κωδικός ασφαλισμένου")
                res2 = InStr(Me.C1TextBox6.Text, "Δεν αντιστοιχεί ο κωδικός ασφαλισμένου")
                If res1 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res1 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res1 + 40)
                    Me.C1TextBox6.Text = istr1 & istr2
                    Exit Sub
                End If
                If res2 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res2 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res2 + 40)
                    Me.C1TextBox6.Text = istr1 & istr2
                Else
                    Me.C1TextBox6.Text = ""
                End If

            Else
                Me.C1TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Dim res1 As Integer, res2 As Integer, istr1 As String, istr2 As String
        If Me.CheckBox3.Checked = True Then
            If Len(Me.C1TextBox6.Text) > 0 Then
                Me.C1TextBox6.Text = Me.C1TextBox6.Text & ", Δεν αντιστοιχεί ο κωδικός ιατρού"
            Else
                Me.C1TextBox6.Text = "Δεν αντιστοιχεί ο κωδικός ιατρού"
            End If
        Else
            If Len(Me.C1TextBox6.Text) > 0 Then
                res1 = InStr(Me.C1TextBox6.Text, ", Δεν αντιστοιχεί ο κωδικός ιατρού")
                res2 = InStr(Me.C1TextBox6.Text, "Δεν αντιστοιχεί ο κωδικός ιατρού")
                If res1 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res1 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res1 + 34)
                    Me.C1TextBox6.Text = istr1 & istr2
                    Exit Sub
                End If
                If res2 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res2 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res2 + 34)
                    Me.C1TextBox6.Text = istr1 & istr2
                Else
                    Me.C1TextBox6.Text = ""
                End If

            Else
                Me.C1TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Dim res1 As Integer, res2 As Integer, istr1 As String, istr2 As String
        If Me.CheckBox4.Checked = True Then
            If Len(Me.C1TextBox6.Text) > 0 Then
                Me.C1TextBox6.Text = Me.C1TextBox6.Text & ", Λείπουν κουπόνια"
            Else
                Me.C1TextBox6.Text = "Λείπουν κουπόνια"
            End If
        Else
            If Len(Me.C1TextBox6.Text) > 0 Then
                res1 = InStr(Me.C1TextBox6.Text, ", Λείπουν κουπόνια")
                res2 = InStr(Me.C1TextBox6.Text, "Λείπουν κουπόνια")
                If res1 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res1 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res1 + 18)
                    Me.C1TextBox6.Text = istr1 & istr2
                    Exit Sub
                End If
                If res2 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res2 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res2 + 18)
                    Me.C1TextBox6.Text = istr1 & istr2
                Else
                    Me.C1TextBox6.Text = ""
                End If

            Else
                Me.C1TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Dim res1 As Integer, res2 As Integer, istr1 As String, istr2 As String
        If Me.CheckBox5.Checked = True Then
            If Len(Me.C1TextBox6.Text) > 0 Then
                Me.C1TextBox6.Text = Me.C1TextBox6.Text & ", Λάθος τιμή φαρμάκου"
            Else
                Me.C1TextBox6.Text = "Λάθος τιμή φαρμάκου"
            End If
        Else
            If Len(Me.C1TextBox6.Text) > 0 Then
                res1 = InStr(Me.C1TextBox6.Text, ", Λάθος τιμή φαρμάκου")
                res2 = InStr(Me.C1TextBox6.Text, "Λάθος τιμή φαρμάκου")
                If res1 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res1 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res1 + 21)
                    Me.C1TextBox6.Text = istr1 & istr2
                    Exit Sub
                End If
                If res2 > 0 Then
                    istr1 = Mid(Me.C1TextBox6.Text, 1, res2 - 1)
                    istr2 = Mid(Me.C1TextBox6.Text, res2 + 21)
                    Me.C1TextBox6.Text = istr1 & istr2
                Else
                    Me.C1TextBox6.Text = ""
                End If

            Else
                Me.C1TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If Me.CheckBox6.Checked = True Then
            Me.C1SuperLabel18.Visible = False
            Me.C1TextBox30.Visible = False
            Me.C1TextBox31.Visible = False
            Me.C1TextBox32.Visible = False
            Me.C1TextBox33.Visible = False
            Me.C1TextBox16.ReadOnly = False
            Me.C1TextBox16.Value = 0
            Me.C1TextBox7.Value = "2801111111111"
            Me.C1TextBox7.ReadOnly = True
            Me.C1TextBox16.Focus()
            Me.C1NumericEdit1.Value = 0
            Me.C1Combo1.SelectedValue = 0
        Else
            Me.C1SuperLabel18.Visible = True
            Me.C1TextBox30.Visible = True
            Me.C1TextBox31.Visible = True
            Me.C1TextBox32.Visible = True
            Me.C1TextBox33.Visible = True
            Me.C1TextBox30.Text = ""
            Me.C1TextBox31.Text = ""
            Me.C1TextBox32.Text = ""
            Me.C1TextBox33.Text = ""
            Me.C1TextBox16.ReadOnly = True
            Me.C1TextBox16.Value = 0
            Me.C1TextBox7.Value = ""
            Me.C1TextBox7.ReadOnly = False
            Me.C1TextBox7.Focus()
            Me.C1NumericEdit1.Value = 0
            Me.C1Combo1.SelectedValue = 0
            Me.table_farmaka1.FillFilter = ""
            Me.table_farmaka1.DataTable.DataSet.Fill()
        End If
    End Sub

    Private Sub C1TextBox16_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox16.KeyDown
        If Me.CheckBox6.Checked = True Then
            If e.KeyCode = Keys.Enter Then Me.C1TextBox21.Focus()
            Me.C1TextBox17.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value
            Me.C1TextBox18.Value = Me.C1TextBox16.Value * Me.C1NumericEdit1.Value * (Me.C1Combo1.SelectedValue / 100)
            calc_totals_update()
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If Me.CheckBox7.Checked = True Then
            Me.C1SuperLabel19.Visible = False
            Me.C1TextBox34.Visible = False
            Me.C1TextBox35.Visible = False
            Me.C1TextBox36.Visible = False
            Me.C1TextBox37.Visible = False
            Me.C1TextBox19.ReadOnly = False
            Me.C1TextBox19.Value = 0
            Me.C1TextBox21.Value = "2801111111121"
            Me.C1TextBox21.ReadOnly = True
            Me.C1TextBox19.Focus()
        Else
            Me.C1SuperLabel19.Visible = True
            Me.C1TextBox34.Visible = True
            Me.C1TextBox35.Visible = True
            Me.C1TextBox36.Visible = True
            Me.C1TextBox37.Visible = True
            Me.C1TextBox34.Text = ""
            Me.C1TextBox35.Text = ""
            Me.C1TextBox36.Text = ""
            Me.C1TextBox37.Text = ""
            Me.C1TextBox19.ReadOnly = True
            Me.C1TextBox19.Value = 0
            Me.C1TextBox21.Value = ""
            Me.C1TextBox21.ReadOnly = False
            Me.C1TextBox21.Focus()
            Me.C1NumericEdit2.Value = 0
            Me.C1Combo2.SelectedValue = 0
            Me.table_farmaka2.FillFilter = ""
            Me.table_farmaka2.DataTable.DataSet.Fill()
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If Me.CheckBox8.Checked = True Then
            Me.C1SuperLabel20.Visible = False
            Me.C1TextBox38.Visible = False
            Me.C1TextBox39.Visible = False
            Me.C1TextBox40.Visible = False
            Me.C1TextBox41.Visible = False
            Me.C1TextBox20.ReadOnly = False
            Me.C1TextBox20.Value = 0
            Me.C1TextBox22.Value = "2801111111131"
            Me.C1TextBox22.ReadOnly = True
            Me.C1TextBox20.Focus()
        Else
            Me.C1SuperLabel20.Visible = True
            Me.C1TextBox38.Visible = True
            Me.C1TextBox39.Visible = True
            Me.C1TextBox40.Visible = True
            Me.C1TextBox41.Visible = True
            Me.C1TextBox38.Text = ""
            Me.C1TextBox39.Text = ""
            Me.C1TextBox40.Text = ""
            Me.C1TextBox41.Text = ""
            Me.C1TextBox20.ReadOnly = True
            Me.C1TextBox20.Value = 0
            Me.C1TextBox22.Value = ""
            Me.C1TextBox22.ReadOnly = False
            Me.C1TextBox22.Focus()
            Me.C1NumericEdit3.Value = 0
            Me.C1Combo3.SelectedValue = 0
            Me.table_farmaka3.FillFilter = ""
            Me.table_farmaka3.DataTable.DataSet.Fill()
        End If
    End Sub

    Private Sub C1TextBox19_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox19.KeyDown
        If Me.CheckBox7.Checked = True Then
            If e.KeyCode = Keys.Enter Then Me.C1TextBox22.Focus()
            Me.C1TextBox8.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value
            Me.C1TextBox9.Value = Me.C1TextBox19.Value * Me.C1NumericEdit2.Value * (Me.C1Combo2.SelectedValue / 100)
            calc_totals_update()
        End If
    End Sub

    Private Sub C1TextBox20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1TextBox20.KeyDown
        If Me.CheckBox8.Checked = True Then
            If e.KeyCode = Keys.Enter Then Me.C1Combo1.Focus()
            Me.C1TextBox10.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value
            Me.C1TextBox11.Value = Me.C1TextBox20.Value * Me.C1NumericEdit3.Value * (Me.C1Combo3.SelectedValue / 100)
            calc_totals_update()
        End If
    End Sub
    Private Sub C1TextBox30_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox30.TextChanged
        If Len(Me.C1TextBox30.Text) = 12 Then If add_enter = True Then Me.C1TextBox31.Focus()
    End Sub

    Private Sub C1TextBox31_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox31.TextChanged
        If Len(Me.C1TextBox31.Text) = 12 Then If add_enter = True Then Me.C1TextBox32.Focus()
    End Sub
    Private Sub C1TextBox32_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox32.TextChanged
        If Len(Me.C1TextBox32.Text) = 12 Then If add_enter = True Then Me.C1TextBox33.Focus()
    End Sub
    Private Sub C1TextBox33_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox33.TextChanged
        If Len(Me.C1TextBox33.Text) = 12 Then If add_enter = True Then Me.C1TextBox21.Focus()
    End Sub
    Private Sub C1TextBox34_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox34.TextChanged
        If Len(Me.C1TextBox34.Text) = 12 Then If add_enter = True Then Me.C1TextBox35.Focus()
    End Sub
    Private Sub C1TextBox35_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox35.TextChanged
        If Len(Me.C1TextBox35.Text) = 12 Then If add_enter = True Then Me.C1TextBox36.Focus()
    End Sub
    Private Sub C1TextBox36_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox36.TextChanged
        If Len(Me.C1TextBox36.Text) = 12 Then If add_enter = True Then Me.C1TextBox37.Focus()
    End Sub
    Private Sub C1TextBox37_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox37.TextChanged
        If Len(Me.C1TextBox37.Text) = 12 Then If add_enter = True Then Me.C1TextBox22.Focus()
    End Sub
    Private Sub C1TextBox38_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox38.TextChanged
        If Len(Me.C1TextBox38.Text) = 12 Then If add_enter = True Then Me.C1TextBox39.Focus()
    End Sub
    Private Sub C1TextBox39_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox39.TextChanged
        If Len(Me.C1TextBox39.Text) = 12 Then If add_enter = True Then Me.C1TextBox40.Focus()
    End Sub
    Private Sub C1TextBox40_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox40.TextChanged
        If Len(Me.C1TextBox40.Text) = 12 Then If add_enter = True Then Me.C1TextBox41.Focus()
    End Sub
    Private Sub C1TextBox41_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1TextBox41.TextChanged
        If Len(Me.C1TextBox41.Text) = 12 Then If add_enter = True Then Me.C1Combo1.Focus()
    End Sub
End Class