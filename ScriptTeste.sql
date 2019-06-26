ALTER TABLE ItemPedido ADD IdStatus int

UPDATE
    ItemPedido
SET
    IdStatus = p.IdStatus
FROM
    ItemPedido AS i
    INNER JOIN Pedido AS p
        ON i.IdPedido = p.IdPedido

ALTER TABLE ItemPedido
ADD FOREIGN KEY (IdStatus) REFERENCES StatusPedido(IdStatus);