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
    public class ACA_TipoDisciplinaDAO : Abstract_ACA_TipoDisciplinaDAO
    {
        /// <summary>
        /// Gera as ordens para os tipos disciplinas.
        /// </summary>     
        public void Ordena_TipoDisciplina_tds_Ordem()
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_Ordena_tds_Ordem", _Banco);
            try
            {
                qs.Execute();
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Verifica o maior número de ordem cadastado de tipo de disciplina.
        /// </summary>     
        public int Select_MaiorOrdem()
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_Select_MaiorOrdem", _Banco);
            try
            {
                qs.Execute();

                return qs.Return.Rows.Count > 0 ? Convert.ToInt32(qs.Return.Rows[0][0]) : 0;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Retorna todos os tipos de disciplina não excluídos logicamente
        /// </summary>        
        /// <param name="tds_id">ID do tipo de disciplina</param>
        /// <param name="tne_id">ID do tipo de nível de ensino</param>
        /// <param name="tds_idNaoConsiderar">Id do tipo de disciplina que não virá do banco</param>
        /// <param name="controlarOrdem">se vai ordenar por ordem ou não</param> 
        /// <param name="paginado">Indica se o datatable será paginado ou não</param> 
        /// <param name="currentPage">Página atual do grid</param>
        /// <param name="pageSize">Total de registros por página do grid</param>
        /// <param name="totalRecords">Total de registros retornado na busca</param>   
        public DataTable SelectBy_Pesquisa
        (
            int tds_id
            , int tne_id
            , int tds_idNaoConsiderar
            , bool controlarOrdem
            , bool paginado
            , int currentPage
            , int pageSize
            , out int totalRecords
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_SelectBy_Pesquisa", _Banco);
            try
            {
                #region PARAMETROS

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@tds_id";
                Param.Size = 4;
                if (tds_id > 0)
                    Param.Value = tds_id;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@tne_id";
                Param.Size = 4;
                if (tne_id > 0)
                    Param.Value = tne_id;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@tds_idNaoConsiderar";
                Param.Size = 4;
                if (tds_idNaoConsiderar > 0)
                    Param.Value = tds_idNaoConsiderar;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Boolean;
                Param.ParameterName = "@controlarOrdem";
                Param.Size = 1;
                Param.Value = controlarOrdem;
                qs.Parameters.Add(Param);

                #endregion

                if (paginado)
                    totalRecords = qs.Execute(currentPage, pageSize);
                else
                {
                    qs.Execute();
                    totalRecords = qs.Return.Rows.Count;
                }

                return qs.Return;
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
        /// Retorna todos os tipos de disciplina não excluídos logicamente
        /// </summary>               
        /// <param name="controlarOrdem">se vai ordenar por ordem ou não</param>
        /// <param name="cur_id"></param>         
        public DataTable SelectBy_Pesquisa_TipoDisciplina_Curso
        (
             bool controlarOrdem,
             int cur_id
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_SelectBy_Pesquisa_Curso", _Banco);
            try
            {
                #region PARAMETROS

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@cur_id";
                Param.Size = 4;
                if (cur_id <= 0)
                    Param.Value = DBNull.Value;
                else
                    Param.Value = cur_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Boolean;
                Param.ParameterName = "@controlarOrdem";
                Param.Size = 1;
                Param.Value = controlarOrdem;
                qs.Parameters.Add(Param);

                #endregion


                qs.Execute();

                return qs.Return;
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
        /// seleciona as disciplinas conforme o cargo selecionado
        /// </summary>
        /// <param name="crg_id"></param>
        /// <returns></returns>
        public DataTable GetSelect_Disciplina(int crg_id)
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_SELECT_by_crg_id", _Banco);
            try
            {
                #region PARAMETROS

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@crg_id";
                Param.Size = 4;
                Param.Value = crg_id;
                qs.Parameters.Add(Param);

                #endregion

                qs.Execute();
                return qs.Return;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Retorna os tipos de disciplina por escola.
        /// </summary>
        /// <param name="esc_id">Id da escola</param>
        /// <returns></returns>
        public DataTable SelectByEscola
        (
            int esc_id
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_SelectBy_Escola", _Banco);
            try
            {
                #region PARAMETROS

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@esc_id";
                Param.Size = 4;
                Param.Value = esc_id;
                qs.Parameters.Add(Param);

                #endregion

                qs.Execute();
                return qs.Return;
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
        /// Carrega todos os tipos de disciplinas de acordo com os filtros informados
        /// exceto as disciplinas do tipo Eletiva do aluno e as disciplinas do tipo informado
        /// </summary>
        /// <param name="cur_id"></param>
        /// <param name="crr_id"></param>
        /// <param name="crp_id"></param>
        /// <param name="crd_tipo">Tipo de disciplina que NÃO será carregado</param>
        /// <returns>DataTable com os dados</returns>
        public DataTable SelectBy_CursoCurriculoPeriodo
        (
            int cur_id
            , int crr_id
            , int crp_id
            , byte crd_tipo
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_SelectBy_CursoCurriculoPeriodo", _Banco);
            try
            {
                #region PARAMETROS

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@cur_id";
                Param.Size = 4;
                if (cur_id > 0)
                    Param.Value = cur_id;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@crr_id";
                Param.Size = 4;
                if (crr_id > 0)
                    Param.Value = crr_id;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@crp_id";
                Param.Size = 4;
                if (crp_id > 0)
                    Param.Value = crp_id;
                else
                    Param.Value = DBNull.Value;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Byte;
                Param.ParameterName = "@crd_tipo";
                Param.Size = 1;
                Param.Value = crd_tipo;
                qs.Parameters.Add(Param);

                #endregion

                qs.Execute();

                return qs.Return;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }

        /// <summary>
        /// Retorna o tipo de disciplina que não foram excluídos logicamente
        /// filtrado por tud_id.
        /// </summary>
        /// <param name="tudId">Id da turma disciplina</param>
        /// <returns></returns>
        public DataTable SelecionaByTudId
        (
            long tudId
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_TipoDisciplina_SelectBy_TudId", _Banco);
            try
            {
                #region PARAMETROS

                Param = qs.NewParameter();
                Param.DbType = DbType.Int64;
                Param.ParameterName = "@tud_id";
                Param.Size = 8;
                Param.Value = tudId;
                qs.Parameters.Add(Param);

                #endregion

                qs.Execute();
                return qs.Return;
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
    }
}