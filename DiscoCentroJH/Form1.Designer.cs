
namespace DiscoCentroJH
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblerror = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblerror);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtlogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Image = global::DiscoCentroJH.Properties.Resources.png_clipart_computer_icons_user_interface_scalable_graphics_error_sign_cancel_button_angle_mirror;
            this.lblerror.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblerror.Location = new System.Drawing.Point(24, 379);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(75, 13);
            this.lblerror.TabIndex = 8;
            this.lblerror.Tag = "";
            this.lblerror.Text = "Error Message";
            this.lblerror.Visible = false;
            this.lblerror.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DiscoCentroJH.Properties.Resources.logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(3, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(335, 145);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogin.Location = new System.Drawing.Point(118, 314);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(80, 36);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "button1";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.LightBlue;
            this.txtpass.Location = new System.Drawing.Point(27, 266);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(288, 26);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Password";
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.LightBlue;
            this.txtlogin.Location = new System.Drawing.Point(27, 208);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(288, 26);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.Text = "Usuario";
            this.txtlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtlogin.Enter += new System.EventHandler(this.txtlogin_Enter);
            this.txtlogin.Leave += new System.EventHandler(this.txtlogin_Leave);
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = global::DiscoCentroJH.Properties.Resources._61155;
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncerrar.Location = new System.Drawing.Point(973, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackgroundImage = global::DiscoCentroJH.Properties.Resources.icone_trait_gris;
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmin.Image = global::DiscoCentroJH.Properties.Resources._61155;
            this.btnmin.Location = new System.Drawing.Point(952, 12);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(15, 15);
            this.btnmin.TabIndex = 6;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscoCentroJH.Properties.Resources.foto_y_escenario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblerror;
    }
}

