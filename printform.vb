Imports C1.C1Preview
Public Class printform

    Private Sub printform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icnt1 As Integer, icnt2 As Integer
        Dim rt As New RenderTable()
        Dim rt1 As New RenderTable

        Dim caption1 As C1.C1Preview.RenderText = New C1.C1Preview.RenderText(Me.C1PrintDocument1)
        'Dim caption2 As C1.C1Preview.RenderText = New C1.C1Preview.RenderText(Me.C1PrintDocument1)
        'Dim caption3 As C1.C1Preview.RenderText = New C1.C1Preview.RenderText(Me.C1PrintDocument1)
        'Dim caption4 As C1.C1Preview.RenderText = New C1.C1Preview.RenderText(Me.C1PrintDocument1)
        'Dim caption5 As C1.C1Preview.RenderText = New C1.C1Preview.RenderText(Me.C1PrintDocument1)
        'Dim caption6 As C1.C1Preview.RenderText = New C1.C1Preview.RenderText(Me.C1PrintDocument1)

        Me.C1PrintDocument1.Body.Children.Add(caption1)
        Me.C1PrintDocument1.Body.Children.Add(rt)
        Me.C1PrintDocument1.Body.Children.Add(rt1)

        'Me.C1PrintDocument1.Body.Children.Add(caption2)

        'Me.C1PrintDocument1.Body.Children.Add(caption4)
        'Me.C1PrintDocument1.Body.Children.Add(caption5)
        'Me.C1PrintDocument1.Body.Children.Add(caption6)
        'Me.C1PrintDocument1.Body.Children.Add(caption3)

        rt.Cells.Item(0, 0).Text = "Ημερομηνία"
        rt.Cells.Item(0, 1).Text = "Σύνολο Συνταγών"
        rt.Cells.Item(0, 2).Text = "Συνταγές Κλινικών"
        rt.Cells.Item(0, 3).Text = "Σύνολο των 0%"
        rt.Cells.Item(0, 4).Text = "Σύνολο των 10%"
        rt.Cells.Item(0, 5).Text = "Σύνολο των 25%"

        For icnt1 = 1 To sigedrotiki.C1FlexGrid1.Rows.Count - 1
            For icnt2 = 1 To sigedrotiki.C1FlexGrid1.Cols.Count - 1
                If icnt2 > 3 Then
                    rt.Cells.Item(icnt1, icnt2 - 1).Text = Format(sigedrotiki.C1FlexGrid1.Item(icnt1, icnt2), "C")                 
                Else
                    rt.Cells.Item(icnt1, icnt2 - 1).Text = sigedrotiki.C1FlexGrid1.Item(icnt1, icnt2)
                End If

            Next
        Next
        rt.Style.GridLines.All = LineDef.Default
        rt.Style.Padding.Top = New C1.C1Preview.Unit(1, C1.C1Preview.UnitTypeEnum.Cm)
        rt1.Style.Padding.Top = New C1.C1Preview.Unit(1, C1.C1Preview.UnitTypeEnum.Cm)

        rt1.Cells.Item(1, 0).Text = "Σύνολο Συνταγών:"
        rt1.Cells.Item(2, 0).Text = "Σύνολο Κλινικών Συνταγών :"
        rt1.Cells.Item(5, 0).Text = "Μεικτά Σύνολα:"
        rt1.Cells.Item(6, 0).Text = "Μείον Συμμετοχή:"
        rt1.Cells.Item(7, 0).Text = "Υπόλοιπο:"
        rt1.Cells.Item(9, 0).Text = "Αιτούμενο Ποσό:"

        rt1.Cells.Item(4, 1).Text = "0%"
        rt1.Cells.Item(4, 2).Text = "10%"
        rt1.Cells.Item(4, 3).Text = "25%"

        rt1.Cells.Item(1, 1).Text = sigedrotiki.C1TextBox3.Text
        rt1.Cells.Item(2, 1).Text = sigedrotiki.C1TextBox13.Text
        rt1.Cells.Item(9, 1).Text = sigedrotiki.C1TextBox14.Text

        rt1.Cells.Item(5, 1).Text = sigedrotiki.C1TextBox4.Text
        rt1.Cells.Item(5, 2).Text = sigedrotiki.C1TextBox9.Text
        rt1.Cells.Item(5, 3).Text = sigedrotiki.C1TextBox12.Text

        rt1.Cells.Item(6, 1).Text = sigedrotiki.C1TextBox5.Text
        rt1.Cells.Item(6, 2).Text = sigedrotiki.C1TextBox8.Text
        rt1.Cells.Item(6, 3).Text = sigedrotiki.C1TextBox11.Text

        rt1.Cells.Item(7, 1).Text = sigedrotiki.C1TextBox6.Text
        rt1.Cells.Item(7, 2).Text = sigedrotiki.C1TextBox7.Text
        rt1.Cells.Item(7, 3).Text = sigedrotiki.C1TextBox10.Text

        caption1.Text = "Συγκεντρωτική Κατάσταση για το Φαρμακείο: " & sigedrotiki.C1TextBox2.Text & " με ΑΦΜ: " & sigedrotiki.C1TextBox1.Text
        'caption2.Text = "Σύνολο Συνταγών Κλινικών: " & ChrW(9) & sigedrotiki.C1TextBox13.Text
        'caption3.Text = "Αιτούμενο Ποσό: " & ChrW(9) & ChrW(9) & sigedrotiki.C1TextBox14.Text

        'caption4.Text = "Μεικτά Σύνολα: " & sigedrotiki.C1TextBox4.Text & ChrW(9) & ChrW(9) & ChrW(9) & sigedrotiki.C1TextBox9.Text & ChrW(9) & sigedrotiki.C1TextBox12.Text
        'caption5.Text = "Μείον Συμμετοχή: " & sigedrotiki.C1TextBox5.Text & ChrW(9) & ChrW(9) & ChrW(9) & sigedrotiki.C1TextBox8.Text & ChrW(9) & sigedrotiki.C1TextBox11.Text
        'caption6.Text = "Υπόλοιπο: " & sigedrotiki.C1TextBox6.Text & ChrW(9) & ChrW(9) & ChrW(9) & sigedrotiki.C1TextBox7.Text & ChrW(9) & sigedrotiki.C1TextBox10.Text

        Me.C1PrintDocument1.Generate()
    End Sub
End Class