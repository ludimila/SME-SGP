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
    public abstract class Abstract_ORC_Objetivo : Abstract_Entity
    {
		[MSNotNullOrEmpty()]
		[DataObjectField(true, true, false)]
		public virtual int obj_id { get; set; }
		[MSNotNullOrEmpty()]
		public virtual int cur_id { get; set; }
		[MSNotNullOrEmpty()]
		public virtual int crr_id { get; set; }
		[MSNotNullOrEmpty()]
		public virtual int crp_id { get; set; }
		[MSNotNullOrEmpty()]
		public virtual int tds_id { get; set; }
        public virtual int cal_id { get; set; }
		[MSNotNullOrEmpty()]
		public virtual string obj_descricao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual byte obj_situacao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual DateTime obj_dataCriacao { get; set; }
		[MSNotNullOrEmpty()]
		public virtual DateTime obj_dataAlteracao { get; set; }

    }
}