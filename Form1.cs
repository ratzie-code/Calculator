using System.Data;


namespace calculator1
{
    public partial class Calculator : Form
    {
        private string currentCalculation = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click (object sender, EventArgs e)
        {
         currentCalculation += (sender as Button).Text;
            txtOutput.Text = currentCalculation;
        }
        private void buttton_Equals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();
            try
            {
                txtOutput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = txtOutput.Text;

            }
            catch(Exception ex)
            {
                txtOutput.Text = "Error";
                currentCalculation = "";
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            currentCalculation = "";
            txtOutput.Text = "";
        }
        private void button_clearEntery_click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation= currentCalculation.Remove(currentCalculation.Length - 1,1);   
            }
            txtOutput.Text = currentCalculation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
