﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVacina
    {
        private DALConexao conexao;

        public BLLVacina(DALConexao cx) { 
      
            this.conexao = cx;
        }

        public void incluirVacinacao(List<ModeloVacina> listaDeDados)
        {
            try
            {
                if (listaDeDados.Count > 0)
                {
                    DALLVacina DALLVacina = new DALLVacina(conexao);
                    ModeloVacina modelo = new ModeloVacina();
                    DALLVacina.IncluirRegistrodeVacinao(listaDeDados);
                }
                else
                {
                    throw new Exception("Adicione Vacina carrinho antes de confirmar a Vacinação.!!!");
                }
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao Inserir a(s) Vacinas no banco de dados. Detalhes: " + erro.Message);
            }

        }




    }
}
