using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ListaArquivos
{
    public partial class frmListarArquivos : Form
    {
        private bool bloquearFirewall = false;

        public frmListarArquivos()
        {
            InitializeComponent();
        }

        private bool SelecionarDiretorio()
        {
            bool status = false;

            if (fbdSelecionarDiretorio.ShowDialog() == DialogResult.OK)
            {
                txtbxCaminho.Text = fbdSelecionarDiretorio.SelectedPath;
                status = true;
            }
            else
            {
                MessageBox.Show("É necessário selecionar uma pasta");
            }

            return status;
        }

        private void ListarArquivos(string tiposArquivos)
        {
            //Inicialização da quantidade de arquivos
            int qtdeArquivos = 0;

            //limpando o conteúdo do RichText
            rchtxtArquivos.Clear();
            
            //configurando o diretório a ser listado
            DirectoryInfo directoryInfo = new DirectoryInfo(txtbxCaminho.Text);

            //Pesquisando arquivos no diretório informado e armazenando em um array de arquivos
            FileInfo[] fileInfos = directoryInfo.GetFiles(tiposArquivos);

            //Para cada arquivo encontrado em fileinfos... adicione-o no richtext
            foreach (FileInfo file in fileInfos)
            {
                //Adiciona o arquivo encontrado no Richtext
                rchtxtArquivos.AppendText(file.Name + Environment.NewLine);

                //verifica se é para bloquear o arquivo no firewall
                if (bloquearFirewall) {
                    //bloquear está habilitado, então envia o caminho e o nome do arquivo para adicionar a regra de bloqueio de saída no firewall
                    BloquearSaidaProgramasFirewall(txtbxCaminho.Text, file.Name);
                }
                
                //Incrementa a quantidade de arquivos encontrados
                qtdeArquivos++;

                //Configurando a quantidade de arquivos no Label
                lblQuantidade.Text = "Quantidade de Arquivos: " + qtdeArquivos.ToString();
            }
        }

        private void BloquearSaidaProgramasFirewall(string caminho, string arquivo)
        {
            string caminhoCompleto = Path.Combine(caminho, arquivo);

            //montando o comando para fazer o bloqueio no firewal avançado do windows 
            string comando = "netsh advfirewall firewall add rule name=\"" + arquivo + "\" dir=out action=block profile=any protocol=any program=\"" + caminhoCompleto + "\" enable=yes";

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                UseShellExecute = true,

                WorkingDirectory = @"C:\Windows\System32",

                FileName = @"C:\Windows\System32\cmd.exe",

                Verb = "runas",

                Arguments = "/c " + comando,

                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process.Start(processStartInfo);
        }

        private void SalvarResultado()
        {
            //salvando o conteúdo do Richtext (listagem no arquivos) em um arquivo
            rchtxtArquivos.SaveFile(txtbxCaminho.Text + @"\listagem.txt", RichTextBoxStreamType.PlainText);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            bool selecionarProgramas = false;
            bool selecionarResultado = false;

            //verificando qual botão está chamando
            switch (btn.Name){
                case "btnListar": 
                    {
                        bloquearFirewall = false;
                        break;
                    }
                case "btnSaidaFirewall":
                    {
                        bloquearFirewall = true;
                        break;
                    }
            }

            //Selecionar o diretório a ser pesquisado
            selecionarProgramas = SelecionarDiretorio();

            if (selecionarProgramas)
            {
                switch (bloquearFirewall)
                {
                    case true :
                        {
                            ListarArquivos("*.exe");
                            break;
                        }
                    case false :
                        {
                            ListarArquivos("*.*");
                            MessageBox.Show("Informe o caminho onde deseja salvar o arquivo texto.");

                            //Selecionar o diretório onde será salvo o arquivo texto
                            selecionarResultado = SelecionarDiretorio();

                            if (selecionarResultado)
                            {
                                //Salva a listagem de arquivos em um arquivo texto no local previamente escolhido na etapa anterior
                                SalvarResultado();
                            }
                            break;
                        }
                }
            }
        }
    }
}
