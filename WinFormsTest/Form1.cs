namespace WinFormsTest
{
    public partial class Bebra : Form
    {
        bool tula = false;
        bool smak = false;
        bool bebra = false;
        public Bebra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ������� �����", "����� ��������");
            this.label2.Text = "�������";
            while (this.progressBar1.Value < 100) 
            {
                this.progressBar1.Value += 1;
            }
            bebra = true;
            this.label2.Text = "����� �������!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� ����� ������ �������� ����", "� ���������");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� �� ����� �� �� ������", "������");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ������� ������� �����", "������� ����� ��������");
            this.label4.Text = "�������";
            while (this.progressBar2.Value < 100)
            {
                this.progressBar2.Value += 1;
            }
            smak = true;
            this.label4.Text = "������� ����� �������!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�� ����� �������� ������", "������");
            tula = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�� ����� �� ����� � ��� �����. ������ ���������� ����� ��� �������.", "�����");
            if (bebra && smak && tula)
            {
                MessageBox.Show("�� ������� �������� ��� �����! ����������!", "��� ������");
                System.IO.File.WriteAllText("C:/Users/" + Environment.UserName + "/Desktop/������.txt", "�� �������� ��� �����");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("��� ����� ������� ���! ���������� ����������� �������!", "���");
                Application.Exit();
            }
        }
    }
    
}