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

Console.WriteLine("PERSONAJE ORIGINAL");
Console.WriteLine(" ");

foreach (string elemento in sprite)
{
    if (elemento == "SALTO")
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write(elemento);
    }
}

Console.WriteLine(" ");

List<string> colores = new List<string> { "Rojo", "Verde", "Azul", "Amarillo", "Cian", "Magenta", "Blanco" };

Console.WriteLine("Colores disponibles para personalizar:");
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

Console.WriteLine(" ");
Console.WriteLine("¡Iniciemos la personalización!");

ConsoleColor colorHashtag = ConsoleColor.White;

switch (hashtag.ToLower())

{
    case "rojo": colorHashtag = ConsoleColor.Red; break;
    case "verde": colorHashtag = ConsoleColor.Green; break;
    case "azul": colorHashtag = ConsoleColor.Blue; break;
    case "amarillo": colorHashtag = ConsoleColor.Yellow; break;
    case "cian": colorHashtag = ConsoleColor.Cyan; break;
    case "magenta": colorHashtag = ConsoleColor.Magenta; break;
    case "blanco": colorHashtag = ConsoleColor.White; break;
}

ConsoleColor colorMas = ConsoleColor.White;

switch (mas.ToLower())
{
    case "rojo": colorMas = ConsoleColor.Red; break;
    case "verde":     colorMas = ConsoleColor.Green; break;
    case "azul":      colorMas = ConsoleColor.Blue; break;
    case "amarillo":  colorMas = ConsoleColor.Yellow; break;
    case "cian":      colorMas = ConsoleColor.Cyan; break;
    case "magenta":   colorMas = ConsoleColor.Magenta; break;
    case "blanco":    colorMas = ConsoleColor.White; break;
}

ConsoleColor colorArroba = ConsoleColor.White;

switch (arroba.ToLower())
{
    case "rojo":     colorArroba = ConsoleColor.Red; break;
    case "verde":    colorArroba = ConsoleColor.Green; break;
    case "azul":     colorArroba = ConsoleColor.Blue; break;
    case "amarillo": colorArroba = ConsoleColor.Yellow; break;
    case "cian":     colorArroba = ConsoleColor.Cyan; break;
    case "magenta":  colorArroba = ConsoleColor.Magenta; break;
    case "blanco":   colorArroba = ConsoleColor.White; break;
}

Console.WriteLine(" ");
Console.WriteLine("Tu personaje personalizado:");

foreach (string elemento in sprite)
{
    if (elemento == "SALTO")
    {
        Console.WriteLine();
    }
    else if (elemento == "#")
    {
        Console.ForegroundColor = colorHashtag;
        Console.Write(elemento);
        Console.ResetColor();
    }
    else if (elemento == "+")
    {
        Console.ForegroundColor = colorMas;
        Console.Write(elemento);
        Console.ResetColor();
    }
    else if (elemento == "@")
    {
        Console.ForegroundColor = colorArroba;
        Console.Write(elemento);
        Console.ResetColor();
    }
    else
    {
        Console.Write(elemento);
    }
}

Console.WriteLine(" ");
