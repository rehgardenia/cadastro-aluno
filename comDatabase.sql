-- criar banco de dados
create database dbAcademico;
-- excluir um banco de dados = "drop database {nome}"
drop database dbAcademico;
-- ativar o banco de dados criado ( por padrão vem o nativo)
use dbAcademico;

-- criar a tabela Alunos no banco de dados
create table Alunos (
	Prontuario char(9) primary key,
	Nome varchar(50) not null ,
	Email varchar(50),
	RG char(12),
	CPF char(15) not null unique
);

-- inserir dados
INSERT INTO Alunos (Prontuario, Nome, Email, RG, CPF)
VALUES ('CB7852369', 'Julia Torres', 'joaninha@email.com', '75.856.963-8', '147852369-85');

-- consultar dados 
SELECT * FROM Alunos;

-- editar dados
UPDATE Alunos SET Email = 'gardenia@email.com' WHERE Prontuario='CB3013731';

-- remover dados
DELETE FROM Alunos 
WHERE Prontuario = '';

-- para excluir uma tabela = drop table {nome da tabela}
drop table Alunos;
