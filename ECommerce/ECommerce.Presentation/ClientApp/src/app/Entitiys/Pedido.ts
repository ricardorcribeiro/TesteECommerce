import { StatusPedido } from "./StatusPedido";
import { ItemPedido } from "./ItemPedido";

export class Pedido {
    IdPedido: number
    IdStatus: number
    Status: StatusPedido;
    ValorPedido: number;
    DataPrevisaoEntrega: Date;
    ItensPedidos: ItemPedido;
}