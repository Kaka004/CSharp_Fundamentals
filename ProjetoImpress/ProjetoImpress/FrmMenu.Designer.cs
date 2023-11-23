namespace ProjetoImpress
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            gerenciarVendasToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeClientesToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, vendasToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1670, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedoresToolStripMenuItem, funcionáriosToolStripMenuItem, produtosToolStripMenuItem, toolStripSeparator1, sairToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = Properties.Resources.btNovo;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(136, 34);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.btUsuario;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(219, 34);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Image = Properties.Resources.group_32;
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(219, 34);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Image = Properties.Resources.btClientes;
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(219, 34);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Image = Properties.Resources.basket;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(219, 34);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(216, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.btSai3;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(219, 34);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarVendasToolStripMenuItem });
            vendasToolStripMenuItem.Image = Properties.Resources.finance_32;
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(111, 34);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // gerenciarVendasToolStripMenuItem
            // 
            gerenciarVendasToolStripMenuItem.Image = Properties.Resources.Billing;
            gerenciarVendasToolStripMenuItem.Name = "gerenciarVendasToolStripMenuItem";
            gerenciarVendasToolStripMenuItem.Size = new Size(255, 34);
            gerenciarVendasToolStripMenuItem.Text = "Gerenciar Vendas";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeClientesToolStripMenuItem, relatórioDeProdutosToolStripMenuItem, relatórioDeVendasToolStripMenuItem });
            relatóriosToolStripMenuItem.Image = Properties.Resources.btRel;
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(136, 34);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeClientesToolStripMenuItem
            // 
            relatórioDeClientesToolStripMenuItem.Image = Properties.Resources.blueprint2;
            relatórioDeClientesToolStripMenuItem.Name = "relatórioDeClientesToolStripMenuItem";
            relatórioDeClientesToolStripMenuItem.Size = new Size(296, 34);
            relatórioDeClientesToolStripMenuItem.Text = "Relatório de Clientes";
            // 
            // relatórioDeProdutosToolStripMenuItem
            // 
            relatórioDeProdutosToolStripMenuItem.Image = Properties.Resources.blueprint3;
            relatórioDeProdutosToolStripMenuItem.Name = "relatórioDeProdutosToolStripMenuItem";
            relatórioDeProdutosToolStripMenuItem.Size = new Size(296, 34);
            relatórioDeProdutosToolStripMenuItem.Text = "Relatório de Produtos";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Image = Properties.Resources.blueprint4;
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(296, 34);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MARKETING_PESSOAL;
            pictureBox1.Location = new Point(0, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1670, 977);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1670, 937);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA TECH TI26 - TEAM";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem gerenciarVendasToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeClientesToolStripMenuItem;
        private ToolStripMenuItem relatórioDeProdutosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}