using net_proyect;
using net_proyect.Models;

public class TareasService : ITareasService
{
    TareasContext context;

    public TareasService(TareasContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Tarea> Get()
    {
        return context.Tareas;
    }
}

public interface ITareasService
{
    IEnumerable<Tarea> Get();
}