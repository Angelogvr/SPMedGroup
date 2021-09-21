CREATE DATABASE SPMEDGROUP
GO

USE SPMEDGROUP
GO

CREATE TABLE tipoUsuario(
	idTipoUsuario INT PRIMARY KEY IDENTITY (1,1),
	tituloUsuario VARCHAR(15) UNIQUE NOT NULL
);
GO

CREATE TABLE usuario(
	idUsuario INT PRIMARY KEY IDENTITY (1,1),
	idTipoUsuario INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario),
	nomeUsuario VARCHAR (75) UNIQUE NOT NULL,
	email VARCHAR (256) UNIQUE NOT NULL,
	senha CHAR (20) NOT NULL
);
GO

CREATE TABLE paciente(
	idPaciente INT PRIMARY KEY IDENTITY (1,1),
	idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario),
	dataDeNascimento DATE NOT NULL,
	rg VARCHAR (13) UNIQUE NOT NULL,
	cpf VARCHAR (11) UNIQUE NOT NULL,
	telefone VARCHAR (15) UNIQUE,
	endereco VARCHAR (300) NOT NULL
);
GO


CREATE TABLE clinica(
	idClinica INT PRIMARY KEY IDENTITY (1,1),
	nomeFantasia VARCHAR (30) NOT NULL,
	endereco VARCHAR (75) UNIQUE NOT NULL,
	funcionamento TIME NOT NULL,
	cnpj VARCHAR (25) UNIQUE NOT NULL,
	razaoSocial VARCHAR (50) NOT NULL
)
GO

CREATE TABLE especialidade(
	idEspecialidade INT PRIMARY KEY IDENTITY (1,1),
	nomeEspecialidade VARCHAR (30) UNIQUE NOT NULL,
);
GO

CREATE TABLE medico(
	idMedico INT PRIMARY KEY IDENTITY (1,1),
	idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario),
	idClinica INT FOREIGN KEY REFERENCES clinica(idClinica),
	idEspecialidade INT FOREIGN KEY REFERENCES especialidade(idEspecialidade),
	crm VARCHAR (25) NOT NULL UNIQUE
);
GO

CREATE TABLE situacao(
	idSituacao INT PRIMARY KEY IDENTITY (1,1),
	descSituacao VARCHAR (25) NOT NULL,
);
GO

CREATE TABLE consulta(
	idConsulta INT PRIMARY KEY IDENTITY (1,1),
	idMedico INT FOREIGN KEY REFERENCES medico(idMedico),
	idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario),
	idSituacao INT FOREIGN KEY REFERENCES situacao(idSituacao),
	dataConsulta DATE NOT NULL,
	horario TIME NOT NULL,
	descricao VARCHAR (256) NOT NULL
);
GO


