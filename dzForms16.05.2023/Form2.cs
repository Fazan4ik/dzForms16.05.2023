using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzForms16._05._2023
{
    public partial class Form2 : Form
    {
        private Button newButton;
        private Point startPoint;

        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            newButton = new Button();
            newButton.Location = e.Location;
            startPoint = e.Location;
            panel1.Controls.Add(newButton);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (newButton != null)
            {
                int width = Math.Abs(e.Location.X - startPoint.X);
                int height = Math.Abs(e.Location.Y - startPoint.Y);

                newButton.Size = new Size(width, height);
                if (e.Location.X < startPoint.X)
                    newButton.Left = e.X;
                if (e.Location.Y < startPoint.Y)
                    newButton.Top = e.Y;

                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            newButton = null;
        }
    }
}
