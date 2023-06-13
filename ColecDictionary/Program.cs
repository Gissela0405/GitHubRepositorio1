


using System.Collections;
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);

int maxDep = Poblacion.Max();
int minDep = Poblacion.Min();
string maxDepkey = "", minDepkey = "";

for (var i = 0; i < Poblacion.Length; i++)
{
    if (Poblacion[i] == maxDep)
        maxDepkey = Departamento[i];
    if (Poblacion[i] == minDep)
        minDepkey = Departamento[i];
}

var ordenado = diccionario.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Departamento = ordenado.Keys.ToArray();
Poblacion = ordenado.Values.ToArray();

for (var i = 0; i < Poblacion.Length; i++)
    Console.WriteLine($"{Departamento[i],20} ==> {Poblacion[i],10:N0}");

Console.WriteLine($"Población General:{Poblacion.Sum():N0}");
Console.WriteLine($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine($"Departamento con menor Población:{minDepkey}");