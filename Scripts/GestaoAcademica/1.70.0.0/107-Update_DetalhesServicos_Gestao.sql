USE [CoreSSO]
GO

BEGIN TRANSACTION 
SET XACT_ABORT ON   

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização do nome e do código das escolas com as informações do histórico'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Arquivos'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização dos dados das aulas vindas do diário de classe'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização dos dados dos planejamentos vindos do diário de classe'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização dos dados dos logs vindos do diário de classe'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização dos dados das justificativas de falta vindas do diário de classe'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização das fotos dos alunos vindos do diário de classe'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualização dos dados das compensações de ausência vindas do diário de classe'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Recálculo da frequência no fechamento baseado em aulas previstas.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Geração/atualização de histórico pedagógico para os alunos'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processar frequências no programa social'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualiza os registros de matrículas dos alunos no boletim'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualiza a frequência ajustada no fechamento do último bimestre, dos registros afetados'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Faz o pré procesamento do relatório pendências por disciplinas e alunos'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Faz o pré procesamento de notas e faltas para o novo fechamento'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Joga registros da tabela pré-processada para fechamento no dia da abertura do evento'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa as pendências da escola no bimestre de acordo com a abertura do evento.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualizar os status das atribuições esporádicas'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Atualiza as informações pré-calculadas da tabela CLS_IndicadorFrequencia.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Faz o pré procesamento de notas e faltas para o novo fechamento em paralelo'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Faz o pré procesamento das pendências de aulas sem plano'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa a remoção das faltas com justificativa de abono.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa a abertura/fechamento das turmas dos anos anteriores.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa os dados para o relatório de divergências de rematrículas.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa os dados para a sugestão das aulas previstas.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa os dados para a sugestão das aulas previstas, para evento cadastrado para toda a rede.'

	UPDATE [SYS_Servicos]
	SET ser_descricao = ''
	WHERE ser_nome = 'Processa as divergências entre registros de aulas dadas e aulas previstas.'

-- Fechar transação     
SET XACT_ABORT OFF 
COMMIT TRANSACTION