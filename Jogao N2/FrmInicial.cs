using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmNovoJogador novoJogador = new FrmNovoJogador();
            novoJogador.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes configuracoes = new FrmConfiguracoes();
            configuracoes.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FrmRanking ranking = new FrmRanking();
            ranking.Show();
        }
    }
}