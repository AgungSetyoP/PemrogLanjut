namespace KonversiSuhu
{
    public partial class Form1 : Form
    {
        double c, f, r, k; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(Celcius.Text);
            c = (c + 5);
            r = (c * 4) / 5;
            f = (c * 9 / 5) + 32;
            r = (c + 273);

            Celcius.Text = Convert.ToString(c);
            Far.Text = Convert.ToString(f);
            Reamur.Text = Convert.ToString(r);
            Kelvin.Text = Convert.ToString(k);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(Celcius.Text);
            c = (c - 5);
            r = (c * 4) / 5;
            f = (c * 9 / 5) + 32;
            r = (c + 273);

            Celcius.Text = Convert.ToString(c);
            Far.Text = Convert.ToString(f);
            Reamur.Text = Convert.ToString(r);
            Kelvin.Text = Convert.ToString(k);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Celcius.Text = "";
            Reamur.Text = "";
            Far.Text = "";
            Kelvin.Text = "";
        }

        private void Far_TextChanged(object sender, EventArgs e)
        {

        }

        private void Celcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Yakin ingin keluar?", "PILIHAN", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
              
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(Celcius.Text);
            r = (c * 4) / 5;
            f = (c * 9 / 5) + 32;
            r = (c + 273);

            Far.Text = Convert.ToString(f);
            Reamur.Text = Convert.ToString(r);
            Kelvin.Text = Convert.ToString(k);
        }
    }
}