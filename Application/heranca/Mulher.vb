

Class Mulher
    Inherits Pessoa
    Private m_tamanhoBusto As Integer

    Public Property TamanhoBusto() As Integer
        Get
            Return m_tamanhoBusto
        End Get
        Set(value As Integer)
            m_tamanhoBusto = value
        End Set
    End Property

End Class
