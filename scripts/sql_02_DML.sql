USE SPMEDGROUP
GO

INSERT INTO tipoUsuario (tituloUsuario)
VALUES
	('Médico'),
	('Paciente'),
	('Administrador')
GO

INSERT INTO usuario (idTipoUsuario, nomeUsuario, email, senha)
VALUES 
	(2, 'Ligia', 'ligia@gmail.com', 'ligia123'),
	(2, 'Alexandre', 'alexandre@gmail.com', 'alexandre123'),
	(2, 'Fernando', 'fernando@gmail.com', 'fernando123'),
	(2, 'Henrique', 'henrique@gmail.com', 'henrique123'),
	(2, 'João', 'joao@hotmail.com', 'joao123'),
	(2, 'Bruno', 'bruno@gmail.com', 'bruno123'),
	(2, 'Mariana', 'mariana@outlook.com', 'mariana123'),
	(1, 'Ricardo Lemos', 'ricardo@gmail.com', 'ricardo123'),
	(1, 'Roberto Possarle', 'roberto@outlook.com', 'roberto123'),
	(1, 'Helena Strada', 'helena@gmail.com', 'helena123')

GO

INSERT INTO paciente (idUsuario, dataDeNascimento, telefone, rg, cpf, endereco)
VALUES 
	(1, '13/10/1983', '11 3456-7654', '43522543-5', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000'),
	(2, '23/07/2001', '11 98765-6543', '32654345-7', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200'),
	(3, '10/10/1978', '11 97208-4453', '54636525-3', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200'),
	(4, '13/10/1985', '11 3456-6543', '54366362-5', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030'),
	(5, '27/08/1975', '11 7656-6377', '53254444-1', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380'),
	(6, '21/03/1972', '11 95436-8769', '54566266-7', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001'),
	(7, '05/03/2018', '', '54566266-8', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140')
GO

INSERT INTO clinica (nomeFantasia, endereco, funcionamento, cnpj, razaoSocial)
VALUES
	('Clinica Possarle', 'Av. Barão Limeira, 532, São Paulo, SP', '', '86.400.902/0001-30', 'SP Medical Group')
GO

INSERT INTO especialidade (nomeEspecialidade)
VALUES
	('Acupuntura'),
	('Anestesiologia'),
	('Angiologia'),
	('Cardiologia'),
	('Cirurgia Cardiovascular'),
	('Cirurgia da Mão'),
	('Cirurgia do Aparelho Digestivo'),
	('Cirurgia Geral'),
	('Cirurgia Pediátrica'),
	('Cirurgia Plástica'),
	('Cirurgia Torácica'),
	('Cirurgia Vascular'),
	('Dermatologia'),
	('Radioterapia'),
	('Urologia'),
	('Pediatria'),
	('Psiquiatria')
GO

INSERT INTO medico (idUsuario, idClinica, idEspecialidade, crm)
VALUES
	(8, 1, 2,'54356-SP'),
	(9, 1, 17,'53452-SP'),
	(10, 1, 16,'65463-SP')
GO

INSERT INTO situacao (descSituacao)
VALUES
	('Realizada'),
	('Agendada'),
	('Cancelada')
GO

INSERT INTO consulta (idMedico, idUsuario, idSituacao, dataConsulta, horario, descricao)
VALUES
	(3, 10, 1, '20/01/2020', '15:00', ''),
	(2, 9, 3, '06/01/2020', '10:00', ''),
	(2, 9, 1, '07/02/2020', '11:00', ''),
	(2, 9, 1, '06/02/2018', '10:00', ''),
	(1, 8, 3, '07/02/2019', '11:00', ''),
	(3, 10, 2, '08/03/2020', '15:00', ''),
	(1, 8, 2, '09/03/2020', '11:00', '')
GO

