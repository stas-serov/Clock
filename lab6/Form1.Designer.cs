
namespace lab6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_type = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_analog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_digital = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_color_sec = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_color_min = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_color_hour = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_color_clock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_color_digits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_size = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_small = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_medium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_big = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_default = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_type,
            this.toolStripMenuItem_color_sec,
            this.toolStripMenuItem_color_min,
            this.toolStripMenuItem_color_hour,
            this.toolStripMenuItem_color_clock,
            this.toolStripMenuItem_color_digits,
            this.toolStripMenuItem_size,
            this.toolStripMenuItem_default,
            this.toolStripMenuItem_info,
            this.toolStripMenuItem_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 246);
            // 
            // toolStripMenuItem_type
            // 
            this.toolStripMenuItem_type.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_analog,
            this.toolStripMenuItem_digital});
            this.toolStripMenuItem_type.Name = "toolStripMenuItem_type";
            this.toolStripMenuItem_type.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_type.Text = "Тип часов";
            // 
            // toolStripMenuItem_analog
            // 
            this.toolStripMenuItem_analog.Name = "toolStripMenuItem_analog";
            this.toolStripMenuItem_analog.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem_analog.Text = "Аналоговые";
            this.toolStripMenuItem_analog.Click += new System.EventHandler(this.toolStripMenuItem_analog_Click);
            // 
            // toolStripMenuItem_digital
            // 
            this.toolStripMenuItem_digital.Name = "toolStripMenuItem_digital";
            this.toolStripMenuItem_digital.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem_digital.Text = "Аналоговые + Цифровые";
            this.toolStripMenuItem_digital.Click += new System.EventHandler(this.toolStripMenuItem_digital_Click);
            // 
            // toolStripMenuItem_color_sec
            // 
            this.toolStripMenuItem_color_sec.Name = "toolStripMenuItem_color_sec";
            this.toolStripMenuItem_color_sec.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_color_sec.Text = "Цвет секундной стрелки";
            this.toolStripMenuItem_color_sec.Click += new System.EventHandler(this.toolStripMenuItem_color_sec_Click);
            // 
            // toolStripMenuItem_color_min
            // 
            this.toolStripMenuItem_color_min.Name = "toolStripMenuItem_color_min";
            this.toolStripMenuItem_color_min.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_color_min.Text = "Цвет минутной стрелки";
            this.toolStripMenuItem_color_min.Click += new System.EventHandler(this.toolStripMenuItem_color_min_Click);
            // 
            // toolStripMenuItem_color_hour
            // 
            this.toolStripMenuItem_color_hour.Name = "toolStripMenuItem_color_hour";
            this.toolStripMenuItem_color_hour.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_color_hour.Text = "Цвет часовой стрелки";
            this.toolStripMenuItem_color_hour.Click += new System.EventHandler(this.toolStripMenuItem_color_hour_Click);
            // 
            // toolStripMenuItem_color_clock
            // 
            this.toolStripMenuItem_color_clock.Name = "toolStripMenuItem_color_clock";
            this.toolStripMenuItem_color_clock.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_color_clock.Text = "Цвет циферблата";
            this.toolStripMenuItem_color_clock.Click += new System.EventHandler(this.toolStripMenuItem_color_clock_Click);
            // 
            // toolStripMenuItem_color_digits
            // 
            this.toolStripMenuItem_color_digits.Name = "toolStripMenuItem_color_digits";
            this.toolStripMenuItem_color_digits.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_color_digits.Text = "Цвет цифр";
            this.toolStripMenuItem_color_digits.Click += new System.EventHandler(this.toolStripMenuItem_color_digits_Click);
            // 
            // toolStripMenuItem_size
            // 
            this.toolStripMenuItem_size.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_small,
            this.toolStripMenuItem_medium,
            this.toolStripMenuItem_big});
            this.toolStripMenuItem_size.Name = "toolStripMenuItem_size";
            this.toolStripMenuItem_size.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_size.Text = "Размер циферблата";
            // 
            // toolStripMenuItem_small
            // 
            this.toolStripMenuItem_small.Name = "toolStripMenuItem_small";
            this.toolStripMenuItem_small.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_small.Text = "Малый";
            this.toolStripMenuItem_small.Click += new System.EventHandler(this.toolStripMenuItem_small_Click);
            // 
            // toolStripMenuItem_medium
            // 
            this.toolStripMenuItem_medium.Name = "toolStripMenuItem_medium";
            this.toolStripMenuItem_medium.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_medium.Text = "Средний";
            this.toolStripMenuItem_medium.Click += new System.EventHandler(this.toolStripMenuItem_medium_Click);
            // 
            // toolStripMenuItem_big
            // 
            this.toolStripMenuItem_big.Name = "toolStripMenuItem_big";
            this.toolStripMenuItem_big.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_big.Text = "Большой";
            this.toolStripMenuItem_big.Click += new System.EventHandler(this.toolStripMenuItem_big_Click);
            // 
            // toolStripMenuItem_default
            // 
            this.toolStripMenuItem_default.Name = "toolStripMenuItem_default";
            this.toolStripMenuItem_default.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_default.Text = "Настройки по умолчанию";
            this.toolStripMenuItem_default.Click += new System.EventHandler(this.toolStripMenuItem_default_Click);
            // 
            // toolStripMenuItem_info
            // 
            this.toolStripMenuItem_info.Name = "toolStripMenuItem_info";
            this.toolStripMenuItem_info.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_info.Text = "Информация об авторе ";
            this.toolStripMenuItem_info.Click += new System.EventHandler(this.toolStripMenuItem_info_Click);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_exit.Text = "Выход";
            this.toolStripMenuItem_exit.Click += new System.EventHandler(this.toolStripMenuItem_exit_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_type;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_analog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_digital;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_color_sec;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_color_min;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_color_hour;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_color_clock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_size;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_small;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_medium;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_big;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_info;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_color_digits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_default;
    }
}

