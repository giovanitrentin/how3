using BLL;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class EfetuarLogin : Form
    {
        public EfetuarLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(EfetuaLoginBLL.EfetuaLogin(login.Text, senha.Text))
            {
                var form = new CadastroCliente();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos");
            }
        }
    }
}
