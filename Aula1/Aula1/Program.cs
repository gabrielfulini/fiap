
void primeiroPrograma ()

{
    Console.WriteLine("Primeira linha");
    Console.WriteLine("segunda linha");
    Console.Write("terceira linha");
    Console.Write("querta linha");
    Console.WriteLine("Quebrando\nLinha\nem\num\nsó\ncomando"); //  \n quebra a linha

}

void saidaDeDados ()
{
    Console.WriteLine("Nome = " + "Edson" + "\tIdade = " + 50 + "\tAltura =  " + 1.71); // \t efetua uma tabulação

    //                                                               1      2    3
    Console.WriteLine("Nome = {0} \tIdade = {1} \tAltura = {2}", "Edson", 50, 1.71);
    //
    Console.WriteLine($"Nome = {"Edson"} \tIdade = {50} \tAltura = {1.71}"); // usando o $ na frente informa as informações
}

//  texto = string
//  inteiro = int
// real = double
// logica = boolean


void variaveis()
{
    //declaração das variaveis
    string nome;
    int idade;
    double altura;
    //Atribuicao dos valores nas variaveis
    nome = "Edson de Oliveira";
    idade = 50;
    altura = 1.71;


    Console.WriteLine("Nome = " + nome + "\tIdade = " + idade + "\tAltura =  " + altura); // \t efetua uma tabulação

    //                                                               1      2    3
    Console.WriteLine("Nome =  \tIdade = {1} \tAltura = {2}", nome, idade, altura);
    //
    Console.WriteLine($"Nome = {nome} \tIdade = {idade} \tAltura = {altura}");
}


void entradaDeDados()

{
    int valor;
    double salario;
    Console.Write("Digite um numero: ");
    valor = Convert.ToInt16(Console.ReadLine()); // ReadLine (lê um valor string)

    Console.WriteLine($"Você digitou:  {valor}");

    /* Readline sempre lê um valor texto (string
     * é necessário convertermos este valor
     * Antes de pedir a digitação do usuário, exibir uma informação sobre o que digitar
     */
}
void operadoresAritmeticos()
{
    int a = 10, b = 3;
    double x = 15.5, y = 1.5;

    Console.WriteLine($"a = {a} b = {b} \tx = {x} y = {y}");
    Console.WriteLine($"Soma = {a + b} | {x + y}");
    Console.WriteLine($"Subtracao = {a - b} | {x - y}");
    Console.WriteLine($"Multiplicação = {a * b} | {x * y}");
    Console.WriteLine($"divisao = {a / b} | {x / y}");

    Console.WriteLine($"Módulo = {a % b} | {x % y}");
}

void fechar()
{
    int a = 7, b = 3, c;

    Console.WriteLine($"a = {a} | b = {a}");

    c = a++ + b++;  // a = a + 1/
    /* a++; soma 1 depois do ;
     * ++a; soma 1 antes do ;*/

    Console.WriteLine($"a = {a} | b = {b}  |  c = {c}");
}

//exercicios

void exercicioAritmetico()
{
    int a = 10;
    int b = 3;
    double c = 20.5;
    double d = 4.0;

    Console.WriteLine(a + b * d);
    Console.WriteLine(d / b - a);
    Console.WriteLine(c + a % b);
    Console.WriteLine(d * (a + b) / d);
    Console.WriteLine(c - a % b / d);
}
    exercicioAritmetico();