using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaDAPL01
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Book1Box_Click(object sender, EventArgs e)
        {
            Desc1984.Text = "1984 descreve a luta de Winston\nSmith contra um regime\ntotalitário, onde a vigilância\nconstante e a manipulação\nideológica controlam cada\naspecto da vida dos cidadãos.";
        }

        private void Book2Box_Click(object sender, EventArgs e)
        {
            DescPoncia.Text = "Ponciá Vicêncio é a história de \numa mulher negra que busca \nsua identidade e liberdade \nem meio ao racismo e à \ndesigualdade social no Brasil.";
        }
        private void Book3Box_Click(object sender, EventArgs e)
        {
            DescEnsaio.Text = "Ensaio sobre a Cegueira retrata \numa cidade mergulhada no caos\ndevido \a uma epidemia de cegueira, \nexplorando os instintos humanos \nem meio ao colapso social \ne moral.";
        }
        private void Book4Box_Click(object sender, EventArgs e)
        {
            DescChato.Text = "Chato: O Rei do Brasil acompanha \na jornada de um personagem \nexcêntrico e provocador que \ndesafia as normas sociais e \npolíticas, provocando reflexões sobre \na cultura brasileira.";
        }

        private void Book5Box_Click(object sender, EventArgs e)
        {
            DescMito.Text = "O Mito da Beleza questiona os \npadrões de beleza, destacando os \ndanos causados pela obsessão \npela imagem corporal perfeita, e \npromove uma reflexão sobre a \nverdadeira essência da beleza \ne da autoaceitação.";
        }

        private void Book6Box_Click(object sender, EventArgs e)
        {
            DescAdmiravel.Text = "Admirável Mundo Novo retrata \numa sociedade distópica onde \na perfeição é buscada através \ndo controle absoluto, desafiando \nos valores da liberdade e \nindividualidade em favor \nda estabilidade.";
        }

        private void Book3Label_Click(object sender, EventArgs e)
        {

        }
        private void Book4Label_Click(object sender, EventArgs e)
        {

        }


    }
}
