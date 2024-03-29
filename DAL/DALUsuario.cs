﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;


        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void incluirUsuario(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_procedure_Usuario";
            cmd.Parameters.AddWithValue("@NomeUsuario", modelo.NomeUsuario);
            cmd.Parameters.AddWithValue("@Senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@Perfil", modelo.Perfil);
            cmd.Parameters.AddWithValue("FuncionarioID", modelo.FuncionarioID);
            cmd.Parameters.AddWithValue("NomeFuncionario", modelo.NomeFuncionario);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            modelo.UsuarioID = Convert.ToInt16(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void AlterarUsuario(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Atualizar_procedure_Usuario";
            //cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
            if (modelo.UsuarioID > 0) // Verifica se o UsuarioID é maior que zero (ou outro critério para um valor válido)
            {
                cmd.Parameters.AddWithValue("@UsuarioID", modelo.UsuarioID);
            }
            else
            {
                throw new ArgumentException("O campo UsuarioID é inválido ou não foi definido corretamente!");
            }

            cmd.Parameters.AddWithValue("@FuncionarioID", modelo.FuncionarioID);
            cmd.Parameters.AddWithValue("@NomeUsuario", modelo.NomeUsuario);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@perfil", modelo.Perfil);
            cmd.Parameters.AddWithValue("@NomeFuncionario", modelo.NomeFuncionario);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void EliminarUsuario(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "delete from Usuario where UsuarioID=@UsuarioID";
            cmd.Parameters.AddWithValue("@UsuarioID", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public ModeloUsuario CarregarModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "selec * from Usuarios where UsuarioID=@UsuarioID";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuarioID= Convert.ToInt16(registro["usu_id"]);
                modelo.Senha = Convert.ToString(registro["senha"]);
                modelo.Perfil = Convert.ToString(registro["perfil"]);
            }
            conexao.Desconectar();
            registro.Close();
            return modelo;
        }
        public DataTable LocalizarUsuarioLogin(String usuario, string senha)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Usuario where NomeUsuario ='" + usuario.ToString() + "' and senha='" + senha.ToString() + "'", conexao.StringConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;

        }
        public DataTable Localizar(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from Usuario where NomeUsuario like'%" + nome.ToString() + "%' OR UsuarioID like'%" + nome.ToString() + "%'", conexao.ObjectoConexao);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
       

    }
}
