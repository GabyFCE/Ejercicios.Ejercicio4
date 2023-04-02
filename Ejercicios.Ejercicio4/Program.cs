// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Ingrese una frase, si ingresa 'fin' el programa finalizará");
    string frase = Console.ReadLine();
    if (frase == "fin")
    {
        Console.WriteLine("Finalizando programa...");
        break;
    }
}
