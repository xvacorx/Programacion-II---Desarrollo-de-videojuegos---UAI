int puntuacion = 0;
string ingresado;

int SumarPuntos()
{
    if (ingresado == "")
    {
        puntuacion++;
    }
    return puntuacion;
}

Console.WriteLine("Para sumar 1 punto presione Enter\n");
Console.WriteLine("Puntuacion actual: " + puntuacion);
Console.Write("-> (Enter) ");
ingresado = Console.ReadLine();
Console.WriteLine();

while (ingresado == "")
{
    SumarPuntos();

    Console.WriteLine("Puntuacion actual: " + puntuacion);
    Console.Write("-> (Enter) ");
    ingresado = Console.ReadLine();
    Console.WriteLine();
}

Console.WriteLine("Suma de puntos finalizada\nPuntuación final: " + puntuacion); 
