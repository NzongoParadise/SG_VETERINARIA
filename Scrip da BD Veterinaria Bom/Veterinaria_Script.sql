-- Cria��o do Banco de Dados
CREATE DATABASE BD_Veterinaria;

USE BD_Veterinaria;

drop DATABASE BD_Veterinaria;

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
-- Criação do procedimento armazenado para inserção de dados na tabela Endereco
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
    select @@identity;
END;

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

-- Tabela de Animal
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
select *from animal
alter table Animal add sexo varchar(10) 
drop  procedure procedure_Atualizar_Animal
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
GO
CREATE PROCEDURE AtualizarConsulta
    @ConsultaID INT,
    @DataConsulta DATETIME,
    @AnimalID INT,
    @Diagnostico VARCHAR(MAX),
    @Tratamento VARCHAR(MAX),
    @Observacao VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Consultas
    SET DataConsulta = @DataConsulta,
        AnimalID = @AnimalID,
        Diagnostico = @Diagnostico,
        Tratamento = @Tratamento,
        observacao = @Observacao
    WHERE ConsultaID = @ConsultaID;
END;

go 
CREATE PROCEDURE Insert_procedure_Consulta
    @DataConsulta datetime,
    @AnimalID int,
    @Diagnostico varchar(MAX),
    @Tratamento varchar(MAX),
    @Observacao varchar(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Consultas (DataConsulta, AnimalID, Diagnostico, Tratamento, observacao)
    VALUES (@DataConsulta, @AnimalID, @Diagnostico, @Tratamento, @Observacao);
END;

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
GO 
CREATE PROCEDURE Insert_procedure_Receita
    @DataReceita DATETIME,
    @DescOrientacoesGerais VARCHAR(150),
    @CodigoDeBarra VARCHAR(20),
    @ConsultaID INT,
    @AnimalID INT,
    @Descricao TEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Receita (data_receita, desc_orientacoes_gerais, codigo_de_barra, ConsultaID, AnimalID, descricao)
    VALUES (@DataReceita, @DescOrientacoesGerais, @CodigoDeBarra, @ConsultaID, @AnimalID, @Descricao);
END;


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

GO
CREATE PROCEDURE Insert_procedure_ItemReceita
    @NumReceita INT,
    @CodeMedicamento INT,
    @Quantidade INT,
    @InicioToma DATE,
    @FimToma DATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ItemReceita (num_receita, codeMedicamento, quantidade, inicioToma, fimToma)
    VALUES (@NumReceita, @CodeMedicamento, @Quantidade, @InicioToma, @FimToma);
END;

GO
--pesquisar sobre isso
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
go 
CREATE PROCEDURE Insert_procedure_Prescricao
    @codePrescricao INT,
    @descr_orietancoes VARCHAR(250),
    @descr_dosagem VARCHAR(250),
    @descr_apresentacao VARCHAR(250),
    @num_receita INT,
    @dataPrescricao DATE,
    @duracao varchar(50),
    @frequencia VARCHAR(50),
    @codeMedicamento INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Prescricao
    SET descr_orietancoes = @descr_orietancoes,
        descr_dosagem = @descr_dosagem,
        descr_apresentacao = @descr_apresentacao,
        num_receita = @num_receita,
        dataPrescricao = @dataPrescricao,
        duracao = @duracao,
        frequencia = @frequencia,
        codeMedicamento = @codeMedicamento
    WHERE codePrescricao = @codePrescricao;
END;

go 
CREATE PROCEDURE Insert_procedure_Prescricao
    @DescrOrientacoes varchar(250),
    @DescrDosagem varchar(250),
    @DescrApresentacao varchar(250),
    @NumReceita int,
    @DataPrescricao DATE,
    @Duracao varchar(50),
    @Frequencia VARCHAR(50),
    @CodeMedicamento int
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Prescricao (descr_orietancoes, descr_dosagem, descr_apresentacao, num_receita, dataPrescricao, duracao, frequencia, codeMedicamento)
    VALUES (@DescrOrientacoes, @DescrDosagem, @DescrApresentacao, @NumReceita, @DataPrescricao, @Duracao, @Frequencia, @CodeMedicamento);
    select @@identity;
END;


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
GO
CREATE PROCEDURE procedure_Atualizar_Tratamento
    @ID_Tratamento INT,
    @FuncionarioID INT,
    @AnimalID INT,
    @Data_Inicio DATE,
    @Data_Fim DATE,
    @Descricao TEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Tratamento
    SET FuncionarioID = @FuncionarioID,
        AnimalID = @AnimalID,
        Data_Inicio = @Data_Inicio,
        Data_Fim = @Data_Fim,
        Descricao = @Descricao
    WHERE ID_Tratamento = @ID_Tratamento;
END;

GO
CREATE PROCEDURE Insert_procedure_Tratamento
    @ID_Tratamento INT,
    @FuncionarioID INT,
    @AnimalID INT,
    @Data_Inicio DATE,
    @Data_Fim DATE,
    @Descricao TEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Tratamento (ID_Tratamento, FuncionarioID, AnimalID, Data_Inicio, Data_Fim, Descricao)
    VALUES (@ID_Tratamento, @FuncionarioID, @AnimalID, @Data_Inicio, @Data_Fim, @Descricao);
    select @@identity;
END;


-- Tabela de Medicamentos
CREATE TABLE Medicamento (
	codeMedicamento INT PRIMARY KEY identity(1,1),
	nomeMedicamento VARCHAR(150),
	TipoProduto VARCHAR(50),
	formaFarmaceutica VARCHAR(50),
	dosagemMedicamento VARCHAR(150),
	instrucoes VARCHAR(250),
	fabricante VARCHAR(50),
	--codeUnidadeMedida INT,
	concentracao VARCHAR(50),
	descricao VARCHAR(250)
);
go

CREATE PROCEDURE Insert_procedure_Medicamento
    @codeMedicamento INT,
    @nomeMedicamento VARCHAR(150),
    @TipoProduto VARCHAR(50),
    @formaFarmaceutica VARCHAR(50),
    @dosagemMedicamento VARCHAR(150),
    @instrucoes VARCHAR(250),
    @fabricante VARCHAR(50),
    @codeUnidadeMedida INT,
    @concentracao VARCHAR(50),
    @descricao VARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Medicamento
    SET nomeMedicamento = @nomeMedicamento,
        TipoProduto = @TipoProduto,
        formaFarmaceutica = @formaFarmaceutica,
        dosagemMedicamento = @dosagemMedicamento,
        instrucoes = @instrucoes,
        fabricante = @fabricante,
        codeUnidadeMedida = @codeUnidadeMedida,
        concentracao = @concentracao,
        descricao = @descricao
    WHERE codeMedicamento = @codeMedicamento;
END;

GO
CREATE PROCEDURE Insert_procedure_Medicamento
    @NomeMedicamento VARCHAR(150),
    @TipoProduto VARCHAR(50),
    @FormaFarmaceutica VARCHAR(50),
    @DosagemMedicamento VARCHAR(150),
    @Instrucoes VARCHAR(250),
    @Fabricante VARCHAR(50),
    @CodeUnidadeMedida INT,
    @Concentracao VARCHAR(50),
    @Descricao VARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Medicamento (nomeMedicamento, TipoProduto, formaFarmaceutica, dosagemMedicamento, instrucoes, fabricante, codeUnidadeMedida, concentracao, descricao)
    VALUES (@NomeMedicamento, @TipoProduto, @FormaFarmaceutica, @DosagemMedicamento, @Instrucoes, @Fabricante, @CodeUnidadeMedida, @Concentracao, @Descricao);
    select @@identity;
END;


CREATE TABLE EntradasEstoque
(
	EntradaID INT PRIMARY KEY identity(1,1),
	codeMedicamento INT,
	FornecedorID INT,
	DataEntrada DATE,
	Quantidade INT,
	quantidade_minima INT,
	lote VARCHAR(50),
	tipoEstoque VARCHAR(50),
	qtdTipoEstoque INT,
	dataFabricado DATE,
	dataValidade DATE,		
	constraint fk_EntradaEstoque_FornecedorID foreign key(FornecedorID) references Fornecedor(FornecedorID),
	constraint fkEntradaEstoque_codeMedicamento foreign key(codeMedicamento) references Medicamento(codeMedicamento)
);
GO
CREATE PROCEDURE procedure_Atualizar_EntradaEstoque
    @EntradaID INT,
    @codeMedicamento INT,
    @FornecedorID INT,
    @DataEntrada DATE,
    @Quantidade INT,
    @quantidade_minima INT,
    @lote VARCHAR(50),
    @tipoEstoque VARCHAR(50),
    @qtdTipoEstoque INT,
    @dataFabricado DATE,
    @dataValidade DATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE EntradasEstoque
    SET codeMedicamento = @codeMedicamento,
        FornecedorID = @FornecedorID,
        DataEntrada = @DataEntrada,
        Quantidade = @Quantidade,
        quantidade_minima = @quantidade_minima,
        lote = @lote,
        tipoEstoque = @tipoEstoque,
        qtdTipoEstoque = @qtdTipoEstoque,
        dataFabricado = @dataFabricado,
        dataValidade = @dataValidade
    WHERE EntradaID = @EntradaID;
END;

GO
CREATE PROCEDURE Insert_procedure_EntradaEstoque
    @CodeMedicamento INT,
    @FornecedorID INT,
    @DataEntrada DATE,
    @Quantidade INT,
    @QuantidadeMinima INT,
    @Lote VARCHAR(50),
    @TipoEstoque VARCHAR(50),
    @QtdTipoEstoque INT,
    @DataFabricado DATE,
    @DataValidade DATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO EntradasEstoque (codeMedicamento, FornecedorID, DataEntrada, Quantidade, quantidade_minima, lote, tipoEstoque, qtdTipoEstoque, dataFabricado, dataValidade)
    VALUES (@CodeMedicamento, @FornecedorID, @DataEntrada, @Quantidade, @QuantidadeMinima, @Lote, @TipoEstoque, @QtdTipoEstoque, @DataFabricado, @DataValidade);
    select @@identity;
END;

CREATE TABLE ItensEstoqueEntrada
(
	codigoItem INT PRIMARY KEY identity(1,1),
	EntradaID INT,
	quantidade INT,
	dataEntrada Date,
	tipoEstoque VARCHAR(50),
	qtdTipoEstoque INT,
	lote VARCHAR(50),
	constraint fk_ItensEstoqueEntrada_EntradaID foreign key(EntradaID) references EntradasEstoque(EntradaID)
);
GO
CREATE PROCEDURE procedure_Atualizar_ItemEstoqueEntrada
    @codigoItem INT,
    @EntradaID INT,
    @quantidade INT,
    @dataEntrada DATE,
    @tipoEstoque VARCHAR(50),
    @qtdTipoEstoque INT,
    @lote VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ItensEstoqueEntrada
    SET EntradaID = @EntradaID,
        quantidade = @quantidade,
        dataEntrada = @dataEntrada,
        tipoEstoque = @tipoEstoque,
        qtdTipoEstoque = @qtdTipoEstoque,
        lote = @lote
    WHERE codigoItem = @codigoItem;
END;

GO
CREATE PROCEDURE Insert_procedure_ItemEstoqueEntrada
    @EntradaID INT,
    @Quantidade INT,
    @DataEntrada DATE,
    @TipoEstoque VARCHAR(50),
    @QtdTipoEstoque INT,
    @Lote VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ItensEstoqueEntrada (EntradaID, quantidade, dataEntrada, tipoEstoque, qtdTipoEstoque, lote)
    VALUES (@EntradaID, @Quantidade, @DataEntrada, @TipoEstoque, @QtdTipoEstoque, @Lote);
    select @@identity;
END;


CREATE TABLE SaidasEstoque
(
	SaidaID INT PRIMARY KEY identity(1,1),
	EntradaID INT,
    AnimalID INT,
	DataSaida DATE,
	Quantidade INT,
	Destino VARCHAR(100),
	Prescritor VARCHAR(100),
	Motivo TEXT,
	constraint fk_EntradaID_codeMedicamento foreign key(EntradaID) references EntradasEstoque(EntradaID),
    constraint fk_SaidaID_AnimalID foreign key(AnimalID) references Animal(AnimalID)
);
go

CREATE PROCEDURE procedure_Atualizar_SaidaEstoque
    @SaidaID INT,
    @codeMedicamento INT,
    @DataSaida DATE,
    @Quantidade INT,
    @Destino VARCHAR(100),
    @Prescritor VARCHAR(100),
    @Motivo TEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE SaidasEstoque
    SET codeMedicamento = @codeMedicamento,
        DataSaida = @DataSaida,
        Quantidade = @Quantidade,
        Destino = @Destino,
        Prescritor = @Prescritor,
        Motivo = @Motivo
    WHERE SaidaID = @SaidaID;
END;


GO
CREATE PROCEDURE Insert_procedure_SaidaEstoque
    @CodeMedicamento INT,
    @DataSaida DATE,
    @Quantidade INT,
    @Destino VARCHAR(100),
    @Prescritor VARCHAR(100),
    @Motivo TEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO SaidasEstoque (codeMedicamento, DataSaida, Quantidade, Destino, Prescritor, Motivo)
    VALUES (@CodeMedicamento, @DataSaida, @Quantidade, @Destino, @Prescritor, @Motivo);
    select @@identity;
END;

-- Tabela de Tipo_Exame
CREATE TABLE Tipo_Exame (
    ID_Tipo_Exame INT PRIMARY KEY,
    Descricao VARCHAR(100)
);
GO
CREATE PROCEDURE procedure_Atualizar_TipoExame
    @ID_Tipo_Exame INT,
    @Descricao VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Tipo_Exame
    SET Descricao = @Descricao
    WHERE ID_Tipo_Exame = @ID_Tipo_Exame;
END;

GO
CREATE PROCEDURE procedure_Inserir_TipoExame
    @ID_Tipo_Exame INT,
    @Descricao VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Tipo_Exame (ID_Tipo_Exame, Descricao)
    VALUES (@ID_Tipo_Exame, @Descricao);
END;


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
go 
CREATE PROCEDURE procedure_Atualizar_Exame
    @ID_Exame INT,
    @AnimalID INT,
    @FuncionarioID INT,
    @ID_Tipo_Exame INT,
    @Data_Hora DATETIME,
    @Resultado TEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Exame
    SET AnimalID = @AnimalID,
        FuncionarioID = @FuncionarioID,
        ID_Tipo_Exame = @ID_Tipo_Exame,
        Data_Hora = @Data_Hora,
        Resultado = @Resultado
    WHERE ID_Exame = @ID_Exame;
END;

go

CREATE PROCEDURE Insert_procedure_Exame
    @AnimalID INT,
    @FuncionarioID INT,
    @ID_Tipo_Exame INT,
    @Data_Hora DATETIME,
    @Resultado TEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Exame (AnimalID, FuncionarioID, ID_Tipo_Exame, Data_Hora, Resultado)
    VALUES (@AnimalID, @FuncionarioID, @ID_Tipo_Exame, @Data_Hora, @Resultado);
END;

-- Tabela de Item_Exame
CREATE TABLE Item_Exame (
    ID_Item_Exame INT PRIMARY KEY,
    ID_Exame INT,
    Descricao_Exame VARCHAR(100),
    Resultado_Exame TEXT,
	constraint fk_Item_Exame_ID_Exame_ID_Exame foreign key(ID_Exame) references Exame(ID_Exame)
);
GO
CREATE PROCEDURE procedure_Atualizar_ItemExame
    @ID_Item_Exame INT,
    @ID_Exame INT,
    @Descricao_Exame VARCHAR(100),
    @Resultado_Exame TEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Item_Exame
    SET ID_Exame = @ID_Exame,
        Descricao_Exame = @Descricao_Exame,
        Resultado_Exame = @Resultado_Exame
    WHERE ID_Item_Exame = @ID_Item_Exame;
END;

go 

CREATE PROCEDURE Insert_procedure_ItemExame
    @ID_Item_Exame INT,
    @ID_Exame INT,
    @Descricao_Exame VARCHAR(100),
    @Resultado_Exame TEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Item_Exame (ID_Item_Exame, ID_Exame, Descricao_Exame, Resultado_Exame)
    VALUES (@ID_Item_Exame, @ID_Exame, @Descricao_Exame, @Resultado_Exame);
    select @@identity;
END;


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
GO
CREATE PROCEDURE procedure_Atualizar_RegistroExame
    @ID_Registro_Exame INT,
    @FuncionarioID INT,
    @ID_Exame INT,
    @AnimalID INT,
    @Data_Hora DATETIME,
    @Observacoes TEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Registro_Exame
    SET FuncionarioID = @FuncionarioID,
        ID_Exame = @ID_Exame,
        AnimalID = @AnimalID,
        Data_Hora = @Data_Hora,
        Observacoes = @Observacoes
    WHERE ID_Registro_Exame = @ID_Registro_Exame;
END;

go

CREATE PROCEDURE Insert_procedure_RegistroExame
    @ID_Registro_Exame INT,
    @FuncionarioID INT,
    @ID_Exame INT,
    @AnimalID INT,
    @Data_Hora DATETIME,
    @Observacoes TEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Registro_Exame (ID_Registro_Exame, FuncionarioID, ID_Exame, AnimalID, Data_Hora, Observacoes)
    VALUES (@ID_Registro_Exame, @FuncionarioID, @ID_Exame, @AnimalID, @Data_Hora, @Observacoes);
    select @@identity;
END;


-- Tabela de Agendamento
CREATE TABLE Agendamento (
    AgendamentoID INT PRIMARY KEY NOT NULL  identity(1,1),
    DataAgendamento DATETIME,
    ConsultaID INT,
    Observacoes VARCHAR(MAX),
	constraint fk_Agendamento_Consulta FOREIGN KEY (ConsultaID) REFERENCES Consultas(ConsultaID),
);
GO
CREATE PROCEDURE procedure_Atualizar_Agendamento
    @AgendamentoID INT,
    @DataAgendamento DATETIME,
    @ConsultaID INT,
    @Observacoes VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Agendamento
    SET DataAgendamento = @DataAgendamento,
        ConsultaID = @ConsultaID,
        Observacoes = @Observacoes
    WHERE AgendamentoID = @AgendamentoID;
END;

GO
CREATE PROCEDURE Insert_procedure_Agendamento
    @DataAgendamento DATETIME,
    @ConsultaID INT,
    @Observacoes VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Agendamento (DataAgendamento, ConsultaID, Observacoes)
    VALUES (@DataAgendamento, @ConsultaID, @Observacoes);
    select @@identity;
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
select * from funcionario 

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

-- Tabela de Usuarios
CREATE TABLE Usuario (
    UsuarioID INT PRIMARY KEY identity(1,1),
    NomeUsuario VARCHAR(50),
    Senha VARCHAR(50),
    perfil VARCHAR(50),
);
GO

CREATE PROCEDURE procedure_Atualizar_Usuario
    @UsuarioID INT,
    @NomeUsuario VARCHAR(50),
    @Senha VARCHAR(50),
    @Perfil VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Usuario
    SET NomeUsuario = @NomeUsuario,
        Senha = @Senha,
        perfil = @Perfil
    WHERE UsuarioID = @UsuarioID;
END;

go

CREATE PROCEDURE procedure_Inserir_Usuario
    @NomeUsuario VARCHAR(50),
    @Senha VARCHAR(50),
    @Perfil VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuario (NomeUsuario, Senha, perfil)
    VALUES (@NomeUsuario, @Senha, @Perfil);
END;


-- Tabela de Fornecedores de Medicamentos e Vacinas
CREATE TABLE Fornecedor (
    FornecedorID INT PRIMARY KEY,
    NomeFornecedor VARCHAR(100),
    TipoServico VARCHAR(50),
	EnderecoID int,
	constraint fk_Fornecedor_Endereco foreign key(EnderecoID) references Endereco(EnderecoID)
);
go

CREATE PROCEDURE procedure_Atualizar_Fornecedor
    @FornecedorID INT,
    @NomeFornecedor VARCHAR(100),
    @TipoServico VARCHAR(50),
    @EnderecoID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Fornecedor
    SET NomeFornecedor = @NomeFornecedor,
        TipoServico = @TipoServico,
        EnderecoID = @EnderecoID
    WHERE FornecedorID = @FornecedorID;
END;

go 
CREATE PROCEDURE procedure_Inserir_Fornecedor
    @FornecedorID INT,
    @NomeFornecedor VARCHAR(100),
    @TipoServico VARCHAR(50),
    @EnderecoID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Fornecedor (FornecedorID, NomeFornecedor, TipoServico, EnderecoID)
    VALUES (@FornecedorID, @NomeFornecedor, @TipoServico, @EnderecoID);
END;


-- Tabela de Compras de Medicamentos e Vacinas
CREATE TABLE Compra (
    CompraID INT PRIMARY KEY,
   
    DataCompra DATETIME,
    Quantidade INT,
    ValorTotal DECIMAL(10, 2),
    FornecedorID INT,
    constraint fk_CompraFornecedor FOREIGN KEY (FornecedorID) REFERENCES Fornecedor(FornecedorID),
	
);
go

CREATE PROCEDURE procedure_Atualizar_Compra
    @CompraID INT,
    @DataCompra DATETIME,
    @Quantidade INT,
    @ValorTotal DECIMAL(10, 2),
    @FornecedorID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Compra
    SET DataCompra = @DataCompra,
        Quantidade = @Quantidade,
        ValorTotal = @ValorTotal,
        FornecedorID = @FornecedorID
    WHERE CompraID = @CompraID;
END;

go 
CREATE PROCEDURE Insert_procedure_Compra
    @CompraID INT,
    @DataCompra DATETIME,
    @Quantidade INT,
    @ValorTotal DECIMAL(10, 2),
    @FornecedorID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Compra (CompraID, DataCompra, Quantidade, ValorTotal, FornecedorID)
    VALUES (@CompraID, @DataCompra, @Quantidade, @ValorTotal, @FornecedorID);
END;

create table ItemCompra(
    ItemID int PRIMARY key not NULL IDENTITY(1,1),
    Quantidade int,
    CompraID INT,
	NomedoProduto VARCHAR(100),
    MedicamentoID INT, 
    FuncionarioID INT,
	constraint fk_ItemCompra_Medicamento FOREIGN KEY (MedicamentoID) REFERENCES Medicamento(MedicamentoID),	 
	constraint fk_Compra_Funcionario foreign key(FuncionarioID) references Funcionario(FuncionarioID)
   );

   go 
   CREATE PROCEDURE Insert_procedure_ItemCompra
    @Quantidade INT,
    @CompraID INT,
    @NomedoProduto VARCHAR(100),
    @MedicamentoID INT,
    @FuncionarioID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ItemCompra (Quantidade, CompraID, NomedoProduto, MedicamentoID, FuncionarioID)
    VALUES (@Quantidade, @CompraID, @NomedoProduto, @MedicamentoID, @FuncionarioID);
END;

-- Tabela de animais Vacinados  
CREATE TABLE Vacinado (
    IDVacinacao INT PRIMARY KEY NOT NULL identity(1,1),   
    VacinaID INT,
    DataVacinacao date,
    FuncionarioID INT,
    AnimalID int,
    constraint fk_ItemCompra_IDVacinacao FOREIGN KEY (MedicamentoID) REFERENCES Medicamento(MedicamentoID),	 
    constraint fk_Vacinado_Funcionario FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID),
);
GO
CREATE PROCEDURE procedure_Atualizar_Vacinado
    @IDVacinacao INT,
    @VacinaID INT,
    @DataVacinacao DATE,
    @FuncionarioID INT,
    @AnimalID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Vacinado
    SET VacinaID = @VacinaID,
        DataVacinacao = @DataVacinacao,
        FuncionarioID = @FuncionarioID,
        AnimalID = @AnimalID
    WHERE IDVacinacao = @IDVacinacao;
END;

go

CREATE PROCEDURE Insert_procedure_Vacinado
    @VacinaID INT,
    @DataVacinacao DATE,
    @FuncionarioID INT,
    @AnimalID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Vacinado (VacinaID, DataVacinacao, FuncionarioID, AnimalID)
    VALUES (@VacinaID, @DataVacinacao, @FuncionarioID, @AnimalID);
END;

create table ItemVenda(
    ItemID int PRIMARY key not NULL IDENTITY(1,1),
    Quantidade int,
    CompraID INT,
	NomedoProduto VARCHAR(100),
    MedicamentoID INT, 
	constraint fk_ItemVenda_Medicamento FOREIGN KEY (MedicamentoID) REFERENCES Medicamento(MedicamentoID),
	 FuncionarioID INT,
	constraint Venda_Funcionario foreign key(FuncionarioID) references Funcionario(FuncionarioID)
   );
   GO
   CREATE PROCEDURE procedure_Atualizar_ItemVenda
    @ItemID INT,
    @Quantidade INT,
    @CompraID INT,
    @NomedoProduto VARCHAR(100),
    @MedicamentoID INT,
    @FuncionarioID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ItemVenda
    SET Quantidade = @Quantidade,
        CompraID = @CompraID,
        NomedoProduto = @NomedoProduto,
        MedicamentoID = @MedicamentoID,
        FuncionarioID = @FuncionarioID
    WHERE ItemID = @ItemID;
END;

   go

   CREATE PROCEDURE Insert_procedure_ItemVenda
    @Quantidade INT,
    @CompraID INT,
    @NomedoProduto VARCHAR(100),
    @MedicamentoID INT,
    @FuncionarioID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ItemVenda (Quantidade, CompraID, NomedoProduto, MedicamentoID, FuncionarioID)
    VALUES (@Quantidade, @CompraID, @NomedoProduto, @MedicamentoID, @FuncionarioID);
END;


CREATE TABLE Venda (
    VendaID INT PRIMARY KEY,
    DataVenda DATETIME,
    ValorTotal DECIMAL(10, 2),
    MetodoPagamento VARCHAR(25)   
   
);
GO
CREATE PROCEDURE procedure_Atualizar_Venda
    @VendaID INT,
    @DataVenda DATETIME,
    @ValorTotal DECIMAL(10, 2),
    @MetodoPagamento VARCHAR(25)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Venda
    SET DataVenda = @DataVenda,
        ValorTotal = @ValorTotal,
        MetodoPagamento = @MetodoPagamento
    WHERE VendaID = @VendaID;
END;

go

CREATE PROCEDURE Insert_procedure_ItemVenda
    @Quantidade INT,
    @CompraID INT,
    @NomedoProduto VARCHAR(100),
    @MedicamentoID INT,
    @FuncionarioID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ItemVenda (Quantidade, CompraID, NomedoProduto, MedicamentoID, FuncionarioID)
    VALUES (@Quantidade, @CompraID, @NomedoProduto, @MedicamentoID, @FuncionarioID);
END;

create table Usuario(
UsuarioID int primary key not null identity (1,1),
FuncionarioID int,
NomeFuncionario varchar(50),
NomeUsuario VARCHAR (20),
Senha VARCHAR (20),
perfil VARCHAR (15),
CONSTRAINT Usuario_Funcionario FOREIGN key (FuncionarioID) REFERENCES Funcionario(FuncionarioID)
)
insert_procedure_Usuario
CREATE PROCEDURE insert_procedure_Usuario
    @FuncionarioID INT,
    @NomeFuncionario VARCHAR(50),
    @NomeUsuario VARCHAR(20),
    @Senha VARCHAR(20),
    @Perfil VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuario (FuncionarioID, NomeFuncionario, NomeUsuario, Senha, perfil)
    VALUES (@FuncionarioID, @NomeFuncionario, @NomeUsuario, @Senha, @Perfil);
END;


CREATE PROCEDURE Atualizar_procedure_Usuario
    @UsuarioID INT,
    @FuncionarioID INT,
    @NomeFuncionario VARCHAR(50),
    @NomeUsuario VARCHAR(20),
    @Senha VARCHAR(20),
    @Perfil VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Usuario
    SET FuncionarioID = @FuncionarioID,
        NomeFuncionario = @NomeFuncionario,
        NomeUsuario = @NomeUsuario,
        Senha = @Senha,
        perfil = @Perfil
    WHERE UsuarioID = @UsuarioID;
END;

use BD_Veterinaria

----- criacao de insrt e outros




-- Exemplo de inserção de dados na tabela Funcionario
INSERT INTO Funcionario (Nome, Sobrenome, Apelido, NomePai, NomeMae, Cargo, Salario, DataContratacao, DataNascimento, TipoDocumento, NumIdentificacao, DataEmissaoBI, DataExpiracaoBI, Nacionalidade, foto, GrauAcademico, EstadoCivil, Observacao, EnderecoID)
VALUES 
('João', 'Silva', 'Jão', 'José Silva', 'Maria Souza', 'Analista de Sistemas', 5000.00, '2023-01-15', '1985-05-10', 'RG', '123456789', '2010-08-20', '2030-08-19', 'Brasileiro', NULL, 'Graduação', 'Solteiro', 'Observações sobre o funcionário.', 1),
('Maria', 'Santos', 'Mary', 'Carlos Santos', 'Ana Oliveira', 'Gerente de Vendas', 7000.00, '2022-11-28', '1980-09-22', 'CPF', '987654321', '2005-06-12', '2035-06-11', 'Brasileira', NULL, 'Pós-Graduação', 'Casado', 'Outras observações.', 2);
use bd_veterinaria
select *from Funcionario
insert into Usuario values('2','mauro','mauro','admin')
SELECT *from Usuario
alter table Usuario add NomeFuncionario varchar(50)
USE BD_Veterinaria
select *from Funcionario