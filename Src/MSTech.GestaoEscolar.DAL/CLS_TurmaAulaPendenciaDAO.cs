/*
	Classe gerada automaticamente pelo MSTech Code Creator
*/

namespace MSTech.GestaoEscolar.DAL
{
    using Data.Common;
    using MSTech.GestaoEscolar.DAL.Abstracts;
    using System.Data;
    using System.Data.SqlClient;
    /// <summary>
    /// Description: .
    /// </summary>
    public class CLS_TurmaAulaPendenciaDAO : Abstract_CLS_TurmaAulaPendenciaDAO
	{
        /// <summary>
        /// Atualiza a pendência da aula.
        /// </summary>
        /// <param name="tud_id">Id da disciplina.</param>
        /// <param name="tau_id">Id da aula.</param>
        /// <param name="semPlanoAula">Indica se possui plano de aula.</param>
        public void AtualizarPendencia(long tud_id, int tau_id, bool semPlanoAula)
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_CLS_TurmaAulaPendencia_AtualizarPendencia", _Banco);

            #region Parâmetros

            Param = qs.NewParameter();
            Param.DbType = DbType.Int64;
            Param.Size = 8;
            Param.ParameterName = "@tud_id";
            Param.Value = tud_id;
            qs.Parameters.Add(Param);

            Param = qs.NewParameter();
            Param.DbType = DbType.Int32;
            Param.Size = 4;
            Param.ParameterName = "@tau_id";
            Param.Value = tau_id;
            qs.Parameters.Add(Param);

            Param = qs.NewParameter();
            Param.DbType = DbType.Boolean;
            Param.Size = 1;
            Param.ParameterName = "@semPlanoAula";
            Param.Value = semPlanoAula;
            qs.Parameters.Add(Param);

            #endregion

            qs.Execute();
            qs.Parameters.Clear();
        }

        /// <summary>
        /// Seleciona as pendências de plano de aula das disciplinas.
        /// </summary>
        /// <param name="dtTurmaDisciplina">Tabela de turmas disciplinas</param>
        /// <returns></returns>
        public DataTable SelecionaPendencias(DataTable dtTurmaDisciplina)
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_CLS_TurmaAulaPendencia_SelecionaPendencias", _Banco);

            try
            {
                #region Parâmetros

                SqlParameter sqlParam = new SqlParameter();
                sqlParam.SqlDbType = SqlDbType.Structured;
                sqlParam.ParameterName = "@tabelaTurmaDisciplina";
                sqlParam.TypeName = "TipoTabela_TurmaDisciplina";
                sqlParam.Value = dtTurmaDisciplina;
                qs.Parameters.Add(sqlParam);

                #endregion Parâmetros

                qs.Execute();

                return qs.Return;
            }
            finally
            {
                qs.Parameters.Clear();
            }
        }
    }
}