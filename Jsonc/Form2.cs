using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Jsonc
{
    public partial class dtg_view : Form


    {
        public List<Cliente> clientes = new List<Cliente>(); //lista para armazenar os objetos

        public dtg_view()
        {
            InitializeComponent();
            CarregarDados();

        }

       
        private void CarregarDados()
        {
            try
            {
                if (File.Exists(@"c:/dados/arquivos.json"))
                {
                    string json = File.ReadAllText(@"c:/dados/arquivos.json");
                    clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
                    dgt_view.DataSource = null;
                    dgt_view.Refresh();
                    dgt_view.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            //Limpando as celulas

            tx_nome.Clear();
            tx_email.Clear();
            tx_telefone.Clear();
            tx_nascimento.Clear();
            tx_endereco.Clear();
            tx_cpf.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                // Cria uma nova instância da classe "Cliente" e preenche suas propriedades
                var cliente = new Cliente();
                cliente.Nome = tx_nome.Text;
                cliente.Email = tx_email.Text;

                if(Validacoes.ValidaCpf(tx_cpf.Text) == true)
                {
                    cliente.Cpf = tx_cpf.Text;
                    cliente.Datanascimento = Convert.ToDateTime(tx_nascimento.Text);
                    cliente.Telefone = tx_telefone.Text;
                    cliente.Endereço = tx_endereco.Text;

                    clientes.Add(cliente);

                    string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                    File.WriteAllText(@"c:/dados/arquivos.json", json);

                    dgt_view.DataSource = null;
                    dgt_view.Refresh();
                    dgt_view.DataSource = clientes;

                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Cpf inválido.");
                }
                //cliente.Cpf = tx_cpf.Text;
                //cliente.Datanascimento = Convert.ToDateTime(tx_nascimento.Text);
                //cliente.Telefone = tx_telefone.Text;
                //cliente.Endereço = tx_endereco.Text;
                
                //clientes.Add(cliente);

         

                //string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                //File.WriteAllText(@"c:/dados/arquivos.json", json);

                //dgt_view.DataSource = null;
                //dgt_view.Refresh();
                //dgt_view.DataSource = clientes;

                //MessageBox.Show("Arquivo salvo");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha " + ex.Message);


            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (dgt_view.SelectedRows.Count > 0)
            {
                int rowIndex = dgt_view.SelectedRows[0].Index;

                Cliente clienteParaExcluir = (Cliente)dgt_view.SelectedRows[0].DataBoundItem;

                clientes.Remove(clienteParaExcluir);

                string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                File.WriteAllText(@"c:/dados/arquivos.json", json);

                dgt_view.DataSource = null;
                dgt_view.DataSource = clientes;

                MessageBox.Show("Registro excluído.");
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para exclusão.");
            }
        }

       
    }
}