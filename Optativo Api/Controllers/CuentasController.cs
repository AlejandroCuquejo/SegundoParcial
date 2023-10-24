using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosService;

namespace Optativo_Api.Controllers;
[ApiController]
[Route("api/[controller]")]

public class CuentasController : Controller
{
    private CuentasService cuentasService;
    
    public CuentasController()
    {
        cuentasService = new CuentasService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=SegundoParcial;");
    }
    
    //Mostra todos las cuentas
    //
    [HttpGet()]
    public IActionResult Get()
    {
        return Ok(cuentasService.obtenerTodasLasCuentas());
    }
    //
    
    
    //Mostra cliente por ID
    //
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(cuentasService.obtenerCuentasPorId(id));
    }
    //
    
    
    //Insertar ciudad  - Basico
    /*/
    [HttpPost("RegistrarClienteBasico")]
    public IActionResult RegistrarClienteBasico([FromBody] Models.CuentasModel modelo)
    {
        cuentasService.RegistrarClienteBasico(
            new Infraestructura.Modelos.CuentasModel()
            {
                nro_cuenta = modelo.nro_cuenta,
                fecha_alta = modelo.fecha_alta,
                tipo_cuenta = modelo.tipo_cuenta,
                estado = modelo.estado,
                saldo = modelo.saldo,
                nro_contrato = modelo.nro_contrato,
                costo_mantenimiento = modelo.costo_mantenimiento,
                promedio_acreditacion = modelo.promedio_acreditacion,
                moneda = modelo.moneda,
                cliente  = new Infraestructura.Modelos.ClienteModel()
                {
                    id_cliente = modelo.id_cliente
                }
            });
        return Ok("Los datos de persona fueron insertados correctamente");
    }
    /*/
    
    
    //modificar cuenta
    //
    [HttpPut]
    public IActionResult modificarCuenta([FromBody]  Infraestructura.Modelos.CuentasModel modelo) {
        try {
            cuentasService.modificarCuenta(modelo);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
            throw;
        }
        return Ok("se actualizo con exito");
    }
    //
    
    
    //Eliminar cuenta
    //
    [HttpDelete("{id}")]
    public IActionResult EliminarCuentaPorId(int id)
    {
        return Ok(cuentasService.EliminarCuentaPorId(id));
    }
    //


}