--SCRIPT CRIA��O DE TABELA
CREATE TABLE tb_lampada 
            (id_lampada INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 id_sensor INT FOREIGN KEY (id_sensor) REFERENCES tb_sensor (id_sensor) NOT NULL,
			 nome_lampada VARCHAR(30) NOT NULL, 
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 data_ultima_atualizacao DATETIME NULL,
			 quantidade_vezes_ligacao INT NULL,
			 bloco VARCHAR(5) NOT NULL,
			 situacao_lampada VARCHAR(10) NOT NULL, --Ligado, Desligado
			 status_lampada VARCHAR(15) NOT NULL) --Funcionando, Queimado

CREATE TABLE tb_sensor
            (id_sensor INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
			 nome_sensor VARCHAR(30) NOT NULL,
			 data_inclusao DATETIME NOT NULL, 
			 data_fim DATETIME NULL,
			 tipo_sensor VARCHAR(10), --Luz, Presen�a
			 bloco VARCHAR(5) NOT NULL,
			 status_sensor VARCHAR(15) NOT NULL) --Funcionando, Queimado


--SCRIPT INSERT DE DADOS TESTE
INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 bloco,
			 quantidade_vezes_ligacao)
	  VALUES (1,
	          'BL1_A1_L1',
	          '10/05/2023',
			  '10/20/2023',
			  'Desligado',
			  'Funcionando',
			  'BL1',
			  5)


			  INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 bloco,
			 quantidade_vezes_ligacao)
	  VALUES (1,
	          'BL1_A1_L2',
	          GETDATE(),
			  GETDATE(),
			  'Ligado',
			  'Funcionando',
			  'BL1',
			  5)


			  INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 quantidade_vezes_ligacao,
			 bloco,
			 data_fim)
	  VALUES (2,
	          'BL2_A2_L1',
	          '07/01/2023 15:30',
			  GETDATE() - 1,
			  'Desligado',
			  'Queimado',
			  150,
			  'BL2',
			  GETDATE())


			update tb_lampada set data_ultima_atualizacao = GETDATE() where id_lampada = 18
			
INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 status_sensor)
     VALUES
            ('BL1_A1_SL1', 
			 '10/05/2023', 
			 'Luz',
			 'BL1',
			 'Funcionando')

INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 status_sensor)
     VALUES
            ('BL2_A2_SL1', 
			 '10/15/2023', 
			 'Luz',
			 'BL2',
			 'Funcionando')

INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 status_sensor)
     VALUES
            ('BL2_A3_SL1', 
			 '10/15/2023', 
			 'Luz',
			 'BL2',
			 'Funcionando')

INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 status_sensor)
     VALUES
            ('BL3_A1_SL1', 
			 '10/15/2023', 
			 'Luz',
			 'BL3',
			 'Funcionando')

INSERT INTO tb_sensor
            (nome_sensor, 
			 data_inclusao, 
			 tipo_sensor,
			 bloco,
			 status_sensor)
     VALUES
            ('BL1_A1_SP1', 
			 '10/20/2023', 
			 'Presen�a',
			 'BL1',
			 'Funcionando')


			 SELECT * FROM tb_lampada

			 SELECT * FROM tb_sensor

			 delete tb_sensor
			 delete tb_lampada


			 drop table tb_lampada

			 drop table tb_sensor


			update tb_lampada set status_lampada = 'Funcionando', situacao_lampada = 'Ligado' where id_lampada = 4


			update tb_sensor set status_sensor = 'Funcionando' where id_sensor = 2
				update tb_sensor set nome_sensor = 'Sensor presen�a' where id_sensor = 1




				select * from tb_lampada where status_lampada = 'Funcionando' and id_sensor = 2


--BL: Bloco
--A: Andar
--SP: Sensor de Presen�a
--SP: Sensor de Luz
--L: L�mpada