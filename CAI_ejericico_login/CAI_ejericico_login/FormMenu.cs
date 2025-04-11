﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.ShowDialog();
        }


    }
}