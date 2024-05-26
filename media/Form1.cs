using System;
using System.Windows.Forms;

namespace media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            try
            {
                float soma = 0;
                int count = 0;

                foreach (Control controle in this.Controls)
                {
                    if (controle is TextBox && controle.Visible)
                    {
                        soma += Convert.ToSingle(((TextBox)controle).Text);
                        count++;
                    }
                }

                if (count > 0)
                {
                    float media = soma / count;
                    label7.Text = media.ToString();
                }
                else
                {
                    label7.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Limpar
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = string.Empty;
                }
            }
            label7.Text = "...";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Clear Checkbox
        {
            bool isChecked = checkBox1.Checked;

            label4.Visible = !isChecked;
            label5.Visible = !isChecked;
            textBox3.Visible = !isChecked;
            textBox4.Visible = !isChecked;
        }
    }
}
