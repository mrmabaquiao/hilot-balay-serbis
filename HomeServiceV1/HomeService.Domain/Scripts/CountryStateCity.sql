
USE HomeService;

--INSERT INTO dbo.Country (Name)
--VALUES ('Philippines');

DECLARE @Country int;

SELECT @Country = CountryId FROM dbo.Country 
WHERE Name = 'Philippines'

DECLARE @State int;
INSERT INTO dbo.[State] (Name,CountryId)
VALUES ('Metro Manila',@Country);

SELECT @State = StateId FROM dbo.[State] 
WHERE Name = 'Metro Manila'


INSERT INTO dbo.City (Name,StateId)
VALUES ('Manila City',@State);

INSERT INTO dbo.City (Name,StateId)
VALUES ('Mandaluyong City',@State);

INSERT INTO dbo.City (Name,StateId)
VALUES ('Makati City',@State);

INSERT INTO dbo.City (Name,StateId)
VALUES ('Pasig City',@State);

INSERT INTO dbo.City (Name,StateId)
VALUES ('Pasay City',@State);

INSERT INTO dbo.City (Name,StateId)
VALUES ('San Juan',@State);
