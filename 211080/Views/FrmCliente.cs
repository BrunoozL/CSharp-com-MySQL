using _211080.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211080.Views
{
    public partial class FrmCliente : Form
    {
        Cidade ci;
        Cliente cl;
        public FrmCliente()
        {
            InitializeComponent();
        }

        void CarregarGrid(String pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.Consultar();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            LimparControles();
            CarregarGrid("");

            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;
        }
        void LimparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }
    }
}
