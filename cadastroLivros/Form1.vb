Public Class Form1

    ' array para guardar os dados
    Dim arrayLivros As New ArrayList

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        ' validar campo titulo
        If (txtTitulo.Text = Nothing Or IsNumeric(txtTitulo.Text)) Then
            MsgBox("O campo 'Título' está em branco.", MsgBoxStyle.Critical, "Verifique seus dados!")
            Exit Sub
        End If

        ' validar campo ano
        Dim ano As String = txtAno.Text
        Dim result As Boolean = ((Not ano Is Nothing) AndAlso ((ano.Length = 4) AndAlso ano.All(Function(c) Char.IsDigit(c))))

        If (result = False) Then
            MsgBox("O campo 'Ano' está em branco, ou não é válido.", MsgBoxStyle.Critical, "Verifique seus dados!")
            Exit Sub
        End If

        ' validar campo autor
        If (txtAutor.Text = Nothing Or IsNumeric(txtTitulo.Text)) Then
            MsgBox("O campo 'Autor' está em branco, ou não é válido.", MsgBoxStyle.Critical, "Verifique seus dados!")
            Exit Sub
        End If

        ' validar campo disponivel
        Dim disponivel As Boolean = IIf(rbtnSim.Checked, True, False)

        ' se estiver tudo preenchido, guardar os livros 
        Dim arrayLivros As Object = {txtTitulo.Text, txtAno.Text, txtAutor.Text, disponivel}

        ' populando a listview
        Dim lsvItem As ListViewItem = lsvLivros.Items.Add(arrayLivros(0))
        lsvItem.SubItems.Add(arrayLivros(1))
        lsvItem.SubItems.Add(arrayLivros(2))
        lsvItem.SubItems.Add(arrayLivros(3))
    End Sub
End Class
