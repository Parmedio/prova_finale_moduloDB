SELECT DISTINCT A.[ArtistName]
FROM (SELECT ID_Museum, ID_Artist FROM ARTWORK) AS AW
JOIN (SELECT Id_Museum, City FROM MUSEUM) AS M ON AW.ID_Museum = M.Id_Museum
JOIN (SELECT Id_Artist, [Name] AS ArtistName FROM ARTIST) AS A ON AW.ID_Artist = A.Id_Artist
WHERE City = 'Parigi'