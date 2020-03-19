
		create database testeforlogic

		use testeforlogic


		create table cadastroUsu   ( tipoUsu varchar (20),
									 idUsu int not null primary key, 
									 nomeUsu varchar (40),
									 emailUsu varchar(40), 
								     telefoneUsu varchar (12),
								     usuarioUsu varchar (20),
								     senhaUsu varchar (10));
									  


		create table emprestimos (data date,
								  tituloLocado varchar (40) primary key,
								  qtddLocado int,
								  valor float,
								  valorTotal float,
								  idUsuEmp int foreign key references cadastroUsu (idUsu));


		
		
		create table filmes (titulo varchar (40) primary key,
							 diretor varchar(40),
							 ano date,
							 genero varchar (20),
							 pais varchar (25),
							 idCustFil int foreign key references cadastroUsu (idUsu));



	  create table acessos (usuario varchar(20),
							idAc int not null primary key
							foreign key references cadastroUsu(idUsu));



		alter table emprestimos add dataDevol date, filmeStatus varchar (15);
								  
		select * from cadastroUsu



		insert into filmes (titulo,diretor,ano,genero,pais) values ('Minha mãe é uma Peça','Andre Pellens','2013/06/21','comedia','Brasil');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('As branquelas','Keenen I.','2004/08/27','comedia','EUA');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('Sexta-feira 13','Sean S.','1980/12/01','terror','EUA');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('Desaparecidos',' David S.','2011/12/09','terror','Brasil');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('Como eu era antes de Vc','Thea Sharrock','2016/06/16','romance','EUA');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('Romance','Guel Arraes','2008/11/14','romance','Brasil');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('Matrix','Lana W.','1999/05/21','acao','EUA');
		insert into filmes (titulo,diretor,ano,genero,pais) values ('Tropa de Elite','José Padilha','2007/10/05','acao','Brasil');
				  

				/* create view */

				create view qtdd_fromance as
				select genero, count (*) as 'Qtdd'
				from filmes
				group by genero

				select * from qtdd_fromance
				


			
		
