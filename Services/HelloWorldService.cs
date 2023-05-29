public class HelloWorldService : IHelloWorldService
{
     public string GetHelloWorld()
     {
        return "Hola Otto y Ragnar!!";
     }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}