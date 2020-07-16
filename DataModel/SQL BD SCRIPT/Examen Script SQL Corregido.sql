
--Se ejecuta la siguiente linea como PASO 1 para crear la Base de Datos examen
create database examen;

--PASO 2 Seleccionar a partir de esta linea hasta la última y ejecutar
--Se selecciona la Base de Datos que usaremos para la creación de los objetos
use examen;

-- Se crea la tabla PRODUCTO_W
create table PRODUCTO_W 
(
SKU varchar(150) primary key,
NOMBRE varchar(200),
EXISTENCIA integer,
PRICE float --double -- Se comenta el tipo de dato que no es válido en SQL Server
)

--Se elimina linea no aceptada en SQL Server
--ENGINE=INNODB;

-- Se crea la tabla USUARIOS_W
create table USUARIOS_W(
USERNAME varchar(150) primary key,
PASSWORD varchar(200),
ROLE varchar(200),
NOMBRE varchar(200),
APELLIDOS varchar(200)
)

--Se elimina linea no aceptada en SQL Server
--ENGINE=INNODB;

-- Se crea la tabla PEDIDOS_W
create table PEDIDOS_W
(
ID int primary key identity(1,1), --Se marca el campo ID como identity e incrementable de 1-1, se comenta -- AUTO_INCREMENT no es válido
TOTAL float, --double -- Se comenta el tipo de dato que no es válido en SQL Server 
DATE_SALE date,
USERNAME varchar(150),
foreign key (USERNAME) references USUARIOS_W(USERNAME))

-- Se crea la tabla PEDIDOS_DETALLE_W
create table PEDIDOS_DETALLE_W
(
ID int primary key identity(1,1), -- Se marca el campo ID como identity e incrementable de 1-1, se comenta -- AUTO_INCREMENT no es válido
ID_PEDIDO integer,
SKU varchar(150),
AMOUT float, --double -- Se comenta el tipo de dato que no es válido en SQL Server
PRICE float, --double -- Se comenta el tipo de dato que no es válido en SQL Server
foreign key (ID_PEDIDO) references PEDIDOS_W(ID),
foreign key (SKU) references PRODUCTO_W(SKU)
)

--Se elimina linea no aceptada en SQL Server
--ENGINE=INNODB;

--Se realiza la insercion en la tabla USUARIOS_W

insert into USUARIOS_W (USERNAME, PASSWORD, ROLE, NOMBRE, APELLIDOS) values('admin', '123456', 'admin', 'Candidato', 'Candidato Truper');
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910606', 'R22-TAPI-13|BARRA SOPORTE MOTOR IZQUIERDA (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910607', 'R23-TAPI-13|TORNILLO HEXAGONAL M8X40MM (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910608', 'R24-TAPI-13|RONDANA PLANA Ø8 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910609', 'R25-TAPI-13|MONTURA MOTOR (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910610', 'R26-TAPI-13|RONDANA PLANA Ø12 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910611', 'R27-TAPI-13|RONDANA DE PRESION Ø12 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910612', 'R28-TAPI-13|TUERCA HEXAGONAL M12 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910613', 'R29.1-TAPI-13|VENTLADOR (PLASTICO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910614', 'R29.2-TAPI-13|CAJA DEL CAPACITOR (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910615', 'R29.3-TAPI-13|RONDANA PLANA Ø4 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('910616', 'R29.4-TAPI-13|TORNILLO PAN M4X6MM  (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('907855', 'R274-SME-10X-2|TUERCA HEXAGONAL M14 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999965', 'LJ-NS-278|LJ-NS-278', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('88836', 'TARIMA P/CARRETILLA CAT-KID', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('88980', 'TARIMA PARA CONTENEDOR #1 Y #2 DE EXHIBI', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('19806', 'PP-10|CARRETILLA DOBLE LLANTA,MGOS/MAD 2,10FT', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('89177', 'TARIMA PARA CAT KID', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('89509', 'BOLSA TORNILLOS|BOLSA TORN. CAT-KIT TUB.', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911925', 'R81-CEP-13|BALERO DE BOLAS 6203 (ACERO-PLASTICO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911926', 'R82-CEP-13|ARMAZON SUPERIOR (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911927', 'R82.2-CEP-13|RONDANA DENTADA   Ø4 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911928', 'R83-CEP-13|OPRESOR DE CABLE (PLASTICO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911929', 'R83.1-CEP-13|TORNILLO PAN M4X14MM (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911930', 'R84-CEP-13|RONDANA PLANA Ø4 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911931', 'R85-CEP-13|DEFLECTOR DE ASERRIN (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911932', 'R85.1-CEP-13|TORNILLO PAN M4X8MM (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911933', 'R86-CEP-13|TUERCA HEXAGONAL M20 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911934', 'R87-CEP-13|SOPORTE DERECHO (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911935', 'R88-CEP-13|RESORTE (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911936', 'R89-CEP-13|FRENO DE SEGURIDAD (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911937', 'R90-CEP-13|TORNILLO ALLEN M5X12MM (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911938', 'R91-CEP-13|PLACA DE CONEXION (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911939', 'R92-CEP-13|RONDANA PLANA Ø8 (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('911940', 'R93-CEP-13|TORNILLO HEXAGONAL M8X16MM (ACERO)', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999971', 'LJ-NS-285|LJ-NS-285', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999972', 'LJ-NS-286|LJ-NS-286', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999973', 'LJ-NS-287|LJ-NS-287', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999975', 'LJ-NS-289|LJ-NS-289', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999976', 'LJ-NS-290|LJ-NS-290', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999977', 'LJ-NS-291|LJ-NS-291', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('999979', 'LJ-NS-293|LJ-NS-293', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('74632', 'ET-CB-R-16MF ETIQUETA CODIGO DE BARRAS', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('74633', 'ET-CB-R8M-KID ETIQUETA CODIGO DE BARRAS', 300, 100); 
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('74609', 'ET-CB-EP-30 ETIQUETA CODIGO DE BARRAS', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('74639', 'ET-CB-MARTE-TP-M', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('31417', 'TRS-5F-GR|PALA PARA CANERIAS 5', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('86632', 'ENSAMBLE DE TARIMA Y CONTENEDOR MADERA', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('86714', 'SUBENSAMBLE TUBO-SOLERA R-4 FOR', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('86910', 'TARIMA DE 1.0X 1.2 HOME DEPOT', 300, 100);
insert into PRODUCTO_W (SKU, NOMBRE, EXISTENCIA, PRICE) values('87010', 'DISPLAY-36-PRL-E-LW/36-R16AM-E-LW S/PROD', 300, 100);


--Se modifica tabla de USUARIOS_W para agregar el campo TOKEN y así poder realizar la autenticación Jeison Web Token
alter table USUARIOS_W
add TOKEN uniqueidentifier null