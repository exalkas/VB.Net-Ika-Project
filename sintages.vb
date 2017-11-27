Imports system.IO
Imports C1.C1Excel

Public Class sintages
    Private Sub C1Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        sintages_add.Show()
    End Sub

    Private Sub C1Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button3.Click
        If Me.C1TrueDBGrid1.RowCount < 1 Then
            MessageBox.Show("Δεν υπάρχουν διαθέσιμες εγγραφές για διαγραφή.")
            Exit Sub
        End If

        If MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγράψετε την συνταγή:" & _
        Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row), "Διαχείριση συνταγών", MessageBoxButtons.YesNo) _
        = Windows.Forms.DialogResult.Yes Then

            SqlCommand1.Parameters.Clear()
            With SqlCommand1
                .Parameters.AddWithValue("code", Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row))
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

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Dim irows1 As Integer, istr As String, irows2 As Integer
        If Me.C1TrueDBGrid1.RowCount < 1 Then Exit Sub
        first_time = 1
        sintages_update.Show()
        clear_form_sintages_update()
        istr = "'" & Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row) & "'"
        Me.table_sintages_details.FillFilter = "[code_sintagi]=" & istr
        Me.table_sintages_details.DataTable.DataSet.Fill()
        irows1 = Me.table_sintages_details.DataTable.Rows.Count
        If irows1 > 0 Then
            Select Case irows1
                'case 1 farmako
                Case 1
                    If Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111111" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111112" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111113" Then
                        sintages_update.CheckBox6.Checked = True
                        sintages_update.C1TextBox7.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) & "1"
                        sintages_update.C1TextBox16.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(3)
                        sintages_update.C1TextBox17.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(4)
                        sintages_update.C1TextBox18.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(5)
                        sintages_update.C1NumericEdit1.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(2)
                        sintages_update.C1Combo1.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(0).Item(6)
                    Else
                        sintages_update.C1TextBox7.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) & "1"
                        sintages_update.C1TextBox16.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(3)
                        sintages_update.C1TextBox17.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(4)
                        sintages_update.C1TextBox18.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(5)
                        sintages_update.C1NumericEdit1.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(2)
                        sintages_update.C1Combo1.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(0).Item(6)
                        'Boxes
                        irows2 = 0
                        Me.table_boxes.FillFilter = "[code_sintagi]=" & istr
                        Me.table_boxes.DataTable.DataSet.Fill()
                        irows2 = Me.table_boxes.DataTable.Rows.Count

                        Select Case irows2
                            Case 1
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                            Case 2
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                            Case 3
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox32.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                            Case 4
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox32.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                                sintages_update.C1TextBox33.Value = Me.table_boxes.DataTable.Rows.Item(3).Item(2)
                        End Select
                    End If
                    'case 2 farmaka
                Case 2
                    If Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111111" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111112" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111113" Then
                        sintages_update.CheckBox6.Checked = True
                        sintages_update.C1TextBox7.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) & "1"
                        sintages_update.C1TextBox16.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(3)
                        sintages_update.C1TextBox17.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(4)
                        sintages_update.C1TextBox18.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(5)
                        sintages_update.C1NumericEdit1.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(2)
                        sintages_update.C1Combo1.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(0).Item(6)
                    Else
                        sintages_update.C1TextBox7.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) & "1"
                        '1o
                        sintages_update.C1TextBox16.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(3)
                        sintages_update.C1TextBox17.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(4)
                        sintages_update.C1TextBox18.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(5)
                        sintages_update.C1NumericEdit1.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(2)
                        sintages_update.C1Combo1.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(0).Item(6)
                        '1o farmako boxes
                        irows2 = 0
                        Me.table_boxes.FillFilter = "[code_sintagi]=" & istr & " and [farmako]='" & Me.table_sintages_details.DataTable.Rows.Item(0).Item(1) & "'"
                        Me.table_boxes.DataTable.DataSet.Fill()
                        irows2 = Me.table_boxes.DataTable.Rows.Count
                        Select Case irows2
                            Case 1
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                            Case 2
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                            Case 3
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox32.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                            Case 4
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox32.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                                sintages_update.C1TextBox33.Value = Me.table_boxes.DataTable.Rows.Item(3).Item(2)
                        End Select
                    End If
                    If Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) = "111111111" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) = "111111112" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) = "111111113" Then
                        sintages_update.CheckBox7.Checked = True
                        sintages_update.C1TextBox21.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) & "1"
                        sintages_update.C1TextBox19.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(3)
                        sintages_update.C1TextBox8.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(4)
                        sintages_update.C1TextBox9.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(5)
                        sintages_update.C1NumericEdit2.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(2)
                        sintages_update.C1Combo2.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(1).Item(6)
                    Else
                        sintages_update.C1TextBox21.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) & "1"
                        '2o
                        sintages_update.C1TextBox19.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(3)
                        sintages_update.C1TextBox8.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(4)
                        sintages_update.C1TextBox9.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(5)
                        sintages_update.C1NumericEdit2.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(2)
                        sintages_update.C1Combo2.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(1).Item(6)
                        '2o farmako boxes
                        irows2 = 0
                        Me.table_boxes.FillFilter = "[code_sintagi]=" & istr & " and [farmako]='" & Me.table_sintages_details.DataTable.Rows.Item(1).Item(1) & "'"
                        Me.table_boxes.DataTable.DataSet.Fill()
                        irows2 = Me.table_boxes.DataTable.Rows.Count
                        Select Case irows2
                            Case 1
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                            Case 2
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox35.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                            Case 3
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox35.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox36.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                            Case 4
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox35.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox36.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                                sintages_update.C1TextBox37.Value = Me.table_boxes.DataTable.Rows.Item(3).Item(2)
                        End Select
                    End If

                    'case 3 farmaka
                Case 3
                    If Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111111" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111112" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) = "111111113" Then
                        sintages_update.CheckBox6.Checked = True
                        sintages_update.C1TextBox7.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) & "1"
                        sintages_update.C1TextBox16.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(3)
                        sintages_update.C1TextBox17.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(4)
                        sintages_update.C1TextBox18.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(5)
                        sintages_update.C1NumericEdit1.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(2)
                        sintages_update.C1Combo1.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(0).Item(6)
                    Else
                        sintages_update.C1TextBox7.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(0).Item(1)) & "1"
                        '1o
                        sintages_update.C1TextBox16.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(3)
                        sintages_update.C1TextBox17.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(4)
                        sintages_update.C1TextBox18.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(5)
                        sintages_update.C1NumericEdit1.Value = Me.table_sintages_details.DataTable.Rows.Item(0).Item(2)
                        sintages_update.C1Combo1.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(0).Item(6)
                        '1o farmako boxes
                        irows2 = 0
                        Me.table_boxes.FillFilter = "[code_sintagi]=" & istr & " and [farmako]='" & Me.table_sintages_details.DataTable.Rows.Item(0).Item(1) & "'"
                        Me.table_boxes.DataTable.DataSet.Fill()
                        irows2 = Me.table_boxes.DataTable.Rows.Count
                        Select Case irows2
                            Case 1
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                            Case 2
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                            Case 3
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox32.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                            Case 4
                                sintages_update.C1TextBox30.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox31.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox32.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                                sintages_update.C1TextBox33.Value = Me.table_boxes.DataTable.Rows.Item(3).Item(2)
                        End Select
                    End If
                    If Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) = "111111111" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) = "111111112" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) = "111111113" Then
                        sintages_update.CheckBox7.Checked = True
                        sintages_update.C1TextBox21.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) & "1"
                        sintages_update.C1TextBox19.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(3)
                        sintages_update.C1TextBox8.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(4)
                        sintages_update.C1TextBox9.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(5)
                        sintages_update.C1NumericEdit2.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(2)
                        sintages_update.C1Combo2.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(1).Item(6)
                    Else
                        sintages_update.C1TextBox21.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(1).Item(1)) & "1"
                        '2o
                        sintages_update.C1TextBox19.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(3)
                        sintages_update.C1TextBox8.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(4)
                        sintages_update.C1TextBox9.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(5)
                        sintages_update.C1NumericEdit2.Value = Me.table_sintages_details.DataTable.Rows.Item(1).Item(2)
                        sintages_update.C1Combo2.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(1).Item(6)
                        '2o farmako boxes
                        irows2 = 0
                        Me.table_boxes.FillFilter = "[code_sintagi]=" & istr & " and [farmako]='" & Me.table_sintages_details.DataTable.Rows.Item(1).Item(1) & "'"
                        Me.table_boxes.DataTable.DataSet.Fill()
                        irows2 = Me.table_boxes.DataTable.Rows.Count
                        Select Case irows2
                            Case 1
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                            Case 2
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox35.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                            Case 3
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox35.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox36.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                            Case 4
                                sintages_update.C1TextBox34.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox35.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox36.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                                sintages_update.C1TextBox37.Value = Me.table_boxes.DataTable.Rows.Item(3).Item(2)
                        End Select
                    End If
                    If Trim(Me.table_sintages_details.DataTable.Rows.Item(2).Item(1)) = "111111111" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(2).Item(1)) = "111111112" Or Trim(Me.table_sintages_details.DataTable.Rows.Item(2).Item(1)) = "111111113" Then
                        sintages_update.CheckBox8.Checked = True
                        sintages_update.C1TextBox22.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(2).Item(1)) & "1"
                        sintages_update.C1TextBox20.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(3)
                        sintages_update.C1TextBox10.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(4)
                        sintages_update.C1TextBox11.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(5)
                        sintages_update.C1NumericEdit3.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(2)
                        sintages_update.C1Combo3.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(2).Item(6)
                    Else
                        sintages_update.C1TextBox22.Value = "280" & Trim(Me.table_sintages_details.DataTable.Rows.Item(2).Item(1)) & "1"
                        '3o
                        sintages_update.C1TextBox20.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(3)
                        sintages_update.C1TextBox10.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(4)
                        sintages_update.C1TextBox11.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(5)
                        sintages_update.C1NumericEdit3.Value = Me.table_sintages_details.DataTable.Rows.Item(2).Item(2)
                        sintages_update.C1Combo3.SelectedValue = Me.table_sintages_details.DataTable.Rows.Item(2).Item(6)
                        '3o farmako boxes
                        irows2 = 0
                        Me.table_boxes.FillFilter = "[code_sintagi]=" & istr & " and [farmako]='" & Me.table_sintages_details.DataTable.Rows.Item(2).Item(1) & "'"
                        Me.table_boxes.DataTable.DataSet.Fill()
                        irows2 = Me.table_boxes.DataTable.Rows.Count
                        Select Case irows2
                            Case 1
                                sintages_update.C1TextBox38.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                            Case 2
                                sintages_update.C1TextBox38.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox39.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                            Case 3
                                sintages_update.C1TextBox38.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox39.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox40.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                            Case 4
                                sintages_update.C1TextBox38.Value = Me.table_boxes.DataTable.Rows.Item(0).Item(2)
                                sintages_update.C1TextBox39.Value = Me.table_boxes.DataTable.Rows.Item(1).Item(2)
                                sintages_update.C1TextBox40.Value = Me.table_boxes.DataTable.Rows.Item(2).Item(2)
                                sintages_update.C1TextBox41.Value = Me.table_boxes.DataTable.Rows.Item(3).Item(2)
                        End Select
                    End If
            End Select

        End If

        old_code = Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox1.Value = Me.C1TrueDBGrid1.Columns(0).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox2.Text = Me.C1TrueDBGrid1.Columns(1).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox3.Text = Me.C1TrueDBGrid1.Columns(2).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox4.Text = Me.C1TrueDBGrid1.Columns(3).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1DateEdit1.Value = Me.C1TrueDBGrid1.Columns(4).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1DateEdit2.Value = Me.C1TrueDBGrid1.Columns(5).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox5.Text = Me.C1TrueDBGrid1.Columns(6).CellText(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox6.Text = Me.C1TrueDBGrid1.Columns(7).CellText(Me.C1TrueDBGrid1.Row)

        sintages_update.C1TextBox12.Value = Me.C1TrueDBGrid1.Columns(8).CellValue(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox13.Value = Me.C1TrueDBGrid1.Columns(9).CellValue(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox14.Value = Me.C1TrueDBGrid1.Columns(10).CellValue(Me.C1TrueDBGrid1.Row)
        sintages_update.C1TextBox23.Value = Me.C1TrueDBGrid1.Columns(11).CellValue(Me.C1TrueDBGrid1.Row)

        If Me.C1TrueDBGrid1.Columns(12).CellText(Me.C1TrueDBGrid1.Row) = "0" Then
            sintages_update.CheckBox1.Checked = False
        Else
            sintages_update.CheckBox1.Checked = True
        End If
        first_time = 0
        
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
            .PageHeader = "Διαχείριση Συνταγών: Εκτύπωση στις " & Today
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
        sheet.Name = "Συνταγές"

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

    Private Sub sintages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icnt As Double, sum1 As Double, sum2 As Double, sum3 As Double, sum4 As Double

        Me.C1TrueDBGrid1.DataSource = Nothing

        Me.C1ExpressTable1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_boxes.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_sintages_details.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        Me.C1ExpressTable1.DbTableName = "sintages"
        Me.table_sintages_details.DbTableName = "sintages_details"
        Me.table_boxes.DbTableName = "boxes"

        Me.C1ExpressTable1.ExpressConnection.Fill()
        Me.table_boxes.ExpressConnection.Fill()
        Me.table_sintages_details.ExpressConnection.Fill()

        Me.C1TrueDBGrid1.DataSource = Me.C1ExpressTable1


        'Me.C1TrueDBGrid1.Splits(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        Me.C1TrueDBGrid1.Columns(0).Caption = "Κωδικός Συνταγής"
        Me.C1TrueDBGrid1.Columns(1).Caption = "Ιατρός"
        Me.C1TrueDBGrid1.Columns(2).Caption = "Ασφαλισμένος"
        Me.C1TrueDBGrid1.Columns(3).Caption = "Φαρμακείο"
        Me.C1TrueDBGrid1.Columns(4).Caption = "Ημ. Έκδοσης"
        Me.C1TrueDBGrid1.Columns(5).Caption = "Ημ. Εκτέλεσης"
        Me.C1TrueDBGrid1.Columns(6).Caption = "Διάγνωση"
        Me.C1TrueDBGrid1.Columns(7).Caption = "Παρατηρήσεις"
        Me.C1TrueDBGrid1.Columns(8).Caption = "Σύνολο"
        Me.C1TrueDBGrid1.Columns(9).Caption = "Σύνολο Συμμετοχής"
        Me.C1TrueDBGrid1.Columns(10).Caption = "Αιτούμενο"
        Me.C1TrueDBGrid1.Columns(11).Caption = "Διαφορά"
        Me.C1TrueDBGrid1.Columns(12).Caption = "Κλινική"
        Me.C1TrueDBGrid1.Columns(13).Caption = "Χρήστης"

        Me.C1TrueDBGrid1.Columns(8).NumberFormat = "C2"
        Me.C1TrueDBGrid1.Columns(9).NumberFormat = "C2"
        Me.C1TrueDBGrid1.Columns(10).NumberFormat = "C2"
        Me.C1TrueDBGrid1.Columns(11).NumberFormat = "C2"

        Me.C1TextBox1.Value = Me.C1TrueDBGrid1.RowCount
        For icnt = 0 To Me.C1TrueDBGrid1.RowCount - 1
            sum1 = sum1 + Me.C1TrueDBGrid1.Columns(8).CellValue(icnt)
            sum2 = sum2 + Me.C1TrueDBGrid1.Columns(9).CellValue(icnt)
            sum3 = sum3 + Me.C1TrueDBGrid1.Columns(10).CellValue(icnt)
            sum4 = sum4 + Me.C1TrueDBGrid1.Columns(11).CellValue(icnt)
        Next
        Me.C1TextBox2.Value = sum1
        Me.C1TextBox3.Value = sum2
        Me.C1TextBox4.Value = sum3
        Me.C1TextBox5.Value = sum4
    End Sub

    Private Sub C1ExpressTable1_AfterFill(ByVal sender As Object, ByVal e As C1.Data.FillEventArgs)
        Dim icnt As Double, sum1 As Double, sum2 As Double, sum3 As Double, sum4 As Double

        Me.C1TextBox1.Value = Me.C1TrueDBGrid1.RowCount
        For icnt = 0 To Me.C1TrueDBGrid1.RowCount - 1
            sum1 = sum1 + Me.C1TrueDBGrid1.Columns(8).CellValue(icnt)
            sum2 = sum2 + Me.C1TrueDBGrid1.Columns(9).CellValue(icnt)
            sum3 = sum3 + Me.C1TrueDBGrid1.Columns(10).CellValue(icnt)
            sum4 = sum4 + Me.C1TrueDBGrid1.Columns(11).CellValue(icnt)
        Next
        Me.C1TextBox2.Value = sum1
        Me.C1TextBox3.Value = sum2
        Me.C1TextBox4.Value = sum3
        Me.C1TextBox5.Value = sum4

    End Sub

    Private Sub C1TrueDBGrid1_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1TrueDBGrid1.AfterFilter
        Dim icnt As Double, sum1 As Double, sum2 As Double, sum3 As Double, sum4 As Double

        Me.C1TextBox1.Value = Me.C1TrueDBGrid1.RowCount
        For icnt = 0 To Me.C1TrueDBGrid1.RowCount - 1
            sum1 = sum1 + Me.C1TrueDBGrid1.Columns(8).CellValue(icnt)
            sum2 = sum2 + Me.C1TrueDBGrid1.Columns(9).CellValue(icnt)
            sum3 = sum3 + Me.C1TrueDBGrid1.Columns(10).CellValue(icnt)
            sum4 = sum4 + Me.C1TrueDBGrid1.Columns(11).CellValue(icnt)
        Next
        Me.C1TextBox2.Value = sum1
        Me.C1TextBox3.Value = sum2
        Me.C1TextBox4.Value = sum3
        Me.C1TextBox5.Value = sum4
    End Sub
End Class
