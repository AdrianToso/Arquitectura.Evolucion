using ApplicationService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class frmLogin : Form
    {
        LoginAppService _login;
        public frmLogin()
        {
            _login = new LoginAppService(); 
            InitializeComponent();
        }
      
    private void btnLogin_Click(object sender, EventArgs e)
        {try
            {   /* s desacopla la session de la iu y se pasa al servicio
                 * frm.Sesion= _login.ValidarUsuario(this.txtName.Text, this.txtPassword.Text);
                 * */
                _login.Login(this.txtName.Text, this.txtPassword.Text);
                FormMain frm = (FormMain)this.MdiParent;
                frm.ValidarForm();
                this.Close();
                frm.Show();

            }
            catch (Exception ee )
            {
                MessageBox.Show(ee.Message);
            }

        }
    }
}
