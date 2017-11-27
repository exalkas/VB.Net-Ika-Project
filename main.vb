Public Class main

    Private Sub ÐáñÜìåôñïéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÐáñÜìåôñïéToolStripMenuItem.Click

    End Sub

    Private Sub main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        login.Close()
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_parameters()
        'Me.sintages_old.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        'Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        'Me.sintages_old.DbTableName = "sintages_old"

        'Me.sintages_old.ExpressConnection.Fill()


    End Sub

    Private Sub ÓõãêåíôñùôéêÝòÖáñìáêåßùíToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÓõãêåíôñùôéêÝòÖáñìáêåßùíToolStripMenuItem.Click
        sigedrotiki.Show()
    End Sub

    Private Sub ÖÜñìáêáToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖÜñìáêáToolStripMenuItem.Click
        farmaka.Show()
    End Sub

    Private Sub ÉáôñïßToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÉáôñïßToolStripMenuItem.Click
        doctors.Show()
    End Sub

    Private Sub ÖáñìáêåßáToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖáñìáêåßáToolStripMenuItem.Click
        farmakeia.Show()
    End Sub

    Private Sub ÁóöáëéóìÝíïéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÁóöáëéóìÝíïéToolStripMenuItem.Click
        asfalismenoi.Show()
    End Sub

    Private Sub MigrateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MigrateToolStripMenuItem.Click
        parameters.Show()
        'Dim icnt1 As Integer
        'SqlConnection1.Open()

        'For icnt1 = 0 To Me.sintages_old.DataTable.Rows.Count - 1
        '    SqlCommand1.Parameters.Clear()
        '    SqlCommand1.Parameters.AddWithValue("code", Me.sintages_old.DataTable.Rows.Item(icnt1).Item(0))

        '    SqlCommand1.ExecuteNonQuery()
        'Next

        'SqlConnection1.Close()
    End Sub

    Private Sub Ïðôéêüò¸ëåã÷ïòToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ïðôéêüò¸ëåã÷ïòToolStripMenuItem.Click
        visual.Show()
    End Sub

    Private Sub ChangeStructureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeStructureToolStripMenuItem.Click
        Dim i As Int64, icnt As Int16
        Me.C1ExpressTable1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_iatroi.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.table_sintages_details.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString
        Me.SqlConnection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("cnn").ConnectionString

        Me.table_iatroi.DbTableName = "iatroi"
        Me.C1ExpressTable1.DbTableName = "sintages"
        Me.table_sintages_details.DbTableName = "sintages_details"

        Me.table_iatroi.ExpressConnection.Fill()
        Me.C1ExpressTable1.ExpressConnection.Fill()
        Me.table_sintages_details.ExpressConnection.Fill()
        SqlConnection1.Open()

        For i = 0 To Me.C1ExpressTable1.DataTable.Rows.Count - 1
            Me.table_iatroi.FillFilter = "[code]='" & Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(1) & "'"
            Me.table_iatroi.DataTable.DataSet.Fill()

            Me.table_sintages_details.FillFilter = "[code_sintagi]='" & Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(0) & "'"
            Me.table_sintages_details.DataTable.DataSet.Fill()

            icnt = Me.table_sintages_details.DataTable.Rows.Count
            Select Case icnt
                Case 1

                    SqlCommand1.Parameters.Clear()
                    SqlCommand1.Parameters.AddWithValue("code_sintagi", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(0))
                    SqlCommand1.Parameters.AddWithValue("doctor", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(1))
                    If Me.table_iatroi.DataTable.Rows.Count > 0 Then
                        SqlCommand1.Parameters.AddWithValue("doctor_name", Me.table_iatroi.DataTable.Rows.Item(0).Item(2))
                    Else
                        SqlCommand1.Parameters.AddWithValue("doctor_name", "UNKNOWN")
                    End If

                    If Me.table_iatroi.DataTable.Rows.Count > 0 Then
                        SqlCommand1.Parameters.AddWithValue("doctor_surname", Me.table_iatroi.DataTable.Rows.Item(0).Item(1))
                    Else
                        SqlCommand1.Parameters.AddWithValue("doctor_surname", "UNKNOWN")

                    End If
                    SqlCommand1.Parameters.AddWithValue("asfalismenos", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(2))
                    SqlCommand1.Parameters.AddWithValue("afm", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(3))
                    SqlCommand1.Parameters.AddWithValue("dmy_issue", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(4))
                    SqlCommand1.Parameters.AddWithValue("dmy_exec", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(5))
                    SqlCommand1.Parameters.AddWithValue("code_farmako1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(1))
                    SqlCommand1.Parameters.AddWithValue("amount1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(2))
                    SqlCommand1.Parameters.AddWithValue("price1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(3))
                    SqlCommand1.Parameters.AddWithValue("total1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(4))
                    SqlCommand1.Parameters.AddWithValue("amount_simmetoxi1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(5))
                    SqlCommand1.Parameters.AddWithValue("pososto1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(6))
                    SqlCommand1.Parameters.AddWithValue("total", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(8))
                    SqlCommand1.Parameters.AddWithValue("total_simmetoxi", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(9))
                    SqlCommand1.Parameters.AddWithValue("total_pay", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(10))
                    SqlCommand1.ExecuteNonQuery()


                Case 2
                    SqlCommand2.Parameters.Clear()
                    SqlCommand2.Parameters.AddWithValue("code_sintagi", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(0))
                    SqlCommand2.Parameters.AddWithValue("doctor", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(1))
                    If Me.table_iatroi.DataTable.Rows.Count > 0 Then
                        SqlCommand2.Parameters.AddWithValue("doctor_name", Me.table_iatroi.DataTable.Rows.Item(0).Item(2))
                    Else
                        SqlCommand2.Parameters.AddWithValue("doctor_name", "UNKNOWN")
                    End If

                    If Me.table_iatroi.DataTable.Rows.Count > 0 Then
                        SqlCommand2.Parameters.AddWithValue("doctor_surname", Me.table_iatroi.DataTable.Rows.Item(0).Item(1))
                    Else
                        SqlCommand2.Parameters.AddWithValue("doctor_surname", "UNKNOWN")

                    End If
                    SqlCommand2.Parameters.AddWithValue("asfalismenos", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(2))
                    SqlCommand2.Parameters.AddWithValue("afm", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(3))
                    SqlCommand2.Parameters.AddWithValue("dmy_issue", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(4))
                    SqlCommand2.Parameters.AddWithValue("dmy_exec", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(5))
                    SqlCommand2.Parameters.AddWithValue("code_farmako1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(1))
                    SqlCommand2.Parameters.AddWithValue("amount1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(2))
                    SqlCommand2.Parameters.AddWithValue("price1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(3))
                    SqlCommand2.Parameters.AddWithValue("total1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(4))
                    SqlCommand2.Parameters.AddWithValue("amount_simmetoxi1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(5))
                    SqlCommand2.Parameters.AddWithValue("pososto1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(6))

                    SqlCommand2.Parameters.AddWithValue("code_farmako2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(1))
                    SqlCommand2.Parameters.AddWithValue("amount2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(2))
                    SqlCommand2.Parameters.AddWithValue("price2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(3))
                    SqlCommand2.Parameters.AddWithValue("total2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(4))
                    SqlCommand2.Parameters.AddWithValue("amount_simmetoxi2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(5))
                    SqlCommand2.Parameters.AddWithValue("pososto2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(6))


                    SqlCommand2.Parameters.AddWithValue("total", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(8))
                    SqlCommand2.Parameters.AddWithValue("total_simmetoxi", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(9))
                    SqlCommand2.Parameters.AddWithValue("total_pay", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(10))
                    SqlCommand2.ExecuteNonQuery()
                Case 3
                    SqlCommand3.Parameters.Clear()
                    SqlCommand3.Parameters.AddWithValue("code_sintagi", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(0))
                    SqlCommand3.Parameters.AddWithValue("doctor", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(1))
                    If Me.table_iatroi.DataTable.Rows.Count > 0 Then
                        SqlCommand3.Parameters.AddWithValue("doctor_name", Me.table_iatroi.DataTable.Rows.Item(0).Item(2))
                    Else
                        SqlCommand3.Parameters.AddWithValue("doctor_name", "UNKNOWN")
                    End If

                    If Me.table_iatroi.DataTable.Rows.Count > 0 Then
                        SqlCommand3.Parameters.AddWithValue("doctor_surname", Me.table_iatroi.DataTable.Rows.Item(0).Item(1))
                    Else
                        SqlCommand3.Parameters.AddWithValue("doctor_surname", "UNKNOWN")

                    End If
                    SqlCommand3.Parameters.AddWithValue("asfalismenos", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(2))
                    SqlCommand3.Parameters.AddWithValue("afm", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(3))
                    SqlCommand3.Parameters.AddWithValue("dmy_issue", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(4))
                    SqlCommand3.Parameters.AddWithValue("dmy_exec", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(5))

                    SqlCommand3.Parameters.AddWithValue("code_farmako1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(1))
                    SqlCommand3.Parameters.AddWithValue("amount1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(2))
                    SqlCommand3.Parameters.AddWithValue("price1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(3))
                    SqlCommand3.Parameters.AddWithValue("total1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(4))
                    SqlCommand3.Parameters.AddWithValue("amount_simmetoxi1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(5))
                    SqlCommand3.Parameters.AddWithValue("pososto1", Me.table_sintages_details.DataTable.Rows.Item(0).Item(6))

                    SqlCommand3.Parameters.AddWithValue("code_farmako2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(1))
                    SqlCommand3.Parameters.AddWithValue("amount2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(2))
                    SqlCommand3.Parameters.AddWithValue("price2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(3))
                    SqlCommand3.Parameters.AddWithValue("total2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(4))
                    SqlCommand3.Parameters.AddWithValue("amount_simmetoxi2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(5))
                    SqlCommand3.Parameters.AddWithValue("pososto2", Me.table_sintages_details.DataTable.Rows.Item(1).Item(6))


                    SqlCommand3.Parameters.AddWithValue("code_farmako3", Me.table_sintages_details.DataTable.Rows.Item(2).Item(1))
                    SqlCommand3.Parameters.AddWithValue("amount3", Me.table_sintages_details.DataTable.Rows.Item(2).Item(2))
                    SqlCommand3.Parameters.AddWithValue("price3", Me.table_sintages_details.DataTable.Rows.Item(2).Item(3))
                    SqlCommand3.Parameters.AddWithValue("total3", Me.table_sintages_details.DataTable.Rows.Item(2).Item(4))
                    SqlCommand3.Parameters.AddWithValue("amount_simmetoxi3", Me.table_sintages_details.DataTable.Rows.Item(2).Item(5))
                    SqlCommand3.Parameters.AddWithValue("pososto3", Me.table_sintages_details.DataTable.Rows.Item(2).Item(6))

                    SqlCommand3.Parameters.AddWithValue("total", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(8))
                    SqlCommand3.Parameters.AddWithValue("total_simmetoxi", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(9))
                    SqlCommand3.Parameters.AddWithValue("total_pay", Me.C1ExpressTable1.DataTable.Rows.Item(i).Item(10))
                    SqlCommand3.ExecuteNonQuery()
                Case Else

            End Select
        Next
        SqlConnection1.Close()

    End Sub
End Class