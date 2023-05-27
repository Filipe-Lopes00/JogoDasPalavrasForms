using JogoDasPalavrasForms.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDasPalavrasForms.controles
{
    public partial class LinhaTermoUserControl : UserControl
    {
        private int indiceAtual = 0;
        public LinhaTermoUserControl()
        {
            InitializeComponent();
        }
           
        public void Digitar(string letra)
        {   
           
            Label labelSelecionada = (Label)gridColunas.Controls[0];
            List<Label> controles = gridColunas.Controls.Cast<Label>().Reverse().ToList();
            controles[indiceAtual].Text = letra;
            indiceAtual++;
        }
        public override string ToString()
        {
            string palavraCompleta = "";
            foreach(Label label in gridColunas.Controls.Cast<Label>().Reverse())
            {
                palavraCompleta += label.Text;
             
            }
            return palavraCompleta;

        }

        internal void ColorirLabels(termo.AvaliacaoLetra[] avaliacoes)
        {
            List<Label> controles = gridColunas.Controls.Cast<Label>().Reverse().ToList();
            for (int i = 0; i < avaliacoes.Length; i++)
            {
                
                Label labelSelecionado = controles[i];
                switch (avaliacoes[i])
                {
                    case termo.AvaliacaoLetra.Correta:
                        labelSelecionado.BackColor = Color.Blue;
                        break;
                    case termo.AvaliacaoLetra.PosicaoIncorreta:
                        labelSelecionado.BackColor = Color.Yellow;
                        break;
                    case termo.AvaliacaoLetra.NaoExistente:
                        labelSelecionado.BackColor = SystemColors.WindowFrame;
                        break;
                }
            }
        }
    }
}