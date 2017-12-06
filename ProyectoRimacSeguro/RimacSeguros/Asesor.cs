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
    public partial class Asesor : Form
    {
        public Asesor()
        {
            InitializeComponent();
            cbCargo.Items.Add("Empleado");
            cbCargo.Items.Add("Administrador");
            cbCargo.Items.Add("Suscripcion");
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
        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Rimac Seguros ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }            
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

        private void btnMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;        
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*Random r = new Random();
            int num;
            string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into asesor values (:1,:2,:3,:4,:5,:6,:7)";
            cmd.Parameters.Add(new OracleParameter("1",
            OracleDbType.Int32,
            num = r.Next(0, 99999999),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("2",
            OracleDbType.Varchar2,
            txtApePat.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("3",
            OracleDbType.Varchar2,
            txtApeMat.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
            OracleDbType.Varchar2,
            txtNombre.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
            OracleDbType.Int32,
            txtDni.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("6",
            OracleDbType.Date,
            txtFecIngreso.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("7",
            OracleDbType.Varchar2,
            cbCargo.Text,
            ParameterDirection.Input));

            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Faltan insertar datos");
            else
                MessageBox.Show("Guardado");
            conn.Dispose();

            dgvListado.Rows.Add(num, txtApePat.Text, txtApeMat.Text, txtNombre.Text, txtDni.Text, cbCargo.Text, txtFecIngreso.Text);
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
            txtDni.Text = "";
            cbCargo.Text = "";
            txtFecIngreso.Text = "";
            txtNombre.Focus();*/
        }

        private void btnRegistrar_MouseHover(object sender, EventArgs e)
        {
            btnRegistrar.Size = new Size(90, 90);
            btnRegistrar.BackgroundImage = Properties.Resources.Registrar2;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.Size = new Size(85, 85);
            btnRegistrar.BackgroundImage = Properties.Resources.Registrar;
        }
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.Size = new Size(90, 90);
            btnBuscar.BackgroundImage = Properties.Resources.Buscar2;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.Size = new Size(85, 85);
            btnBuscar.BackgroundImage = Properties.Resources.Buscar;
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            btnActualizar.Size = new Size(90, 90);
            btnActualizar.BackgroundImage = Properties.Resources.Mostrar2;
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            btnActualizar.Size = new Size(85, 85);
            btnActualizar.BackgroundImage = Properties.Resources.Mostrar;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.Size = new Size(90, 90);
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar2;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Size = new Size(85, 85);
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnModificar.Size = new Size(90, 90);
            btnModificar.BackgroundImage = Properties.Resources.Modificar2;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.Size = new Size(85, 85);
            btnModificar.BackgroundImage = Properties.Resources.Modificar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtCodigo.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "select apepat,apemat,nombre,dni,fecingreso,cargo from asesor where codigoa=:1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Apellido Paterno: " + dr.GetString(0) + "\n" + "Apellido Materno: " + dr.GetString(1) + "\n" + "Nombre: " + dr.GetString(2) + "\n" + "DNI: " + dr.GetInt32(3) + "\n" + "Fecha de ingreso: " + dr.GetDateTime(4) + "\n" + "Cargo: " + dr.GetString(5));
            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
            conn.Dispose();
            txtCodigo.Text = "";
            txtCodigo.Focus();*/
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtCodigo.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "select apepat,apemat,nombre,dni,fecingreso,cargo from asesor where codigoa=:1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtApePat.Text = dr.GetString(0);
                txtApeMat.Text = dr.GetString(1);
                txtNombre.Text = dr.GetString(2);
                txtDni.Text = dr.GetInt32(3).ToString();
                txtFecIngreso.Text = dr.GetDateTime(4).ToString();
                cbCargo.Text = dr.GetString(5);
            }
            else
            {
                MessageBox.Show("No existe cliente");
            }
            conn.Dispose();*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtCodigo.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "delete from asesor where codigoa=:1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("No existe el cliente");
            }
            else
            {
                MessageBox.Show("Cliente eliminado");
            }
            conn.Dispose();
            txtCodigo.Text = "";
            txtCodigo.Focus();*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update asesor set apepat=:1,apemat=:2,nombre=:3,dni=:4,fecingreso=:5,cargo=:6 where codigoa=:7";
            cmd.Parameters.Add(new OracleParameter("1",
            OracleDbType.Varchar2,
            txtApePat.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("2",
            OracleDbType.Varchar2,
            txtApeMat.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("3",
            OracleDbType.Varchar2,
            txtNombre.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
            OracleDbType.Int32,
            txtDni.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
            OracleDbType.Date,
            txtFecIngreso.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("6",
            OracleDbType.Varchar2,
            cbCargo.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("7",
            OracleDbType.Int32,
            txtCodigo.Text,
            ParameterDirection.Input));
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Faltan insertar datos");
            else
                MessageBox.Show("Actualizado");
            conn.Dispose();*/
        }
    }
}
