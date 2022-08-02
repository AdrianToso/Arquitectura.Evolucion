using ApplicationService;
using Domain;
using Services;
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
    public partial class FormMain : Form
    {
      
        UserAppService _usr;
        LoginAppService _login;
     
       
        public void ValidarForm()
        {
          if (!SessionHandler.isLogged())

                this.lblSesion.Text = "Inicie sesion";
            else
            {
                this.lblSesion.Text = SessionHandler.Session.Username;
            }
            this.mnuLogin.Enabled= !SessionHandler.isLogged();
            this.mnuLogout.Enabled = SessionHandler.isLogged();
        }
        public FormMain()
        {           
            InitializeComponent();
            ValidarForm();
            _usr = new UserAppService();
            _login = new LoginAppService(); 
        }
       
        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm= new frmLogin();
            frm.MdiParent= this;
           frm.Show();
        }
        
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            SessionHandler.CerrarSession();
            ValidarForm();
        }

    }
}
