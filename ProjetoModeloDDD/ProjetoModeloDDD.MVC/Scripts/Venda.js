function SalvarVenda() {
 debugger
    //Data
    var data = $("#Data").val();

    //Valor
   // var valor = $("#ValorTotal").val();

    //Cliente
    var cliente = $("#Cliente").val();

    //Funcionário
    colaborador = $("#Colaborador").val();
 
    var token = $('input[name="__RequestVerificationToken"]').val();
    var tokenadr = $('form[action="/Venda/Criar"] input[name="__RequestVerificationToken"]').val();
    var headers = {};
    var headersadr = {};
    headers['__RequestVerificationToken'] = token;
    headersadr['__RequestVerificationToken'] = tokenadr;

    //Gravar
    var url = "/Venda/Criar";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , headers: headersadr
        , data: { VendaId: 0, Data: data, Cliente : cliente, Colaborador:colaborador,  __RequestVerificationToken: token }
        , success: function (data) {
            if (data.Resultado > 0) {
                ListarItens(data.Resultado);
            }
        }
    });debugger
}

function ListarItens(VendaId) {

    var url = "/Itens/ListarItens";

    $.ajax({
        url: url
        , type: "GET"
        , data: { id: VendaId }
        , datatype: "html"
        , success: function (data) {
            var divItens = $("#divItens");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    });

}


function SalvarItens() {

    var quantidade = $("#Quantidade").val();
    var produto = $("#Produto").val();
   // var valorunitario = $("#ValorUnitario").val();
    var idVenda = $("#idVenda").val();

    var url = "/Itens/SalvarItens";

    $.ajax({
        url: url
        , data: { quantidade: quantidade, produto: produto, valorunitario: valorunitario, idVenda: idVenda }
        , type: "GET"
        , datatype: "html"
        , success: function (data) {
            if (data.Resultado > 0) {
                ListarItens(idVenda);
            }
        }
    });
}
