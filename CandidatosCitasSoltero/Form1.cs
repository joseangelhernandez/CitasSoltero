using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandidatosCitaSolteros;
using CandidatosCitasSoltero.CedulasTableAdapters;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CandidatosCitasSoltero
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCedula.Text = "000-0000000-0";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click_Async();
        }
        private async Task btnBuscar_Click_Async()
        {
            try
            {
                using (HttpClient wc = new HttpClient())
                {
                    for (int i = 0; i < 1; i++)
                    {
                        #region Consulta Padron
                        string cedulatext = txtCedula.Text;
                        string[] cedulas = cedulatext.Split('-');
                        string mun_ced = cedulas[0];
                        string seq_ced = cedulas[1];
                        string ver_ced = cedulas[2];
                        string urlstring = $"https://compulaboratoriomendez.com/lib/?Key=567811&MUN_CED={mun_ced}&SEQ_CED={seq_ced}&VER_CED={ver_ced}";
                        var json = await wc.GetStringAsync(urlstring);
                        #endregion

                        Console.WriteLine(json);

                        var js = JsonConvert.SerializeObject(json);

                        var k = json.Replace('[', ' ').Replace(']', ' ');
                        var j = JObject.Parse(k);

                        dynamic data = JObject.Parse(k);
                        Console.WriteLine(data.NOMBRES);

                        var myDetails = JsonConvert.DeserializeObject<Padron>(k);
                        Console.WriteLine(myDetails.NOMBRES);

                        txtNombre.Text = myDetails.NOMBRES;
                        txtApellido1.Text = myDetails.APELLIDO1;
                        txtApellido2.Text = myDetails.APELLIDO2;
                        txtDireccion.Text = "Direccion";
                        dtpFechaNacimiento.Value = DateTime.Parse(myDetails.FECHA_NAC);
                        txtSexo.Text = myDetails.SEXO;
                        txtEstadoCivil.Text = myDetails.EST_CIVIL;

                        Console.WriteLine(j["NOMBRES"]);
                        Console.WriteLine(j["APELLIDO1"]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CN"].ToString()))
            {
                string cedula = txtCedula.Text;
                string nombre = txtNombre.Text;
                string apellido1 = txtApellido1.Text;
                string apellido2 = txtApellido2.Text;
                DateTime fechanacimento = dtpFechaNacimiento.Value;
                string estadocivil = txtEstadoCivil.Text;
                string direccion = txtDireccion.Text;
                string sexo = txtSexo.Text;
                string telefono = txtTelefono.Text;
                bool divertida = chkDivertido.Checked;
                bool impredecible = chkImpredecible.Checked;
                bool interesante = chkInteresante.Checked;
                bool atrevido = chkAtrevido.Checked;

                // Aquí deberías agregar el código para ejecutar la inserción:
                string query = @"INSERT INTO Ciudadanos 
                    (Cedula, Nombres, Apellidos, FechaNacimiento, EstadoCivil, Direccion, Sexo, Telefono, Divertida, Impredecible, Interesante, Atrevido)
                    VALUES (@Cedula, @Nombres, @Apellidos, @FechaNacimiento, @EstadoCivil, @Direccion, @Sexo, @Telefono, @Divertida, @Impredecible, @Interesante, @Atrevido)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Nombres", nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", apellido1 + apellido2);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechanacimento);
                    cmd.Parameters.AddWithValue("@EstadoCivil", estadocivil);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Divertida", divertida);
                    cmd.Parameters.AddWithValue("@Impredecible", impredecible);
                    cmd.Parameters.AddWithValue("@Interesante", interesante);
                    cmd.Parameters.AddWithValue("@Atrevido", atrevido);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado correctamente.");
                }
            }


            CiudadanosTableAdapter ciudadanosTableAdapter = new CiudadanosTableAdapter();
            var tbl = ciudadanosTableAdapter.GetData();
            ReportDataSource dr = new ReportDataSource("CedulasDBDataSet", (DataTable)tbl);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dr);
            reportViewer1.LocalReport.Refresh();
            // TODO: This line of code loads data into the 'clientes.tblClientes' table. You can move, or remove it, as needed.
            ciudadanosTableAdapter.Fill(tbl);
            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
