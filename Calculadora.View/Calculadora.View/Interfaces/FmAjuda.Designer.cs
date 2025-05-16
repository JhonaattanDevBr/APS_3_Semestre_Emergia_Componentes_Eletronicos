namespace Calculadora.View.Interfaces
{
    partial class FmAjuda
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
            PbImagemAjuda = new PictureBox();
            BtnAnterior = new Button();
            BtnProximo = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PbImagemAjuda).BeginInit();
            SuspendLayout();
            // 
            // PbImagemAjuda
            // 
            PbImagemAjuda.Image = Properties.Resources.Ajuda_Ciclo;
            PbImagemAjuda.Location = new Point(12, 12);
            PbImagemAjuda.Name = "PbImagemAjuda";
            PbImagemAjuda.Size = new Size(710, 430);
            PbImagemAjuda.SizeMode = PictureBoxSizeMode.StretchImage;
            PbImagemAjuda.TabIndex = 0;
            PbImagemAjuda.TabStop = false;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnAnterior.Location = new Point(566, 448);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(75, 30);
            BtnAnterior.TabIndex = 1;
            BtnAnterior.Text = "Anterior";
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // BtnProximo
            // 
            BtnProximo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnProximo.Location = new Point(647, 448);
            BtnProximo.Name = "BtnProximo";
            BtnProximo.Size = new Size(75, 30);
            BtnProximo.TabIndex = 2;
            BtnProximo.Text = "Proximo";
            BtnProximo.UseVisualStyleBackColor = true;
            BtnProximo.Click += BtnProximo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 453);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 3;
            label1.Text = "Intruções de uso do sistema.";
            // 
            // FmAjuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(734, 487);
            Controls.Add(label1);
            Controls.Add(BtnProximo);
            Controls.Add(BtnAnterior);
            Controls.Add(PbImagemAjuda);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FmAjuda";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "AJUDA";
            Load += FmAjuda_Load;
            ((System.ComponentModel.ISupportInitialize)PbImagemAjuda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbImagemAjuda;
        private Button BtnAnterior;
        private Button BtnProximo;
        private Label label1;
    }
}