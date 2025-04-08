using CAI_ejericico_login.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_ejericico_login
{
   public partial class formLogin : Form
    {
        PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
        public formLogin()
        {
            InitializeComponent();
        }
        // Agregar el método formLogin_Load en el archivo Form1.cs
        private void formLogin_Load(object sender, EventArgs e)
        {
            // Código que se ejecutará cuando el formulario se cargue
            InitializeComponent();
        }



        private void btnIniciarSes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }

        private List<String> obtenerUsuarios()
        {
            List<String> listado = persistenciaUtils.LeerRegistro("credenciales.csv");

            return listado;
        }
    }
}
