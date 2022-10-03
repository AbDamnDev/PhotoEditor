namespace PhotoEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.Customers = new FontAwesome.Sharp.IconButton();
            this.Camera = new FontAwesome.Sharp.IconButton();
            this.VideoEdit = new FontAwesome.Sharp.IconButton();
            this.PictureEdit = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.bars = new FontAwesome.Sharp.IconButton();
            this.Restore = new FontAwesome.Sharp.IconButton();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.Exit = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.Customers);
            this.panel1.Controls.Add(this.Camera);
            this.panel1.Controls.Add(this.VideoEdit);
            this.panel1.Controls.Add(this.PictureEdit);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 592);
            this.panel1.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.Settings.IconColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.IconSize = 32;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 380);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Settings.Size = new System.Drawing.Size(220, 60);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "    Creditos";
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Customers.FlatAppearance.BorderSize = 0;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.ForeColor = System.Drawing.Color.Gainsboro;
            this.Customers.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.Customers.IconColor = System.Drawing.Color.Gainsboro;
            this.Customers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Customers.IconSize = 32;
            this.Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.Location = new System.Drawing.Point(0, 320);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Customers.Size = new System.Drawing.Size(220, 60);
            this.Customers.TabIndex = 4;
            this.Customers.Text = "    Manual de Usuario";
            this.Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customers.UseVisualStyleBackColor = false;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Camera
            // 
            this.Camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Camera.FlatAppearance.BorderSize = 0;
            this.Camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Camera.ForeColor = System.Drawing.Color.Gainsboro;
            this.Camera.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.Camera.IconColor = System.Drawing.Color.Gainsboro;
            this.Camera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Camera.IconSize = 32;
            this.Camera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Camera.Location = new System.Drawing.Point(0, 260);
            this.Camera.Name = "Camera";
            this.Camera.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Camera.Size = new System.Drawing.Size(220, 60);
            this.Camera.TabIndex = 3;
            this.Camera.Text = "    Camara y deteccion de movimiento";
            this.Camera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Camera.UseVisualStyleBackColor = false;
            this.Camera.Click += new System.EventHandler(this.Products_Click);
            // 
            // VideoEdit
            // 
            this.VideoEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.VideoEdit.FlatAppearance.BorderSize = 0;
            this.VideoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.VideoEdit.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.VideoEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.VideoEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VideoEdit.IconSize = 32;
            this.VideoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VideoEdit.Location = new System.Drawing.Point(0, 200);
            this.VideoEdit.Name = "VideoEdit";
            this.VideoEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.VideoEdit.Size = new System.Drawing.Size(220, 60);
            this.VideoEdit.TabIndex = 2;
            this.VideoEdit.Text = "    Editor de Videos";
            this.VideoEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VideoEdit.UseVisualStyleBackColor = false;
            this.VideoEdit.Click += new System.EventHandler(this.Orders_Click);
            // 
            // PictureEdit
            // 
            this.PictureEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PictureEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PictureEdit.FlatAppearance.BorderSize = 0;
            this.PictureEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.PictureEdit.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.PictureEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.PictureEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PictureEdit.IconSize = 32;
            this.PictureEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PictureEdit.Location = new System.Drawing.Point(0, 140);
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PictureEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PictureEdit.Size = new System.Drawing.Size(220, 60);
            this.PictureEdit.TabIndex = 1;
            this.PictureEdit.Text = "    Editor de Fotos";
            this.PictureEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PictureEdit.UseVisualStyleBackColor = false;
            this.PictureEdit.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(-5, -14);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(188, 125);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 0;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitle.Controls.Add(this.panel2);
            this.panelTitle.Controls.Add(this.Restore);
            this.panelTitle.Controls.Add(this.Minimize);
            this.panelTitle.Controls.Add(this.Exit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(709, 63);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitleChildForm);
            this.panel2.Controls.Add(this.IconCurrentChildForm);
            this.panel2.Controls.Add(this.bars);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 35);
            this.panel2.TabIndex = 7;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(80, 8);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(67, 24);
            this.lblTitleChildForm.TabIndex = 3;
            this.lblTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 37;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(40, 0);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(37, 37);
            this.IconCurrentChildForm.TabIndex = 2;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // bars
            // 
            this.bars.Dock = System.Windows.Forms.DockStyle.Left;
            this.bars.FlatAppearance.BorderSize = 0;
            this.bars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bars.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.bars.IconColor = System.Drawing.Color.Gainsboro;
            this.bars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bars.IconSize = 32;
            this.bars.Location = new System.Drawing.Point(0, 0);
            this.bars.Margin = new System.Windows.Forms.Padding(0);
            this.bars.Name = "bars";
            this.bars.Size = new System.Drawing.Size(37, 35);
            this.bars.TabIndex = 0;
            this.bars.UseVisualStyleBackColor = true;
            this.bars.Click += new System.EventHandler(this.bars_Click);
            // 
            // Restore
            // 
            this.Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restore.ForeColor = System.Drawing.Color.Gainsboro;
            this.Restore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.Restore.IconColor = System.Drawing.Color.Gainsboro;
            this.Restore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Restore.IconSize = 15;
            this.Restore.Location = new System.Drawing.Point(599, 0);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(52, 24);
            this.Restore.TabIndex = 6;
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimize.IconColor = System.Drawing.Color.Gainsboro;
            this.Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimize.IconSize = 15;
            this.Minimize.Location = new System.Drawing.Point(548, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(45, 24);
            this.Minimize.TabIndex = 5;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.Exit.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.Exit.IconColor = System.Drawing.Color.Gainsboro;
            this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit.IconSize = 15;
            this.Exit.Location = new System.Drawing.Point(657, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 24);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 63);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(709, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktop.BackgroundImage")));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(709, 520);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 592);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(929, 592);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Settings;
        private FontAwesome.Sharp.IconButton Customers;
        private FontAwesome.Sharp.IconButton Camera;
        private FontAwesome.Sharp.IconButton VideoEdit;
        private FontAwesome.Sharp.IconButton PictureEdit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton Restore;
        private FontAwesome.Sharp.IconButton Minimize;
        private FontAwesome.Sharp.IconButton Exit;
        private FontAwesome.Sharp.IconButton bars;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

