Imports System.Data.SqlClient
Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()
        Chart1.Series(3).Points.Clear()

        Label21.Text = "MIN: 1.9%"
        Label22.Text = "NOMINAL: 2.2%"
        Label23.Text = "MAX: 2.5%"

        Chart1.Series("% FLUX").Points.AddXY("1st", TextBox7.Text)
        Chart1.Series("% FLUX").Points.AddXY("2nd", TextBox8.Text)
        Chart1.Series("% FLUX").Points.AddXY("3rd", TextBox9.Text)
        Chart1.Series("% FLUX").Points.AddXY("4th", TextBox10.Text)
        Chart1.Series("% FLUX").Points.AddXY("5th", TextBox13.Text)
        Chart1.Series("% FLUX").Points.AddXY("6th", TextBox16.Text)
        Chart1.Series("% FLUX").Points.AddXY("7th", TextBox17.Text)
        Chart1.Series("% FLUX").Points.AddXY("8th", TextBox18.Text)

        Chart1.Series("MAX").Points.AddXY("1st", 2.5)
        Chart1.Series("MAX").Points.AddXY("2nd", 2.5)
        Chart1.Series("MAX").Points.AddXY("3rd", 2.5)
        Chart1.Series("MAX").Points.AddXY("4th", 2.5)
        Chart1.Series("MAX").Points.AddXY("5th", 2.5)
        Chart1.Series("MAX").Points.AddXY("6th", 2.5)
        Chart1.Series("MAX").Points.AddXY("7th", 2.5)
        Chart1.Series("MAX").Points.AddXY("8th", 2.5)

        Chart1.Series("MIN").Points.AddXY("1st", 1.9)
        Chart1.Series("MIN").Points.AddXY("2nd", 1.9)
        Chart1.Series("MIN").Points.AddXY("3rd", 1.9)
        Chart1.Series("MIN").Points.AddXY("4th", 1.9)
        Chart1.Series("MIN").Points.AddXY("5th", 1.9)
        Chart1.Series("MIN").Points.AddXY("6th", 1.9)
        Chart1.Series("MIN").Points.AddXY("7th", 1.9)
        Chart1.Series("MIN").Points.AddXY("8th", 1.9)

        Chart1.Series("NOMINAL").Points.AddXY("1st", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("2nd", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("3rd", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("4th", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("5th", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("6th", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("7th", 2.2)
        Chart1.Series("NOMINAL").Points.AddXY("8th", 2.2)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()
        Chart1.Series(3).Points.Clear()

        Label21.Text = "MIN: 0.4%"
        Label22.Text = "NOMINAL: 0.6%"
        Label23.Text = "MAX: 0.8%"

        Chart1.Series("% FLUX").Points.AddXY("1st", TextBox7.Text)
        Chart1.Series("% FLUX").Points.AddXY("2nd", TextBox8.Text)
        Chart1.Series("% FLUX").Points.AddXY("3rd", TextBox9.Text)
        Chart1.Series("% FLUX").Points.AddXY("4th", TextBox10.Text)
        Chart1.Series("% FLUX").Points.AddXY("5th", TextBox13.Text)
        Chart1.Series("% FLUX").Points.AddXY("6th", TextBox16.Text)
        Chart1.Series("% FLUX").Points.AddXY("7th", TextBox17.Text)
        Chart1.Series("% FLUX").Points.AddXY("8th", TextBox18.Text)

        Chart1.Series("MAX").Points.AddXY("1st", 0.8)
        Chart1.Series("MAX").Points.AddXY("2nd", 0.8)
        Chart1.Series("MAX").Points.AddXY("3rd", 0.8)
        Chart1.Series("MAX").Points.AddXY("4th", 0.8)
        Chart1.Series("MAX").Points.AddXY("5th", 0.8)
        Chart1.Series("MAX").Points.AddXY("6th", 0.8)
        Chart1.Series("MAX").Points.AddXY("7th", 0.8)
        Chart1.Series("MAX").Points.AddXY("8th", 0.8)

        Chart1.Series("MIN").Points.AddXY("1st", 0.4)
        Chart1.Series("MIN").Points.AddXY("2nd", 0.4)
        Chart1.Series("MIN").Points.AddXY("3rd", 0.4)
        Chart1.Series("MIN").Points.AddXY("4th", 0.4)
        Chart1.Series("MIN").Points.AddXY("5th", 0.4)
        Chart1.Series("MIN").Points.AddXY("6th", 0.4)
        Chart1.Series("MIN").Points.AddXY("7th", 0.4)
        Chart1.Series("MIN").Points.AddXY("8th", 0.4)

        Chart1.Series("NOMINAL").Points.AddXY("1st", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("2nd", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("3rd", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("4th", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("5th", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("6th", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("7th", 0.6)
        Chart1.Series("NOMINAL").Points.AddXY("8th", 0.6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If TextBox1.Text = "" Then
            MsgBox("Favor de capturar una WO")
            Return
        End If

        Try
            'Leer del Master data los demas campos

            Dim consulta_a_sql As String
            Dim lista_a_sql As String

            consulta_a_sql = "SELECT [WO],[MACHINE],[DATE],[HOUR],[ITEM],[DESCRIPTION],[LOT],[LB_REQUEST],[FLUX_PERCENT],[LB_PRODUCTION],[GOOD_LB],[AVAILABILITY],[PERFORMANCE],[QUALITY],[OEE],[FLOW_RATE_1],[FLOW_RATE_2],[FLOW_RATE_3],[FLOW_RATE_4],[FLOW_RATE_5],[FLOW_RATE_6],[FLOW_RATE_7],[FLOW_RATE_8],[SCRAP] FROM [OEE_data].[dbo].[ALPHA_MTY_WIRE_EXTRUSION_EX01] WHERE WO = '" & TextBox1.Text & "'"

            adaptador_a_sql = New SqlDataAdapter(consulta_a_sql, ConexionSQL.ConexionSQL)
            ConexionSQL.registro_a_sql = New DataSet
            adaptador_a_sql.Fill(registro_a_sql, "Tabla1")
            lista_a_sql = registro_a_sql.Tables("Tabla1").Rows.Count


            If lista_a_sql <> 0 Then

                TextBox1.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WO")
                TextBox14.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("MACHINE")
                TextBox2.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DATE")
                TextBox3.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("HOUR")
                TextBox19.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("ITEM")
                TextBox11.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DESCRIPTION")
                TextBox12.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("LOT")
                TextBox4.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("LB_REQUEST")
                TextBox21.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLUX_PERCENT")
                TextBox5.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("LB_PRODUCTION")
                TextBox15.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("GOOD_LB")
                TextBox7.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_1")
                TextBox8.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_2")
                TextBox9.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_3")
                TextBox10.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_4")
                TextBox13.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_5")
                TextBox16.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_6")
                TextBox17.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_7")
                TextBox18.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FLOW_RATE_8")
                TextBox6.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("SCRAP")

            Else
                MsgBox("Asegurese que exista la WO en la base de datos")
                Return
            End If

        Catch ex As Exception
            MsgBox("Problema con la Base de datos:  " & ex.Message)
        End Try

        If TextBox21.Text = "2" Then
            Button1.PerformClick()
        Else
            If TextBox21.Text = "0.6" Then
                Button2.PerformClick()
            Else
                If TextBox21.Text = "1" Then
                    Button3.PerformClick()
                Else
                    If TextBox21.Text = "1.5" Then
                        Button4.PerformClick()
                    Else
                        If TextBox21.Text = "3" Then
                            Button5.PerformClick()
                        Else
                            If TextBox21.Text = "4" Then
                                Button6.PerformClick()
                            Else
                                MsgBox("Seleccione la medición de flux manualmente para generar el gáfico")
                            End If
                        End If
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()
        Chart1.Series(3).Points.Clear()

        Label21.Text = "MIN: 0.8%"
        Label22.Text = "NOMINAL: 1.1%"
        Label23.Text = "MAX: 1.4%"

        Chart1.Series("% FLUX").Points.AddXY("1st", TextBox7.Text)
        Chart1.Series("% FLUX").Points.AddXY("2nd", TextBox8.Text)
        Chart1.Series("% FLUX").Points.AddXY("3rd", TextBox9.Text)
        Chart1.Series("% FLUX").Points.AddXY("4th", TextBox10.Text)
        Chart1.Series("% FLUX").Points.AddXY("5th", TextBox13.Text)
        Chart1.Series("% FLUX").Points.AddXY("6th", TextBox16.Text)
        Chart1.Series("% FLUX").Points.AddXY("7th", TextBox17.Text)
        Chart1.Series("% FLUX").Points.AddXY("8th", TextBox18.Text)

        Chart1.Series("MAX").Points.AddXY("1st", 1.4)
        Chart1.Series("MAX").Points.AddXY("2nd", 1.4)
        Chart1.Series("MAX").Points.AddXY("3rd", 1.4)
        Chart1.Series("MAX").Points.AddXY("4th", 1.4)
        Chart1.Series("MAX").Points.AddXY("5th", 1.4)
        Chart1.Series("MAX").Points.AddXY("6th", 1.4)
        Chart1.Series("MAX").Points.AddXY("7th", 1.4)
        Chart1.Series("MAX").Points.AddXY("8th", 1.4)

        Chart1.Series("MIN").Points.AddXY("1st", 0.8)
        Chart1.Series("MIN").Points.AddXY("2nd", 0.8)
        Chart1.Series("MIN").Points.AddXY("3rd", 0.8)
        Chart1.Series("MIN").Points.AddXY("4th", 0.8)
        Chart1.Series("MIN").Points.AddXY("5th", 0.8)
        Chart1.Series("MIN").Points.AddXY("6th", 0.8)
        Chart1.Series("MIN").Points.AddXY("7th", 0.8)
        Chart1.Series("MIN").Points.AddXY("8th", 0.8)

        Chart1.Series("NOMINAL").Points.AddXY("1st", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("2nd", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("3rd", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("4th", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("5th", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("6th", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("7th", 1.1)
        Chart1.Series("NOMINAL").Points.AddXY("8th", 1.1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()
        Chart1.Series(3).Points.Clear()

        Label21.Text = "MIN: 1.3%"
        Label22.Text = "NOMINAL: 1.5%"
        Label23.Text = "MAX: 1.7%"

        Chart1.Series("% FLUX").Points.AddXY("1st", TextBox7.Text)
        Chart1.Series("% FLUX").Points.AddXY("2nd", TextBox8.Text)
        Chart1.Series("% FLUX").Points.AddXY("3rd", TextBox9.Text)
        Chart1.Series("% FLUX").Points.AddXY("4th", TextBox10.Text)
        Chart1.Series("% FLUX").Points.AddXY("5th", TextBox13.Text)
        Chart1.Series("% FLUX").Points.AddXY("6th", TextBox16.Text)
        Chart1.Series("% FLUX").Points.AddXY("7th", TextBox17.Text)
        Chart1.Series("% FLUX").Points.AddXY("8th", TextBox18.Text)

        Chart1.Series("MAX").Points.AddXY("1st", 1.7)
        Chart1.Series("MAX").Points.AddXY("2nd", 1.7)
        Chart1.Series("MAX").Points.AddXY("3rd", 1.7)
        Chart1.Series("MAX").Points.AddXY("4th", 1.7)
        Chart1.Series("MAX").Points.AddXY("5th", 1.7)
        Chart1.Series("MAX").Points.AddXY("6th", 1.7)
        Chart1.Series("MAX").Points.AddXY("7th", 1.7)
        Chart1.Series("MAX").Points.AddXY("8th", 1.7)

        Chart1.Series("MIN").Points.AddXY("1st", 1.3)
        Chart1.Series("MIN").Points.AddXY("2nd", 1.3)
        Chart1.Series("MIN").Points.AddXY("3rd", 1.3)
        Chart1.Series("MIN").Points.AddXY("4th", 1.3)
        Chart1.Series("MIN").Points.AddXY("5th", 1.3)
        Chart1.Series("MIN").Points.AddXY("6th", 1.3)
        Chart1.Series("MIN").Points.AddXY("7th", 1.3)
        Chart1.Series("MIN").Points.AddXY("8th", 1.3)

        Chart1.Series("NOMINAL").Points.AddXY("1st", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("2nd", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("3rd", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("4th", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("5th", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("6th", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("7th", 1.5)
        Chart1.Series("NOMINAL").Points.AddXY("8th", 1.5)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()
        Chart1.Series(3).Points.Clear()

        Label21.Text = "MIN: 3.0%"
        Label22.Text = "NOMINAL: 3.3%"
        Label23.Text = "MAX: 3.6%"

        Chart1.Series("% FLUX").Points.AddXY("1st", TextBox7.Text)
        Chart1.Series("% FLUX").Points.AddXY("2nd", TextBox8.Text)
        Chart1.Series("% FLUX").Points.AddXY("3rd", TextBox9.Text)
        Chart1.Series("% FLUX").Points.AddXY("4th", TextBox10.Text)
        Chart1.Series("% FLUX").Points.AddXY("5th", TextBox13.Text)
        Chart1.Series("% FLUX").Points.AddXY("6th", TextBox16.Text)
        Chart1.Series("% FLUX").Points.AddXY("7th", TextBox17.Text)
        Chart1.Series("% FLUX").Points.AddXY("8th", TextBox18.Text)

        Chart1.Series("MAX").Points.AddXY("1st", 3.6)
        Chart1.Series("MAX").Points.AddXY("2nd", 3.6)
        Chart1.Series("MAX").Points.AddXY("3rd", 3.6)
        Chart1.Series("MAX").Points.AddXY("4th", 3.6)
        Chart1.Series("MAX").Points.AddXY("5th", 3.6)
        Chart1.Series("MAX").Points.AddXY("6th", 3.6)
        Chart1.Series("MAX").Points.AddXY("7th", 3.6)
        Chart1.Series("MAX").Points.AddXY("8th", 3.6)

        Chart1.Series("MIN").Points.AddXY("1st", 3.0)
        Chart1.Series("MIN").Points.AddXY("2nd", 3.0)
        Chart1.Series("MIN").Points.AddXY("3rd", 3.0)
        Chart1.Series("MIN").Points.AddXY("4th", 3.0)
        Chart1.Series("MIN").Points.AddXY("5th", 3.0)
        Chart1.Series("MIN").Points.AddXY("6th", 3.0)
        Chart1.Series("MIN").Points.AddXY("7th", 3.0)
        Chart1.Series("MIN").Points.AddXY("8th", 3.0)

        Chart1.Series("NOMINAL").Points.AddXY("1st", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("2nd", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("3rd", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("4th", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("5th", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("6th", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("7th", 3.3)
        Chart1.Series("NOMINAL").Points.AddXY("8th", 3.3)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()
        Chart1.Series(3).Points.Clear()

        Label21.Text = "MIN: 4.2%"
        Label22.Text = "NOMINAL: 4.4%"
        Label23.Text = "MAX: 4.6%"

        Chart1.Series("% FLUX").Points.AddXY("1st", TextBox7.Text)
        Chart1.Series("% FLUX").Points.AddXY("2nd", TextBox8.Text)
        Chart1.Series("% FLUX").Points.AddXY("3rd", TextBox9.Text)
        Chart1.Series("% FLUX").Points.AddXY("4th", TextBox10.Text)
        Chart1.Series("% FLUX").Points.AddXY("5th", TextBox13.Text)
        Chart1.Series("% FLUX").Points.AddXY("6th", TextBox16.Text)
        Chart1.Series("% FLUX").Points.AddXY("7th", TextBox17.Text)
        Chart1.Series("% FLUX").Points.AddXY("8th", TextBox18.Text)

        Chart1.Series("MAX").Points.AddXY("1st", 4.6)
        Chart1.Series("MAX").Points.AddXY("2nd", 4.6)
        Chart1.Series("MAX").Points.AddXY("3rd", 4.6)
        Chart1.Series("MAX").Points.AddXY("4th", 4.6)
        Chart1.Series("MAX").Points.AddXY("5th", 4.6)
        Chart1.Series("MAX").Points.AddXY("6th", 4.6)
        Chart1.Series("MAX").Points.AddXY("7th", 4.6)
        Chart1.Series("MAX").Points.AddXY("8th", 4.6)

        Chart1.Series("MIN").Points.AddXY("1st", 4.2)
        Chart1.Series("MIN").Points.AddXY("2nd", 4.2)
        Chart1.Series("MIN").Points.AddXY("3rd", 4.2)
        Chart1.Series("MIN").Points.AddXY("4th", 4.2)
        Chart1.Series("MIN").Points.AddXY("5th", 4.2)
        Chart1.Series("MIN").Points.AddXY("6th", 4.2)
        Chart1.Series("MIN").Points.AddXY("7th", 4.2)
        Chart1.Series("MIN").Points.AddXY("8th", 4.2)

        Chart1.Series("NOMINAL").Points.AddXY("1st", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("2nd", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("3rd", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("4th", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("5th", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("6th", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("7th", 4.4)
        Chart1.Series("NOMINAL").Points.AddXY("8th", 4.4)
    End Sub
End Class