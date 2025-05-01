Public Class InterfazPrincipal
    Private Sub InterfazPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipo.Items.Add("Ingreso")
        cbxTipo.Items.Add("Gasto")



    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        cbxCategoria.Items.Clear()
        If cbxTipo.SelectedItem.ToString = "Ingreso" Then
            cbxCategoria.Items.Add("Sueldo")
            cbxCategoria.Items.Add("Alquileres cobrados")
            cbxCategoria.Items.Add("Intereses / Rendimientos")
        ElseIf cbxTipo.SelectedItem.ToString = "Gasto" Then
            cbxCategoria.Items.Add("Alquiler")
            cbxCategoria.Items.Add("Comida")
            cbxCategoria.Items.Add("Transporte")
            cbxCategoria.Items.Add("Servicios")
            cbxCategoria.Items.Add("Salud")

        End If
    End Sub


End Class