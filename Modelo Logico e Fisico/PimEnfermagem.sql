
drop database IF EXISTS PimEnfermagem2019

--Criando Banco de Dados
create database PimEnfermagem2019
go

--Utilizando Banco de Dados
use PimEnfermagem2019
go

-- Criando Tabelas 

create table Pessoas
(
	IdPessoa int identity (1,1),
	TipoUsuario varchar (12),
	Usuario varchar (20),
	Senha Varchar(12),
	ConfSenha Varchar (12),
	Nome varchar(50) not null,
	DataNascimento datetime not null,
	Cpf varchar(15) not null,
	Sexo Varchar (10),
	EstadoCivil Varchar(15)

	constraint Pk_Pessoas primary key (IdPessoa)
);
go

Create table Enderecos
(
	IdEndereco int identity (1,1),
	Logradouro varchar (50) not null,
	Numero varchar (8) not null,
	Complemento Varchar(40),
	Cidade varchar (40)not null,
	Bairro varchar (40)not null,
	Estado varchar (2) not null,
	Cep varchar (10) not null,
	Fk_Pessoas_IdPessoa int

	constraint Pk_Enderecos primary key (IdEndereco)
);
go

create table Contatos
(
	IdContato int identity (1,1),
	Email varchar (70),
	Celular varchar (15) not null,
	Telefone varchar (15),
	
	Fk_Pessoas_IdPessoa int

	constraint Pk_Contatos primary key (IdContato)
);
go

create table Pacientes
(
	IdPaciente int identity(1,1),
	Religiao Varchar (40),
	NumeroFilhos varchar (2),
	Fk_Pessoas_IdPessoa int,
	Fk_Amnense_IdAmnense int,

	constraint Pk_Pacientes primary key (IdPaciente)
);
go

create table Alunos
(
	IdAluno int identity (1,1),
	Ra varchar (9),
	PeriodoAluno varchar (9),
	Semestre varchar (12),
	Fk_Pessoas_IdPessoa int,

	constraint Pk_Alunos primary key (IdAluno)
);
go

create table Professores
(
	IdProfessor int identity (1,1),
	NumeroUnipProf varchar (9),
	PeriodoProf varchar (9),
	Fk_Pessoas_IdPessoa int,

	constraint Pk_Professores primary key (IdProfessor)
);
go

create table Coordenadores
(
	IdCoordenador int identity (1,1),
	NumeroUnipCood varchar (9),
	PeriodoCood varchar (9),
	Fk_Pessoas_IdPessoa int,

	constraint Pk_Coordenadores primary key (IdCoordenador)
);
go

create table Enfermeiros
(
	IdEnfermeiro int identity (1,1),
	NumeroEnfermeiro varchar (9),
	PeriodoEnf varchar (9),
	Fk_Pessoas_IdPessoa int,

	constraint Pk_Enfermeiros primary key (IdEnfermeiro)
);
go

create table Amnense
(
	IdAmnense int identity (1,1),
	Tabagismo varchar (10),
	Etilismo varchar (9),
	DiabetesMellitus Varchar (18),
	Dislipidemias varchar (14),
	DoencaCardioVascular Varchar (22),
	DoencaMusculoEsqueletica Varchar (27),
	DoencaNeurologica varchar (19),
	DoencaRespiratoria varchar (20),
	DoencaRenal varchar (13),
	DisfuncaoSexual varchar (17),
	OutrosComorbidades varchar (20),
	IncontinenciaUrinaria varchar (23),
	incontinenciaFecal varchar (20),
	DeclinioCognitivo varchar (19),
	Hospitalizacao varchar (16),
	DiabetesMellitusFamiliar varchar (28),
	DislipidemiasFamiliar varchar (24),
	DoencaNeurologicaFamiliar varchar (29),
	DoencaCardioVascularFamiliar varchar (32),
	DoencaRenalFamiliar varchar (23),
	OutrosFamiliar varchar (16),
	Fk_Habitos_IdHabito int

	
	constraint Pk_Amnense primary key (IdAmnense)
);
go

create table Habitos
(
	IdHabito int identity (1,1),
	Frutas varchar (7),
	LeitesDerivados varchar (17),
	LeguminosasVerduras Varchar (21),
	Proteinas varchar (10),
	PaesMassasBatatas Varchar (22),
	Liquidos Varchar (9),
	QualidadeSono varchar (15),
	DormeMedicacao varchar (4),
	AtividadeFisica varchar (4),
	NumeroAtividadeFisica varchar (2),
	VidaSexual varchar (11),
	MultiplosParceiros varchar (4)
	
	constraint Pk_Habitos primary key (IdHabito)
);
go

create table Atendimentos
(
	IdAtendimento int identity (1,1),
	DescricaoAtendimento varchar (300),
	Fk_Pacientes_IdPaciente int,
	Fk_Alunos_IdAluno int,
	Fk_Professores_IdProfessor int,
	Fk_Coordenadores_IdCoordenador int,
	FK_Enfermeiros_IdEnfermeiro int,
	
	Constraint Pk_Atendimentos primary key (IdAtendimento)
);
go

create table Consultas
(
	IdConsulta int identity (1,1),
	ReceitaMedica varchar (300),
	DescricaoConsulta varchar (300),

	constraint Pk_Cosnultas primary key (IdConsulta)
);
go

create table Estoques
(
	IdProduto int identity (1,1),
	NomeProduto varchar (50) not null,
	QuantidadeProduto smallint,
	DescricaoProduto varchar (300),
	DataHrCadastroProduto Datetime not null

	constraint Pk_Estoques primary key (IdProduto)
);
go

create table LogEstoques
(
	IdLogEstoque int identity (1,1),
	QuantidadeUtilizada smallint,
	DataUtilizado Datetime,
	Fk_Consultas_IdConsulta int,
	Fk_Estoques_IdProduto int

	constraint Pk_LogEstoques primary key (IdLogestoque)
);
go

create table LogConsultas
(
	IdLogConsultas int identity (1,1),
	LocalAtendimento varchar (20),
	DataHrConsulta datetime,
	DataHrMarcada datetime,
	Fk_Consultas_IdConsulta int,
	Fk_Atendimentos_IdAtendimento int 

	constraint Pk_LogConsultas primary key (IdLogConsultas)

)
go
-- Adicionando Chave Estrangeira

alter table Enderecos
	add constraint FK_Enderecos_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Contatos 
	add constraint FK_Contatos_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;

go

alter table Pacientes
	add constraint Fk_Pacientes_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Alunos
	add constraint Fk_Alunos_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Professores
	add constraint Fk_Professores_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Coordenadores
	add constraint Fk_Coordenadores_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Enfermeiros
	add constraint Fk_Enfermeiros_Pessoas foreign key (Fk_Pessoas_IdPessoa)
	references Pessoas(IdPessoa)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Pacientes
	add constraint Fk_Pacientes_Amnense foreign key (Fk_Amnense_IdAmnense)
	references Amnense(IdAmnense)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Atendimentos
	add constraint Fk_Atendimentos_Pacientes foreign key (Fk_Pacientes_IdPaciente)
	references Pacientes(IdPaciente);
go

alter table Atendimentos
	add constraint Fk_Atendimentos_Aluno foreign key (Fk_Alunos_IdAluno)
	references Alunos(IdAluno);
go

alter table Atendimentos
	add constraint Fk_Atendimentos_Professores foreign key (Fk_Professores_IdProfessor)
	references Professores(IdProfessor);

go

alter table Atendimentos
	add constraint Fk_Atendimentos_Coordenadores foreign key (Fk_Coordenadores_IdCoordenador)
	references Coordenadores(IdCoordenador);
go

alter table Atendimentos
	add constraint Fk_Atendimentos_Enfermeiros foreign key (Fk_Enfermeiros_IdEnfermeiro)
	references Enfermeiros(IdEnfermeiro);
go

alter table LogEstoques
	add constraint Fk_LogEstoques_Consultas foreign key (Fk_Consultas_IdConsulta)
	references Consultas(IdConsulta)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table LogEstoques
	add constraint Fk_LogEstoques_Estoques foreign key (Fk_Estoques_IdProduto)
	references Estoques(IdProduto)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table LogConsultas
	add constraint Fk_LogConsutas_Consultas foreign key (Fk_Consultas_IdConsulta)
	references Consultas(IdConsulta)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table logConsultas
	add constraint Fk_LogConsultas_Atendimentos foreign key (Fk_Atendimentos_IdAtendimento)
	references Atendimentos(IdAtendimento)
	on DELETE CASCADE
	on UPDATE CASCADE;
go

alter table Amnense
	add constraint Fk_Amnense_Habitos foreign key (Fk_Habitos_IdHabito)
	references Habitos(IdHabito)
	on DELETE CASCADE
	on UPDATE CASCADE;

	
	select * from Pessoas
	select * from Contatos
	select * from Enderecos
	select * from Enfermeiros
	select * from Coordenadores
	select * from  Professores
	select * from  Alunos
	select * from  Pacientes

	insert into Pessoas(TipoUsuario, Usuario, Senha, ConfSenha, Nome, DataNascimento, Cpf, Sexo, EstadoCivil)
	values ('Professor','Admin','Admin', 'Admin', 'Admin','26-01-1993','00000000', 'Masculino','Solteiro')

