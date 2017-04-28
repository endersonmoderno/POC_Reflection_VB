Imports System.Reflection

''' <summary>
''' Controle de FormExemplo
''' </summary>
Public Class ControllerExemplo

    ''' <summary>
    ''' Obtem as propriedades preenchidas do objeto
    ''' </summary>
    ''' <param name="Obj">Objeto carregado</param>
    ''' <returns></returns>
    Public Function ObterDadosDaClasse(ByVal Obj As EntityExemplo) As String

        'determina retorno padrão
        Dim retorno As String = String.Empty

        Try

            'carrega lista de propriedades do objeto
            Dim propriedades As PropertyInfo() = Obj.GetType().GetProperties()

            'varre lista de propriedades
            For Each prop As PropertyInfo In propriedades

                'carrega valor da propriedade
                Dim valor As Object = prop.GetValue(Obj)

                'verifica se propriedade existe
                If valor IsNot Nothing Then

                    'verifica se retorno não está vazio
                    If Not String.IsNullOrEmpty(retorno) Then

                            'coloca a vírgula na última prop do retorno
                            retorno = String.Format("{0}, ", retorno)

                        End If

                        'carrega nome e valor de propriedade para retorno
                        retorno = String.Format("{0}{1}='{2}'", retorno, prop.Name, valor)

                    End If

            Next

        Catch ex As Exception
            retorno = String.Format("Erro: {0}", ex.Message)
        End Try

        Return retorno

    End Function


End Class
