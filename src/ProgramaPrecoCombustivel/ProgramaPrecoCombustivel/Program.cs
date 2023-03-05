

float PrecoAlcool()
{
    Console.Write("Digite o preço do álcool na sua cidade: ");
    return float.Parse(Console.ReadLine());
}

float PrecoGasolina()

{
    Console.Write("Digite o preço da gasolina na sua cidade: ");
    return float.Parse(Console.ReadLine());
}

void Preco()
{
    if(PrecoAlcool() >= 0.72 * PrecoGasolina())
    {
        Console.WriteLine("Pelos preços dos combustíveis, é aconselhável abastecer com GASOLINA");
    }
    else
    {
        Console.WriteLine("Pelos preços dos combustíveis, é aconselhável abastecer com Álcool ");
    }
}

Preco();
