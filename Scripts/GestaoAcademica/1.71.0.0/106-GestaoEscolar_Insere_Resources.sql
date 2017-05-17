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
            @rcr_chave = 'CompensacaoAusencia.Busca.SemCompensacaoAusencia' 
            , @rcr_NomeResource = 'Classe'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'A pesquisa n�o encontrou resultados.'


		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ErroPesquisar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Erro ao tentar carregar as configura��es do servi�o de pend�ncia.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ErroPermissao' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Voc� n�o possui permiss�o para acessar a p�gina solicitada.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ErroInicializar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Erro ao tentar carregar os dados.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ErroSistema' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Erro ao tentar carregar o sistema.'





		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Configuracao.ErroCarregar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Erro ao tentar carregar a configura��o do servi�o de pend�ncia.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Configuracao.SucessoCadastrar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Configura��o do servi�o de pend�ncia cadastrada com sucesso.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Configuracao.SucessoAlterar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Configura��o do servi�o de pend�ncia alterada com sucesso.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Configuracao.ErroSalvar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Erro ao tentar salvar a configura��o do servi�o de pend�ncia.'


		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Configuracao.ErroSelecione' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Selecione o tipo de n�vel de ensino, o tipo de modalidade de ensino ou o tipo de turma.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Configuracao.ErroSistema' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Erro ao tentar carregar o sistema.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.lblLegend.Text' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Listagem de configura��o do servi�o de pend�ncia'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.btnPesquisar.Text' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Pesquisar'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ColunaEditar' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Editar'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ColunaPendencias' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Pend�ncias'
			
		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ColunaTipoModalidadeEnsino' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Tipo de modalidade de ensino'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.ColunaTipoNivelEnsino' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Tipo de n�vel de ensino'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.grvConfigServPendencia.EmptyDataText' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'A pesquisa n�o encontrou resultados.'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.btnLimparPesquisa.Text' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Limpar pesquisa'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.btnIncluirNovo.Text' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Incluir novo'

		EXEC MS_InsereResource 
            @rcr_chave = 'ConfiguracaoServicoPendencia.Busca.btnEditar.Tooltip' 
            , @rcr_NomeResource = 'Academico'
            , @rcr_cultura = 'pt-BR'
            , @rcr_codigo = 0 
            , @rcr_valorPadrao = 'Editar'

-- Fechar transa��o     
SET XACT_ABORT OFF 
COMMIT TRANSACTION



