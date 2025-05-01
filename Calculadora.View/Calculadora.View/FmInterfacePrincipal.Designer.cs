namespace Calculadora.View
{
    partial class FmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            aJUDAToolStripMenuItem = new ToolStripMenuItem();
            DgvCaminhos = new DataGridView();
            LblQuantidadeCaminhos = new Label();
            TxtQuantidadeCaminhos = new TextBox();
            label1 = new Label();
            LblCaminho1 = new Label();
            LblCaminho2 = new Label();
            LblCaminho3 = new Label();
            LblCaminho4 = new Label();
            LblElementoCam1 = new Label();
            CmbCam1 = new ComboBox();
            LblValorCam1 = new Label();
            TxtValorCam1 = new TextBox();
            BtnRemoverCam1 = new Button();
            BtnAdicionarCam1 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label10 = new Label();
            textBox5 = new TextBox();
            button9 = new Button();
            button10 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCaminhos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aJUDAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aJUDAToolStripMenuItem
            // 
            aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            aJUDAToolStripMenuItem.Size = new Size(56, 20);
            aJUDAToolStripMenuItem.Text = "AJUDA";
            // 
            // DgvCaminhos
            // 
            DgvCaminhos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCaminhos.Location = new Point(12, 47);
            DgvCaminhos.Name = "DgvCaminhos";
            DgvCaminhos.Size = new Size(388, 160);
            DgvCaminhos.TabIndex = 1;
            // 
            // LblQuantidadeCaminhos
            // 
            LblQuantidadeCaminhos.AutoSize = true;
            LblQuantidadeCaminhos.Location = new Point(406, 85);
            LblQuantidadeCaminhos.Name = "LblQuantidadeCaminhos";
            LblQuantidadeCaminhos.Size = new Size(172, 20);
            LblQuantidadeCaminhos.TabIndex = 2;
            LblQuantidadeCaminhos.Text = "Quantidade de caminhos: ";
            // 
            // TxtQuantidadeCaminhos
            // 
            TxtQuantidadeCaminhos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantidadeCaminhos.Location = new Point(572, 81);
            TxtQuantidadeCaminhos.MaxLength = 1;
            TxtQuantidadeCaminhos.Name = "TxtQuantidadeCaminhos";
            TxtQuantidadeCaminhos.Size = new Size(45, 26);
            TxtQuantidadeCaminhos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(623, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 4;
            label1.Text = "(Max 4)*";
            // 
            // LblCaminho1
            // 
            LblCaminho1.AutoSize = true;
            LblCaminho1.Location = new Point(406, 118);
            LblCaminho1.Name = "LblCaminho1";
            LblCaminho1.Size = new Size(80, 20);
            LblCaminho1.TabIndex = 5;
            LblCaminho1.Text = "Caminho 1:";
            // 
            // LblCaminho2
            // 
            LblCaminho2.AutoSize = true;
            LblCaminho2.Location = new Point(406, 222);
            LblCaminho2.Name = "LblCaminho2";
            LblCaminho2.Size = new Size(80, 20);
            LblCaminho2.TabIndex = 6;
            LblCaminho2.Text = "Caminho 2:";
            // 
            // LblCaminho3
            // 
            LblCaminho3.AutoSize = true;
            LblCaminho3.Location = new Point(406, 330);
            LblCaminho3.Name = "LblCaminho3";
            LblCaminho3.Size = new Size(80, 20);
            LblCaminho3.TabIndex = 7;
            LblCaminho3.Text = "Caminho 3:";
            // 
            // LblCaminho4
            // 
            LblCaminho4.AutoSize = true;
            LblCaminho4.Location = new Point(406, 440);
            LblCaminho4.Name = "LblCaminho4";
            LblCaminho4.Size = new Size(80, 20);
            LblCaminho4.TabIndex = 8;
            LblCaminho4.Text = "Caminho 4:";
            // 
            // LblElementoCam1
            // 
            LblElementoCam1.AutoSize = true;
            LblElementoCam1.Location = new Point(434, 138);
            LblElementoCam1.Name = "LblElementoCam1";
            LblElementoCam1.Size = new Size(72, 20);
            LblElementoCam1.TabIndex = 10;
            LblElementoCam1.Text = "Elemento:";
            // 
            // CmbCam1
            // 
            CmbCam1.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCam1.FormattingEnabled = true;
            CmbCam1.Location = new Point(512, 135);
            CmbCam1.Name = "CmbCam1";
            CmbCam1.Size = new Size(200, 28);
            CmbCam1.TabIndex = 11;
            // 
            // LblValorCam1
            // 
            LblValorCam1.AutoSize = true;
            LblValorCam1.Location = new Point(718, 138);
            LblValorCam1.Name = "LblValorCam1";
            LblValorCam1.Size = new Size(74, 20);
            LblValorCam1.TabIndex = 12;
            LblValorCam1.Text = "Valor Sej: ";
            // 
            // TxtValorCam1
            // 
            TxtValorCam1.Enabled = false;
            TxtValorCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtValorCam1.Location = new Point(798, 135);
            TxtValorCam1.MaxLength = 5;
            TxtValorCam1.Name = "TxtValorCam1";
            TxtValorCam1.Size = new Size(70, 26);
            TxtValorCam1.TabIndex = 13;
            // 
            // BtnRemoverCam1
            // 
            BtnRemoverCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnRemoverCam1.Location = new Point(512, 175);
            BtnRemoverCam1.Name = "BtnRemoverCam1";
            BtnRemoverCam1.Size = new Size(180, 30);
            BtnRemoverCam1.TabIndex = 14;
            BtnRemoverCam1.Text = "Remover Último Elemento";
            BtnRemoverCam1.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarCam1
            // 
            BtnAdicionarCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnAdicionarCam1.Location = new Point(718, 175);
            BtnAdicionarCam1.Name = "BtnAdicionarCam1";
            BtnAdicionarCam1.Size = new Size(150, 30);
            BtnAdicionarCam1.TabIndex = 15;
            BtnAdicionarCam1.Text = "Adicionar Elemento";
            BtnAdicionarCam1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 242);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 16;
            label2.Text = "Elemento: ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(512, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 242);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 18;
            label3.Text = "Valor Sej: ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Arial Narrow", 12F);
            textBox1.Location = new Point(798, 239);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 26);
            textBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(512, 283);
            button1.Name = "button1";
            button1.Size = new Size(180, 30);
            button1.TabIndex = 20;
            button1.Text = "Remover Último Elemento";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(718, 283);
            button2.Name = "button2";
            button2.Size = new Size(150, 30);
            button2.TabIndex = 21;
            button2.Text = "Adicionar Elemento";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 350);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 22;
            label4.Text = "Elemento: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(718, 350);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 23;
            label5.Text = "Valor Sej: ";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(512, 347);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 28);
            comboBox2.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Arial Narrow", 12F);
            textBox2.Location = new Point(798, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(70, 26);
            textBox2.TabIndex = 25;
            // 
            // button3
            // 
            button3.Location = new Point(512, 391);
            button3.Name = "button3";
            button3.Size = new Size(180, 30);
            button3.TabIndex = 26;
            button3.Text = "Remover Último Elemento";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(718, 391);
            button4.Name = "button4";
            button4.Size = new Size(150, 30);
            button4.TabIndex = 27;
            button4.Text = "Adicionar Elemento";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 460);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 28;
            label6.Text = "Elemento: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(718, 460);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 29;
            label7.Text = "Valor Sej: ";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(512, 457);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 28);
            comboBox3.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Arial Narrow", 12F);
            textBox3.Location = new Point(798, 457);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(70, 26);
            textBox3.TabIndex = 33;
            // 
            // button5
            // 
            button5.Location = new Point(512, 502);
            button5.Name = "button5";
            button5.Size = new Size(180, 30);
            button5.TabIndex = 36;
            button5.Text = "Remover Último Elemento";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(718, 502);
            button6.Name = "button6";
            button6.Size = new Size(150, 30);
            button6.TabIndex = 37;
            button6.Text = "Adicionar Elemento";
            button6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(406, 47);
            label10.Name = "label10";
            label10.Size = new Size(165, 20);
            label10.TabIndex = 40;
            label10.Text = "O que pretende calcular: ";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(572, 41);
            textBox5.MaxLength = 30;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 26);
            textBox5.TabIndex = 41;
            // 
            // button9
            // 
            button9.Location = new Point(592, 548);
            button9.Name = "button9";
            button9.Size = new Size(100, 30);
            button9.TabIndex = 42;
            button9.Text = "Limpar Tudo";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(718, 548);
            button10.Name = "button10";
            button10.Size = new Size(80, 30);
            button10.TabIndex = 43;
            button10.Text = "Calcular";
            button10.UseVisualStyleBackColor = true;
            // 
            // FmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(884, 591);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(BtnAdicionarCam1);
            Controls.Add(BtnRemoverCam1);
            Controls.Add(TxtValorCam1);
            Controls.Add(LblValorCam1);
            Controls.Add(CmbCam1);
            Controls.Add(LblElementoCam1);
            Controls.Add(LblCaminho4);
            Controls.Add(LblCaminho3);
            Controls.Add(LblCaminho2);
            Controls.Add(LblCaminho1);
            Controls.Add(label1);
            Controls.Add(TxtQuantidadeCaminhos);
            Controls.Add(LblQuantidadeCaminhos);
            Controls.Add(DgvCaminhos);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CECE - Calculadora Emergética de Componentes Eletronicos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCaminhos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aJUDAToolStripMenuItem;
        private DataGridView DgvCaminhos;
        private Label LblQuantidadeCaminhos;
        private TextBox TxtQuantidadeCaminhos;
        private Label label1;
        private Label LblCaminho1;
        private Label LblCaminho2;
        private Label LblCaminho3;
        private Label LblCaminho4;
        private Label LblElementoCam1;
        private ComboBox CmbCam1;
        private Label LblValorCam1;
        private TextBox TxtValorCam1;
        private Button BtnRemoverCam1;
        private Button BtnAdicionarCam1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Label label6;
        private Label label7;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Label label10;
        private TextBox textBox5;
        private Button button9;
        private Button button10;
    }
}
