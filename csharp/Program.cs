//calculadora simples

double n1, n2, res;
string opr;

Console.WriteLine("Olá, seja bem vindo, este progama é uma calculadora totalmente funcional!");
Console.WriteLine("Insira o primeiro número:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo número:");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira qual operação deseja realizar com esses números:");
opr = Console.ReadLine();

switch (opr) {

    case "*":
        res = n1 * n2;
        Console.WriteLine($"O resultado da sua multiplicação é {res}");
        break;
    case "/":
        res = n1 / n2;
        if (n2 == 0)
            Console.WriteLine("Não é possível dividir por zero!");
        else
            Console.WriteLine($"O resultado da sua divisão foi de {res}");
        break;

    case "-":
        res = n1 - n2;
        Console.WriteLine($"O resultado da sua subtração foi de {res}");
        break;

    case "+":
        res = n1 + n2;
        Console.WriteLine($"O resultado da sua soma foi de {res}");
        break;

    default:
        Console.WriteLine("Operação invalidá! Insira alguma operação válida!");
        break;

}