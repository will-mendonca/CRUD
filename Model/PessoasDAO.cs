using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Model
{
    public class PessoasDAO
    {
        public readonly SqlConnection _conn;
        public readonly SqlTransaction _trans;
        public PessoasDAO(SqlConnection conn, SqlTransaction trans)
        {
            _conn = conn;
            _trans = trans;
        }

        public void AdicionarPessoa(PessoasModel pessoa)
        {
            string sqlInsert = @"INSERT INTO PESSOAS(NOME, IDADE, EMAIL, ENDERECO) VALUES(@nome, @idade, @email, @endereco)";
            SqlCommand cmd = new SqlCommand(sqlInsert, _conn, _trans);
            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@idade", pessoa.Idade);
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
            cmd.Parameters.AddWithValue("@endereco", pessoa.Endereco);
            cmd.ExecuteNonQuery();
        }

        public List<PessoasModel> CarregaLista()
        {
            string sql = @"SELECT ID, NOME, IDADE, EMAIL, ENDERECO FROM PESSOAS";
            SqlCommand cmd = new SqlCommand(sql, _conn, _trans);
            var listaPessoas = new List<PessoasModel>();
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    PessoasModel pessoas = new PessoasModel()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Nome = reader["NOME"].ToString(),
                        Idade = Convert.ToInt32(reader["IDADE"]),
                        Email = reader["EMAIL"].ToString(),
                        Endereco = reader["ENDERECO"].ToString()
                    };
                    listaPessoas.Add(pessoas);
                }
            }
            return listaPessoas;
        }
        public void RemoverPessoas(int id)
        {
            string sqlDelete = $@"DELETE FROM PESSOAS WHERE ID = {id}";
            SqlCommand cmd = new SqlCommand(sqlDelete, _conn, _trans);
            cmd.ExecuteNonQuery();
        }
        public void EditarPessoa(PessoasModel p)
        {
            string sqlUpdate = $@"UPDATE PESSOAS SET NOME = @nome, IDADE = @idade, EMAIL = @email, ENDERECO = @endereco WHERE ID = {p.Id}";
            SqlCommand cmd = new SqlCommand(sqlUpdate, _conn, _trans);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@idade", p.Idade);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@endereco", p.Endereco);
            cmd.ExecuteNonQuery();
        }
    }
}
