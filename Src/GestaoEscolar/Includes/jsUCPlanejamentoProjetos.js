﻿function jsUCPlanejamentoProjetos() {
    createTabs("#divTabs", "input[id='txtSelectedTab']");

    createDialog('.divPlanoAluno', 555, 0);
    createDialog('.divPlanoProjeto', 700, 0);
    createDialog("#divReplicarPlanejamentoAnual", 555, 0);
    createDialog("#divTextoGrande", 700, 400);
    createDialog("#divHistoricoAlteracoesCiclo", 700, 0);

    var selected_tab = 1;
    $(function () {
        var tabs = $("#divTabs").tabs({
            select: function (e, i) {
                selected_tab = i.index;
                $("[id$=selected_tab]").val(selected_tab);
              
            }
        });
        selected_tab = $("[id$=selected_tab]").val() != "" ? parseInt($("[id$=selected_tab]").val()) : 0;
        tabs.tabs('select', selected_tab);
        $("form").submit(function () {
            $("[id$=selected_tab]").val(selected_tab);
        });
    });

    //Adiciona página de confirmação caso o usuário tente sair da tela
    SetExitPageConfirmer();
}

// Insere as funções na lista de funcões - será chamado no Init.js.
arrFNC.push(jsUCPlanejamentoProjetos);
arrFNCSys.push(jsUCPlanejamentoProjetos);