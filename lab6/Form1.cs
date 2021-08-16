using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// settings
        /// </summary>
        Settings set;
        /// <summary>
        /// form coordinates
        /// </summary>
        Point formXY;
        /// <summary>
        /// mouse coordinates
        /// </summary>
        Point mouseXY;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1;
            timer.Start();
        }
        /// <summary>
        /// method for form loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Control.DefaultBackColor;
            timer.Interval = 1000;
            set = new Settings();
            Operations.save_default_settings(set);
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            if (!Operations.load_user_settings(ref set)) set = new Settings();
        }
        /// <summary>
        /// method for timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// method for graphics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(set.clock_size == 0 )
            {
                this.Width = 150;
                this.Height = 150;
                pictureBox1.Width = 150;
                pictureBox1.Height = 150;
            }
            if(set.clock_size == 1)
            {
                this.Width = 300;
                this.Height = 300;
                pictureBox1.Width = 300;
                pictureBox1.Height = 300;
            }
            if (set.clock_size == 2)
            {
                this.Width = 450;
                this.Height = 450;
                pictureBox1.Width = 450;
                pictureBox1.Height = 450;
            }
            Graphics gr = e.Graphics;
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gr.FillEllipse(new SolidBrush(set.clock_color), 2, 2, this.Width - 4, this.Height - 4);
            gr.DrawEllipse(new Pen(Color.Black, 8), 5, 5, this.Width - 10, this.Height - 10);
            Operations.hands_paint(pictureBox1, gr, set);
            Operations.digits_paint(pictureBox1, gr, set);
            if (set.clock_type) Operations.digital_watch(pictureBox1, gr, set);
        }
        /// <summary>
        /// analog watch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_analog_Click(object sender, EventArgs e)
        {
            set.clock_type = false;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// digital watch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_digital_Click(object sender, EventArgs e)
        {
            set.clock_type = true;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// hand second solor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_color_sec_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rd = cd.ShowDialog();
            if (rd == DialogResult.OK) set.sec_color = cd.Color;
            if (rd == DialogResult.Cancel) return;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// hand minute color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_color_min_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rd = cd.ShowDialog();
            if (rd == DialogResult.OK) set.min_color = cd.Color;
            if (rd == DialogResult.Cancel) return;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// hand hour color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_color_hour_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rd = cd.ShowDialog();
            if (rd == DialogResult.OK) set.hour_color = cd.Color;
            if (rd == DialogResult.Cancel) return;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// clock color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_color_clock_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rd = cd.ShowDialog();
            if (rd == DialogResult.OK) set.clock_color = cd.Color;
            if (rd == DialogResult.Cancel) return;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// digits color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_color_digits_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult rd = cd.ShowDialog();
            if (rd == DialogResult.OK) set.digits_color = cd.Color;
            if (rd == DialogResult.Cancel) return;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Operations.save_user_settings(set);
            Close();
        }
        /// <summary>
        /// mouse press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseXY = Cursor.Position;
        }
        /// <summary>
        /// form moove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                formXY = e.Location;
                formXY = this.PointToScreen(formXY);
                this.Left += formXY.X - mouseXY.X;
                this.Top += formXY.Y - mouseXY.Y;
                mouseXY = formXY;
            }
        }
        /// <summary>
        /// infornation menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_info_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        /// <summary>
        /// small clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_small_Click(object sender, EventArgs e)
        {
            set.clock_size = 0;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// medium clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_medium_Click(object sender, EventArgs e)
        {
            set.clock_size = 1;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// big clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_big_Click(object sender, EventArgs e)
        {
            set.clock_size = 2;
            pictureBox1.Invalidate();
        }
        /// <summary>
        /// default setting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_default_Click(object sender, EventArgs e)
        {
            set = new Settings();
        }
    }
}
