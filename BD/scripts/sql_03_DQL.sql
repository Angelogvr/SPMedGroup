USE SPMEDGROUP_A
GO

SELECT * FROM usuario
SELECT * FROM paciente
SELECT * FROM medico
SELECT * FROM consulta
SELECT * FROM especialidade

--Contar quantos médicos certa especialidade têm
SELECT COUNT(idMedico)
FROM medico
WHERE idEspecialidade = 17
GO

--Criou uma função para retornar a quantidade de médicos de uma determinada especialidade
CREATE PROCEDURE P_Idade
AS  
SELECT  nomeUsuario, DATEDIFF(YEAR, (dataDeNascimento), GETDATE()) AS 'Idade'
FROM paciente
INNER JOIN Usuario 
ON paciente.idUsuario = usuario.idUsuario
GO

EXEC P_Idade;
GO

--Converteu a data de nascimento do usuário para o formato (mm-dd-yyyy) na exibição
SELECT  nomeUsuario 'Nome', FORMAT (dataDeNascimento, 'dd-MM-yyyy') 'Data Nascimento' FROM paciente 
INNER JOIN usuario
ON usuario.idUsuario = paciente.idUsuario

--Mostrou a quantidade de usuários após realizar a importação do banco de dados
SELECT COUNT(idUsuario) 'Quantidade de usuários' FROM usuario;
GO