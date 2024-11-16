namespace WinAsynchMethod
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int a, int b);

        public Form1()
        {
            InitializeComponent();
        }

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void tbxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // ������������ ���� �����
                a = Int32.Parse(tbxA.Text);
                b = Int32.Parse(tbxB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("��� �������� ������������ ���� ������� �������");
                tbxA.Text = tbxB.Text = "";
                return;
            }

            Task.Run(() =>
            {
                int result = Summ(a, b);
                Invoke(new Action(() =>
                {
                    string str = String.Format("���� �������� ����� ������� {0}", result);
                    MessageBox.Show(str, "��������� ��������");
                }));
            });
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm? summdelegate = ar.AsyncState as AsyncSumm;
            if (summdelegate != null)
            {
                str = String.Format("���� �������� ����� ������� {0}", summdelegate.EndInvoke(ar));
                MessageBox.Show(str, "��������� ��������");
            }
            else
            {
                MessageBox.Show("������� ��� ������������ �������", "�������");
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ������!!!");
        }
    }
}