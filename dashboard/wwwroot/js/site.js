$(window).on('load', function () {
    $(".loader").fadeOut("slow");
    $("#section-comercial").toggle("fast");
});

$(document).ready(function () {
    /*
    var urlApi = 'Dashboard/GetVendedores';
    var urlPedidos = 'Dashboard/GetPedidosNaoFaturados'
    //Função que ao ser selecionado o botão de semana ou mês carrega os valores totais relacionados.
    $(function () {

        $('input.switch').click(function () {
            if ($('#semana').is(":checked")) {
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
            'width': 360,
            'height': 300,
            'backgroundColor': 'transparent',
            'legend': { 'position': 'left' }
        };

        var chart = new google.visualization.PieChart(document.getElementById('chart-pedidosFaturadosNaoFaturados'));
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
        return false;
    } ------------------------------------------------------------------------------------------------*/

    var totalEmitidos = 0;
    var totalFaturados = 0;

    $(function () {

        $('input.switch').click(function () {
            if ($('#dia').is(":checked")) {
                totalEmitidos = 20;
                totalFaturados = 15;
                $('#qtdPedidosNaoFaturados').html(totalEmitidos);
                $('#qtdPedidosFaturados').html(totalFaturados);
                drawChart();
            }
            else if ($('#semana').is(":checked")) {
                totalEmitidos = 200;
                totalFaturados = 150;
                $('#qtdPedidosNaoFaturados').html(totalEmitidos);
                $('#qtdPedidosFaturados').html(totalFaturados);
                drawChart();
            } else if ($('#mes').is(":checked")) {
                totalEmitidos = 2000;
                totalFaturados = 1500;
                $('#qtdPedidosNaoFaturados').html(totalEmitidos);
                $('#qtdPedidosFaturados').html(totalFaturados);
                drawChart();
            }
            else {
                totalEmitidos = 20;
                totalFaturados = 15;
                $('#qtdPedidosNaoFaturados').html(totalEmitidos);
                $('#qtdPedidosFaturados').html(totalFaturados);
                drawChart();
            }
        })
    });

    // Load the Visualization API and the piechart package.
    google.charts.load('current', { 'packages': ['corechart'] });

    // Set a callback to run when the Google Visualization API is loaded.
    google.charts.setOnLoadCallback(drawChart);

    // Callback that creates and populates a data table, 
    // instantiates the pie chart, passes in the data and
    // draws it.
    function drawChart() {

        // Create the data table.
        var data = google.visualization.arrayToDataTable([
            ['Element', 'Total', { role: 'style' }],
            ['Emitidos', totalEmitidos, 'gold'],
            ['Faturados', totalFaturados, 'color: #e5e4e2'],
        ]);

        // Set chart options
        var options = {
            width: 330,
            height: 300,
            bar: { groupWidth: "95%" },
            legend: { position: "none" },
        };

        // Instantiate and draw our chart, passing in some options.
        var chart = new google.visualization.ColumnChart(document.getElementById('chart-pedidosFaturadosNaoFaturados'));
        chart.draw(data, options);

        // Create the data table.
        var dataColumn = google.visualization.arrayToDataTable([
            ['Vendedor', 'Valor'],
            ['Daniel', 51000],
            ['Lucas', 49000],
            ['Matheus', 35000],
            ['Gessika', 30000],
            ['Deyze', 27000],
        ]);

        // Set chart options
        var options = {
            width: 330,
            height: 300,
            bar: { groupWidth: "95%" },
            legend: { position: "right" },
        };

        // Instantiate and draw our chart, passing in some options.
        var chart = new google.visualization.PieChart(document.getElementById('chart-top5Vendedores'));
        chart.draw(dataColumn, options);
    }
    //Animação toggle informar intervalo de datas----------------------------------------------------------------------------------------------------
    var theToggle = document.getElementById('toggle');

    // based on Todd Motto functions
    // https://toddmotto.com/labs/reusable-js/

    // hasClass
    function hasClass(elem, className) {
        return new RegExp(' ' + className + ' ').test(' ' + elem.className + ' ');
    }
    // addClass
    function addClass(elem, className) {
        if (!hasClass(elem, className)) {
            elem.className += ' ' + className;
        }
    }
    // removeClass
    function removeClass(elem, className) {
        var newClass = ' ' + elem.className.replace(/[\t\r\n]/g, ' ') + ' ';
        if (hasClass(elem, className)) {
            while (newClass.indexOf(' ' + className + ' ') >= 0) {
                newClass = newClass.replace(' ' + className + ' ', ' ');
            }
            elem.className = newClass.replace(/^\s+|\s+$/g, '');
        }
    }
    // toggleClass
    function toggleClass(elem, className) {
        var newClass = ' ' + elem.className.replace(/[\t\r\n]/g, " ") + ' ';
        if (hasClass(elem, className)) {
            while (newClass.indexOf(" " + className + " ") >= 0) {
                newClass = newClass.replace(" " + className + " ", " ");
            }
            elem.className = newClass.replace(/^\s+|\s+$/g, '');
        } else {
            elem.className += ' ' + className;
        }
    }

    theToggle.onclick = function () {
        toggleClass(this, 'on');
        return false;
    }

});