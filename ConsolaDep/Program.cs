Console.WriteLine("Hello, World!");

public class Deportes
{
    public int IdDep = 0;
    public String? Nombre = "";
}
public class TiposD
{
    public int IdT = 0;
    public String? Nombre = "";
}

public class EntrenadorD
{
    public int IdEntr = 0;
    public String? Nombre = "";
    public DateTime fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public TiposD Tipo = new TiposD();
    public List<Deportes> Deportes = new List<Deportes>();
}

public class JugadoresD
{
    public int IdJug = 0;
    public String? Nombre = "";
    public DateTime fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public TiposD Tipo = new TiposD();
    public List<Deportes> Deportes = new List<Deportes>();
}


