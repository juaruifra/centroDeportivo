using centroDeportivo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class ActividadesRepository : RepositoryBase
{
    /// <summary>
    /// Obtener todas las actividades
    /// </summary>
    /// <returns></returns>
    public List<Actividades> GetAll()
    {
        return Context.Actividades.ToList();
    }

    /// <summary>
    /// Crear o editar actividad
    /// </summary>
    /// <param name="ac"></param>
    /// <exception cref="Exception"></exception>
    public void Save(Actividades ac)
    {
        try { 
            if (ac.Id < 1)
            {
                Context.Actividades.Add(ac);  // Insertar
            }
            else
            {
                // Actualizar
                var a = Context.Actividades.Find(ac.Id);

                // Modificamos los datos
                a.Nombre = ac.Nombre;
                a.AforoMaximo = ac.AforoMaximo;

            }

            Context.SaveChanges(); // Guardar cambios
        }
        catch (Exception ex) {
            throw new Exception("Error guardar actividad BBDD.", ex);
        }
    }
    /// <summary>
    /// Borrar actividad
    /// </summary>
    /// <param name="ac"></param>
    /// <exception cref="Exception"></exception>
    public void Delete(Actividades ac)
    {
        try { 
            Context.Actividades.Remove(ac); // Marcar para eliminación
            Context.SaveChanges(); // Ejecutar los cambios
        }
        catch (Exception ex) {
            throw new Exception("Error borrar actividad BBDD.", ex);
        }
    }


}
