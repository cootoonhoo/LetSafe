using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            cpf = cpf.Replace("-", "");
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"INSERT INTO Segurado VALUES (@nome, @cpf, @email, 1)";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@nome", nome);
                        comand.Parameters.AddWithValue("@cpf", cpf);
                        comand.Parameters.AddWithValue("@email", email);
                        comand.ExecuteNonQuery();
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
                    var SqlQuerry = $"INSERT INTO endereco VALUES (@logradouro, @numero, @complemento, @bairro, @cidade, @uf, @cep)";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@logradouro", logradouro);
                        comand.Parameters.AddWithValue("@numero", numero);
                        comand.Parameters.AddWithValue("@complemento", complemento);
                        comand.Parameters.AddWithValue("@bairro", bairro);
                        comand.Parameters.AddWithValue("@cidade", cidade);
                        comand.Parameters.AddWithValue("@uf", uf);
                        comand.Parameters.AddWithValue("@cep", cep);
                        comand.ExecuteNonQuery();
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

        public static void EditaSegurado(string nome, string novoCpf, string email, string antigoCpf)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"UPDATE segurado SET (@nome, @cpf, @email, 1) WHERE cpf = {antigoCpf}";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@nome", nome);
                        comand.Parameters.AddWithValue("@cpf", novoCpf);
                        comand.Parameters.AddWithValue("@email", email);
                        comand.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Dados editados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
            }
        }

        public static void EditaEndereço(string logradouro, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"UPDATE endereco SET (@logradouro, @numero, @complemento, @bairro, @cidade, @uf, @cep)";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@logradouro", logradouro);
                        comand.Parameters.AddWithValue("@numero", numero);
                        comand.Parameters.AddWithValue("@complemento", complemento);
                        comand.Parameters.AddWithValue("@bairro", bairro);
                        comand.Parameters.AddWithValue("@cidade", cidade);
                        comand.Parameters.AddWithValue("@uf", uf);
                        comand.Parameters.AddWithValue("@cep", cep);
                        comand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
            }
        }
        public static void CadastrarApolice(decimal valorSeguro, DateTime InicioVig, DateTime FimVig)
        {
            int Num1, Num2;
            Num1 = new Random().Next(1, 1000);
            Num2 = new Random().Next(1, 1000);

            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = $"INSERT INTO Apolice VALUES (@ValorSeguro, @InicioVig, @FimVig, @Produto, @Segurado)";
                    using (SqlCommand comand = new SqlCommand(SqlQuerry, DbCon))
                    {
                        comand.Parameters.AddWithValue("@ValorSeguro", valorSeguro);
                        comand.Parameters.AddWithValue("@InicioVig", InicioVig);
                        comand.Parameters.AddWithValue("@FimVig", FimVig);
                        comand.Parameters.AddWithValue("@Produto", Num1);
                        comand.Parameters.AddWithValue("@Segurado", Num2);
                        comand.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Segurado Cadastrado com sucesso! {Debug}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
            }
        }
        public static int IdUltimoSegurado()
        {
            using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
            {
                DbCon.Open();
                var SqlQuerry = $"SELECT TOP 1 id_segurado FROM segurado ORDER BY id_segurado DESC;";
                using (SqlDataAdapter DaAdpt = new SqlDataAdapter(SqlQuerry, DbCon))
                {
                    DataTable dt = new DataTable();
                    DaAdpt.Fill(dt);
                    return int.Parse(dt.Rows[0][0].ToString());
                }
            }
        }
        public static int IdSeguradoPorCpf(string CPF)
        {
            CPF = CPF.Replace("-", "");
            using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
            {
                DbCon.Open();
                var SqlQuerry = $"SELECT  * FROM segurado WHERE CPF = {CPF};";
                using (SqlDataAdapter DaAdpt = new SqlDataAdapter(SqlQuerry, DbCon))
                {
                    DataTable dt = new DataTable();
                    DaAdpt.Fill(dt);
                    return int.Parse(dt.Rows[0][0].ToString());
                }
            }
        }

        public static bool ClienteCadastrado(string cpf)
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

                        if (dt.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao conectar\n" + ex.Message);
                return false;
            }
        }

        public static List<string> ApolicesSegurado(string cpf)
        {
            List<string> apolices = new List<string>();

            using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
            {
                DbCon.Open();
                var SqlQuerry = $"SELECT id_apolice, nome_produto from Apolice a LEFT JOIN segurado s ON s.id_segurado = a.id_segurado LEFT JOIN Produtos p ON p.id_produto = a.id_produto WHERE cpf = {cpf} AND a.fim_vigencia >= GETDATE();";
                using (SqlDataAdapter DaAdpt = new SqlDataAdapter(SqlQuerry, DbCon))
                {
                    DataTable dt = new DataTable();
                    DaAdpt.Fill(dt);

                    int numApolices = dt.Rows.Count;

                    for (int i = 0; i < numApolices; i++ )
                    {
                        apolices.Add($"{dt.Rows[i][0]} - {dt.Rows[i][1]}");
                    }

                    return apolices;                    
                }
            }
        }

        public static DataTable ConsultaApolicesSegurados(string cpf)
        {

            try
            {
                using (SqlConnection DbCon = new SqlConnection(DataBaseCon.StrCon))
                {
                    DbCon.Open();
                    var SqlQuerry = @$"SELECT id_apolice,nome_produto FROM Apolice
INNER JOIN Produtos on Apolice.id_produto = Produtos.id_produto
WHERE id_segurado = (SELECT id_segurado FROM segurado WHERE cpf = {cpf}
                    AND Apolice.fim_vigencia >= GETDATE()); ";
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
                throw ex;
            }
        }
            
            
    }
}