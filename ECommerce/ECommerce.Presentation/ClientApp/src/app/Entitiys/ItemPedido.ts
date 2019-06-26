import { Pedido } from "./Pedido";
import { Produto } from "./Produto";
import { StatusPedido } from "./StatusPedido";

export class ItemPedido{
    IdPedido: number;
    Pedido: Pedido;
    IdProduto: number;
    Produto: Produto;
    PrecoVenda: number;
    IdStatus: number;
    Status: StatusPedido;
}
