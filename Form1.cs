using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace controleMedicamental
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //Inicia a cinexão com o banco de dados
        string connectionString = "server=localhost; user id=root; password= ; database=db_medical;";

        private void Form1_Load(object sender, EventArgs e)
        {
            text_descri.Text = "Lista de medicamentos com 30 dias para vencer!";
            //Inicia a cinexão com o banco de dados
            MySqlConnection objcon = new MySqlConnection(connectionString);
            //Abre o banco de dados
            objcon.Open();

            MySqlCommand SELECT = objcon.CreateCommand();
            SELECT.CommandText = "SELECT lote_medic, nome_medic FROM dados WHERE data_venc <= DATE_ADD(now(), INTERVAL 30 DAY);";
            MySqlDataReader reader = SELECT.ExecuteReader();

            SELECT.CommandType = CommandType.Text;

            int nColunas = reader.FieldCount;

            for (int i = 0; i < nColunas; i++)
            {
                dataGridView1.Columns.Add(reader.GetName(i).ToString(), reader.GetName(i).ToString());
            }

            //define um array de strings com nCOlunas

            string[] linhaDados = new string[nColunas];
            //percorre o DataRead
            while (reader.Read())

            {

                //percorre cada uma das colunas

                for (int a = 0; a < nColunas; a++)

                {

                    //verifica o tipo de dados da coluna

                    if (reader.GetFieldType(a).ToString() == "System.Int32")

                    {

                        linhaDados[a] = reader.GetInt32(a).ToString();

                    }

                    if (reader.GetFieldType(a).ToString() == "System.String")

                    {

                        linhaDados[a] = reader.GetString(a).ToString();

                    }

                    if (reader.GetFieldType(a).ToString() == "System.DateTime")

                    {

                        linhaDados[a] = reader.GetDateTime(a).ToString();

                    }

                }

                //atribui a linha ao datagridview

                dataGridView1.Rows.Add(linhaDados);
            }

            objcon.Close();
    }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicia a cinexão com o banco de dados
                MySqlConnection objcon = new MySqlConnection(connectionString);
                //Abre o banco de dados
                objcon.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO dados(cd_medic, lote_medic, nome_medic, data_entra, data_fab, data_venc) VALUES (null, @lote_medic, @nome_medic, @data_entra, @data_fab, @data_venc)",objcon);
                INSERT.Parameters.AddWithValue("@lote_medic", textLote.Text);
                INSERT.Parameters.AddWithValue("@nome_medic", textNome.Text);
                INSERT.Parameters.AddWithValue("@data_entra", dateEntrada.Value);
                INSERT.Parameters.AddWithValue("@data_fab", dateFabrica.Value);
                INSERT.Parameters.AddWithValue("@data_venc", dateVenci.Value);
                INSERT.ExecuteNonQuery();
                //Mensagem se a conexao foi bem sucedida
                MessageBox.Show("Sucesso!");


                //fecha a conexao
                objcon.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar! " + erro);
                
            }
        }

        private void btn_atualiza_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
             //Inicia a cinexão com o banco de dados
            MySqlConnection objcon = new MySqlConnection(connectionString);
            //Abre o banco de dados
            objcon.Open();

            MySqlCommand SELECT = objcon.CreateCommand();
            SELECT.CommandText = "SELECT lote_medic, nome_medic FROM dados WHERE data_venc <= DATE_ADD(now(), INTERVAL 30 DAY);";
            MySqlDataReader reader = SELECT.ExecuteReader();

            SELECT.CommandType = CommandType.Text;

            int nColunas = reader.FieldCount;

            for (int i = 0; i< nColunas; i++)
            {
                dataGridView1.Columns.Add(reader.GetName(i).ToString(), reader.GetName(i).ToString());
            }

            //define um array de strings com nCOlunas

            string[] linhaDados = new string[nColunas];
            //percorre o DataRead
            while (reader.Read())

            {

                //percorre cada uma das colunas

                for (int a = 0; a < nColunas; a++)

                {

                    //verifica o tipo de dados da coluna

                    if (reader.GetFieldType(a).ToString() == "System.Int32")

                    {

                        linhaDados[a] = reader.GetInt32(a).ToString();

                    }

                    if (reader.GetFieldType(a).ToString() == "System.String")

                    {

                        linhaDados[a] = reader.GetString(a).ToString();

                    }

                    if (reader.GetFieldType(a).ToString() == "System.DateTime")

                    {

                        linhaDados[a] = reader.GetDateTime(a).ToString();

                    }

                }

                //atribui a linha ao datagridview

                dataGridView1.Rows.Add(linhaDados);
            }

        objcon.Close();
        }
    }
}
