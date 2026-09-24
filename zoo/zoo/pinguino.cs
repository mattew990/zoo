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