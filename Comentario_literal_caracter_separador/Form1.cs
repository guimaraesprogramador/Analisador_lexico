using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Comentario_literal_caracter_separador
{
    public partial class Form1 : Form
    {
        private Comentario_fonte fonte;
        public Form1()
        {
            InitializeComponent();
            listBox3.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            fonte = new Comentario_fonte();
        }
      //  public static int linha;
        private void analisar_Click(object sender, EventArgs e)
        {
            ///linha = textBox1.Lines.Count();
            Comentario_fonte.texto = textBox1.Text.ToCharArray();
           List<string> resposta = fonte.main();
            analisador_lexico(resposta);
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "*.txt";
            openFileDialog.ShowDialog();
            Stream stream = openFileDialog.OpenFile();
            using (StreamReader sr = new StreamReader(stream))
            {
               
            }
            }
        public void analisador_lexico(List<string> resposta)
        {
            for (int o = 0; o < resposta.Count; o++)
            {

                switch (resposta[o])
                {
                    case "erro metadado":
                        listBox3.Items.Add("erro metadado");
                        break;
                    case "erro lexico":
                        listBox3.Items.Add("erro lexico");
                        break;
                    case "é comentario":
                        listBox4.Items.Add("é comentario");
                        break;
                    default:
                        if(resposta[o].ToString()=="erro"||resposta[o].ToString()== "erro de bloco"||
                            resposta[o].ToString() == "Caracter não terminado até E.O.F"||
                            resposta[o].ToString() == @"'\" + "outros"||
                            resposta[o].ToString()== "erro de metadados"||
                            resposta[o].ToString() == "'" + "outros")
                        {
                            listBox3.Items.Add(resposta[o].ToString());
                        }

                        else
                        {
                            listBox1.Items.Add(resposta[o].ToString());
                        }
                       
                        break;
                }
            }
        }
    }
}
