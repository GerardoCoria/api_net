using Microsoft.AspNetCore.Mvc;
using api_net.Services;
using net_proyect.Models;

namespace api_net.Controllers;

[Route("api/[controller]")]
public class TareaController : ControllerBase
{
    ITareasService tareasService;

    public TareaController(ITareasService service)
    {
        tareasService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tareasService.Get());
    }

    //[HttpPost]
    //public IActionResult Post([FromBody]Categoria categoria)
    //{
    //    tareasService.Save(categoria);
    //    return Ok();
    //}
//
    //[HttpPut("{id}")]
    //public IActionResult Put(Guid id, [FromBody]Categoria categoria)
    //{
    //    tareasService.Update(id, categoria);
    //    return Ok();
    //}
//
    //[HttpDelete("{id}")]
    //  public IActionResult Delete(Guid id)
    //{
    //    tareasService.Delete(id);
    //    return Ok();
    //} 
}