using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProjetoImpress
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
            // Inicializar os componentes
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            // Configurar o PrintPreviewDialog
            printPreviewDialog1.Document = printDocument;

            // Configurar o OpenFileDialog
            openFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";

            // Configurar o SaveFileDialog
            saveFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Definir o conteúdo a ser impresso
            string conteudo = $"Nome: {txtNome.Text}\nIdade: {lblIdade.Text}" +
                $"\nEmail: {txtEmail.Text}";

            // Definir a fonte e as coordenadas para impressão
            Font fonte = new Font("Arial", 12);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Imprimir o conteúdo
            e.Graphics.DrawString(conteudo, fonte, Brushes.Black, x, y);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        //ignorar a linha 51 
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                // Carregar os dados do arquivo selecionado nos campos
                string[] linhas = File.ReadAllLines(filePath);
                if (linhas.Length >= 3)
                {
                    txtNome.Text = linhas[0];
                    lblIdade.Text = linhas[1];
                    txtEmail.Text = linhas[2];
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;

                // Salvar os dados nos campos em um arquivo
                string[] linhas = { txtNome.Text, lblIdade.Text, txtEmail.Text };
                File.WriteAllLines(filePath, linhas);
            }
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Fazer algo com o diretório selecionado, se necessário
                string selectedFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtIdade_ValueChanged(object sender, EventArgs e)
        {
            //CALCULAR A IDADE E ATRIBUIR PARA A LBLIDADE
            int anoNascimento, idade;
            string ano;
            ano = txtIdade.Value.ToString();
            ano = ano.Substring(6, 4);
            //label4.Text = ano;
            anoNascimento = Convert.ToInt32(ano);
            idade = DateTime.Now.Year - anoNascimento;
            lblIdade.Text = idade.ToString() + " anos";
        }
    }
}