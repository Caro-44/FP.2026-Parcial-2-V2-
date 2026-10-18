// Carolina Ortiz Villavicencio.
// Pablo Mateo Martínez Baéz.

/*
 EJERCICIO 1
Desarrollar un programa que sea capaz de asignar precios a cinco herramientas, fabricar una cantidad de materia prima aleatoria entre cien y mil unidades
registrar órdenes y comience a preparar las herramientas una vez que las solicitudes terminen.

ENTRADAS
1. Órdenes de herramientas

SALIDAS
1.  Costos de herramientas.
2. Herramientas que se fabricaron.
3. Herramientas que no se fabricaron.
4. Cantidad de materia prima inicial.
5. Cantidad de materia prima restante.
6. Cantidad de materia prima utilizada.

*/

const int HACHA             = 40 ;
const int PALAS             = 20 ;
const int PICOS             = 30 ;
const int LANZAS            = 60 ;
const int MARTILLOS         = 50 ;
const int MATERIA_PRIMA_MIN = 100;
const int MATERIA_PRIMA_MAX = 1000;

int contHacha = 0;
int contPala = 0;
int contPico     = 0;
int contLanza = 0;
int contMartillo = 0;

var rng = new Random();

//Madera que se generó
int madera          = rng.Next(MATERIA_PRIMA_MIN,MATERIA_PRIMA_MAX + 1);
int maderaInicial   = madera;
int maderaUtilizada = 0;
Console.WriteLine("La cantidad de madera que se tiene es de " + madera);
Console.WriteLine(" ");

Console.WriteLine("Herramientas y su precio.");
Console.WriteLine(HACHA + " de madera por hacha.");
Console.WriteLine(PALAS + " de madera por pala.");
Console.WriteLine(PICOS + " de madera por pico.");
Console.WriteLine(LANZAS + " de madera por lanza.");
Console.WriteLine(MARTILLOS + " de madera por martillo.");
Console.WriteLine(" ");

Console.WriteLine("Menú para realizar su pedido.");
Console.WriteLine("1 para hacha.");
Console.WriteLine("2 para pala.");
Console.WriteLine("3 para pico.");
Console.WriteLine("4 para lanza.");
Console.WriteLine("5 para martillo.");
Console.WriteLine("-1 para finalizar pedidos.");
Console.WriteLine(" ");

List<int> ordenes = new List<int>();
int       pedidos = 0;

while (pedidos != -1)
{
    Console.WriteLine("Ingrese su orden.");
    string entrada = Console.ReadLine();
    if (!int.TryParse(entrada, out pedidos))

{
    Console.WriteLine("Dato inválido. Escriba un número solicitado.");
}
else if (pedidos == -1)
{
    Console.WriteLine("Registro de órdenes finalizado.");

}
    else if (pedidos != 1 && pedidos != 2 && pedidos != 3 &&  pedidos != 4 && pedidos != 5)
    {
        Console.WriteLine("Número inválido. Escriba uno de los solicitados.");
    }
else
{
    ordenes.Add(pedidos);
}
}

Console.WriteLine(" ");
Console.WriteLine("Inicia la producción.");

foreach (int pedido in ordenes)
{
    int costoHerramientas = 0;

    switch (pedido)
    {
        case 1: costoHerramientas = HACHA; break;
        case 2: costoHerramientas = PALAS; break;
        case 3: costoHerramientas = PICOS; break;
        case 4: costoHerramientas = LANZAS; break;
        case 5: costoHerramientas = MARTILLOS; break;
    }

    if (madera >= costoHerramientas)
    {
        madera          -= costoHerramientas;
        maderaUtilizada += costoHerramientas;
        if (pedido == 1) contHacha++;
        else if (pedido == 2) contPala++;
        else if (pedido == 3) contPico++;
        else if (pedido == 4) contLanza++;
        else if (pedido == 5) contMartillo++;

        Console.WriteLine("La herramienta " + pedido + " fue realizada con éxito.");
    }
    else
    {
        Console.WriteLine("No hay suficiente madera para completar la orden " + pedido + ".");
        break;
    }
}

Console.WriteLine(" ");
Console.WriteLine("RESULTADOS DE FABRICACIÓN.");
Console.WriteLine("Madera inicial: " + maderaInicial);
Console.WriteLine("Madera utilizada: " +  maderaUtilizada);
int maderaRestante = maderaInicial - maderaUtilizada;
Console.WriteLine("Madera restante: " + maderaRestante);
Console.WriteLine(" ");

Console.WriteLine("HERRAMIENTAS FABRICADAS.");
Console.WriteLine("Hachas: " + contHacha);
Console.WriteLine("Palas: " + contPala);
Console.WriteLine("Picos: " + contPico);
Console.WriteLine("Lanzas: " + contLanza);
Console.WriteLine("Martillos: " + contMartillo);
