﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MSTech.GestaoEscolar.Web.WebProject;

public partial class WebControls_Combos_UCComboEscolaSituacao : MotherUserControl
{
    #region PROPRIEDADES

    /// <summary>
    /// Atribui valores para o combo
    /// </summary>
    public DropDownList _Combo
    {
        get
        {
            return _ddlEscolaSituacao;
        }
        set
        {
            _ddlEscolaSituacao = value;
        }
    }

    /// <summary>
    /// Atribui valores para o label
    /// </summary>
    public Label _Label
    {
        get
        {
            return LabelSituacao;
        }
        set
        {
            LabelSituacao = value;
        }
    }

    #endregion
}
