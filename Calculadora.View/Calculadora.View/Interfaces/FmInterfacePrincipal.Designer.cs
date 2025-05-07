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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPrincipal));
            BarraMenu = new MenuStrip();
            aJUDAToolStripMenuItem = new ToolStripMenuItem();
            DgvCaminhos = new DataGridView();
            LblQuantidadeCaminhos = new Label();
            LblCaminho1 = new Label();
            LblCaminho2 = new Label();
            LblCaminho3 = new Label();
            LblCaminho4 = new Label();
            LblElementoCam1 = new Label();
            CmbElementoCam1 = new ComboBox();
            LblEsforcoCam1 = new Label();
            TxtEsforcoCam1 = new TextBox();
            BtnRemoverCam1 = new Button();
            BtnAdicionarCam1 = new Button();
            LblElementoCam2 = new Label();
            CmbElementoCam2 = new ComboBox();
            LblEsforcoCam2 = new Label();
            TxtEsforcoCam2 = new TextBox();
            BtnRemoverCam2 = new Button();
            BtnAdicionarCam2 = new Button();
            LblElementoCam3 = new Label();
            LblEsforcoCam3 = new Label();
            CmbElementoCam3 = new ComboBox();
            TxtEsforcoCam3 = new TextBox();
            BtnRemoverCam3 = new Button();
            BtnAdicionarCam3 = new Button();
            LblElementoCam4 = new Label();
            LblEsforcoCam4 = new Label();
            CmbElementoCam4 = new ComboBox();
            TxtEsforcoCam4 = new TextBox();
            BtnRemoverCam4 = new Button();
            BtnAdicionarCam4 = new Button();
            LblComponente = new Label();
            TxtComponente = new TextBox();
            BtnLimparTudo = new Button();
            BtnCalculcar = new Button();
            LblCategoriaCam1 = new Label();
            CmbCategoriaCam1 = new ComboBox();
            LblCategoriaCam2 = new Label();
            LblCategoriaCam3 = new Label();
            LblCategoriaCam4 = new Label();
            CmbCategoriaCam2 = new ComboBox();
            CmbCategoriaCam3 = new ComboBox();
            CmbCategoriaCam4 = new ComboBox();
            BtnAjuda = new Button();
            LblMsgAjuda = new Label();
            RbtUm = new RadioButton();
            RbtDois = new RadioButton();
            RbtTres = new RadioButton();
            RbtQuatro = new RadioButton();
            BarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCaminhos).BeginInit();
            SuspendLayout();
            // 
            // BarraMenu
            // 
            BarraMenu.Items.AddRange(new ToolStripItem[] { aJUDAToolStripMenuItem });
            BarraMenu.Location = new Point(0, 0);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(1114, 24);
            BarraMenu.TabIndex = 0;
            BarraMenu.Text = "menuStrip1";
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
            DgvCaminhos.Size = new Size(333, 160);
            DgvCaminhos.TabIndex = 1;
            // 
            // LblQuantidadeCaminhos
            // 
            LblQuantidadeCaminhos.AutoSize = true;
            LblQuantidadeCaminhos.Location = new Point(351, 85);
            LblQuantidadeCaminhos.Name = "LblQuantidadeCaminhos";
            LblQuantidadeCaminhos.Size = new Size(172, 20);
            LblQuantidadeCaminhos.TabIndex = 2;
            LblQuantidadeCaminhos.Text = "Quantidade de caminhos: ";
            // 
            // LblCaminho1
            // 
            LblCaminho1.AutoSize = true;
            LblCaminho1.Location = new Point(351, 118);
            LblCaminho1.Name = "LblCaminho1";
            LblCaminho1.Size = new Size(80, 20);
            LblCaminho1.TabIndex = 5;
            LblCaminho1.Text = "Caminho 1:";
            // 
            // LblCaminho2
            // 
            LblCaminho2.AutoSize = true;
            LblCaminho2.Location = new Point(351, 221);
            LblCaminho2.Name = "LblCaminho2";
            LblCaminho2.Size = new Size(80, 20);
            LblCaminho2.TabIndex = 6;
            LblCaminho2.Text = "Caminho 2:";
            LblCaminho2.Visible = false;
            // 
            // LblCaminho3
            // 
            LblCaminho3.AutoSize = true;
            LblCaminho3.Location = new Point(351, 329);
            LblCaminho3.Name = "LblCaminho3";
            LblCaminho3.Size = new Size(80, 20);
            LblCaminho3.TabIndex = 7;
            LblCaminho3.Text = "Caminho 3:";
            LblCaminho3.Visible = false;
            // 
            // LblCaminho4
            // 
            LblCaminho4.AutoSize = true;
            LblCaminho4.Location = new Point(351, 434);
            LblCaminho4.Name = "LblCaminho4";
            LblCaminho4.Size = new Size(80, 20);
            LblCaminho4.TabIndex = 8;
            LblCaminho4.Text = "Caminho 4:";
            LblCaminho4.Visible = false;
            // 
            // LblElementoCam1
            // 
            LblElementoCam1.AutoSize = true;
            LblElementoCam1.Location = new Point(666, 138);
            LblElementoCam1.Name = "LblElementoCam1";
            LblElementoCam1.Size = new Size(72, 20);
            LblElementoCam1.TabIndex = 10;
            LblElementoCam1.Text = "Elemento:";
            // 
            // CmbElementoCam1
            // 
            CmbElementoCam1.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbElementoCam1.FormattingEnabled = true;
            CmbElementoCam1.Location = new Point(744, 135);
            CmbElementoCam1.Name = "CmbElementoCam1";
            CmbElementoCam1.Size = new Size(200, 28);
            CmbElementoCam1.TabIndex = 11;
            // 
            // LblEsforcoCam1
            // 
            LblEsforcoCam1.AutoSize = true;
            LblEsforcoCam1.Location = new Point(950, 138);
            LblEsforcoCam1.Name = "LblEsforcoCam1";
            LblEsforcoCam1.Size = new Size(65, 20);
            LblEsforcoCam1.TabIndex = 12;
            LblEsforcoCam1.Text = "Esforço: ";
            // 
            // TxtEsforcoCam1
            // 
            TxtEsforcoCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEsforcoCam1.Location = new Point(1021, 135);
            TxtEsforcoCam1.MaxLength = 3;
            TxtEsforcoCam1.Name = "TxtEsforcoCam1";
            TxtEsforcoCam1.Size = new Size(70, 26);
            TxtEsforcoCam1.TabIndex = 13;
            TxtEsforcoCam1.KeyPress += TxtEsforcoCam1_KeyPress;
            // 
            // BtnRemoverCam1
            // 
            BtnRemoverCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnRemoverCam1.Location = new Point(382, 169);
            BtnRemoverCam1.Name = "BtnRemoverCam1";
            BtnRemoverCam1.Size = new Size(180, 30);
            BtnRemoverCam1.TabIndex = 14;
            BtnRemoverCam1.Text = "Remover Último Elemento";
            BtnRemoverCam1.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarCam1
            // 
            BtnAdicionarCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnAdicionarCam1.Location = new Point(588, 169);
            BtnAdicionarCam1.Name = "BtnAdicionarCam1";
            BtnAdicionarCam1.Size = new Size(150, 30);
            BtnAdicionarCam1.TabIndex = 15;
            BtnAdicionarCam1.Text = "Adicionar Elemento";
            BtnAdicionarCam1.UseVisualStyleBackColor = true;
            // 
            // LblElementoCam2
            // 
            LblElementoCam2.AutoSize = true;
            LblElementoCam2.Location = new Point(666, 244);
            LblElementoCam2.Name = "LblElementoCam2";
            LblElementoCam2.Size = new Size(76, 20);
            LblElementoCam2.TabIndex = 16;
            LblElementoCam2.Text = "Elemento: ";
            LblElementoCam2.Visible = false;
            // 
            // CmbElementoCam2
            // 
            CmbElementoCam2.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbElementoCam2.FormattingEnabled = true;
            CmbElementoCam2.Location = new Point(744, 241);
            CmbElementoCam2.Name = "CmbElementoCam2";
            CmbElementoCam2.Size = new Size(200, 28);
            CmbElementoCam2.TabIndex = 17;
            CmbElementoCam2.Visible = false;
            // 
            // LblEsforcoCam2
            // 
            LblEsforcoCam2.AutoSize = true;
            LblEsforcoCam2.Location = new Point(950, 244);
            LblEsforcoCam2.Name = "LblEsforcoCam2";
            LblEsforcoCam2.Size = new Size(65, 20);
            LblEsforcoCam2.TabIndex = 18;
            LblEsforcoCam2.Text = "Esforço: ";
            LblEsforcoCam2.Visible = false;
            // 
            // TxtEsforcoCam2
            // 
            TxtEsforcoCam2.Font = new Font("Arial Narrow", 12F);
            TxtEsforcoCam2.Location = new Point(1021, 241);
            TxtEsforcoCam2.MaxLength = 3;
            TxtEsforcoCam2.Name = "TxtEsforcoCam2";
            TxtEsforcoCam2.Size = new Size(70, 26);
            TxtEsforcoCam2.TabIndex = 19;
            TxtEsforcoCam2.Visible = false;
            TxtEsforcoCam2.KeyPress += TxtEsforcoCam2_KeyPress;
            // 
            // BtnRemoverCam2
            // 
            BtnRemoverCam2.Location = new Point(382, 273);
            BtnRemoverCam2.Name = "BtnRemoverCam2";
            BtnRemoverCam2.Size = new Size(180, 30);
            BtnRemoverCam2.TabIndex = 20;
            BtnRemoverCam2.Text = "Remover Último Elemento";
            BtnRemoverCam2.UseVisualStyleBackColor = true;
            BtnRemoverCam2.Visible = false;
            // 
            // BtnAdicionarCam2
            // 
            BtnAdicionarCam2.Location = new Point(588, 273);
            BtnAdicionarCam2.Name = "BtnAdicionarCam2";
            BtnAdicionarCam2.Size = new Size(150, 30);
            BtnAdicionarCam2.TabIndex = 21;
            BtnAdicionarCam2.Text = "Adicionar Elemento";
            BtnAdicionarCam2.UseVisualStyleBackColor = true;
            BtnAdicionarCam2.Visible = false;
            // 
            // LblElementoCam3
            // 
            LblElementoCam3.AutoSize = true;
            LblElementoCam3.Location = new Point(666, 349);
            LblElementoCam3.Name = "LblElementoCam3";
            LblElementoCam3.Size = new Size(76, 20);
            LblElementoCam3.TabIndex = 22;
            LblElementoCam3.Text = "Elemento: ";
            LblElementoCam3.Visible = false;
            // 
            // LblEsforcoCam3
            // 
            LblEsforcoCam3.AutoSize = true;
            LblEsforcoCam3.Location = new Point(950, 349);
            LblEsforcoCam3.Name = "LblEsforcoCam3";
            LblEsforcoCam3.Size = new Size(65, 20);
            LblEsforcoCam3.TabIndex = 23;
            LblEsforcoCam3.Text = "Esforço: ";
            LblEsforcoCam3.Visible = false;
            // 
            // CmbElementoCam3
            // 
            CmbElementoCam3.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbElementoCam3.FormattingEnabled = true;
            CmbElementoCam3.Location = new Point(744, 346);
            CmbElementoCam3.Name = "CmbElementoCam3";
            CmbElementoCam3.Size = new Size(200, 28);
            CmbElementoCam3.TabIndex = 24;
            CmbElementoCam3.Visible = false;
            // 
            // TxtEsforcoCam3
            // 
            TxtEsforcoCam3.Font = new Font("Arial Narrow", 12F);
            TxtEsforcoCam3.Location = new Point(1021, 349);
            TxtEsforcoCam3.MaxLength = 3;
            TxtEsforcoCam3.Name = "TxtEsforcoCam3";
            TxtEsforcoCam3.Size = new Size(70, 26);
            TxtEsforcoCam3.TabIndex = 25;
            TxtEsforcoCam3.Visible = false;
            TxtEsforcoCam3.KeyPress += TxtEsforcoCam3_KeyPress;
            // 
            // BtnRemoverCam3
            // 
            BtnRemoverCam3.Location = new Point(382, 378);
            BtnRemoverCam3.Name = "BtnRemoverCam3";
            BtnRemoverCam3.Size = new Size(180, 30);
            BtnRemoverCam3.TabIndex = 26;
            BtnRemoverCam3.Text = "Remover Último Elemento";
            BtnRemoverCam3.UseVisualStyleBackColor = true;
            BtnRemoverCam3.Visible = false;
            // 
            // BtnAdicionarCam3
            // 
            BtnAdicionarCam3.Location = new Point(588, 378);
            BtnAdicionarCam3.Name = "BtnAdicionarCam3";
            BtnAdicionarCam3.Size = new Size(150, 30);
            BtnAdicionarCam3.TabIndex = 27;
            BtnAdicionarCam3.Text = "Adicionar Elemento";
            BtnAdicionarCam3.UseVisualStyleBackColor = true;
            BtnAdicionarCam3.Visible = false;
            // 
            // LblElementoCam4
            // 
            LblElementoCam4.AutoSize = true;
            LblElementoCam4.Location = new Point(666, 457);
            LblElementoCam4.Name = "LblElementoCam4";
            LblElementoCam4.Size = new Size(76, 20);
            LblElementoCam4.TabIndex = 28;
            LblElementoCam4.Text = "Elemento: ";
            LblElementoCam4.Visible = false;
            // 
            // LblEsforcoCam4
            // 
            LblEsforcoCam4.AutoSize = true;
            LblEsforcoCam4.Location = new Point(950, 457);
            LblEsforcoCam4.Name = "LblEsforcoCam4";
            LblEsforcoCam4.Size = new Size(65, 20);
            LblEsforcoCam4.TabIndex = 29;
            LblEsforcoCam4.Text = "Esforço: ";
            LblEsforcoCam4.Visible = false;
            // 
            // CmbElementoCam4
            // 
            CmbElementoCam4.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbElementoCam4.FormattingEnabled = true;
            CmbElementoCam4.Location = new Point(744, 454);
            CmbElementoCam4.Name = "CmbElementoCam4";
            CmbElementoCam4.Size = new Size(200, 28);
            CmbElementoCam4.TabIndex = 32;
            CmbElementoCam4.Visible = false;
            // 
            // TxtEsforcoCam4
            // 
            TxtEsforcoCam4.Font = new Font("Arial Narrow", 12F);
            TxtEsforcoCam4.Location = new Point(1021, 454);
            TxtEsforcoCam4.MaxLength = 3;
            TxtEsforcoCam4.Name = "TxtEsforcoCam4";
            TxtEsforcoCam4.Size = new Size(70, 26);
            TxtEsforcoCam4.TabIndex = 33;
            TxtEsforcoCam4.Visible = false;
            TxtEsforcoCam4.KeyPress += TxtEsforcoCam4_KeyPress;
            // 
            // BtnRemoverCam4
            // 
            BtnRemoverCam4.Location = new Point(382, 487);
            BtnRemoverCam4.Name = "BtnRemoverCam4";
            BtnRemoverCam4.Size = new Size(180, 30);
            BtnRemoverCam4.TabIndex = 36;
            BtnRemoverCam4.Text = "Remover Último Elemento";
            BtnRemoverCam4.UseVisualStyleBackColor = true;
            BtnRemoverCam4.Visible = false;
            // 
            // BtnAdicionarCam4
            // 
            BtnAdicionarCam4.Location = new Point(588, 487);
            BtnAdicionarCam4.Name = "BtnAdicionarCam4";
            BtnAdicionarCam4.Size = new Size(150, 30);
            BtnAdicionarCam4.TabIndex = 37;
            BtnAdicionarCam4.Text = "Adicionar Elemento";
            BtnAdicionarCam4.UseVisualStyleBackColor = true;
            BtnAdicionarCam4.Visible = false;
            // 
            // LblComponente
            // 
            LblComponente.AutoSize = true;
            LblComponente.Location = new Point(351, 47);
            LblComponente.Name = "LblComponente";
            LblComponente.Size = new Size(194, 20);
            LblComponente.TabIndex = 40;
            LblComponente.Text = "Componente a ser calculado: ";
            // 
            // TxtComponente
            // 
            TxtComponente.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtComponente.Location = new Point(551, 41);
            TxtComponente.MaxLength = 30;
            TxtComponente.Name = "TxtComponente";
            TxtComponente.Size = new Size(220, 26);
            TxtComponente.TabIndex = 41;
            TxtComponente.KeyPress += TxtComponente_KeyPress;
            // 
            // BtnLimparTudo
            // 
            BtnLimparTudo.Location = new Point(462, 549);
            BtnLimparTudo.Name = "BtnLimparTudo";
            BtnLimparTudo.Size = new Size(100, 30);
            BtnLimparTudo.TabIndex = 42;
            BtnLimparTudo.Text = "Limpar Tudo";
            BtnLimparTudo.UseVisualStyleBackColor = true;
            // 
            // BtnCalculcar
            // 
            BtnCalculcar.Location = new Point(588, 549);
            BtnCalculcar.Name = "BtnCalculcar";
            BtnCalculcar.Size = new Size(80, 30);
            BtnCalculcar.TabIndex = 43;
            BtnCalculcar.Text = "Calcular";
            BtnCalculcar.UseVisualStyleBackColor = true;
            // 
            // LblCategoriaCam1
            // 
            LblCategoriaCam1.AutoSize = true;
            LblCategoriaCam1.Location = new Point(382, 138);
            LblCategoriaCam1.Name = "LblCategoriaCam1";
            LblCategoriaCam1.Size = new Size(76, 20);
            LblCategoriaCam1.TabIndex = 44;
            LblCategoriaCam1.Text = "Categoria: ";
            // 
            // CmbCategoriaCam1
            // 
            CmbCategoriaCam1.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaCam1.FormattingEnabled = true;
            CmbCategoriaCam1.Items.AddRange(new object[] { "Componentes", "Materias Primas", "Processos", "Produtos" });
            CmbCategoriaCam1.Location = new Point(460, 135);
            CmbCategoriaCam1.Name = "CmbCategoriaCam1";
            CmbCategoriaCam1.Size = new Size(200, 28);
            CmbCategoriaCam1.TabIndex = 45;
            // 
            // LblCategoriaCam2
            // 
            LblCategoriaCam2.AutoSize = true;
            LblCategoriaCam2.Location = new Point(382, 244);
            LblCategoriaCam2.Name = "LblCategoriaCam2";
            LblCategoriaCam2.Size = new Size(76, 20);
            LblCategoriaCam2.TabIndex = 46;
            LblCategoriaCam2.Text = "Categoria: ";
            LblCategoriaCam2.Visible = false;
            // 
            // LblCategoriaCam3
            // 
            LblCategoriaCam3.AutoSize = true;
            LblCategoriaCam3.Location = new Point(382, 349);
            LblCategoriaCam3.Name = "LblCategoriaCam3";
            LblCategoriaCam3.Size = new Size(76, 20);
            LblCategoriaCam3.TabIndex = 47;
            LblCategoriaCam3.Text = "Categoria: ";
            LblCategoriaCam3.Visible = false;
            // 
            // LblCategoriaCam4
            // 
            LblCategoriaCam4.AutoSize = true;
            LblCategoriaCam4.Location = new Point(382, 457);
            LblCategoriaCam4.Name = "LblCategoriaCam4";
            LblCategoriaCam4.Size = new Size(76, 20);
            LblCategoriaCam4.TabIndex = 48;
            LblCategoriaCam4.Text = "Categoria: ";
            LblCategoriaCam4.Visible = false;
            // 
            // CmbCategoriaCam2
            // 
            CmbCategoriaCam2.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaCam2.FormattingEnabled = true;
            CmbCategoriaCam2.Location = new Point(460, 239);
            CmbCategoriaCam2.Name = "CmbCategoriaCam2";
            CmbCategoriaCam2.Size = new Size(200, 28);
            CmbCategoriaCam2.TabIndex = 49;
            CmbCategoriaCam2.Visible = false;
            // 
            // CmbCategoriaCam3
            // 
            CmbCategoriaCam3.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaCam3.FormattingEnabled = true;
            CmbCategoriaCam3.Location = new Point(460, 346);
            CmbCategoriaCam3.Name = "CmbCategoriaCam3";
            CmbCategoriaCam3.Size = new Size(200, 28);
            CmbCategoriaCam3.TabIndex = 50;
            CmbCategoriaCam3.Visible = false;
            // 
            // CmbCategoriaCam4
            // 
            CmbCategoriaCam4.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaCam4.FormattingEnabled = true;
            CmbCategoriaCam4.Location = new Point(460, 454);
            CmbCategoriaCam4.Name = "CmbCategoriaCam4";
            CmbCategoriaCam4.Size = new Size(200, 28);
            CmbCategoriaCam4.TabIndex = 51;
            CmbCategoriaCam4.Visible = false;
            // 
            // BtnAjuda
            // 
            BtnAjuda.BackgroundImage = (Image)resources.GetObject("BtnAjuda.BackgroundImage");
            BtnAjuda.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAjuda.FlatAppearance.BorderSize = 0;
            BtnAjuda.FlatStyle = FlatStyle.Flat;
            BtnAjuda.Location = new Point(1027, 38);
            BtnAjuda.Name = "BtnAjuda";
            BtnAjuda.Size = new Size(75, 60);
            BtnAjuda.TabIndex = 52;
            BtnAjuda.UseVisualStyleBackColor = true;
            // 
            // LblMsgAjuda
            // 
            LblMsgAjuda.AutoSize = true;
            LblMsgAjuda.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            LblMsgAjuda.Location = new Point(854, 41);
            LblMsgAjuda.Name = "LblMsgAjuda";
            LblMsgAjuda.Size = new Size(161, 17);
            LblMsgAjuda.TabIndex = 53;
            LblMsgAjuda.Text = "Precisa de ajuda, clique aqui.";
            // 
            // RbtUm
            // 
            RbtUm.AutoSize = true;
            RbtUm.Checked = true;
            RbtUm.Location = new Point(529, 85);
            RbtUm.Name = "RbtUm";
            RbtUm.Size = new Size(34, 24);
            RbtUm.TabIndex = 54;
            RbtUm.TabStop = true;
            RbtUm.Text = "1";
            RbtUm.UseVisualStyleBackColor = true;
            RbtUm.CheckedChanged += RbtUm_CheckedChanged;
            // 
            // RbtDois
            // 
            RbtDois.AutoSize = true;
            RbtDois.Location = new Point(569, 85);
            RbtDois.Name = "RbtDois";
            RbtDois.Size = new Size(34, 24);
            RbtDois.TabIndex = 55;
            RbtDois.Text = "2";
            RbtDois.UseVisualStyleBackColor = true;
            RbtDois.CheckedChanged += RbtDois_CheckedChanged;
            // 
            // RbtTres
            // 
            RbtTres.AutoSize = true;
            RbtTres.Location = new Point(609, 85);
            RbtTres.Name = "RbtTres";
            RbtTres.Size = new Size(34, 24);
            RbtTres.TabIndex = 56;
            RbtTres.Text = "3";
            RbtTres.UseVisualStyleBackColor = true;
            RbtTres.CheckedChanged += RbtTres_CheckedChanged;
            // 
            // RbtQuatro
            // 
            RbtQuatro.AutoSize = true;
            RbtQuatro.Location = new Point(649, 85);
            RbtQuatro.Name = "RbtQuatro";
            RbtQuatro.Size = new Size(34, 24);
            RbtQuatro.TabIndex = 57;
            RbtQuatro.Text = "4";
            RbtQuatro.UseVisualStyleBackColor = true;
            RbtQuatro.CheckedChanged += RbtQuatro_CheckedChanged;
            // 
            // FmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1114, 591);
            Controls.Add(RbtQuatro);
            Controls.Add(RbtTres);
            Controls.Add(RbtDois);
            Controls.Add(RbtUm);
            Controls.Add(LblMsgAjuda);
            Controls.Add(BtnAjuda);
            Controls.Add(CmbCategoriaCam4);
            Controls.Add(CmbCategoriaCam3);
            Controls.Add(CmbCategoriaCam2);
            Controls.Add(LblCategoriaCam4);
            Controls.Add(LblCategoriaCam3);
            Controls.Add(LblCategoriaCam2);
            Controls.Add(CmbCategoriaCam1);
            Controls.Add(LblCategoriaCam1);
            Controls.Add(BtnCalculcar);
            Controls.Add(BtnLimparTudo);
            Controls.Add(TxtComponente);
            Controls.Add(LblComponente);
            Controls.Add(BtnAdicionarCam4);
            Controls.Add(BtnRemoverCam4);
            Controls.Add(TxtEsforcoCam4);
            Controls.Add(CmbElementoCam4);
            Controls.Add(LblEsforcoCam4);
            Controls.Add(LblElementoCam4);
            Controls.Add(BtnAdicionarCam3);
            Controls.Add(BtnRemoverCam3);
            Controls.Add(TxtEsforcoCam3);
            Controls.Add(CmbElementoCam3);
            Controls.Add(LblEsforcoCam3);
            Controls.Add(LblElementoCam3);
            Controls.Add(BtnAdicionarCam2);
            Controls.Add(BtnRemoverCam2);
            Controls.Add(TxtEsforcoCam2);
            Controls.Add(LblEsforcoCam2);
            Controls.Add(CmbElementoCam2);
            Controls.Add(LblElementoCam2);
            Controls.Add(BtnAdicionarCam1);
            Controls.Add(BtnRemoverCam1);
            Controls.Add(TxtEsforcoCam1);
            Controls.Add(LblEsforcoCam1);
            Controls.Add(CmbElementoCam1);
            Controls.Add(LblElementoCam1);
            Controls.Add(LblCaminho4);
            Controls.Add(LblCaminho3);
            Controls.Add(LblCaminho2);
            Controls.Add(LblCaminho1);
            Controls.Add(LblQuantidadeCaminhos);
            Controls.Add(DgvCaminhos);
            Controls.Add(BarraMenu);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = BarraMenu;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CECE - Calculadora Emergética de Componentes Eletronicos";
            BarraMenu.ResumeLayout(false);
            BarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCaminhos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip BarraMenu;
        private ToolStripMenuItem aJUDAToolStripMenuItem;
        private DataGridView DgvCaminhos;
        private Label LblQuantidadeCaminhos;
        private Label LblCaminho1;
        private Label LblCaminho2;
        private Label LblCaminho3;
        private Label LblCaminho4;
        private Label LblElementoCam1;
        private ComboBox CmbElementoCam1;
        private Label LblEsforcoCam1;
        private TextBox TxtEsforcoCam1;
        private Button BtnRemoverCam1;
        private Button BtnAdicionarCam1;
        private Label LblElementoCam2;
        private ComboBox CmbElementoCam2;
        private Label LblEsforcoCam2;
        private TextBox TxtEsforcoCam2;
        private Button BtnRemoverCam2;
        private Button BtnAdicionarCam2;
        private Label LblElementoCam3;
        private Label LblEsforcoCam3;
        private ComboBox CmbElementoCam3;
        private TextBox TxtEsforcoCam3;
        private Button BtnRemoverCam3;
        private Button BtnAdicionarCam3;
        private Label LblElementoCam4;
        private Label LblEsforcoCam4;
        private ComboBox CmbElementoCam4;
        private TextBox TxtEsforcoCam4;
        private Button BtnRemoverCam4;
        private Button BtnAdicionarCam4;
        private Label LblComponente;
        private TextBox TxtComponente;
        private Button BtnLimparTudo;
        private Button BtnCalculcar;
        private Label LblCategoriaCam1;
        private ComboBox CmbCategoriaCam1;
        private Label LblCategoriaCam2;
        private Label LblCategoriaCam3;
        private Label LblCategoriaCam4;
        private ComboBox CmbCategoriaCam2;
        private ComboBox CmbCategoriaCam3;
        private ComboBox CmbCategoriaCam4;
        private Button BtnAjuda;
        private Label LblMsgAjuda;
        private RadioButton RbtUm;
        private RadioButton RbtDois;
        private RadioButton RbtTres;
        private RadioButton RbtQuatro;
    }
}
