Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Declarar duas variáveis inteiras
        Dim intNum1 As Integer
        Dim intNum2 As Integer

        'Definir os seus valores
        intNum1 = 12
        intNum2 = 31

        'Realizar uma operação matemática e mostrar os resultados numa caixa de mensagem
        MessageBox.Show("A multiplicação de " & intNum1 & " x " & intNum2 & " = " & intNum1 * intNum2, "Exercicio01")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Declarar duas variáveis de string e definir os seus valores
        Dim strNome1 As String = "Visual Studio "
        Dim strNome2 As String = "2019"

        'Realizar uma concatenação nas variáveis e mostrar os resultados numa caixa de mensagem
        MessageBox.Show(strNome1 & strNome2, "Exercicio01")
    End Sub
End Class
