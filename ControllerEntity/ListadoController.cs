using DataEntity;
using Models;
using System.Data;

namespace ControllerEntity;

public class ListadoController
{
    public void CreateObjLista (string NombreLista)
    {
        // creacion del obj Lista.
        Global.GlobalLista.NombreLista = NombreLista;
        Global.GlobalLista.EmailUsuario = null;
    }

    public bool MthAddNewList(string NombreLista)
    {
        // se obtiene de la clase LoginDataEntity el email del usuario actual.
        string email = LoginDataEntity.EmailUsuarioActual;
        return Global.LDE.NuevaLista(NombreLista, email); // retorna un boleano
    }

    public DataTable MthGetList()
    {
        // se obtiene de la clase LoginDataEntity el email del usuario actual.
        string email = LoginDataEntity.EmailUsuarioActual;
        // se llama al metodo TraerListado de la clase ListadoDataEntity
        DataTable dataTable = Global.LDE.TraerListado(email); 
        return dataTable;

        // Si el DataTable tiene filas, podemos actualizar el CurrentListId
        if (dataTable.Rows.Count > 0)
        {
            Global.CurrentListId = Convert.ToUInt32(dataTable.Rows[0]["idLista"]);
        }
        else
        {
            Global.CurrentListId = 0; 
        }
    }

    internal void UpdateIdlista ()
    {

    }
}
