// Escribe un programa que:
// Pida datos a un cliente: Nombre, email, cupón
// Determine si un cliente tiene un cupon descuento
// Muestre un precio rebajado en función del descuento
// Muestre el precio de un producto sin descuento si no hay cupón

// Nota: puedes poner un precio fijo de un producto o uno variable.

Console.WriteLine("\n--INGRESE LA INFORMACION DEL CLIENTE--\nDigite nombre del cliente: ");
string Nom = Console.ReadLine();
Console.WriteLine("Correo electronico: ");
string Correo = Console.ReadLine();
Console.WriteLine("Cuenta con cupon de descuento? si/no: ");
string Cupon = Console.ReadLine();
Console.Clear();

Console.WriteLine("--INGRESE LA INFORMACION DEL PRODUCTO--\nDigite nombre del producto: ");
string nomP = Console.ReadLine();
Console.WriteLine("Precio: ");
double Precio = Convert.ToInt32(Console.ReadLine());
Console.Clear();

//Precio final del producto
if (Cupon == "si")
{
    Console.WriteLine("Descuento: %");
    double Desc = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    //calculamos el descuento neto sobre el producto
    double Descuento = Math.Round((Precio * Desc) / 100);
    //Precio final del producto
    double precioF = (Precio - Descuento);

    Imprimir(Nom, Correo, Cupon, nomP, Precio);

    Console.WriteLine($" Se aplico el %{Desc} de descuento al producto \n Precio neto: COP" + precioF);
}
else
{
    Imprimir(Nom, Correo, Cupon, nomP, Precio);

    Console.WriteLine(" No se aplico descuento al producto \n Precio Neto: COP" + Precio);
}

//Imprimir en pantalla 
static void Imprimir(string Nom, String Correo, String Cupon, string nomP, double Precio)
{
    Console.WriteLine("\n----INFORMACIÓN DEL CLIENTE----\n Nombre : {0} \n Email: {1} \n Cupon: {2} \n "
                    , Nom, Correo, Cupon);

    Console.WriteLine("\n----DESCRIPCIÓN DEL PRODUCTO----\n Producto : {0} \n Precio : COP{1}  "
                   , nomP, Precio, Cupon);
}



