$(window).on('load', function () {
    $(".loader").fadeOut("slow");
    $("#section-comercial").toggle("fast");
});

$(document).ready(function () {
    var urlApi = 'Dashboard/GetVendedores';
    //Função que ao ser selecionado o botão de semana ou mês carrega os valores totais relacionados.
    $(function () {

        $('input.btn-vendedor').click(function () {
            if ($('#btn-vendedor-semana').is(":checked")) {
                urlApi = 'Dashboard/GetVendedoresSemana'
                drawChart();
            } else {
                urlApi = 'Dashboard/GetVendedores'
                drawChart();
            }
        })
    });

    // Load the Visualization API and the corechart package.
    google.charts.load('current', { 'packages': ['corechart'] });

    // Set a callback to run when the Google Visualization API is loaded.
    google.charts.setOnLoadCallback(drawChart);

    // Callback that creates and populates a data table,
    // instantiates the pie chart, passes in the data and
    // draws it.

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
        // Create the data table.
        var data = google.visualization.arrayToDataTable(dataArray);
        //data.addColumn('string', 'Topping');
        //data.addColumn('number', 'Slices');

        // Set chart options
        var options = {
            'title': 'Top 10 de vendas por vendedor',
            'titleTextStyle': { 'fontSize': 14 },
            'width': 360,
            'height': 300,
            'backgroundColor': 'transparent',
            'legend': { 'position': 'left' },
            'is3D': 'true'
        };

        // Instantiate and draw our chart, passing in some options.
        var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
        chart.draw(data, options);

        // Set chart options
        var options = {
            'title': 'Total de faturamento semanal',
            'titleTextStyle': { 'fontSize': 14 },
            'width': 360,
            'height': 300,
            'backgroundColor': 'transparent'
        };

        // Instantiate and draw our chart, passing in some options.
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

        // Instantiate and draw our chart, passing in some options.
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

        // Instantiate and draw our chart, passing in some options.
        var chart = new google.visualization.ColumnChart(document.getElementById('chartSmallPier_div'));
        chart.draw(data, options);
        return false;
    }


});