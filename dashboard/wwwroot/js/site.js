$(window).on('load', function () {
    $(".loader").fadeOut("slow");
    $("#section-comercial").toggle("fast");
});

$(document).ready(function () {
    var urlApi = 'Dashboard/GetVendedores';
    var urlPedidos = 'Dashboard/GetPedidosNaoFaturados'
    //Função que ao ser selecionado o botão de semana ou mês carrega os valores totais relacionados.
    $(function () {

        $('input.btn-vendedor').click(function () {
            if ($('#btn-vendedor-semana').is(":checked")) {
                urlApi = 'Dashboard/GetVendedoresSemana'
                $('#qtdPedidosNaoFaturados').html("243");
                $('#qtdPedidosFaturados').html("121");
                drawChart();
            } else {
                urlApi = 'Dashboard/GetVendedores'
                $('#qtdPedidosNaoFaturados').html("834");
                $('#qtdPedidosFaturados').html("732");
                drawChart();
            }
        })
    });

    function getPedidos() {
        $.ajax({
            url: urlPedidos,
            dataType: "json",
            type: "GET",
            error: function (xhr, status, error) {
                var err = eval(" (" + xhr.responseText + ") ");
                //toast.error(err.message);
            },
            success: function (data) {
                //$('.block').html("Requisição concluída...");
                
                return data.totalVendas[0];
            }
        });
    }

    google.charts.load('current', { 'packages': ['corechart'] });

    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
        //$('.block').html("<img src='http://i.imgur.com/zAD2y29.gif'>");
        $.ajax({
            url: urlApi,
            dataType: "json",
            type: "GET",
            error: function (xhr, status, error) {
                var err = eval(" (" + xhr.responseText + ") ");
                //toast.error(err.message);
            },
            success: function (data) {
                //$('.block').html("Requisição concluída...");
                GiveVendedores(data);
                return false;
            }
        });
        return false;
    }

    function GiveVendedores(data) {
        var dataArray = [
            ['Vendedor', 'TotalVendas']
        ];
        $.each(data, function (i, item) {
            dataArray.push([item.vendedor, item.totalVendas]);
        });
        var data = google.visualization.arrayToDataTable(dataArray);

        var options = {
            'title': 'Top 10 de vendas por vendedor',
            'titleTextStyle': { 'fontSize': 14 },
            'width': 360,
            'height': 300,
            'backgroundColor': 'transparent',
            'legend': { 'position': 'left' },
            'is3D': 'true'
        };

        var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
        chart.draw(data, options);

        var options = {
            'title': 'Total de faturamento semanal',
            'titleTextStyle': { 'fontSize': 14 },
            'width': 360,
            'height': 300,
            'backgroundColor': 'transparent'
        };

        var chart = new google.visualization.ColumnChart(document.getElementById('columnChart_div'));
        chart.draw(data, options);

        // Grafico de Pizza para celulares menores que 320px
        var options = {
            'title': 'Top 10 de vendas por vendedor',
            'titleTextStyle': { 'fontSize': 14 },
            'width': 280,
            'height': 300,
            'backgroundColor': 'transparent',
            'legend': { 'position': 'bottom' },
            'is3D': 'true'
        };

        var chart = new google.visualization.PieChart(document.getElementById('chartSmallPizza_div'));
        chart.draw(data, options);


        // Grafico de colunas para celulares menores que 320px
        var options = {
            'title': 'Total de faturamento semanal',
            'titleTextStyle': { 'fontSize': 14 },
            'width': 280,
            'height': 300,
            'backgroundColor': 'transparent'
        };

        var chart = new google.visualization.ColumnChart(document.getElementById('chartSmallPier_div'));
        chart.draw(data, options);
        return false;
    }


});