$(window).on('load', function () {
    $(".loader").fadeOut("slow");
    $("#section-comercial").toggle("fast");
    //Ultima atualização
    let hoje = new Date();
    const dia = hoje.getDate();
    const mes = hoje.getMonth() + 1;
    const ano = hoje.getFullYear();
    const hora = hoje.getHours();
    const minutos = hoje.getMinutes();
    const segundos = hoje.getSeconds();
    $('.ultimaAtualizacao').html(`Última atualização: ${dia}/${mes}/${ano} às ${hora}:${minutos}`);
});

$(document).ready(function () {

    $(function () {

        let dataT = new Date();
        let btndataInicial = `${dataT.getDate()}\ ${dataT.getMonth()}\ ${dataT.getFullYear()} 00:00:00`;
        let btndataFinal = `${dataT.getDate()}\ ${dataT.getMonth()}\ ${dataT.getFullYear()} 00:00:00`;

        $('input.switch').click(function () {
            if ($('#dia').is(":checked")) {
                btndataInicial = dataT.getDate();
                btndataFinal = dataT.getDate();
            }
            else if ($('#semana').is(":checked")) {
                btndataInicial = dataT.getDate();
                btndataFinal = dataT.getDate();
            } else if ($('#mes').is(":checked")) {
                btndataInicial = dataT.getDate();
                btndataFinal = dataT.getDate();
            }

            $.ajax({
                url: 'Dashboard/AtualizaDados',
                data: { "DataInicial": btndataInicial, "DataFinal": btndataFinal },
                dataType: "json",
                type: "POST",
                error: function (xhr, status, error) {
                    var err = eval(" (" + xhr.responseText + ") ");
                    //toast.error(err.message);
                },
                success: function (data) {
                    //$('.block').html("Requisição concluída...");
                    let totalEmitidos = data[0].pedidos.emitidos;
                    let totalFaturados = data[0].pedidos.faturados;
                    $('#qtdPedidosNaoFaturados').html(totalEmitidos);
                    $('#qtdPedidosFaturados').html(totalFaturados);
                    return false;
                }
            });

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
            url: 'Dashboard/AtualizaDados',
            dataType: "json",
            type: "GET",
            error: function (xhr, status, error) {
                var err = eval(" (" + xhr.responseText + ") ");
                //toast.error(err.message);
            },
            success: function (data) {
                //$('.block').html("Requisição concluída...");
                //$('#displayData').html("01/01/2020 a 31/12/2020");
                AtualizaDados(data);
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
                url: 'Dashboard/AtualizaDados',
                data: { "DataInicial": dataInicial, "DataFinal": dataFinal },
                dataType: "json",
                type: "POST",
                error: function (xhr, status, error) {
                    var err = eval(" (" + xhr.responseText + ") ");
                    //toast.error(err.message);
                },
                success: function (data) {
                    //$('.block').html("Requisição concluída...");
                    AtualizaDados(data);
                    $("#toggle").removeClass("on");
                    $('#displayData').html(
                        dataInicial.replace(/(\d*)-(\d*)-(\d*).*/, '$3/$2/$1') +
                        " a " +
                        dataFinal.replace(/(\d*)-(\d*)-(\d*).*/, '$3/$2/$1')
                    );
                    return false;
                }
            });
        });
    }

    function AtualizaDados(data) {

        AtualizaBlocoFaturamento(data);

        const dataArray = [
            ['Vendedor', 'TotalVendas']
        ];
        $.each(data[0].vendedores, function (i, item) {
            dataArray.push([item['vendedor'], item['totalVendas']]);
        });

        var dataColumn = google.visualization.arrayToDataTable(dataArray);

        var options = {
            width: 330,
            height: 300,
            bar: { groupWidth: "95%" },
            legend: { position: "right" },
        };

        var chart = new google.visualization.PieChart(document.getElementById('chart-top5Vendedores'));
        chart.draw(dataColumn, options);

        const dataArrayPedido = [
            ['Element', 'Total', { role: 'style' }],
            ['Faturados', parseInt(data[0].pedidos.faturados), 'green'],
            ['Emitidos', parseInt(data[0].pedidos.emitidos), 'gold']
        ];

        var dataPedidos = google.visualization.arrayToDataTable(dataArrayPedido);

        var options = {
            width: 330,
            height: 300,
            bar: { groupWidth: "95%" },
            legend: { position: "none" },
        };

        var chart = new google.visualization.ColumnChart(document.getElementById('chart-pedidosFaturadosNaoFaturados'));
        chart.draw(dataPedidos, options);
    }

    function AtualizaBlocoFaturamento(data) {
        let ValorPedidosFaturados = data[0].somaValorPedidos;
        $('#faturamento-dia').html(ValorPedidosFaturados);
    }

    //Animação toggle informar intervalo de datas-----------------------------------------------------------------
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