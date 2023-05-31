public class HelloWorldService : IHelloWorldService
{
     public string GetHelloWorld()
     {
        return "Hola Otto y Ragnar!! Tienen hambre?";
     }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}