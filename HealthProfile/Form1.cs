namespace HealthProfile
{
    public partial class Form1 : Form
    {
        Patient person = new Patient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message;
                
            try
            {
                string fn = textBox1.Text;
                string ln = textBox6.Text;
                string gn = textBox2.Text;
                int h = int.Parse(textBox4.Text);
                int w = int.Parse(textBox5.Text);
                int m = int.Parse(textBox3.Text);
                int d = int.Parse(textBox7.Text);
                int y = int.Parse(textBox8.Text);

                person.Name = fn + " " + ln;
                person.Gender = gn;
                person.Age = y;
                person.Height = h;
                person.Weight = w;
                person.Max = 0;
                person.Target = "";
                person.BMI = 0;

                message = person.getPatientInfo();

            } catch(Exception ex) {
                message = "Error! Your input is not valid. Try again.\n";
            }
        
            MessageBox.Show(message);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BMIChart chart = new BMIChart();
            DialogResult result = chart.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
                chart.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}