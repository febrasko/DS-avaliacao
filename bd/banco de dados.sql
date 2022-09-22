create database escola;
use escola;

create table desempenho_alunos(
nome varchar(100),
rm char(11) primary key,
intemediaria1 varchar(2),
final1 varchar(2),
intemediaria2 varchar(2),
final2 varchar(2),
faltas float,
resultado varchar(12)
);

create table professores(
nome varchar(100),
rm char(11) primary key,
cpf char(11),
email varchar(100),
telefone varchar(20),
endereco varchar(200),
disciplinas varchar(200),
salario float
);

insert into desempenho_alunos values('Silas Kando', '20222930066', 'MB', 'MB', 'MB', 'MB', 0, 'Aprovado');
insert into desempenho_alunos values('Victor Schiavon', '20222930021', 'I', 'I', 'MB', 'MB', 2.5, 'Aprovado');
insert into desempenho_alunos values('Leonardo Biffe', '20222930045', 'R', 'B', 'R', 'R', 11.5, 'Aprovado');
insert into desempenho_alunos values('Volkswagen dos Santos', '20222930099', 'B', 'MB', 'MB', 'I', 5, 'Aprovado');
insert into desempenho_alunos values('Desaparecido de Oliveira', '20222930033', 'I', 'I', 'I', 'I', 125, 'Reprovado');
insert into desempenho_alunos values('Pontiac Firebird', '20222930011', 'MB', 'MB', 'MB', 'MB', 125, 'Aprovado');
insert into desempenho_alunos values('Neymar Junior Junior Junior', '20222930010', 'B', 'B', 'B', 'B', 10, 'Aprovado');
insert into desempenho_alunos values('Zinedine Zidane', '20222930087', 'I', 'MB', 'I', 'MB', 0.2, 'Aprovado');
insert into desempenho_alunos values('Lídia Mante', '20222930009', 'I', 'R', 'B', 'MB', 0, 'Aprovado');
insert into desempenho_alunos values('Junessa Oliveira', '20222930082', 'MB', 'MB', 'MB', 'MB', 66.6, 'Aprovado');
insert into desempenho_alunos values('Andressa Bonda', '20222930055', 'B', 'B', 'B', 'R', 44.5, 'Aprovado');
insert into desempenho_alunos values('Son Goku', '20222930038', 'MB', 'MB', 'MB', 'MB', 0, 'Aprovado');
insert into desempenho_alunos values('João Fute Bol', '20222930076', 'MB', 'R', 'B', 'MB', 0, 'Aprovado');
insert into desempenho_alunos values('Dom Pedro Décimo Quinto', '20222930015', 'MB', 'MB', 'MB', 'MB', 19, 'Aprovado');
insert into desempenho_alunos values('Patrick Bateman', '20222930051', 'MB', 'MB', 'MB', 'MB', 0, 'Reprovado');

insert into professores values('Silas Kow', '11111111111', '00000000001', 'silas@kow.com', '11999999999', 'Ali', 'Programação em Bloco de Notas', 99999);
insert into professores values('Roberto Vatto', '11111111112', '00000000002', 'volks@vatto.com', '11999999999', 'Aqui', 'Alquimia', 12.50);
insert into professores values('Vasco da Gama', '11111111113', '00000000003', 'vas@kow.com', '11999999999', 'Portugal', 'Literatura Quântica', 1200.00);
insert into professores values('Groenlandio dos Santos', '11111111114', '00000000004', 'groen@landio.com', '11999999999', 'Norte', 'Paint', 99999);
insert into professores values('Marco Aurélio', '11111111115', '00000000005', 'email@generico.com', '11999999999', 'Roma', 'Filosofia', 6666.66);
insert into professores values('JC Denton', '11111111116', '00000000006', 'email@generico.com', '11999999999', 'Nova Iorque', 'Cybercucking', 99999);
insert into professores values('Lenovo Araujo', '11111111117', '00000000007', 'email@generico.com', '11999999999', 'Dentro de um PC', 'Doxxing', 99999);
insert into professores values('Silvio Saveiro', '11111111118', '00000000008', 'email@generico.com', '11999999999', 'Em movimento', 'Corridas Ilegais', 99999);
insert into professores values('X Souza', '11111111119', '00000000009', 'email@generico.com', '11999999999', 'Ponto Nemo', 'Design Quântico', 99999);
insert into professores values('Doutor Douglas', '11111111110', '00000000010', 'email@generico.com', '11999999999', 'Lá', 'Urologia', 99999);
insert into professores values('Rafa El', '11111111121', '000000000021', 'email@generico.com', '11999999999', 'Do meu lado', 'Desenvolvimento de Sistemas', 99999);
insert into professores values('Edigar Herculano', '11111111167', '00000000067', 'email@generico.com', '11999999999', 'Não Sei', 'Programação Web', 99999);
insert into professores values('Gustavo Guanabara', '11111111182', '00000000082', 'email@generico.com', '11999999999', 'Hell de Janeiro', 'PHP', 99999);
insert into professores values('Carl Johnson', '11111111199', '00000000099', 'email@generico.com', '11999999999', 'Groove Street', 'Desenvolvimento de Jogos', 99999);
insert into professores values("Samsara Al'Abbas", '11111111134', '00000000034', 'email@generico.com', '11999999999', 'Valhalla', 'Filosofia Oriental', 99999);
insert into professores values('Magnus Chase', '11111111177', '00000000077', 'email@generico.com', '11999999999', 'Valhalla', 'Banco de Dados', 99999);
insert into professores values('Manuel Neuer', '11111111234', '00000001234', 'email@generico.com', '11999999999', 'Alemanha', 'Cybersegurança', 99999);