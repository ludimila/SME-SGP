﻿function jsUCCurriculo() {
    // Accordion dos eixos
    var lstHdnAberto = $("input[id$='hdnAberto']");
    for (var i = 0; i < lstHdnAberto.length; i++) {
        var hdnAberto = $(lstHdnAberto[i]);
        if (hdnAberto.val() == '1')
        {
            hdnAberto.parents(".accordion-body").addClass("accordion-opened");
        }
        else
        {
            hdnAberto.parents(".accordion-body").addClass("accordion-closed");
        }
    }
    $(".accordion-head").unbind('click').click(function () {
        var head = $(this);
        if (head.find("input[type='text']").length == 0 && head.find("textarea").length == 0) {
            var item = $(head.parents("tr").find('.accordion-body'));
            var hdnAberto = item.find("input[id$='hdnAberto']");
            if (item.hasClass("accordion-closed")) {
                item.removeClass("accordion-closed");
                item.addClass("accordion-opened");
                hdnAberto.val('1');
            }
            else if (item.hasClass("accordion-opened")) {
                item.removeClass("accordion-opened");
                item.addClass("accordion-closed");
                hdnAberto.val('0');
            }
        }
    });
    // Lista de sugestões
    var lstHdnAbertoSugestao = $("input[id$='hdnAbertoSugestao']");
    for (var i = 0; i < lstHdnAbertoSugestao.length; i++) {
        var hdnAberto = $(lstHdnAbertoSugestao[i]);
        if (hdnAberto.val() == '1') {
            hdnAberto.siblings("ul").addClass("list-opened");
        }
        else {
            hdnAberto.siblings("ul").addClass("list-closed");
        }
    }
    //
    if ($("[id$='lblMessage']").length > 0 && $("[id$='lblMessage']").html() != "")
    {
        setTimeout('window.scrollTo(0,0);', 0);
    }
}

function ListarSugestoes(head)
{
    var item = $(head.parents("tr").find('ul').first());
    var hdnAberto = item.siblings("input[id$='hdnAbertoSugestao']").first();
    if (item.hasClass("list-closed")) {
        item.removeClass("list-closed");
        item.addClass("list-opened");
        hdnAberto.val('1');
    }
    else if (item.hasClass("list-opened")) {
        item.removeClass("list-opened");
        item.addClass("list-closed");
        hdnAberto.val('0');
    }
}

// Insere as funções na lista de funcões - será chamado no Init.js.
arrFNC.push(jsUCCurriculo);
arrFNCSys.push(jsUCCurriculo);