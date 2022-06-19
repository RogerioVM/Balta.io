// See https://aka.ms/new-console-template for more information

/*Soma();*/

Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer? ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("-----------------------------------------------");

    Console.WriteLine("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch(res)
    {
        case 1 : Soma(); break;
        case 2 : Subtracao(); break;
        case 3 : Multiplicacao(); break;
        case 4 : Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}


void Soma()
{
    Console.Clear();
    try 
    {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        float resultado = v1 + v2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.ReadKey();
        Menu();
    } catch(FormatException e)
    {
        Console.WriteLine($"A calculadora não aceita strings!\n Código do erro: {e.GetHashCode()}");
    }
}

void Subtracao()    
{
    Console.Clear();
    try 
    {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.ReadKey();
        Menu();
    } catch(Exception e)
    {
        Console.WriteLine($"Valor inválido para a operação!\n Log: {e.Message}");
    }
}

void Multiplicacao()
{
    Console.Clear();
    try 
    {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.ReadKey();
        Menu();
    } catch(Exception e)
    {
        Console.WriteLine($"Valor inválido para a operação!\n Log: {e.Message}");
    }
}

void Divisao()
{
    Console.Clear();
    try 
    {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.ReadKey();
        Menu();
    } catch(Exception e)
    {
        Console.WriteLine($"Valor inválido para a operação!\n Log: {e.Message}");
    }
}

