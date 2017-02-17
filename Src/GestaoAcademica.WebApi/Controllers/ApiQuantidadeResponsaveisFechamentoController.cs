﻿using System.Data;
using System.Web.Http;
using MSTech.GestaoEscolar.BLL;
using System.Web.Http.Description;

namespace GestaoAcademica.WebApi.Controllers
{

    [ApiExplorerSettings(IgnoreApi = true)]
    public class ApiQuantidadeResponsaveisFechamentoController : ApiController
    {        
        public DataTable GetAll()
        {
            return ApiBO.SelecionaResponsaveisFechamento();
        }
    }
}