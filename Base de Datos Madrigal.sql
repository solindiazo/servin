
CREATE TABLE UNIDAD_MEDIDA(
	UnidM_Nombre VARCHAR(45) PRIMARY KEY
	)

INSERT INTO UNIDAD_MEDIDA VALUES ('Metro'), ('Unidad');

CREATE TABLE MATERIAL(
	Mat_Nombre VARCHAR(50) NOT NULL PRIMARY KEY,
	Mat_Precio FLOAT NOT NULL,
	Mat_UnitMedida VARCHAR (45) NOT NULL,
	Mat_Estado VARCHAR(1) NOT NULL
	FOREIGN KEY (Mat_UnitMedida) REFERENCES UNIDAD_MEDIDA (UnidM_Nombre)
	)

CREATE TABLE CATEGORIA(
	Categ_Nombre VARCHAR(25) NOT NULL PRIMARY KEY,
	Categ_Estado VARCHAR(1) NOT NULL
	)

CREATE TABLE SUBCATEGORIA(
	SubCa_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	SubCa_Nombre VARCHAR(50) NOT NULL,
	SubCa_Categoria VARCHAR(25) NOT NULL,
	SubCa_Estado VARCHAR(1) NOT NULL,
	FOREIGN KEY (SubCa_Categoria) REFERENCES CATEGORIA (Categ_Nombre)
	)
	
CREATE TABLE PERSONA(
	Perso_ID VARCHAR(15) NOT NULL PRIMARY KEY,
	Perso_Nombre VARCHAR(50) NOT NULL,
	Perso_Apellido VARCHAR(25) NULL,
	Perso_Telefono VARCHAR(15) NOT NULL,
	Perso_Direccion VARCHAR(50) NULL,
	Perso_Tipo VARCHAR(1) NOT NULL
	)

CREATE TABLE PROVEEDOR(
	Provee_ID VARCHAR(15) NOT NULL PRIMARY KEY,
	Provee_Descripcion VARCHAR(200) NOT NULL,
	Provee_Estado VARCHAR(1) NOT NULL,
	FOREIGN KEY (Provee_ID) REFERENCES PERSONA (Perso_ID),
		)

CREATE TABLE SUMINISTRO(
	Sumin_Proveedor VARCHAR(15) NOT NULL,
	Sumin_Material VARCHAR(50) NOT NULL,
	Sumin_Cantidad INT NOT NULL,
	Sumin_Fecha DATE NOT NULL,
	FOREIGN KEY (Sumin_Proveedor)  REFERENCES PROVEEDOR (Provee_ID),
	FOREIGN KEY (Sumin_Material) REFERENCES MATERIAL (Mat_Nombre)
	)

CREATE TABLE ROL(
	Rol_Nombre VARCHAR(15) NOT NULL PRIMARY KEY,
	Rol_Descripcion VARCHAR(150) NULL
	)

CREATE TABLE FUNCION(
	Funci_Nombre VARCHAR(25) NOT NULL PRIMARY KEY,
	Funci_TiempoxM2 INT NOT NULL,
	Funci_CostoxM2 INT NOT NULL
	)

CREATE TABLE EMPLEADO(
	Emple_ID VARCHAR(15) NOT NULL PRIMARY KEY,
	Emple_Funcion VARCHAR(25) NOT NULL,
	Emple_Estado VARCHAR(1) NOT NULL,
	FOREIGN KEY (Emple_ID) REFERENCES PERSONA (Perso_ID),
	FOREIGN KEY (Emple_Funcion) REFERENCES FUNCION (Funci_Nombre)
	)

CREATE TABLE LOGIN(
	Login_Usuario VARCHAR(15) NOT NULL PRIMARY KEY,
	Login_Pass VARCHAR(25) NOT NULL,
	Login_Estado VARCHAR(1) NOT NULL,
	Login_Rol VARCHAR(15) NOT NULL,
	FOREIGN KEY (Login_Usuario) REFERENCES EMPLEADO (Emple_ID),
	FOREIGN KEY (Login_Rol) REFERENCES ROL (Rol_Nombre)
	)

CREATE TABLE CLIENTE(
	Clien_ID VARCHAR(15) NOT NULL PRIMARY KEY,
	Clien_Estado VARCHAR(1) NOT NULL,
	FOREIGN KEY (Clien_ID) REFERENCES PERSONA (Perso_ID)
	)


CREATE TABLE COTIZACION(
	Coti_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Coti_CC VARCHAR(15) NOT NULL,
	Coti_Nombre VARCHAR(25) NOT NULL,
	Coti_Apellido VARCHAR(25) NOT NULL,
	Coti_Telefono VARCHAR(15) NOT NULL,
	Coti_Direccion VARCHAR(50) NULL,
	Coti_Trabajo VARCHAR(15) NOT NULL, --Elaboracion --Reparacion
	Coti_Fecha DATE NOT NULL,
	Coti_Tipo VARCHAR(22) NOT NULL, --Cotizacion --Venta --Ya merito
	Coti_Cant INT NOT NULL,
	Coti_Observaciones VARCHAR(400) NULL,
	Coti_SubCategoria INT NOT NULL,
	FOREIGN KEY (Coti_SubCategoria) REFERENCES SUBCATEGORIA (SubCa_ID)
	)

CREATE TABLE COTIZACION_MATERIAL(
		CotM_Cotizacion INT NOT NULL,
		CotM_Material VARCHAR(50) NOT NULL,
		CotM_Cant INT NOT NULL,
		FOREIGN KEY (CotM_Cotizacion) REFERENCES COTIZACION (Coti_ID),
		FOREIGN KEY (CotM_Material) REFERENCES MATERIAL (Mat_Nombre)
	)

CREATE TABLE PROYECTO(
	Proye_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Proye_Descripcion VARCHAR(250) NULL,
	Proye_CostoProduccion FLOAT NOT NULL,
	Proye_Estado VARCHAR(1) NOT NULL, --Completado, En proceso, Cancelado
	Proye_Cotizacion INT NOT NULL,
	FOREIGN KEY (Proye_Cotizacion) REFERENCES COTIZACION (Coti_ID),
	)

CREATE TABLE TRABAJO(
	Trab_Proyecto INT NOT NULL,
	Trab_Empleado VARCHAR(15) NOT NULL,
	Trab_Pago FLOAT NULL,
	Trab_FechaInicio DATETIME NOT NULL,
	Trab_FechaFin DATETIME NOT NULL,
	FOREIGN KEY (Trab_Proyecto) REFERENCES PROYECTO (Proye_ID),
	FOREIGN KEY (Trab_Empleado) REFERENCES EMPLEADO (Emple_ID)
	)




use SERVIN_MADRIGAL;

insert into rol (Rol_Nombre) values ('Administrador'),('Usuario');

Insert into funcion values('Administrar','0','0');

insert into PERSONA values ('1026290127','Jessica','Botello','3194763198','Tv 5 G','N');

insert into EMPLEADO values ('1026290127','Administrar','1');

insert into LOGIN values ('1026290127','123','1','Administrador');

Insert into funcion values('Cortador','5','10000');