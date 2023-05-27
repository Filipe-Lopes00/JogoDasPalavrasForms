using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasPalavrasForms.dominio
{
    public partial class termo
    {
        private string palavraSecreta = "";
        public int tentativas = 0;
        public termo() 
        {
            palavraSecreta = ObterPalavraAleatoria();
        
        }
        public AvaliacaoLetra[] Avaliar(string palavra)
        {
            tentativas++;
            AvaliacaoLetra[] avaliacoes = new AvaliacaoLetra[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == palavraSecreta[i])
                    avaliacoes[i] = AvaliacaoLetra.Correta;

                else if (palavraSecreta.Contains(palavra[i]))
                    avaliacoes[i] = AvaliacaoLetra.PosicaoIncorreta;

                else
                    avaliacoes[i] = AvaliacaoLetra.NaoExistente;

            }
            return avaliacoes;
        }
        public bool JogadorAcertou(string palavra)
        {
            return palavra == palavraSecreta;
        }
        public bool JagadorPerdeu()
        {
            return tentativas == 5;
        }

        private string ObterPalavraAleatoria()
        {
            string[] palavras = {
                "ABRIR",
                "AMIGO",
                "BEBER",
                "BOLDO",
                "CAIXA",
                "CASAL",
                "CORPO",
                "DEDOS",
                "DENTE",
                "DIZER",
                "ERROS",
                "FALAR",
                "FESTA",
                "FOGAO",
                "GANHO",
                "GIRAR",
                "GRITO",
                "HORAS",
                "JOGOS",
                "JULHO",
                "LIMAO",
                "LOUCO",
                "MACAS",
                "MAIOR",
                "MELAO",
                "MOLHO"
            };
            return palavras[0];

        }

    }
}
