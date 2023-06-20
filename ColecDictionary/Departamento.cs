namespace Departamentos
{
    //clase que define un departamento con su nombre y población
    public class departamento
    {
        public string Name {get; set; }
        public int population {get; set; }
        
        public depto (String n, int poblacion)
        {
            Name = n;
            population = poblacion; 
        }
    }
}