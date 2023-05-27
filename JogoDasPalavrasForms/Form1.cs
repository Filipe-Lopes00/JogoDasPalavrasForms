using JogoDasPalavrasForms.controles;
using JogoDasPalavrasForms.dominio;
using static JogoDasPalavrasForms.dominio.termo;

namespace JogoDasPalavrasForms
{
    public partial class TelaPricipal : Form
    {
        private termo jogo;
        public LinhaTermoUserControl LinhaAtual
        {
            get
            {
                return (LinhaTermoUserControl)gridPrincipal.Controls[jogo.tentativas];
            }
        }
        public TelaPricipal()
        {

            InitializeComponent();
            RegistrarEventos();
            jogo = new termo();
        }

        public void RegistrarEventos()
        {
            foreach (Button botao in tableLayoutPanel2.Controls)
            {
                if (botao.Name == "btENTER")
                    continue;
                botao.Click += DigitarLetra;

            }
            btENTER.Click += AvaliarPalavra;
        }

        private void AvaliarPalavra(object? sender, EventArgs e)
        {
            string palavraCompleta = LinhaAtual.ToString();
            AvaliacaoLetra[] avaliacoes = jogo.Avaliar(palavraCompleta);
            LinhaAtual.ColorirLabels(avaliacoes);
            

        }

        private void DigitarLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            LinhaAtual.Digitar(botaoClicado.Text);
        }
    }



}