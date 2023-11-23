namespace ProjetoImpress
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImprimir = new Button();
            printDialog1 = new PrintDialog();
            label3 = new Label();
            txtIdade = new DateTimePicker();
            lblIdade = new Label();
            groupBox1 = new GroupBox();
            btnVisualizar = new Button();
            btnSelecionarArq = new Button();
            btnSalvar = new Button();
            btnSelecionarPasta = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 51);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 101);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 1;
            label2.Text = "E-MAIL:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(133, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(624, 39);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(624, 39);
            txtEmail.TabIndex = 3;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImprimir
            // 
            btnImprimir.Image = Properties.Resources.Printer_modern;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(361, 225);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(186, 52);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.TextAlign = ContentAlignment.MiddleRight;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 141);
            label3.Name = "label3";
            label3.Size = new Size(266, 32);
            label3.TabIndex = 5;
            label3.Text = "DATA DE NASCIMENTO:";
            // 
            // txtIdade
            // 
            txtIdade.Format = DateTimePickerFormat.Short;
            txtIdade.Location = new Point(288, 136);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(282, 39);
            txtIdade.TabIndex = 6;
            txtIdade.ValueChanged += txtIdade_ValueChanged;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(576, 141);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(19, 32);
            lblIdade.TabIndex = 7;
            lblIdade.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblIdade);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 195);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS CADASTRAIS";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Image = Properties.Resources.Zoom;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(12, 225);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(186, 52);
            btnVisualizar.TabIndex = 9;
            btnVisualizar.Text = "VISUALIZAR";
            btnVisualizar.TextAlign = ContentAlignment.MiddleRight;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnSelecionarArq
            // 
            btnSelecionarArq.Image = Properties.Resources.Folder;
            btnSelecionarArq.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelecionarArq.Location = new Point(553, 225);
            btnSelecionarArq.Name = "btnSelecionarArq";
            btnSelecionarArq.Size = new Size(254, 52);
            btnSelecionarArq.TabIndex = 10;
            btnSelecionarArq.Text = "ABRIR ARQUIVOS";
            btnSelecionarArq.TextAlign = ContentAlignment.MiddleRight;
            btnSelecionarArq.UseVisualStyleBackColor = true;
            btnSelecionarArq.Click += btnSelecionar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.Disquette;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(204, 225);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(151, 52);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSelecionarPasta
            // 
            btnSelecionarPasta.Image = Properties.Resources.Folder_docs;
            btnSelecionarPasta.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelecionarPasta.Location = new Point(553, 283);
            btnSelecionarPasta.Name = "btnSelecionarPasta";
            btnSelecionarPasta.Size = new Size(254, 58);
            btnSelecionarPasta.TabIndex = 12;
            btnSelecionarPasta.Text = "ABRIR PASTAS";
            btnSelecionarPasta.UseVisualStyleBackColor = true;
            btnSelecionarPasta.Click += btnSelecionarPasta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 309);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 354);
            Controls.Add(label4);
            Controls.Add(btnSelecionarPasta);
            Controls.Add(btnSalvar);
            Controls.Add(btnSelecionarArq);
            Controls.Add(btnVisualizar);
            Controls.Add(groupBox1);
            Controls.Add(btnImprimir);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtEmail;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnImprimir;
        private PrintDialog printDialog1;
        private Label label3;
        private DateTimePicker txtIdade;
        private Label lblIdade;
        private GroupBox groupBox1;
        private Button btnVisualizar;
        private Button btnSelecionarArq;
        private Button btnSalvar;
        private Button btnSelecionarPasta;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label4;
    }
}