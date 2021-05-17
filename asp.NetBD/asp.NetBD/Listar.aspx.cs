using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.NetBD
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }


        private void CarregarCliente() 
        {
            string query = @"Select cli_id, cli_nome from cliente";
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, Conexao.Connection);
                da.Fill(dt);

                rptClientes.DataSource = dt;
                rptClientes.DataBind();
            }
            catch (Exception ex)
            {
                lblMsg.Text = $"Error: {ex.Message}";
            }
            finally 
            {
                Conexao.Desconectar();
            }
        }
    }
}