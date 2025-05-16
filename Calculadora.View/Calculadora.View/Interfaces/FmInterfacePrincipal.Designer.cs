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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BarraMenu = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            BtnEmergia = new ToolStripMenuItem();
            ObterAjudaToolStripMenuItem = new ToolStripMenuItem();
            SairToolStripMenuItem = new ToolStripMenuItem();
            DgvCaminho1 = new DataGridView();
            CategoriaCam1 = new DataGridViewTextBoxColumn();
            ElementoCam1 = new DataGridViewTextBoxColumn();
            UnidadeMedidaCam1 = new DataGridViewTextBoxColumn();
            EsforcoCam1 = new DataGridViewTextBoxColumn();
            LblNumeroCaminhos = new Label();
            LblCaminho1 = new Label();
            LblCaminho2 = new Label();
            LblCaminho3 = new Label();
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
            LblComponente = new Label();
            TxtComponente = new TextBox();
            BtnLimparTudo = new Button();
            BtnCalculcar = new Button();
            LblCategoriaCam1 = new Label();
            CmbCategoriaCam1 = new ComboBox();
            LblCategoriaCam2 = new Label();
            LblCategoriaCam3 = new Label();
            CmbCategoriaCam2 = new ComboBox();
            CmbCategoriaCam3 = new ComboBox();
            BtnAjuda = new Button();
            LblMsgAjuda = new Label();
            RbtUm = new RadioButton();
            RbtDois = new RadioButton();
            RbtTres = new RadioButton();
            DgvCaminho2 = new DataGridView();
            CategoriaCam2 = new DataGridViewTextBoxColumn();
            ElementoCam2 = new DataGridViewTextBoxColumn();
            UnidadeMedidaCam2 = new DataGridViewTextBoxColumn();
            EsforcoCam2 = new DataGridViewTextBoxColumn();
            DgvCaminho3 = new DataGridView();
            CategoriaCam3 = new DataGridViewTextBoxColumn();
            ElementoCam3 = new DataGridViewTextBoxColumn();
            UnidadeMedidaCam3 = new DataGridViewTextBoxColumn();
            EsforcoCam3 = new DataGridViewTextBoxColumn();
            LblDgvCam1 = new Label();
            LblDgvCam2 = new Label();
            LblDgvCam3 = new Label();
            TxtNomeCam1 = new TextBox();
            TxtNomeCam2 = new TextBox();
            TxtNomeCam3 = new TextBox();
            LblNomeCam1 = new Label();
            LblNomeCam2 = new Label();
            LblNomeCam3 = new Label();
            BarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCaminho1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvCaminho2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvCaminho3).BeginInit();
            SuspendLayout();
            // 
            // BarraMenu
            // 
            BarraMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, BtnEmergia, ObterAjudaToolStripMenuItem, SairToolStripMenuItem });
            BarraMenu.Location = new Point(0, 0);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(1114, 24);
            BarraMenu.TabIndex = 0;
            BarraMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // BtnEmergia
            // 
            BtnEmergia.Name = "BtnEmergia";
            BtnEmergia.Size = new Size(156, 20);
            BtnEmergia.Text = "Entenda o que é emergeia";
            BtnEmergia.Click += BtnEmergia_Click;
            // 
            // ObterAjudaToolStripMenuItem
            // 
            ObterAjudaToolStripMenuItem.Name = "ObterAjudaToolStripMenuItem";
            ObterAjudaToolStripMenuItem.Size = new Size(81, 20);
            ObterAjudaToolStripMenuItem.Text = "Obter ajuda";
            ObterAjudaToolStripMenuItem.Click += ObterAjudaToolStripMenuItem_Click;
            // 
            // SairToolStripMenuItem
            // 
            SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            SairToolStripMenuItem.Size = new Size(38, 20);
            SairToolStripMenuItem.Text = "Sair";
            SairToolStripMenuItem.Click += SairToolStripMenuItem_Click;
            // 
            // DgvCaminho1
            // 
            DgvCaminho1.AllowUserToAddRows = false;
            DgvCaminho1.AllowUserToResizeRows = false;
            DgvCaminho1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCaminho1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCaminho1.Columns.AddRange(new DataGridViewColumn[] { CategoriaCam1, ElementoCam1, UnidadeMedidaCam1, EsforcoCam1 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvCaminho1.DefaultCellStyle = dataGridViewCellStyle1;
            DgvCaminho1.Location = new Point(12, 67);
            DgvCaminho1.MultiSelect = false;
            DgvCaminho1.Name = "DgvCaminho1";
            DgvCaminho1.ReadOnly = true;
            DgvCaminho1.RowHeadersVisible = false;
            DgvCaminho1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCaminho1.Size = new Size(333, 111);
            DgvCaminho1.TabIndex = 1;
            // 
            // CategoriaCam1
            // 
            CategoriaCam1.HeaderText = "Categoria";
            CategoriaCam1.Name = "CategoriaCam1";
            CategoriaCam1.ReadOnly = true;
            // 
            // ElementoCam1
            // 
            ElementoCam1.HeaderText = "Elemento";
            ElementoCam1.Name = "ElementoCam1";
            ElementoCam1.ReadOnly = true;
            // 
            // UnidadeMedidaCam1
            // 
            UnidadeMedidaCam1.HeaderText = "Unidade";
            UnidadeMedidaCam1.Name = "UnidadeMedidaCam1";
            UnidadeMedidaCam1.ReadOnly = true;
            // 
            // EsforcoCam1
            // 
            EsforcoCam1.HeaderText = "Esforço";
            EsforcoCam1.Name = "EsforcoCam1";
            EsforcoCam1.ReadOnly = true;
            // 
            // LblNumeroCaminhos
            // 
            LblNumeroCaminhos.AutoSize = true;
            LblNumeroCaminhos.Location = new Point(757, 38);
            LblNumeroCaminhos.Name = "LblNumeroCaminhos";
            LblNumeroCaminhos.Size = new Size(115, 20);
            LblNumeroCaminhos.TabIndex = 2;
            LblNumeroCaminhos.Text = "Nº de caminhos: ";
            // 
            // LblCaminho1
            // 
            LblCaminho1.AutoSize = true;
            LblCaminho1.Location = new Point(351, 85);
            LblCaminho1.Name = "LblCaminho1";
            LblCaminho1.Size = new Size(228, 20);
            LblCaminho1.TabIndex = 5;
            LblCaminho1.Text = "Nome do elemento do 1º caminho: ";
            // 
            // LblCaminho2
            // 
            LblCaminho2.AutoSize = true;
            LblCaminho2.Location = new Point(351, 252);
            LblCaminho2.Name = "LblCaminho2";
            LblCaminho2.Size = new Size(228, 20);
            LblCaminho2.TabIndex = 6;
            LblCaminho2.Text = "Nome do elemento do 2º caminho: ";
            LblCaminho2.Visible = false;
            // 
            // LblCaminho3
            // 
            LblCaminho3.AutoSize = true;
            LblCaminho3.Location = new Point(351, 420);
            LblCaminho3.Name = "LblCaminho3";
            LblCaminho3.Size = new Size(228, 20);
            LblCaminho3.TabIndex = 7;
            LblCaminho3.Text = "Nome do elemento do 3º caminho: ";
            LblCaminho3.Visible = false;
            // 
            // LblElementoCam1
            // 
            LblElementoCam1.AutoSize = true;
            LblElementoCam1.Location = new Point(666, 121);
            LblElementoCam1.Name = "LblElementoCam1";
            LblElementoCam1.Size = new Size(72, 20);
            LblElementoCam1.TabIndex = 10;
            LblElementoCam1.Text = "Elemento:";
            // 
            // CmbElementoCam1
            // 
            CmbElementoCam1.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbElementoCam1.FormattingEnabled = true;
            CmbElementoCam1.IntegralHeight = false;
            CmbElementoCam1.Location = new Point(744, 118);
            CmbElementoCam1.Name = "CmbElementoCam1";
            CmbElementoCam1.Size = new Size(358, 28);
            CmbElementoCam1.TabIndex = 11;
            // 
            // LblEsforcoCam1
            // 
            LblEsforcoCam1.AutoSize = true;
            LblEsforcoCam1.Location = new Point(393, 155);
            LblEsforcoCam1.Name = "LblEsforcoCam1";
            LblEsforcoCam1.Size = new Size(65, 20);
            LblEsforcoCam1.TabIndex = 12;
            LblEsforcoCam1.Text = "Esforço: ";
            // 
            // TxtEsforcoCam1
            // 
            TxtEsforcoCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEsforcoCam1.Location = new Point(460, 152);
            TxtEsforcoCam1.MaxLength = 3;
            TxtEsforcoCam1.Name = "TxtEsforcoCam1";
            TxtEsforcoCam1.Size = new Size(70, 26);
            TxtEsforcoCam1.TabIndex = 13;
            TxtEsforcoCam1.KeyPress += TxtEsforcoCam1_KeyPress;
            // 
            // BtnRemoverCam1
            // 
            BtnRemoverCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnRemoverCam1.Location = new Point(588, 152);
            BtnRemoverCam1.Name = "BtnRemoverCam1";
            BtnRemoverCam1.Size = new Size(180, 30);
            BtnRemoverCam1.TabIndex = 14;
            BtnRemoverCam1.Text = "Remover Último Elemento";
            BtnRemoverCam1.UseVisualStyleBackColor = true;
            BtnRemoverCam1.Click += BtnRemoverCam1_Click;
            // 
            // BtnAdicionarCam1
            // 
            BtnAdicionarCam1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            BtnAdicionarCam1.Location = new Point(794, 152);
            BtnAdicionarCam1.Name = "BtnAdicionarCam1";
            BtnAdicionarCam1.Size = new Size(150, 30);
            BtnAdicionarCam1.TabIndex = 15;
            BtnAdicionarCam1.Text = "Adicionar Elemento";
            BtnAdicionarCam1.UseVisualStyleBackColor = true;
            BtnAdicionarCam1.Click += BtnAdicionarCam1_Click;
            // 
            // LblElementoCam2
            // 
            LblElementoCam2.AutoSize = true;
            LblElementoCam2.Location = new Point(666, 290);
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
            CmbElementoCam2.IntegralHeight = false;
            CmbElementoCam2.Location = new Point(744, 287);
            CmbElementoCam2.Name = "CmbElementoCam2";
            CmbElementoCam2.Size = new Size(358, 28);
            CmbElementoCam2.TabIndex = 17;
            CmbElementoCam2.Visible = false;
            // 
            // LblEsforcoCam2
            // 
            LblEsforcoCam2.AutoSize = true;
            LblEsforcoCam2.Location = new Point(393, 322);
            LblEsforcoCam2.Name = "LblEsforcoCam2";
            LblEsforcoCam2.Size = new Size(65, 20);
            LblEsforcoCam2.TabIndex = 18;
            LblEsforcoCam2.Text = "Esforço: ";
            LblEsforcoCam2.Visible = false;
            // 
            // TxtEsforcoCam2
            // 
            TxtEsforcoCam2.Font = new Font("Arial Narrow", 12F);
            TxtEsforcoCam2.Location = new Point(460, 319);
            TxtEsforcoCam2.MaxLength = 3;
            TxtEsforcoCam2.Name = "TxtEsforcoCam2";
            TxtEsforcoCam2.Size = new Size(70, 26);
            TxtEsforcoCam2.TabIndex = 19;
            TxtEsforcoCam2.Visible = false;
            TxtEsforcoCam2.KeyPress += TxtEsforcoCam2_KeyPress;
            // 
            // BtnRemoverCam2
            // 
            BtnRemoverCam2.Location = new Point(588, 321);
            BtnRemoverCam2.Name = "BtnRemoverCam2";
            BtnRemoverCam2.Size = new Size(180, 30);
            BtnRemoverCam2.TabIndex = 20;
            BtnRemoverCam2.Text = "Remover Último Elemento";
            BtnRemoverCam2.UseVisualStyleBackColor = true;
            BtnRemoverCam2.Visible = false;
            BtnRemoverCam2.Click += BtnRemoverCam2_Click;
            // 
            // BtnAdicionarCam2
            // 
            BtnAdicionarCam2.Location = new Point(794, 321);
            BtnAdicionarCam2.Name = "BtnAdicionarCam2";
            BtnAdicionarCam2.Size = new Size(150, 30);
            BtnAdicionarCam2.TabIndex = 21;
            BtnAdicionarCam2.Text = "Adicionar Elemento";
            BtnAdicionarCam2.UseVisualStyleBackColor = true;
            BtnAdicionarCam2.Visible = false;
            BtnAdicionarCam2.Click += BtnAdicionarCam2_Click;
            // 
            // LblElementoCam3
            // 
            LblElementoCam3.AutoSize = true;
            LblElementoCam3.Location = new Point(666, 456);
            LblElementoCam3.Name = "LblElementoCam3";
            LblElementoCam3.Size = new Size(76, 20);
            LblElementoCam3.TabIndex = 22;
            LblElementoCam3.Text = "Elemento: ";
            LblElementoCam3.Visible = false;
            // 
            // LblEsforcoCam3
            // 
            LblEsforcoCam3.AutoSize = true;
            LblEsforcoCam3.Location = new Point(393, 487);
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
            CmbElementoCam3.IntegralHeight = false;
            CmbElementoCam3.Location = new Point(744, 453);
            CmbElementoCam3.Name = "CmbElementoCam3";
            CmbElementoCam3.Size = new Size(358, 28);
            CmbElementoCam3.TabIndex = 24;
            CmbElementoCam3.Visible = false;
            // 
            // TxtEsforcoCam3
            // 
            TxtEsforcoCam3.Font = new Font("Arial Narrow", 12F);
            TxtEsforcoCam3.Location = new Point(460, 487);
            TxtEsforcoCam3.MaxLength = 3;
            TxtEsforcoCam3.Name = "TxtEsforcoCam3";
            TxtEsforcoCam3.Size = new Size(70, 26);
            TxtEsforcoCam3.TabIndex = 25;
            TxtEsforcoCam3.Visible = false;
            TxtEsforcoCam3.KeyPress += TxtEsforcoCam3_KeyPress;
            // 
            // BtnRemoverCam3
            // 
            BtnRemoverCam3.Location = new Point(588, 487);
            BtnRemoverCam3.Name = "BtnRemoverCam3";
            BtnRemoverCam3.Size = new Size(180, 30);
            BtnRemoverCam3.TabIndex = 26;
            BtnRemoverCam3.Text = "Remover Último Elemento";
            BtnRemoverCam3.UseVisualStyleBackColor = true;
            BtnRemoverCam3.Visible = false;
            BtnRemoverCam3.Click += BtnRemoverCam3_Click;
            // 
            // BtnAdicionarCam3
            // 
            BtnAdicionarCam3.Location = new Point(794, 487);
            BtnAdicionarCam3.Name = "BtnAdicionarCam3";
            BtnAdicionarCam3.Size = new Size(150, 30);
            BtnAdicionarCam3.TabIndex = 27;
            BtnAdicionarCam3.Text = "Adicionar Elemento";
            BtnAdicionarCam3.UseVisualStyleBackColor = true;
            BtnAdicionarCam3.Visible = false;
            BtnAdicionarCam3.Click += BtnAdicionarCam3_Click;
            // 
            // LblComponente
            // 
            LblComponente.AutoSize = true;
            LblComponente.Location = new Point(351, 38);
            LblComponente.Name = "LblComponente";
            LblComponente.Size = new Size(194, 20);
            LblComponente.TabIndex = 40;
            LblComponente.Text = "Componente a ser calculado: ";
            // 
            // TxtComponente
            // 
            TxtComponente.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtComponente.Location = new Point(551, 37);
            TxtComponente.MaxLength = 30;
            TxtComponente.Name = "TxtComponente";
            TxtComponente.Size = new Size(200, 26);
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
            BtnLimparTudo.Click += BtnLimparTudo_Click;
            // 
            // BtnCalculcar
            // 
            BtnCalculcar.Location = new Point(588, 549);
            BtnCalculcar.Name = "BtnCalculcar";
            BtnCalculcar.Size = new Size(80, 30);
            BtnCalculcar.TabIndex = 43;
            BtnCalculcar.Text = "Calcular";
            BtnCalculcar.UseVisualStyleBackColor = true;
            BtnCalculcar.Click += BtnCalculcar_Click;
            // 
            // LblCategoriaCam1
            // 
            LblCategoriaCam1.AutoSize = true;
            LblCategoriaCam1.Location = new Point(382, 121);
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
            CmbCategoriaCam1.Location = new Point(460, 118);
            CmbCategoriaCam1.Name = "CmbCategoriaCam1";
            CmbCategoriaCam1.Size = new Size(200, 28);
            CmbCategoriaCam1.TabIndex = 45;
            CmbCategoriaCam1.SelectedIndexChanged += CmbCategoriaCam1_SelectedIndexChanged;
            // 
            // LblCategoriaCam2
            // 
            LblCategoriaCam2.AutoSize = true;
            LblCategoriaCam2.Location = new Point(382, 290);
            LblCategoriaCam2.Name = "LblCategoriaCam2";
            LblCategoriaCam2.Size = new Size(76, 20);
            LblCategoriaCam2.TabIndex = 46;
            LblCategoriaCam2.Text = "Categoria: ";
            LblCategoriaCam2.Visible = false;
            // 
            // LblCategoriaCam3
            // 
            LblCategoriaCam3.AutoSize = true;
            LblCategoriaCam3.Location = new Point(382, 456);
            LblCategoriaCam3.Name = "LblCategoriaCam3";
            LblCategoriaCam3.Size = new Size(76, 20);
            LblCategoriaCam3.TabIndex = 47;
            LblCategoriaCam3.Text = "Categoria: ";
            LblCategoriaCam3.Visible = false;
            // 
            // CmbCategoriaCam2
            // 
            CmbCategoriaCam2.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaCam2.FormattingEnabled = true;
            CmbCategoriaCam2.Items.AddRange(new object[] { "Componentes", "Materias Primas", "Processos", "Produtos" });
            CmbCategoriaCam2.Location = new Point(460, 285);
            CmbCategoriaCam2.Name = "CmbCategoriaCam2";
            CmbCategoriaCam2.Size = new Size(200, 28);
            CmbCategoriaCam2.TabIndex = 49;
            CmbCategoriaCam2.Visible = false;
            CmbCategoriaCam2.SelectedIndexChanged += CmbCategoriaCam2_SelectedIndexChanged;
            // 
            // CmbCategoriaCam3
            // 
            CmbCategoriaCam3.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaCam3.FormattingEnabled = true;
            CmbCategoriaCam3.Items.AddRange(new object[] { "Componentes", "Materias Primas", "Processos", "Produtos" });
            CmbCategoriaCam3.Location = new Point(460, 453);
            CmbCategoriaCam3.Name = "CmbCategoriaCam3";
            CmbCategoriaCam3.Size = new Size(200, 28);
            CmbCategoriaCam3.TabIndex = 50;
            CmbCategoriaCam3.Visible = false;
            CmbCategoriaCam3.SelectedIndexChanged += CmbCategoriaCam3_SelectedIndexChanged;
            // 
            // BtnAjuda
            // 
            BtnAjuda.BackgroundImage = (Image)resources.GetObject("BtnAjuda.BackgroundImage");
            BtnAjuda.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAjuda.FlatAppearance.BorderSize = 0;
            BtnAjuda.FlatStyle = FlatStyle.Flat;
            BtnAjuda.Location = new Point(1058, 38);
            BtnAjuda.Name = "BtnAjuda";
            BtnAjuda.Size = new Size(45, 30);
            BtnAjuda.TabIndex = 52;
            BtnAjuda.UseVisualStyleBackColor = true;
            BtnAjuda.Click += BtnAjuda_Click;
            // 
            // LblMsgAjuda
            // 
            LblMsgAjuda.AutoSize = true;
            LblMsgAjuda.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            LblMsgAjuda.Location = new Point(1062, 75);
            LblMsgAjuda.Name = "LblMsgAjuda";
            LblMsgAjuda.Size = new Size(40, 17);
            LblMsgAjuda.TabIndex = 53;
            LblMsgAjuda.Text = "Ajuda";
            // 
            // RbtUm
            // 
            RbtUm.AutoSize = true;
            RbtUm.Checked = true;
            RbtUm.Location = new Point(878, 38);
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
            RbtDois.Location = new Point(918, 38);
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
            RbtTres.Location = new Point(958, 38);
            RbtTres.Name = "RbtTres";
            RbtTres.Size = new Size(34, 24);
            RbtTres.TabIndex = 56;
            RbtTres.Text = "3";
            RbtTres.UseVisualStyleBackColor = true;
            RbtTres.CheckedChanged += RbtTres_CheckedChanged;
            // 
            // DgvCaminho2
            // 
            DgvCaminho2.AllowUserToAddRows = false;
            DgvCaminho2.AllowUserToResizeRows = false;
            DgvCaminho2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCaminho2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCaminho2.Columns.AddRange(new DataGridViewColumn[] { CategoriaCam2, ElementoCam2, UnidadeMedidaCam2, EsforcoCam2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvCaminho2.DefaultCellStyle = dataGridViewCellStyle2;
            DgvCaminho2.Location = new Point(12, 234);
            DgvCaminho2.Name = "DgvCaminho2";
            DgvCaminho2.ReadOnly = true;
            DgvCaminho2.RowHeadersVisible = false;
            DgvCaminho2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCaminho2.Size = new Size(333, 111);
            DgvCaminho2.TabIndex = 57;
            DgvCaminho2.Visible = false;
            // 
            // CategoriaCam2
            // 
            CategoriaCam2.HeaderText = "Categoria";
            CategoriaCam2.Name = "CategoriaCam2";
            CategoriaCam2.ReadOnly = true;
            // 
            // ElementoCam2
            // 
            ElementoCam2.HeaderText = "Elemento";
            ElementoCam2.Name = "ElementoCam2";
            ElementoCam2.ReadOnly = true;
            // 
            // UnidadeMedidaCam2
            // 
            UnidadeMedidaCam2.HeaderText = "Unidade";
            UnidadeMedidaCam2.Name = "UnidadeMedidaCam2";
            UnidadeMedidaCam2.ReadOnly = true;
            // 
            // EsforcoCam2
            // 
            EsforcoCam2.HeaderText = "Esforço";
            EsforcoCam2.Name = "EsforcoCam2";
            EsforcoCam2.ReadOnly = true;
            // 
            // DgvCaminho3
            // 
            DgvCaminho3.AllowUserToAddRows = false;
            DgvCaminho3.AllowUserToResizeRows = false;
            DgvCaminho3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCaminho3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCaminho3.Columns.AddRange(new DataGridViewColumn[] { CategoriaCam3, ElementoCam3, UnidadeMedidaCam3, EsforcoCam3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvCaminho3.DefaultCellStyle = dataGridViewCellStyle3;
            DgvCaminho3.Location = new Point(12, 402);
            DgvCaminho3.Name = "DgvCaminho3";
            DgvCaminho3.ReadOnly = true;
            DgvCaminho3.RowHeadersVisible = false;
            DgvCaminho3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCaminho3.Size = new Size(333, 111);
            DgvCaminho3.TabIndex = 58;
            DgvCaminho3.Visible = false;
            // 
            // CategoriaCam3
            // 
            CategoriaCam3.HeaderText = "Categoria";
            CategoriaCam3.Name = "CategoriaCam3";
            CategoriaCam3.ReadOnly = true;
            // 
            // ElementoCam3
            // 
            ElementoCam3.HeaderText = "Elemento";
            ElementoCam3.Name = "ElementoCam3";
            ElementoCam3.ReadOnly = true;
            // 
            // UnidadeMedidaCam3
            // 
            UnidadeMedidaCam3.HeaderText = "Unidade";
            UnidadeMedidaCam3.Name = "UnidadeMedidaCam3";
            UnidadeMedidaCam3.ReadOnly = true;
            // 
            // EsforcoCam3
            // 
            EsforcoCam3.HeaderText = "Esforço";
            EsforcoCam3.Name = "EsforcoCam3";
            EsforcoCam3.ReadOnly = true;
            // 
            // LblDgvCam1
            // 
            LblDgvCam1.AutoSize = true;
            LblDgvCam1.Location = new Point(12, 44);
            LblDgvCam1.Name = "LblDgvCam1";
            LblDgvCam1.Size = new Size(87, 20);
            LblDgvCam1.TabIndex = 59;
            LblDgvCam1.Text = "1º caminho: ";
            // 
            // LblDgvCam2
            // 
            LblDgvCam2.AutoSize = true;
            LblDgvCam2.Location = new Point(12, 211);
            LblDgvCam2.Name = "LblDgvCam2";
            LblDgvCam2.Size = new Size(87, 20);
            LblDgvCam2.TabIndex = 60;
            LblDgvCam2.Text = "2º caminho: ";
            LblDgvCam2.Visible = false;
            // 
            // LblDgvCam3
            // 
            LblDgvCam3.AutoSize = true;
            LblDgvCam3.Location = new Point(12, 379);
            LblDgvCam3.Name = "LblDgvCam3";
            LblDgvCam3.Size = new Size(87, 20);
            LblDgvCam3.TabIndex = 61;
            LblDgvCam3.Text = "3º caminho: ";
            LblDgvCam3.Visible = false;
            // 
            // TxtNomeCam1
            // 
            TxtNomeCam1.CharacterCasing = CharacterCasing.Lower;
            TxtNomeCam1.Font = new Font("Arial Narrow", 12F);
            TxtNomeCam1.Location = new Point(585, 82);
            TxtNomeCam1.MaxLength = 20;
            TxtNomeCam1.Name = "TxtNomeCam1";
            TxtNomeCam1.Size = new Size(250, 26);
            TxtNomeCam1.TabIndex = 62;
            TxtNomeCam1.TextChanged += TxtnomeCam1_TextChanged;
            TxtNomeCam1.KeyPress += TxtnomeCam1_KeyPress;
            // 
            // TxtNomeCam2
            // 
            TxtNomeCam2.CharacterCasing = CharacterCasing.Lower;
            TxtNomeCam2.Font = new Font("Arial Narrow", 12F);
            TxtNomeCam2.Location = new Point(585, 249);
            TxtNomeCam2.MaxLength = 20;
            TxtNomeCam2.Name = "TxtNomeCam2";
            TxtNomeCam2.Size = new Size(250, 26);
            TxtNomeCam2.TabIndex = 63;
            TxtNomeCam2.Visible = false;
            TxtNomeCam2.TextChanged += TxtNomeCam2_TextChanged;
            TxtNomeCam2.KeyPress += TxtNomeCam2_KeyPress;
            // 
            // TxtNomeCam3
            // 
            TxtNomeCam3.CharacterCasing = CharacterCasing.Lower;
            TxtNomeCam3.Font = new Font("Arial Narrow", 12F);
            TxtNomeCam3.Location = new Point(585, 417);
            TxtNomeCam3.MaxLength = 20;
            TxtNomeCam3.Name = "TxtNomeCam3";
            TxtNomeCam3.Size = new Size(250, 26);
            TxtNomeCam3.TabIndex = 64;
            TxtNomeCam3.Visible = false;
            TxtNomeCam3.TextChanged += TxtNomeCam3_TextChanged;
            TxtNomeCam3.KeyPress += TxtNomeCam3_KeyPress;
            // 
            // LblNomeCam1
            // 
            LblNomeCam1.AutoSize = true;
            LblNomeCam1.Location = new Point(105, 44);
            LblNomeCam1.Name = "LblNomeCam1";
            LblNomeCam1.Size = new Size(0, 20);
            LblNomeCam1.TabIndex = 65;
            // 
            // LblNomeCam2
            // 
            LblNomeCam2.AutoSize = true;
            LblNomeCam2.Location = new Point(105, 211);
            LblNomeCam2.Name = "LblNomeCam2";
            LblNomeCam2.Size = new Size(0, 20);
            LblNomeCam2.TabIndex = 66;
            LblNomeCam2.Visible = false;
            // 
            // LblNomeCam3
            // 
            LblNomeCam3.AutoSize = true;
            LblNomeCam3.Location = new Point(105, 379);
            LblNomeCam3.Name = "LblNomeCam3";
            LblNomeCam3.Size = new Size(0, 20);
            LblNomeCam3.TabIndex = 67;
            LblNomeCam3.Visible = false;
            // 
            // FmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1114, 591);
            Controls.Add(LblNomeCam3);
            Controls.Add(LblNomeCam2);
            Controls.Add(LblNomeCam1);
            Controls.Add(TxtNomeCam3);
            Controls.Add(TxtNomeCam2);
            Controls.Add(TxtNomeCam1);
            Controls.Add(LblDgvCam3);
            Controls.Add(LblDgvCam2);
            Controls.Add(LblDgvCam1);
            Controls.Add(DgvCaminho3);
            Controls.Add(DgvCaminho2);
            Controls.Add(RbtTres);
            Controls.Add(RbtDois);
            Controls.Add(RbtUm);
            Controls.Add(LblMsgAjuda);
            Controls.Add(BtnAjuda);
            Controls.Add(CmbCategoriaCam3);
            Controls.Add(CmbCategoriaCam2);
            Controls.Add(LblCategoriaCam3);
            Controls.Add(LblCategoriaCam2);
            Controls.Add(CmbCategoriaCam1);
            Controls.Add(LblCategoriaCam1);
            Controls.Add(BtnCalculcar);
            Controls.Add(BtnLimparTudo);
            Controls.Add(TxtComponente);
            Controls.Add(LblComponente);
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
            Controls.Add(LblCaminho3);
            Controls.Add(LblCaminho2);
            Controls.Add(LblCaminho1);
            Controls.Add(LblNumeroCaminhos);
            Controls.Add(DgvCaminho1);
            Controls.Add(BarraMenu);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = BarraMenu;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CECE - Calculadora Emergética de Componentes Eletronicos";
            Load += FmPrincipal_Load;
            BarraMenu.ResumeLayout(false);
            BarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCaminho1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvCaminho2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvCaminho3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip BarraMenu;
        private DataGridView DgvCaminho1;
        private Label LblNumeroCaminhos;
        private Label LblCaminho1;
        private Label LblCaminho2;
        private Label LblCaminho3;
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
        private Label LblComponente;
        private TextBox TxtComponente;
        private Button BtnLimparTudo;
        private Button BtnCalculcar;
        private Label LblCategoriaCam1;
        private ComboBox CmbCategoriaCam1;
        private Label LblCategoriaCam2;
        private Label LblCategoriaCam3;
        private ComboBox CmbCategoriaCam2;
        private ComboBox CmbCategoriaCam3;
        private Button BtnAjuda;
        private Label LblMsgAjuda;
        private RadioButton RbtUm;
        private RadioButton RbtDois;
        private RadioButton RbtTres;
        private DataGridView DgvCaminho2;
        private DataGridView DgvCaminho3;
        private Label LblDgvCam1;
        private Label LblDgvCam2;
        private Label LblDgvCam3;
        private TextBox TxtNomeCam1;
        private TextBox TxtNomeCam2;
        private TextBox TxtNomeCam3;
        private Label LblNomeCam1;
        private Label LblNomeCam2;
        private Label LblNomeCam3;
        private DataGridViewTextBoxColumn CategoriaCam2;
        private DataGridViewTextBoxColumn ElementoCam2;
        private DataGridViewTextBoxColumn UnidadeMedidaCam2;
        private DataGridViewTextBoxColumn EsforcoCam2;
        private DataGridViewTextBoxColumn CategoriaCam1;
        private DataGridViewTextBoxColumn ElementoCam1;
        private DataGridViewTextBoxColumn UnidadeMedidaCam1;
        private DataGridViewTextBoxColumn EsforcoCam1;
        private DataGridViewTextBoxColumn CategoriaCam3;
        private DataGridViewTextBoxColumn ElementoCam3;
        private DataGridViewTextBoxColumn UnidadeMedidaCam3;
        private DataGridViewTextBoxColumn EsforcoCam3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem BtnEmergia;
        private ToolStripMenuItem ObterAjudaToolStripMenuItem;
        private ToolStripMenuItem SairToolStripMenuItem;
    }
}
