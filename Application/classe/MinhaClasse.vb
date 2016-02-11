

Class MinhaClasse
    Public Sub New()
        Dim meuTelefone As New Telefone("Preto", "WP7")
        meuTelefone.Ligar("9999-9999")
        meuTelefone.Ligar("011", "9999-9999")
    End Sub

End Class

Class Telefone
    Private cor As String
    Private SO As String

    Public Sub New(_cor As String, _SO As String)
        cor = _cor
        SO = _SO
    End Sub

    Public Sub Ligar(numeroDiscar As String)
        Dim texto As String = BemVindo()
        System.Console.WriteLine(texto)
        System.Console.WriteLine("Ligando para {0}", numeroDiscar)
    End Sub


    Public Sub Ligar(ddd As String, numeroDiscar As String)
        Dim texto As String = BemVindo()
        System.Console.WriteLine(texto)
        System.Console.WriteLine("Ligando para {0} - {1}", ddd, numeroDiscar)
    End Sub

    Private Function BemVindo() As String
        Dim texto As String = "Telefone " & cor & " com o sistema operacional " & SO
        Return texto
    End Function

    Public Shared Sub Discar(numeroDiscar As String)
        System.Console.WriteLine("Ligando para {0}", numeroDiscar)
    End Sub


    Protected Overrides Sub Finalize()
        Try
            System.Console.WriteLine("Telefone sendo liberado da memoria")
        Finally
            MyBase.Finalize()
        End Try
    End Sub
End Class


