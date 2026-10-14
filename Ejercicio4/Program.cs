// Carolina Ortiz Villavicencio.
// Pablo Mateo Martínez Baéz.

/*
 EJERCICIO 4
 Arreglar el ejercicio identificando los errores de sintaxis y lógica que presenta.

*/

// Solicitar y registrar los nombres de todos los jugadores.
// Organizar aleatoriamente a los participantes en equipos.
// Respetar la cantidad máxima de integrantes por equipo.
// Incluir a todos los jugadores exactamente una vez, sin repetir ni omitir nombres.
// Numerar los equipos consecutivamente, comenzando en 1.
// Cuando la cantidad de jugadores no permita formar exclusivamente equipos completos, el último
// Equipo tendrá menos integrantes.//

Console.WriteLine("Cantidad de jugadores: ");
int      playerCount = int.Parse(Console.ReadLine());
string[] players     = new string[playerCount];
for (int i = 0; i < playerCount; i++)
{
    Console.Write($"Nombre {i + 1}: ");
    players[i] = Console.ReadLine();
}
Console.Write("Integrantes por equipo: ");
int teamSize = int.Parse(Console.ReadLine());
Random.Shared.Shuffle(players);
int team = 1;
Console.WriteLine($"Equipo {team}:"));
for (int i = 0; i < players.Length - 1; i++)
{
    if (i > 0 && i % teamSize == 1)
    {
        team++;
        Console.WriteLine($"Equipo {team}:");
    }

    Console.WriteLine(players[i % teamSize]);
    }

