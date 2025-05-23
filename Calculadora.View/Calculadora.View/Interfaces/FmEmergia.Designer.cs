namespace Calculadora.View.Interfaces
{
    partial class FmEmergia
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
            PbImagemEmergia = new PictureBox();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbImagemEmergia).BeginInit();
            SuspendLayout();
            // 
            // PbImagemEmergia
            // 
            PbImagemEmergia.Image = Properties.Resources.Explicacao_Emergia;
            PbImagemEmergia.Location = new Point(12, 12);
            PbImagemEmergia.Name = "PbImagemEmergia";
            PbImagemEmergia.Size = new Size(810, 490);
            PbImagemEmergia.TabIndex = 0;
            PbImagemEmergia.TabStop = false;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Khaki;
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFechar.Location = new Point(747, 523);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 30);
            BtnFechar.TabIndex = 1;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // FmEmergia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(834, 561);
            Controls.Add(BtnFechar);
            Controls.Add(PbImagemEmergia);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FmEmergia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entenda o que é emergia";
            ((System.ComponentModel.ISupportInitialize)PbImagemEmergia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PbImagemEmergia;
        private Button BtnFechar;
    }
}