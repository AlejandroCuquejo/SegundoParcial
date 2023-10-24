using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class ClienteService {
    
    ClienteDatos clienteDatos;

    public ClienteService(string cadenaConexion) {
        clienteDatos = new ClienteDatos(cadenaConexion);
    }
    
    public List<ClienteModel> obtenerTodosLosClientes()
    {
        return clienteDatos.obtenerTodosLosClientes();
    }
    
    public void RegistrarClienteBasico(ClienteModel cliente) {
        validarDatos(cliente);
        clienteDatos.insertarCliente(cliente);
    }
    
    public ClienteModel obtenerCliente(int id) {
        return clienteDatos.obtenerClientePorId(id);
    }

    public void modificarCliente(ClienteModel cliente) {
        validarDatos(cliente);
        clienteDatos.modificarCliente(cliente);
    } 
    
    public ClienteModel EliminarCliente(int id) {
        return clienteDatos.EliminarClientePorId(id);
    }
    
    private void validarDatos(ClienteModel cliente)
    {
        if(cliente.fecha_ingreso != null )
        {
            throw new Exception("El campo fecha_ingreso no puede ser nulo");
        } 
        if(cliente.calificacion.Trim().Length < 1 )
        {
            throw new Exception("El campo calificacion no puede ser nulo");
        }  
        if(cliente.estado.Trim().Length < 1 )
        {
            throw new Exception("El campo estado no puede ser nulo");
        } 
    }
}