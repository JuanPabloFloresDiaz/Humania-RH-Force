namespace Humania_RH_Force.Views
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            panelContenedor = new Panel();
            cpbCarga = new CircularProgressBar_NET5.CircularProgressBar();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(27, 154, 233);
            panelContenedor.Controls.Add(cpbCarga);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1182, 753);
            panelContenedor.TabIndex = 0;
            // 
            // cpbCarga
            // 
            cpbCarga.Anchor = AnchorStyles.None;
            cpbCarga.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            cpbCarga.AnimationSpeed = 500;
            cpbCarga.BackColor = Color.Transparent;
            cpbCarga.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpbCarga.ForeColor = Color.FromArgb(64, 64, 64);
            cpbCarga.InnerColor = Color.FromArgb(224, 224, 224);
            cpbCarga.InnerMargin = 2;
            cpbCarga.InnerWidth = -1;
            cpbCarga.Location = new Point(288, 71);
            cpbCarga.MarqueeAnimationSpeed = 2000;
            cpbCarga.Name = "cpbCarga";
            cpbCarga.OuterColor = Color.DarkGray;
            cpbCarga.OuterMargin = -25;
            cpbCarga.OuterWidth = 26;
            cpbCarga.ProgressColor = Color.FromArgb(0, 0, 192);
            cpbCarga.ProgressWidth = 25;
            cpbCarga.SecondaryFont = new Font("Segoe UI", 36F);
            cpbCarga.Size = new Size(600, 600);
            cpbCarga.StartAngle = 270;
            cpbCarga.SubscriptColor = Color.White;
            cpbCarga.SubscriptMargin = new Padding(10, -35, 0, 0);
            cpbCarga.SubscriptText = "";
            cpbCarga.SuperscriptColor = Color.White;
            cpbCarga.SuperscriptMargin = new Padding(10, 35, 0, 0);
            cpbCarga.SuperscriptText = "";
            cpbCarga.TabIndex = 0;
            cpbCarga.Text = "Iniciando ...";
            cpbCarga.TextMargin = new Padding(8, 8, 0, 0);
            cpbCarga.Value = 68;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelContenedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Splash";
            Text = "Pantalla de carga";
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private CircularProgressBar_NET5.CircularProgressBar cpbCarga;
    }
}