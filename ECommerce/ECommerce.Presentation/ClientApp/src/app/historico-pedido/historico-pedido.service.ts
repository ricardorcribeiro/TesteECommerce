import { HistoricoPedido } from './../Entitiys/HistorioPedido';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HistoricoPedidoService {

  private readonly API: string = 'https://localhost:44392/api/HistoricoStatus';

  constructor(private http: HttpClient) { }

  List() {
    return this.http.get<HistoricoPedido[]>(this.API);
  }

  HistoricoByIdPedido(id) {
    return this.http.get<HistoricoPedido[]>(this.API + '/HistoricoByIdPedido/' + id);
  }
}
