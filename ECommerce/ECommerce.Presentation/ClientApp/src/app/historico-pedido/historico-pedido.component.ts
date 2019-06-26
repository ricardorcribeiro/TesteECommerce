import { Component, OnInit } from '@angular/core';
import { HistoricoPedidoService } from './historico-pedido.service';
import { HistoricoPedido } from '../Entitiys/HistorioPedido';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-historico-pedido',
  templateUrl: './historico-pedido.component.html',
  styleUrls: ['./historico-pedido.component.css']
})
export class HistoricoPedidoComponent implements OnInit {

  Historicos : HistoricoPedido[];

  constructor(
    private service: HistoricoPedidoService,
    private route: ActivatedRoute

  ) {
    console.log(this.route);
  }

  ngOnInit() {
    this.route.params.subscribe((params: any) => {
      console.log(params['id'])

      this.service.HistoricoByIdPedido(params['id']).subscribe(result => { this.Historicos = result; console.log(result) });

    })
  }
}
