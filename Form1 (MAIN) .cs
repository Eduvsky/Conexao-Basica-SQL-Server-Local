using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGBD_Practice_SQL_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + path + @"Database.mdf';Integrated Security=True";

            string consult = "SELECT * FROM Filme";

            // Cria uma conexão, um tunel para acessar o Banco de dados 
            SqlConnection conection = new SqlConnection(connectionString);
            conection.Open();// <-- Aqui essa conexão / tunel é aberta

            // O Construtor dessa classe recebe dois parametros, a instrução SQL, e o tunel para envia-la
            SqlCommand comand = new SqlCommand(consult, conection);
            SqlDataReader leitor = comand.ExecuteReader(); // <-- Usamos esse comando para atribuir o valor do retorno na variavel leitor

            while(leitor.Read()) // <-- Posiciona o cursor de linhas na tabela
            {
                listbox.Items.Add(leitor["Nome"].ToString()); // <-- Para acessar um elemento da linha onde o leitor esta posicionado basta indicar o nome da coluna
            }
            leitor.Close();

            while (leitor.Read())
            {
                listbox.Items.Add(leitor["Id"].ToString());
            }

            // Aqui são fechadas as conexões
            leitor.Close();
            conection.Close();
        }
    }
}
