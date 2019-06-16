Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AutosDataSet.Vehicle_Categories' Puede moverla o quitarla según sea necesario.
        Me.Vehicle_CategoriesTableAdapter.Fill(Me.AutosDataSet.Vehicle_Categories)

    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        txtCode.Text = ""
        txtDescription.Text = ""
    End Sub
End Class
