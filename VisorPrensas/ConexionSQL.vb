Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ConexionSQL
    Public ConexionSQL As SqlConnection

    Public servidor As String = "NDCA0WPAP138.MX.CKSNNET.COM\ALPHAMTY"
    Public bd As String = "OEE_data"
    Public usuario As String = "SA"
    Public pass As String = "Alpha123"

    Public conexion_a_sql As New OleDbConnection
    Public comando_a_sql As New SqlCommand
    Public adaptador_a_sql As New SqlDataAdapter
    Public registro_a_sql As New DataSet

    Public estadosql As String

    Sub Conexion_SQL()
        Try
            Dim cadena = "data source =" & servidor & "; initial catalog = " & bd & "; user id = " & usuario & "; password = " & pass
            'Dim cadena = "data source =" & servidor & "; initial catalog =" & bd & "; Integrated Security = SSPI"

            ConexionSQL = New SqlConnection(cadena)

            ConexionSQL.Open()
            estadosql = "Online"
            'MsgBox("Conexión establecida")

            'ConexionSQL.Close()
            'estadosql = "Offline"
            'MsgBox("Conexión cerrada")

        Catch ex As Exception

            estadosql = "Failure offline"
            MsgBox("Error al tratar de conectar a la base de datos: " & ex.Message)

        End Try
    End Sub
End Module

