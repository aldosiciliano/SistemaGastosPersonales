Imports System.Data.SqlClient
Imports System.Data.SQLite
Public Class Conexion
    Private Const rutaBD As String = "C:\Users\IK\Desktop\PROG II 2025\SistemaGastosPersonales\BD\gastos.db"
    Private Shared ReadOnly cadenaConexion As String = $"Data Source={rutaBD};Version=3;Read Only=False;"
    Public Shared Function ObtenerConexion() As SQLiteConnection
        Dim conexion As New SQLiteConnection(cadenaConexion)
        conexion.Open()
        Return conexion
    End Function
End Class
