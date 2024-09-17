use Carrefour3

SELECT * FROM dbo.Producto 

INSERT INTO Marca (nombre)
VALUES ('Domino');

SELECT p.Id, p.Nombre, m.Nombre, p.TipoId, p.Precio, p.Stock, p.UnidadId FROM dbo.Producto p
inner join Marca m on m.Id = p.marcaId
