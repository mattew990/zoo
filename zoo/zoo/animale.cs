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