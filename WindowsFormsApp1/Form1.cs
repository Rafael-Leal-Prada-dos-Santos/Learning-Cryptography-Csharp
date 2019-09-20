using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string arqLe;
        private string arqSaida;
        private void btn_Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarArquivo = new OpenFileDialog();
            selecionarArquivo.DefaultExt = "txt";
            selecionarArquivo.CheckFileExists = true;
            selecionarArquivo.CheckPathExists = true;
            selecionarArquivo.InitialDirectory = @"C:\";
        
            selecionarArquivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;
            if (selecionarArquivo.ShowDialog() == DialogResult.OK) {
                arqLe = selecionarArquivo.FileName;
                txtArquivoLeitura.Text = arqLe;
                
            }

        }

        private void btnChose2_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarArquivo = new OpenFileDialog();
            selecionarArquivo.DefaultExt = "txt";            
            selecionarArquivo.InitialDirectory = @"C:\";
            selecionarArquivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;

            if (selecionarArquivo.ShowDialog() == DialogResult.OK)
            {
                arqSaida = selecionarArquivo.FileName;
                txtArquivoSaida.Text = arqSaida;            
                            
                
            }
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChave.Text) && txtChave.Text.Length == 8 && !string.IsNullOrEmpty(arqLe) && !string.IsNullOrEmpty(arqSaida))
            {
                try
                {


                    FileStream le = new FileStream(arqLe, FileMode.Open);
                    BinaryReader br = new BinaryReader(le);


                    byte[] arquivoAnterior = br.ReadBytes((int)le.Length);
                    char[] textoAnterior = Encoding.UTF8.GetString(arquivoAnterior).ToCharArray();
                    char[] textoCriptografado = new char[textoAnterior.Length];

                    char[] textoChave = txtChave.Text.ToCharArray();
                    long valorChave = 0;

                    for (int i = 0; i < textoChave.Length; i++)
                    {
                        long valorIndice = textoChave[i];
                        valorChave += valorIndice;
                    }


                    //string vetor = "guhwqkljo;adughj;oiu1234690@#$&()";
                    //char[] charVetor = vetor.ToCharArray();

                    char[,] subBytes = new char[8, 8] {

                        { '!', '´', 'ç', 'ô', 'A', ',', '~', '[' },
                        { 'l', 'î', 'Ö', 'B', 'ƒ', 'Ñ', 'Ñ', 'a'},
                        { '£', 'l', 'Ê', '0', 'ú', 'z', 'æ', '{' },
                        { '}', '2', 'P', 'z', '|', ']', '%', '&' },
                        { '$', '*', '<', '.', 'B', 'h', 'o', '?' },
                        { 'j', '#', '@', 'C', 'v', '6', ':', '-' },
                        { ';', 'K', 'V', 'û', 'f', 't', 'T', 'R' },
                        { '=', 'G', 'L', 'S', 'y', 'W', '7', '9' }
                    };


                    for (int i = 0; i < textoAnterior.Length;)
                    {

                        int l = 0;
                        int c = i;

                        //if ((c < subBytes.GetLength(0)))
                        //{

                        //    char valorVetor = subBytes[l, c];

                        //    textoCriptografado[i] = (char)((arquivoAnterior[i] + valorVetor) * (valorChave));

                        //    c++;
                        //}
                        //else if (!(l < subBytes.GetLength(1)))
                        //{
                        //    c = 0;
                        //    l = 0;
                        //}
                        //else
                        //{
                        //    l++;
                        //    c = 0;
                        //}

                        while ((c < subBytes.GetLength(0)) && ( i < textoAnterior.Length))
                        {

                            char valorVetor = subBytes[l, c];

                            textoCriptografado[i] = (char)(arquivoAnterior[i] + valorVetor + valorChave);

                            c++;
                            i++;

                            if (!(c < subBytes.GetLength(0)) && (l < subBytes.GetLength(1)) ) {
                                c = 0;
                                l++;
                                i++;
                            }
                            if (!( l < subBytes.GetLength(1) )){
                                l = 0;
                                c = 0;
                            }

                        }

                                       
                         
                            
                        
                        


                    }

                    //Criptografia antiga

                    //for (int i = 0; i < textoCriptografado.Length; i++)
                    //{
                    //    for (int v = 0; v < charVetor.Length; v++)
                    //    {

                    //        for (int k = 0; k < chave.Length; k++)
                    //        {
                    //            textoCriptografado[i] = (char)((arquivoAnterior[i] * charVetor[v]) + chave[k]);
                    //        }

                    //    }
                    //}

                    FileStream escreve = new FileStream(arqSaida, FileMode.Open);
                    BinaryWriter bw = new BinaryWriter(escreve);

                    bw.Write(textoCriptografado);


                    MessageBox.Show("Criptografia Bem Sucedida!");

                    le.Close();
                    escreve.Close();
                    br.Close();
                    bw.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(arqLe))
            {

                MessageBox.Show("Arquivo não escolhido, Selecione  o Arquivo a ser criptografado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(arqSaida))
            {

                MessageBox.Show("Arquivo não escolhido, Selecione  o arquivo de saída ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtChave.Text))
            {

                MessageBox.Show(" Chave não pode estar vazia, Digite uma chave. ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                MessageBox.Show("A chave tem que conter 8 dígitos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }
    }
}
