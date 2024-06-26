// Variaveis
int operaçao;
double Saldo;

// Entrada de informaçoes
Console.WriteLine("Informe o valor atual do saldo");
Saldo = double.Parse(Console.ReadLine());

// Seleçao de operaçao
Console.WriteLine("Informe a operaçao desejada");
Console.WriteLine("1 para Saque");
Console.WriteLine("2 para Deposito");
Console.WriteLine("3 para Pagamento de conta");
Console.WriteLine("4 para Transferencia");

// Escolha de operaçao
operaçao = int.Parse(Console.ReadLine());

// Condicionamento para escolha de operaçao
// Saque
if (operaçao == 1)
{
    Console.WriteLine("Voce escolheu saque");
    Console.WriteLine("Qual o valor do saque?");
    Saldo = Saldo - double.Parse(Console.ReadLine());
}
// Deposito
else if (operaçao == 2)
{
    Console.WriteLine("Voce escolheu deposito");
    Console.WriteLine("Qual o valor do deposito?");
    Saldo = Saldo + double.Parse(Console.ReadLine());
}
// Pagamento de conta 
else if (operaçao == 3)
{
    Console.WriteLine("Voce escolheu pagamento de conta");
    Console.WriteLine("Qual o valor da conta?");
    Saldo = Saldo - double.Parse(Console.ReadLine());
}
// Transferencia
else if (operaçao == 4)
{
    Console.WriteLine("Voce escolheu transferencia");
    Console.WriteLine("Qual o valor da Transferencia");
    Saldo = Saldo - double.Parse(Console.ReadLine());
}
// Resposta errada
else
{
    Console.WriteLine("Foi digitado o numero errado");
    Console.WriteLine("Digite apenas um dos 4 numeros");
}

// Saldo final
Console.WriteLine("O seu saldo é");
Console.WriteLine(Saldo);
