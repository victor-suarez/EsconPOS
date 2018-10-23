BEGIN TRANSACTION;
DROP TABLE IF EXISTS `UnidadesMedidas`;
CREATE TABLE IF NOT EXISTS `UnidadesMedidas` (
	`UnidadMedidaID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Codigo`	TEXT NOT NULL,
	`UnidadMedida`	TEXT NOT NULL,
	`PorDefecto`	INTEGER NOT NULL DEFAULT 0
);
DROP TABLE IF EXISTS `TiposDocumentos`;
CREATE TABLE IF NOT EXISTS `TiposDocumentos` (
	`TipoDocumentoID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Codigo`	TEXT NOT NULL,
	`TipoDocumento`	TEXT NOT NULL
);
DROP TABLE IF EXISTS `Provincias`;
CREATE TABLE IF NOT EXISTS `Provincias` (
	`ProvinciaID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`DepartamentoID`	INTEGER NOT NULL,
	`Provincia`	TEXT NOT NULL,
	`UBIGEO`	TEXT NOT NULL,
	FOREIGN KEY(`DepartamentoID`) REFERENCES `Departamentos`(`DepartamentoID`)
);
DROP TABLE IF EXISTS `Productos`;
CREATE TABLE IF NOT EXISTS `Productos` (
	`ProductoID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Codigo`	TEXT NOT NULL,
	`Producto`	TEXT NOT NULL,
	`TipoID`	NUMERIC NOT NULL,
	`MarcaID`	INTEGER NOT NULL,
	`ImpuestoID`	INTEGER NOT NULL
);
DROP TABLE IF EXISTS `Paises`;
CREATE TABLE IF NOT EXISTS `Paises` (
	`PaisID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Codigo`	TEXT NOT NULL,
	`Pais`	TEXT NOT NULL
);
DROP TABLE IF EXISTS `Monedas`;
CREATE TABLE IF NOT EXISTS `Monedas` (
	`MonedaID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Codigo`	TEXT NOT NULL,
	`Moneda`	TEXT NOT NULL,
	`PorDefecto`	INTEGER NOT NULL DEFAULT 0,
	`Base`	INTEGER NOT NULL DEFAULT 0,
	`FactorCambiario`	REAL NOT NULL DEFAULT 1
);
DROP TABLE IF EXISTS `Impuestos`;
CREATE TABLE IF NOT EXISTS `Impuestos` (
	`ImpuestoID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Impuesto`	TEXT NOT NULL,
	`Codigo`	TEXT NOT NULL,
	`Categoria`	TEXT NOT NULL,
	`Tasa`	REAL NOT NULL DEFAULT 0,
	`ValidoDesde`	TEXT NOT NULL,
	`ValidoHasta`	TEXT,
	`Activo`	INTEGER NOT NULL DEFAULT 1
);
DROP TABLE IF EXISTS `Identificaciones`;
CREATE TABLE IF NOT EXISTS `Identificaciones` (
	`IdentificacionID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Codigo`	TEXT NOT NULL,
	`Identificacion`	TEXT NOT NULL
);
DROP TABLE IF EXISTS `EmpresasEmpleados`;
CREATE TABLE IF NOT EXISTS `EmpresasEmpleados` (
	`EmpresaID`	INTEGER NOT NULL,
	`EmpleadoID`	INTEGER NOT NULL,
	FOREIGN KEY(`EmpleadoID`) REFERENCES `Empleados`(`EmpleadoID`),
	PRIMARY KEY(`EmpresaID`,`EmpleadoID`),
	FOREIGN KEY(`EmpresaID`) REFERENCES `Empresas`(`EmpresaID`)
);
DROP TABLE IF EXISTS `EmpresasClientes`;
CREATE TABLE IF NOT EXISTS `EmpresasClientes` (
	`EmpresaID`	INTEGER NOT NULL,
	`ClienteID`	INTEGER NOT NULL,
	PRIMARY KEY(`EmpresaID`,`ClienteID`),
	FOREIGN KEY(`ClienteID`) REFERENCES `Clientes`(`ClienteID`),
	FOREIGN KEY(`EmpresaID`) REFERENCES `Empresas`(`EmpresaID`)
);
DROP TABLE IF EXISTS `Empresas`;
CREATE TABLE IF NOT EXISTS `Empresas` (
	`EmpresaID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`IdentificacionID`	INTEGER NOT NULL,
	`NroDocIdent`	TEXT NOT NULL,
	`NombreComercial`	TEXT,
	`RazonSocial`	TEXT NOT NULL,
	`Direccion`	TEXT NOT NULL,
	`DistritoID`	INTEGER,
	`Urbanizacion`	TEXT,
	`NroTelefonico`	TEXT,
	`CorreoElectronico`	TEXT,
	FOREIGN KEY(`IdentificacionID`) REFERENCES `Identificaciones`(`IdentificacionID`),
	FOREIGN KEY(`DistritoID`) REFERENCES `Distritos`(`DistritoID`)
);
DROP TABLE IF EXISTS `Empleados`;
CREATE TABLE IF NOT EXISTS `Empleados` (
	`EmpleadoID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`IdentificacionID`	INTEGER NOT NULL,
	`NroDocIdent`	TEXT NOT NULL,
	`Nombre`	TEXT NOT NULL,
	`Direccion`	TEXT,
	`Telefono`	TEXT,
	`CorreoElectronico`	TEXT,
	`Login`	TEXT NOT NULL,
	`PasswdHash`	BLOB NOT NULL,
	`EsSupervisor`	INTEGER NOT NULL DEFAULT 0 CHECK(EsSupervisor = 0 OR EsSupervisor = 1),
	`EsAdministrador`	INTEGER NOT NULL DEFAULT 0 CHECK(EsAdministrador = 0 OR EsAdministrador = 1)
);
DROP TABLE IF EXISTS `Distritos`;
CREATE TABLE IF NOT EXISTS `Distritos` (
	`DistritoID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`ProvinciaID`	INTEGER NOT NULL,
	`Distrito`	TEXT NOT NULL,
	`UBIGEO`	TEXT NOT NULL,
	FOREIGN KEY(`ProvinciaID`) REFERENCES `Provincias`(`ProvinciaID`)
);
DROP TABLE IF EXISTS `Departamentos`;
CREATE TABLE IF NOT EXISTS `Departamentos` (
	`DepartamentoID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`PaisID`	INTEGER NOT NULL,
	`Departamento`	TEXT NOT NULL,
	`UBIGEO`	TEXT NOT NULL,
	FOREIGN KEY(`PaisID`) REFERENCES `Paises`(`PaisID`)
);
DROP TABLE IF EXISTS `Configuraciones`;
CREATE TABLE IF NOT EXISTS `Configuraciones` (
	`ConfiguracionID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`CajaID`	INTEGER NOT NULL,
	`Configuracion`	TEXT NOT NULL,
	`Valor`	TEXT NOT NULL
);
DROP TABLE IF EXISTS `Clientes`;
CREATE TABLE IF NOT EXISTS `Clientes` (
	`ClienteID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`IdentificacionID`	INTEGER NOT NULL,
	`NroDocIdent`	TEXT NOT NULL,
	`Nombre`	TEXT NOT NULL,
	`Direccion`	TEXT,
	`PaisID`	INTEGER,
	`DistritoID`	INTEGER,
	`NroTelefonico`	TEXT,
	`CorreoElectronico`	TEXT,
	FOREIGN KEY(`PaisID`) REFERENCES `Paises`(`PaisID`),
	FOREIGN KEY(`IdentificacionID`) REFERENCES `Identificaciones`(`IdentificacionID`),
	FOREIGN KEY(`DistritoID`) REFERENCES `Distritos`(`DistritoID`)
);
COMMIT;
