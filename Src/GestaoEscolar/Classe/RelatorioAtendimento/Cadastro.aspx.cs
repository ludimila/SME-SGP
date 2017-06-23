﻿namespace GestaoEscolar.Classe.RelatorioAtendimento
{
    using MSTech.CoreSSO.BLL;
    using MSTech.GestaoEscolar.BLL;
    using MSTech.GestaoEscolar.Entities;
    using MSTech.GestaoEscolar.Web.WebProject;
    using MSTech.Validation.Exceptions;
    using System;
    using System.Collections.Generic;
    public partial class Cadastro : MotherPageLogado
    {
        private long VS_alu_id
        {
            get
            {
                return Convert.ToInt64(ViewState["VS_alu_id"] ?? -1);
            }

            set
            {
                ViewState["VS_alu_id"] = value;
            }
        }

        private long VS_tur_id
        {
            get
            {
                return Convert.ToInt64(ViewState["VS_tur_id"] ?? -1);
            }

            set
            {
                ViewState["VS_tur_id"] = value;
            }
        }
        
        private int VS_cal_id
        {
            get
            {
                return Convert.ToInt32(ViewState["VS_cal_id"] ?? -1);
            }

            set
            {
                ViewState["VS_cal_id"] = value;
            }
        }

        /// <summary>
        /// Propriedade que seta a url de retorno da página.
        /// </summary>
        private string VS_PaginaRetorno
        {
            get
            {
                if (ViewState["VS_PaginaRetorno"] != null)
                    return ViewState["VS_PaginaRetorno"].ToString();

                return "";
            }
            set
            {
                ViewState["VS_PaginaRetorno"] = value;
            }
        }

        /// <summary>
        /// Propriedade que guarda dados necessários para a página de retorno.
        /// </summary>
        private object VS_DadosPaginaRetorno
        {
            get
            {
                return ViewState["VS_DadosPaginaRetorno"];
            }
            set
            {
                ViewState["VS_DadosPaginaRetorno"] = value;
            }
        }

        /// <summary>
        /// Propriedade que guarda dados necessários para a página de retorno Minhas turmas.
        /// </summary>
        private object VS_DadosPaginaRetorno_MinhasTurmas
        {
            get
            {
                return ViewState["VS_DadosPaginaRetorno_MinhasTurmas"];
            }
            set
            {
                ViewState["VS_DadosPaginaRetorno_MinhasTurmas"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UCCRelatorioAtendimento.IndexChanged += UCCRelatorioAtendimento_IndexChanged;
            UCCPeriodoCalendario.IndexChanged += UCCPeriodoCalendario_IndexChanged;

            int tpc_idSelecionado = -1;

            if (!IsPostBack)
            {
                try
                {
                    if ((PreviousPage != null) && PreviousPage.IsCrossPagePostBack)
                    {
                        VS_alu_id = PreviousPage.EditItemAluId;
                        VS_cal_id = PreviousPage.EditItemCalId;
                        VS_tur_id = PreviousPage.EditItemTurId;
                    }
                    else if (Session["PaginaRetorno_RelatorioAEE"] != null)
                    {
                        VS_PaginaRetorno = Session["PaginaRetorno_RelatorioAEE"].ToString();
                        Session.Remove("PaginaRetorno_RelatorioAEE");
                        VS_DadosPaginaRetorno = Session["DadosPaginaRetorno"];
                        Session.Remove("DadosPaginaRetorno");
                        VS_DadosPaginaRetorno_MinhasTurmas = Session["VS_DadosTurmas"];
                        Session.Remove("VS_DadosTurmas");

                        VS_alu_id = Convert.ToInt64(Session["alu_id_RelatorioAEE"].ToString());
                        Session.Remove("alu_id_RelatorioAEE");

                        Dictionary<string, string> dadosPaginaRetorno = (Dictionary<string, string>)VS_DadosPaginaRetorno;

                        VS_cal_id = Convert.ToInt32(dadosPaginaRetorno["Edit_cal_id"]);
                        VS_tur_id = Convert.ToInt64(dadosPaginaRetorno["Edit_tur_id"]);
                        tpc_idSelecionado = Convert.ToInt32(dadosPaginaRetorno["Edit_tpc_id"]);
                    }

                    UCCRelatorioAtendimento.CarregarPorPermissaoUuarioTipo(CLS_RelatorioAtendimentoTipo.AEE);
                    UCCPeriodoCalendario.CarregarPorCalendario(VS_cal_id);

                    if (tpc_idSelecionado > 0)
                    {
                        ACA_CalendarioPeriodo cap = ACA_CalendarioPeriodoBO.SelecionaPor_Calendario_TipoPeriodo(VS_cal_id, tpc_idSelecionado, ApplicationWEB.AppMinutosCacheLongo);

                        if (cap != null && cap.cap_id > 0)
                        {
                            UCCPeriodoCalendario.Valor = new[] { tpc_idSelecionado, cap.cap_id };
                        }
                    }

                    updFiltros.Update();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = UtilBO.GetErroMessage("Erro ao tentar carregar os dados.", UtilBO.TipoMensagem.Erro);
                    ApplicationWEB._GravaErro(ex);
                    updMensagem.Update();
                }
            }
        }

        private void CarregarRelatorio()
        {
            try
            {

                pnlLancamento.Visible = btnSalvar.Visible = btnSalvarBaixo.Visible = btnAprovar.Visible = btnAprovarBaixo.Visible =
                     btnDesaprovar.Visible = btnDesaprovarBaixo.Visible = false;

                if (UCCPeriodoCalendario.Valor[0] > 0 && UCCPeriodoCalendario.Valor[1] > 0 && UCCRelatorioAtendimento.Valor > 0)
                {
                    pnlLancamento.GroupingText = UCCRelatorioAtendimento.Texto;
                    UCLancamentoRelatorioAtendimento.Carregar(VS_alu_id, VS_tur_id, -1, UCCPeriodoCalendario.Valor[0], UCCRelatorioAtendimento.Valor, false);
                    pnlLancamento.Visible = true;

                    btnSalvar.Visible = btnSalvarBaixo.Visible = UCLancamentoRelatorioAtendimento.PermiteEditar &&
                                (ACA_ParametroAcademicoBO.ParametroValorBooleanoPorEntidade(eChaveAcademico.PERMITIR_EDITAR_RELATORIO_APROVADO, Ent_ID_UsuarioLogado) ||
                                 UCLancamentoRelatorioAtendimento.SituacaoRelatorioPreenchimento != (byte)RelatorioPreenchimentoAlunoSituacao.Aprovado);

                    btnAprovar.Visible = btnAprovarBaixo.Visible = UCLancamentoRelatorioAtendimento.PermiteAprovar &&
                        UCLancamentoRelatorioAtendimento.PreenchimentoFinalizado && UCLancamentoRelatorioAtendimento.SituacaoRelatorioPreenchimento == (byte)RelatorioPreenchimentoAlunoSituacao.Finalizado;

                    btnDesaprovar.Visible = btnDesaprovarBaixo.Visible = UCLancamentoRelatorioAtendimento.PermiteAprovar && UCLancamentoRelatorioAtendimento.PermiteEditar &&
                        UCLancamentoRelatorioAtendimento.SituacaoRelatorioPreenchimento == (byte)RelatorioPreenchimentoAlunoSituacao.Aprovado &&
                        !ACA_ParametroAcademicoBO.ParametroValorBooleanoPorEntidade(eChaveAcademico.PERMITIR_EDITAR_RELATORIO_APROVADO, Ent_ID_UsuarioLogado);

                    UCCPeriodoCalendario.PermiteEditar = UCCRelatorioAtendimento.PermiteEditar = false;
                }

                updBotoes.Update();
                updFiltros.Update();
                updLancamento.Update();
            }
            catch (PermissaoRelatorioPreenchimentoValidationException ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage(ex.Message, UtilBO.TipoMensagem.Alerta);
                updMensagem.Update();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage("Erro ao tentar carregar o relatório de atendimento.", UtilBO.TipoMensagem.Erro);
                ApplicationWEB._GravaErro(ex);
                updMensagem.Update();
            }
        }

        /// <summary>
        /// Verifica qual página deve voltar e redireciona.
        /// </summary>
        private void VerificaPaginaRedirecionar()
        {
            string url = "~/Classe/RelatorioAtendimento/Busca.aspx";

            if (!string.IsNullOrEmpty(VS_PaginaRetorno))
            {
                Session["DadosPaginaRetorno"] = VS_DadosPaginaRetorno;
                Session["VS_DadosTurmas"] = VS_DadosPaginaRetorno_MinhasTurmas;
                url = VS_PaginaRetorno;
            }

            RedirecionarPagina(url);
        }

        private void Salvar(bool aprovar)
        {
            try
            {
                RelatorioPreenchimentoAluno rel = UCLancamentoRelatorioAtendimento.RetornaQuestionarioPreenchimento(aprovar);
                List<CLS_AlunoDeficienciaDetalhe> lstAlunoDeficienciaDetalhe = UCLancamentoRelatorioAtendimento.RetornaListaDeficienciaDetalhe();
                if (CLS_RelatorioPreenchimentoBO.Salvar(rel, lstAlunoDeficienciaDetalhe, UCLancamentoRelatorioAtendimento.PermiteAlterarRacaCor, UCLancamentoRelatorioAtendimento.RacaCor))
                {
                    string msg = aprovar ? "Relatório de atendimento aprovado com sucesso." : "Relatório de atendimento preenchido com sucesso.";
                    __SessionWEB.PostMessages = UtilBO.GetErroMessage(msg, UtilBO.TipoMensagem.Sucesso);
                    ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Update, msg  + " | reap_id: " + rel.entityRelatorioPreenchimento.reap_id);
                    VerificaPaginaRedirecionar();
                }
            }
            catch (ValidationException ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage(ex.Message, UtilBO.TipoMensagem.Alerta);
                updMensagem.Update();
            }
            catch (Exception ex)
            {
                string msg = aprovar ? "Erro ao tentar aprovar o relatório de atendimento." : "Erro ao tentar salvar o relatório de atendimento.";
                lblMensagem.Text = UtilBO.GetErroMessage(msg, UtilBO.TipoMensagem.Erro);
                ApplicationWEB._GravaErro(ex);
                updMensagem.Update();
            }
        }

        private void Desaprovar()
        {
            try
            {
                CLS_RelatorioPreenchimentoAlunoTurmaDisciplina entity = UCLancamentoRelatorioAtendimento.RetornaQuestionarioPreenchimento(false).entityPreenchimentoAlunoTurmaDisciplina;
                entity.ptd_situacao = (byte)RelatorioPreenchimentoAlunoSituacao.Rascunho;
                if (CLS_RelatorioPreenchimentoAlunoTurmaDisciplinaBO.Save(entity))
                {
                    lblMensagem.Text = UtilBO.GetErroMessage("Relatório liberado para edição com sucesso.", UtilBO.TipoMensagem.Sucesso);
                    ApplicationWEB._GravaLogSistema(LOG_SistemaTipo.Update, "Relatório liberado para edição com sucesso. | reap_id: " + entity.reap_id);
                    updMensagem.Update();
                    CarregarRelatorio();
                }
            }
            catch (ValidationException ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage(ex.Message, UtilBO.TipoMensagem.Alerta);
                updMensagem.Update();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage("Erro ao tentar liberar relatório para edição.", UtilBO.TipoMensagem.Erro);
                ApplicationWEB._GravaErro(ex);
                updMensagem.Update();
            }
        }

        private void UCCPeriodoCalendario_IndexChanged()
        {
            try
            {
                CarregarRelatorio();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage("Erro ao tentar carregar os dados", UtilBO.TipoMensagem.Erro);
                ApplicationWEB._GravaErro(ex);
                updMensagem.Update();
            }
        }

        private void UCCRelatorioAtendimento_IndexChanged()
        {
            try
            {
                CarregarRelatorio();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = UtilBO.GetErroMessage("Erro ao tentar carregar os dados", UtilBO.TipoMensagem.Erro);
                ApplicationWEB._GravaErro(ex);
                updMensagem.Update();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            VerificaPaginaRedirecionar();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Salvar(false);
            }
        }

        protected void btnAprovar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Salvar(true);
            }
        }

        protected void btnDesaprovar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Desaprovar();
            }
        }
    }
}