Imports System.Text
Public Class Hash
    Public Shared Function HashearSHA256(texto As String) As String
        Using sha256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(texto)
            Dim hash = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
End Class
