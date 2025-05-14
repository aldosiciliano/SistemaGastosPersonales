
Imports System.Data.SQLite
Public Class Conexion
    Private Shared _instancia As SQLiteConnection
    Private Shared ReadOnly _lock As New Object()
    Private Const rutaBD As String = "C:\Users\IK\Desktop\PROG II 2025\SistemaGastosPersonales\BD\gastos.db"
    Private Shared ReadOnly cadenaConexion As String = $"Data Source={rutaBD};Version=3;Read Only=False;"

    Private Sub New() 'Constructor privado para evitar instanciación externa

    End Sub
    Public Shared Function ObtenerConexion() As SQLiteConnection
        If _instancia Is Nothing Then
            SyncLock _lock
                If _instancia Is Nothing Then
                    _instancia = New SQLiteConnection(cadenaConexion)
                    _instancia.Open()
                End If
            End SyncLock
        ElseIf _instancia.State = ConnectionState.Closed Then
            _instancia.Open()
        End If
        Return _instancia
    End Function
End Class
