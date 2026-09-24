public class Animale{
    protected string nome;
    protected int eta;
    protected bool isDiurno;

    public Animale(string nome, int eta, bool isDiurno){
        this.nome = nome;
        this.eta = eta;
        this.isDiurno = isDiurno;
    };

    public void faiVerso(){
        Console.writeLine("...");
    }

    public void Mangia(){
        Console.writeLine("l'animale sta mangiando");
    }
    
    public void GetInfo(){
        Console.writeLine($"{this.nome} ha {this.eta} anni e {this.isDiurno ? "è diurno" : "non è diurno"}");
    }
}

public class Leone:Animale{
    private int volumeRuggito;

    public void faiVerso(){
        Console.writeLine("ROAR!!!!");
    }

    public void Mangia(){
        Console.writeLine("il leone mangia carne fresca");
    }
}

public class Pinguino:Animale{
    private double velocitaNuoto;

    public void faiVerso(){
        Console.writeLine("squittio acuto");
    }

    public void Nuota(){
        Console.writeLine($"il pinguino nuota a {this.velocitaNuoto} km/h");
    }
}

public class Pappagallo:Animale{
    private double aperturaAalare;

    public void faiVerso(string s){
        Console.writeLine($"craa! {s}");
    } 
}