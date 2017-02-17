﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTech.GestaoEscolar.ObjetosSincronizacao.Entities
{
    public class Nivel
    {
        public int Nvl_id { get; set; }
        public int Cur_id { get; set; }
        public int Crr_id { get; set; }
        public int Crp_id { get; set; }
        public int Crp_ordem { get; set; }
        public int Cal_id { get; set; }
        public int Nvl_ordem { get; set; }
        public string Nvl_nome { get; set; }
        public DateTime Nvl_dataSincronizacao { get; set; }
        public int Tds_id { get; set; }
        public List<OrientacaoCurricular> OrientacoesCurriculares { get; set; }
    }
}
