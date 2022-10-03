--CREATE DATABASE AudioCorrientes
--USE AudioCorrientes


CREATE TABLE TipoCliente(
	id_tipoCliente INT PRIMARY KEY IDENTITY,
	tipo VARCHAR(40)
);


CREATE TABLE Clientes (
	id_cliente INT PRIMARY KEY IDENTITY,
	cuit VARCHAR(30) NOT NULL UNIQUE,
	nombre VARCHAR(25) NOT NULL,
	apellido VARCHAR(25) NOT NULL,
	telefono VARCHAR(30) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL UNIQUE,
	id_tipoCliente INT NOT NULL,
	CONSTRAINT FK_Cliente_TipoCliente FOREIGN KEY (id_tipoCLiente)  REFERENCES TipoCliente(id_tipoCLiente)
);

CREATE TABLE Categoria(
	id_categorias INT PRIMARY KEY IDENTITY,
	categoria VARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE Marca(
	id_marcas INT PRIMARY KEY IDENTITY,
	marca VARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE Productos(
	id_productos INT PRIMARY KEY IDENTITY,
	id_categorias INT NOT NULL,
	id_marcas INT NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR(100) NOT NULL,
	precio FLOAT NOT NULL,
	stock INT NOT NULL,
	estado BIT NOT NULL,
	CONSTRAINT FK_Producto_Categoria FOREIGN KEY (id_categorias)  REFERENCES Categoria(id_categorias),
	CONSTRAINT FK_Producto_Marca FOREIGN KEY (id_marcas)  REFERENCES Categoria(id_categorias)
)

CREATE TABLE Roles(
	id_rol INT PRIMARY KEY IDENTITY,
	rol VARCHAR(25) NOT NULL
)

CREATE TABLE Empleados(
	id_empleado INT PRIMARY KEY IDENTITY,
	dni INT NOT NULL UNIQUE,
	nombre VARCHAR(25) NOT NULL,
	apellido VARCHAR(25) NOT NULL,
	telefono VARCHAR(30) NOT NULL,
	direccion VARCHAR(50) NOT NULL
);

CREATE TABLE Usuarios(
	id_usuario INT PRIMARY KEY IDENTITY,
	id_empleado INT NOT NULL,
	usuario VARCHAR(25) NOT NULL,
	contrasena VARCHAR(50) NOT NULL,
	id_rol INT NOT NULL,
	CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_rol)  REFERENCES Roles(id_rol),
	CONSTRAINT FK_Usuario_Empleado FOREIGN KEY (id_empleado)  REFERENCES Empleados(id_empleado)
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
	id_usuario INT NOT NULL,
	id_cliente INT NOT NULL,
	total FLOAT NOT NULL,
	CONSTRAINT FK_Venta_TipoFactura FOREIGN KEY (id_tipoFactura)  REFERENCES TipoFactura(id_tipoFactura),
	CONSTRAINT FK_Venta_Usuario FOREIGN KEY (id_usuario)  REFERENCES Usuarios(id_usuario),
	CONSTRAINT FK_Venta_Cliente FOREIGN KEY (id_cliente)  REFERENCES Clientes(id_cliente)
);

CREATE TABLE DetalleVenta(
	id_detalleVenta INT PRIMARY KEY IDENTITY,
	id_ventas INT NOT NULL,
	id_productos INT NOT NULL,
	precioVenta FLOAT NOT NULL,
	cantidad INT NOT NULL,
	subtotal FLOAT NOT NULL,
	CONSTRAINT FK_Detalle_Venta FOREIGN KEY (id_ventas)  REFERENCES Ventas(id_ventas),
	CONSTRAINT FK_Detalle_Producto FOREIGN KEY (id_productos)  REFERENCES Productos(id_productos)
);



--INSERCIÓN DE DATOS Y CONSULTAS


INSERT INTO TipoCliente (tipo) VALUES ('Consumidor final');
INSERT INTO TipoCliente (tipo) VALUES ('Responsable Inscripto');
INSERT INTO TipoCliente (tipo) VALUES ('Monotributista');


INSERT INTO Clientes (cuit, nombre, apellido, telefono, direccion, email, id_tipoCLiente) VALUES ('20237854670', 'Juan', 'Esteban', '3794275467', 'Las Heras 734', 'juanperez@gmail.com', 1);


SELECT Clientes.id_cliente, Clientes.cuit, Clientes.nombre,Clientes.apellido, Clientes.telefono, Clientes.email, TipoCliente.tipo
FROM Clientes
INNER JOIN TipoCliente
ON Clientes.id_tipoCliente = TipoCliente.id_tipoCliente;

































































