Imports System.Data.SqlClient

Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            'Leer del Master data los demas campos

            Dim consulta_a_sql As String
            Dim lista_a_sql As String

            consulta_a_sql = "SELECT * FROM ALPHA_MTY_WIRE_EXTRUSION_EX02 ORDER BY DATE"

            adaptador_a_sql = New SqlDataAdapter(consulta_a_sql, ConexionSQL.ConexionSQL)
            ConexionSQL.registro_a_sql = New DataSet
            adaptador_a_sql.Fill(registro_a_sql, "Tabla1")
            lista_a_sql = registro_a_sql.Tables("Tabla1").Rows.Count
            DataGridView1.DataSource = registro_a_sql.Tables("Tabla1")
        Catch

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        llenarExcel(DataGridView1)
    End Sub
End Class