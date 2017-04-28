Public Class FormExemplo

    ''' <summary>
    ''' Formulário de Teste
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'nova instância de controle
        Dim fn As New ControllerExemplo

        'objeto de teste 1
        Dim Obj As New EntityExemplo With {
            .Nome = "Teste 1",
            .Idade = 10,
            .Status = True,
            .Descricao = "Apenas um teste 1"
        }

        'obtem o objeto em string
        Dim exemplo1 = fn.ObterDadosDaClasse(Obj)

        'objeto de teste 2
        Obj = New EntityExemplo With {
            .Nome = "Teste 2"
        }

        'obtem o objeto em string, menos preenchido
        Dim exemplo2 = fn.ObterDadosDaClasse(Obj)

        Dim ResultadoFinal As String = String.Format("Obj1: {0} - Obj2: {1}", exemplo1, exemplo2)

    End Sub

End Class
