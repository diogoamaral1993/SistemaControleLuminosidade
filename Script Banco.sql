--SCRIPT CRIAÇÃO DE TABELA
CREATE TABLE tb_lampada 
            (id_lampada INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 id_sensor INT FOREIGN KEY (id_sensor) REFERENCES tb_sensor (id_sensor) NOT NULL,
			 nome_lampada VARCHAR(30) NOT NULL, 
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 data_ultima_atualizacao DATETIME NULL,
			 quantidade_vezes_ligacao INT NULL,
			 situacao_lampada VARCHAR(10) NOT NULL, --L(Ligada), D(Desligada)
			 status_lampada VARCHAR(15) NOT NULL) --A(Ativa), I(Inativa)

CREATE TABLE tb_sensor
            (id_sensor INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 nome_sensor VARCHAR(30) NOT NULL,
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 status_sensor CHAR(1) NOT NULL) --A(Ativa), I(Inativa)


--SCRIPT INSERT DE DADOS TESTE
INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao)
	  VALUES (1,
	          'BL1_A1_SP1.1_L1',
	          '10/05/2023',
			  '10/20/2023',
			  'Desligado',
			  'Funcionando',
			  5)


			  INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao)
	  VALUES (1,
	          'BL1_A1_SP1.1_L2',
	          GETDATE(),
			  GETDATE(),
			  'Ligado',
			  'Funcionando',
			  5)


			  INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao,
			 data_fim)
	  VALUES (1,
	          'BL1_A1_SP1.1_L2',
	          '07/01/2023 15:30',
			  GETDATE() - 1,
			  'Desligado',
			  'Queimado',
			  150,
			  GETDATE())


			update tb_lampada set data_ultima_atualizacao = GETDATE() where id_lampada = 18
			
INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 status_sensor)
     VALUES
            ('Sensor luminosidade', 
			 '10/05/2023', 
			 'A')


			 SELECT * FROM tb_lampada

			 SELECT * FROM tb_sensor

			 delete tb_lampada

			 drop table tb_lampada

			 drop table tb_sensor



			update tb_lampada set status_lampada = 'Funcionando' where id_lampada = 21