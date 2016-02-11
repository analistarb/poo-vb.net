

Class Pessoa
    Private m_nome As String
    Private m_idade As Integer

    Public Property Nome() As String
        Get
            Return m_nome
        End Get
        Set(value As String)
            m_nome = value
        End Set
    End Property

    Public Property Idade() As Integer
        Get
            Return m_idade
        End Get
        Set(value As Integer)
            m_idade = value
        End Set
    End Property

End Class
