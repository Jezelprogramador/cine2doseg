using System;
using System.Data;
using System.Web.Http;
using cine2doseg.Models.cine2doseg.Models;
using cine2doseg.Models;

public class SucursalController : ApiController
{
    private DbHelper dbHelper = new DbHelper();

    // Endpoint para obtener las sucursales
    [HttpGet]
    [Route("cine/sucursal/vwrptsucursales")]
    public IHttpActionResult VwRptSucursales()
    {
        try
        {
            string query = "SELECT * FROM vwRptSucursales";
            DataSet ds = dbHelper.ExecuteQuery(query);
            return Ok(new clsApiStatus(0, "Consulta exitosa", ds.Tables[0]));
        }
        catch (Exception ex)
        {
            return InternalServerError(new clsApiStatus(1, "Error: " + ex.Message, null));
        }
    }

    private IHttpActionResult InternalServerError(clsApiStatus clsApiStatus)
    {
        throw new NotImplementedException();
    }

    // Endpoint para insertar una sucursal
    [HttpPost]
    [Route("cine/sucursal/spinssucursales")]
    public IHttpActionResult SpInsSucursales([FromBody] clsSucursal sucursal)
    {
        try
        {
            string query = $"CALL spInsSucursales('{sucursal.Nombre}', '{sucursal.Direccion}', '{sucursal.Url}', '{sucursal.Logo}', @Resultado)";
            int resultado = dbHelper.ExecuteNonQuery(query);
            return Ok(new clsApiStatus(resultado, "Operación completada", null));
        }
        catch (Exception ex)
        {
            return InternalServerError(new clsApiStatus(1, "Error: " + ex.Message, null));
        }
    }
}
