using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final
{
    public partial class ModificarCita : System.Web.UI.Page
    {
        string IdCita = string.Empty;
        string strConexion = "Server=(Local); Database=Tienda; Integrated Security=true;";
        protected void Page_Load(object sender, EventArgs e)
        {
            IdCita = Request.QueryString["id"];
            if (string.IsNullOrEmpty(IdCita))
            {
                Response.Redirect("citas.aspx");
            }

            if (!Page.IsPostBack)
            {
                cargarDatosCitas();
            }
        }
        void cargarDatosCitas()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                var sql = "Select * From cita Where IdCita=@id";
                using (var command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@id", IdCita);
                    var reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        txtHora.Text = reader["Nombre"].ToString();
                        txtDia.Text = reader["Dia"].ToString();
                        txtServicio.Text = reader["Servicio"].ToString();
                        txtNombreVeterinario.Text = reader["NombreVeterinario"].ToString();
                        txtApellido.Text = reader["ApellidoVeterinario"].ToString();
                        txtNombre.Text = reader["NombreMascota"].ToString();
                        txtRaza.Text = reader["Raza"].ToString();

                    }
                }
            }
        }
        protected void actualizar(object sender, EventArgs e)
        {
            var Hora = txtHora.Text;
            var Dia = txtDia.Text;
            var Servicio = txtServicio.Text;
            var NombreVeterinario = txtNombreVeterinario.Text;
            var ApellidoVeterinario = txtApellido.Text;
            var NombreMascota = txtNombre.Text;
            var Raza = txtRaza.Text;

            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                var sql = "Update cita Set Hora=@nombre, Dia=@marca, " +
                    "Servicio=@precio, NombreVeterinario=@observacion,ApellidoVeterinario=@ApellidoVeterinario,NombreMascota=@NombreMascota,Raza=@Raza " +
                    "Where IdCita=@id";
                using (var command = new SqlCommand(sql, conexion))
                {

                    command.Parameters.AddWithValue("@Hora", Hora);
                    command.Parameters.AddWithValue("@Dia", Dia);
                    command.Parameters.AddWithValue("@Servicio", Servicio);
                    command.Parameters.AddWithValue("@NombreVeterinario", NombreVeterinario);
                    command.Parameters.AddWithValue("@ApellidoVeterinario", ApellidoVeterinario);
                    command.Parameters.AddWithValue("@NombreMascota", NombreMascota);
                    command.Parameters.AddWithValue("@Raza", Raza);
                    command.Parameters.AddWithValue("@id", IdCita); 
                    int filas = command.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        var script = "alert('Cita Modificada'); ";
                        script += "window location='citas.aspx';";

                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                   "mensaje", "alert('Cita Modificada')", true);

                    }

                }
            }
        }

    }
}