using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class PersonaService
{
    PersonaDatos personaDatos;

    public PersonaService(string cadenaConexion) {
        personaDatos = new PersonaDatos(cadenaConexion);
    }

    public List<PersonaModel> obtenerTodasLasPersona()
    {
        return personaDatos.obtenerTodasLasPersonas();
    }

    public PersonaModel obtenerPersonaPorId(int id)
    {
        return personaDatos.obtenerPersonaPorId(id);
    }

    public void registrarPersona(PersonaModel persona)
    {
        validarDatos(persona);
        personaDatos.insertarPersona(persona);
    }
    
    public void modificarPersona(PersonaModel persona)
    {
        validarDatos(persona);
        personaDatos.modificarPersona(persona);
    }  
    
    public CiudadModel EliminarPersona(int id) {
        return personaDatos.EliminarPersnaPorId(id);
    }
    
    private void validarDatos(PersonaModel persona)
    {
        if(persona.nombre.Trim().Length < 2 )
        {
            throw new Exception("El campo nombre no puede ser nulo");
        }
        if(persona.apellido.Trim().Length < 2 )
        {
            throw new Exception("El campo apellido no puede ser nulo");
        } 
        if(persona.nro_documento.Trim().Length < 2 )
        {
            throw new Exception("El campo nro_documento no puede ser nulo");
        }  if(persona.direccion.Trim().Length < 2 )
        {
            throw new Exception("El campo direccion no puede ser nulo");
        }  
        if(persona.email.Trim().Length < 2 )
        {
            throw new Exception("El campo email no puede ser nulo");
        }  
        if(persona.celular.Trim().Length < 2 )
        {
            throw new Exception("El campo celular no puede ser nulo");
        }  
        if(persona.estado.Trim().Length < 1 )
        {
            throw new Exception("El campo estado no puede ser nulo");
        }  
        if(persona.estado.Trim().Length < 0 )
        {
            throw new Exception("El campo estado no puede ser negativo");
        } 
        if(persona.ciudad.id_ciudad < 1 )
        {
            throw new Exception("El campo id_ciudad no puede ser nulo");
        } 
    }
}