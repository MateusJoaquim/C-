// See https://aka.ms/new-console-template for more information

//Soma();
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Selecione a opção desejada:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Média");
    Console.WriteLine("6 - Sair");

    Console.WriteLine("----------------");
    Console.WriteLine("Selecione a opção");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Media(); break;
        case 6: System.Environment.Exit(0); break;
        default: Menu(); break;

    }
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;

    Console.WriteLine("O resultado da soma é " + resultado);


    // Console.WriteLine(v1);

    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
    Menu();


}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();


    Console.WriteLine("Primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
    Console.ReadKey();
    Menu();


}

static void Media()

{
    Console.Clear();
    Console.WriteLine("Valor");
    float v1 = float.Parse(Console.ReadLine());
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = (v1 + v2) / 2;
    Console.WriteLine("A Média é" + (v1 + v2) / 2);
    Console.ReadKey();
    Menu();
}
