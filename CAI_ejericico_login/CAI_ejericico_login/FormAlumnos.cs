﻿using CAI_ejericico_login.Entidades;
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
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }
               
        private void btnListar_Click(object sender, EventArgs e)
        {
            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
            List<String> listado = persistenciaUtils.LeerRegistro("alumnos.csv");

            foreach (String registro in listado)
            {
                Alumno alumno = new Alumno(registro);
                lstAlumnos.Items.Add(alumno);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAlumnos.SelectedItems;
            Alumno alumno = (Alumno)itemSeleccionado[0];

            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            dtpFechaNacimiento.Value = alumno.FechaNac;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes formReportes = new FormReportes();
            formReportes.ShowDialog();
        }
    }
}
