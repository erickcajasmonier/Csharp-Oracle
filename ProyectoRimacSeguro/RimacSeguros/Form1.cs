using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;*/


namespace RimacSeguros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string codec;
        private void lblIS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmb1.Visible = true;
           
        }
        public void expandir()
        {
            this.Size = new Size(649, 344);            
            this.BackgroundImage = Properties.Resources.Sin_título;
            btnCerrar1.Visible = false;
            btnMin1.Visible = false;
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb1.SelectedIndex)
            {
                case 0:
                    btnAcceder1.Visible = true;
                    btnAcceder2.Visible = false;
                    btnAcceder3.Visible = false;
                    expandir();
                    break;
                case 1:
                    btnAcceder1.Visible = false;
                    btnAcceder2.Visible = true;
                    btnAcceder3.Visible = false;
                    expandir();
                    break;
                case 2:
                    btnAcceder1.Visible = false;
                    btnAcceder2.Visible = false;
                    btnAcceder3.Visible = true;
                    expandir();
                    break;
            }
            
        }

        private void btnAcceder1_Click(object sender, EventArgs e)
        {
            Cliente fp = new Cliente();
            fp.Show();            
            this.Size = new Size(310, 344);
            this.BackgroundImage = Properties.Resources.Sin_título1;
            btnCerrar1.Visible = true;
            btnMin1.Visible = true;
            cmb1.Visible = false;
            cmb1.Text = "Seleccionar";
            /* oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb); // C#
            conn.Open();
            OracleParameter parm = new OracleParameter();
            OracleParameter parm1 = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtUsuario.Text;
            parm1.OracleDbType = OracleDbType.Decimal;
            parm1.Value = txtContraseña.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "select nombre from asesor where dni = :1 and cargo= 'Empleado'"; //987654321
            cmd.CommandType = CommandType.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm1);
            cmd1.CommandText = "select nombre from asesor where codigoa = :1 and cargo= 'Empleado'"; //123456789
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataReader dr1 = cmd1.ExecuteReader();
            if (dr.Read())
            {
                if (dr1.Read())
                {
                    MessageBox.Show("Bienvenido " + dr.GetString(0));
                    Cliente c = new Cliente();
                    c.Show();
                    codec = txtContraseña.Text;                   
                    this.Size = new Size(310, 344);
                    this.BackgroundImage = Properties.Resources.Sin_título1;
                    btnCerrar1.Visible = true;
                    btnMin1.Visible = true;
                    cmb1.Visible = false;
                    cmb1.Text = "Seleccionar";
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
            conn.Dispose();*/
        }

        private void btnAcceder2_Click(object sender, EventArgs e)
        {
            Asesor fp = new Asesor();
            fp.Show();            
            this.Size = new Size(310, 344);
            this.BackgroundImage = Properties.Resources.Sin_título1;
            btnCerrar1.Visible = true;
            btnMin1.Visible = true;
            cmb1.Visible = false;
            cmb1.Text = "Seleccionar";
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            OracleParameter parm1 = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtUsuario.Text;
            parm1.OracleDbType = OracleDbType.Decimal;
            parm1.Value = txtContraseña.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "select nombre from asesor where dni = :1 and cargo= 'Administrador'"; //14214472
            cmd.CommandType = CommandType.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm1);
            cmd1.CommandText = "select nombre from asesor where codigoa = :1 and cargo= 'Administrador'"; //14214472
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataReader dr1 = cmd1.ExecuteReader();
            if (dr.Read())
            {
                if (dr1.Read())
                {
                    MessageBox.Show("Bienvenido " + dr.GetString(0));
                    Asesor a = new Asesor();
                    a.Show();                    
                    this.Size = new Size(310, 344);
                    this.BackgroundImage = Properties.Resources.Sin_título1;
                    btnCerrar1.Visible = true;
                    btnMin1.Visible = true;
                    cmb1.Visible = false;
                    cmb1.Text = "Seleccionar";
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
            conn.Dispose();*/
        }
        private void btnAcceder3_Click(object sender, EventArgs e)
        {
            Poliza fp = new Poliza();
            fp.Show();
            this.Size = new Size(310, 344);
            this.BackgroundImage = Properties.Resources.Sin_título1;
            btnCerrar1.Visible = true;
            btnMin1.Visible = true;
            cmb1.Visible = false;
            cmb1.Text = "Seleccionar";
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb); // C#
            conn.Open();
            OracleParameter parm = new OracleParameter();
            OracleParameter parm1 = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtUsuario.Text;
            parm1.OracleDbType = OracleDbType.Decimal;
            parm1.Value = txtContraseña.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "select nombre from asesor where dni = :1 and cargo= 'Suscripcion'"; //123456789
            cmd.CommandType = CommandType.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm1);
            cmd1.CommandText = "select nombre from asesor where codigoa = :1 and cargo= 'Suscripcion'"; //987654321
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataReader dr1 = cmd1.ExecuteReader();
            if (dr.Read())
            {
                if (dr1.Read())
                {
                    MessageBox.Show("Bienvenido " + dr.GetString(0));
                    Poliza poli = new Poliza();
                    poli.Show();                    
                    this.Size = new Size(310, 344);
                    this.BackgroundImage = Properties.Resources.Sin_título1;
                    btnCerrar1.Visible = true;
                    btnMin1.Visible = true;
                    cmb1.Visible = false;
                    cmb1.Text = "Seleccionar";
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
            conn.Dispose();*/
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {                   
            btnCerrar.Size = new Size(47, 26);
            btnCerrar.BackgroundImage = Properties.Resources.i1;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {          
            btnCerrar.Size = new Size(42, 21);
            btnCerrar.BackgroundImage = Properties.Resources.imagen6;
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            btnMin.Size = new Size(26, 26);
            btnMin.BackgroundImage = Properties.Resources.min;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.Size = new Size(21, 21);
            btnMin.BackgroundImage = Properties.Resources.min1;
        }

        private void btnCerrar1_MouseHover(object sender, EventArgs e)
        {
            btnCerrar1.Size = new Size(47, 26);
            btnCerrar1.BackgroundImage = Properties.Resources.i1;
        }

        private void btnCerrar1_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar1.Size = new Size(42, 21);
            btnCerrar1.BackgroundImage = Properties.Resources.imagen6;
        }

        private void btnMin1_MouseHover(object sender, EventArgs e)
        {
            btnMin1.Size = new Size(26, 26);
            btnMin1.BackgroundImage = Properties.Resources.min;
        }

        private void btnMin1_MouseLeave(object sender, EventArgs e)
        {
            btnMin1.Size = new Size(21, 21);
            btnMin1.BackgroundImage = Properties.Resources.min1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | HellPass ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Size = new Size(310, 344);
            this.BackgroundImage = Properties.Resources.Sin_título1;
            btnCerrar1.Visible = true;
            btnMin1.Visible = true;
            cmb1.Visible = false;
            cmb1.Text = "Seleccionar";
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Rimac Seguros ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreem f1 = new SplashScreem();
            f1.ShowDialog(this);
            f1.Dispose();
        }

        private void btnAcceder1_MouseHover(object sender, EventArgs e)
        {
            btnAcceder1.Size = new Size(38, 30);
            btnAcceder1.BackgroundImage = Properties.Resources.next2;
        }

        private void btnAcceder1_MouseLeave(object sender, EventArgs e)
        {
            btnAcceder1.Size = new Size(33, 25);
            btnAcceder1.BackgroundImage = Properties.Resources.next1;            
        }

        private void btnAcceder3_MouseHover(object sender, EventArgs e)
        {
            btnAcceder3.Size = new Size(38, 30);
            btnAcceder3.BackgroundImage = Properties.Resources.next2;
        }

        private void btnAcceder3_MouseLeave(object sender, EventArgs e)
        {
            btnAcceder3.Size = new Size(33, 25);
            btnAcceder3.BackgroundImage = Properties.Resources.next1;
        }

        private void btnAcceder2_MouseHover(object sender, EventArgs e)
        {
            btnAcceder2.Size = new Size(38, 30);
            btnAcceder2.BackgroundImage = Properties.Resources.next2;
        }

        private void btnAcceder2_MouseLeave(object sender, EventArgs e)
        {
            btnAcceder2.Size = new Size(33, 25);
            btnAcceder2.BackgroundImage = Properties.Resources.next1;
        }        
    }
}
