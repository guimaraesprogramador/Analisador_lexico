using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void analisar_Click(object sender, EventArgs e)
        {
            Comentario_fonte.texto = textBox1.Text;
            switch (fonte.main())
            {
                case "erro":
                    listBox3.Items.Add("erro de identicador");
                    break;
                case "erro lexico":
                    listBox3.Items.Add("erro lexico");
                    break;
                case "erro lexico e identicador":
                    break;
                default:
                    listBox1.Items.Add(fonte.main());
                    textBox2.Text = Convert.ToString(Comentario_fonte.token);
                    listBox2.Items.Add(Identificador.comentario_identifador(Token.token));
                    break;
            }
            textBox1.Clear();

        }
    }
}
