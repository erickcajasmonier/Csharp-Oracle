using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimacSeguros
{
    public partial class Poliza : Form
    {
        public Poliza()
        {
            InitializeComponent();
            lblCodCli.Text = Cliente.codecli;
            cbCodArea.Items.Add(1);
            cbCodArea.Items.Add(2);
            cbCodArea.Items.Add(3);
            SacarApellidoMaterno();
            SacarApellidoPat();
            SacarNombre();
            lblFechaEmi.Text = DateTime.Today.ToString();
            Random r = new Random();
            int num = r.Next(0, 99999999);
            lblCodPoliza.Text = num.ToString();
            lblMontoSeguro.Text = Cliente.montototal;
            lblCicloPago.Text = Cliente.cuotas;
        }       
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into poliza values (:1,:2,:3,:4,:5,:6,:7)";
            cmd.Parameters.Add(new OracleParameter("1",
            OracleDbType.Int32,
            int.Parse(lblCodPoliza.Text),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("2",
            OracleDbType.Int32,
            int.Parse(lblCodCli.Text),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("3",
            OracleDbType.Date,
            txtFechaCadu.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
            OracleDbType.Char,
            lblCicloPago.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
            OracleDbType.Double,
            double.Parse(lblMontoSeguro.Text),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("6",
            OracleDbType.Date,
            Convert.ToDateTime(lblFechaEmi.Text),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("7",
            OracleDbType.Int32,
            cbCodArea.Text,
            ParameterDirection.Input));
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Faltan insertar datos");
            else
                MessageBox.Show("Guardado");
            conn.Dispose();   */
        }
        public void SacarNombre()
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = lblCodCli.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm);
            cmd1.CommandText = "select nombre from cliente where codigoc = :1";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                lblNomCliente.Text = dr.GetString(0);
            }
            conn.Dispose();*/

        }
        public void SacarApellidoPat()
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = lblCodCli.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm);
            cmd1.CommandText = "select apellidopat from cliente where codigoc = :1";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                lblApePat.Text = dr.GetString(0);
            }
            conn.Dispose();*/
        }

        public void SacarApellidoMaterno()
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = lblCodCli.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm);
            cmd1.CommandText = "select apellidomat from cliente where codigoc = :1";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                lblApeMat.Text = dr.GetString(0);
            }
            conn.Dispose();*/
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
        private void btnGenerar_MouseHover(object sender, EventArgs e)
        {

            btnGenerar.Size = new Size(90,90);
            btnGenerar.BackgroundImage = Properties.Resources.BLOG2;
        }

        private void btnGenerar_MouseLeave(object sender, EventArgs e)
        {
             btnGenerar.Size = new Size(85, 85);
            btnGenerar.BackgroundImage = Properties.Resources.BLOG;
        }

        private void btnMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Rimac Seguros ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }        
    }
}
