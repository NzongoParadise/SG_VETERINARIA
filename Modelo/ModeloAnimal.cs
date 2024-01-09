using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloAnimal
    {
            private int AnimalID;
            private string Nome;
            private string Especie;
            private string Raca;
        private string sexo;
        private string Cor;
            private double Peso;
            private string Estado;
            private DateTime DataNascimento;
            private string Porte;
            private int ProprietarioID;
            private string observacao;
            private byte[] foto;



            public ModeloAnimal(int animalID, string nome, string especie, string raca, string sexo, string cor, double peso, string estado, DateTime dataNascimento, string porte, int proprietarioID, string observacao, string foto)
            {
                AnimalID = animalID;
                Nome = nome;
                Especie = especie;
                Raca = raca;
                sexo = sexo;    
                Cor = cor;
                Peso = peso;
                Estado = estado;
                DataNascimento = dataNascimento;
                Porte = porte;
                ProprietarioID = proprietarioID;
                this.observacao = observacao;
                this.CarregaImage(foto);
            }
            public ModeloAnimal(int animalID, string nome, string especie, string raca, string sexo, string cor, double peso, string estado, DateTime dataNascimento, string porte, int proprietarioID, string observacao, byte[] foto)
            {
                AnimalID = animalID;
                Nome = nome;
                Especie = especie;
                Raca = raca;
                sexo = sexo;
                Cor = cor;
                Peso = peso;
                Estado = estado;
                DataNascimento = dataNascimento;
                Porte = porte;
                ProprietarioID = proprietarioID;
                this.observacao = observacao;
                this.foto = foto;
            }

            public ModeloAnimal()
            {
                AnimalID = 0;
                ProprietarioID = 0;
                Nome = "";
                Especie = "";
                Raca = "";
                sexo = "";
                Cor = "";
                Peso = 0;
                Estado = "";
                DataNascimento = DateTime.Now;
                Porte = "";
                this.observacao = "";
                //this.foto = 0;


            }

            public int AnimalID1
            {
                get
                {
                    return AnimalID;
                }

                set
                {
                    AnimalID = value;
                }
            }

            public string Nome1
            {
                get
                {
                    return Nome;
                }

                set
                {
                    Nome = value;
                }
            }

            public string Especie1
            {
                get
                {
                    return Especie;
                }

                set
                {
                    Especie = value;
                }
            }

            public string Raca1
            {
                get
                {
                    return Raca;
                }

                set
                {
                    Raca = value;
                }
            }
        public string sexo1
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Cor1
            {
                get
                {
                    return Cor;
                }

                set
                {
                    Cor = value;
                }
            }

            public double Peso1
            {
                get
                {
                    return Peso;
                }

                set
                {
                    Peso = value;
                }
            }

            public string Estado1
            {
                get
                {
                    return Estado;
                }

                set
                {
                    Estado = value;
                }
            }

            public DateTime DataNascimento1
            {
                get
                {
                    return DataNascimento;
                }

                set
                {
                    DataNascimento = value;
                }
            }

            public string Porte1
            {
                get
                {
                    return Porte;
                }

                set
                {
                    Porte = value;
                }
            }

            public int ProprietarioID1
            {
                get
                {
                    return ProprietarioID;
                }

                set
                {
                    ProprietarioID = value;
                }
            }

            public string Observacao
            {
                get
                {
                    return observacao;
                }

                set
                {
                    observacao = value;
                }
            }

            public byte[] Foto
            {
                get
                {
                    return foto;
                }

                set
                {
                    foto = value;
                }
            }

            public void CarregaImage(String imgCaminho)
            {
                try
                {
                    if (string.IsNullOrEmpty(imgCaminho))
                    {
                        return;
                        /*
                         * fornecer priopriedade metodos de instancia para criar, copiar
                         * excluir, mover, abrir arquivos e  ajuda na criação de objectos FileStream
                        */

                        FileInfo arqImagem = new FileInfo(imgCaminho);
                        /*
                         * Expoe um Stream ao redor de um arquivo de suporte
                         * síncrono e assíncrono operações de leitura e gravar
                        */
                        FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);

                        // aloca memória para o vetor

                        this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];

                        //Lê um bloco de bytes do fluxo e grava os dados em buffer fornecido.

                        int iBytesRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
                        fs.Close();
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message.ToString());
                }
            }

        }


    }
