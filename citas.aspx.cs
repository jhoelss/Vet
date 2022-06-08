using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final
{
    public partial class citas : System.Web.UI.Page
    {
        string strConexion = "Server=(local); Database=citas; Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        void cargarDatos()
        {

            using (var conexion = new SqlConnection(strConexion))
            {


                string sql = "select IdCita, A.Hora, Dia, Servicio, B.NombreVeterinario,B.ApellidoVeterinario, NombreMascota,Raza " +
 "from cita A inner join Veterinario B on A.IdVeterinario = B.IdVeterinario ";
                using (var command = new SqlCommand(sql, conexion))
                {
                    var ds = new DataSet();
                    var da = new SqlDataAdapter(command);
                    da.Fill(ds);
                    gvDatos.DataSource = ds;
                    gvDatos.DataBind();
                    rpDatos.DataSource = ds;
                    rpDatos.DataBind();
                }
            }
        
        }
      
        public void citaDelete(int IdCita)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM cita where IdCita= '" + IdCita + "'");
            cmd.ExecuteNonQuery();
        }

        protected void gvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdCita;
            IdCita = gvDatos.SelectedRow.Cells[2].Text;
        }

        protected void gvDatos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                citas delete = new citas();
                string IdCita;
                IdCita = gvDatos.SelectedRow.Cells[2].Text;
                delete.citaDelete(Convert.ToInt32(IdCita));
                Response.Write("<script> window.location.href='citas.aspx'; </script>");

            }
            catch(Exception)
            {
                Response.Write("<script> alert('No se pudo eliminar'); </script>");


            }
        }
    }

   
}