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
int madera = rng.Next(MATERIA_PRIMA_MIN,MATERIA_PRIMA_MAX + 1);
Console.WriteLine("La cantidad de madera que se tiene es de " + madera);
Console.WriteLine(" ");

Console.WriteLine("Herramientas y su precio.");
Console.WriteLine(HACHA + " de madera por hacha.");
Console.WriteLine(PALAS + " de madera por pala.");
Console.WriteLine(PICOS + " de madera por pico.");
Console.WriteLine(LANZAS + " de madera por lanza.");
Console.WriteLine(MARTILLOS + " de madera por martillo.");

List<string> herramientas = new List<string>();
herramientas.Add("Hacha");
herramientas.Add("Pala");
herramientas.Add("Pico");
herramientas.Add("Lanza");
herramientas.Add("Martillo");

Console.WriteLine("Escribe la herramienta que deseas. (Hacha, Pala, Pico, Lanza, Martillo");
Console.ReadLine();

