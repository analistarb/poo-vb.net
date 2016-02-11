'-----------------------------------------------
'Para testar use CTRL + F5
'-----------------------------------------------

Module Module1

    Sub Main()
        '-----------------------------------------------
        '---> Classe <---
        '-----------------------------------------------

        'Dim mm As New MinhaClasse()
        'Telefone.Discar("9999-9999")


        '-----------------------------------------------
        '---> Composição <---
        '-----------------------------------------------

        'Dim r1 As New Roda()
        'r1.cor = "Azul"
        'r1.aro = 22

        'Dim r2 As New Roda()
        'r2.cor = "Vermelha"
        'r2.aro = 22

        'Dim minhaMoto As New Moto("Azul", r1, r2)


        '-----------------------------------------------
        '---> Encapsulamento <--- 
        '-----------------------------------------------

        'Dim cp As New Cripto()
        'cp.setValor("aeiou")
        'System.Console.WriteLine(cp.getValor())


        '-----------------------------------------------
        '---> Herança <--- 
        '-----------------------------------------------

        'Dim eu As New Homem()
        'eu.Idade = 30
        'eu.Nome = "João da Silva"
        'eu.TamanhoBarba = 0

        'Dim mi As New Mulher()
        'mi.TamanhoBusto = 80
        'mi.Nome = "Maria da Silva"
        'mi.Idade = 21


        '-----------------------------------------------
        '---> Polimorfismo <---
        '-----------------------------------------------

        'Dim m1 As Mamifero = New Leao()
        'm1.Andar()

        'Dim m2 As Mamifero = New Gorila()
        'm2.Andar()


        '-----------------------------------------------
        '---> Polimorfismo 2 <---
        '-----------------------------------------------

        '      Dim op As Operacao = New Soma()
        '      Dim n1 As Double = 5, n2 As Double = 4
        'New Calcular().MostrarResultado(op, n1, n2)


        '      Dim opp As Operacao = New Subtracao()
        '      'double n1 = 5, n2 = 5;
        'New Calcular().MostrarResultado(opp, n1, n2)


        '-----------------------------------------------
        '---> Sobreposição <---
        '-----------------------------------------------

        Dim p1 As New Poupanca()
        p1.Saque("99999-9", "1234-5", 100)

        Dim c1 As New Corrente()
        c1.Saque("88888-8", "5432-1", 100)
    End Sub

End Module
