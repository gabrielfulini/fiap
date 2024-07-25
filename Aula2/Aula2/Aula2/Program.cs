
using System;
using System.Xml;

void operadoresRelacionais()
    
{
    int a = 20, b = 15;
    Console.WriteLine($"a = {a} | b = {b}");
    bool resp;
    resp = a > b;
    Console.WriteLine($"> {resp}");
    resp = a < b;
    Console.WriteLine($"< {resp}");
    resp = a >= b;
    Console.WriteLine($">= {resp}");
    resp = a <= b;
    Console.WriteLine($"<= {resp}");
    resp = a == b;
    Console.WriteLine($"== {resp}");
    resp = a != b;
    Console.WriteLine($"!= {resp}");

     a = 10;
     b = 10;
    Console.WriteLine($"\na = {a} | b = {b}");
    resp = a > b;
    Console.WriteLine($"> {resp}");
    resp = a < b;
    Console.WriteLine($"< {resp}");
    resp = a >= b;
    Console.WriteLine($">= {resp}");
    resp = a <= b;
    Console.WriteLine($"<= {resp}");
    resp = a == b;
    Console.WriteLine($"== {resp}");
    resp = a != b;
    Console.WriteLine($"!= {resp}");
}


void treinoCondicaoSimples()
{
    // exercicio: dado um numero pelo usuario, calcular o seu modulo matematico:
    // numero: 67    exibe: 67
    //numero: -45    exibe: 45


    // --------------- ALGORITIMO
    int num;
    //ler um numero
    Console.Write("Digite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());  //67

    //verificar se o numero é negativo
    if (num < 0)
    {
        //bloco verdade
        // se for tranformar em positivo
        num = num * -1;
    }
    //exibir um numero
    Console.WriteLine($"O Numero digitado = {num}");
}


void exercicioCondicao()
{
    int idade;
    Console.Write("Insira a sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 12)
    {
        Console.WriteLine("Você pode jogar");
    }
    else
    {
        Console.WriteLine("Você não pode jogar");
     }
}


void exercicioCondicao2()
{
    double venda;
    Console.Write("Insira o valor da venda R$ ");
    venda = Convert.ToDouble(Console.ReadLine());

    if (venda > 500)
    {
        Console.WriteLine($"Venda com desconto R${venda = venda * 0.88}");
    }
    else
    {
        Console.WriteLine($"Venda com desconto R${venda = venda * 0.94}");
    }
}

void exercicioEncadeado()
{
    //Dado um numero pelo usuario, verificar se o numero é "positivo", "negativo" ou 'nulo'
    //num 67    positivo
    //num 0     nulo
    //num -4    negativo

    int num;
    Console.Write("Numero :");
    num = Convert.ToInt32(Console.ReadLine());


    if (num > 0)
    {
        Console.WriteLine("Positivo");
    }
    else  if (num < 0 )
    {
        Console.WriteLine("Negativo");
    }
    else
    {
        Console.WriteLine("nulo");
    }

}

void Switch1()
{
    // Exibir por extenso o dia da semana a partir de um numero
    int dia = 8; // ao comparar numero, coloque somente o numero
    char letra = 'a'; // ao comparar char (um caractere) coloque entre apóstrofo  '  '
    string palavra = "Edson"; // ao compara  string, coloque entre aspas ""

   

    switch (dia)
    {
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda");
            break;
        case 3:
            Console.WriteLine("Terça");
            break;
        case 4:
            Console.WriteLine("Quarta");
            break;
        case 5:
            Console.WriteLine("Quinta");
            break;
        case 6:
            Console.WriteLine("Sexta");
            break;
        case 7:
            Console.WriteLine("Sábado");
            break;
        default:
            Console.WriteLine("dia inexistente"); break;

    }
}


void Switch2()
{
    int a, b;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    switch ((a, b))
    {
        case ( > 0, > 0) when a == b:
            Console.WriteLine($"Os valores são positivos, mas iguais: {a}");
            break;
        case ( > 0, > 0):
            Console.WriteLine($"Positivos mas diferentes a = {a} e b = {b}");
            break;
        default:
            Console.WriteLine($"um ou os dois são negativos mas diferentes a = {a} e b = {b}");
            break;
    }
}

