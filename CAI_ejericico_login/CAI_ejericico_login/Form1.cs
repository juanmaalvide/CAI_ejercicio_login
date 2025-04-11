using CAI_ejericico_login.Entidades;
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
        



        private void btnIniciarSes_Click(object sender, EventArgs e)
        {
            // 1) Validaciones
            Boolean error = true;

            // 1.1) Validaciones de integridad de datos
            if (txtUsua.Text == "")
            {
                error = false;
                MessageBox.Show("El nombre de usuario no puede estar vacio.");
            }

            if (txtContra.Text == "")
            {
                error = false;
                MessageBox.Show("La contraseña no puede estar vacia.");
            }

            // 1.) Validaciones de negocio

            // 1.1) Longitud de usuario (mayor igual a 6)
            if (txtUsua.Text.Length < 6)
            {
                error = false;
                MessageBox.Show("El nombre de usuario debe de tener como mínimo 6 caracteres.");
            }

            // 1.2) Longitud de password (mayor igual a 6)
            if (txtContra.Text.Length < 6)
            {
                error = false;
                MessageBox.Show("La contraseña debe de tener como mínimo 6 caracteres.");
            }

            error = validarCredenciales(txtUsua.Text, txtContra.Text);

            // 1.3) Primero Login? -> Cambio password y 1.4) Expira password?
            if (error)
            {
                validarEstadoClave(txtUsua.Text);
            }

            // 2) Redirigir
            if (error)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }            
        }
        private Boolean validarCredenciales(String usuarioLogin, string passwordLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);
            if (credencialLogin == null)
            {
                return false;
                MessageBox.Show("Usuario no existe");
            }
            else
            {
                if (!credencialLogin.Password.Equals(passwordLogin))
                {
                    return false;
                    MessageBox.Show("Contraseña incorrecta");
                }
            }

            return true;
        }
        private void validarEstadoClave(String usuarioLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);

            if (credencialLogin.FechaUltimoIngreso == null)
            {
                // Redirigir al cambio de contraseña
            }

            if (credencialLogin.FechaUltimoIngreso < DateTime.Today.AddDays(-30))
            {
                // Redirigir al cambio de contraseña
            }

        }

        private Credencial buscarUsuario(String usuarioLogin)
        {
            Credencial credencialLogin = null;

            foreach (Credencial credencial in obtenerCredenciales())
            {
                if (credencial.Usuario.Equals(usuarioLogin))
                {
                    credencialLogin = credencial;
                }
            }

            return credencialLogin;
        }

        private List<Credencial> obtenerCredenciales()
        {
            List<String> listado = persistenciaUtils.LeerRegistro("credenciales.csv");
            List<Credencial> listadoCredenciales = new List<Credencial>();

            foreach (String registro in listado)
            {
                Credencial credencial = new Credencial(registro);
                listadoCredenciales.Add(credencial);
            }

            return listadoCredenciales;
        }

    }
}