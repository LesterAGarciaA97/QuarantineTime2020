using System;
using System.Drawing;
using System.Windows.Forms;

namespace InformaticGirlfriendQuestion
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void NO_MouseEnter(object sender, EventArgs e)
        {
            int newX = r.Next(0, this.Size.Width - NO.Size.Width);
            int newY = r.Next(0, this.Size.Height - NO.Size.Height);
            NO.Location = new Point(newX, newY);
        }
        private void SI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya sabía que querías ser mi novia 🙈", "😍 🖤");
            Environment.Exit(0);
        }
    }
}
