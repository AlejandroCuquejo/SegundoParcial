using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosService;


namespace Optativo_Api.Controllers;
[ApiController]
[Route("cliente/[controller]")]

public class ClienteController : Controller
{
    private ClienteService clienteServicio;
    
    public ClienteController()
    {
        clienteServicio = new ClienteService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=SegundoParcial;");
    }
    
    //Mostra porsona por ID
    //
    [HttpGet()]
    public IActionResult Get()
    {
        return Ok(clienteServicio.obtenerTodosLosClientes());
    }
    
    //    //Mostra porsona por ID
    //
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(clienteServicio.obtenerCliente(id));
    }
    //
    
    //Insertar ciudad por documento - Basico
    /*/
    [HttpPost("RegistrarPersonaBasico")]
    public IActionResult RegistrarClienteBasico([FromBody] Models.ClienteModel modelo)
    {
        clienteServicio.RegistrarClienteBasico(
            new Infraestructura.Modelos.ClienteModel()
            {
                fecha_ingreso = modelo.fecha_ingreso,
                calificacion = modelo.calificacion,
                estado = modelo.estado,
                persona  = new Infraestructura.Modelos.PersonaModel()
                {
                    id_persona = modelo.id_persona
                }
            });
        return Ok("Los datos de persona fueron insertados correctamente");
    }
    /*/
    
    //Modificar cliente
    //
    [HttpPut]
    public IActionResult ModificarCiudadAccion([FromBody] Infraestructura.Modelos.ClienteModel modelo) {
        try {
            clienteServicio.modificarCliente(modelo);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
            throw;
        }
        return Ok("se actualizo con exito");
    }
    //
    
    //Eliminar cliente
    //
    [HttpDelete("{id}")]
    public IActionResult EliminarPersona(int id)
    {
        return Ok(clienteServicio.EliminarCliente(id));
    }
    //
}