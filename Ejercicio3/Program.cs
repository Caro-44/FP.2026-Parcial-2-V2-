// Carolina Ortiz Villavicencio.
// Pablo Mateo Martínez Baéz.

/*
 EJERCICIO 3
 Generar un programa que genere una cantidad aleatoria de ciudades administradas (aleatorio), cantidad de edificios y mejoras por ciudad (aleatoria),
 identificar que ciudad produce mayor cantidad de material (madera, piedra y oro) y la cantidad que se generó.

 ENTRADAS:
 Cantidad de ciudades que serán analizadas.

 SALIDAS:
 1. Número de ciudades
 2. Número de edificios y mejoras por ciudad.
 3. Cantidad de materia producida.
 4. La ciudad que más generó.

*/

const int CIUDADES  = 3;
const int EDIFICIOS_MAX = 8;
const int EDIFICIOS_MIN = 2;
const int MEJORAS_MAX   = 4;
const int MEJORAS_MIN   = 2;
const int MADERA_MAX    = 100;
const int MADERA_MIN    = 1;
const int PIEDRA_MAX    = 100;
const int PIEDRA_MIN    = 1;
const int ORO_MAX       = 100;
const int ORO_MIN       = 1;

int ciudadUno;
int ciudadDos;
int ciudadTres;
var rng    = new Random();
int madera = rng.Next(MADERA_MIN, MADERA_MAX + 1);
int piedra = rng.Next(PIEDRA_MIN, PIEDRA_MAX + 1);
int oro    = rng.Next(ORO_MIN, ORO_MAX + 1);

Console.WriteLine("La cantidad de ciudades que hay: " + CIUDADES);

int edificios = rng.Next(EDIFICIOS_MIN, EDIFICIOS_MAX + 1);
Console.WriteLine("La cantidad de edificios que hay por ciudad es de: "  + edificios);

int mejoras = rng.Next(MEJORAS_MIN, MEJORAS_MAX + 1);
Console.WriteLine("Las mejoras disponbibles son:  " + mejoras);

Console.WriteLine(" ");

Console.WriteLine("¿Cuántas ciudades deseas analizar?");
string analisisCiud = Console.ReadLine();

if (analisisCiud != "1" && analisisCiud != "2" && analisisCiud != "2");
{
    Console.WriteLine("Valor inválido, ingrese un número del 1 al 3.");

    if (analisisCiud == "3")
    {
        Console.WriteLine("La cantidad de materiales que generó ciudad 1 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");

        Console.WriteLine("La cantidad de materiales que generó ciudad 2 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");

        Console.WriteLine("La cantidad de materiales que genera ciudad 3 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");

        Console.WriteLine("La cantidad de materiales que genera ciudad 3 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");
    }

    else if (analisisCiud == "2")
    {
        Console.WriteLine("La cantidad de materiales que generó ciudad 1 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");

        Console.WriteLine("La cantidad de materiales que generó ciudad 2 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");
    }

    else if (analisisCiud == "1")
    {
        Console.WriteLine("La cantidad de materiales que generó ciudad 1 es de: ");
        Console.WriteLine("Madera: " + madera);
        Console.WriteLine("Piedra: " + piedra);
        Console.WriteLine("Oro: " + oro);
        Console.WriteLine(" ");
    }
}

Console.WriteLine("");


