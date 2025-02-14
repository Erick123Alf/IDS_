USE AkirasBoutiques;

SELECT id_producto, sum (stock) as Compras
FROM producto
GROUP BY id_producto
ORDER BY Compras DESC


