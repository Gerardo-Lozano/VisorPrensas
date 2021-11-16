Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visor_Timer.Enabled = True
        Sounds.Enabled = True
        Conexion_SQL()
        Label1.Text = estadosql
    End Sub

    Private Sub Visor_Timer_Tick(sender As Object, e As EventArgs) Handles Visor_Timer.Tick

        'CONSULTA PARA PRENSA 1



        Try
            'Leer del Master data los demas campos

            Dim consulta_a_sql As String
            Dim lista_a_sql As Byte

            consulta_a_sql = "SELECT * FROM [OEE_data].[dbo].[VisorStatus] WHERE [MACHINE] = 1"

            adaptador_a_sql = New SqlDataAdapter(consulta_a_sql, ConexionSQL.ConexionSQL)
            ConexionSQL.registro_a_sql = New DataSet
            adaptador_a_sql.Fill(registro_a_sql, "Tabla1")
            lista_a_sql = registro_a_sql.Tables("Tabla1").Rows.Count

            Dim Status As Integer

            If lista_a_sql <> 0 Then
                Status = registro_a_sql.Tables("Tabla1").Rows(0).Item("CODE")
                Label19.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WO")
                Label18.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("BATCH")
                Label17.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("ITEM")
                Label15.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("QTY")
                Label14.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DATEREQ")
                Label13.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("START_HR")
                TextBox1.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DESCRIPTION")
                Label33.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FROMSTART_HR")
                Label31.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WITHOUTSTP_HR")
                Label29.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("SHEDULESTP_HR")
                Label27.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("UNSCHEDULSTP_HR")
                Label25.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("STOPS_HR")
                Label23.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("PRODUCED")
                Label21.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("COMPLETED")
                Label35.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("PARO")
                Label107.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("OPERATOR")

                Label32.Text = Label21.Text.TrimEnd & " % Completed"

                If Label21.Text >= 0 Then
                    ProgressBar1.Value = registro_a_sql.Tables("Tabla1").Rows(0).Item("COMPLETED")
                End If
                'Barra de Progreso

                If Status = 0 Then
                        PictureBox4.Visible = True
                        Label4.Visible = True
                        PictureBox7.Visible = False
                        Label3.Visible = False
                        PictureBox10.Visible = False
                        Label5.Visible = False
                        PictureBox13.Visible = False
                        Label2.Visible = False
                        PictureBox16.Visible = False
                    Label34.Visible = False
                    PictureBox17.Visible = False
                    Label36.Visible = False

                    Label35.Visible = False
                End If

                    If Status = 1 Then
                        PictureBox4.Visible = False
                        Label4.Visible = False
                        PictureBox7.Visible = False
                        Label5.Visible = False
                        PictureBox10.Visible = False
                        Label2.Visible = False
                        PictureBox13.Visible = True
                        Label3.Visible = True
                        PictureBox16.Visible = False
                    Label34.Visible = False
                    PictureBox17.Visible = False
                    Label36.Visible = False

                    Label35.Visible = False
                End If

                    If Status = 2 Then
                        PictureBox4.Visible = False
                        Label4.Visible = False
                        PictureBox7.Visible = True
                        Label5.Visible = True
                        PictureBox10.Visible = False
                        Label2.Visible = False
                        PictureBox13.Visible = False
                        Label3.Visible = False
                        PictureBox16.Visible = False
                    Label34.Visible = False
                    PictureBox17.Visible = False
                    Label36.Visible = False

                    Label35.Visible = False
                End If

                    If Status = 3 Then
                        PictureBox4.Visible = False
                        Label4.Visible = False
                        PictureBox7.Visible = False
                        Label5.Visible = False
                        PictureBox10.Visible = True
                        Label2.Visible = True
                        PictureBox13.Visible = False
                        Label3.Visible = False
                        PictureBox16.Visible = False
                    Label34.Visible = False
                    PictureBox17.Visible = False
                    Label36.Visible = False

                    Label35.Visible = True
                End If

                    If Status = 4 Then
                        PictureBox4.Visible = False
                        Label4.Visible = False
                        PictureBox7.Visible = False
                        Label5.Visible = False
                        PictureBox10.Visible = False
                        Label2.Visible = False
                        PictureBox13.Visible = False
                    Label3.Visible = False
                    PictureBox17.Visible = False
                    Label36.Visible = False
                    PictureBox16.Visible = True
                    Label34.Visible = True

                    Label35.Visible = False
                End If

                If Status = 5 Then
                    PictureBox4.Visible = False
                    Label4.Visible = False
                    PictureBox7.Visible = False
                    Label5.Visible = False
                    PictureBox10.Visible = False
                    Label2.Visible = False
                    PictureBox13.Visible = False
                    Label3.Visible = False
                    PictureBox16.Visible = False
                    Label34.Visible = False

                    PictureBox17.Visible = True
                    Label36.Visible = True

                    Label35.Visible = False
                End If

            Else
                    MsgBox("Problema con la BD del Visor")
                Return
            End If

        Catch

        End Try

        'CONSULTA PARA PRENSA 2

        Try
            'Leer del Master data los demas campos

            Dim consulta_a_sql As String
            Dim lista_a_sql As Byte

            consulta_a_sql = "SELECT * FROM [OEE_data].[dbo].[VisorStatus] WHERE [MACHINE] = 2"

            adaptador_a_sql = New SqlDataAdapter(consulta_a_sql, ConexionSQL.ConexionSQL)
            ConexionSQL.registro_a_sql = New DataSet
            adaptador_a_sql.Fill(registro_a_sql, "Tabla1")
            lista_a_sql = registro_a_sql.Tables("Tabla1").Rows.Count

            Dim Status2 As Integer

            If lista_a_sql <> 0 Then
                Status2 = registro_a_sql.Tables("Tabla1").Rows(0).Item("CODE")
                Label80.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WO")
                Label78.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("BATCH")
                Label76.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("ITEM")
                Label72.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("QTY")
                Label70.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DATEREQ")
                Label68.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("START_HR")
                TextBox2.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DESCRIPTION")
                Label66.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FROMSTART_HR")
                Label65.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WITHOUTSTP_HR")
                Label63.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("SHEDULESTP_HR")
                Label61.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("UNSCHEDULSTP_HR")
                Label59.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("STOPS_HR")
                Label57.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("PRODUCED")
                Label52.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("COMPLETED")
                Label43.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("PARO")
                Label109.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("OPERATOR")

                Label51.Text = Label52.Text.TrimEnd & " % Completed"

                If Label52.Text >= 0 Then
                    ProgressBar2.Value = registro_a_sql.Tables("Tabla1").Rows(0).Item("COMPLETED")
                End If
                'Barra de Progreso

                If Status2 = 0 Then
                    PictureBox5.Visible = True
                    Label40.Visible = True
                    PictureBox8.Visible = False
                    Label41.Visible = False
                    PictureBox11.Visible = False
                    Label39.Visible = False
                    PictureBox14.Visible = False
                    Label42.Visible = False
                    PictureBox18.Visible = False
                    Label38.Visible = False
                    PictureBox20.Visible = False
                    Label37.Visible = False

                    Label43.Visible = False
                End If

                If Status2 = 1 Then
                    PictureBox5.Visible = False
                    Label40.Visible = False
                    PictureBox8.Visible = False
                    Label41.Visible = True
                    PictureBox11.Visible = False
                    Label39.Visible = False
                    PictureBox14.Visible = True
                    Label42.Visible = False
                    PictureBox18.Visible = False
                    Label38.Visible = False
                    PictureBox20.Visible = False
                    Label37.Visible = False

                    Label43.Visible = False
                End If

                If Status2 = 2 Then
                    PictureBox5.Visible = False
                    Label40.Visible = False
                    PictureBox8.Visible = True
                    Label41.Visible = False
                    PictureBox11.Visible = False
                    Label39.Visible = True
                    PictureBox14.Visible = False
                    Label42.Visible = False
                    PictureBox18.Visible = False
                    Label38.Visible = False
                    PictureBox20.Visible = False
                    Label37.Visible = False

                    Label43.Visible = False
                End If

                If Status2 = 3 Then
                    PictureBox5.Visible = False
                    Label40.Visible = False
                    PictureBox8.Visible = False
                    Label41.Visible = False
                    PictureBox11.Visible = True
                    Label39.Visible = False
                    PictureBox14.Visible = False
                    Label42.Visible = True
                    PictureBox18.Visible = False
                    Label38.Visible = False
                    PictureBox20.Visible = False
                    Label37.Visible = False

                    Label43.Visible = True
                End If

                If Status2 = 4 Then
                    PictureBox5.Visible = False
                    Label40.Visible = False
                    PictureBox8.Visible = False
                    Label41.Visible = False
                    PictureBox11.Visible = False
                    Label39.Visible = False
                    PictureBox14.Visible = False
                    Label42.Visible = False
                    PictureBox18.Visible = True
                    Label38.Visible = True
                    PictureBox20.Visible = False
                    Label37.Visible = False

                    Label43.Visible = False
                End If

                If Status2 = 5 Then
                    PictureBox5.Visible = False
                    Label40.Visible = False
                    PictureBox8.Visible = False
                    Label41.Visible = False
                    PictureBox11.Visible = False
                    Label39.Visible = False
                    PictureBox14.Visible = False
                    Label42.Visible = False
                    PictureBox18.Visible = False
                    Label38.Visible = False
                    PictureBox20.Visible = True
                    Label37.Visible = True

                    Label43.Visible = False
                End If

            Else
                MsgBox("Problema con la BD del Visor")
                Return
            End If

        Catch

        End Try

        'CONSULTA PARA PRENSA 3

        Try
            'Leer del Master data los demas campos

            Dim consulta_a_sql As String
            Dim lista_a_sql As Byte

            consulta_a_sql = "SELECT * FROM [OEE_data].[dbo].[VisorStatus] WHERE [MACHINE] = 3"

            adaptador_a_sql = New SqlDataAdapter(consulta_a_sql, ConexionSQL.ConexionSQL)
            ConexionSQL.registro_a_sql = New DataSet
            adaptador_a_sql.Fill(registro_a_sql, "Tabla1")
            lista_a_sql = registro_a_sql.Tables("Tabla1").Rows.Count

            Dim Status3 As Integer

            If lista_a_sql <> 0 Then
                Status3 = registro_a_sql.Tables("Tabla1").Rows(0).Item("CODE")
                Label106.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WO")
                Label104.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("BATCH")
                Label102.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("ITEM")
                Label98.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("QTY")
                Label96.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DATEREQ")
                Label94.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("START_HR")
                TextBox3.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("DESCRIPTION")
                Label92.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("FROMSTART_HR")
                Label91.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("WITHOUTSTP_HR")
                Label89.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("SHEDULESTP_HR")
                Label87.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("UNSCHEDULSTP_HR")
                Label85.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("STOPS_HR")
                Label83.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("PRODUCED")
                Label54.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("COMPLETED")
                Label44.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("PARO")
                Label111.Text = registro_a_sql.Tables("Tabla1").Rows(0).Item("OPERATOR")

                Label53.Text = Label54.Text.TrimEnd & " % Completed"

                If Label54.Text >= 0 Then
                    ProgressBar3.Value = registro_a_sql.Tables("Tabla1").Rows(0).Item("COMPLETED")
                End If
                'Barra de Progreso

                If Status3 = 0 Then
                    PictureBox6.Visible = True
                    Label48.Visible = True
                    PictureBox9.Visible = False
                    Label49.Visible = False
                    PictureBox12.Visible = False
                    Label47.Visible = False
                    PictureBox15.Visible = False
                    Label50.Visible = False
                    PictureBox19.Visible = False
                    Label46.Visible = False
                    PictureBox21.Visible = False
                    Label45.Visible = False

                    Label44.Visible = False
                End If

                If Status3 = 1 Then
                    PictureBox6.Visible = False
                    Label48.Visible = False
                    PictureBox9.Visible = False
                    Label49.Visible = True
                    PictureBox12.Visible = False
                    Label47.Visible = False
                    PictureBox15.Visible = True
                    Label50.Visible = False
                    PictureBox19.Visible = False
                    Label46.Visible = False
                    PictureBox21.Visible = False
                    Label45.Visible = False

                    Label44.Visible = False
                End If

                If Status3 = 2 Then
                    PictureBox6.Visible = False
                    Label48.Visible = False
                    PictureBox9.Visible = True
                    Label49.Visible = False
                    PictureBox12.Visible = False
                    Label47.Visible = True
                    PictureBox15.Visible = False
                    Label50.Visible = False
                    PictureBox19.Visible = False
                    Label46.Visible = False
                    PictureBox21.Visible = False
                    Label45.Visible = False

                    Label44.Visible = False
                End If

                If Status3 = 3 Then
                    PictureBox6.Visible = False
                    Label48.Visible = False
                    PictureBox9.Visible = False
                    Label49.Visible = False
                    PictureBox12.Visible = True
                    Label47.Visible = False
                    PictureBox15.Visible = False
                    Label50.Visible = True
                    PictureBox19.Visible = False
                    Label46.Visible = False
                    PictureBox21.Visible = False
                    Label45.Visible = False

                    Label44.Visible = True
                End If

                If Status3 = 4 Then
                    PictureBox6.Visible = False
                    Label48.Visible = False
                    PictureBox9.Visible = False
                    Label49.Visible = False
                    PictureBox12.Visible = False
                    Label47.Visible = False
                    PictureBox15.Visible = False
                    Label50.Visible = False
                    PictureBox19.Visible = True
                    Label46.Visible = True
                    PictureBox21.Visible = False
                    Label45.Visible = False

                    Label44.Visible = False
                End If

                If Status3 = 5 Then
                    PictureBox6.Visible = False
                    Label48.Visible = False
                    PictureBox9.Visible = False
                    Label49.Visible = False
                    PictureBox12.Visible = False
                    Label47.Visible = False
                    PictureBox15.Visible = False
                    Label50.Visible = False
                    PictureBox19.Visible = False
                    Label46.Visible = False
                    PictureBox21.Visible = True
                    Label45.Visible = True

                    Label44.Visible = False
                End If

            Else
                MsgBox("Problema con la BD del Visor")
                Return
            End If

        Catch

        End Try

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ConexionSQL.ConexionSQL.Close()
    End Sub

    Private Sub Sounds_Tick(sender As Object, e As EventArgs) Handles Sounds.Tick
        If PictureBox16.Visible Or PictureBox18.Visible Or PictureBox19.Visible = True Then
            'Sonar la alarma
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Stop()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub
End Class
