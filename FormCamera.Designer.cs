﻿namespace PhotoEditor
{
    partial class FormCamera
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PB_webcam = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_webcamslist = new System.Windows.Forms.ComboBox();
            this.btn_webcamstart = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_webcam)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 74);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 74);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.btn_webcamstart);
            this.panel4.Controls.Add(this.cb_webcamslist);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.PB_webcam);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 316);
            this.panel4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F);
            this.label5.Location = new System.Drawing.Point(192, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Camara";
            // 
            // PB_webcam
            // 
            this.PB_webcam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_webcam.BackColor = System.Drawing.Color.MediumPurple;
            this.PB_webcam.Location = new System.Drawing.Point(13, 34);
            this.PB_webcam.Name = "PB_webcam";
            this.PB_webcam.Size = new System.Drawing.Size(427, 240);
            this.PB_webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_webcam.TabIndex = 1;
            this.PB_webcam.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(454, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 316);
            this.panel3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(20, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10F);
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Personas en movimiento";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10F);
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total de personas";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F);
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deteccion de movimiento";
            // 
            // cb_webcamslist
            // 
            this.cb_webcamslist.FormattingEnabled = true;
            this.cb_webcamslist.Location = new System.Drawing.Point(70, 282);
            this.cb_webcamslist.Name = "cb_webcamslist";
            this.cb_webcamslist.Size = new System.Drawing.Size(167, 21);
            this.cb_webcamslist.TabIndex = 15;
            // 
            // btn_webcamstart
            // 
            this.btn_webcamstart.Location = new System.Drawing.Point(264, 283);
            this.btn_webcamstart.Name = "btn_webcamstart";
            this.btn_webcamstart.Size = new System.Drawing.Size(79, 19);
            this.btn_webcamstart.TabIndex = 16;
            this.btn_webcamstart.Text = "start";
            this.btn_webcamstart.UseVisualStyleBackColor = true;
            this.btn_webcamstart.Click += new System.EventHandler(this.btn_webcamstart_Click);
            // 
            // FormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormCamera";
            this.Text = "FormCamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCamera_FormClosing);
            this.Load += new System.EventHandler(this.FormCamera_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_webcam)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PB_webcam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_webcamstart;
        private System.Windows.Forms.ComboBox cb_webcamslist;
    }
}