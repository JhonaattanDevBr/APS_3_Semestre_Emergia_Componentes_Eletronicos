namespace Calculadora.View.Interfaces
{
    partial class FmResultado
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
            LblMsgResultadoCientifico = new Label();
            LblResultadoCientifico = new Label();
            LblMsgResultadoNumerico = new Label();
            LblResultadoNumerico = new Label();
            LblMsgRelatorio = new Label();
            LblRelatorio = new Label();
            button1 = new Button();
            LblMensagem = new Label();
            LblMsgElemento = new Label();
            LblElementoCalculado = new Label();
            SuspendLayout();
            // 
            // LblMsgResultadoCientifico
            // 
            LblMsgResultadoCientifico.AutoSize = true;
            LblMsgResultadoCientifico.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblMsgResultadoCientifico.ForeColor = SystemColors.ControlLightLight;
            LblMsgResultadoCientifico.Location = new Point(23, 113);
            LblMsgResultadoCientifico.Name = "LblMsgResultadoCientifico";
            LblMsgResultadoCientifico.Size = new Size(203, 20);
            LblMsgResultadoCientifico.TabIndex = 0;
            LblMsgResultadoCientifico.Text = "Resultado em notação cietifica:";
            // 
            // LblResultadoCientifico
            // 
            LblResultadoCientifico.AutoSize = true;
            LblResultadoCientifico.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblResultadoCientifico.Location = new Point(23, 145);
            LblResultadoCientifico.Name = "LblResultadoCientifico";
            LblResultadoCientifico.Size = new Size(134, 20);
            LblResultadoCientifico.TabIndex = 1;
            LblResultadoCientifico.Text = "Resultado Cientifico";
            // 
            // LblMsgResultadoNumerico
            // 
            LblMsgResultadoNumerico.AutoSize = true;
            LblMsgResultadoNumerico.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblMsgResultadoNumerico.ForeColor = SystemColors.ControlLightLight;
            LblMsgResultadoNumerico.Location = new Point(23, 189);
            LblMsgResultadoNumerico.Name = "LblMsgResultadoNumerico";
            LblMsgResultadoNumerico.Size = new Size(217, 20);
            LblMsgResultadoNumerico.TabIndex = 2;
            LblMsgResultadoNumerico.Text = "Resultado em valores numéricos:";
            // 
            // LblResultadoNumerico
            // 
            LblResultadoNumerico.AutoSize = true;
            LblResultadoNumerico.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblResultadoNumerico.Location = new Point(23, 223);
            LblResultadoNumerico.Name = "LblResultadoNumerico";
            LblResultadoNumerico.Size = new Size(135, 20);
            LblResultadoNumerico.TabIndex = 3;
            LblResultadoNumerico.Text = "Resultado Numérico";
            // 
            // LblMsgRelatorio
            // 
            LblMsgRelatorio.AutoSize = true;
            LblMsgRelatorio.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblMsgRelatorio.ForeColor = SystemColors.ControlLightLight;
            LblMsgRelatorio.Location = new Point(23, 272);
            LblMsgRelatorio.Name = "LblMsgRelatorio";
            LblMsgRelatorio.Size = new Size(188, 20);
            LblMsgRelatorio.TabIndex = 4;
            LblMsgRelatorio.Text = "Um novo relatório foi criado!";
            // 
            // LblRelatorio
            // 
            LblRelatorio.AutoSize = true;
            LblRelatorio.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblRelatorio.Location = new Point(23, 306);
            LblRelatorio.Name = "LblRelatorio";
            LblRelatorio.Size = new Size(118, 20);
            LblRelatorio.TabIndex = 5;
            LblRelatorio.Text = "Nome do Arquivo";
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(380, 310);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 6;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LblMensagem
            // 
            LblMensagem.AutoSize = true;
            LblMensagem.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMensagem.ForeColor = SystemColors.ControlLightLight;
            LblMensagem.Location = new Point(112, 9);
            LblMensagem.Name = "LblMensagem";
            LblMensagem.Size = new Size(261, 23);
            LblMensagem.TabIndex = 7;
            LblMensagem.Text = "Resultado do Calculo da Emergia";
            // 
            // LblMsgElemento
            // 
            LblMsgElemento.AutoSize = true;
            LblMsgElemento.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblMsgElemento.ForeColor = SystemColors.ControlLightLight;
            LblMsgElemento.Location = new Point(23, 46);
            LblMsgElemento.Name = "LblMsgElemento";
            LblMsgElemento.Size = new Size(136, 20);
            LblMsgElemento.TabIndex = 8;
            LblMsgElemento.Text = "Elemento calculado:";
            // 
            // LblElementoCalculado
            // 
            LblElementoCalculado.AutoSize = true;
            LblElementoCalculado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LblElementoCalculado.Location = new Point(23, 76);
            LblElementoCalculado.Name = "LblElementoCalculado";
            LblElementoCalculado.Size = new Size(68, 20);
            LblElementoCalculado.TabIndex = 9;
            LblElementoCalculado.Text = "Elemento";
            // 
            // FmResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(484, 356);
            ControlBox = false;
            Controls.Add(LblElementoCalculado);
            Controls.Add(LblMsgElemento);
            Controls.Add(LblMensagem);
            Controls.Add(button1);
            Controls.Add(LblRelatorio);
            Controls.Add(LblMsgRelatorio);
            Controls.Add(LblResultadoNumerico);
            Controls.Add(LblMsgResultadoNumerico);
            Controls.Add(LblResultadoCientifico);
            Controls.Add(LblMsgResultadoCientifico);
            MaximumSize = new Size(500, 395);
            MinimumSize = new Size(500, 395);
            Name = "FmResultado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado do Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMsgResultadoCientifico;
        private Label LblResultadoCientifico;
        private Label LblMsgResultadoNumerico;
        private Label LblResultadoNumerico;
        private Label LblMsgRelatorio;
        private Label LblRelatorio;
        private Button button1;
        private Label LblMensagem;
        private Label LblMsgElemento;
        private Label LblElementoCalculado;
    }
}