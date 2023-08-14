using static ConcreteFactory2;


ConcreteFactory1 ConcreteFactory1=new ConcreteFactory1();
Console.WriteLine(ConcreteFactory1.CreateProductA().MetodoA());
Console.WriteLine(ConcreteFactory1.CreateProductB().MetodoB());
Console.WriteLine(ConcreteFactory1.CreateProductB().OtroMetodoB(ConcreteFactory1.CreateProductA()));
//estas formas son algo mas intuitivas pero son incorrectas, la que iría es la de ajoba.

Console.WriteLine("\n-------------------------\n");
Cliente cliente1=new Cliente();
cliente1.MetodoCliente(ConcreteFactory1);





public class Cliente
{

   public void MetodoCliente(IAbstractFactory factory)
    {
        var ProductA1 = factory.CreateProductA();
        Console.WriteLine(ProductA1.MetodoA());


    }

}


public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

public class ConcreteFactory1:IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }

    public interface IAbstractProductA
    {
        string MetodoA();
    }

    public class ConcreteProductA1 : IAbstractProductA
    {
        public string MetodoA()
        {
            return "Desde Método A1 en ConcretoProductA1";
        }
    }
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string MetodoA()
        {
            return "Desde Método A en ConcretoProductA1";
        }
    }

    public interface IAbstractProductB
    {
        string MetodoB();
        string OtroMetodoB(IAbstractProductA colaborador);
    }

    public class ConcreteProductB1 : IAbstractProductB
    {
        public string MetodoB()
        {
            return "Desde Método B1 en ConcretoProductB1";
        }
         
        public string OtroMetodoB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.MetodoA();
            return "El resultado de la colaboración con A es: " + resultado;
        }

    }
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string MetodoB()
        {
            return "Desde Método B en ConcretoProductB2";
        }
        public string OtroMetodoB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.MetodoA();
            return "El resultado de la colaboración con A es: " + resultado;
        }
    }

   
}