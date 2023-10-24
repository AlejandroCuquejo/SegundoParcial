using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CiudadService {
    
    CiudadDatos ciudadDatos;
    
    public CiudadService(string cadenaConexion) {
        ciudadDatos = new CiudadDatos(cadenaConexion);
    }

    public void insertarCiudad(CiudadModel ciudad) {
        validarDatos(ciudad);
        ciudadDatos.insertarCiudad(ciudad);
    }
    
    public List<CiudadModel> obtenerTodasLasCiudad()
    {
        return ciudadDatos.obtenerTodasLasCiudad();
    }

    
    public CiudadModel obtenerCiudad(int id)
    {
        return ciudadDatos.obtenerCiudadPorId(id);
    }

    public void modificarCiudad(CiudadModel ciudad)
    {
        validarDatos(ciudad);
        ciudadDatos.modificarCiudad(ciudad);
    }  
    
    public CiudadModel EliminarCiudadPorId(int id) {
        return ciudadDatos.EliminarCiudadPorId(id);
    }
    
    private void validarDatos(CiudadModel ciudad)
    {
        if(ciudad.ciudad.Trim().Length < 2 )
        {
            throw new Exception("El campo ciudad no puede ser nulo");
        }   
        if(ciudad.departamento.Trim().Length < 2 )
        {
            throw new Exception("El campo departamento no puede ser nulo");
        }   
        if(ciudad.postal_code < 2 )
        {
            throw new Exception("El campo postal_code no puede ser nulo");
        }
    }
}