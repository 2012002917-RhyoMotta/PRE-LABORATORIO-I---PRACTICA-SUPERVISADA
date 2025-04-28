namespace Proyecto_PreLab
{
    partial class CreditosForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 80);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 256);
            label1.TabIndex = 0;
            label1.Text = "Desarrollador: Rhyo Donato Motta Pérez\r\nGrado: V Bachillerato\r\nSección: \"B\"\r\nClave: 17\r\n\r\nColegio Salesiano Don Bosco 2025\r\n\r\n¡Gracias por usar el programa!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 9);
            label2.Name = "label2";
            label2.Size = new Size(476, 47);
            label2.TabIndex = 1;
            label2.Text = "Proyecto PreLaboratorio #1";
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Image = Properties.Resources.Fotografia;
            label3.Location = new Point(11, 21);
            label3.Name = "label3";
            label3.Size = new Size(218, 315);
            label3.TabIndex = 2;
            // 
            // CreditosForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 351);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "CreditosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creditos del Proyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}