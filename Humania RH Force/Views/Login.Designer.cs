namespace Humania_RH_Force.Views
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelContenedor = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelDerecho = new Panel();
            btnAyuda = new Resources.Components.Buttons.ButtonPersonalizado();
            cpcbLogo = new Resources.Components.PictureBoxs.CircularPictureBox();
            txtClave = new Resources.Components.TextBoxs.TextBoxRounded();
            txtCorreo = new Resources.Components.TextBoxs.TextBoxRounded();
            btnAcceder = new Resources.Components.Buttons.BotonEsquinaRedonda();
            lblClave = new Label();
            lblCorreo = new Label();
            panelIzquierdo = new Panel();
            pcbImgIzquierda = new PictureBox();
            errorLogin = new ErrorProvider(components);
            panelContenedor.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cpcbLogo).BeginInit();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImgIzquierda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLogin).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.AutoScroll = true;
            panelContenedor.BackColor = Color.FromArgb(27, 154, 233);
            panelContenedor.Controls.Add(tableLayoutPanel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1182, 753);
            panelContenedor.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelDerecho, 1, 0);
            tableLayoutPanel1.Controls.Add(panelIzquierdo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1182, 753);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.FromArgb(27, 154, 233);
            panelDerecho.Controls.Add(btnAyuda);
            panelDerecho.Controls.Add(cpcbLogo);
            panelDerecho.Controls.Add(txtClave);
            panelDerecho.Controls.Add(txtCorreo);
            panelDerecho.Controls.Add(btnAcceder);
            panelDerecho.Controls.Add(lblClave);
            panelDerecho.Controls.Add(lblCorreo);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(594, 3);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(585, 747);
            panelDerecho.TabIndex = 0;
            // 
            // btnAyuda
            // 
            btnAyuda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAyuda.BackColor = Color.FromArgb(27, 154, 233);
            btnAyuda.BackgroundColor = Color.FromArgb(27, 154, 233);
            btnAyuda.BorderColor = Color.LightSkyBlue;
            btnAyuda.BorderRadius = 0;
            btnAyuda.BorderSize = 0;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.ForeColor = Color.White;
            btnAyuda.Image = Properties.Resources.information;
            btnAyuda.Location = new Point(519, 688);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(57, 50);
            btnAyuda.TabIndex = 11;
            btnAyuda.TextColor = Color.White;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // cpcbLogo
            // 
            cpcbLogo.Anchor = AnchorStyles.None;
            cpcbLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            cpcbLogo.BorderColor = Color.LightBlue;
            cpcbLogo.BorderColor2 = Color.SkyBlue;
            cpcbLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            cpcbLogo.BorderSize = 2;
            cpcbLogo.GradientAngle = 50F;
            cpcbLogo.Image = Properties.Resources.logo;
            cpcbLogo.Location = new Point(185, 110);
            cpcbLogo.Name = "cpcbLogo";
            cpcbLogo.Size = new Size(200, 200);
            cpcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            cpcbLogo.TabIndex = 10;
            cpcbLogo.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.None;
            txtClave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtClave.BackColor = SystemColors.Window;
            txtClave.BorderColor = Color.DarkBlue;
            txtClave.BorderFocusColor = Color.Blue;
            txtClave.BorderRadius = 20;
            txtClave.BorderSize = 2;
            txtClave.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.ForeColor = Color.FromArgb(64, 64, 64);
            txtClave.Location = new Point(109, 452);
            txtClave.Margin = new Padding(4);
            txtClave.Multiline = false;
            txtClave.Name = "txtClave";
            txtClave.Padding = new Padding(10, 7, 10, 7);
            txtClave.PasswordChar = true;
            txtClave.PlaceholderColor = Color.DarkGray;
            txtClave.PlaceholderText = "";
            txtClave.Size = new Size(352, 35);
            txtClave.TabIndex = 9;
            txtClave.Texts = "";
            txtClave.UnderlinedStyle = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCorreo.BackColor = SystemColors.Window;
            txtCorreo.BorderColor = Color.DarkBlue;
            txtCorreo.BorderFocusColor = Color.Blue;
            txtCorreo.BorderRadius = 20;
            txtCorreo.BorderSize = 2;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreo.Location = new Point(109, 372);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(10, 7, 10, 7);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = Color.DarkGray;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Size = new Size(352, 35);
            txtCorreo.TabIndex = 8;
            txtCorreo.Texts = "";
            txtCorreo.UnderlinedStyle = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Anchor = AnchorStyles.None;
            btnAcceder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAcceder.BackColor = Color.FromArgb(0, 0, 192);
            btnAcceder.BackgroundColor = Color.FromArgb(0, 0, 192);
            btnAcceder.BorderColor = Color.PaleVioletRed;
            btnAcceder.BorderRadius = 40;
            btnAcceder.BorderSize = 0;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(141, 516);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(300, 59);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.TextColor = Color.White;
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // lblClave
            // 
            lblClave.Anchor = AnchorStyles.None;
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(109, 422);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(65, 26);
            lblClave.TabIndex = 3;
            lblClave.Text = "Clave";
            lblClave.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.None;
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(109, 342);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(77, 26);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(0, 0, 192);
            panelIzquierdo.Controls.Add(pcbImgIzquierda);
            panelIzquierdo.Dock = DockStyle.Fill;
            panelIzquierdo.Location = new Point(3, 3);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(585, 747);
            panelIzquierdo.TabIndex = 1;
            // 
            // pcbImgIzquierda
            // 
            pcbImgIzquierda.BackColor = Color.White;
            pcbImgIzquierda.Dock = DockStyle.Fill;
            pcbImgIzquierda.Image = Properties.Resources.recursos4;
            pcbImgIzquierda.Location = new Point(0, 0);
            pcbImgIzquierda.Name = "pcbImgIzquierda";
            pcbImgIzquierda.Size = new Size(585, 747);
            pcbImgIzquierda.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbImgIzquierda.TabIndex = 0;
            pcbImgIzquierda.TabStop = false;
            // 
            // errorLogin
            // 
            errorLogin.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelContenedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Inicio de sesión";
            panelContenedor.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cpcbLogo).EndInit();
            panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImgIzquierda).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelDerecho;
        private Label lblCorreo;
        private Panel panelIzquierdo;
        private Label lblClave;
        private PictureBox pcbImgIzquierda;
        private Humania_RH_Force.Resources.Components.Buttons.BotonEsquinaRedonda btnAcceder;
        private Resources.Components.TextBoxs.TextBoxRounded txtCorreo;
        private Resources.Components.TextBoxs.TextBoxRounded txtClave;
        private Resources.Components.PictureBoxs.CircularPictureBox cpcbLogo;
        private Resources.Components.Buttons.ButtonPersonalizado btnAyuda;
        private ErrorProvider errorLogin;
    }
}