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
    public partial class FrmCidades : Form
    {
        Cidade c;
        public FrmCidades()
        {
            InitializeComponent();
        }

        void LimparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtUF.Clear();
            txtNomeParaPesquisa.Clear();
        }

        void CarregarGrid(String pesquisa)
        {
            c = new Cidade();
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            CarregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            c = new Cidade()
            {
                nome = txtNome.Text,
                uf = txtUF.Text
            };

            c.Incluir();

            LimparControles();
            CarregarGird("");
        }


    }
}
