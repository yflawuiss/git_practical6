using System.Drawing.Text;
using System.Security.Cryptography.Pkcs;

namespace WinAsynchDelegate
{
    public partial class Form1 : Form
    {
        private delegate void TimeConsumingMethodDelegate(int seconds);

        public delegate void SetProgressDelegate(int val);

        public Form1()
        {
            InitializeComponent();
        }

        // Додавання методу TimeConsumingMethod
        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                if (Cancel)
                {
                    break;
                }
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(j * 100) / seconds);
            }

            if (Cancel)
            {
                System.Windows.Forms.MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete");
            }
        }

        bool Cancel;

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancel = false; // Сброс переменной Cancel перед началом новой задачи
            int seconds;
            if (int.TryParse(textBox1.Text, out seconds))
            {
                Task.Run(() => TimeConsumingMethod(seconds));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле повинно мати цифри");
            }
        }
    }
}