namespace ProjetoImpress
{
    partial class FrmFornecedor
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtCnpjPesq = new MaskedTextBox();
            lblCnpjCheck = new Label();
            btnPesquisar = new Button();
            groupBox2 = new GroupBox();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnImprimir = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtNumero = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtCidade = new TextBox();
            cbUF = new ComboBox();
            label9 = new Label();
            txtCNPJ = new MaskedTextBox();
            label10 = new Label();
            txtCEP = new MaskedTextBox();
            label11 = new Label();
            dgFornecedor = new DataGridView();
            statusStrip1 = new StatusStrip();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblData = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblHora = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFornecedor).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Controls.Add(lblCnpjCheck);
            groupBox1.Controls.Add(txtCnpjPesq);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Efetue a Pesquisa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 1;
            label2.Text = "CNPJ:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(109, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 36);
            txtCodigo.TabIndex = 2;
            // 
            // txtCnpjPesq
            // 
            txtCnpjPesq.Location = new Point(305, 44);
            txtCnpjPesq.Mask = "99,999,999/9999-99";
            txtCnpjPesq.Name = "txtCnpjPesq";
            txtCnpjPesq.Size = new Size(202, 36);
            txtCnpjPesq.TabIndex = 3;
            // 
            // lblCnpjCheck
            // 
            lblCnpjCheck.AutoSize = true;
            lblCnpjCheck.Location = new Point(513, 50);
            lblCnpjCheck.Name = "lblCnpjCheck";
            lblCnpjCheck.Size = new Size(18, 30);
            lblCnpjCheck.TabIndex = 4;
            lblCnpjCheck.Text = ".";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.Zoom;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(708, 39);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(151, 53);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLimpar);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Controls.Add(btnAlterar);
            groupBox2.Controls.Add(btnInserir);
            groupBox2.Location = new Point(896, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 359);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Comandos";
            // 
            // btnInserir
            // 
            btnInserir.Image = Properties.Resources.btNovo2;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(24, 35);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(210, 57);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Novo Cliente";
            btnInserir.TextAlign = ContentAlignment.MiddleRight;
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.btAltera;
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(24, 98);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(210, 57);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar Cliente";
            btnAlterar.TextAlign = ContentAlignment.MiddleRight;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Image = Properties.Resources.Printer_modern;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(24, 161);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(210, 58);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir tela";
            btnImprimir.TextAlign = ContentAlignment.MiddleRight;
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.trash_32;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(24, 225);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(210, 57);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir Cliente";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.paint_tools;
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(24, 289);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(210, 61);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar dados";
            btnLimpar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 273);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 312);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 4;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(715, 312);
            label5.Name = "label5";
            label5.Size = new Size(43, 30);
            label5.TabIndex = 5;
            label5.Text = "Nº:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 396);
            label6.Name = "label6";
            label6.Size = new Size(101, 30);
            label6.TabIndex = 6;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 354);
            label7.Name = "label7";
            label7.Size = new Size(86, 30);
            label7.TabIndex = 7;
            label7.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(713, 352);
            label8.Name = "label8";
            label8.Size = new Size(44, 30);
            label8.TabIndex = 8;
            label8.Text = "UF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 267);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(762, 36);
            txtNome.TabIndex = 9;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(122, 309);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(587, 36);
            txtEndereco.TabIndex = 10;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(764, 309);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 36);
            txtNumero.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(532, 393);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(177, 36);
            txtTelefone.TabIndex = 12;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(122, 351);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(343, 36);
            txtCidade.TabIndex = 13;
            // 
            // cbUF
            // 
            cbUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUF.FormattingEnabled = true;
            cbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "GO", "ES", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SP", "SC", "SE", "TO" });
            cbUF.Location = new Point(763, 349);
            cbUF.Name = "cbUF";
            cbUF.Size = new Size(121, 38);
            cbUF.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 394);
            label9.Name = "label9";
            label9.Size = new Size(67, 30);
            label9.TabIndex = 15;
            label9.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(122, 391);
            txtCNPJ.Mask = "99,999,999/9999-99";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(184, 36);
            txtCNPJ.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(471, 354);
            label10.Name = "label10";
            label10.Size = new Size(55, 30);
            label10.TabIndex = 17;
            label10.Text = "CEP:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(532, 351);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(177, 36);
            txtCEP.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 471);
            label11.Name = "label11";
            label11.Size = new Size(271, 30);
            label11.TabIndex = 19;
            label11.Text = "Fornecedores Cadastrados";
            // 
            // dgFornecedor
            // 
            dgFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFornecedor.Location = new Point(12, 507);
            dgFornecedor.Name = "dgFornecedor";
            dgFornecedor.RowTemplate.Height = 25;
            dgFornecedor.Size = new Size(1138, 241);
            dgFornecedor.TabIndex = 20;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblData, toolStripStatusLabel3, lblHora });
            statusStrip1.Location = new Point(0, 760);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1162, 26);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(67, 21);
            toolStripStatusLabel1.Text = "HOJE É ";
            // 
            // lblData
            // 
            lblData.Name = "lblData";
            lblData.Size = new Size(127, 21);
            lblData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(46, 21);
            toolStripStatusLabel3.Text = " E SÃO ";
            // 
            // lblHora
            // 
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(127, 21);
            lblHora.Text = "toolStripStatusLabel4";
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1162, 786);
            Controls.Add(statusStrip1);
            Controls.Add(dgFornecedor);
            Controls.Add(label11);
            Controls.Add(txtCEP);
            Controls.Add(label10);
            Controls.Add(txtCNPJ);
            Controls.Add(label9);
            Controls.Add(cbUF);
            Controls.Add(txtCidade);
            Controls.Add(txtTelefone);
            Controls.Add(txtNumero);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE FORNECEDORES";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgFornecedor).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label lblCnpjCheck;
        private MaskedTextBox txtCnpjPesq;
        private TextBox txtCodigo;
        private Button btnPesquisar;
        private GroupBox groupBox2;
        private Button btnInserir;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnImprimir;
        private Button btnAlterar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private MaskedTextBox txtTelefone;
        private TextBox txtCidade;
        private ComboBox cbUF;
        private Label label9;
        private MaskedTextBox txtCNPJ;
        private Label label10;
        private MaskedTextBox txtCEP;
        private Label label11;
        private DataGridView dgFornecedor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblHora;
    }
}