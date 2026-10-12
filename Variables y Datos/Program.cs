/*
Cuando se tienen muchas variables, en vez de usar var "definir" e ir escribiendo variable por variable, podemos utilizar:

"inventory" se utiliza para guardar varios elementos de un tipo. Es un arreglo. Los arreglos son una estructura
de datos que almacena una cantidad definida de elementos del mismo tipo.

 */

// Arreglos

using System;

// Antes de ejecutar, responde:
// - ¿Cuántos valores contiene inventory?
//   Tiene 3 valores.

// - ¿Qué representa [0]?
//   Espada.

// - ¿Qué mostrará inventory[2]?
//   EL índice 2, que es Llave.

// - ¿Qué cambia en la línea 11?
//

// - ¿Cuántas veces se ejecutará el for?
//   La misma cantidad de elementos que lleve el arreglo

// - ¿Qué contiene inventory.Length?
//


// Después de ejecutar, realiza estos cambios:
// - Reemplaza la declaración de valores por la de longitud
// - Asigna los valores
// - Agrega un nuevo elemento "Espada" al arreglo
// - Asigna "Linterna" a inventory[inventory.Length - 1]
// - Imprime inventory.Length
// - Imprime los 4 valores
// - Asigna "Hacha" a inventory[5]
// - Asigna "Casco" a inventory[-1]


string[] inventory =
[
    "Espada",
    "Poción",
    "Llave",
    "Espada",

];


for (var i = 0; i < inventory.Length; ++i)
{
    Console.WriteLine(inventory[i]);
}

Console.WriteLine("\n");
Console.WriteLine(inventory[0]);
Console.WriteLine(inventory[2]);

inventory[1] = "Escudo";
inventory[inventory.Length - 1 ] = "Linterna";

for (var i = 0; i < inventory.Length; ++i)
{
    Console.WriteLine(inventory[i]);
}

Console.WriteLine(inventory.Length);

// inventory[5] = "Hacha";
// inventory[-1] = "Casco";
