using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final
{
    public partial class crear_cita : System.Web.UI.Page
    {
        string strConexion = "Server=(local); Database=citas; Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { cargarDatos(); }
        }
        void cargarDatos()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();

                using (var command = new SqlCommand("Select*from Veterinario", conexion))
                {
                    var reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        ListItem Veterinario;
                        while (reader.Read())
                        {
                            Veterinario = new ListItem();
                            Veterinario.Value = reader["IdVeterinario"].ToString();
                            Veterinario.Text = reader["Especialidad"].ToString();
                    
                            ddlVeterinario.Items.Add(Veterinario);
                        }
                    }
                }
            }
        }
        protected void registrar(object sender, EventArgs e)
        {
            string Hora = txtHora.Text;
           string Dia = txtDia.Text;   
            string Servicio = ddlVeterinario.SelectedValue;
            string NombreVeterinario = txtNombreVeterinario.Text; 
            string ApellidoVeterinario = txtApellidoVeterinario.Text;
            string NombreMascota= txtNombre.Text;
            string Raza = txtRaza.Text;


            using (var conexion = new SqlConnection(strConexion))
            {
                var sql = "Insert Into cita(Hora, Dia, Servicio,NombreVeterinario,ApellidoVeterinario,NombreMascota,Raza)" +
                    "Values (@Hora, @Dia, @Servicio, @NombreVeterinario," +
                    "@ApellidoVeterinario,@NombreMascota,@Raza)";
                using (var command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@Hora", Hora);
                    command.Parameters.AddWithValue("@Dia", Dia);
                    command.Parameters.AddWithValue("@Servicio", Servicio);   
                    command.Parameters.AddWithValue("@NombreVeterinario", NombreVeterinario);
                    command.Parameters.AddWithValue("@ApellidoVeterinario", ApellidoVeterinario);
                    command.Parameters.AddWithValue("@NombreMascota", NombreMascota);
                    command.Parameters.AddWithValue("@Raza", Raza);
                    conexion.Open();
                    int filas = command.ExecuteNonQuery();
                    if (filas > 0)
                    { 
                        var script = "alert('Nueva Cita Agregada'); " +
                         "window.location='citas.aspx';";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", script, true);
                }
                    else
                    {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "mensaje", "alert('cita actualizada')", true);
                }
            }

            }
        }
    }
}

