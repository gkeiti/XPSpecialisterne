using Dinamica;

Console.WriteLine(@"Selecione o exercício:
1) Calcular Média
5) Calcula área retângulo
6) Calcula idade em dias
7) Calcula potência
8) Verifica palíndomo");

var programa = Console.ReadLine();

if (programa == "1")
    Media.CalculaMedia();

if (programa == "5")
    Retangulo.CalculaAreaRetangulo();

if (programa == "6")
    IdadeEmDias.CalculaIdadeEmDias();

if (programa == "7")
    Potencia.CalculaPotencia();

if (programa == "8")
    Palindromo.VerificaPalindromo();