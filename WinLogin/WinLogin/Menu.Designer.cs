namespace WinLogin
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdmiUser = new System.Windows.Forms.Button();
            this.btnpermisos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 31);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCerrar.Location = new System.Drawing.Point(16, 458);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(205, 42);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdmiUser
            // 
            this.btnAdmiUser.BackColor = System.Drawing.Color.Gray;
            this.btnAdmiUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmiUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmiUser.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmiUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdmiUser.Location = new System.Drawing.Point(16, 279);
            this.btnAdmiUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmiUser.Name = "btnAdmiUser";
            this.btnAdmiUser.Size = new System.Drawing.Size(205, 65);
            this.btnAdmiUser.TabIndex = 3;
            this.btnAdmiUser.Text = "Administrar\r\nUsuario";
            this.btnAdmiUser.UseVisualStyleBackColor = false;
            this.btnAdmiUser.Click += new System.EventHandler(this.btnAdmiUser_Click);
            // 
            // btnpermisos
            // 
            this.btnpermisos.BackColor = System.Drawing.Color.Gray;
            this.btnpermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpermisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpermisos.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpermisos.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnpermisos.Location = new System.Drawing.Point(16, 364);
            this.btnpermisos.Margin = new System.Windows.Forms.Padding(4);
            this.btnpermisos.Name = "btnpermisos";
            this.btnpermisos.Size = new System.Drawing.Size(205, 65);
            this.btnpermisos.TabIndex = 4;
            this.btnpermisos.Text = "Administrar permisos";
            this.btnpermisos.UseVisualStyleBackColor = false;
            this.btnpermisos.Click += new System.EventHandler(this.btnpermisos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 575);
            this.Controls.Add(this.btnpermisos);
            this.Controls.Add(this.btnAdmiUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdmiUser;
        private System.Windows.Forms.Button btnpermisos;
    }
}

