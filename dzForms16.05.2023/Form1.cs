namespace dzForms16._05._2023
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MoveButtonToRandomPosition();
        }

        private void MoveButtonToRandomPosition()
        {
            int maxX = ClientSize.Width - button1.Width;
            int maxY = ClientSize.Height - button1.Height;

            int newX = random.Next(maxX);
            int newY = random.Next(maxY);

            button1.Location = new Point(newX, newY);
        }
    }
}