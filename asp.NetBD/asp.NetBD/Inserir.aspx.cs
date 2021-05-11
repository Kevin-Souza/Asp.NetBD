using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.NetBD
{
    public partial class Inserir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"insert into cliente
                                    (cli_nome, cli_logradouro, cli_numero,
                                     cli_complemento, cli_bairro, cli_cidade, cli_uf)
                                     values
                                     (@nome, @logradouro, @numero, @complemento, @bairro, @cidade, @uf)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@uf", txtUF.Text);

                Conexao.Conectar();

                cmd.ExecuteNonQuery();
                lblResultado.Text = "Cliente Inserido";


            }
            catch (Exception ex)
            {
                lblResultado.CssClass = "text text-danger";
                lblResultado.Text = $"Erro: {ex.Message}";

            }
            finally
            {
                Conexao.Desconectar();
            
            }
        }
    }
}