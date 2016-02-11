

Class Cripto
    Private valor As String

    Public Sub setValor(texto As String)
        valor = texto.Replace("a"c, "1"c)
    End Sub

    Public Function getValor() As String
        Return valor
    End Function

End Class
