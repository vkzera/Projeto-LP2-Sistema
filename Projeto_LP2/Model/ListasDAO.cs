﻿using MySql.Data.MySqlClient;
using Projeto_LP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    class ListasDAO : IDAO<Lista>, IDisposable
    {

        //conexao com o banco
        private IConnection conn;


        public ListasDAO(IConnection Connection)
        {
            this.conn = Connection;
        }

        public void Atualizar(Lista model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Inserir(Lista model)
        {
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO listas(lis_nome) " +
                "VALUES(@nome);";

                cmd.Parameters.AddWithValue("@nome", model.Nome);
               

                try
                {
                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch
                {
                    return 0;
                }

            }
        }

        public Collection<Lista> ListarHistoricoPorProduto(string supermercado)
        {
            throw new NotImplementedException();
        }

        public Collection<Lista> ListarHistoricoPorSupermercado()
        {
            throw new NotImplementedException();
        }

        public Collection<Lista> ListarTudo()
        {
            Collection<Lista> colecao = new Collection<Lista>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM listas;";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Lista lista = new Lista
                        {
                            Id = int.Parse(row["id_lista"].ToString()),
                            Nome = row["lis_nome"].ToString()
                        };
                        colecao.Add(lista);
                    }
                }
            }
            return colecao;
        }

        public Collection<Lista> LocalizarPorCodigo(Lista model)
        {
            Collection<Lista> colecao = new Collection<Lista>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM listas WHERE lis_nome like @value";

                cmd.Parameters.AddWithValue("@value", "%" + model.Nome + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Lista lista = new Lista
                        {
                            Id = int.Parse(row["id_lista"].ToString()),
                            Nome = row["lis_nome"].ToString()
                        };
                        colecao.Add(lista);
                    }
                }
                return colecao;
            }
        }

        public bool Remover(Lista model)
        {
            
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM listas WHERE id_lista = @id";

                cmd.Parameters.AddWithValue("@id", model.Id);


                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }

            }

        }
    }
}
