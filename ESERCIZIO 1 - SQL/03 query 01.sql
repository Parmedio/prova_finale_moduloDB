SELECT M.MuseumName, AW.[Name] AS ArtworkName, C.[Name] AS CharacterName
FROM ARTWORK AS AW JOIN MUSEUM AS M ON AW.ID_Museum = M.Id_Museum
	JOIN ARTIST AS A ON A.Id_Artist = AW.ID_Artist
	LEFT JOIN [CHARACTER] AS C ON AW.ID_Character = C.Id_Character
WHERE A.Country = 'Italia'

