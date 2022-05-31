namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static int p1;
        public static int p2;
        public static int p3;

        public static long creditos = 100;
        public static long total = 0;
        public static int apuesta = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("2.png");
            pictureBox2.Image = Image.FromFile("3.png");
            pictureBox3.Image = Image.FromFile("1.png");
        }

        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void Palanca1_MouseDown(object sender, MouseEventArgs e)
        {
            Palanca1.Visible = false;
            Palanca2.Visible = true;

            if (creditos >= apuesta)
            {
                creditos = creditos - apuesta;
                label1.Text = "Creditos: " + creditos.ToString();

                for (var i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 17);
                    p2 = IntUtil.Random(1, 17);
                    p3 = IntUtil.Random(1, 17);
                }

                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(p1.ToString() + ".png");

                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile(p2.ToString() + ".png");

                if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile(p3.ToString() + ".png");

                total = 0;


                if (p1 == 3) total = total + 5;

                if (p1 == 2 & p2 == 2) total = total + 10;
                if (p1 == 3 & p2 == 3) total = total + 10;

                if (p1 == 1 & p2 == 1 & p3 == 1) total = total + 20;
                if (p1 == 2 & p2 == 2 & p3 == 2) total = total + 30;
                if (p1 == 3 & p2 == 3 & p3 == 3) total = total + 50;
                if (p1 == 4 & p2 == 4 & p3 == 4) total = total + 20;
                if (p1 == 5 & p2 == 5 & p3 == 5) total = total + 20;
                if (p1 == 6 & p2 == 6 & p3 == 6) total = total + 20;
                if (p1 == 7 & p2 == 7 & p3 == 7) total = total + 20;
                if (p1 == 8 & p2 == 8 & p3 == 8) total = total + 20;
                if (p1 == 9 & p2 == 9 & p3 == 9) total = total + 20;
                if (p1 == 10 & p2 == 10 & p3 == 10) total = total + 20;
                if (p1 == 11 & p2 == 11 & p3 == 11) total = total + 20;
                if (p1 == 12 & p2 == 12 & p3 == 12) total = total + 20;
                if (p1 == 13 & p2 == 13 & p3 == 13) total = total + 20;
                if (p1 == 14 & p2 == 14 & p3 == 14) total = total + 20;
                if (p1 == 15 & p2 == 15 & p3 == 15) total = total + 20;
                if (p1 == 16 & p2 == 16 & p3 == 16) total = total + 20;

                creditos = creditos + total;
                label3.Text = "Victoria: " + total.ToString();
                label1.Text = "Creditos: " + creditos.ToString();
            }

        }

        private void Palanca1_MouseUp(object sender, MouseEventArgs e)
        {
            Palanca1.Visible=true;
            Palanca2.Visible=false;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}