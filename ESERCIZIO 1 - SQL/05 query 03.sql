SELECT City
FROM (SELECT ID_Museum, [Name] AS ArtworkName FROM ARTWORK) AS AW
JOIN (SELECT Id_Museum, City FROM MUSEUM) AS M ON AW.ID_Museum = M.Id_Museum
WHERE ArtworkName = 'Flora'