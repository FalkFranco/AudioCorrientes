--Lote Datos
USE AudioCorrientes

INSERT INTO TipoCliente (tipo) VALUES ('Consumidor final');
INSERT INTO TipoCliente (tipo) VALUES ('Responsable Inscripto');
INSERT INTO TipoCliente (tipo) VALUES ('Monotributista');

INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('25633256', 'Juan', 'Esteban', '3794275467', 'Las Heras 734', 'juanperez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('41632735', 'Maria', 'Ramirez', '379442345', 'Av Maipu 1227', 'mariaramirez@gmail.com', 2);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('42673564', 'Jualiana', 'Lopez', '3794735624', 'Las Madrid 1234', 'julilopez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('25874361', 'Pedro', 'Gomez', '3794735462', 'Niza 345', 'pedrogomez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('25436523', 'Nicolas', 'Gomez', '3794635241', 'Alberti 332', 'nicogomez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('42673546', 'Joaquin', 'Gonzalez', '3795872453', 'Ombu 122', 'juaquin2010@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('40236743', 'Sebastian', 'Diaz', '3795235653', 'Av La Paz 1536', 'sebastiandiaz@gmail.com', 2);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('32657842', 'Franco', 'Romero', '3794985344', 'Necochea 1223', 'franco_romero@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('43672543', 'Francisco', 'Sanchez', '3794334564', 'Av Sarmiento 1226', 'fran7356@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('41633267', 'Sandra', 'Gonzales', '3795732367', 'Gral. Paz 877', 'sandragonz@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('41235673', 'Oscar', 'Cruz', '3794763354', 'Bolivar 552', 'oscarcruz@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('39652433', 'Melina', 'Espinoza', '3795632443', 'Junin 323', 'meliespin@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('38765523', 'Sofia', 'Ruiz', '3795648735', 'Alvear 873', 'sofiruiz@gmail.com', 3);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('38652341', 'Lucrecia', 'Vazquez', '3794536472', 'Jujuy 448', 'lucreciavaz@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('23546345', 'Ramon', 'Rojas', '3794885522', '9 De Julio 1350', 'ramonrojas@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('34546890', 'Franco', 'Torres', '3794221122', 'Chaco 559', 'francotorrez@gmail.com', 2);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('35647835', 'Juan', 'Suarez', '3794876543', 'San Martin 663', 'juansuarez@gmail.com', 1);


INSERT INTO Marca (marca_descripcion) VALUES ('Fender');
INSERT INTO Marca (marca_descripcion) VALUES ('Gibson');
INSERT INTO Marca (marca_descripcion) VALUES ('Ibanez');
INSERT INTO Marca (marca_descripcion) VALUES ('Epiphone');
INSERT INTO Marca (marca_descripcion) VALUES ('Taylor');
INSERT INTO Marca (marca_descripcion) VALUES ('Gretsch');
INSERT INTO Marca (marca_descripcion) VALUES ('Squier');
INSERT INTO Marca (marca_descripcion) VALUES ('PRS');
INSERT INTO Marca (marca_descripcion) VALUES ('Marshall');
INSERT INTO Marca (marca_descripcion) VALUES ('Boss');
INSERT INTO Marca (marca_descripcion) VALUES ('Orange');
INSERT INTO Marca (marca_descripcion) VALUES ('Vox');


INSERT INTO Categoria(categoria_descripcion) VALUES ('Guitarra Electrica');
INSERT INTO Categoria(categoria_descripcion) VALUES ('Guitarra Acustica');
INSERT INTO Categoria(categoria_descripcion) VALUES ('Bajos');
INSERT INTO Categoria(categoria_descripcion) VALUES ('Amplificadores');
INSERT INTO Categoria(categoria_descripcion) VALUES ('Pedales');
INSERT INTO Categoria(categoria_descripcion) VALUES ('Accesorios');

INSERT INTO Productos
(categoria_id,marca_id,nombre,descripcion,precio,stock) 
VALUES (1,1,
'Fender Player Series Stratocaster Maple Fingerboard Electric Guitar Polar White',
'Over the decades, players have been continually inspired by the sound of a Strat. From the clarity of the high end, through the gut punch of the mids and the solid lows,
its a sound thats helped define what an electric guitar should be�versatile enough for any style and broad enough for any player to find an individual voice. This Player Series
Stratocaster puts all of the classic features of the Strat at your fingertips while adding a modern edge, including a modern neck profile, medium-jumbo frets and a freshly redesigned
2-point fulcrum vibrato bridge. With a beautiful gloss finish over a solid alder body, a 22-fret pau ferro fingerboard with a contemporary 9.5" radius for easy bending, the Player
Series Stratocaster is primed and ready to carry you along your musical voyage.',
849.99,20);

INSERT INTO Productos
(categoria_id,marca_id,nombre,descripcion,precio,stock) 
VALUES (1,1,
'Fender Player Telecaster Maple Fingerboard Electric Guitar Butterscotch Blonde',
'From a whisper to a scream, from pure country twang to serious rock and roll�even jazz�there 
are few guitars as outright versatile as a Telecaster. Respecting that long and storied heritage, 
while enhancing the instrument with the kinds of contemporary innovations that appeal to both casual 
and professional players, the Fender Player Series Telecaster puts a modern edge on the authentic Tele 
tone and vibe.',
849.99,20);


INSERT INTO Productos
(categoria_id,marca_id,nombre,descripcion,precio,stock) 
VALUES (1,1,
'Gibson Les Paul Traditional Pro V Flame Top Electric Guitar Washed Cherry Burst',
'The Gibson Les Paul Traditional PRO V, commonly referred to as the �Trad PRO V.� brings Gibson tradition together with a unique feature set. 
Designed to make a must-have instrument for players who desire that classic Les Paul vibe, the guitar is also loaded with modern features that enhance tone and playability.',
3099,20);

INSERT INTO Productos
(categoria_id,marca_id,nombre,descripcion,precio,stock) 
VALUES (2,5,
'Taylor 214ce Rosewood Grand Auditorium Acoustic-Electric Guitar Natural',
'Taylor 200 Series delivers all the essentials of a great guitar: exquisite playability, a full and articulate voice, 
impeccable intonation up the neck, and Taylors top-of-the-line, professional-grade pickup�at a price thats 
within reach. To add further value to these instruments, Taylor uses genuine West-African Responsible Trade Ebony 
fretboards and bridges to give players the feel and performance that only comes from this amazing wood. A gorgeous 
layered rosewood back and sides adorn an internal architecture that has been optimized for even more volume and dynamics.
All 200 Series guitars ship in a lightweight, Taylor gig bag with double-stitched seams and reinforced stress points.',
1099,20);



INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('23784563','Maria', 'Melgarejo','3794237465','Av Maipu 234', '2021-01-01', '1998-06-24', 'mari@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('41732563','Juan', 'Shuck','3795743672','Aconcagua 823', '2021-03-01', '1999-03-20', 'juan_shuck@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('41633267', 'Sandra', 'Gonzales', '3795732367', 'Gral. Paz 877', '2021-02-01', '1999-06-24', 'sandragonz@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('41235673', 'Oscar', 'Cruz', '3794763354', 'Bolivar 552', '2021-02-01', '1998-03-15', 'oscarcruz@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('39652433', 'Melina', 'Espinoza', '3795632443', 'Junin 323', '2022-01-01', '1996-06-23', 'meliespin@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('38765523', 'Sofia', 'Ruiz', '3795648735', 'Alvear 873', '2021-01-01', '1997-10-12', 'sofiruiz@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('38652341', 'Lucrecia', 'Vazquez', '3794536472', 'Jujuy 448', '2021-06-01', '1994-01-24', 'lucreciavaz@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('23546345', 'Ramon', 'Rojas', '3794885522', '9 De Julio 1350', '2021-06-01', '1985-11-24', 'ramonrojas@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('34546890', 'Franco', 'Torres', '3794221122', 'Chaco 559', '2022-01-01', '1992-02-12', 'francotorrez@gmail.com')
INSERT INTO Empleados(dni,nombre,apellido,telefono,direccion,fechaIngreso,fechaNac,email) VALUES ('35647835', 'Juan', 'Suarez', '3794876543', 'San Martin 663', '2022-01-01', '1993-12-12', 'juansuarez@gmail.com')


INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('43672543', 'Francisco', 'Sanchez', '3794334564', 'Av Sarmiento 1226', 'fran7356@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('41633267', 'Sandra', 'Gonzales', '3795732367', 'Gral. Paz 877', 'sandragonz@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('41235673', 'Oscar', 'Cruz', '3794763354', 'Bolivar 552', 'oscarcruz@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('39652433', 'Melina', 'Espinoza', '3795632443', 'Junin 323', 'meliespin@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('38765523', 'Sofia', 'Ruiz', '3795648735', 'Alvear 873', 'sofiruiz@gmail.com', 3);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('38652341', 'Lucrecia', 'Vazquez', '3794536472', 'Jujuy 448', 'lucreciavaz@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('23546345', 'Ramon', 'Rojas', '3794885522', '9 De Julio 1350', 'ramonrojas@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('34546890', 'Franco', 'Torres', '3794221122', 'Chaco 559', 'francotorrez@gmail.com', 2);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('35647835', 'Juan', 'Suarez', '3794876543', 'San Martin 663', 'juansuarez@gmail.com', 1);

INSERT INTO Roles(rol) VALUES ('Administrador')
INSERT INTO Roles(rol) VALUES (' Super Administrador')
INSERT INTO Roles(rol) VALUES ('Gerente')
INSERT INTO Roles(rol) VALUES ('Vendedor')


INSERT INTO TipoFactura(tipo) VALUES ('A');
INSERT INTO TipoFactura(tipo) VALUES ('B');
INSERT INTO TipoFactura(tipo) VALUES ('C');

SELECT * FROM Productos


SELECT * FROM Roles


SELECT Clientes.id_cliente, Clientes.dni, Clientes.nombre,Clientes.apellido, Clientes.telefono, Clientes.email, TipoCliente.tipo
FROM Clientes
INNER JOIN TipoCliente
ON Clientes.id_tipoCliente = TipoCliente.id_tipoCliente;


SELECT * FROM TipoCliente



SELECT * FROM Empleados
SELECT * FROM Usuarios

SELECT * FROM Ventas
SELECT * FROM DetalleVenta
Select * from Productos

DELETE FROM Ventas WHERE id_ventas = 2;
DELETE FROM DetalleVenta WHERE id_ventas = 2;