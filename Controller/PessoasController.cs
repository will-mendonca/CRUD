using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Controller
{
    public class PessoasController
    {
        private readonly SqlConnection _conn;
        public PessoasController()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ToString());
        }

        public void AdicionaPessoa(string nome, int idade, string email, string endereco)
        {
            var pessoas = new PessoasModel()
            {
                Nome = nome,
                Idade = idade,
                Email = email,
                Endereco = endereco
            };
            _conn.Open();
            var trans = _conn.BeginTransaction();
            try
            {
                new PessoasDAO(_conn, trans).AdicionarPessoa(pessoas);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        public List<PessoasModel> CarregaLista()
        {
            _conn.Open();
            var trans = _conn.BeginTransaction();
            try
            {
                var listaCarregada = new PessoasDAO(_conn, trans).CarregaLista();
                trans.Commit();
                return listaCarregada;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public void RemoverPessoas(int id)
        {
            _conn.Open();
            var trans = _conn.BeginTransaction();
            try
            {
                new PessoasDAO(_conn, trans).RemoverPessoas(id);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public void EditarPessoas(int id, string nome, int idade, string email, string endereco)
        {
            var pessoaEdit = new PessoasModel()
            {
                Id = id,
                Nome = nome,
                Idade = idade,
                Email = email,
                Endereco = endereco
            };
                _conn.Open();
                var trans = _conn.BeginTransaction();
            try
            {
                new PessoasDAO(_conn, trans).EditarPessoa(pessoaEdit);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
