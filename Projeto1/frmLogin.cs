using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto1
{
    public partial class frmLogin : Form
    {
        //instanciando a string  de conexao
        Conexao con = new Conexao();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuario e Senha invalidos.");
            }
            //tentar
            //aqui ele vai aprender os comandos do sql.
            try
            {
                string sql = "select * from tbLogin where usuario=@user and senha = @senha";
                //o con levou o cmd pra entender oque tem la no sql
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                //essa parte de baixo explica pra variavel sql oque eu escrevi
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                //mysqladapter é o nome da função que leva as informações pro c#
                MySqlDataReader dados;
                dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    MessageBox.Show("Seja bem-vindo ao Sistema");
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception error0)
            {
                MessageBox.Show(error0.Message);
            }
            //essa parte serve para finalizar e fechar o Mysql, segurança
            finally
            {
                con.DesConnectarBD();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
