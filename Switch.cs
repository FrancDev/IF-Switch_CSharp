/*Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola
 y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.*/

bool salir=false;

while(!salir){
    Console.WriteLine("\n---LENGUAJES DE PROGRAMCIÓN---\n");
    Console.WriteLine("1. C#");
    Console.WriteLine("2. Java");
    Console.WriteLine("3. C++");
    Console.WriteLine("4. Phyton");
    Console.WriteLine("5. JavaScript");
    Console.WriteLine("6. Swift");
    Console.WriteLine("7. Ruby");
    Console.WriteLine("8. Go");
    Console.WriteLine("9. Perl");
    Console.WriteLine("10. R");
    Console.WriteLine("0. Salir");

    Console.WriteLine("\nSelecciona un lenguaje");
    int opc = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

switch(opc) 
{
  case 1:
    Console.WriteLine("C#\n Console.WriteLine(''Helo, World!'');");
    break;
  case 2:
    Console.WriteLine("Java\n System.out.println(''Helo, World!'');");
    break;
    case 3:
    Console.WriteLine("C++\n std::cout << ''Hello, World!'';");
    break;
    case 4:
    Console.WriteLine("Phyton\n print(''Hello, World!'');");
    break;
    case 5:
    Console.WriteLine("JavaScript\n console.log(''Hello, World!'');");
    break;
    case 6:
    Console.WriteLine("Swift\n print(''Hello, World!'')");
    break;
    case 7:
    Console.WriteLine("Ruby\n puts''Hello, World!''");
    break;
    case 8:
    Console.WriteLine("Go\n fmt.Println(''Hello, World!'')");
    break;
    case 9:
    Console.WriteLine("Perl\n print(''Hello, World!'');");
    break;
    case 10:
    Console.WriteLine("R\n print(''Hello, World!'')");   
    break;
    case 0:
    Console.WriteLine("Has Elegido Salir de aplicacion");
    salir = true;
    break;
    
  default:
    Console.WriteLine("Elige una opción valida entre 0 y 10");
    break;
}

}