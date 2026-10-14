// Carolina Ortiz Villavicencio.
// Pablo Mateo Martínez Baéz.

/*
 EJERCICIO 2
 Generar un programa que permita al jugador cambiar el color de los símbolos para poder personalizar su personaje.

 ENTRADAS:
 1. Color por signo (#, +, @).

 SALIDAS:
 1. Personaje coloreado.

*/

string[] sprite =
[
    " ", " ", "#", "#", "#", "#", "#", " ", " ", "SALTO",
    " ", "#", "#", "+", "+", "+", "#", "#", " ", "SALTO",
    "#", "+", "+", "@", "+", "@", "+", "+", "#", "SALTO",
    "#", "+", "+", "+", "+", "+", "+", "+", "#", "SALTO",
    "#", "+", "+", "#", "#", "#", "+", "+", "#", "SALTO",
    " ", "#", "#", "+", "+", "+", "#", "#", " ", "SALTO",
    " ", " ", "#", " ", " ", " ", "#", " ", " ", "SALTO"
];


List<string> colores = new List<string> { "Rojo", "Verde", "Azul, Amarillo, Cian, Magenta, Blanco" };

Console.WriteLine("Colores disponibles:");
foreach (string color in colores)
{
    Console.WriteLine(color);
}

Console.WriteLine(" ");
Console.WriteLine("¿Qué color deseas asignar a #?");
string hashtag = Console.ReadLine();

Console.WriteLine(" ");
Console.WriteLine("¿Qué color deseas asignar a +?");
string mas = Console.ReadLine();

Console.WriteLine(" ");
Console.WriteLine("¿Qué color deseas asignar a @?");
string arroba = Console.ReadLine();

