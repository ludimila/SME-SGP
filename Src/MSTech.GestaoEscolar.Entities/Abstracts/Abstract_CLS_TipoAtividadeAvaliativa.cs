/*
	Classe gerada automaticamente pelo MSTech Code Creator
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using MSTech.Data.Common.Abstracts;
using MSTech.Validation;

namespace MSTech.GestaoEscolar.Entities.Abstracts
{	
	/// <summary>
	/// 
	/// </summary>
	[Serializable()]
    public abstract class Abstract_CLS_TipoAtividadeAvaliativa : Abstract_Entity
    {
		[MSNotNullOrEmpty()]
		[DataObjectField(true, true, false)]
		public virtual int tav_id { get; set; }
		[MSValidRange(100)]
		[MSNotNullOrEmpty()]
		public virtual string tav_nome { get; set; }
		[MSNotNullOrEmpty()]
		public virtual byte tav_situacao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual DateTime tav_dataAlteracao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual DateTime tav_dataCriacao { get; set; }

        /// <summary>
        /// ID do qualificador de atividade.
        /// </summary>
        public virtual int qat_id { get; set; }

    }
}