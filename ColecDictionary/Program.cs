//programa que permita visualizar los departamentos de nicaragua con
//su cantidad poblacional.
//Encuentre:Mayor, menor, sumas y ordene los datos
using Departamentos;
//Lista de departamentos 
List<depto>lstDeptos = new List<depto>()
{
  new depto("Boaco", 185013),
  new depto("carazo",  197139),
  new depto("Chinandega", 439906),
  new depto("Chontales", 190863),
  new depto("Costa Caribe Norte", 530586),
  new depto("Costa Caribe Sur", 414543),
  new depto("Esteli", 229866),
  new depto("Granda", 214317),
  new depto("Jinotega", 475630),
  new depto("León", 421050),
  new depto("Madriz", 174744),
  new depto("Managua", 1546939), 
  new depto("Masaya", 391903),
  new deto("Nueva Segovia", 271581),
  new depto("Río San Juan", 135446),
  new depto("Rivas", 182645),
};
//Encontrar el mayor y el menor (poblacion)
depto minDepto = lstDeptos.OrderBy(d => d.population).First();
depto maxDepto = lstDeptos.OrderBy(d => d.population).Last();
//Ordenar los departamentos
var DeptOrdenado = lstDeptos.OrderBy(d => d.population);
//Mostrar departamenos ordenados
foreach (var item in DeptOrdenado)
 Console.WriteLine($"{item.Name,-20}")==>{item.population,10:NO};
//Mostrar el mayor y el menor
Console.WriteLine($"Dpto con menor poblacion: {minDepto.Name}");
Console:writeLine($"Dpto con mayor poblacion: {maxDeptp.Name}");
//Sumar todas las poblaciones con SUM de LINQ
int total = lstDeptos.Select(d => d.population).Sum();
Console.WriteLine($"Poblacion General:{total:NO}");