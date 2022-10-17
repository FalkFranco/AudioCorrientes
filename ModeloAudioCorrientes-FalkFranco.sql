--CREATE DATABASE AudioCorrientes
USE AudioCorrientes


CREATE TABLE TipoCliente(
	id_tipoCliente INT PRIMARY KEY IDENTITY,
	tipo VARCHAR(40)
);


CREATE TABLE Clientes (
	id_cliente INT PRIMARY KEY IDENTITY,
	dni VARCHAR(8) NOT NULL,
	nombre VARCHAR(25) NOT NULL,
	apellido VARCHAR(25) NOT NULL,
	telefono VARCHAR(30) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	id_tipoCliente INT NOT NULL,
	CONSTRAINT FK_Cliente_TipoCliente FOREIGN KEY (id_tipoCLiente)  REFERENCES TipoCliente(id_tipoCLiente),
	CONSTRAINT UQ_cuit UNIQUE (dni),
	CONSTRAINT CK_dni CHECK (len(dni) = 8),
	CONSTRAINT UQ_email UNIQUE (email),
	CONSTRAINT CK_email CHECK (email like '_%@__%.__%' or email like '_%@__%.__.__%'),
	CONSTRAINT CK_telefono CHECK (len(telefono) = 10)
);

INSERT INTO Clientes(dni,nombre,apellido,telefono,direccion,email,id_tipoCliente) VALUES ('12345678','Franco','Falk','3794396611','Junin 378','franco@gmail.com.ar',1)

CREATE TABLE Categoria(
	id_categorias INT PRIMARY KEY IDENTITY,
	categoria VARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE Marca(
	id_marcas INT PRIMARY KEY IDENTITY,
	marca VARCHAR(40) UNIQUE NOT NULL,
	CONSTRAINT UQ_marca UNIQUE (marca)
);

CREATE TABLE Productos(
	id_productos INT PRIMARY KEY IDENTITY,
	id_categorias INT NOT NULL,
	id_marcas INT NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR(100) NOT NULL,
	precio FLOAT NOT NULL,
	stock INT NOT NULL,
	estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT FK_Producto_Categoria FOREIGN KEY (id_categorias)  REFERENCES Categoria(id_categorias),
	CONSTRAINT FK_Producto_Marca FOREIGN KEY (id_marcas)  REFERENCES Marca(id_marcas)
)


CREATE TABLE Roles(
	id_rol INT PRIMARY KEY IDENTITY,
	rol VARCHAR(25) NOT NULL
)

CREATE TABLE Empleados(
	id_empleado INT PRIMARY KEY IDENTITY,
	dni INT NOT NULL,
	nombre VARCHAR(25) NOT NULL,
	apellido VARCHAR(25) NOT NULL,
	telefono VARCHAR(30) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	activo BIT NOT NULL DEFAULT 1,
	fechaIngreso DATE NOT NULL,
	fechaNac DATE NOT NULL,
	email VARCHAR(25) NOT NULL,
	CONSTRAINT UQ_dni UNIQUE (dni),
	CONSTRAINT CK_dni_Empleado CHECK (len(dni) = 8)
);

CREATE TABLE Usuarios(
	id_usuario INT PRIMARY KEY IDENTITY,
	id_empleado INT NOT NULL,
	usuario VARCHAR(25) NOT NULL,
	contrasena VARCHAR(50) NOT NULL,
	id_rol INT NOT NULL,
	activo BIT DEFAULT 1,
	CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_rol)  REFERENCES Roles(id_rol),
	CONSTRAINT FK_Usuario_Empleado FOREIGN KEY (id_empleado) REFERENCES Empleados(id_empleado),
	CONSTRAINT UQ_Usuario UNIQUE (usuario),
	CONSTRAINT CK_PassValidate CHECK (contrasena like '%[0-9]%' and contrasena like '%[A-Z]%' and contrasena like '%[!@#$%a^&*()-_+=.,;:"`~]%' and len(contrasena) >= 8)
);

CREATE TABLE TipoFactura(
	id_tipoFactura INT PRIMARY KEY IDENTITY,
	tipo VARCHAR(25) NOT NULL,
	descripcion VARCHAR(40)
)

CREATE TABLE Ventas(
	id_ventas INT PRIMARY KEY IDENTITY,
	id_tipoFactura INT NOT NULL,
	fecha DATE NOT NULL,
	id_empleado INT NOT NULL,
	id_cliente INT NOT NULL,
	total FLOAT NOT NULL,
	estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT FK_Venta_TipoFactura FOREIGN KEY (id_tipoFactura)  REFERENCES TipoFactura(id_tipoFactura),
	CONSTRAINT FK_Venta_Empleado FOREIGN KEY (id_empleado)  REFERENCES Empleados(id_empleado),
	CONSTRAINT FK_Venta_Cliente FOREIGN KEY (id_cliente)  REFERENCES Clientes(id_cliente),
	CONSTRAINT CK_MAYOR_ACTUAL CHECK (fecha >= CONVERT (Date, GETDATE()))
);

CREATE TABLE DetalleVenta(
	id_detalleVenta INT PRIMARY KEY IDENTITY,
	id_ventas INT NOT NULL,
	id_productos INT NOT NULL,
	precioVenta FLOAT NOT NULL,
	cantidad INT NOT NULL,
	subtotal FLOAT NOT NULL,
	CONSTRAINT FK_Detalle_Venta FOREIGN KEY (id_ventas)  REFERENCES Ventas(id_ventas),
	CONSTRAINT FK_Detalle_Producto FOREIGN KEY (id_productos)  REFERENCES Productos(id_productos),
	CONSTRAINT CK_Cantidad CHECK (cantidad > 0)
);


--INSERCIÓN DE DATOS Y CONSULTAS


INSERT INTO TipoCliente (tipo) VALUES ('Consumidor final');
INSERT INTO TipoCliente (tipo) VALUES ('Responsable Inscripto');
INSERT INTO TipoCliente (tipo) VALUES ('Monotributista');


INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('25633256', 'Juan', 'Esteban', '3794275467', 'Las Heras 734', 'juanperez@gmail.com', 1);


SELECT Clientes.id_cliente, Clientes.dni, Clientes.nombre,Clientes.apellido, Clientes.telefono, Clientes.email, TipoCliente.tipo
FROM Clientes
INNER JOIN TipoCliente
ON Clientes.id_tipoCliente = TipoCliente.id_tipoCliente;


SELECT * FROM TipoCliente



INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('41632735', 'Maria', 'Ramirez', '379442345', 'Av Maipu 1227', 'mariaramirez@gmail.com', 2);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('42673564', 'Jualiana', 'Lopez', '3794735624', 'Las Madrid 1234', 'julilopez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('25874361', 'Pedro', 'Gomez', '3794735462', 'Niza 345', 'pedrogomez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('25436523', 'Nicolas', 'Gomez', '3794635241', 'Alberti 332', 'nicogomez@gmail.com', 1);
INSERT INTO Clientes (dni, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('42673546', 'Joaquin', 'Gonzalez', '3795872453', 'Ombú 122', 'juaquin2010@gmail.com', 1);
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





























































