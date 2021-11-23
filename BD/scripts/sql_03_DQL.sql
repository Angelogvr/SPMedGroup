USE SPMEDGROUP_A
GO

SELECT * FROM usuario
SELECT * FROM paciente
SELECT * FROM medico
SELECT * FROM consulta
SELECT * FROM especialidade

--Contar quantos m�dicos certa especialidade t�m
SELECT COUNT(idMedico)
FROM medico
WHERE idEspecialidade = 17
GO

--Criou uma fun��o para retornar a quantidade de m�dicos de uma determinada especialidade
CREATE PROCEDURE P_Idade
AS  
SELECT  nomeUsuario, DATEDIFF(YEAR, (dataDeNascimento), GETDATE()) AS 'Idade'
FROM paciente
INNER JOIN Usuario 
ON paciente.idUsuario = usuario.idUsuario
GO

EXEC P_Idade;
GO

--Converteu a data de nascimento do usu�rio para o formato (mm-dd-yyyy) na exibi��o
SELECT  nomeUsuario 'Nome', FORMAT (dataDeNascimento, 'dd-MM-yyyy') 'Data Nascimento' FROM paciente 
INNER JOIN usuario
ON usuario.idUsuario = paciente.idUsuario

--Mostrou a quantidade de usu�rios ap�s realizar a importa��o do banco de dados
SELECT COUNT(idUsuario) 'Quantidade de usu�rios' FROM usuario;
GO