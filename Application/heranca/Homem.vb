

Class Homem
    Inherits Pessoa
    Private m_tamanhoBarba As Integer

    Public Property TamanhoBarba() As Integer
        Get
            Return m_tamanhoBarba
        End Get
        Set(value As Integer)
            m_tamanhoBarba = value
        End Set
    End Property

End Class
