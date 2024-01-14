-- Cria��o do Banco de Dados
CREATE DATABASE BD_Veterinaria;

USE BD_Veterinaria;
select *from endereco
drop DATABASE BD_Veterinaria;
-----------tabelas basicas ---------------
create table Endereco(
    EnderecoID int PRIMARY key not null identity(1,1),
    Bairro varchar (15),
    Cidade VARCHAR (10), 
    Rua VARCHAR(20),
    Email VARCHAR(100),
    Telefone1 VARCHAR(15), 
    Telefone2 VARCHAR(15),
    Comuna VARCHAR(25),
    Municipio VARCHAR(15),
    Provincia VARCHAR(15)
);

go 
CREATE PROCEDURE procedure_Atualizar_Endereco
    @EnderecoID INT,
    @Bairro VARCHAR(15),
    @Cidade VARCHAR(10),
    @Rua VARCHAR(20),
    @Email VARCHAR(100),
    @Telefone1 VARCHAR(15),
    @Telefone2 VARCHAR(15),
    @Comuna VARCHAR(25),
    @Municipio VARCHAR(15),
    @Provincia VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Endereco
    SET Bairro = @Bairro,
        Cidade = @Cidade,
        Rua = @Rua,
        Email = @Email,
        Telefone1 = @Telefone1,
        Telefone2 = @Telefone2,
        Comuna = @Comuna,
        Municipio = @Municipio,
        Provincia = @Provincia
    WHERE EnderecoID = @EnderecoID;
END;

go
CREATE PROCEDURE Insert_procedure_Endereco
    @Bairro varchar(15),
    @Cidade varchar(10),
    @Rua varchar(20),
    @Email varchar(100),
    @Telefone1 varchar(15),
    @Telefone2 varchar(15),
    @Comuna varchar(25),
    @Municipio varchar(15),
    @Provincia varchar(15)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Endereco (Bairro, Cidade, Rua, Email, Telefone1, Telefone2, Comuna, Municipio, Provincia)
    VALUES (@Bairro, @Cidade, @Rua, @Email, @Telefone1, @Telefone2, @Comuna, @Municipio, @Provincia);
    SELECT SCOPE_IDENTITY();
END;


alter table funcionario add sexo varchar (10)
select *from Funcionario

-- Tabela de Funcion�rios
CREATE TABLE Funcionario (
    FuncionarioID INT PRIMARY KEY NOT NULL identity(1,1),
    Nome VARCHAR(50),
    Sobrenome VARCHAR(50),
    Apelido VARCHAR(50),
	sexo varchar (10),
    NomePai VARCHAR(100),
    NomeMae varchar(100),
    Cargo VARCHAR(50),
    Salario DECIMAL(10, 2),
    DataContratacao DATE,
    DataNascimento DATE,
    TipoDocumento VARCHAR(25),
    NumIdentificacao VARCHAR(50),
    DataEmissaoBI DATE,
    DataExpiracaoBI date,
    Nacionalidade VARCHAR(50),
    foto varbinary (max),
    GrauAcademico VARCHAR(50),
    EstadoCivil VARCHAR(15),
    Observacao VARCHAR(MAX),
	EnderecoID int,
	constraint fk_EnderecoID_Funcionario foreign key(EnderecoID) references Endereco(EnderecoID)
);
use BD_Veterinaria
select * from animal

GO 
CREATE PROCEDURE procedure_Atualizar_Funcionario
    @FuncionarioID INT,
    @Nome VARCHAR(50),
    @Sobrenome VARCHAR(50),
    @Apelido VARCHAR(50),
	@sexo varchar (10),
    @NomePai VARCHAR(100),
    @NomeMae VARCHAR(100),
    @Cargo VARCHAR(50),
    @Salario DECIMAL(10, 2),
    @DataContratacao DATE,
    @DataNascimento DATE,
    @TipoDocumento VARCHAR(25),
    @NumIdentificacao VARCHAR(50),
    @DataEmissaoBI DATE,
    @DataExpiracaoBI DATE,
    @Nacionalidade VARCHAR(50),
    @Foto VARBINARY(MAX),
    @GrauAcademico VARCHAR(50),
    @EstadoCivil VARCHAR(15),
    @Observacao VARCHAR(MAX),
    @EnderecoID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Funcionario
    SET Nome = @Nome,
        Sobrenome = @Sobrenome,
        Apelido = @Apelido,
		sexo = @sexo,
        NomePai = @NomePai,
        NomeMae = @NomeMae,
        Cargo = @Cargo,
        Salario = @Salario,
        DataContratacao = @DataContratacao,
        DataNascimento = @DataNascimento,
        TipoDocumento = @TipoDocumento,
        NumIdentificacao = @NumIdentificacao,
        DataEmissaoBI = @DataEmissaoBI,
        DataExpiracaoBI = @DataExpiracaoBI,
        Nacionalidade = @Nacionalidade,
        foto = @Foto,
        GrauAcademico = @GrauAcademico,
        EstadoCivil = @EstadoCivil,
        Observacao = @Observacao,
        EnderecoID = @EnderecoID
    WHERE FuncionarioID = @FuncionarioID;
END;

GO
CREATE PROCEDURE Insert_procedure_Funcionario
    @Nome VARCHAR(50),
    @Sobrenome VARCHAR(50),
    @Apelido VARCHAR(50),
	@sexo varchar (10),
    @NomePai VARCHAR(100),
    @NomeMae VARCHAR(100),
    @Cargo VARCHAR(50),
    @Salario DECIMAL(10, 2),
    @DataContratacao DATE,
    @DataNascimento DATE,
    @TipoDocumento VARCHAR(25),
    @NumIdentificacao VARCHAR(50),
    @DataEmissaoBI DATE,
    @DataExpiracaoBI DATE,
    @Nacionalidade VARCHAR(50),
    @Foto VARBINARY(MAX),
    @GrauAcademico VARCHAR(50),
    @EstadoCivil VARCHAR(15),
    @Observacao VARCHAR(MAX),
    @EnderecoID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Funcionario (Nome, Sobrenome, Apelido, sexo,NomePai, NomeMae, Cargo, Salario, DataContratacao, DataNascimento, TipoDocumento, NumIdentificacao, DataEmissaoBI, DataExpiracaoBI, Nacionalidade, foto, GrauAcademico, EstadoCivil, Observacao, EnderecoID)
    VALUES (@Nome, @Sobrenome, @Apelido, @sexo, @NomePai, @NomeMae, @Cargo, @Salario, @DataContratacao, @DataNascimento, @TipoDocumento, @NumIdentificacao, @DataEmissaoBI, @DataExpiracaoBI, @Nacionalidade, @Foto, @GrauAcademico, @EstadoCivil, @Observacao, @EnderecoID);

END

----------------------tabelas relacionadas com proprietario e animais------------------------------
-- Tabela de PROPRIETARIO
CREATE TABLE proprietario (
    ProprietarioID INT PRIMARY KEY NOT NULL identity(1,1),
    EnderecoID int,
    Nome VARCHAR(100),
    Sexo varchar(10),
    Sobrenome VARCHAR(50),
    Apelido VARCHAR(50),
    TipoDocumento VARCHAR(50),
    NumIdent VARCHAR(25),
    DataEmisao DATE,
    DataValidade date,
    NomePai VARCHAR(100),
    NomeMae varchar(100),
    Nacionalidade VARCHAR(50),
    descricao VARCHAR(MAX),
	constraint fk_EnderecoID_ProprietarioID foreign key(EnderecoID) references Endereco(EnderecoID)
);

GO
CREATE PROCEDURE procedure_Atualizar_Proprietario
    @ProprietarioID INT,
    @EnderecoID INT,
    @Nome VARCHAR(100),
    @Sexo VARCHAR(10),
    @Sobrenome VARCHAR(50),
    @Apelido VARCHAR(50),
    @TipoDocumento VARCHAR(50),
    @NumIdent VARCHAR(25),
    @DataEmisao DATE,
    @DataValidade DATE,
    @NomePai VARCHAR(100),
    @NomeMae VARCHAR(100),
    @Nacionalidade VARCHAR(50),
    @Descricao VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE proprietario
    SET EnderecoID = @EnderecoID,
        Nome = @Nome,
        Sexo = @Sexo,
        Sobrenome = @Sobrenome,
        Apelido = @Apelido,
        TipoDocumento = @TipoDocumento,
        NumIdent = @NumIdent,
        DataEmisao = @DataEmisao,
        DataValidade = @DataValidade,
        NomePai = @NomePai,
        NomeMae = @NomeMae,
        Nacionalidade = @Nacionalidade,
        descricao = @Descricao
    WHERE ProprietarioID = @ProprietarioID;
END;

go
CREATE PROCEDURE Insert_procedure_Proprietario
    @EnderecoID int,
    @Nome varchar(100),
    @Sexo varchar(10),
    @Sobrenome varchar(50),
    @Apelido varchar(50),
    @TipoDocumento varchar(50),
    @NumIdent varchar(25),
    @DataEmisao date,
    @DataValidade date,
    @NomePai varchar(100),
    @NomeMae varchar(100),
    @Nacionalidade varchar(50),
    @Descricao varchar(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO proprietario (EnderecoID, Nome, Sexo, Sobrenome, Apelido, TipoDocumento, NumIdent, DataEmisao, DataValidade, NomePai, NomeMae, Nacionalidade, descricao)
    VALUES (@EnderecoID, @Nome, @Sexo, @Sobrenome, @Apelido, @TipoDocumento, @NumIdent, @DataEmisao, @DataValidade, @NomePai, @NomeMae, @Nacionalidade, @Descricao);
    select @@identity;
END;

-- Tabela de Animal-------
CREATE TABLE Animal (
    AnimalID INT PRIMARY KEY NOT NULL identity(1,1),
    Nome VARCHAR(50),
    Especie VARCHAR(50),
    Raca VARCHAR(50),
    Cor varchar(30),
    Peso decimal (10,2),
    Estado varchar (20),
    DataNascimento DATE,
    Porte varchar(30),
    ProprietarioID INT,
    foto varbinary (max),
    observacao varchar(max),
    constraint fk_ProprietarioID_AnimalID foreign key(ProprietarioID) references Proprietario(ProprietarioID)
);

GO
CREATE PROCEDURE procedure_Atualizar_Animal
    @AnimalID INT,
    @Nome VARCHAR(50),
    @Especie VARCHAR(50),
    @Raca VARCHAR(50),
	@sexo VARCHAR(10),
    @Cor VARCHAR(30),
    @Peso DECIMAL(10, 2),
    @Estado VARCHAR(20),
    @DataNascimento DATE,
    @Porte VARCHAR(30),
    @ProprietarioID INT,
    @Foto VARBINARY(MAX),
    @Observacao VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Animal
    SET Nome = @Nome,
        Especie = @Especie,
        Raca = @Raca,
		sexo = @sexo,
        Cor = @Cor,
        Peso = @Peso,
        Estado = @Estado,
        DataNascimento = @DataNascimento,
        Porte = @Porte,
        ProprietarioID = @ProprietarioID,
        foto = @Foto,
        observacao = @Observacao
    WHERE AnimalID = @AnimalID;
END;

go 
CREATE PROCEDURE Insert_procedure_Animal
    @Nome varchar(50),
    @Especie varchar(50),
    @Raca varchar(50),
	@sexo VARCHAR(10),
    @Cor varchar(30),
    @Peso decimal(10, 2),
    @Estado varchar(20),
    @DataNascimento date,
    @Porte varchar(30),
    @ProprietarioID int,
    @Foto varbinary(max),
    @Observacao varchar(max)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Animal (Nome, Especie, Raca, sexo, Cor, Peso, Estado, DataNascimento, Porte, ProprietarioID, foto, observacao)
    VALUES (@Nome, @Especie, @Raca,@sexo, @Cor, @Peso, @Estado, @DataNascimento, @Porte, @ProprietarioID, @Foto, @Observacao);
    select @@identity;
END;





----Inicio tabelas relacionada com a clinica ---------------
-- Tabela de Consultas
CREATE TABLE Consultas (
    ConsultaID INT PRIMARY KEY NOT NULL identity(1,1),
    DataConsulta DATETIME,
    AnimalID INT,
    Diagnostico VARCHAR(MAX),
    Tratamento VARCHAR(MAX),
    observacao VARCHAR(MAX),
	constraint fk_AnimalID_ConsultaID foreign key(AnimalID) references Animal(AnimalID)
);

--criacao da tabela abaixo
CREATE TABLE Receita
(
	num_receita INT PRIMARY KEY identity(1,1),
	data_receita DATETIME,
	desc_orientacoes_gerais VARCHAR(150),
	codigo_de_barra VARCHAR(20) null,
	ConsultaID INT,
	AnimalID int,
	descricao TEXT,
	constraint fk_ConsultaID_num_receita  foreign key(ConsultaID) references Consultas(ConsultaID),
	constraint fk_AnimalID_num_receita  foreign key(AnimalID) references Animal(AnimalID)
);

--criacao da tabela abaixo  ItemReceita
CREATE TABLE ItemReceita
(
	item_num_receita INT PRIMARY KEY identity(1,1),
    num_receita int,
	codeMedicamento INT,
	quantidade INT,
    observacao VARCHAR(200),
	constraint fk_num_receita_num_item_num_receita foreign key(num_receita) references Receita(num_receita),
	constraint fk_codeMedicamento_item_num_receita foreign key(codeMedicamento) references Medicamento(codeMedicamento)
)

--pesquisar sobre isso
--criacao da tabela abaixo
CREATE TABLE Prescricao
(
	codePrescricao INT PRIMARY KEY identity(1,1),
	descr_orietancoes varchar(250),
	descr_dosagem varchar(250),
	descr_apresentacao varchar(250),
	num_receita int,
	dataPrescricao DATE,
	duracao varchar(50),
	frequencia VARCHAR(50),
	codeMedicamento int,
	constraint fk_num_receita_codePrescricao foreign key(num_receita) references Receita(num_receita),
	constraint fk_codeMedicamento_codePrescricao foreign key(codeMedicamento) references Medicamento(codeMedicamento)
);
-- Tabela de Tratamento
CREATE TABLE Tratamento (
    ID_Tratamento INT PRIMARY KEY,
    FuncionarioID INT,
    AnimalID int,
    Data_Inicio DATE,
    Data_Fim DATE,
    Descricao TEXT,
    constraint fk_Tratamento_FuncionarioID foreign key(FuncionarioID) references Funcionario(FuncionarioID),
    constraint fk_Tratamento_AnimalID foreign key(AnimalID) references Animal(AnimalID)
);

-- Tabela de Tipo_Exame
CREATE TABLE Tipo_Exame (
    ID_Tipo_Exame INT PRIMARY KEY,
    Descricao VARCHAR(100)
);
-- Tabela de Exame
CREATE TABLE Exame (
    ID_Exame INT PRIMARY KEY identity(1,1),
    AnimalID INT FOREIGN KEY REFERENCES Animal(AnimalID),
    FuncionarioID INT,
    ID_Tipo_Exame INT,
    Data_Hora DATETIME,
    Resultado TEXT,
	constraint fk_Exame_AnimalID foreign key(AnimalID) references Animal(AnimalID),
	constraint fk_Exame_FuncionarioID foreign key(FuncionarioID) references Funcionario(FuncionarioID),
	constraint fk_ExameID_Tipo_Exame foreign key(ID_Tipo_Exame) references Tipo_Exame(ID_Tipo_Exame)
);
-- Tabela de Item_Exame
CREATE TABLE Item_Exame (
    ID_Item_Exame INT PRIMARY KEY,
    ID_Exame INT,
    Descricao_Exame VARCHAR(100),
    Resultado_Exame TEXT,
	constraint fk_Item_Exame_ID_Exame_ID_Exame foreign key(ID_Exame) references Exame(ID_Exame)
);
-- Tabela de Registro_Exame
CREATE TABLE Registro_Exame (
    ID_Registro_Exame INT PRIMARY KEY,
    FuncionarioID INT,
	ID_Exame INT,
    AnimalID INT,
    Data_Hora DATETIME,
    Observacoes TEXT,
	constraint fk_Registro_Exame_Exame foreign key(ID_Exame) references Exame(ID_Exame),
	constraint Registro_Exame_Funcionario foreign key(FuncionarioID) references Funcionario(FuncionarioID)
);
-- Tabela de Agendamento
CREATE TABLE Agendamento (
    AgendamentoID INT PRIMARY KEY NOT NULL  identity(1,1),
    DataAgendamento DATETIME,
    ConsultaID INT,
    Observacoes VARCHAR(MAX),
	constraint fk_Agendamento_Consulta FOREIGN KEY (ConsultaID) REFERENCES Consultas(ConsultaID),
);

----fim tabelas relacionada com a clinica ---------------



-- Area de criacao de tabelas de compra e vendas da farmacia----------------------------------------------------------------------------

-- Tabela de Produtos
CREATE TABLE Produto (
    IDProduto INT PRIMARY KEY,
    IDFornecedor INT,
	TipoProduto VARCHAR(50),
	formaFarmaceutica VARCHAR(50),
	dosagemMedicamento VARCHAR(150),
	instrucoes VARCHAR(250),
	fabricante VARCHAR(50),
    NomeProduto VARCHAR(255),
    CategoriaProduto VARCHAR(50),
    CustoProduto DECIMAL(10, 2),  -- Custo do produto
    QuantidadeEmEstoque INT,
	concentracao VARCHAR(50),
	descricao VARCHAR(250),
    FOREIGN key (IDFornecedor) REFERENCES Fornecedor (IDFornecedor) 
);
-- Tabela ItemVenda
CREATE TABLE ItemVenda (
    IDItemVenda INT PRIMARY KEY,
    VendaID INT,
    ProdutoID INT,
    Quantidade INT,
    PrecoUnitario DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    FOREIGN KEY (VendaID) REFERENCES Venda(IDVenda),
    FOREIGN KEY (ProdutoID) REFERENCES Produto(IDProduto)
);
-- Tabela Venda
CREATE TABLE Venda (
    IDVenda INT PRIMARY KEY,
    ClienteID INT,
    FuncionarioID INT, -- Adicionada a referência ao Funcionario
    DataVenda DATE,
    TotalVenda DECIMAL(10, 2),
    FOREIGN KEY (ClienteID) REFERENCES Cliente(IDCliente),
    FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(IDFuncionario)
);
-- Tabela de Fornecedores de Medicamentos e Vacinas
CREATE TABLE Fornecedor (
    FornecedorID INT PRIMARY KEY identity(1,1),
    NomeFornecedor VARCHAR(100),
    TipoServico VARCHAR(50),
	EnderecoID int,
	Observacao varchar (MAX),
	constraint fk_Fornecedor_Endereco foreign key(EnderecoID) references Endereco(EnderecoID)
);
-- Tabela Compra
CREATE TABLE Compra (
    IDCompra INT PRIMARY KEY,
    FornecedorID INT,
    FuncionarioID INT, -- Adicionada a referência ao Funcionario
    DataCompra DATE,
    TotalCompra DECIMAL(10, 2),
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedor(IDFornecedor),
    FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(IDFuncionario)
);
-- Tabela ItemCompraProduto
CREATE TABLE ItemCompraProduto (
    IDItemCompraProduto INT PRIMARY KEY,
    CompraID INT,
    ProdutoID INT,
    Quantidade INT,
    PrecoUnitario DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    FOREIGN KEY (CompraID) REFERENCES Compra(IDCompra),
    FOREIGN KEY (ProdutoID) REFERENCES Produto(IDProduto)
);
--criacao da tabela produto
CREATE TABLE Produto (
    IDProduto INT PRIMARY KEY,
    IDFornecedor INT,
	TipoProduto VARCHAR(50),
    formaFarmaceutica VARCHAR(50),
	dosagemMedicamento VARCHAR(150),
	instrucoes VARCHAR(250),
	fabricante VARCHAR(50),
    NomeProduto VARCHAR(255),
    CategoriaProduto VARCHAR(50),
    CustoProduto DECIMAL(10, 2),  
    QuantidadeEmEstoque INT,
	concentracao VARCHAR(50),
	descricao VARCHAR(250)
    FOREIGN key (IDFornecedor) REFERENCES Fornecedor (IDFornecedor) 
);
------------------------------------------------------------------
--fim de Area de criacao de tabelas de compra e vendas da farmacia----------------------------------------------------------------------------
