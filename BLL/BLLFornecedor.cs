using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL

{


    public class BLLFornecedor
    {
        private DALConexao conexao;
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void DeletarFornecedor(int id)
        {
            DALFornecedor dalforn = new DALFornecedor(conexao);
            dalforn.DeletarFornecedor(id);

        }
        public DataTable MostrarFornecedores()
        {
            DALFornecedor DalObj = new DALFornecedor(conexao);
            return DalObj.CarregarFornecedores();
        }
        public DataTable PesquisarFornecedorComChave(string nome)
        {
            DALFornecedor DalObj = new DALFornecedor(conexao);
            return DalObj.PesquisarFornecedorComChave(nome);
        }

        public DataTable PesquisarEnderecoComChave(string nome)
        {
            DALFornecedor DalObj = new DALFornecedor(conexao);
            return DalObj.PesquisarEnderecoComChave(nome);
        }
        public void AlterarFornecedor(ModeloFornecedor modelo)
        {
            if (modelo.fornecedorID <= 0)
            {
                throw new Exception("Informe o código do fornecdor!");
            }
            if (modelo.enderecoID <= 0)
            {
                throw new Exception("Informe o código do endereco do fornecdor!");
            }
            if (modelo.tipoServico.Trim().Length == 0)
            {
                throw new Exception("Informe o tipo de serviço do fornecdor!");
            }
            if (modelo.nomeFornecedor.Trim().Length == 0)
            {
                throw new Exception("Informe Nome do fornecdor!");
            }
            DALFornecedor Dal = new DALFornecedor(conexao);
            Dal.AlterarFornecedor(modelo);


        }
        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.enderecoID<=0)
            {
                throw new  Exception("Informe o código do endereco do fornecdor!");
            }
            if (modelo.tipoServico.Trim().Length== 0)
            {
                throw new Exception("Informe o tipo de serviço do fornecdor!");
            }
            if (modelo.nomeFornecedor.Trim().Length==0)
            {
                throw new Exception("Informe Nome do fornecdor!");
            }
            DALFornecedor Dal=new DALFornecedor(conexao);
            Dal.IncluirFornecedor(modelo);
        }
    }

    
}
