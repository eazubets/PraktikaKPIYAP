using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR8
{
    public partial class Form1 : Form
    {
        private List<Drawable> shapes = new List<Drawable>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Drawable shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
        private void AddShape(Drawable shape)
        {
            shapes.Add(shape);
            Invalidate(); // Перерисовать форму
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(50, 50, 100, 200);
            AddShape(rect);
        }
    }
    public interface Drawable
    {
        void Draw(Graphics g);
    }

    public abstract class Figure : Drawable
    {
        protected int x;
        protected int y;

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics g);
    }

    public class Rectangle : Figure
    {
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, x, y, width, height);
        }
    }
    
}