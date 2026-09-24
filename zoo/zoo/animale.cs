public class Animale
{
    protected string nome;
    protected int eta;
    protected bool isDiurno;

    public Animale(string nome, int eta, bool isDiurno)
    {
        this.nome = nome;
        this.eta = eta;
        this.isDiurno = isDiurno;
    }

    public Animale()
    {
        this.nome = "Error";
        this.eta = 404;
        this.isDiurno = true;
    }

    public void faiVerso()
    {
        Console.WriteLine("...");
    }

    public void Mangia()
    {
        Console.WriteLine("l'animale sta mangiando");
    }

    public void getInfo()
    {
        Console.WriteLine($"{this.nome} ha {this.eta} anni e {(this.isDiurno ? "è diurno" : "non è diurno")}");
    }
}

public class Leone : Animale
{
    private int volumeRuggito;

    public void faiVerso()
    {
        Console.WriteLine("ROAR!!!!");
    }

    public void Mangia()
    {
        Console.WriteLine("il leone mangia carne fresca");
    }
}

public class Pinguino : Animale
{
    private double velocitaNuoto;

    public void faiVerso()
    {
        Console.WriteLine("squittio acuto");
    }

    public void Nuota()
    {
        Console.WriteLine($"il pinguino nuota a {this.velocitaNuoto} km/h");
    }
}

public class Pappagallo : Animale
{
    private double aperturaAalare;

    public void faiVerso(string s)
    {
        Console.WriteLine($"craa! {s}");
    }
}