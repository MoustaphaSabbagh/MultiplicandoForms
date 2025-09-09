namespace MultiplicandoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ENTRADA DE DADOS:
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int Resultado;

            //PROCESSAMENTO:
            Resultado = num1 * num2;

            //SAIDA DE DADOS:
            textBox3.Text = Resultado.ToString();
        }
        
    }
}
