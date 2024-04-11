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

        string sinopse;
        public HomePage()
        {
            InitializeComponent();
        }

        private void Book1Box_Click(object sender, EventArgs e)
        {
            Desc1984.Text = GetSinopse1();

        }

        private void Book2Box_Click(object sender, EventArgs e)
        {
            DescPoncia.Text = GetSinopse2();
        }
        private void Book3Box_Click(object sender, EventArgs e)
        {
            DescEnsaio.Text = GetSinopse3();
        }
        private void Book4Box_Click(object sender, EventArgs e)
        {
            DescChato.Text = GetSinopse4();
        }

        private void Book5Box_Click(object sender, EventArgs e)
        {
            DescMito.Text =  GetSinopse5();
        }

        private void Book6Box_Click(object sender, EventArgs e)
        {
            DescAdmiravel.Text = GetSinopse6();
        }

        private void Book3Label_Click(object sender, EventArgs e)
        {

        }
        private void Book4Label_Click(object sender, EventArgs e)
        {

        }
        private string GetSinopse1()
        {
           sinopse = "1984 descreve a luta de Winston\nSmith contra um regime\ntotalitário, onde a vigilância\nconstante e a manipulação\nideológica controlam cada\naspecto da vida dos cidadãos.";
            return (sinopse);
        }
        private string GetSinopse2()
        {
            sinopse = "Ponciá Vicêncio é a história de \numa mulher negra que busca \nsua identidade e liberdade \nem meio ao racismo e à \ndesigualdade social no Brasil.";
            return (sinopse);
        }
        private string GetSinopse3()
        {
            sinopse = "Ensaio sobre a Cegueira retrata \numa cidade mergulhada no caos\ndevido a uma epidemia de cegueira, \nexplorando os instintos humanos \nem meio ao colapso social \ne moral.";
            return (sinopse);
        }
        private string GetSinopse4()
        {
            sinopse = "Chato: O Rei do Brasil acompanha \na jornada de um personagem \nexcêntrico e provocador que \ndesafia as normas sociais e \npolíticas, provocando reflexões sobre \na cultura brasileira.";
            return (sinopse);
        }
        private string GetSinopse5()
        {
            sinopse = "O Mito da Beleza questiona os \npadrões de beleza, destacando os \ndanos causados pela obsessão \npela imagem corporal perfeita, e \npromove uma reflexão sobre a \nverdadeira essência da beleza \ne da autoaceitação.";
            return (sinopse);
        }
        private string GetSinopse6()
        {
            sinopse = "Admirável Mundo Novo retrata \numa sociedade distópica onde \na perfeição é buscada através \ndo controle absoluto, desafiando \nos valores da liberdade e \nindividualidade em favor \nda estabilidade.";
            return (sinopse);
        }
    }
}
