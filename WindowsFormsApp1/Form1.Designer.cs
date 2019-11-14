namespace IntersectColorChanger
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
            this.button1 = new System.Windows.Forms.Button();
            this.redPictureBox = new System.Windows.Forms.PictureBox();
            this.invertPictureBox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(698, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redPictureBox
            // 
            this.redPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redPictureBox.Location = new System.Drawing.Point(0, 0);
            this.redPictureBox.Name = "redPictureBox";
            this.redPictureBox.Size = new System.Drawing.Size(760, 547);
            this.redPictureBox.TabIndex = 3;
            this.redPictureBox.TabStop = false;
            this.redPictureBox.Visible = false;
            // 
            // invertPictureBox
            // 
            this.invertPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invertPictureBox.Location = new System.Drawing.Point(0, 0);
            this.invertPictureBox.Name = "invertPictureBox";
            this.invertPictureBox.Size = new System.Drawing.Size(760, 547);
            this.invertPictureBox.TabIndex = 4;
            this.invertPictureBox.TabStop = false;
            this.invertPictureBox.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Form",
            "RED",
            "INVERT"});
            this.listBox1.Location = new System.Drawing.Point(698, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(50, 43);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 547);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.invertPictureBox);
            this.Controls.Add(this.redPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invertPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox redPictureBox;
        private System.Windows.Forms.PictureBox invertPictureBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

