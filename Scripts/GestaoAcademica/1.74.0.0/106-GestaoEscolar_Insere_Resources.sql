USE [GestaoPedagogica]
GO

BEGIN TRANSACTION 
SET XACT_ABORT ON   

	/***************
		Copiar do exemplo abaixo.
	****************

        -- Insere resources. 
        EXEC MS_InsereResource 
            @rcr_chave = 'Relatorios.UCRelatorios.lblMessageLayout.MsgAviso' 
            , @rcr_NomeResource = 'WebControls'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'A visualiza��o do texto na tela abaixo n�o corresponde, necessariamente, ao formato no qual ele ser� impresso. Este formato segue as normas estabelecidas pela Secretaria Municipal de Educa��o.'

	*/

	EXEC MS_InsereResource 
        @rcr_chave = 'UCDadosBoletim.lblAEETitulo.Text' 
        , @rcr_NomeResource = 'UserControl'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Atendimento educacional especializado'

	EXEC MS_InsereResource 
        @rcr_chave = 'UCAlunoEfetivacaoObservacaoGeral.lblParecerFinalAEE.Text' 
        , @rcr_NomeResource = 'UserControl'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Parecer Final'

	EXEC MS_InsereResource 
        @rcr_chave = 'UCAlunoEfetivacaoObservacaoGeral.lblPorcentagemFreqAEE.Text' 
        , @rcr_NomeResource = 'UserControl'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = '% Freq.'

	EXEC MS_InsereResource 
        @rcr_chave = 'ControleTurma.Alunos.btnRelatorioRP.ToolTip' 
        , @rcr_NomeResource = 'Academico'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Anota��es da recupera��o paralela'
		
	EXEC MS_InsereResource 
        @rcr_chave = 'CLS_RelatorioAtendimentoBO.CLS_RelatorioAtendimentoTipo.AEE' 
        , @rcr_NomeResource = 'Enumerador'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'AEE'

	EXEC MS_InsereResource 
			@rcr_chave = 'CLS_RelatorioAtendimentoBO.CLS_RelatorioAtendimentoTipo.NAAPA' 
			, @rcr_NomeResource = 'Enumerador'
			, @rcr_cultura = 'pt-BR'
			, @rcr_codigo = 0 
			, @rcr_valorPadrao = 'NAAPA'

	EXEC MS_InsereResource 
			@rcr_chave = 'CLS_RelatorioAtendimentoBO.CLS_RelatorioAtendimentoTipo.RP' 
			, @rcr_NomeResource = 'Enumerador'
			, @rcr_cultura = 'pt-BR'
			, @rcr_codigo = 0 
			, @rcr_valorPadrao = 'Recupera��o paralela'

	EXEC MS_InsereResource 
			@rcr_chave = 'CLS_RelatorioPreenchimentoAlunoTurmaDisciplinaBO.RelatorioPreenchimentoAlunoSituacao.Rascunho' 
			, @rcr_NomeResource = 'Enumerador'
			, @rcr_cultura = 'pt-BR'
			, @rcr_codigo = 0 
			, @rcr_valorPadrao = 'Rascunho'

	EXEC MS_InsereResource 
			@rcr_chave = 'CLS_RelatorioPreenchimentoAlunoTurmaDisciplinaBO.RelatorioPreenchimentoAlunoSituacao.Finalizado' 
			, @rcr_NomeResource = 'Enumerador'
			, @rcr_cultura = 'pt-BR'
			, @rcr_codigo = 0 
			, @rcr_valorPadrao = 'Finalizado'

	EXEC MS_InsereResource 
			@rcr_chave = 'CLS_RelatorioPreenchimentoAlunoTurmaDisciplinaBO.RelatorioPreenchimentoAlunoSituacao.Aprovado' 
			, @rcr_NomeResource = 'Enumerador'
			, @rcr_cultura = 'pt-BR'
			, @rcr_codigo = 0 
			, @rcr_valorPadrao = 'Aprovado'

	EXEC MS_InsereResource 
        @rcr_chave = 'ControleTurma.Alunos.btnRelatorioAEE.ToolTip' 
        , @rcr_NomeResource = 'Academico'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Relat�rios do AEE'

	EXEC MS_InsereResource 
        @rcr_chave = 'TUR_TurmaHorarioBO.SalvarTurmaHorario.ValidacaoTemposAula' 
        , @rcr_NomeResource = 'BLL'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'O componente curricular {0} ultrapassou a carga hor�ria ({1}) na turma {2} em {3} aulas.'

	EXEC MS_InsereResource 
        @rcr_chave = 'RelatorioRecuperacaoParalela.Cadastro.pnlFiltros.GroupingText' 
        , @rcr_NomeResource = 'Classe'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Anota��es da recupera��o paralela'

	EXEC MS_InsereResource 
        @rcr_chave = 'RelatorioRecuperacaoParalela.Cadastro.btnNovo.Text' 
        , @rcr_NomeResource = 'Classe'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Nova anota��o'

	EXEC MS_InsereResource 
        @rcr_chave = 'RelatorioRecuperacaoParalela.Cadastro.btnSalvar.Text' 
        , @rcr_NomeResource = 'Classe'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Salvar'

	EXEC MS_InsereResource 
        @rcr_chave = 'RelatorioRecuperacaoParalela.Cadastro.btnCancelar.Text' 
        , @rcr_NomeResource = 'Classe'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'Cancelar'

	EXEC MS_InsereResource 
        @rcr_chave = 'RelatorioRecuperacaoParalela.Cadastro.grvLancamentos.EmptyDataText' 
        , @rcr_NomeResource = 'Classe'
        , @rcr_cultura = 'pt-BR'
        , @rcr_codigo = 0 
        , @rcr_valorPadrao = 'N�o existem anota��es de recupera��o paralela para o aluno.'

-- Fechar transa��o     
SET XACT_ABORT OFF 
COMMIT TRANSACTION



