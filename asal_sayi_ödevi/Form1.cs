namespace asal_sayi_ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            long num = Convert.ToInt64(textBox1.Text);
            for(long i = 2; i <= num; i++)
            {
                int controller = 0;
                for(long j = 2; j < i; j++)
                {
                    if(i % j == 0) { 
                        controller++;
                        break;
                    }
                }
                if(controller == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
            label3.Text = listBox1.Items.Count.ToString();
        }
    }
}