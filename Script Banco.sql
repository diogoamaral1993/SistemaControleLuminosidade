--SCRIPT CRIAÇÃO DE TABELA
CREATE TABLE tb_lampada 
            (id_lampada INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 id_sensor INT FOREIGN KEY (id_sensor) REFERENCES tb_sensor (id_sensor) NOT NULL,
			 nome_lampada VARCHAR(30) NOT NULL, 
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 data_ultima_atualizacao DATETIME NULL,
			 quantidade_vezes_ligacao INT NULL,
			 situacao_lampada VARCHAR(10) NOT NULL, --Ligado, Desligado
			 status_lampada VARCHAR(15) NOT NULL) --Funcionando, Queimado

CREATE TABLE tb_sensor
            (id_sensor INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 nome_sensor VARCHAR(30) NOT NULL,
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 tipo_sensor VARCHAR(10), --Luz, Presença
			 status_sensor VARCHAR(15) NOT NULL) --Funcionando, Queimado


--SCRIPT INSERT DE DADOS TESTE
INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao)
	  VALUES (2,
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
	  VALUES (2,
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
	  VALUES (2,
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
			 tipo_sensor,
			 status_sensor)
     VALUES
            ('Sensor luminosidade 1', 
			 '10/05/2023', 
			 'Luz',
			 'Funcionando')

INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 tipo_sensor,
			 status_sensor)
     VALUES
            ('Sensor luminosidade 3', 
			 '10/20/2023', 
			 'Presença',
			 'Funcionando')


			 SELECT * FROM tb_lampada

			 SELECT * FROM tb_sensor

			 delete tb_sensor
			 delete tb_lampada


			 drop table tb_lampada

			 drop table tb_sensor


			update tb_lampada set status_lampada = 'Funcionando', situacao_lampada = 'Ligado' where id_lampada = 4


			update tb_sensor set status_sensor = 'Queimado' where id_sensor = 1
				update tb_sensor set nome_sensor = 'Sensor presença' where id_sensor = 1

