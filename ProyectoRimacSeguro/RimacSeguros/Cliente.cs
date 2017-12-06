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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();            
            agregarComboAsesor();
            agregarComboCliente();
            agregarComboSuscripcion();
            agregarComboTipo();
            agregarComboCro();
            agregarComboHere();
            agregarComboOperacion();
            agregarComboTratado();
            cbEstado.Items.Add("Solter@");
            cbEstado.Items.Add("Casad@");
            cbEstado.Items.Add("Divorciad@");
            cbEstado.Items.Add("Viud@");
            lblFechaVenta.Text = DateTime.Today.ToString();
            lblCodigoAsesor.Text = Form1.codec;
            lblCodigoCliente.Text = Cliente.codecli;
            cbIGV.Items.Add("18%");
            cbIGV.Items.Add("19%");
            SacarApellidoMaterno();
            SacarApellidoPat();
            SacarNombre();
            Random r = new Random();
            int num = r.Next(0, 99999999);
            lblNumeroRuc.Text = num.ToString();
        }
        public static string montototal;
        public static string codecli;        
        public void agregarComboTratado()
        {
            cbTrat.Items.Add(0);
            cbTrat.Items.Add(1);
            cbTrat.Items.Add(2);
            cbTrat.Items.Add(3);
            cbTrat.Items.Add(4);
            cbTrat.Items.Add(5);
            cbTrat.Items.Add(6);
            cbTrat.Items.Add(7);
            cbTrat.Items.Add(8);
            cbTrat.Items.Add(9);
            cbTrat.Items.Add(10);
            cbTrat.Items.Add(11);
            cbTrat.Items.Add(12);
            cbTrat.Items.Add(13);
            cbTrat.Items.Add(14);
            cbTrat.Items.Add(15);
        }
        public void agregarComboOperacion()
        {
            cbOpe.Items.Add(0);
            cbOpe.Items.Add(1);
            cbOpe.Items.Add(2);
            cbOpe.Items.Add(3);
            cbOpe.Items.Add(4);
            cbOpe.Items.Add(5);
            cbOpe.Items.Add(6);
            cbOpe.Items.Add(7);
            cbOpe.Items.Add(8);
            cbOpe.Items.Add(9);
            cbOpe.Items.Add(10);
            cbOpe.Items.Add(11);
            cbOpe.Items.Add(12);
            cbOpe.Items.Add(13);
            cbOpe.Items.Add(14);
            cbOpe.Items.Add(15);
        }
        public void agregarComboHere()
        {
            cbHere.Items.Add(0);
            cbHere.Items.Add(1);
            cbHere.Items.Add(2);
            cbHere.Items.Add(3);
            cbHere.Items.Add(4);
            cbHere.Items.Add(5);
            cbHere.Items.Add(6);
            cbHere.Items.Add(7);
            cbHere.Items.Add(8);
            cbHere.Items.Add(9);
            cbHere.Items.Add(10);
            cbHere.Items.Add(11);
            cbHere.Items.Add(12);
            cbHere.Items.Add(13);
            cbHere.Items.Add(14);
            cbHere.Items.Add(15);
        }
        public void agregarComboCro()
        {
            cbCro.Items.Add(0);
            cbCro.Items.Add(1);
            cbCro.Items.Add(2);
            cbCro.Items.Add(3);
            cbCro.Items.Add(4);
            cbCro.Items.Add(5);
            cbCro.Items.Add(6);
            cbCro.Items.Add(7);
            cbCro.Items.Add(8);
            cbCro.Items.Add(9);
            cbCro.Items.Add(10);
            cbCro.Items.Add(11);
            cbCro.Items.Add(12);
            cbCro.Items.Add(13);
            cbCro.Items.Add(14);
            cbCro.Items.Add(15);
        }      
        public void SacarNombre()
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb); // C#
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = lblCodigoCliente.Text;
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.Parameters.Add(parm);
            cmd1.CommandText = "select nombre from cliente where codigoc = :1";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                lblNombreCliente.Text = dr.GetString(0);
            }
            conn.Dispose();*/

        }
        public void SacarApellidoPat()
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb); // C#
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = lblCodigoCliente.Text;
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
            OracleConnection conn = new OracleConnection(oradb); // C#
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = lblCodigoCliente.Text;
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
        public void agregarComboAsesor()
        {
            //cbCodAsesor.Items.Add(Form1.codec);
        }
        public void agregarComboCliente()
        {
           //cbCodCliente.Items.Add(Cliente.codecli);
        }
        public void agregarComboSuscripcion()
        {
            cbCodArea.Items.Add("1");
            cbCodArea.Items.Add("2");
            cbCodArea.Items.Add("3");
        }
        public void agregarComboTipo()
        {
            cbTipoSeguro.Items.Add("Seguro de vida");
            cbTipoSeguro.Items.Add("Seguro de salud");
        }
        public static string area;
        public static string fecemi;
        public static string cuotas;
        public void ForViBol()
        {
            btnBuscar3.Visible = true;
            btnRegistrar2.Visible = true;            
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl8.Visible = true;
            lbl9.Visible = true;
            lbl10.Visible = true;
            lbl11.Visible = true;
            lblCodigoCliente.Visible = true;
            lblNombreCliente.Visible = true;
            lblApePat.Visible = true;
            lblApeMat.Visible = true;
            lblCodigoAsesor.Visible = true;
            lblFechaVenta.Visible = true;
            lblNumeroRuc.Visible = true;
            lblMontoTotal.Visible = true;
            txtMontoBruto.Visible = true;
            cbIGV.Visible = true;
            txtCodigo.Visible = true;
            btnSoli.Visible = false;
            btnJura.Visible = false;
            btnBole.Visible = false;

               
        }
        public void ForViDeJu()
        {
            btnGuardar2.Visible = true;
            btnMostrar2.Visible = true;
            btnEliminar3.Visible = true;
            lblH.Visible = true;
            txtCodigo.Visible =true;
            lblI.Visible = true;           
            cbOpe.Visible = true;
            lblJ.Visible = true;
            cbTrat.Visible = true;
            lblK.Visible = true;
            cbHere.Visible = true;
            lblL.Visible = true;
            cbCro.Visible = true;
            dgvListado3.Visible = true;
            btnSoli.Visible = false;
            btnJura.Visible = false;
            btnBole.Visible = false;

        }
        public void ForViDocu()
        {
            btnSoli.Visible = true;
            btnJura.Visible = true;
            btnBole.Visible = true;
            btnRegresar.Visible = true;            
        }
        public void ForViRe()
        {
            txtCodigo.Visible = true;
            btnRegistrar.Visible = true;
            btnActualizar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnBuscar.Visible = true;
            btnDocumentos.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblApellidoPat.Visible = true;
            txtApePat.Visible = true;
            lblApellidoMat.Visible = true;
            txtApeMat.Visible = true;
            lblEdad.Visible = true;
            txtEdad.Visible = true;
            lblDireccion.Visible = true;
            txtDireccion.Visible = true;
            lblTelefono.Visible = true;
            txtTelefono.Visible = true;
            lblCorreo.Visible = true;
            txtCorreo.Visible = true;
            lblEstadoCivil.Visible = true;
            cbEstado.Visible = true;
            lblEstatura.Visible = true;
            txtEstatura.Visible = true;
            lblPeso.Visible = true;
            txtPeso.Visible = true;
            lblCod.Visible = true;
            txtCodigo.Visible = true;
            dgvListado.Visible = true;
            btnRegresar.Visible = false;
            btnSoli.Visible = false;
            btnJura.Visible = false;
            btnBole.Visible = false;
            lblA.Visible = false;
            cbCodAsesor.Visible = false;
            lblB.Visible = false;
            cbCodCliente.Visible = false;
            lblC.Visible = false;
            txtFecha.Visible = false;
            lblD.Visible = false;
            cbCodArea.Visible = false;
            lblE.Visible = false;
            cbTipoSeguro.Visible = false;
            lblF.Visible = false;
            txtCuotas.Visible = false;
            lblG.Visible = false;
            txtTipoOperacion.Visible = false;
            lblH.Visible = false;
            txtCodSolicitud.Visible = true;
            dgvListado2.Visible = false;
            btnGuardar.Visible = false;
            btnBuscar2.Visible = false;
            btnEliminar2.Visible = false;
            txtCodSolicitud.Visible = false;
            btnSoli.Visible = false;
            btnJura.Visible = false;
            btnBole.Visible = false;
            btnRegresar.Visible = false;
            btnGuardar2.Visible = false;
            btnMostrar2.Visible = false;
            btnEliminar3.Visible = false;
            txtCodigo.Text = "";
            lblI.Visible = false;
            cbOpe.Visible = false;
            lblJ.Visible = false;
            cbTrat.Visible = false;
            lblK.Visible = false;
            cbHere.Visible = false;
            lblL.Visible = false;
            cbCro.Visible = false;
            dgvListado3.Visible = false;
            btnBuscar3.Visible = false;
            btnRegistrar2.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
            lbl11.Visible = false;
            lblCodigoCliente.Visible = false;
            lblNombreCliente.Visible = false;
            lblApePat.Visible = false;
            lblApeMat.Visible = false;
            lblCodigoAsesor.Visible = false;
            lblFechaVenta.Visible = false;
            lblNumeroRuc.Visible = false;
            lblMontoTotal.Visible = false;
            txtMontoBruto.Visible = false;
            cbIGV.Visible = false;

        }
        public void ForViSoi()
        {
            lblA.Visible = true;
            cbCodAsesor.Visible = true;
            lblB.Visible = true;
            cbCodCliente.Visible = true;
            lblC.Visible = true;
            txtFecha.Visible = true;
            lblD.Visible = true;
            cbCodArea.Visible = true;
            lblE.Visible = true;
            cbTipoSeguro.Visible = true;
            lblF.Visible = true;
            txtCuotas.Visible = true;
            lblG.Visible = true;
            txtTipoOperacion.Visible = true;
            lblH.Visible = true;
            txtCodSolicitud.Visible = true;
            dgvListado2.Visible = true;
            btnGuardar.Visible = true;
            btnBuscar2.Visible = true;
            btnEliminar2.Visible = true;
            btnSoli.Visible = false;           
            btnJura.Visible = false;
            btnBole.Visible = false;
        }
        public void ForVisible()
        {
            btnRegistrar.Visible = false;
            btnActualizar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnDocumentos.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblApellidoPat.Visible = false;
            txtApePat.Visible = false;
            lblApellidoMat.Visible = false;
            txtApeMat.Visible = false;
            lblEdad.Visible = false;
            txtEdad.Visible = false;
            lblDireccion.Visible = false;
            txtDireccion.Visible = false;
            lblTelefono.Visible = false;
            txtTelefono.Visible = false;
            lblCorreo.Visible = false;
            txtCorreo.Visible = false;
            lblEstadoCivil.Visible = false;
            cbEstado.Visible = false;
            lblEstatura.Visible = false;
            txtEstatura.Visible = false;
            lblPeso.Visible = false;
            txtPeso.Visible = false;
            lblCod.Visible = false;
            txtCodigo.Visible = false;
            dgvListado.Visible = false;
            txtCodigo.Visible = false;
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
            cmd.CommandText = "Insert into cliente VALUES (:1, :2, :3, :4, :5, :6, :7, :8, :9, :10, :11)";
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
            txtEdad.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("6",
            OracleDbType.Char,
            txtDireccion.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("7",
            OracleDbType.Char,
            txtTelefono.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("8",
            OracleDbType.Char,
            txtCorreo.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("9",
            OracleDbType.Varchar2,
            cbEstado.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("10",
            OracleDbType.Char,
            txtEstatura.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("11",
            OracleDbType.Char,
            txtPeso.Text,
            ParameterDirection.Input));

            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Faltan insertar datos");
            }
            else
            {
                MessageBox.Show("Guardado");
                codecli = txtCodigo.Text;
            }
            conn.Dispose();
            dgvListado.Rows.Add(num, txtApePat.Text, txtApeMat.Text, txtNombre.Text, txtEdad.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, cbEstado.Text, txtEstatura.Text + " cm", txtPeso.Text + " kg");
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbEstado.Text = "";
            txtEstatura.Text = "";
            txtPeso.Text = "";
            txtNombre.Focus();*/
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
            cmd.CommandText = "select apellidopat,apellidomat,nombre,edad,direccion,tlf,correo,estadocivil,estatura,peso from cliente where codigoc = :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtApePat.Text = dr.GetString(0);
                txtApeMat.Text = dr.GetString(1);
                txtNombre.Text = dr.GetString(2);
                txtEdad.Text = dr.GetInt32(3).ToString();
                txtDireccion.Text = dr.GetString(4);
                txtTelefono.Text = dr.GetString(5);
                txtCorreo.Text = dr.GetString(6);
                cbEstado.Text = dr.GetString(7);
                txtEstatura.Text = dr.GetString(8);
                txtPeso.Text = dr.GetString(9);
            }
            else
            {
                MessageBox.Show("No existe cliente");
            }
            conn.Dispose();*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update cliente set apellidopat=:1,apellidomat=:2,nombre=:3,edad=:4,direccion=:5,tlf=:6,correo=:7,estadocivil=:8,estatura=:9,peso=:10 where codigoc=:11";
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
            txtEdad.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
            OracleDbType.Char,
            txtDireccion.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("6",
            OracleDbType.Char,
            txtTelefono.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("7",
            OracleDbType.Char,
            txtCorreo.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("8",
            OracleDbType.Varchar2,
            cbEstado.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("9",
            OracleDbType.Char,
            txtEstatura.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("10",
            OracleDbType.Char,
            txtPeso.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("11",
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
            cmd.CommandText = "delete from cliente where codigoc= :1";
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
            cmd.CommandText = "select apellidopat,apellidomat,nombre,edad,direccion,tlf,correo,estadocivil,estatura,peso from cliente where codigoc = :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Apellido Paterno: " + dr.GetString(0) + "\n" + "Apellido Materno: " + dr.GetString(1) + "\n" + "Nombre: " + dr.GetString(2) + "\n" + "Edad: " + dr.GetInt32(3) + "\n" + "Direccion: " + dr.GetString(4) + "\n" + "Telefono: " + dr.GetString(5) + "\n" + "Correo: " + dr.GetString(6) + "\n" + "Estado Civil: " + dr.GetString(7) + "\n" + "Estatura: " + dr.GetString(8) + " cm" + "\n" + "Peso: " + dr.GetString(9) + " Kg");
                codecli = txtCodigo.Text;
            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
            conn.Dispose();
            txtCodigo.Text = "";
            txtCodigo.Focus();*/
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            ForVisible();
            ForViDocu();
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

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Rimac Seguros ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();                
            }
        }
        private void btnMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;            
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

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.Size = new Size(90, 90);
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar2;
        
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Size = new Size(85,85);
            btnEliminar.BackgroundImage = Properties.Resources.Eliminar;
        }

        private void btnDocumentos_MouseHover(object sender, EventArgs e)
        {
            btnDocumentos.Size = new Size(90, 90);
            btnDocumentos.BackgroundImage = Properties.Resources.Documentos2;
        }

        private void btnDocumentos_MouseLeave(object sender, EventArgs e)
        {
            btnDocumentos.Size = new Size(85,85);
            btnDocumentos.BackgroundImage = Properties.Resources.Documentos;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ForViRe();
        }

        private void btnSoli_MouseHover(object sender, EventArgs e)
        {
            btnSoli.Size = new Size(90, 90);
            btnSoli.BackgroundImage = Properties.Resources.soli2;
        }

        private void btnSoli_MouseLeave(object sender, EventArgs e)
        {
            btnSoli.Size = new Size(85,85);
            btnSoli.BackgroundImage = Properties.Resources.soli;
        }

        private void btnJura_MouseHover(object sender, EventArgs e)
        {
            btnJura.Size = new Size(90, 90);
            btnJura.BackgroundImage = Properties.Resources.declaracion2;        
        }
        private void btnJura_MouseLeave(object sender, EventArgs e)
        {
            btnJura.Size = new Size(85, 85);
            btnJura.BackgroundImage = Properties.Resources.declaracion; 
        }
        private void btnBole_MouseHover(object sender, EventArgs e)
        {
            btnBole.Size = new Size(90, 90);
            btnBole.BackgroundImage = Properties.Resources.boletas2; 
        }

        private void btnBole_MouseLeave(object sender, EventArgs e)
        {
            btnBole.Size = new Size(85, 85);
            btnBole.BackgroundImage = Properties.Resources.boletas; 
        }
        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.Size = new Size(55, 55);
            btnRegresar.BackgroundImage = Properties.Resources.magen7; 
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.Size = new Size(46, 46);
            btnRegresar.BackgroundImage = Properties.Resources.magen6; 
        }

        private void btnSoli_Click(object sender, EventArgs e)
        {
            ForViSoi();
        }

        private void btnJura_Click(object sender, EventArgs e)
        {
            ForViDeJu();
        }

        private void btnBole_Click(object sender, EventArgs e)
        {
            ForViBol();
        }
        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.Size = new Size(90, 90);
            btnGuardar.BackgroundImage = Properties.Resources.guardar2; 
        }
        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.Size = new Size(85, 85);
            btnGuardar.BackgroundImage = Properties.Resources.guardar; 
        }
        private void btnBuscar2_MouseHover(object sender, EventArgs e)
        {
            btnBuscar2.Size = new Size(90, 90);
            btnBuscar2.BackgroundImage = Properties.Resources.pasiente2; 
        }
        private void btnBuscar2_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar2.Size = new Size(85, 85);
            btnBuscar2.BackgroundImage = Properties.Resources.pasiente; 
        }
        private void btnEliminar2_MouseHover(object sender, EventArgs e)
        {
            btnEliminar2.Size = new Size(90, 90);
            btnEliminar2.BackgroundImage = Properties.Resources.Eliminar2;
        }
        private void btnEliminar2_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar2.Size = new Size(85, 85);
            btnEliminar2.BackgroundImage = Properties.Resources.Eliminar;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*Random r = new Random();
            int num;
            string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into solicitud_de_seguro values (:1,:2,:3,:4)";
            cmd.Parameters.Add(new OracleParameter("1",
            OracleDbType.Int32,
            num = r.Next(0, 99999999),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("2",
            OracleDbType.Varchar2,
            cbTipoSeguro.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("3",
            OracleDbType.Int32,
            txtCuotas.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
            OracleDbType.Varchar2,
            txtTipoOperacion.Text,
            ParameterDirection.Input));
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Faltan insertar datos");
            }
            else
            {
                MessageBox.Show("Guardado");
                area = cbCodArea.Text;
                fecemi = txtFecha.Text;
                cuotas = txtCuotas.Text;
            }
            conn.Dispose();
            dgvListado2.Rows.Add(num, cbCodAsesor.Text, cbCodCliente.Text, cbCodArea.Text, cbTipoSeguro.Text, txtCuotas.Text, txtTipoOperacion.Text, txtFecha.Text);
            cbCodAsesor.Text = "";
            cbCodCliente.Text = "";
            cbCodArea.Text = "";
            cbTipoSeguro.Text = "";
            txtCuotas.Text = "";
            txtTipoOperacion.Text = "";
            txtFecha.Text = "";
            cbCodAsesor.Focus();*/
        }
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtCodSolicitud.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "select tiposeguro,numerocuotas,tipooperacion from solicitud_de_seguro where codsolicitud= :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Codigo del Asesor: " + LogIn.codec + "\n" + "Codigo del Cliente: " + Cliente.codecli + "\n" + "Codigo de Area: " + area + "\n" + "Tipo de Seguro: " + dr.GetString(0) + "\n" + "Numero de Cuotas: " + dr.GetInt32(1) + "\n" + "Tipo de Operacion: " + dr.GetString(2) + "\n" + "Fecha de Emision: " + fecemi);
            }
            else
            {
                MessageBox.Show("No existe el documento");
            }
            conn.Dispose();
            txtCodSolicitud.Text = "";
            txtCodSolicitud.Focus();*/
        }
        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            /*string oradb = "Data Source=ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleParameter parm = new OracleParameter();
            parm.OracleDbType = OracleDbType.Decimal;
            parm.Value = txtCodSolicitud.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.Parameters.Add(parm);
            cmd.CommandText = "delete from solicitud_de_seguro where codsolicitud= :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("No existe el documento");
            }
            else
            {
                MessageBox.Show("Documento eliminado");
            }
            conn.Dispose();
            txtCodSolicitud.Text = "";
            txtCodSolicitud.Focus();*/
        }
        private void btnGuardar2_MouseHover(object sender, EventArgs e)
        {
            btnGuardar2.Size = new Size(90, 90);
            btnGuardar2.BackgroundImage = Properties.Resources.guardar2; 
        }

        private void btnGuardar2_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar2.Size = new Size(85, 85);
            btnGuardar2.BackgroundImage = Properties.Resources.guardar; 
        }

        private void btnMostrar2_MouseHover(object sender, EventArgs e)
        {
            btnMostrar2.Size = new Size(90, 90);
            btnMostrar2.BackgroundImage = Properties.Resources.Mostrar2; 
        }
        private void btnMostrar2_MouseLeave(object sender, EventArgs e)
        {
            btnMostrar2.Size = new Size(85, 85);
            btnMostrar2.BackgroundImage = Properties.Resources.Mostrar; 
        }
        private void btnEliminar3_MouseHover(object sender, EventArgs e)
        {
            btnEliminar3.Size = new Size(90, 90);
            btnEliminar3.BackgroundImage = Properties.Resources.Eliminar2;
        }
        private void btnEliminar3_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar3.Size = new Size(85, 85);
            btnEliminar3.BackgroundImage = Properties.Resources.Eliminar;
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select numoper,numtratact,numenfhere,numenfcronic from declaracion_jurada_salud where coddecla= :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Codigo del Asesor: " + Form1.codec + "\n" + "Codigo del Cliente: " + Cliente.codecli + "\n" + "Codigo de Area: " + SolicitudDeSeguro.area + "\n" + "Numero de operaciones: " + dr.GetInt32(0) + "\n" + "Numero de Tratamientos Actuales: " + dr.GetInt32(1) + "\n" + "Numero de Enfermedades Hereditarias: " + dr.GetInt32(2) + "\n" + "Numero de Enfermedades Cronicas: " + dr.GetInt32(3) + "\n" + "Fecha de Emision: " + SolicitudDeSeguro.fecemi);
            }
            else
            {
                MessageBox.Show("No existe el documento");
            }
            conn.Dispose();
            txtCodigo.Text = "";
            txtCodigo.Focus();*/
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
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
            cmd.CommandText = "delete from declaracion_jurada_salud where coddecla= :1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("No existe el documento");
            }
            else
            {
                MessageBox.Show("Documento eliminado");
            }
            conn.Dispose();
            txtCodigo.Text = "";
            txtCodigo.Focus();*/
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
           /* Random r = new Random();
            int num;
            string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into declaracion_jurada_salud values (:1,:2,:3,:4,:5)";
            cmd.Parameters.Add(new OracleParameter("1",
            OracleDbType.Int32,
            num = r.Next(0, 99999999),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("2",
            OracleDbType.Int32,
            cbOpe.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("3",
            OracleDbType.Int32,
            cbTrat.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
            OracleDbType.Int32,
            cbHere.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
            OracleDbType.Int32,
            cbCro.Text,
            ParameterDirection.Input));
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
                MessageBox.Show("Faltan insertar datos");
            else
                MessageBox.Show("Guardado");
            conn.Dispose();
            dgvListado3.Rows.Add(num, Form1.codec, Cliente.codecli, SolicitudDeSeguro.area, cbOpe.Text, cbTrat.Text, cbCro.Text, cbHere.Text, SolicitudDeSeguro.fecemi);
            cbTrat.Text = "";
            cbOpe.Text = "";
            cbHere.Text = "";
            cbCro.Text = "";
            cbOpe.Focus();*/
        }

        private void btnBuscar3_MouseHover(object sender, EventArgs e)
        {
            btnBuscar3.Size = new Size(90, 90);
            btnBuscar3.BackgroundImage = Properties.Resources.Buscar2;
        }

        private void btnBuscar3_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar3.Size = new Size(85, 85);
            btnBuscar3.BackgroundImage = Properties.Resources.Buscar;
        }

        private void btnRegistrar2_MouseHover(object sender, EventArgs e)
        {
            btnRegistrar2.Size = new Size(90, 90);
            btnMostrar2.BackgroundImage = Properties.Resources.Mostrar2; 
        }

        private void btnRegistrar2_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar2.Size = new Size(85, 85);
            btnRegistrar2.BackgroundImage = Properties.Resources.Mostrar; 
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            /*double a;
            double b = double.Parse(txtMontoBruto.Text);
            if (cbIGV.Text == "18")
            {
                a = 1.18;
            }
            else
            {
                a = 1.19;
            }
            lblMontoTotal.Text = (b * a).ToString();
            string oradb = "Data Source= ProyBD;User Id=rimac;Password=a14222405;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into boleta_de_pago values (:1,:2,:3,:4,:5)";
            cmd.Parameters.Add(new OracleParameter("1",
            OracleDbType.Int32,
            int.Parse(lblNumeroRuc.Text),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("2",
            OracleDbType.Double,
            b,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("3",
            OracleDbType.Char,
            cbIGV.Text,
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("4",
            OracleDbType.Date,
            Convert.ToDateTime(lblFechaVenta.Text),
            ParameterDirection.Input));
            cmd.Parameters.Add(new OracleParameter("5",
            OracleDbType.Double,
            double.Parse(lblMontoTotal.Text),
            ParameterDirection.Input));
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Faltan insertar datos");
            }
            else
            {
                MessageBox.Show("Guardado");
                montototal = lblMontoTotal.Text;
            }
            conn.Dispose();*/
        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select montobruto,igv,montototal from boleta_de_pago where codbole=:1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Codigo del Asesor: " + Form1.codec + "\n" + "Codigo del Cliente: " + Cliente.codecli + "\n" + "Codigo de Area: " + SolicitudDeSeguro.area + "\n" + "Monto Bruto: " + dr.GetDouble(0) + "\n" + "IGV: " + dr.GetString(1) + "\n" + "Fecha de Caducidad: " + SolicitudDeSeguro.fecemi + "\n" + "Monto Total: " + dr.GetDouble(2));
            }
            else
            {
                MessageBox.Show("No existe el documento");
            }
            conn.Dispose();*/
        }                
    }
}
