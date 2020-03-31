﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dashboard.Models;
using dashboard.ViewModel;

namespace dashboard.Services
{
    public class SqlDashboardData : IDashboardRepository
    {
        private readonly SOFCONContext db;

        public SqlDashboardData(SOFCONContext db)
        {
            this.db = db;
        }

        public int GetPedidosNaoFaturados()
        {
            return db.pedidos.Where(pedido => pedido.IdNfe == 0).Count();
        }

        public IEnumerable<MovimGimViewModel> GetVendedores()
        {
            return db.MovimGim.
                            Join(db.VendedorGim, movimentacoes => movimentacoes.SqlMcodven,
                                vendedores => vendedores.SqlVcodven,
                            (movimentacoes, vendedores) => new MovimGimViewModel
                            {
                                NomeVendedor = vendedores.SqlVnompt1,
                                IdVendedor = vendedores.SqlVcodven,
                                IdMovimentacaoVendedor = movimentacoes.SqlMcodven,
                                ValorMovimentacao = movimentacoes.SqlMvalmov

                            }).ToList();
        }

        public IEnumerable<VendedoresViewModel> SomaPorGrupos()
        {
            var movimentacoes = GetVendedores();

            var somaVendas = from vendedor in movimentacoes
                             orderby vendedor.ValorMovimentacao
                             group vendedor by vendedor.NomeVendedor into vendedorGroup
                             select new VendedoresViewModel
                             {
                                 Vendedor = vendedorGroup.Key,
                                 TotalVendas = vendedorGroup.Sum(x => x.ValorMovimentacao)
                             };
            return somaVendas;
        }

        public IEnumerable<VendedoresViewModel> SomaPorGruposSemana()
        {
            var movimentacoes = GetVendedores();

            var somaVendas = from vendedor in movimentacoes
                             orderby vendedor.ValorMovimentacao
                             group vendedor by vendedor.NomeVendedor into vendedorGroup
                             select new VendedoresViewModel
                             {
                                 Vendedor = vendedorGroup.Key,
                                 TotalVendas = vendedorGroup.Sum(x => x.ValorMovimentacao / 5)
                             };
            return somaVendas;
        }
    }
}