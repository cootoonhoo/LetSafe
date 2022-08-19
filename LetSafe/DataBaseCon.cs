using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace LetSafe
{
    static class DataBaseCon
    {
        private static string server = @"vps40251.publiccloud.com.br";
        private static string dataBase = "LetSafe";
        private static string user = "michel";
        private static string password = "michel";

        public static string StrCon
        {
            get
            {
                return $"Data Source ={server}; Integrated Security=false; Initial Catalog ={dataBase}; User ID= {user}; Password={password}";
            }
        }
        public static DataTable ResgatarRelatorio(string nomeTabela, string OrderByElemento)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"SELECT * FROM {nomeTabela} ORDER BY {OrderByElemento} DESC";
                    using (SqlDataAdapter DaAdpt = new SqlDataAdapter(SqlQuerry, DbCon))
                    {
                        DataTable dt = new DataTable();
                        DaAdpt.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
                return null;
            }
        }
        public static void CadastrarSegurado(string nome, string cpf, string email)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"INSERT INTO Segurado VALUES ('@nome', '@cpf', @'email')";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@nome", nome);
                        comand.Parameters.AddWithValue("@cpf", cpf);
                        comand.Parameters.AddWithValue("@email", email);
                    }

                }
                MessageBox.Show("Segurado Cadastrado com sucesso! {Debug}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
            }
        }
        public static void CadastrarEndereco(string logradouro, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"INSERT INTO endereco VALUES ('@logradouro', '@numero', '@complemento', '@bairro', '@cidade', '@uf', '@cep')";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@logradouro", logradouro);
                        comand.Parameters.AddWithValue("@numero", numero);
                        comand.Parameters.AddWithValue("@complemento", complemento);
                        comand.Parameters.AddWithValue("@bairro", bairro);
                        comand.Parameters.AddWithValue("@cidade", cidade);
                        comand.Parameters.AddWithValue("@uf", uf);
                        comand.Parameters.AddWithValue("@cep", cep);
                    }

                }
                MessageBox.Show("Endereco cadastrado com sucesso! {Debug}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
            }
        }

        public static DataTable ConsultaCliente(string cpf)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"SELECT * FROM segurado WHERE cpf = {cpf}";
                    using (SqlDataAdapter DaAdpt = new SqlDataAdapter(SqlQuerry, DbCon))
                    {
                        DataTable dt = new DataTable();
                        DaAdpt.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
                return null;
            }
        }

        public static void DeletaCliente(string cpf)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"DELETE FROM segurado WHERE cpf = {cpf}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
            }
        }

        public static void EditaCliente(string cpf)
        {
           
        }
    }
}
