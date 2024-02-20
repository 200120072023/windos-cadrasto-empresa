using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01_Aula_João
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CADASTRAR_Click(object sender, EventArgs e)
        {
            string cnpj = (box_CNPJ.Text);
            string razao = (tx_razão.Text);
            string nomeFantasia = (tx_fantasia.Text);
            string Situacao = (comboBox_situacao.Text);
            
            string regimetri = ("");
            string datainicio = (maskedTextBox_datainicio.Text);
            string  telefone = (maskedTextBox_telefone.Text);
            double capital = Convert.ToDouble(text_capitalsocial.Text);
            string endereço = (maskedTextBox_telefone.Text);
            string tipo = (""); 
            string porteempresa = ("");
            string juridica = (comboBox2.Text);
            string propretario = (textBox13.Text);
            string cpfpropretario  = (textBox14.Text);

            if (radioButton1.Checked == true)
            {
                regimetri = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                regimetri = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                regimetri = radioButton3.Text;
            }
            if (radioButton7.Checked == true)
            {
                tipo = radioButton7.Text;
            }
            if (radioButton6.Checked == true)
            {
                tipo = radioButton6.Text;
            }
            if (radioButton4.Checked == true)
            {
                porteempresa = radioButton4.Text;
            }
            if (radioButton5.Checked == true)
            {
                porteempresa = radioButton5.Text;
            } 
            if (PEQUENO.Checked == true)
            {
                porteempresa = PEQUENO.Text;
            }


            string texto = @"C:\Users\2022102020054\Desktop\Nova pasta\TESTE.txt";

            using (StreamWriter sw = new StreamWriter(texto))
            {
                sw.WriteLine(MessageBox.Show($"CNPJ = {cnpj}\n" + $"Razão Social:{razao}\n" + $"Nome Fatasia:{nomeFantasia}\n" + $"Situação:{Situacao}\n" +
                $"Regime Tributário:{regimetri}\n" + $"Data de iníco:{datainicio}\n" + $"Telefone:{telefone}\n" + $"Capital:{capital}\n" +
                 $"Endereço:{endereço}\n" + $"Tipo:{tipo}\n" + $"Porte da Empresa:{porteempresa}\n" + $"Juridica:{juridica}\n"
                 + $"Propreteratio:{propretario}\n" + $"Cpf do propretério:{cpfpropretario}\n"));
            }









        }
    }
}
