/*
	Classe gerada automaticamente pelo MSTech Code Creator
*/

using System;
using System.Data;
using MSTech.Data.Common;
using MSTech.GestaoEscolar.Entities;
using MSTech.GestaoEscolar.DAL.Abstracts;

namespace MSTech.GestaoEscolar.DAL
{

    /// <summary>
    /// 
    /// </summary>
    public class ACA_HistoricoObservacaoPadraoDAO : Abstract_ACA_HistoricoObservacaoPadraoDAO
    {
        #region Métodos

        /// <summary>
        /// Retorna um datatable contendo as observações não excluídas logicamente.
        /// </summary>
        /// <returns>Datatable contendo as observações</returns>
        public DataTable SelecionaTodos()
        {
            DataTable dt = new DataTable();
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_HistoricoObservacaoPadrao_SelectBy_All", _Banco);
            try
            {
                qs.Execute();
                dt = qs.Return;

                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Retorna um datatable contendo as observações não excluídas logicamente.
        /// Filtrando por tipo de observação.
        /// </summary>
        /// <param name="hop_tipo">Tipo de observação</param>
        /// <returns>Datatable contendo as observações</returns>
        public DataTable SelecionaPorTipo
        (
            int hop_tipo
        )
        {
            DataTable dt = new DataTable();
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_HistoricoObservacaoPadrao_SelectBy_Tipo", _Banco);
            try
            {
                #region Parâmetros

                Param = qs.NewParameter();
                Param.DbType = DbType.Byte;
                Param.ParameterName = "@hop_tipo";
                Param.Size = 1;
                if (hop_tipo > 0)
                    Param.Value = hop_tipo;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                #endregion

                qs.Execute();
                dt = qs.Return;

                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Verifica se existe outra observação com o mesmo nome. Certifica-se de que situação
        /// seja diferente de inativo e não seja o próprio registro.
        /// </summary>
        /// <param name="hop_id">Id da observação</param>
        /// <param name="hop_nome">Nome da observação</param>
        /// <returns>Retorna true se já existe uma observação com o mesmo nome</returns>
        public bool VerificaSeJaExisteNome
        (
            int hop_id
            , string hop_nome
        )
        {
            DataTable dt = new DataTable();
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_HistoricoObservacaoPadrao_VerificaNome", _Banco);
            try
            {
                #region Parâmetros

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@hop_id";
                if (!string.IsNullOrEmpty(hop_id.ToString()))
                    Param.Value = hop_id;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.String;
                Param.ParameterName = "@hop_nome";
                Param.Value = hop_nome;
                qs.Parameters.Add(Param);

                #endregion

                qs.Execute();

                if (qs.Return.Rows.Count > 0)
                    return true;

                return false;
            }
            catch
            {
                throw;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Retorna um datatable contendo todas as observações que não foram excluídas logicamente.      
        /// </summary>
        /// <param name="paginado"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecords"></param>
        /// <returns></returns>
        public DataTable SelectBy_All
        (
            bool paginado
            , int currentPage
            , int pageSize
            , out int totalRecords
        )
        {
            DataTable dt = new DataTable();
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_HistoricoObservacaoPadrao_SelectBy_All", _Banco);
            try
            {
                if (paginado)
                    totalRecords = qs.Execute(currentPage, pageSize);
                else
                {
                    qs.Execute();
                    totalRecords = qs.Return.Rows.Count;
                }

                if (qs.Return.Rows.Count > 0)
                    dt = qs.Return;

                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        #endregion

        #region Métodos sobrescritos

        /// <summary>
        /// Parâmetros para efetuar a inclusão com data de criação e de alteração fixas
        /// </summary>


        /// <summary>
        /// Configura os parametros do metodo de Inserir
        /// </summary>
        /// <param name="qs"></param>
        /// <param name="entity"></param>
        protected override void ParamInserir(QuerySelectStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        {
            base.ParamInserir(qs, entity);

            qs.Parameters["@hop_dataCriacao"].Value = DateTime.Now;
            qs.Parameters["@hop_dataAlteracao"].Value = DateTime.Now;
        }

        /// <summary>
        /// Configura os parametros do metodo de Alterar
        /// </summary>
        /// <param name="qs"></param>
        /// <param name="entity"></param>
        protected override void ParamAlterar(QueryStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        {
            base.ParamAlterar(qs, entity);

            qs.Parameters.RemoveAt("@hop_dataCriacao");
            qs.Parameters["@hop_dataAlteracao"].Value = DateTime.Now;
        }

        /// <summary>
        /// Configura os parametros do metodo de Excluir
        /// </summary>
        /// <param name="qs"></param>
        /// <param name="entity"></param>
        protected override void ParamDeletar(QueryStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        {
            base.ParamDeletar(qs, entity);

            Param = qs.NewParameter();
            Param.DbType = DbType.DateTime;
            Param.ParameterName = "@hop_dataAlteracao";
            Param.Size = 16;
            Param.Value = DateTime.Now;
            qs.Parameters.Add(Param);

            Param = qs.NewParameter();
            Param.DbType = DbType.Byte;
            Param.ParameterName = "@hop_situacao";
            Param.Size = 1;
            Param.Value = 3;
            qs.Parameters.Add(Param);
        }

        /// <summary>
        /// Exclui logicamente o registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override bool Delete(ACA_HistoricoObservacaoPadrao entity)
        {
            __STP_DELETE = "NEW_ACA_HistoricoObservacaoPadrao_UPDATE_Situacao";
            return base.Delete(entity);
        }

        /// <summary>
        /// Inseri os valores da classe em um registro ja existente
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override bool Alterar(ACA_HistoricoObservacaoPadrao entity)
        {
            __STP_UPDATE = "NEW_ACA_HistoricoObservacaoPadrao_UPDATE";
            return base.Alterar(entity);
        }

        #endregion

        #region Métodos Comentados
        ///// <summary>
        ///// Inseri os valores da classe em um registro ja existente
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem modificados</param>
        ///// <returns>True - Operacao bem sucedida</returns>
        //protected override bool Alterar(ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.Alterar(entity);
        //}
        ///// <summary>
        ///// Inseri os valores da classe em um novo registro
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem inseridos</param>
        ///// <returns>True - Operacao bem sucedida</returns>
        //protected override bool Inserir(ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.Inserir(entity);
        //}
        ///// <summary>
        ///// Carrega um registro da tabela usando os valores nas chaves
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem carregados</param>
        ///// <returns>True - Operacao bem sucedida</returns>
        //public override bool Carregar(ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.Carregar(entity);
        //}
        ///// <summary>
        ///// Exclui um registro do banco
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem apagados</param>
        ///// <returns>True - Operacao bem sucedida</returns>
        //public override bool Delete(ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.Delete(entity);
        //}
        ///// <summary>
        ///// Configura os parametros do metodo de Alterar
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros</param>
        //protected override void ParamAlterar(QueryStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        //{
        //    base.ParamAlterar(qs, entity);
        //}
        ///// <summary>
        ///// Configura os parametros do metodo de Carregar
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros</param>
        //protected override void ParamCarregar(QuerySelectStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        //{
        //    base.ParamCarregar(qs, entity);
        //}
        ///// <summary>
        ///// Configura os parametros do metodo de Deletar
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros</param>
        //protected override void ParamDeletar(QueryStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        //{
        //    base.ParamDeletar(qs, entity);
        //}
        ///// <summary>
        ///// Configura os parametros do metodo de Inserir
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros</param>
        //protected override void ParamInserir(QuerySelectStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        //{
        //    base.ParamInserir(qs, entity);
        //}
        ///// <summary>
        ///// Salva o registro no banco de dados
        ///// </summary>
        ///// <param name="entity">Entidade com os dados para preenchimento para inserir ou alterar</param>
        ///// <returns>True - Operacao bem sucedida</returns>
        //public override bool Salvar(ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.Salvar(entity);
        //}
        ///// <summary>
        ///// Realiza o select da tabela
        ///// </summary>
        ///// <returns>Lista com todos os registros da tabela</returns>
        //public override IList<ACA_HistoricoObservacaoPadrao> Select()
        //{
        //    return base.Select();
        //}
        ///// <summary>
        ///// Realiza o select da tabela com paginacao
        ///// </summary>
        ///// <param name="currentPage">Pagina atual</param>
        ///// <param name="pageSize">Tamanho da pagina</param>
        ///// <param name="totalRecord">Total de registros na tabela original</param>
        ///// <returns>Lista com todos os registros da p�gina</returns>
        //public override IList<ACA_HistoricoObservacaoPadrao> Select_Paginado(int currentPage, int pageSize, out int totalRecord)
        //{
        //    return base.Select_Paginado(currentPage, pageSize, out totalRecord);
        //}
        ///// <summary>
        ///// Recebe o valor do auto incremento e coloca na propriedade 
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure</param>
        ///// <param name="entity">Entidade com os dados</param>
        ///// <returns>True - Operacao bem sucedida</returns>
        //protected override bool ReceberAutoIncremento(QuerySelectStoredProcedure qs, ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.ReceberAutoIncremento(qs, entity);
        //}
        ///// <summary>
        ///// Passa os dados de um datatable para uma entidade
        ///// </summary>
        ///// <param name="dr">DataRow do datatable preenchido</param>
        ///// <param name="entity">Entidade onde ser�o transferidos os dados</param>
        ///// <returns>Entidade preenchida</returns>
        //public override ACA_HistoricoObservacaoPadrao DataRowToEntity(DataRow dr, ACA_HistoricoObservacaoPadrao entity)
        //{
        //    return base.DataRowToEntity(dr, entity);
        //}
        ///// <summary>
        ///// Passa os dados de um datatable para uma entidade
        ///// </summary>
        ///// <param name="dr">DataRow do datatable preenchido</param>
        ///// <param name="entity">Entidade onde ser�o transferidos os dados</param>
        ///// <param name="limparEntity">Indica se a entidade deve ser limpada antes da transferencia</param>
        ///// <returns>Entidade preenchida</returns>
        //public override ACA_HistoricoObservacaoPadrao DataRowToEntity(DataRow dr, ACA_HistoricoObservacaoPadrao entity, bool limparEntity)
        //{
        //    return base.DataRowToEntity(dr, entity, limparEntity);
        //}
        #endregion
    }
}