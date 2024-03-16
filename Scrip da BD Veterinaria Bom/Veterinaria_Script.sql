-- Cria��o do Banco de Dados
CREATE DATABASE BD_Veterinaria;

USE BD_Veterinaria;
select *from proprietario
select *from Animal
select *from endereco
drop DATABASE BD_Veterinaria;
-----------tabelas basicas ---------------
CREATE TABLE Usuario (
    UsuarioID INT PRIMARY KEY IDENTITY,
    NomeUsuario VARCHAR(50) NOT NULL,
    Senha VARCHAR(50) NOT NULL,
    Perfil VARCHAR(50) NOT NULL,
    FuncionarioID INT,
    NomeFuncionario VARCHAR(100),
    FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID)
);
select *from Funcionario
CREATE  PROCEDURE insert_procedure_Usuario
    @NomeUsuario VARCHAR(50),
    @Senha VARCHAR(50),
    @Perfil VARCHAR(50),
    @FuncionarioID INT,
    @NomeFuncionario VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuario (NomeUsuario, Senha, Perfil, FuncionarioID, NomeFuncionario)
    VALUES (@NomeUsuario, @Senha, @Perfil, @FuncionarioID, @NomeFuncionario);

    SELECT SCOPE_IDENTITY();
END;

SELECT FROM
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
    Provincia VARCHAR(15),
	UsuarioID INT,
	 DataCadstro datetime default getdate()
	constraint Endereco_Usuario FOREIGN KEY (UsuarioID) references Usuario(UsuarioID)
);select *from animal
select a.nome,concat(p.Nome,' ',p.Sobrenome,' ',p.Apelido) FROM Proprietario p, Animal a WHERE p.ProprietarioID = a.ProprietarioID AND a.AnimalID = 27
select *from Endereco order by datacadstro 
select * from Endereco where Bairro like '%" + nome.ToString() + "%' order by datacadstro DESC
select *from endereco ORDER BY DATACADSTRO asc
select *from endereco
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
	 DataCadastro datetime DEFAULT getdate(),
    DataContratacao DATE,
    DataNascimento DATE,
    TipoDocumento VARCHAR(25),
    NumIdentificacao VARCHAR(50),
    DataEmissaoBI DATE,
    DataExpiracaoBI date,
	 UsuarioID int,
    Nacionalidade VARCHAR(50),
    foto varbinary (max),
    GrauAcademico VARCHAR(50),
    EstadoCivil VARCHAR(15),
    Observacao VARCHAR(MAX),
	EnderecoID int,
	constraint fk_EnderecoID_Funcionario foreign key(EnderecoID) references Endereco(EnderecoID),
	CONSTRAINT Usuario_Proprietario foreign key (UsuarioID)  REFERENCES Usuario(UsuarioID)
);


GO 
CREATE     PROCEDURE procedure_Atualizar_Funcionario
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
	@UsuarioID INT,
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
		@UsuarioID=@UsuarioID,
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
	 SELECT @FuncionarioID;
END;
GO
CREATE   PROCEDURE Insert_procedure_Funcionario
    @Nome VARCHAR(50),
    @Sobrenome VARCHAR(50),
    @Apelido VARCHAR(50),
	@sexo varchar (10),
    @NomePai VARCHAR(100),
    @NomeMae VARCHAR(100),
    @Cargo VARCHAR(50),
    @Salario DECIMAL(10, 2),
    @DataContratacao DATE,
	@UsuarioID INT,
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

    INSERT INTO Funcionario (Nome, Sobrenome, Apelido, sexo,NomePai, NomeMae, Cargo, Salario, DataContratacao,UsuarioID,DataNascimento, TipoDocumento, NumIdentificacao, DataEmissaoBI, DataExpiracaoBI, Nacionalidade, foto, GrauAcademico, EstadoCivil, Observacao, EnderecoID)
    VALUES (@Nome, @Sobrenome, @Apelido, @sexo, @NomePai, @NomeMae, @Cargo, @Salario, @DataContratacao, @UsuarioID,@DataNascimento, @TipoDocumento, @NumIdentificacao, @DataEmissaoBI, @DataExpiracaoBI, @Nacionalidade, @Foto, @GrauAcademico, @EstadoCivil, @Observacao, @EnderecoID);
	select  SCOPE_IDENTITY();
END
select *from Venda
select *from produto
select IDProduto as 'Código Produto', NomeProduto as 'Nome Produto' 
,Qtd as 'Quantidade Disponivel',ValorVenda as 'Valor de Venda'
,NomeFornecedor as 'Nome Fornecedor',TipoProduto as 'Tipo de Produto',
FinalidadeProduto as'Finalidade do Produto', NomeFornecedor as 'Nome do Fornecedor'
,CategoriaProduto as 'Categoria do Produto', Fabricante, DataExpiracao as 'Data Validade'
from Produto where EstadoProduto=1 and IsentoCusto='Não Isento a Custos' 
            

----------------------tabelas relacionadas com proprietario e animais------------------------------
-- Tabela de PROPRIETARIO
ALTER TABLE PROPRIETARIO ADD 
CREATE TABLE proprietario (
    ProprietarioID INT PRIMARY KEY NOT NULL identity(1,1),
    EnderecoID int,
    Nome VARCHAR(100),
    Sexo varchar(10),
    Sobrenome VARCHAR(50),
    Apelido VARCHAR(50),
	DataNascmento date,
	DataCadastro datetime default getdate(),
    TipoDocumento VARCHAR(50),
    NumIdent VARCHAR(25),
    DataEmisao DATE,
    DataValidade date,
    NomePai VARCHAR(100),
	 UsuarioID int,
    NomeMae varchar(100),
    Nacionalidade VARCHAR(50),
    descricao VARCHAR(MAX),
	CONSTRAINT Usuario_Proprietario foreign key (UsuarioID)  REFERENCES Usuario(UsuarioID),
	constraint fk_EnderecoID_ProprietarioID foreign key(EnderecoID) references Endereco(EnderecoID)
);
INSERT INTO proprietario (EnderecoID, Nome, Sexo, Sobrenome, Apelido, TipoDocumento, NumIdent, DataEmisao, DataValidade, NomePai, NomeMae, Nacionalidade, descricao)
VALUES
(1, 'Mauricio', 'Masculino', 'Filipe', '', 'BI', '007042471UE044', '1990-02-15', '2025-02-15', 'Carlos', 'Mariana', 'Angolana', 'Descrição sobre Ana'),
(2, 'Pedro', 'Masculino', 'Mendes', 'Pedrinho', 'BI', '34567890', '1985-06-20', '2024-06-20', 'António', 'Luísa', 'Angolana', 'Descrição sobre Pedro'),
(3, 'Marta', 'Feminino', 'Gomes', 'Martinha', 'BI', '45678901', '1988-09-30', '2023-09-30', 'Francisco', 'Catarina', 'Angolana', 'Descrição sobre Marta'),
(4, 'Rui', 'Masculino', 'Almeida', 'Ruízinho', 'BI', '56789012', '1992-11-10', '2026-11-10', 'Jorge', 'Isabel', 'Angolana', 'Descrição sobre Rui'),
(4, 'Sofia', 'Feminino', 'Oliveira', 'Sofiazinha', 'BI', '67890123', '1996-04-25', '2022-04-25', 'Ricardo', 'Filipa', 'Angolana', 'Descrição sobre Sofia');


GO
CREATE   PROCEDURE procedure_Atualizar_Proprietario
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
	 select @ProprietarioID;
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
select *from Animal

-- Tabela de Animal-------
CREATE TABLE Animal (
    AnimalID INT PRIMARY KEY NOT NULL identity(1,1),
    Nome VARCHAR(50),
    Especie VARCHAR(50),
    Raca VARCHAR(50),
	UsuarioID int,
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

select *from Animal

CREATE   PROCEDURE procedure_Atualizar_Animal
    @AnimalID INT OUTPUT,
    @Nome VARCHAR(50),
    @Especie VARCHAR(50),
    @Raca VARCHAR(50),
    @sexo VARCHAR(10),
    @Cor VARCHAR(30),
    @UsuarioID INT,
    @Peso DECIMAL(10, 2),
    @Estado VARCHAR(20),
    @DataNascimento DATE,
    @Porte VARCHAR(30),
    @ProprietarioID INT,
    @Foto VARBINARY(MAX),
    @Observacao VARCHAR(MAX),
    @AnimalIDAtualizado INT OUTPUT -- Parâmetro de saída para o código do animal atualizado
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DataCadastro DATEtime;

    -- Obtém a data de cadastro atual do animal
    SELECT @DataCadastro = DataCdastro
    FROM Animal
    WHERE AnimalID = @AnimalID;

    -- Atualiza os campos do animal, exceto a DataCadastro
    UPDATE Animal
    SET Nome = @Nome,
        Especie = @Especie,
        Raca = @Raca,
        sexo = @sexo,
        Cor = @Cor,
        Peso = @Peso,
        Estado = @Estado,
        UsuarioID = @UsuarioID,
        Porte = @Porte,
        ProprietarioID = @ProprietarioID,
        foto = @Foto,
        observacao = @Observacao
    WHERE AnimalID = @AnimalID;

    -- Restaura a DataCadastro para o valor original
    UPDATE Animal
    SET DataCdastro = @DataCadastro
    WHERE AnimalID = @AnimalID;

    SET @AnimalIDAtualizado = @AnimalID; -- Define o valor do código do animal atualizado
END;
EXEC sp_rename 'NomeDaTabela.NomeDaColunaAntiga', 'NomeDaColunaNova', 'COLUMN';
exec sp_rename schema.animal.DataCdastro ,DataCadastro 
EXEC sp_rename 'schema.NomeDaTabela.NomeDaColunaAntiga', 'NomeDaColunaNova', 'COLUMN';

go 
CREATE  PROCEDURE Insert_procedure_Animal
    @Nome varchar(50),
    @Especie varchar(50),
    @Raca varchar(50),
	@sexo VARCHAR(10),
    @Cor varchar(30),
	@UsuarioID int,
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

    INSERT INTO Animal (UsuarioID,Nome, Especie, Raca, sexo, Cor, Peso, Estado, DataNascimento, Porte, ProprietarioID, foto, observacao)
    VALUES (@UsuarioID,@Nome, @Especie, @Raca,@sexo, @Cor, @Peso, @Estado, @DataNascimento, @Porte, @ProprietarioID, @Foto, @Observacao);
    select @@identity;
END;

select * from Animal
--criacao do procedimento para actualizar os dados do peso do animal
CREATE PROCEDURE Update_procedure_Peso
	@AnimalID INT,
    @NovoPeso INT
AS
BEGIN
    UPDATE Animal
    SET
        Peso = @NovoPeso
    WHERE AnimalID = @AnimalID
END;







CREATE TABLE Racas
(
    IDRaca INT PRIMARY KEY IDENTITY(1,1),
    NomeRaca NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(MAX)
);
-- Procedimento para Obter Nomes de Raças
CREATE PROCEDURE ObterNomesRacas
AS
BEGIN
   
END; SELECT NomeRaca
    FROM Racas;
select *from Animal
--procedimento para inserir dados na tabela raca
CREATE PROCEDURE Insert_procedure_Raca
    @NomeRaca NVARCHAR(100),
    @Descricao NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Racas (NomeRaca, Descricao)
    VALUES (@NomeRaca, @Descricao);
END;

--procedimento para actualizar os dados na tabela raca
CREATE PROCEDURE Update_procedure_Raca
    @IDRaca INT,
    @NomeRaca NVARCHAR(100),
    @Descricao NVARCHAR(MAX)
AS
BEGIN
    UPDATE Racas
    SET NomeRaca = @NomeRaca,
        Descricao = @Descricao
    WHERE IDRaca = @IDRaca;
END;





----------------------------area de consultas de teste-----------------------------------------------------
select *from proprietario
select *from Animal
select *from produto
SELECT *FROM Funcionario
delete produto
delete Animal
select *from Compra
select *from ItemCompraProduto
delete Venda
delete ItemVenda
delete RegistroVacinacao
delete IItensRegistroVacina
select *from Racas
select *from IItensRegistroVacina
select a.Nome, p.ProprietarioID, p.Nome from proprietario p, Animal a where p.ProprietarioID=a.ProprietarioID 







---------------------------------Inicio tabelas relacionada com a clinica ---------------

CREATE   TABLE RegistroVacinacaobom (
    IDRegistroVacinacao INT PRIMARY KEY IDENTITY(1,1),
    AnimalID INT,
	UsuarioID int,
	DataRegistro DATETIME default getdate(),
	Desconto decimal(15,2),
	Imposto decimal(15,2),
	Troco decimal (15,2),
	FormaPagamento varchar (30),
    CustoTotal DECIMAL(15, 2),
	ValorEntregue decimal(15,2),
	NotasObservacoes varchar (MAX),
	CONSTRAINT fk_Animal_regist FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID),
	CONSTRAINT fk_usuario_registro FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);
go 

CREATE   PROCEDURE  Insert_procedure_RegistroVacinacaobom
    @AnimalID INT,
	@Desconto decimal(15,2),
	@Imposto decimal(15,2),
	@Troco decimal (15,2),
	@FormaPagamento varchar (30),
    @CustoTotal DECIMAL(15, 2),
	@ValorEntregue decimal(15,2),
	@NotasObservacoes varchar (MAX),
    @UsuarioID INT
AS
BEGIN
    -- Inserir dados na tabela RegistroVacinacao
    INSERT INTO RegistroVacinacaobom (AnimalID,UsuarioID,Desconto,Imposto,Troco,FormaPagamento,CustoTotal,ValorEntregue,NotasObservacoes)
    VALUES (@AnimalID, @UsuarioID,@Desconto,@Imposto,@Troco,@FormaPagamento,@CustoTotal,@ValorEntregue,@NotasObservacoes);

    -- Obter o ID gerado
declare @IDRegistroVacinacao int;
    SET @IDRegistroVacinacao = SCOPE_IDENTITY();
 -- Retorna o IDRegistro
    SELECT @IDRegistroVacinacao AS 'IDRegistroVacinacao';
END;

	sp_help itensregistrovacinabom

 create     table  ItensRegistroVacinabom(
	IDItens int primary key identity(1,1),
	IDRegistroVacinacao INT,
	IdProduto INT,
    DoseVacina decimal (10,2),
    LoteVacina VARCHAR(20),
    ViaAdministracao VARCHAR(20),
    LocalAdministracao VARCHAR(50),
    ReacoesAdversas varchar (MAX),
    ProximaDataVacinacao DATE,
	constraint fk_IDRegistroVacinacao_IItensRegistroVacinacao foreign key (IDRegistroVacinacao) references RegistroVacinacaobom (IDRegistroVacinacao),
	CONSTRAINT fk_ProdutoID_IItensRegistroVacina FOREIGN KEY (IdProduto) REFERENCES Produto(IdProduto)
);


SELECT *from RegistroVacinacaobom
SELECT *from ItensRegistroVacinabom

drop TABLE RegistroVacinacao 
drop PROCEDURE  Insert_procedure_RegistroVacinacao
drop PROCEDURE Insert_procedure_ItensRegistroVacina
 drop  table  ItensRegistroVacinabom

	CREATE    PROCEDURE Insert_procedure_ItensRegistroVacinabom
    @IDRegistroVacinacao INT,
    @IdProduto INT,
    @DoseVacina DECIMAL(10, 2),
    @LoteVacina VARCHAR(20),
    @ViaAdministracao VARCHAR(20),
    @LocalAdministracao VARCHAR(50),
    @ReacoesAdversas VARCHAR(MAX),
    @ProximaDataVacinacao DATETIME
AS
BEGIN
    -- Inserir dados na tabela IItensRegistroVacina
    INSERT INTO ItensRegistroVacinabom (
        IDRegistroVacinacao,
        IdProduto,
        DoseVacina,
        LoteVacina,
        ViaAdministracao,
        LocalAdministracao,
        ReacoesAdversas,
        ProximaDataVacinacao
    )
    VALUES (
        @IDRegistroVacinacao,
        @IdProduto,
        @DoseVacina,
        @LoteVacina,
        @ViaAdministracao,
        @LocalAdministracao,
        @ReacoesAdversas,
        @ProximaDataVacinacao
    );
END;


CREATE  TABLE Pesagem (
    PesagemID INT PRIMARY KEY IDENTITY(1,1),
    AnimalID INT,
	UsuarioID INT,
	FuncionarioID INT,
    DataPesagem DATETIME default getdate(),
    Peso decimal(5,2),
	Obs varchar(MAX),
    CONSTRAINT fk_AnimalID_Pesagem FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID),
	CONSTRAINT fk_FuncionarioID_Pesagem FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID),
	CONSTRAINT fk_UsuarioID_Pesagem FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)


--procedimento para inserir dados na tabela rPesagem
CREATE  PROCEDURE Insert_procedure_Pesagem
    @AnimalID int,
    @FuncionarioID int,
	@Peso decimal(5,2),
    @Obs NVARCHAR(MAX),
	@UsuarioID int 
AS
BEGIN
    INSERT INTO Pesagem (AnimalID,FuncionarioID,Peso,Obs,UsuarioID)
    VALUES (@AnimalID, @FuncionarioID,@Peso,@Obs,@UsuarioID);
END;
select*from Animal where peso=600

select *from pesagem
select *from proprietario
SELECT * FROM Animal WHERE AnimalID=26 or AnimalID=28 or AnimalID=31

select distinct a.AnimalID,a.Nome,pp.Nome,a.Cor,a.DataNascimento,a.Especie,a.Raca,p.DataPesagem, p.peso from proprietario pp, pesagem p, Animal a where p.animalID=a.AnimalID

select p.nome, a.Nome as nome_animal from  Animal as a, proprietario as p where p.ProprietarioID=a.ProprietarioID
select distinct a.AnimalID,a.Nome,pp.Nome,a.Cor,a.DataNascimento,a.Especie,a.Raca,p.DataPesagem, p.peso  from proprietario pp, pesagem p, Animal a where p.animalID=a.AnimalID and pp.ProprietarioID=a.ProprietarioID and a.Nome like '%m%' OR a.AnimalID=26


SELECT DISTINCT a.AnimalID, a.Nome, pp.Nome, a.Cor, a.DataNascimento, a.Especie, a.Raca, p.DataPesagem, p.peso 
FROM proprietario pp, pesagem p, Animal a 
WHERE p.animalID = a.AnimalID 
  AND pp.ProprietarioID = a.ProprietarioID 
  AND (a.Nome LIKE '%m%' OR p.AnimalID = 28)





CREATE TABLE MovimentacaoAnimal (
    MovimentacaoID INT PRIMARY KEY IDENTITY(1,1),
    AnimalID INT,
    ProprietarioID INT,
	UsuarioID int,
    Origem VARCHAR(100),
    Destino VARCHAR(100),
	Motivos varchar(max),
	Obs varchar(max),
    CONSTRAINT fk_AnimalID_MovimentacaoAnimal FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID),
    CONSTRAINT fk_ProprietarioID_MovimentacaoAnimal FOREIGN KEY (ProprietarioID) REFERENCES Proprietario(ProprietarioID),
	CONSTRAINT fk_UsuarioID_MovimentacaoAnimal FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);

select *from Consultas
CREATE TABLE Consulta(
    ConsultaID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    AnimalID INT NOT NULL,
	UsuarioID int,
    FuncionarioID INT NOT NULL,
	DataConsulta DATETIME NOT NULL,
    MotivoConsulta VARCHAR(255),
    ExamesRealizados VARCHAR(255),
    Diagnostico VARCHAR(MAX),
    Tratamento VARCHAR(MAX),
    Observacao VARCHAR(MAX),
    EstadoConsulta VARCHAR(50), -- Pode ser 'Agendada', 'Realizada', 'Cancelada', etc.
    CONSTRAINT fk_AnimalID_ConsultaID FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID),
    CONSTRAINT fk_FuncionarioID_ConsultaID FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID),
	CONSTRAINT fk_UsuarioID_Consulta FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)

);

select *from agendamento
update agendamento set DataAgendamento='2024-02-10' where AgendamentoID=35
select *from agendamento where FuncionarioID=1018 and DataAgendamento='2024-02-19'
select *from Animal
45
select *from usuario
select *from usuario
select f.nome from agendamento a,funcionario f where f.FuncionarioID=1018
select *from Agendamento
-- Tabela de Agendamento

select *from Agendamento where FuncionarioID=1018
update agendamento set StatusAgendamento ='Marcada' where StatusAgendamento='Agendado'
CREATE TABLE Agendamento(
    AgendamentoID INT PRIMARY KEY NOT NULL  identity(1,1),
    DataAgendamento DATE,
	FuncionarioID int,
	UsuarioID int,
	AnimalID int,
	DataCadastro date default getdate(),
	TipoAgendamento varchar(30),
    Observacoes VARCHAR(MAX),
	StatusAgendamento varchar (50),
	Gravidade varchar (50),
	HoraInicial time,
	HoraFinal time,
	constraint Agendamento_AnimalID foreign key(AnimalID) references Animal(AnimalID),
	constraint Agendamento_Funcionario foreign key(FuncionarioID) references Funcionario(FuncionarioID),
	CONSTRAINT fk_UsuarioID_Agendamento FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);


DECLARE @DataAgendamento DATE = '2024-02-20'; -- Data para a qual deseja verificar a disponibilidade

SELECT DISTINCT
    HoraInicial,
    HoraFinal
FROM (
    SELECT
        A1.HoraInicial,
        A2.HoraFinal
    FROM
        Agendamento A1
        JOIN Agendamento A2 ON A1.HoraInicial < A2.HoraInicial
    WHERE
        A1.DataAgendamento = @DataAgendamento
        AND NOT EXISTS (
            SELECT 1
            FROM Agendamento A3
            WHERE
                A3.DataAgendamento = @DataAgendamento
                AND A3.FuncionarioID = A1.FuncionarioID
                AND A3.HoraInicial <= A1.HoraInicial
                AND A3.HoraFinal >= A2.HoraFinal
        )
) AS IntervalosDisponiveis;





CREATE PROCEDURE procedure_Atualizar_ConsultaAgendada
    @AgendamentoID INT,
    @DataAgendamento DATE,
    @FuncionarioID INT,
    @UsuarioID INT,
    @AnimalID INT,
    @TipoAgendamento VARCHAR(30),
    @Observacoes VARCHAR(MAX),
    @StatusAgendamento VARCHAR(50),
    @Gravidade VARCHAR(50),
    @HoraInicial TIME,
    @HoraFinal TIME
AS
BEGIN
    UPDATE Agendamento
    SET DataAgendamento = @DataAgendamento,
        FuncionarioID = @FuncionarioID,
        UsuarioID = @UsuarioID,
        AnimalID = @AnimalID,
        TipoAgendamento = @TipoAgendamento,
        Observacoes = @Observacoes,
        StatusAgendamento = @StatusAgendamento,
        Gravidade = @Gravidade,
        HoraInicial = @HoraInicial,
        HoraFinal = @HoraFinal
    WHERE AgendamentoID = @AgendamentoID;
END;

alter table agendamento alter column DataAgendamento date
CREATE PROCEDURE Insert_procedure_CadastrarCosultaAgendada
    @DataAgendamento DATETIME,
    @FuncionarioID INT,
    @UsuarioID INT,
    @AnimalID INT,
    @TipoAgendamento VARCHAR(30),
    @Observacoes VARCHAR(MAX),
    @StatusAgendamento VARCHAR(50),
    @Gravidade VARCHAR(50),
    @HoraInicial TIME,
    @HoraFinal TIME
AS
BEGIN
    INSERT INTO Agendamento (DataAgendamento, FuncionarioID, UsuarioID, AnimalID, TipoAgendamento, Observacoes, StatusAgendamento, Gravidade, HoraInicial, HoraFinal)
    VALUES (@DataAgendamento, @FuncionarioID, @UsuarioID, @AnimalID, @TipoAgendamento, @Observacoes, @StatusAgendamento, @Gravidade, @HoraInicial, @HoraFinal);
END;
select *from Agendamento
alter table agendamento add DataCadastro datetime

alter table Agendamento add AnimalID
alter table Agendamento add HoraInicial time
alter table Agendamento add HoraFinal time
--criacao da tabela abaixo
CREATE TABLE Receita
(
    ReceitaID INT PRIMARY KEY IDENTITY(1,1),
    DataEmissao DATETIME,
    OrientacoesGerais VARCHAR(150),
    CodigoBarra VARCHAR(20) NULL,
    ConsultaID INT,
    AnimalID INT,
    FuncionarioID INT,
    descricao TEXT,
    CONSTRAINT fk_ConsultaID_ReceitaID FOREIGN KEY (ConsultaID) REFERENCES Consulta(ConsultaID),
    CONSTRAINT fk_AnimalID_Receita FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID),
    CONSTRAINT fk_FuncionarioID_Receita FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID);
	CONSTRAINT fk_UsuarioID_Receita FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);

--criacao da tabela abaixo  ItemReceita
CREATE TABLE ItemReceita
(
	ItemReceita INT PRIMARY KEY identity(1,1),
	ReceitaID int,
	produtoID INT,
	quantidade INT,
    observacao VARCHAR(200),
	constraint fk_num_receita_num_item_num_receita foreign key(ReceitaID) references Receita(ReceitaID),
	constraint fk_produto_ItemReceita foreign key(produtoID) references produto(ProdutoID)
);
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

CREATE TABLE Tratamento (
    ID_Tratamento INT PRIMARY KEY IDENTITY(1,1),
    FuncionarioID INT,
    AnimalID INT,
    UsuarioID INT,
    Data_Inicio DATE,
    Data_Fim DATE,
    Descricao TEXT,
    Custo DECIMAL(10, 2),
    Resultado VARCHAR(100),
    Observacoes TEXT,
    Tipo_Tratamento VARCHAR(50),---"Medicação", "Cirurgia", "Fisioterapia")
    Estado VARCHAR(20)--('Em andamento', 'Terminado', 'Cancelado')),
    CONSTRAINT fk_Tratamento_FuncionarioID FOREIGN KEY(FuncionarioID) REFERENCES Funcionario(FuncionarioID),
    CONSTRAINT fk_Tratamento_AnimalID FOREIGN KEY(AnimalID) REFERENCES Animal(AnimalID),
    CONSTRAINT fk_UsuarioID_Tratamento FOREIGN KEY(UsuarioID) REFERENCES Usuario(UsuarioID)
);

-- Tabela de Tratamento
CREATE TABLE Tratamento (
    ID_Tratamento INT PRIMARY KEY identity(1,1),
    FuncionarioID INT,
    AnimalID int,
	UsuarioID int,
    Data_Inicio DATE,
    Data_Fim DATE,
    Descricao TEXT,
    constraint fk_Tratamento_FuncionarioID foreign key(FuncionarioID) references Funcionario(FuncionarioID),
    constraint fk_Tratamento_AnimalID foreign key(AnimalID) references Animal(AnimalID)
	CONSTRAINT fk_UsuarioID_Tratamento FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);

-- Tabela de Tipo_Exame
CREATE TABLE TipoExame (
    TipoExameID INT PRIMARY KEY,
    Descricao VARCHAR(100)
);

-- Tabela de Exame
CREATE TABLE Exame (
    IDExame INT PRIMARY KEY IDENTITY(1,1),
    DataHora DATETIME default getdate(),
    ResultadoGeral VARCHAR(MAX), 
	AnimalID INT,
    FuncionarioID INT,
    UsuarioID INT,
    Observacoes TEXT,
    DiagnosticoPreliminar VARCHAR(MAX),
	CondicaoAnimal VARCHAR(MAX),
    RecomendacoesTratamento VARCHAR(MAX),
    InstrucoesProprietario VARCHAR(MAX),
    AcompanhamentoNecessario VARCHAR(MAX),
	StatusExame varchar(15),
     CONSTRAINT fk_RegistroExame_Funcionario FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID),
    CONSTRAINT fk_RegistroExame_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    CONSTRAINT fk_RegistroExame_Animal FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID)
);

-- Tabela de Item_Exame
CREATE TABLE ItemExame (
    ItemExameID INT PRIMARY KEY IDENTITY(1,1),
    ExameID INT,
    TipoExameID int,
    ObservacaoItemExame VARCHAR(MAX),
    CONSTRAINT fk_ItemExame_Exame FOREIGN KEY (ExameID) REFERENCES Exame(IDExame),
	CONSTRAINT fk_Exame_TipoExameID FOREIGN KEY (TipoExameID) REFERENCES TipoExame(TipoExameID)
);

select *from Animal
CREATE TABLE RegistroExame (
    RegistroExameID INT PRIMARY KEY IDENTITY(1,1),
    ExameID INT,
    AnimalID INT,
    FuncionarioID INT,
    UsuarioID INT,
    Data_Hora DATETIME,
    Observacoes TEXT,
    DiagnosticoPreliminar VARCHAR(MAX),
	CondicaoAnimal VARCHAR(MAX),
    RecomendacoesTratamento TEXT,
    InstrucoesProprietario TEXT,
    AcompanhamentoNecessario TEXT,
    CONSTRAINT fk_RegistroExame_Exame FOREIGN KEY (ExameID) REFERENCES Exame(ID_Exame),
    CONSTRAINT fk_RegistroExame_Funcionario FOREIGN KEY (FuncionarioID) REFERENCES Funcionario(FuncionarioID),
    CONSTRAINT fk_RegistroExame_Usuario FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    CONSTRAINT fk_RegistroExame_Animal FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID)
);

----fim tabelas relacionada com a clinica ---------------


select *from Funcionario




-- inicio da Area de criacao de tabelas de compra e vendas da farmacia----------------------------------------------------------------------------
-- Tabela de Fornecedores de Medicamentos e Vacinas
CREATE TABLE Fornecedor (
    FornecedorID INT PRIMARY KEY identity(1,1),
    NomeFornecedor VARCHAR(100),
    TipoServico VARCHAR(50),
	EnderecoID int,
	Observacao varchar (MAX),
	constraint fk_Fornecedor_Endereco foreign key(EnderecoID) references Endereco(EnderecoID)
);

-- Tabela de Produtos
CREATE TABLE produto(
    IdProduto INT PRIMARY KEY IDENTITY(1,1),
    NomeProduto NVARCHAR(255),
   FornecedorID INT,
	UsuarioID INT,
	CodigodeBarra varchar (100),
    Qtd INT,
    ValorCompra DECIMAL(18,2),
    ValorVenda DECIMAL(18,2),
    Concentracao NVARCHAR(255),
    Dosagem NVARCHAR(255),
    TipoProduto NVARCHAR(255),
    CategoriaProduto NVARCHAR(255),
    FormaFarmaceutica NVARCHAR(255),
    Obs NVARCHAR(255),
    NomeFornecedor NVARCHAR(255),
    Fabricante NVARCHAR(255),
	DataProducao date,
	DataExpiracao date,
	DataCadastro datetime,
	FinalidadeProduto varchar(20),
	EstadoProduto BIT,
	IsentoCusto varchar(20)
	foreign key (FornecedorID) REFERENCES Fornecedor(FornecedorID),
	FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);
alter table produto add IntervaloAplicacao int
select *from produto
sp_help produto
alter table produto add IsentoCusto varchar(5)
alter table produto alter column  IsentoCusto varchar(20)
select *from produto
--criacao do procedimento para actualizar os dados da compra do produto

CREATE PROCEDURE Update_procedure_Produtocompra
	@IdProduto INT,
    @NovaQuantidade INT,
    @NovaDataProducao DATE,
    @NovaDataExpiracao DATE,
    @NovoValorCompra DECIMAL(18,2),
    @NovoValorVenda DECIMAL(18,2),
	@EstadoProduto bit
AS
BEGIN
    UPDATE produto
    SET
        Qtd = @NovaQuantidade,
        DataProducao = @NovaDataProducao,
        DataExpiracao = @NovaDataExpiracao,
        ValorCompra = @NovoValorCompra,
        ValorVenda = @NovoValorVenda,
		EstadoProduto=@EstadoProduto
    WHERE IdProduto = @IdProduto
END;

--criacao do procedimento para inserir produto
CREATE  PROCEDURE Insert_procedure_Produto
    @NomeProduto NVARCHAR(255),
    @FornecedorID INT,
    @UsuarioID INT,
	@CodigodeBarra varchar(100),
    @Qtd INT,
    @ValorCompra DECIMAL(18,2),
    @ValorVenda DECIMAL(18,2),
    @Concentracao NVARCHAR(255),
    @Dosagem NVARCHAR(255),
    @TipoProduto NVARCHAR(255),
    @CategoriaProduto NVARCHAR(255),
    @FormaFarmaceutica NVARCHAR(255),
    @Obs NVARCHAR(255),
    @NomeFornecedor NVARCHAR(255),
    @Fabricante NVARCHAR(255),
    @DataProducao DATE,
    @DataExpiracao DATE,
    @FinalidadeProduto VARCHAR(20),
    @NovoProdutoID INT OUTPUT,
	@EstadoProduto bit,
	@IsentoCusto varchar(20),
	@IntervaloAplicacao int
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO produto (
        NomeProduto,
        FornecedorID,
        UsuarioID,
		CodigodeBarra,
        Qtd,
        ValorCompra,
        ValorVenda,
        Concentracao,
        Dosagem,
        TipoProduto,
        CategoriaProduto,
        FormaFarmaceutica,
        Obs,
        NomeFornecedor,
        Fabricante,
        DataProducao,
        DataExpiracao,
        DataCadastro,
        FinalidadeProduto,
		EstadoProduto,
		IsentoCusto,
		IntervaloAplicacao
    )
    VALUES (
        @NomeProduto,
        @FornecedorID,
        @UsuarioID,
		@CodigodeBarra,
        @Qtd,
        @ValorCompra,
        @ValorVenda,
        @Concentracao,
        @Dosagem,
        @TipoProduto,
        @CategoriaProduto,
        @FormaFarmaceutica,
        @Obs,
        @NomeFornecedor,
        @Fabricante,
        @DataProducao,
        @DataExpiracao,
        GETDATE(), -- DataCadastro
        @FinalidadeProduto,
		@EstadoProduto,
		@IsentoCusto,
		@IntervaloAplicacao
    );

   -- Obtém o ID do produto recém-inserido
    SET @NovoProdutoID = SCOPE_IDENTITY();
END;

select *from compra
select *from venda 


-- criacao da Tabela Compra
CREATE  TABLE Compra(
    IDCompra INT PRIMARY KEY not null identity(1,1),
    UsuarioID INT, 
    DataCompra DATETIME default getdate(),
	Desconto decimal(15,2),
	Imposto decimal(15,2),
	Troco decimal (15,2),
	FormaPagamento varchar (30),
    TotalCompra DECIMAL(15, 2),
	ValorEntregue decimal(15,2),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);
select *from Compra
select *from itemcompraproduto
-- criacao do procedimento inserir compra 
CREATE  PROCEDURE Insert_procedure_Compra
    @UsuarioID INT,
    @TotalCompra DECIMAL(18, 2),
	@Desconto DECIMAL(18, 2),
	@Imposto DECIMAL(18, 2),
	@Troco DECIMAL(18, 2),
	@FormaPagamento varchar(30),
	@ValorEntregue DECIMAL(18, 2)
AS
BEGIN
    SET NOCOUNT ON;
    -- Aqui você realiza as operações necessárias, por exemplo, inserir dados na tabela Compra
    INSERT INTO Compra (UsuarioID,TotalCompra,Desconto,Imposto,Troco,FormaPagamento,ValorEntregue)
    VALUES (@UsuarioID,@TotalCompra,@Desconto,@Imposto,@Troco,@FormaPagamento,@ValorEntregue);
    -- Obtém o ID da compra inserida
    DECLARE @CompraID INT;
    SET @CompraID = SCOPE_IDENTITY();
    -- Retorna o ID da compra
    SELECT @CompraID AS 'CompraID';
END
select *from Compra
-- Tabela ItemCompraProduto
CREATE  TABLE ItemCompraProduto (
    IDItemCompraProduto INT PRIMARY KEY not null identity(1,1),
    CompraID INT,
    ProdutoID INT,
    Quantidade INT,
    PrecoUnitario DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    FOREIGN KEY (CompraID) REFERENCES Compra(IDCompra),
    FOREIGN KEY (ProdutoID) REFERENCES Produto(IDProduto)
);
--criacao do procedimento inserir itemcompra
CREATE PROCEDURE Insert_procedure_ItemCompra
    @CompraID INT,
    @ProdutoID INT,
    @Quantidade INT,
    @PrecoUnitario DECIMAL(10, 2),
    @Total DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO ItemCompraProduto (CompraID, ProdutoID, Quantidade, PrecoUnitario, Total)
    VALUES (@CompraID, @ProdutoID, @Quantidade, @PrecoUnitario, @Total);
END;
select *from ItemVenda 
select *from venda
ma
select *from Fornecedor
select *from produto where idproduto=2
select *from Venda
alter table venda alter column DataVenda datetime
-- Tabela Venda
CREATE  TABLE Venda (
    IDVenda INT PRIMARY KEY identity (1,1),
	NomeCliente Varchar (100),
    DataVenda DATETIME,
    TotalVenda DECIMAL(15, 2),
	Desconto decimal(15,2),
	Imposto decimal(15,2),
	Troco decimal(15,2),
	FormaPagamento varchar(30),
	ValorEntregue decimal(15,2),
	UsuarioID INT,-- Adicionada a referência ao Funcionario
	FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID)
);


-- Tabela ItemVenda
CREATE  TABLE ItemVenda (
    IDItemVenda INT PRIMARY KEY identity (1,1),
    VendaID INT,
    ProdutoID INT,
    Quantidade INT,
    PrecoUnitario DECIMAL(15, 2),
    Total DECIMAL(15, 2),
    FOREIGN KEY (ProdutoID) REFERENCES Produto(IDProduto)
);


CREATE     PROCEDURE Insert_procedure_Venda
    @NomeCliente VARCHAR(100),
    @DataVenda DATEtime,
    @TotalVenda DECIMAL(12, 2),
    @UsuarioID INT,
    @Desconto DECIMAL(15, 2),
    @ValorEntregue DECIMAL(15, 2),
    @Imposto DECIMAL(15, 2),
    @Troco DECIMAL(15, 2),
    @FormaPagamento varchar(30)
AS
BEGIN
    INSERT INTO Venda (NomeCliente, DataVenda, TotalVenda, UsuarioID, Desconto, ValorEntregue, Imposto, Troco, FormaPagamento )
    VALUES (@NomeCliente, @DataVenda, @TotalVenda, @UsuarioID, @Desconto, @ValorEntregue, @Imposto, @Troco, @FormaPagamento);

    -- Retorna o ID da venda inserida
    SELECT SCOPE_IDENTITY();
END;




select *from Venda
DECLARE @IDVenda INT;

EXEC Insert_procedure_Venda
    @NomeCliente = 'Ngovo',
    @DataVenda = '2024-03-07',
    @TotalVenda = 100.00,
    @UsuarioID = 2,
    @Desconto = 10.00,
    @ValorEntregue = 120.00,
    @Imposto = 5.00,
    @Troco = 10.00,
    @FormaPagamento = cash















select *from venda
DECLARE @IDVenda INT; -- Declara a variável para armazenar o ID da venda
-- Executa o procedimento armazenado para inserir a venda
EXEC Insert_procedure_Venda 
    @NomeCliente = 'Cliente',
    @DataVenda = '2024-03-09',
    @TotalVenda = 100.00,
    @UsuarioID = 1,
    @Desconto = 10.00,
    @ValorEntregue = 120.00,
    @Imposto = 5.00,
    @Troco = 10.00,
    @FormaPagamento = 'Dinheiro',
    @IDVenda = @IDVenda OUTPUT; -- Passa a variável como parâmetro de saída

-- Retorna o ID da venda inserida
SELECT @IDVenda = SCOPE_IDENTITY();

-- Exibe o ID da venda inserida
SELECT @IDVenda AS IDVendaInserida;

--criacao do procedimento para actualizar a quantidade vendida
CREATE PROCEDURE Update_procedure_AtualizarQuantidadeEstoque
    @ProdutoID INT,
    @Quantidade INT
AS
BEGIN
    UPDATE Produto
    SET Qtd = Qtd - @Quantidade
    WHERE IDProduto = @ProdutoID;
END


--procedimento para consultar os dados na base de dados sobre venda
CREATE   PROCEDURE ObterDadosVenda
    @CodigoVenda INT
AS
BEGIN
    SELECT v.IDVenda, v.NomeCliente, v.TotalVenda, v.DataVenda, v.ValorEntregue,v.Desconto, v.Imposto, v.Troco, v.FormaPagamento,
           i.ProdutoID, p.NomeProduto, i.Quantidade, i.PrecoUnitario, i.Total,CONCAT(f.nome,' ',f.Sobrenome,' ',f.Apelido) as 'Operador'
    FROM Venda v
    INNER JOIN ItemVenda i ON v.IDVenda = i.VendaID
    INNER JOIN Produto p ON i.ProdutoID = p.IdProduto
	inner join Usuario u on v.UsuarioID=u.UsuarioID
	inner join Funcionario f on u.FuncionarioID=f.FuncionarioID
    WHERE v.IDVenda = @CodigoVenda;
END

exec ObterDadosVenda 22
select *from Venda
select *from ItemVenda



create  procedure ObterDadosCompra
    @CdogioCompra INT
as 
BEGIN

select  c.IDCompra, c.DataCompra,c.Desconto,c.Imposto,c.Troco,c.FormaPagamento,c.TotalCompra,i.ProdutoID,i.Quantidade,i.PrecoUnitario,i.Total
,p.NomeProduto, f.NomeFornecedor,CONCAT(fu.Nome, ' ',fu.Sobrenome,' ', fu.Apelido) as Operador,c.ValorEntregue

 from Compra c INner JOIN ItemCompraProduto i on c.IDCompra=i.CompraID 
 INNER JOIN produto p on p.IdProduto=i.ProdutoID 
 inner join Fornecedor f on f.FornecedorID=p.FornecedorID
 inner JOIN Usuario u on c.UsuarioID=u.UsuarioID
 INNER JOIN Funcionario fu on fu.FuncionarioID=u.FuncionarioID

 where c.IDCompra=@CdogioCompra
 END

 select *from Compra
 select *from ItemCompraProduto

exec ObterDadosVenda 20
select *from Funcionario
select *from Venda


select *from Venda
select  *from usuario u, Funcionario f where u.funcionarioid=f.FuncionarioID
select *from usuario u inner join Funcionario f on u.FuncionarioID=f.FuncionarioID
exec ObterDadosVenda 5

------------------------------------------------------------------
--fim de Area de criacao de tabelas de compra e vendas da farmacia----------------------------------------------------------------------------
select distinct p.Nome from proprietario p, Animal a where a.ProprietarioID=p.ProprietarioID

select *from Venda
select *from ItemVenda
update venda set NomeCliente='Mauricio Filipe' where IDVenda=5
--procedimento para consultar os dados na base de dados sobre venda


CREATE    PROCEDURE ObterDadosVendat
    @CodigoAnimal INT
AS
BEGIN
    select a.AnimalID,a.Nome,CONCAT(p.Nome,' ',p.Sobrenome,' ',p.Apelido)
		from Animal a inner join proprietario p on a.ProprietarioID=p.ProprietarioID
		where AnimalID = @CodigoAnimal
	
--group by v.IDVenda, i.quantidade, i.precoUnitario,f.Nome,v.dataVenda, v.NomeCliente,p.NomeProduto,v.TotalVenda, v.ValorEntregue,v.Desconto,v.Imposto
--,v.Troco,v.FormaPagamento ,i.ProdutoID, i.Total
END


-------------------------------------------------------------------------------------------------
--testes de codigo pode eliminar a qualquer momento so estou a testa

CREATE    PROCEDURE ObterDadosVendateste
    @CodigoVenda INT
AS
BEGIN
    SELECT  v.NomeCliente, v.TotalVenda, v.DataVenda, v.ValorEntregue,v.Desconto, v.Imposto, v.Troco, v.FormaPagamento,
           i.ProdutoID, p.NomeProduto, i.Quantidade, i.PrecoUnitario, i.Total,f.nome
    FROM Venda v
    INNER JOIN ItemVenda i ON v.IDVenda = i.VendaID
    INNER JOIN Produto p ON i.ProdutoID = p.IdProduto
	inner join Usuario u on v.UsuarioID=u.UsuarioID
	inner join Funcionario f on u.FuncionarioID=f.FuncionarioID
	WHERE VendaID = @CodigoVenda
--group by v.IDVenda, i.quantidade, i.precoUnitario,f.Nome,v.dataVenda, v.NomeCliente,p.NomeProduto,v.TotalVenda, v.ValorEntregue,v.Desconto,v.Imposto
--,v.Troco,v.FormaPagamento ,i.ProdutoID, i.Total
END
EXEC ObterDadosVendateste 22
CREATE  PROCEDURE ObterDadosVendateste
(@CodigoVenda INT)
AS
BEGIN
SELECT v.IDVenda, v.NomeCliente, v.TotalVenda, v.DataVenda, v.ValorEntregue, v.Desconto, v.Imposto, v.Troco, v.FormaPagamento,
i.ProdutoID, p.NomeProduto, i.Quantidade, i.PrecoUnitario, i.Total, f.Nome AS NomeFuncionario
FROM Venda v
INNER JOIN ItemVenda i ON v.IDVenda = i.VendaID
INNER JOIN Produto p ON i.ProdutoID = p.IdProduto
INNER JOIN Usuario u ON v.UsuarioID = u.UsuarioID
INNER JOIN Funcionario f ON u.FuncionarioID = f.FuncionarioID
WHERE EXISTS (SELECT * FROM ItemVenda WHERE VendaID = @CodigoVenda)
--group by v.IDVenda, i.quantidade, i.precoUnitario,f.Nome,v.dataVenda, v.NomeCliente,p.NomeProduto,v.TotalVenda, v.ValorEntregue,v.Desconto,v.Imposto
--,v.Troco,v.FormaPagamento ,i.ProdutoID, i.Total
END











update  animal set usuarioID =2
select *from Animal

create    procedure ObterDadosAnimal
		@CodigoAnimal int 

AS
	BEGIN
		
SELECT
    a.AnimalID,
    a.Nome,
    CONCAT(p.Nome, ' ', p.Sobrenome, ' ', p.Apelido) AS proprietario,
    a.Especie,
    a.Raca,
    a.cor,
    a.Peso,
    a.Estado,
	CONCAT(f.Nome, ' ', f.Sobrenome, ' ', f.Apelido) AS Operador,
	CONVERT(date, a.DataNascimento) AS DataNascimento,
    CASE
    WHEN DATEDIFF(MONTH, a.DataNascimento, GETDATE()) < 12 THEN CONCAT(DATEDIFF(MONTH, a.DataNascimento, GETDATE()), ' mes(es)')
    ELSE CONCAT(DATEDIFF(YEAR, a.DataNascimento, GETDATE()), ' ano(s)')
END AS Idade,


    a.foto,
    a.observacao,
    a.DataCdastro,
    a.Porte,
    a.sexo
FROM
    Animal a
    INNER JOIN proprietario p ON a.ProprietarioID = p.ProprietarioID
	inner join Usuario u on u.UsuarioID=a.UsuarioID
	inner join Funcionario f on f.FuncionarioID=u.FuncionarioID
where AnimalID = @CodigoAnimal
		end

	exec ObterDadosAnimal 46
	alter table animal add DataCdastro DATETIME default getdate()
	alter table animal alter 
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



select *from proprietario
select *from IItensRegistroVacina
select *from Animal 