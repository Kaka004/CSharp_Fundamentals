namespace ProjetoImpress
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnPesquisar = new Button();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtCep = new MaskedTextBox();
            cbUF = new ComboBox();
            txtComplemento = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnInativar = new Button();
            btnLimpar = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            txtCpf = new MaskedTextBox();
            label11 = new Label();
            txtDtNasc = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnImprimir = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblData = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblHora = new ToolStripStatusLabel();
            dgCliente = new DataGridView();
            label12 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblCpfcheck = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 260);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 300);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 1;
            label2.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 340);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 2;
            label3.Text = "Cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(756, 299);
            label4.Name = "label4";
            label4.Size = new Size(43, 30);
            label4.TabIndex = 3;
            label4.Text = "Nº:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 380);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 4;
            label5.Text = "Compl.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 338);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 5;
            label6.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(755, 339);
            label7.Name = "label7";
            label7.Size = new Size(44, 30);
            label7.TabIndex = 6;
            label7.Text = "UF:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 53);
            label8.Name = "label8";
            label8.Size = new Size(89, 30);
            label8.TabIndex = 7;
            label8.Text = "Código:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 380);
            label9.Name = "label9";
            label9.Size = new Size(101, 30);
            label9.TabIndex = 8;
            label9.Text = "Telefone:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(750, 49);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(156, 44);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(101, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 36);
            txtCodigo.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 257);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(795, 36);
            txtNome.TabIndex = 11;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(138, 297);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(561, 36);
            txtEndereco.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(809, 297);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(124, 36);
            txtNumero.TabIndex = 13;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(138, 337);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(318, 36);
            txtCidade.TabIndex = 14;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(565, 337);
            txtCep.Mask = "00000-999";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(134, 36);
            txtCep.TabIndex = 15;
            // 
            // cbUF
            // 
            cbUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUF.FormattingEnabled = true;
            cbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "GO", "ES", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SP", "SC", "SE", "TO" });
            cbUF.Location = new Point(809, 337);
            cbUF.Name = "cbUF";
            cbUF.Size = new Size(124, 38);
            cbUF.TabIndex = 16;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(138, 377);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(318, 36);
            txtComplemento.TabIndex = 17;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(565, 377);
            maskedTextBox2.Mask = "(99) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(134, 36);
            maskedTextBox2.TabIndex = 18;
            // 
            // btnInserir
            // 
            btnInserir.AccessibleDescription = "Pressione ALT + N para inserir novo cliente";
            btnInserir.AccessibleName = "NovoCliente";
            btnInserir.AccessibleRole = AccessibleRole.Sound;
            btnInserir.AutoEllipsis = true;
            btnInserir.Image = Properties.Resources.btNovo2;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(9, 38);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(275, 61);
            btnInserir.TabIndex = 19;
            btnInserir.Text = "&Novo cliente";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.btAltera;
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(9, 103);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(275, 61);
            btnAlterar.TabIndex = 20;
            btnAlterar.Text = "Alterar cliente";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInativar
            // 
            btnInativar.Image = Properties.Resources.trash_32;
            btnInativar.ImageAlign = ContentAlignment.MiddleLeft;
            btnInativar.Location = new Point(9, 224);
            btnInativar.Name = "btnInativar";
            btnInativar.Size = new Size(275, 61);
            btnInativar.TabIndex = 21;
            btnInativar.Text = "Excluir cliente";
            btnInativar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.paint_tools;
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(9, 291);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(275, 60);
            btnLimpar.TabIndex = 22;
            btnLimpar.Text = "Limpar dados";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CADASTRO_DE_CLIENTES;
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1253, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 56);
            label10.Name = "label10";
            label10.Size = new Size(55, 30);
            label10.TabIndex = 24;
            label10.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(315, 50);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(163, 36);
            txtCpf.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(702, 379);
            label11.Name = "label11";
            label11.Size = new Size(97, 30);
            label11.TabIndex = 26;
            label11.Text = "Dt. Nasc:";
            // 
            // txtDtNasc
            // 
            txtDtNasc.Location = new Point(809, 379);
            txtDtNasc.Mask = "00/00/0000";
            txtDtNasc.Name = "txtDtNasc";
            txtDtNasc.Size = new Size(124, 36);
            txtDtNasc.TabIndex = 27;
            txtDtNasc.ValidatingType = typeof(DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImprimir);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnInativar);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Location = new Point(950, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 357);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comandos";
            // 
            // btnImprimir
            // 
            btnImprimir.Image = Properties.Resources.Printer_modern;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(9, 170);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(275, 48);
            btnImprimir.TabIndex = 23;
            btnImprimir.Text = "Imprimir tela";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblData, toolStripStatusLabel2, lblHora });
            statusStrip1.Location = new Point(0, 724);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1252, 26);
            statusStrip1.TabIndex = 31;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(63, 21);
            toolStripStatusLabel1.Text = "HOJE É";
            // 
            // lblData
            // 
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.Name = "lblData";
            lblData.Size = new Size(174, 21);
            lblData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(69, 21);
            toolStripStatusLabel2.Text = "|| E SÃO";
            // 
            // lblHora
            // 
            lblHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(174, 21);
            lblHora.Text = "toolStripStatusLabel3";
            // 
            // dgCliente
            // 
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Location = new Point(12, 493);
            dgCliente.Name = "dgCliente";
            dgCliente.RowTemplate.Height = 25;
            dgCliente.Size = new Size(1228, 219);
            dgCliente.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 460);
            label12.Name = "label12";
            label12.Size = new Size(219, 30);
            label12.TabIndex = 33;
            label12.Text = "Clientes Cadastrados:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblCpfcheck
            // 
            lblCpfcheck.AutoSize = true;
            lblCpfcheck.Location = new Point(484, 56);
            lblCpfcheck.Name = "lblCpfcheck";
            lblCpfcheck.Size = new Size(18, 30);
            lblCpfcheck.TabIndex = 34;
            lblCpfcheck.Text = ".";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lblCpfcheck);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCpf);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Location = new Point(11, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(922, 110);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Efetue a Pesquisa:";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1252, 750);
            Controls.Add(groupBox2);
            Controls.Add(label12);
            Controls.Add(dgCliente);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(txtDtNasc);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(txtComplemento);
            Controls.Add(cbUF);
            Controls.Add(txtCep);
            Controls.Add(txtCidade);
            Controls.Add(txtNumero);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE CLIENTES";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnPesquisar;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private MaskedTextBox txtCep;
        private ComboBox cbUF;
        private TextBox txtComplemento;
        private MaskedTextBox maskedTextBox2;
        private Button btnInserir;
        private Button btnAlterar;
        private Button btnInativar;
        private Button btnLimpar;
        private PictureBox pictureBox1;
        private Label label10;
        private MaskedTextBox txtCpf;
        private Label label11;
        private MaskedTextBox txtDtNasc;
        private GroupBox groupBox1;
        private StatusStrip statusStrip1;
        private DataGridView dgCliente;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblHora;
        private Label label12;
        private System.Windows.Forms.Timer timer1;
        private Label lblCpfcheck;
        private GroupBox groupBox2;
        private Button btnImprimir;
    }
}