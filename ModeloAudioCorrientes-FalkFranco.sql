--CREATE DATABASE AudioCorrientes
--DROP DATABASE AudioCorrientes
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


CREATE TABLE Categoria(
	id_categorias INT PRIMARY KEY IDENTITY,
	categoria_descripcion VARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE Marca(
	id_marcas INT PRIMARY KEY IDENTITY,
	marca_descripcion VARCHAR(40) UNIQUE NOT NULL,
	CONSTRAINT UQ_marca UNIQUE (marca_descripcion)
);

CREATE TABLE Productos(
	id_productos INT PRIMARY KEY IDENTITY,
	categoria_id INT NOT NULL,
	marca_id INT NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	descripcion VARCHAR(900) NOT NULL,
	precio FLOAT NOT NULL,
	stock INT NOT NULL,
	estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT FK_Producto_Categoria FOREIGN KEY (categoria_id)  REFERENCES Categoria(id_categorias),
	CONSTRAINT FK_Producto_Marca FOREIGN KEY (marca_id)  REFERENCES Marca(id_marcas)
)

--ALTER TABLE Productos
--ALTER COLUMN nombre VARCHAR(100) NOT NULL; 
--ALTER TABLE Productos
--ALTER COLUMN descripcion VARCHAR(900) NOT NULL;


CREATE TABLE Roles(
	id_rol INT PRIMARY KEY IDENTITY,
	rol VARCHAR(25) NOT NULL
)

CREATE TABLE Empleados(
	id_empleado INT PRIMARY KEY IDENTITY,
	dni VARCHAR(8)NOT NULL,
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
	precioVenta FLOAT NOT NULL, --MODIFICAR (8,2)
	cantidad INT NOT NULL,
	subtotal FLOAT NOT NULL,
	CONSTRAINT FK_Detalle_Venta FOREIGN KEY (id_ventas)  REFERENCES Ventas(id_ventas),
	CONSTRAINT FK_Detalle_Producto FOREIGN KEY (id_productos)  REFERENCES Productos(id_productos),
	CONSTRAINT CK_Cantidad CHECK (cantidad > 0)
);


--INSERCI??N DE DATOS Y CONSULTAS






















SELECT * FROM Ventas












































