// Ejemplo de Agregación
class Pez
{
    public string Nombre;
    public Pez(string nombre)
    {
        Nombre = nombre;
    }
}

class Acuario
{
    public List<Pez> Peces = new List<Pez>();

    public void AgregarPez(Pez p)
    {
        Peces.Add(p);
    }
}

// Ejemplo de Composición
class Aleta
{
    public string Lado;
    public Aleta(string lado)
    {
        Lado = lado;
    }
}

class Orca
{
    private Aleta aletaIzq;
    private Aleta aletaDer;

    public Orca()
    {
        aletaIzq = new Aleta("Izquierda");
        aletaDer = new Aleta("Derecha");
    }
}
