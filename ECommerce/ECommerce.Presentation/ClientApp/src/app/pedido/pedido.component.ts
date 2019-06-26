import { Component, OnInit } from '@angular/core';
import { PedidoService } from './pedido.service';
import { Pedido } from '../Entitiys/Pedido';

@Component({
  selector: 'app-pedido',
  templateUrl: './pedido.component.html',
  styleUrls: ['./pedido.component.css']
})
export class PedidoComponent implements OnInit {

  Pedidos: Pedido[]

  constructor(private service: PedidoService) { }

  ngOnInit() {
    this.service.List().subscribe(result => this.Pedidos = result);
  }

}
