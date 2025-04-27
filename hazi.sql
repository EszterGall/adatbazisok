DROP TABLE IF EXISTS Ugyfel_Maszkolva; --ezt csak a tesztelés kedvéért írtam bele

CREATE TABLE Ugyfel_Maszkolva (
    login NVARCHAR(255) PRIMARY KEY,
    email NVARCHAR(100) masked with (Function='email()'),
    nev NVARCHAR(100) masked with (Function='partial(1,"XXX",1)'),
    szulev INT masked with (Function='random(1,2025)'),
    nem NVARCHAR(10) masked with (Function='default()'),
    cim NVARCHAR(200) masked with (Function='partial(2,"XXX",2)')
);

INSERT INTO Ugyfel_Maszkolva (login, email, nev, szulev, nem, cim)
SELECT DISTINCT login, email, nev, szulev, nem, cim
FROM ugyfel;

select * from Ugyfel_Maszkolva;

CREATE USER MaskUser WITHOUT Login
GRANT SELECT ON Ugyfel_Maszkolva TO MaskUser;