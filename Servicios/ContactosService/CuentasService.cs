using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CuentasService {
    
    CuentasDatos cuentasDatos;
    
    public CuentasService(string cadenaConexion) {
        cuentasDatos = new CuentasDatos(cadenaConexion);
    }
    
    public void RegistrarClienteBasico(CuentasModel cuentas) {
        //validarDatos(ciudad);
        cuentasDatos.RegistrarClienteBasico(cuentas);
    }
    
    public List<CuentasModel> obtenerTodasLasCuentas()
    {
        return cuentasDatos.obtenerTodasLasCuentas();
    }
    
    public CuentasModel obtenerCuentasPorId(int id) {
        Console.WriteLine("Datos obtenidos correctamente");
        return cuentasDatos.obtenerCuentasPorId(id);
    }
    
    public void modificarCuenta(CuentasModel cuentas) {
        cuentasDatos.modificarCuenta(cuentas);
    } 
    
    public CuentasModel EliminarCuentaPorId(int id) {
        return cuentasDatos.EliminarCuentaPorId(id);
    }
    
   
}
