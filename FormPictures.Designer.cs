namespace PhotoEditor
{
    partial class FormPictures
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Examinar = new FontAwesome.Sharp.IconButton();
            this.normal_Pic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveImage = new System.Windows.Forms.Button();
            this.resetImage = new System.Windows.Forms.Button();
            this.applyFilter = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.filtersCombo = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.normal_Pic)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Examinar
            // 
            this.Examinar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Examinar.FlatAppearance.BorderSize = 0;
            this.Examinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Examinar.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Examinar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Examinar.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.Examinar.IconColor = System.Drawing.Color.Gainsboro;
            this.Examinar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Examinar.IconSize = 18;
            this.Examinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Examinar.Location = new System.Drawing.Point(109, 10);
            this.Examinar.Name = "Examinar";
            this.Examinar.Size = new System.Drawing.Size(100, 28);
            this.Examinar.TabIndex = 0;
            this.Examinar.Text = "Examinar";
            this.Examinar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Examinar.UseVisualStyleBackColor = false;
            this.Examinar.Click += new System.EventHandler(this.Examinar_Click);
            // 
            // normal_Pic
            // 
            this.normal_Pic.BackColor = System.Drawing.Color.MediumPurple;
            this.normal_Pic.Location = new System.Drawing.Point(18, 26);
            this.normal_Pic.Name = "normal_Pic";
            this.normal_Pic.Size = new System.Drawing.Size(193, 194);
            this.normal_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.normal_Pic.TabIndex = 1;
            this.normal_Pic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 74);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 74);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imagen Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imagen Editada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Histograma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cargar Imagen";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Examinar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 45);
            this.panel3.TabIndex = 16;
            // 
            // saveImage
            // 
            this.saveImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveImage.Location = new System.Drawing.Point(155, 241);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(75, 23);
            this.saveImage.TabIndex = 7;
            this.saveImage.Text = "save";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // resetImage
            // 
            this.resetImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetImage.Location = new System.Drawing.Point(78, 241);
            this.resetImage.Name = "resetImage";
            this.resetImage.Size = new System.Drawing.Size(75, 23);
            this.resetImage.TabIndex = 6;
            this.resetImage.Text = "reset";
            this.resetImage.UseVisualStyleBackColor = true;
            this.resetImage.Click += new System.EventHandler(this.resetImage_Click);
            // 
            // applyFilter
            // 
            this.applyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applyFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.applyFilter.Location = new System.Drawing.Point(1, 241);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(75, 23);
            this.applyFilter.TabIndex = 5;
            this.applyFilter.Text = "apply";
            this.applyFilter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.normal_Pic);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.filtersCombo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 271);
            this.panel4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 8.25F);
            this.label5.Location = new System.Drawing.Point(18, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filtros";
            // 
            // filtersCombo
            // 
            this.filtersCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filtersCombo.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.filtersCombo.ForeColor = System.Drawing.Color.White;
            this.filtersCombo.FormattingEnabled = true;
            this.filtersCombo.Location = new System.Drawing.Point(68, 242);
            this.filtersCombo.Name = "filtersCombo";
            this.filtersCombo.Size = new System.Drawing.Size(121, 23);
            this.filtersCombo.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(462, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 271);
            this.panel5.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.Location = new System.Drawing.Point(18, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 194);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.applyFilter);
            this.panel6.Controls.Add(this.resetImage);
            this.panel6.Controls.Add(this.saveImage);
            this.panel6.Location = new System.Drawing.Point(237, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 271);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox2.Location = new System.Drawing.Point(18, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FormPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 464);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPictures";
            this.Text = "FormPictures";
            ((System.ComponentModel.ISupportInitialize)(this.normal_Pic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton Examinar;
        private System.Windows.Forms.PictureBox normal_Pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button resetImage;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filtersCombo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}