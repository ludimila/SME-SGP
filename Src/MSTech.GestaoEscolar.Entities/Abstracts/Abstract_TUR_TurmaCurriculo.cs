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
    public abstract class Abstract_TUR_TurmaCurriculo : Abstract_Entity
    {
		[MSNotNullOrEmpty()]
		[DataObjectField(true, false, false)]
		public virtual Int64 tur_id { get; set; }
		[MSNotNullOrEmpty()]
		[DataObjectField(true, false, false)]
		public virtual int cur_id { get; set; }
		[MSNotNullOrEmpty()]
		[DataObjectField(true, false, false)]
		public virtual int crr_id { get; set; }
		[MSNotNullOrEmpty()]
		[DataObjectField(true, false, false)]
		public virtual int crp_id { get; set; }
		[MSNotNullOrEmpty()]
		public virtual int tcr_prioridade { get; set; }
		[MSNotNullOrEmpty()]
		public virtual byte tcr_situacao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual DateTime tcr_dataCriacao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual DateTime tcr_dataAlteracao { get; set; }

    }
}