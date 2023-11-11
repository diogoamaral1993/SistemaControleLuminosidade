-------------------------------------
---limpando as tabelas---------------
-------------------------------------

drop table tb_lampada

drop table tb_sensor

-------------------------------------
---Insert na tabela na tb_sensor-----
-------------------------------------

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
			 'Presença',
			 'BL1',
			 'Funcionando')

-------------------------------------
---Insert na tabela na tb_lampada----
-------------------------------------

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
	  VALUES (3,
	          'BL2_A3_L1',
	          '07/01/2023 15:30',
			  GETDATE() - 1,
			  'Desligado',
			  'Queimado',
			  150,
			  'BL2',
			  GETDATE())


INSERT INTO tb_lampada 
            (id_sensor,
			 nome_lampada, 
			 data_inclusao,
			 data_ultima_atualizacao,
			 situacao_lampada,
			 status_lampada,
			 bloco,
			 quantidade_vezes_ligacao)
	  VALUES (3,
	          'BL3_A1_L1',
	          GETDATE(),
			  GETDATE(),
			  'Ligado',
			  'Funcionando',
			  'BL3',
			  15)