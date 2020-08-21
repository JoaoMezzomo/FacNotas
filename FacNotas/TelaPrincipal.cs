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
using System.Xml;

namespace FacNotas
{
    public partial class TelaPrincipal : Form
    {
        List<Disciplina> Disciplinas = new List<Disciplina>();

        public TelaPrincipal()
        {
            InitializeComponent();
            CarregarDisciplinas();
        }

        private bool VerificarSeExiste(string nome) 
        {
            bool retorno = false;
            string pathData = CriarArquivoData();

            XmlDocument documento = new XmlDocument();
            documento.Load(pathData);

            XmlNode root = documento.DocumentElement;

            XmlNodeList nodeDisciplinas = root.ChildNodes;

            if (nodeDisciplinas != null)
            {
                foreach (XmlNode nodeItem in nodeDisciplinas)
                {
                    if (nodeItem.SelectSingleNode("Nome").InnerXml == nome)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            
            return retorno;
        }

        private void Novo() 
        {
            int i = 1;
            bool nomeDisponivel = false;
            string novoNome = "";

            while (!nomeDisponivel)
            {
                string nome = "Disciplina" + i;

                if (!VerificarSeExiste(nome))
                {
                    novoNome = nome;
                    nomeDisponivel = true;
                }
                else
                {
                    i++;
                }
            }

            string pathData = CriarArquivoData();

            XmlDocument documento = new XmlDocument();
            documento.Load(pathData);

            XmlNode root = documento.DocumentElement;

            XmlNode nodeItem = documento.CreateElement("Item");
            XmlNode nodeNome = documento.CreateElement("Nome");
            XmlNode nodeA1 = documento.CreateElement("A1");
            XmlNode nodeA2 = documento.CreateElement("A2");
            XmlNode nodeA3 = documento.CreateElement("A3");
            XmlNode nodeA4 = documento.CreateElement("A4");
            XmlNode nodeA5 = documento.CreateElement("A5");
            XmlNode nodeA6 = documento.CreateElement("A6");

            nodeNome.InnerXml = novoNome;
            nodeA1.InnerXml = "";
            nodeA2.InnerXml = "";
            nodeA3.InnerXml = "";
            nodeA4.InnerXml = "";
            nodeA5.InnerXml = "";
            nodeA6.InnerXml = "";

            nodeItem.AppendChild(nodeNome);
            nodeItem.AppendChild(nodeA1);
            nodeItem.AppendChild(nodeA2);
            nodeItem.AppendChild(nodeA3);
            nodeItem.AppendChild(nodeA4);
            nodeItem.AppendChild(nodeA5);
            nodeItem.AppendChild(nodeA6);

            root.AppendChild(nodeItem);

            documento.Save(pathData);

            CarregarDisciplinas();
        }

        private void Excluir() 
        {
            if (listDisciplinas.SelectedIndex >= 0 && Disciplinas != null)
            {
                string disciplinaSelecionada = listDisciplinas.SelectedItem.ToString();

                string pathData = CriarArquivoData();

                XmlDocument documento = new XmlDocument();
                documento.Load(pathData);

                XmlNode root = documento.DocumentElement;

                XmlNodeList nodeDisciplinas = root.ChildNodes;

                if (nodeDisciplinas != null)
                {
                    foreach (XmlNode nodeItem in nodeDisciplinas)
                    {
                        if (nodeItem.SelectSingleNode("Nome").InnerXml == disciplinaSelecionada)
                        {
                            root.RemoveChild(nodeItem);

                            break;
                        }
                    }
                }

                documento.Save(pathData);

                CarregarDisciplinas();
            }
        }

        private void MostrarMensagem(string mensagem, string titulo) 
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK);
        }

        private void Salvar()
        {
            if (listDisciplinas.SelectedIndex >= 0 && Disciplinas != null)
            {
                string disciplinaSelecionada = listDisciplinas.SelectedItem.ToString();

                string pathData = CriarArquivoData();

                XmlDocument documento = new XmlDocument();
                documento.Load(pathData);

                XmlNode root = documento.DocumentElement;

                XmlNodeList nodeDisciplinas = root.ChildNodes;

                if (nodeDisciplinas != null)
                {
                    foreach (XmlNode nodeItem in nodeDisciplinas)
                    {
                        if (nodeItem.SelectSingleNode("Nome").InnerXml == disciplinaSelecionada)
                        {
                            if (disciplinaSelecionada != txtNome.Text && !string.IsNullOrEmpty(txtNome.Text))
                            {
                                nodeItem.SelectSingleNode("Nome").InnerXml = txtNome.Text;
                                disciplinaSelecionada = txtNome.Text;
                            }

                            nodeItem.SelectSingleNode("A1").InnerText = txtA1.Text;
                            nodeItem.SelectSingleNode("A2").InnerText = txtA2.Text;
                            nodeItem.SelectSingleNode("A3").InnerText = txtA3.Text;
                            nodeItem.SelectSingleNode("A4").InnerText = txtA4.Text;
                            nodeItem.SelectSingleNode("A5").InnerText = txtA5.Text;
                            nodeItem.SelectSingleNode("A6").InnerText = txtA6.Text;

                            MostrarMensagem("Alterações para a disciplina " + disciplinaSelecionada + " foram salvas!", "Alterações Salvas");

                            break;
                        }
                    }
                }

                documento.Save(pathData);

                CarregarDisciplinas();
            }
        }

        private void CalcularMediaTrabalho() 
        {
            if (!string.IsNullOrEmpty(txtA1.Text) && !string.IsNullOrEmpty(txtA2.Text) && !string.IsNullOrEmpty(txtA3.Text) && !string.IsNullOrEmpty(txtA4.Text))
            {
                double A1 = 0;
                double A2 = 0;
                double A3 = 0;
                double A4 = 0;

                if (double.TryParse(txtA1.Text, out A1) &&
                    double.TryParse(txtA2.Text, out A2) &&
                    double.TryParse(txtA3.Text, out A3) &&
                    double.TryParse(txtA4.Text, out A4))
                {
                    txtMediaT.Text = (((A1 + A2 + A3 + A4) / 4) * 0.4).ToString();
                }
                else
                {
                    txtMediaT.Text = "";
                }
            }
            else
            {
                txtMediaT.Text = "";
            }
        }

        private void CalcularMediaProva() 
        {
            if (!string.IsNullOrEmpty(txtA5.Text) || !string.IsNullOrEmpty(txtA6.Text))
            {
                double valor = 0;

                if (!string.IsNullOrEmpty(txtA6.Text))
                {
                    if (double.TryParse(txtA6.Text, out valor))
                    {
                        txtMediaP.Text = (valor * 0.6).ToString();
                    }
                    else
                    {
                        txtMediaP.Text = "";
                    }
                }
                else
                {
                    if (double.TryParse(txtA5.Text, out valor))
                    {
                        txtMediaP.Text = (valor * 0.6).ToString();
                    }
                    else
                    {
                        txtMediaP.Text = "";
                    }
                }
            }
            else
            {
                txtMediaP.Text = "";
            }
        }

        private void CalcularNotaFinal() 
        {
            //Color.Goldenrod;
            //Color.LightCoral;
            if (!string.IsNullOrEmpty(txtMediaP.Text) && !string.IsNullOrEmpty(txtMediaT.Text))
            {
                double mediaP = 0;
                double mediaT = 0;

                if (double.TryParse(txtMediaT.Text, out mediaT) && double.TryParse(txtMediaP.Text, out mediaP))
                {
                    txtNotaFinal.Text = (mediaP + mediaT).ToString();

                    if (Convert.ToDouble(txtNotaFinal.Text) >= 6)
                    {
                        txtMensagem.ForeColor = Color.Green;
                        txtMensagem.Text = "Aprovado!";
                    }
                    else
                    {
                        txtMensagem.ForeColor = Color.Red;
                        txtMensagem.Text = "Reprovado!";
                    }
                }
                else
                {
                    txtNotaFinal.Text = "";
                    txtMensagem.Clear();
                }
            }
            else
            {
                txtNotaFinal.Text = "";
                txtMensagem.Clear();
            }
        }

        private void Calcular() 
        {
            CalcularMediaTrabalho();
            CalcularMediaProva();
            CalcularNotaFinal();
        }

        private void MostrarValoresNaTela() 
        {
            if (listDisciplinas.SelectedIndex >= 0 && Disciplinas != null)
            {
                string disciplinaSelecionada = listDisciplinas.SelectedItem.ToString();

                foreach (Disciplina disciplina in Disciplinas)
                {
                    if (disciplina.Nome == disciplinaSelecionada)
                    {
                        txtNome.Text = disciplina.Nome;
                        txtA1.Text = disciplina.A1 >= 0 ? disciplina.A1.ToString() : "";
                        txtA2.Text = disciplina.A2 >= 0 ? disciplina.A2.ToString() : "";
                        txtA3.Text = disciplina.A3 >= 0 ? disciplina.A3.ToString() : "";
                        txtA4.Text = disciplina.A4 >= 0 ? disciplina.A4.ToString() : "";
                        txtA5.Text = disciplina.A5 >= 0 ? disciplina.A5.ToString() : "";
                        txtA6.Text = disciplina.A6 >= 0 ? disciplina.A6.ToString() : "";

                        Calcular();

                        break;
                    }
                }
            }
        }

        private void Limpar() 
        {
            Disciplinas.Clear();
            listDisciplinas.Items.Clear();

            txtA1.Clear();
            txtA2.Clear();
            txtA3.Clear();
            txtA4.Clear();
            txtA5.Clear();
            txtA6.Clear();
            txtMediaP.Clear();
            txtMediaT.Clear();
            txtNome.Clear();
            txtMensagem.Clear();
        }

        private void CarregarDisciplinas() 
        {
            string pathData = CriarArquivoData();
            string disciplinaSelecionada = "";

            if (listDisciplinas.SelectedIndex >= 0)
            {
                disciplinaSelecionada = listDisciplinas.SelectedItem.ToString();
            }

            if (disciplinaSelecionada != txtNome.Text && !string.IsNullOrEmpty(txtNome.Text))
            {
                disciplinaSelecionada = txtNome.Text;
            }

            XmlDocument documento = new XmlDocument();
            documento.Load(pathData);

            XmlNode root = documento.DocumentElement;

            XmlNodeList nodeDisciplinas = root.ChildNodes;

            Limpar();

            if (nodeDisciplinas != null)
            {
                foreach (XmlNode nodeItem in nodeDisciplinas)
                {
                    Disciplina novaDisciplina = new Disciplina();

                    novaDisciplina.Nome = nodeItem.SelectSingleNode("Nome").InnerXml;
                    novaDisciplina.A1 = !string.IsNullOrEmpty(nodeItem.SelectSingleNode("A1").InnerXml) ? Convert.ToDouble(nodeItem.SelectSingleNode("A1").InnerXml) : -1;
                    novaDisciplina.A2 = !string.IsNullOrEmpty(nodeItem.SelectSingleNode("A2").InnerXml) ? Convert.ToDouble(nodeItem.SelectSingleNode("A2").InnerXml) : -1;
                    novaDisciplina.A3 = !string.IsNullOrEmpty(nodeItem.SelectSingleNode("A3").InnerXml) ? Convert.ToDouble(nodeItem.SelectSingleNode("A3").InnerXml) : -1;
                    novaDisciplina.A4 = !string.IsNullOrEmpty(nodeItem.SelectSingleNode("A4").InnerXml) ? Convert.ToDouble(nodeItem.SelectSingleNode("A4").InnerXml) : -1;
                    novaDisciplina.A5 = !string.IsNullOrEmpty(nodeItem.SelectSingleNode("A5").InnerXml) ? Convert.ToDouble(nodeItem.SelectSingleNode("A5").InnerXml) : -1;
                    novaDisciplina.A6 = !string.IsNullOrEmpty(nodeItem.SelectSingleNode("A6").InnerXml) ? Convert.ToDouble(nodeItem.SelectSingleNode("A6").InnerXml) : -1;

                    Disciplinas.Add(novaDisciplina);
                }

                Disciplinas = Disciplinas.OrderBy(x => x.Nome).ToList();

                if (Disciplinas != null)
                {
                    foreach (Disciplina disciplinaParaLista in Disciplinas)
                    {
                        listDisciplinas.Items.AddRange(new object[] { disciplinaParaLista.Nome });
                    }
                }
            }

            if (!string.IsNullOrEmpty(disciplinaSelecionada))
            {
                for (int i = 0; i < listDisciplinas.Items.Count; i++)
                {
                    if (listDisciplinas.Items[i].ToString() == disciplinaSelecionada)
                    {
                        listDisciplinas.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private string CriarArquivoData() 
        {
            string path = Environment.CurrentDirectory + "\\Data.xml" ;

            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine("<Disciplinas>");
                    writer.Write("</Disciplinas>");
                }

            }

            return path;
        }

        private void TrocarCor(ref TextBox textBox) 
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (double.TryParse(textBox.Text, out double saida))
                {
                    double valor = Convert.ToDouble(textBox.Text);

                    if (valor > 6)
                    {
                        textBox.BackColor = Color.LimeGreen;
                    }
                    else if (valor == 6)
                    {
                        textBox.BackColor = Color.Goldenrod;
                    }
                    else if (valor < 6)
                    {
                        textBox.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void TrocarCorMediaP(ref TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (double.TryParse(textBox.Text, out double saida))
                {
                    double valor = Convert.ToDouble(textBox.Text);

                    if (valor > 3.6)
                    {
                        textBox.BackColor = Color.LimeGreen;
                    }
                    else if (valor == 3.6)
                    {
                        textBox.BackColor = Color.Goldenrod;
                    }
                    else if (valor < 3.6)
                    {
                        textBox.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void TrocarCorMediaT(ref TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (double.TryParse(textBox.Text, out double saida))
                {
                    double valor = Convert.ToDouble(textBox.Text);

                    if (valor > 2.4)
                    {
                        textBox.BackColor = Color.LimeGreen;
                    }
                    else if (valor == 2.4)
                    {
                        textBox.BackColor = Color.Goldenrod;
                    }
                    else if (valor < 2.4)
                    {
                        textBox.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void txtA1_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtA1);
            Calcular();
        }

        private void txtA2_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtA2);
            Calcular();
        }

        private void txtA3_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtA3);
            Calcular();
        }

        private void txtA4_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtA4);
            Calcular();
        }

        private void txtMediaT_TextChanged(object sender, EventArgs e)
        {
            TrocarCorMediaT(ref txtMediaT);
        }

        private void txtA5_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtA5);
            Calcular();
        }

        private void txtA6_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtA6);
            Calcular();
        }

        private void txtMediaP_TextChanged(object sender, EventArgs e)
        {
            TrocarCorMediaP(ref txtMediaP);
        }

        private void txtNotaFinal_TextChanged(object sender, EventArgs e)
        {
            TrocarCor(ref txtNotaFinal);
        }

        private void listDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarValoresNaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
