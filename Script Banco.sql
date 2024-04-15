--SCRIPT CRIAÇÃO DE TABELA
CREATE TABLE tb_lampada 
            (id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 id_sensor INT FOREIGN KEY (id_sensor) REFERENCES tb_sensor (id) NULL,
			 nome VARCHAR(30) NOT NULL, 
			 descricao VARCHAR(100) NULL,
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 data_ultima_atualizacao DATETIME NULL,
			 quantidade_vezes_ligacao INT NULL,
			 bloco VARCHAR(5) NULL,
			 tipo VARCHAR(10) NOT NULL,
			 preco NUMERIC NULL,
			 situacao_lampada VARCHAR(10) NOT NULL, --Ligado, Desligado
			 status_lampada VARCHAR(15) NOT NULL) --Funcionando, Queimado

CREATE TABLE tb_sensor
            (id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 nome VARCHAR(30) NOT NULL,
			 descricao VARCHAR(100) NULL,
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 tipo_sensor VARCHAR(10) NOT NULL, --Luz, Presença
			 bloco VARCHAR(5) NULL,
			 preco decimal NULL,
			 tipo VARCHAR(10) NOT NULL,
			 status_sensor VARCHAR(15) NOT NULL) --Funcionando, Queimado


CREATE TABLE tb_usuario
            (id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
			 usuario VARCHAR(20) NOT NULL,
			 senha VARCHAR(30) NOT NULL)


			update tb_lampada set data_ultima_atualizacao = GETDATE() where id_lampada = 18



			 SELECT * FROM tb_lampada

			 SELECT * FROM tb_sensor

			 delete tb_sensor
			 delete tb_lampada


			 drop table tb_lampada

			 drop table tb_sensor


			update tb_lampada set status_lampada = 'Funcionando', situacao_lampada = 'Ligado' where id_lampada = 4


			update tb_sensor set status_sensor = 'Funcionando' where id_sensor = 2
				update tb_sensor set nome_sensor = 'Sensor presença' where id_sensor = 1




				select * from tb_lampada where status_lampada = 'Funcionando' and id_sensor = 2

				select * from tb_sensor


--BL: Bloco
--A: Andar
--SP: Sensor de Presença
--SP: Sensor de Luz
--L: Lâmpada




------------insert---------------------------------


			
INSERT INTO tb_sensor
            (nome, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 tipo,
			 status_sensor,
			 descricao,
			 preco)
     VALUES
            ('BL1_A1_SL1', 
			 '10/05/2023', 
			 'Luz',
			 'BL1',
			 'Sensor',
			 'Funcionando',
			 'Numero da nota 4558877',
			  25.50)

INSERT INTO tb_sensor
            (nome, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 tipo,
			 status_sensor,
			 descricao,
			 preco)
     VALUES
            ('BL2_A2_SL1', 
			 '10/15/2023', 
			 'Luz',
			 'BL2',
			 'Sensor',
			 'Funcionando',
			 'Numero da nota 4558877',
			  25.50)

INSERT INTO tb_sensor
            (nome, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 tipo,
			 status_sensor,
			 descricao,
			 preco)
     VALUES
            ('BL2_A3_SL1', 
			 '10/15/2023', 
			 'Luz',
			 'BL2',
			 'Sensor',
			 'Funcionando',
			 'Numero da nota 4558877',
			  25.50)

INSERT INTO tb_sensor
            (nome, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 tipo,
			 status_sensor,
			 descricao,
			 preco)
     VALUES
            ('BL3_A1_SL1', 
			 '10/15/2023', 
			 'Luz',
			 'BL3',
			 'Sensor',
			 'Funcionando',
			 'Numero da nota 4558877',
			  25.50)

INSERT INTO tb_sensor
            (nome, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 tipo,
			 status_sensor,
			 descricao,
			 preco)
     VALUES
            ('BL1_A1_SP1', 
			 '10/20/2023', 
			 'Presença',
			 'BL1',
			 'Sensor',
			 'Funcionando',
			 'Numero da nota 4558877',
			  25.50)


			 INSERT INTO tb_sensor
            (nome, 
			 data_inclusao, 
			 tipo_sensor,
			 tipo,
			 status_sensor,
			 descricao,
			 preco)
     VALUES
            ('NoEstoque', 
			 '10/20/2023', 
			 'Presença',
			 'Sensor',
			 'No estoque',
			 'Numero da nota 4558877',
			  25.50)

----------------------------------------------------
INSERT INTO tb_lampada 
            (id_sensor,
			 nome, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 bloco,
			 tipo,
			 quantidade_vezes_ligacao,
			 descricao,
			 preco)
	  VALUES (1,
	          'BL1_A1_L1',
	          '10/05/2023',
			  '10/20/2023',
			  'Desligado',
			  'Funcionando',
			  'BL1',
			  'Lampada',
			  5,
			  'Numero da nota 1531685343',
			  10.00)


			  INSERT INTO tb_lampada 
            (id_sensor,
			 nome, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 bloco,
			 tipo,
			 quantidade_vezes_ligacao,
			 descricao,
			 preco)
	  VALUES (1,
	          'BL1_A1_L2',
	          GETDATE(),
			  GETDATE(),
			  'Ligado',
			  'Funcionando',
			  'BL1',
			  'Lampada',
			  5,
			  'Numero da nota 1531685343',
			  10.00)


			  INSERT INTO tb_lampada 
            (id_sensor,
			 nome, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao,
			 bloco,
			 tipo,
			 data_fim,
			 descricao,
			 preco)
	  VALUES (2,
	          'BL2_A2_L1',
	          '07/01/2023 15:30',
			  GETDATE() - 1,
			  'Desligado',
			  'Queimado',
			  150,
			  'BL2',
			  'Lampada',
			  GETDATE(),
			  'Numero da nota 1531685343',
			  10.00)

  INSERT INTO tb_lampada 
            (nome, 
			 data_inclusao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao,
			 tipo,
			 data_fim,
			 descricao,
			 preco)
	  VALUES ('No estoque',
	          '07/01/2023 15:30',
			  'Desligado',
			  'No estoque',
			  0,
			  'Lampada',
			  GETDATE(),
			  'Numero da nota 1531685343',
			  10.00)