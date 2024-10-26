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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelDerecho = new Panel();
            btnAcceder = new Resources.Components.Buttons.BotonEsquinaRedonda();
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            lblClave = new Label();
            lblCorreo = new Label();
            pcbLogo = new PictureBox();
            panelIzquierdo = new Panel();
            pcbImgIzquierda = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImgIzquierda).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(24, 139, 255);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 753);
            panel1.TabIndex = 0;
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
            panelDerecho.Controls.Add(btnAcceder);
            panelDerecho.Controls.Add(txtClave);
            panelDerecho.Controls.Add(txtCorreo);
            panelDerecho.Controls.Add(lblClave);
            panelDerecho.Controls.Add(lblCorreo);
            panelDerecho.Controls.Add(pcbLogo);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(594, 3);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(585, 747);
            panelDerecho.TabIndex = 0;
            // 
            // btnAcceder
            // 
            btnAcceder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            btnAcceder.Location = new Point(164, 516);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(265, 50);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "Acceder";
            btnAcceder.TextColor = Color.White;
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.BackColor = Color.White;
            txtClave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.ForeColor = Color.Black;
            txtClave.Location = new Point(164, 451);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(265, 30);
            txtClave.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.BackColor = Color.White;
            txtCorreo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(164, 371);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(265, 30);
            txtCorreo.TabIndex = 4;
            // 
            // lblClave
            // 
            lblClave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(164, 422);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(65, 26);
            lblClave.TabIndex = 3;
            lblClave.Text = "Clave";
            lblClave.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(164, 342);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(77, 26);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcbLogo.Image = Properties.Resources.logo;
            pcbLogo.Location = new Point(202, 110);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(200, 200);
            pcbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
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
            pcbImgIzquierda.Dock = DockStyle.Fill;
            pcbImgIzquierda.Image = Properties.Resources.recursos;
            pcbImgIzquierda.Location = new Point(0, 0);
            pcbImgIzquierda.Name = "pcbImgIzquierda";
            pcbImgIzquierda.Size = new Size(585, 747);
            pcbImgIzquierda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImgIzquierda.TabIndex = 0;
            pcbImgIzquierda.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImgIzquierda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelDerecho;
        private Label lblCorreo;
        private PictureBox pcbLogo;
        private Panel panelIzquierdo;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private Label lblClave;
        private PictureBox pcbImgIzquierda;
        private Humania_RH_Force.Resources.Components.Buttons.BotonEsquinaRedonda btnAcceder;
    }
}