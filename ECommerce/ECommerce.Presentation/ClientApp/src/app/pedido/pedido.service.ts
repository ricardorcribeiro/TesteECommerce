import { Pedido } from './../Entitiys/Pedido';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {

  private readonly API: string = 'https://localhost:44392/api/Pedido';

  constructor(private http: HttpClient) { }
  GetById(id: number) {
    return this.http.get<Pedido>(this.API);
  }

  List() {
    return this.http.get<Pedido[]>(this.API);
  }
}
