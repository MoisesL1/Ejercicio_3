Dictionary <string, double> notas = new Dictionary<string, double>();

Console.WriteLine("Ingrese la cantidad de estudiates que ingresara: ");
int cant = int.Parse(Console.ReadLine());

string estudiante;

for(int x = 0; x < cant; x++)
{
    Console.WriteLine("Ingrese el nombre del estudiante: ");
    estudiante = Console.ReadLine();
    Console.WriteLine("Ingrese la nota: ");
    double nota = double.Parse(Console.ReadLine());

    notas.Add(estudiante, nota);
}

Console.WriteLine("Ingrese el ID del estudiante que desea ver: ");
estudiante = Console.ReadLine();

if (notas.ContainsKey(estudiante) == true)
{
    Console.WriteLine(notas[estudiante]);
}

else
{
    Console.WriteLine("Ingreso un nombre invalido. ");
}