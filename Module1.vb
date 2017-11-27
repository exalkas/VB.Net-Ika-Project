Module Module1
    Public old_code As String
    Public first_time As Int16
    Public clear_afm As Boolean
    Public usr_id As String
    Public connection_str As String
    Public add_enter As Boolean
    Public clear_checks As Boolean
    Public keep_dates As Boolean

    Public Sub calc_totals()
        sintages_add.C1TextBox12.Value = sintages_add.C1TextBox17.Value + sintages_add.C1TextBox8.Value + sintages_add.C1TextBox10.Value
        sintages_add.C1TextBox13.Value = sintages_add.C1TextBox18.Value + sintages_add.C1TextBox9.Value + sintages_add.C1TextBox11.Value
        sintages_add.C1TextBox14.Value = sintages_add.C1TextBox12.Value - sintages_add.C1TextBox13.Value
        If sintages_add.C1TextBox15.Value > 0 Then sintages_add.C1TextBox23.Value = sintages_add.C1TextBox14.Value - sintages_add.C1TextBox15.Value
    End Sub
    Public Sub calc_totals_update()
        If first_time = 1 Then Exit Sub
        sintages_update.C1TextBox12.Value = sintages_update.C1TextBox17.Value + sintages_update.C1TextBox8.Value + sintages_update.C1TextBox10.Value
        sintages_update.C1TextBox13.Value = sintages_update.C1TextBox18.Value + sintages_update.C1TextBox9.Value + sintages_update.C1TextBox11.Value
        sintages_update.C1TextBox14.Value = sintages_update.C1TextBox12.Value - sintages_update.C1TextBox13.Value
        If sintages_update.C1TextBox15.Value > 0 Then sintages_update.C1TextBox23.Value = sintages_update.C1TextBox14.Value - sintages_update.C1TextBox15.Value
    End Sub
    Public Sub clear_form_sintages_add()
        'Initialize dates
        If keep_dates = True Then sintages_add.C1DateEdit1.Value = Today
        If keep_dates = True Then sintages_add.C1DateEdit2.Value = Today

        sintages_add.C1TextBox1.Text = ""
        sintages_add.C1TextBox2.Text = ""
        sintages_add.C1TextBox3.Text = ""

        If clear_afm = True Then sintages_add.C1TextBox4.Text = ""
        sintages_add.CheckBox6.Checked = False
        sintages_add.CheckBox7.Checked = False
        sintages_add.CheckBox8.Checked = False
        sintages_add.C1TextBox5.Text = ""
        sintages_add.C1TextBox6.Text = ""
        sintages_add.C1TextBox7.Text = ""
        sintages_add.C1TextBox21.Text = ""
        sintages_add.C1TextBox22.Text = ""
        sintages_add.CheckBox1.Checked = False
        If clear_checks = True Then sintages_add.CheckBox2.Checked = False
        If clear_checks = True Then sintages_add.CheckBox3.Checked = False
        If clear_checks = True Then sintages_add.CheckBox4.Checked = False
        If clear_checks = True Then sintages_add.CheckBox5.Checked = False

        'Boxes
        sintages_add.C1TextBox30.Text = ""
        sintages_add.C1TextBox31.Text = ""
        sintages_add.C1TextBox32.Text = ""
        sintages_add.C1TextBox33.Text = ""
        sintages_add.C1TextBox34.Text = ""
        sintages_add.C1TextBox35.Text = ""
        sintages_add.C1TextBox36.Text = ""
        sintages_add.C1TextBox37.Text = ""
        sintages_add.C1TextBox38.Text = ""
        sintages_add.C1TextBox39.Text = ""
        sintages_add.C1TextBox40.Text = ""
        sintages_add.C1TextBox41.Text = ""

        'Farmako1
        sintages_add.C1TextBox16.ValueIsDbNull = False
        sintages_add.C1TextBox8.Value = 0
        sintages_add.C1TextBox9.Value = 0
        sintages_add.C1TextBox10.Value = 0
        sintages_add.C1TextBox11.Value = 0
        sintages_add.C1TextBox12.Value = 0
        sintages_add.C1TextBox13.Value = 0
        sintages_add.C1TextBox14.Value = 0
        sintages_add.C1TextBox15.Value = 0
        sintages_add.C1TextBox16.Value = 0
        sintages_add.C1TextBox17.Value = 0
        sintages_add.C1TextBox18.Value = 0
        sintages_add.C1TextBox19.Value = 0
        sintages_add.C1TextBox20.Value = 0
        sintages_add.C1TextBox23.Value = 0

        sintages_add.C1NumericEdit1.Value = 0
        sintages_add.C1NumericEdit2.Value = 0
        sintages_add.C1NumericEdit3.Value = 0
        sintages_add.C1Combo1.SelectedValue = sintages_add.table_simetoxi1.DataTable.Rows.Item(0).Item(0)
        sintages_add.C1Combo2.SelectedValue = sintages_add.table_simetoxi2.DataTable.Rows.Item(0).Item(0)
        sintages_add.C1Combo3.SelectedValue = sintages_add.table_simetoxi3.DataTable.Rows.Item(0).Item(0)
        sintages_add.C1TextBox1.Focus()

    End Sub
    Public Sub clear_form_sintages_update()
        'Initialize dates
        sintages_update.C1DateEdit1.Value = Today
        sintages_update.C1DateEdit2.Value = Today

        sintages_update.CheckBox6.Checked = False
        sintages_update.CheckBox7.Checked = False
        sintages_update.CheckBox8.Checked = False
        sintages_update.C1TextBox2.Text = ""
        sintages_update.C1TextBox3.Text = ""
        sintages_update.C1TextBox4.Text = ""
        sintages_update.C1TextBox5.Text = ""
        sintages_update.C1TextBox6.Text = ""
        sintages_update.C1TextBox7.Text = ""
        sintages_update.C1TextBox21.Text = ""
        sintages_update.C1TextBox22.Text = ""
        sintages_update.C1TextBox23.Value = 0
        sintages_update.CheckBox1.Checked = False
        sintages_update.CheckBox2.Checked = False
        sintages_update.CheckBox3.Checked = False
        sintages_update.CheckBox4.Checked = False
        sintages_update.CheckBox5.Checked = False

        'Boxes
        sintages_update.C1TextBox30.Text = ""
        sintages_update.C1TextBox31.Text = ""
        sintages_update.C1TextBox32.Text = ""
        sintages_update.C1TextBox33.Text = ""
        sintages_update.C1TextBox34.Text = ""
        sintages_update.C1TextBox35.Text = ""
        sintages_update.C1TextBox36.Text = ""
        sintages_update.C1TextBox37.Text = ""
        sintages_update.C1TextBox38.Text = ""
        sintages_update.C1TextBox39.Text = ""
        sintages_update.C1TextBox40.Text = ""
        sintages_update.C1TextBox41.Text = ""

        'Farmako1
        sintages_update.C1TextBox16.ValueIsDbNull = False
        sintages_update.C1TextBox8.Value = 0
        sintages_update.C1TextBox9.Value = 0
        sintages_update.C1TextBox10.Value = 0
        sintages_update.C1TextBox11.Value = 0
        sintages_update.C1TextBox12.Value = 0
        sintages_update.C1TextBox13.Value = 0
        sintages_update.C1TextBox14.Value = 0
        sintages_update.C1TextBox15.Value = 0
        sintages_update.C1TextBox16.Value = 0
        sintages_update.C1TextBox17.Value = 0
        sintages_update.C1TextBox18.Value = 0
        sintages_update.C1TextBox19.Value = 0
        sintages_update.C1TextBox20.Value = 0

        sintages_update.C1NumericEdit1.Value = 0
        sintages_update.C1NumericEdit2.Value = 0
        sintages_update.C1NumericEdit3.Value = 0
        sintages_update.C1Combo1.SelectedValue = sintages_update.table_simetoxi1.DataTable.Rows.Item(0).Item(0)
        sintages_update.C1Combo2.SelectedValue = sintages_update.table_simetoxi2.DataTable.Rows.Item(0).Item(0)
        sintages_update.C1Combo3.SelectedValue = sintages_update.table_simetoxi3.DataTable.Rows.Item(0).Item(0)
        sintages_update.C1TextBox2.Focus()
    End Sub
    Public Sub get_parameters()
        Dim clearafm As String, addenter As String, clearchecks As String, keepdates As String

        clearafm = My.Settings.clearafm
        If clearafm = "TRUE" Then
            clear_afm = True
        Else
            clear_afm = False
        End If

        addenter = My.Settings.addenter
        If addenter = "TRUE" Then
            add_enter = True
        Else
            add_enter = False
        End If

        clearchecks = My.Settings.clearchecks
        If clearchecks = "TRUE" Then
            clear_checks = True
        Else
            clear_checks = False
        End If

        keepdates = My.Settings.keepdates
        If keepdates = "TRUE" Then
            keep_dates = True
        Else
            keep_dates = False
        End If


    End Sub
    Public Sub clear_asfalismenoi_add()
        asfalismenoi_add.C1TextBox1.Text = ""
        asfalismenoi_add.C1TextBox2.Text = ""
        asfalismenoi_add.C1TextBox3.Text = ""
        asfalismenoi_add.C1TextBox4.Text = ""
        asfalismenoi_add.C1TextBox5.Text = ""
        asfalismenoi_add.C1TextBox6.Text = ""
        asfalismenoi_add.C1TextBox7.Text = ""
        'asfalismenoi_add.C1TextBox8.Text = ""
        'asfalismenoi_add.C1TextBox9.Text = ""
        'asfalismenoi_add.C1TextBox10.Text = ""
        'asfalismenoi_add.C1TextBox11.Text = ""
        'asfalismenoi_add.C1TextBox12.Text = ""
        asfalismenoi_add.C1TextBox1.Focus()
    End Sub
    Public Sub clear_asfalismenoi_update()
        asfalismenoi_update.C1TextBox2.Text = ""
        asfalismenoi_update.C1TextBox3.Text = ""
        asfalismenoi_update.C1TextBox4.Text = ""
        asfalismenoi_update.C1TextBox5.Text = ""
        asfalismenoi_update.C1TextBox6.Text = ""
        asfalismenoi_update.C1TextBox7.Text = ""
        'asfalismenoi_update.C1TextBox8.Text = ""
        'asfalismenoi_update.C1TextBox9.Text = ""
        'asfalismenoi_update.C1TextBox10.Text = ""
        'asfalismenoi_update.C1TextBox11.Text = ""
        'asfalismenoi_update.C1TextBox12.Text = ""
        asfalismenoi_update.C1TextBox2.Focus()
    End Sub
    Public Sub clear_doctors_add()
        doctors_add.C1TextBox1.Text = ""
        doctors_add.C1TextBox2.Text = ""
        doctors_add.C1TextBox3.Text = ""
        doctors_add.C1TextBox4.Text = ""
        doctors_add.C1TextBox5.Text = ""
        doctors_add.C1DateEdit1.Value = Today
        doctors_add.CheckBox1.Checked = False
        doctors_add.C1TextBox1.Focus()
    End Sub
    Public Sub clear_doctors_update()
        doctors_update.C1TextBox2.Text = ""
        doctors_update.C1TextBox3.Text = ""
        doctors_update.C1TextBox4.Text = ""
        doctors_update.C1TextBox5.Text = ""
        doctors_update.C1DateEdit1.Value = Today
        doctors_update.CheckBox1.Checked = False
        doctors_update.C1TextBox2.Focus()
    End Sub
    Public Sub clear_farmaka_add()
        farmaka_add.C1TextBox1.Text = ""
        farmaka_add.C1TextBox2.Text = ""
        farmaka_add.C1TextBox3.Text = ""
        farmaka_add.C1TextBox4.Text = ""
        farmaka_add.C1TextBox5.Text = ""
        farmaka_add.C1TextBox6.Value = 0
        farmaka_add.C1TextBox7.Value = 0
        farmaka_add.C1TextBox8.Value = 0
        farmaka_add.C1TextBox1.Focus()
    End Sub
    Public Sub clear_farmaka_update()
        farmaka_update.C1TextBox1.Text = ""
        farmaka_update.C1TextBox3.Text = ""
        farmaka_update.C1TextBox4.Text = ""
        farmaka_update.C1TextBox5.Text = ""
        farmaka_update.C1TextBox6.Value = 0
        farmaka_update.C1TextBox7.Value = 0
        farmaka_update.C1TextBox8.Value = 0
        farmaka_update.C1TextBox1.Focus()
    End Sub
    Public Sub clear_farmakeia_add()
        farmakeia_add.C1TextBox1.Text = ""
        farmakeia_add.C1TextBox2.Text = ""
        farmakeia_add.C1TextBox3.Text = ""
        farmakeia_add.C1TextBox1.Focus()
    End Sub
    Public Sub clear_farmakeia_update()
        farmakeia_update.C1TextBox1.Text = ""
        farmakeia_update.C1TextBox3.Text = ""
        farmakeia_update.C1TextBox2.Text = ""
    End Sub
    Public Sub clear_visual()
        Dim icnt As Integer, idate As DateTime, icnt2 As Integer, icnt3 As Integer

        idate = visual_add.C1DateEdit1.Value
        icnt2 = idate.DaysInMonth(Format(visual_add.C1DateEdit1.Value, "yyyy"), Format(visual_add.C1DateEdit1.Value, "MM"))
        For icnt = 1 To visual_add.C1FlexGrid1.Rows.Count - 1
            visual_add.C1FlexGrid1.Rows.Remove(1)
        Next
        For icnt = 1 To icnt2
            visual_add.C1FlexGrid1.Rows.Add(1)
        Next
        For icnt = 1 To icnt2
            visual_add.C1FlexGrid1.Item(icnt, 1) = DateSerial(Format(visual_add.C1DateEdit1.Value, "yyyy"), Format(visual_add.C1DateEdit1.Value, "MM"), icnt)
        Next
        For icnt = 1 To icnt2
            For icnt3 = 1 To visual_add.C1FlexGrid1.Cols.Count - 1
                visual_add.C1FlexGrid1.Item(icnt, icnt3) = 0
            Next
        Next
        visual_add.C1TextBox1.Text = ""
        visual_add.C1TextBox2.Value = "Παρακαλώ επιλέξτε Φαρμακείο"
        visual_add.C1TextBox3.Value = 0
        visual_add.C1TextBox5.Value = 0
        visual_add.C1TextBox6.Value = 0
        visual_add.C1TextBox7.Value = 0
        visual_add.C1TextBox8.Value = 0
        visual_add.C1TextBox9.Value = 0
        visual_add.C1TextBox10.Value = 0
        visual_add.C1TextBox11.Value = 0
        visual_add.C1TextBox12.Value = 0
        visual_add.C1TextBox14.Value = 0
        visual_add.C1TextBox15.Value = 0
        visual_add.C1NumericEdit1.Value = 0

    End Sub
    Public Sub calc_totals_visual()
        Dim icnt As Integer, icntx As Integer
        visual_add.C1TextBox4.Value = visual_add.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 4, visual_add.C1FlexGrid1.Rows.Count - 1, 4)
        visual_add.C1TextBox9.Value = visual_add.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 5, visual_add.C1FlexGrid1.Rows.Count - 1, 5)
        visual_add.C1TextBox12.Value = visual_add.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 6, visual_add.C1FlexGrid1.Rows.Count - 1, 6)

        visual_add.C1TextBox5.Value = 0
        visual_add.C1TextBox6.Value = visual_add.C1TextBox4.Value - visual_add.C1TextBox5.Value
        visual_add.C1TextBox8.Value = visual_add.C1TextBox9.Value * 0.1
        visual_add.C1TextBox7.Value = visual_add.C1TextBox9.Value - visual_add.C1TextBox8.Value
        visual_add.C1TextBox11.Value = visual_add.C1TextBox12.Value * 0.25
        visual_add.C1TextBox10.Value = visual_add.C1TextBox12.Value - visual_add.C1TextBox11.Value
        visual_add.C1TextBox14.Value = visual_add.C1TextBox6.Value + visual_add.C1TextBox7.Value + visual_add.C1TextBox10.Value
        For icnt = 1 To visual_add.C1FlexGrid1.Rows.Count - 1
            If visual_add.C1FlexGrid1.Item(icnt, 2) <> 0 And visual_add.C1FlexGrid1.Item(icnt, 3) <> 0 Then
                icntx = icntx + (visual_add.C1FlexGrid1.Item(icnt, 3) - visual_add.C1FlexGrid1.Item(icnt, 2) + 1)
            End If
        Next
        visual_add.C1TextBox3.Value = icntx
    End Sub
End Module
