$(window).on('load', function () {
    $(".loader").fadeOut("slow");
    $("#section-comercial").toggle("fast");
    let hoje = new Date();
    $('.ultimaAtualizacao').html("Última atualização: "
        + hoje.getDate()
        + "/"
        + hoje.getMonth()
        + "/"
        + hoje.getFullYear()
        + " às "
        + hoje.getHours()
        + ":"
        + hoje.getMinutes()
        + ":"
        + hoje.getSeconds()
        + " hs"
    );
});

$(document).ready(function () {

    let totalEmitidos = 0;
    let totalFaturados = 0;

    let GetVendedoresApi = 'Dashboard/GetVendedores';

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
                totalFaturados = 20;
                $('#qtdPedidosNaoFaturados').html(totalEmitidos);
                $('#qtdPedidosFaturados').html(totalFaturados);
                drawChart();
            } else if ($('#mes').is(":checked")) {
                totalEmitidos = 2000;
                totalFaturados = 2126;
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
        });

        $('input.switch').click(function () {
            if ($('#chart-vendedores-dia').is(":checked")) {
                GetVendedoresApi = 'Dashboard/GetVendedoresSemana';
                drawChart();
            }
            else if ($('#chart-vendedores-semana').is(":checked")) {
                GetVendedoresApi = 'Dashboard/GetVendedoresSemana';
                drawChart();
            } else if ($('#chart-vendedores-mes').is(":checked")) {
                GetVendedoresApi = 'Dashboard/GetVendedores';
                drawChart();
            }
            else {
                GetVendedoresApi = 'Dashboard/GetVendedores';
                drawChart();
            }
        });
    });

    google.charts.load('current', { 'packages': ['corechart'] });

    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {

        $.ajax({
            url: GetVendedoresApi,
            dataType: "json",
            type: "GET",
            error: function (xhr, status, error) {
                var err = eval(" (" + xhr.responseText + ") ");
                //toast.error(err.message);
            },
            success: function (data) {
                //$('.block').html("Requisição concluída...");
                $('#displayData').html("01/01/2020 a 31/12/2020");
                GiveVendedores(data);
                return false;
            }
        });

        $('#atualizaData').click(function () {

            let dataInicial = $('#dataInicial').val();
            let dataFinal = $('#dataFinal').val();

            if (dataInicial > dataFinal) {
                alert("Data inicial maior que a data final. Insira a data corretamente.");
                return;
            }

            $.ajax({
                url: 'Dashboard/AtualizaData',
                data: { "DataInicial": dataInicial, "DataFinal": dataFinal },
                dataType: "json",
                type: "POST",
                error: function (xhr, status, error) {
                    var err = eval(" (" + xhr.responseText + ") ");
                    //toast.error(err.message);
                },
                success: function (data) {
                    //$('.block').html("Requisição concluída...");
                    GiveVendedores(data);
                    $("#toggle").removeClass("on");
                    $('#displayData').html(dataInicial + " a " + dataFinal);
                    return false;
                }
            });
        });
    }

    function GiveVendedores(data) {
        const dataArray = [
            ['Vendedor', 'TotalVendas']
        ];
        $.each(data, function (i, item) {
            dataArray.push([item.vendedor, item.totalVendas]);
        });

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
        var dataColumn = google.visualization.arrayToDataTable(dataArray);

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