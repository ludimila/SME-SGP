USE [GestaoPedagogica]
GO

BEGIN TRANSACTION 
SET XACT_ABORT ON   

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Histórico - Atualizar escola', ser_descricao = 'Atualização do nome e do código das escolas com as informações do histórico.'
	WHERE ser_nomeProcedimento = 'MS_JOB_EscolaHistorico_AtualizarEscola'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Arquivos - Exclusão', ser_descricao = 'Deleta fisicamente os arquivos excluídos logicamente ou temporários.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ArquivosExclusao'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de Classe - Aulas', ser_descricao = 'Atualização dos dados das aulas vindas do diário de classe.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaAulas_DiarioClasse'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Planejamento', ser_descricao = 'Atualização dos dados dos planejamentos vindos do diário de classe.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaPlanejamento_DiarioClasse'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Log', ser_descricao = 'Atualização dos dados dos logs vindos do diário de classe.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaLogs_DiarioClasse'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Justificativa de falta', ser_descricao = 'Atualização dos dados das justificativas de falta vindas do diário de classe.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaJustificativa_DiarioClasse'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Foto', ser_descricao = 'Atualização das fotos dos alunos vindos do diário de classe.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaFoto_DiarioClasse'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Compensação de ausência', ser_descricao = 'Atualização dos dados das compensações de ausência vindas do diário de classe.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaCompensacao_DiarioClasse'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Recálculo frequência', ser_descricao = 'Recálculo da frequência no fechamento baseado em aulas previstas.'
	WHERE ser_nomeProcedimento = 'MS_JOB_FechamentoRecalcularFrequenciaAulasPrevistas'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Histório - Geração/atualização', ser_descricao = 'Geração/atualização de histórico pedagógico para os alunos.'
	WHERE ser_nomeProcedimento = 'MS_JOB_GeracaoHistoricoPedagogico'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Programa social - Frequência', ser_descricao = 'Processar frequências no programa social.'
	WHERE ser_nomeProcedimento = 'MS_JOB_FrequenciaProgramaSocial'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Matriculas - Atualizar', ser_descricao = 'Atualiza os registros de matrículas dos alunos no boletim.'
	WHERE ser_nomeProcedimento = 'MS_JOB_MatriculasBoletim_Atualizar'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Frequência ajustada', ser_descricao = 'Atualiza a frequência ajustada no fechamento do último bimestre, dos registros afetados.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaFrequenciaAjustadaFinal'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Pendências', ser_descricao = 'Faz o pré procesamento do relatório de pendências por disciplinas e alunos.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoRelatorioDisciplinasAlunosPendencias'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Notas e faltas', ser_descricao = 'Faz o pré procesamento de notas e faltas para o fechamento'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoNotaFrequenciaFechamento'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Processamento abertura', ser_descricao = 'Insere registros da tabela pré processada para fechamento no dia da abertura do evento.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaFechamento_AberturaEvento'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Abertura evento', ser_descricao = 'Processa as pendências da escola no bimestre de acordo com a abertura do evento.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoPendenciasAberturaEvento'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Atribuições esporádicas - Atualizar', ser_descricao = 'Atualizar os status das atribuições esporádicas.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaAtribuicoesEsporadicas'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Frequência - Indicador', ser_descricao = 'Atualiza as informações pré calculadas da tabela de indicador de frequência.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaIndicadorFrequencia'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Processamento', ser_descricao = 'Faz o pré procesamento de notas e faltas para o novo fechamento em paralelo.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoNotaFrequenciaFechamentoParalelo'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Pendências - Aulas sem plano', ser_descricao = 'Faz o pré procesamento das pendências de aulas sem plano.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoPendenciaAulas'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Justificativa de abono', ser_descricao = 'Processa a remoção das faltas com justificativa de abono.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoAbonoFalta'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Anos anteriores', ser_descricao = 'Processa a abertura/fechamento das turmas dos anos anteriores.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoAberturaTurmaAnosAnteriores'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Divergências rematrículas - Processa dados', ser_descricao = 'Processa os dados para o relatório de divergências de rematrículas.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoDivergenciasRematriculas'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Aulas previstas', ser_descricao = 'Processa os dados para a sugestão das aulas previstas.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoSugestaoAulasPrevistas'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Aulas previstas toda rede', ser_descricao = 'Processa os dados para a sugestão das aulas previstas, para evento cadastrado para toda a rede.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoSugestaoAulasPrevistas_TodaRede'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Diário de classe - Divergências aulas previstas', ser_descricao = 'Processa as divergências entre registros de aulas dadas e aulas previstas.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoDivergenciasAulasPrevistas'

-- Fechar transação     
SET XACT_ABORT OFF 
COMMIT TRANSACTION