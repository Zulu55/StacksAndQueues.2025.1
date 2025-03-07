var fruits = new Stack<string>();
var opc = "0";
do
{
    try
    {
        opc = Menu();
        switch (opc)
        {
            case "1":
                Console.Write("Ingrese fruta: ");
                fruits.Push(Console.ReadLine()!);
                break;

            case "2":
                Console.WriteLine(fruits.Pop());
                break;

            case "3":
                Console.WriteLine(fruits.Peek());
                break;

            case "0":
                Console.WriteLine("Hasta la vista baby...");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (opc != "0");

string Menu()
{
    Console.WriteLine("1. Apilar");
    Console.WriteLine("2. Desapilar");
    Console.WriteLine("3. Mostrar tope de la pila");
    Console.WriteLine("0. Salir");
    Console.Write("Digite su opción: ");
    return Console.ReadLine()!;
}