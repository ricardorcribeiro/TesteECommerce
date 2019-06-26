import { Pedido } from "./Pedido";
import { StatusPedido } from "./StatusPedido";

export class HistoricoPedido {
    IdPedido: number;
    Pedido: Pedido;
    IdStatus: number;
    Status:StatusPedido;
    DataStatus: Date;
    StatusDoAtraso: number;
}
