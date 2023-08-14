
Enumera enumera = new Enumera();
enumera.CreaEnum();



Console.ReadLine();



public class Enumera
{
    public void CreaEnum()
    {
        Console.WriteLine(Zabeca.BochaArriba);

        var e = new Zabeca();

        int c = (int)Zabeca.BochaArriba;
        Console.WriteLine(c);
    }

    public enum Zabeca { Pelado, Frenteancha, BochaArriba = 4, PeloJusto = 3, PeloParaRegalar = 2 };
}

