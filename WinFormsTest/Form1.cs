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
            MessageBox.Show("Начато нюхание бебры", "Бебра нюхается");
            this.label2.Text = "Бебринг";
            while (this.progressBar1.Value < 100) 
            {
                this.progressBar1.Value += 1;
            }
            bebra = true;
            this.label2.Text = "Бебра внюхана!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это новая версия нюхателя бебр", "О программе");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лучше не тыкай на всё подряд", "Хехехе");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Начато нюхание смачной бебры", "Смачная бебра нюхается");
            this.label4.Text = "Бебринг";
            while (this.progressBar2.Value < 100)
            {
                this.progressBar2.Value += 1;
            }
            smak = true;
            this.label4.Text = "Смачная бебра внюхана!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы съели тульский пряник", "Пряник");
            tula = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы пошли на битву с мшк фреде. Только сильнейшие могут его одолеть.", "Фреде");
            if (bebra && smak && tula)
            {
                MessageBox.Show("Вы успешно победили Мшк Фреде! Поздравляю!", "ура победа");
                System.IO.File.WriteAllText("C:/Users/" + Environment.UserName + "/Desktop/трофей.txt", "вы победили мшк фреде");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Мшк фреде победил вас! Попробуйте прокачаться сильнее!", "лох");
                Application.Exit();
            }
        }
    }
    
}