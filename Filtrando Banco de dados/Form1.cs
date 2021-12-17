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
using System.IO;

namespace Exercício03
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            string dataBasePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + dataBasePath + @"Colegio.mdf';Integrated Security=True";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* TO-DO:
             * 
             * Assim que o formulário for carregado é necessário que a ComboBox da Turma
             * seja preenchida com todos os nomes de turmas possíveis.
             */

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string GetTurma = "SELECT * FROM Turma";
                SqlCommand GetNomesTurma = new SqlCommand(GetTurma, connection);

                using (SqlDataReader reader2 = GetNomesTurma.ExecuteReader())
                {
                    while (reader2.Read())
                    cmbClass.Items.Add(Convert.ToString(reader2["Nome"]));
                }
            }                
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlStatement = "SELECT * FROM Aluno";
                    SqlCommand command = new SqlCommand(sqlStatement, connection);
                    
                    
                    if (chkFilter.Checked == true && radMale.Checked == true) // Filtro masculino
                    {
                        SqlCommand radmale = new SqlCommand("SELECT * FROM Aluno WHERE Sexo LIKE 'M'", connection);

                        if (txtInitial.Text != string.Empty)
                        {
                            SqlCommand RadmaleInitial = new SqlCommand("SELECT * FROM Aluno WHERE Sexo LIKE 'M' AND Nome LIKE '" + txtInitial.Text + "%'", connection);

                            using (SqlDataReader reader = RadmaleInitial.ExecuteReader())
                            {
                                while (reader.Read())
                                    lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                            }
                        }

                        else if (txtInitial.Text == string.Empty)
                        {
                            using (SqlDataReader reader = radmale.ExecuteReader())
                            {
                                while (reader.Read())
                                    lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                            }
                        }
                        
                    }

                    if (chkFilter.Checked == true && radFemale.Checked == true) // Filtro feminino
                    {
                        SqlCommand radfemale = new SqlCommand("SELECT * FROM Aluno WHERE Sexo LIKE 'F'", connection);

                        if (txtInitial.Text != string.Empty)
                        {
                            SqlCommand RadmaleInitial = new SqlCommand("SELECT * FROM Aluno WHERE Sexo LIKE 'F' AND Nome LIKE '" + txtInitial.Text + "%'", connection);

                            using (SqlDataReader reader = RadmaleInitial.ExecuteReader())
                            {
                                while (reader.Read())
                                    lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                            }
                            
                        }
                        else if (txtInitial.Text == string.Empty)
                        {
                            using (SqlDataReader reader = radfemale.ExecuteReader())
                            {
                                while (reader.Read())
                                    lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                            }
                        }
                        
                    }

                    if (chkFilter.Checked == false)
                    {
                        if (txtInitial.Text != string.Empty)
                        {
                            SqlCommand RadmaleInitial = new SqlCommand("SELECT * FROM Aluno WHERE Nome LIKE '" + txtInitial.Text + "%'");

                            using (SqlDataReader reader = RadmaleInitial.ExecuteReader())
                            {
                                while (reader.Read())
                                    lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                            }
                        }

                        else if (txtInitial.Text == string.Empty)
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                    lstNames.Items.Add(Convert.ToString(reader["Nome"]));
                            }
                        }
                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
