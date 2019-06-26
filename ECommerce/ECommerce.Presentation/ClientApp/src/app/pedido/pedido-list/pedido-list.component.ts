import { Component, OnInit } from '@angular/core';
import { PedidoService } from '../pedido.service';
import { Pedido } from '../../Entitiys/Pedido';

@Component({
  selector: 'app-pedido-list',
  templateUrl: './pedido-list.component.html',
  styleUrls: ['./pedido-list.component.css']
})
export class PedidoListComponent implements OnInit {

  Pedidos: Pedido[]

  constructor(private service: PedidoService) { }

  ngOnInit() {
    this.service.List().subscribe(result => this.Pedidos = result);
  }

}
