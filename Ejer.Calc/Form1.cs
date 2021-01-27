using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejer.Calc
{
    public partial class Form1 : Form
    {
        static Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {
            if (cbxOperaciones.Text == "Suma")
            {
                lblRes.Text = (op.Suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
            else if (cbxOperaciones.Text == "Resta")
            {
                lblRes.Text = (op.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
            else if (cbxOperaciones.Text == "Multiplicación")
            {
                lblRes.Text = (op.Mul(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
            else if (cbxOperaciones.Text == "División")
            {
                lblRes.Text = (op.Div(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString());
            }
        }

        private void lblv1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese el primer valor en el espacio dado");
        }

        private void cbxOperaciones_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Elija la operación que desea aquí");
        }

        private void txtv2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lblOperaciones_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
