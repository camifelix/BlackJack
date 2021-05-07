using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class form_apresentacao : Form
    {
        public form_apresentacao()
        {
            InitializeComponent();
            btn_Iniciar.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Form jogo = new Form_jogo(textBox1.Text,textBox2.Text);

            jogo.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox2.Text.Count() > 0) {
                btn_Iniciar.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && textBox1.Text.Count() > 0)
            {
                btn_Iniciar.Enabled = true;
            }
        }
    }
}
