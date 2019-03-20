USE GD2C2017
GO
--Creación schema y tablas
CREATE SCHEMA [404_NOT_FOUND]
GO


CREATE TABLE [404_NOT_FOUND].[CLIENTES]
( 
	[clie_dni]           numeric(8)  NOT NULL ,
	[clie_apellido]      varchar(30)  NOT NULL ,
	[clie_nombre]        varchar(30)  NOT NULL ,
	[clie_fecha_nac]     smalldatetime  NOT NULL ,
	[clie_mail]          varchar(50)  NOT NULL ,
	[clie_habilitado]    bit  NOT NULL ,
	[clie_telefono]		 varchar(20) NULL
)
go

ALTER TABLE [404_NOT_FOUND].[CLIENTES]
	ADD CONSTRAINT [XPKClientes] PRIMARY KEY  CLUSTERED ([clie_dni] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Devoluciones]
( 
	[dev_motivo]         varchar(50)  NULL ,
	[dev_id]             integer  NOT NULL ,
	[dev_fecha]          datetime  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Devoluciones]
	ADD CONSTRAINT [XPKDevoluciones] PRIMARY KEY  CLUSTERED ([dev_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Direcciones]
( 
	[dir_cod_postal]     numeric(4)  NOT NULL ,
	[dir_localidad]      varchar(20)  NOT NULL ,
	[dir_piso]           varchar(8)  NULL ,
	[dir_depto]          char  NULL ,
	[clie_dni]           numeric(8)  NOT NULL ,
	[dir_calle]          varchar(60)  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Direcciones]
	ADD CONSTRAINT [XPKDirecciones_Clientes] PRIMARY KEY  CLUSTERED ([clie_dni] ASC)
go

CREATE TABLE [404_NOT_FOUND].[EMPRESAS]
( 
	[emp_cuit]           char(13)  NOT NULL ,
	[emp_nombre]         varchar(50)  NOT NULL ,
	[emp_habilitado]     bit  NOT NULL ,
	[emp_direccion]      varchar(60)  NOT NULL ,
	[emp_rubro]          integer  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[EMPRESAS]
	ADD CONSTRAINT [XPKEmpresas] PRIMARY KEY  CLUSTERED ([emp_cuit] ASC)
go

CREATE TABLE [404_NOT_FOUND].[FACTURAS]
( 
	[fact_numero]        integer  NOT NULL ,
	[fact_fecha_alta]    smalldatetime  NOT NULL ,
	[fact_total]         float  NOT NULL ,
	[fact_fecha_vencimiento] smalldatetime  NOT NULL ,
	[fact_emp_cuit]      char(13)  NOT NULL ,
	[fact_cliente]       numeric(8)  NOT NULL,
	[fact_habilitada]    bit not null
)
go

ALTER TABLE [404_NOT_FOUND].[FACTURAS]
	ADD CONSTRAINT [XPKFacturas] PRIMARY KEY  CLUSTERED ([fact_numero] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Funcionalidades]
( 
	[func_nombre]        varchar(40)  NOT NULL ,
	[func_detalle]       varchar(80)  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Funcionalidades]
	ADD CONSTRAINT [XPKFuncionalidades] PRIMARY KEY  CLUSTERED ([func_nombre] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Item_Pago]
( 
	[pago_id]            integer  NOT NULL ,
	[fact_numero]        integer  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Item_Pago]
	ADD CONSTRAINT [XPKItem_Pago] PRIMARY KEY  CLUSTERED ([pago_id] ASC,[fact_numero] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Item_Devolucion]
( 
	[dev_id]            integer  NOT NULL ,
	[fact_numero]        integer  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Item_Devolucion]
	ADD CONSTRAINT [XPKItem_Devolucion] PRIMARY KEY  CLUSTERED ([dev_id] ASC,[fact_numero] ASC)
go


CREATE TABLE [404_NOT_FOUND].[Item_Rendicion]
( 
	[fact_numero]        integer  NOT NULL ,
	[rend_id]            integer  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Item_Rendicion]
	ADD CONSTRAINT [XPKItem_Rendicion] PRIMARY KEY  CLUSTERED ([fact_numero] ASC,[rend_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Items_Factura]
( 
	[item_fact_numero]   integer  NOT NULL ,
	[item_monto]         float  NOT NULL ,
	[item_cantidad]      integer  NOT NULL ,
	[item_detalle]       varchar(50)  NULL 
)
go

CREATE TABLE [404_NOT_FOUND].[Pagos]
( 
	[pago_id]            integer  NOT NULL ,
	[pago_fecha_cobro]   datetime  NOT NULL ,
	[pago_suc_cod_post]  integer  NOT NULL ,
	[pago_total]         float  NOT NULL ,
	[pago_medio]         varchar(20)  NOT NULL ,
	[pago_cliente]       numeric(8)  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Pagos]
	ADD CONSTRAINT [XPKPagos] PRIMARY KEY  CLUSTERED ([pago_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Rendiciones]
( 
	[rend_fecha]         smalldatetime  NOT NULL ,
	[rend_comision_porcent] decimal(5,2)  NOT NULL ,
	[rend_total]         float  NOT NULL ,
	[rend_comision]      float  NOT NULL ,
	[rend_id]            integer  NOT NULL ,
	[rend_cantidad]      integer  NOT NULL ,
	[rend_empresa]       char(13)  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Rendiciones]
	ADD CONSTRAINT [XPKRendiciones] PRIMARY KEY  CLUSTERED ([rend_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Roles]
( 
	[rol_id]			 int identity(1,1),
	[rol_nombre]         varchar(50) unique NOT NULL ,
	[rol_inhabilitado]   bit  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Roles]
	ADD CONSTRAINT [XPKRol] PRIMARY KEY  CLUSTERED ([rol_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Roles_Funcionalidades]
( 
	[rol_id]			 int NOT NULL,
	[func_nombre]        varchar(40)  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Roles_Funcionalidades]
	ADD CONSTRAINT [XPKRoles_Funcionalidades] PRIMARY KEY  CLUSTERED ([rol_id] ASC,[func_nombre] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Roles_Usuarios]
( 
	[user_name]          varchar(20)  NOT NULL ,
	[rol_id]         int  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Roles_Usuarios]
	ADD CONSTRAINT [XPKRoles_Usuarios] PRIMARY KEY  CLUSTERED ([user_name] ASC,[rol_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Rubros]
( 
	[rubr_detalle]       varchar(20)  NOT NULL ,
	[rubr_id]            integer  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Rubros]
	ADD CONSTRAINT [XPKRubros] PRIMARY KEY  CLUSTERED ([rubr_id] ASC)
go

CREATE TABLE [404_NOT_FOUND].[Sucursal_Usuario]
( 
	[user_name]          varchar(20)  NOT NULL ,
	[suc_cod_post]       integer  NOT NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[Sucursal_Usuario]
	ADD CONSTRAINT [XPKSucursal_Usuario] PRIMARY KEY  CLUSTERED ([user_name] ASC,[suc_cod_post] ASC)
go

CREATE TABLE [404_NOT_FOUND].[SUCURSALES]
( 
	[suc_nombre]         varchar(20)  NOT NULL ,
	[suc_cod_post]       integer  NOT NULL ,
	[suc_direccion]      varchar(60)  NOT NULL ,
	[suc_habilitado]     bit  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[SUCURSALES]
	ADD CONSTRAINT [XPKSucursales] PRIMARY KEY  CLUSTERED ([suc_cod_post] ASC)
go

CREATE TABLE [404_NOT_FOUND].[USUARIOS]
( 
	[user_name]          varchar(20)  NOT NULL ,
	[user_pass]          varchar(20)  NOT NULL ,
	[user_inhabilitado]  bit  NULL ,
	[user_intentos_fallidos] integer  NULL 
)
go

ALTER TABLE [404_NOT_FOUND].[USUARIOS]
	ADD CONSTRAINT [XPKUsuario] PRIMARY KEY  CLUSTERED ([user_name] ASC)
go

ALTER TABLE [404_NOT_FOUND].[Direcciones]
	ADD CONSTRAINT [R_42] FOREIGN KEY ([clie_dni]) REFERENCES [404_NOT_FOUND].[CLIENTES]([clie_dni])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[EMPRESAS]
	ADD CONSTRAINT [R_52] FOREIGN KEY ([emp_rubro]) REFERENCES [404_NOT_FOUND].[Rubros]([rubr_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[FACTURAS]
	ADD CONSTRAINT [R_1] FOREIGN KEY ([fact_cliente]) REFERENCES [404_NOT_FOUND].[CLIENTES]([clie_dni])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[FACTURAS]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([fact_emp_cuit]) REFERENCES [404_NOT_FOUND].[EMPRESAS]([emp_cuit])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Item_Pago]
	ADD CONSTRAINT [R_54] FOREIGN KEY ([pago_id]) REFERENCES [404_NOT_FOUND].[Pagos]([pago_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[Item_Pago]
	ADD CONSTRAINT [R_55] FOREIGN KEY ([fact_numero]) REFERENCES [404_NOT_FOUND].[FACTURAS]([fact_numero])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Item_Devolucion]
	ADD CONSTRAINT [R_58] FOREIGN KEY ([dev_id]) REFERENCES [404_NOT_FOUND].[Devoluciones]([dev_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[Item_Devolucion]
	ADD CONSTRAINT [R_59] FOREIGN KEY ([fact_numero]) REFERENCES [404_NOT_FOUND].[FACTURAS]([fact_numero])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Item_Rendicion]
	ADD CONSTRAINT [R_56] FOREIGN KEY ([fact_numero]) REFERENCES [404_NOT_FOUND].[FACTURAS]([fact_numero])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[Item_Rendicion]
	ADD CONSTRAINT [R_57] FOREIGN KEY ([rend_id]) REFERENCES [404_NOT_FOUND].[Rendiciones]([rend_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Items_Factura]
	ADD CONSTRAINT [R_2] FOREIGN KEY ([item_fact_numero]) REFERENCES [404_NOT_FOUND].[FACTURAS]([fact_numero])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Pagos]
	ADD CONSTRAINT [R_38] FOREIGN KEY ([pago_suc_cod_post]) REFERENCES [404_NOT_FOUND].[SUCURSALES]([suc_cod_post])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Rendiciones]
	ADD CONSTRAINT [R_53] FOREIGN KEY ([rend_empresa]) REFERENCES [404_NOT_FOUND].[EMPRESAS]([emp_cuit])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Roles_Funcionalidades]
	ADD CONSTRAINT [R_24] FOREIGN KEY ([rol_id]) REFERENCES [404_NOT_FOUND].[Roles]([rol_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[Roles_Funcionalidades]
	ADD CONSTRAINT [R_25] FOREIGN KEY ([func_nombre]) REFERENCES [404_NOT_FOUND].[Funcionalidades]([func_nombre])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Roles_Usuarios]
	ADD CONSTRAINT [R_21] FOREIGN KEY ([user_name]) REFERENCES [404_NOT_FOUND].[USUARIOS]([user_name])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[Roles_Usuarios]
	ADD CONSTRAINT [R_23] FOREIGN KEY ([rol_id]) REFERENCES [404_NOT_FOUND].[Roles]([rol_id])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [404_NOT_FOUND].[Sucursal_Usuario]
	ADD CONSTRAINT [R_45] FOREIGN KEY ([user_name]) REFERENCES [404_NOT_FOUND].[USUARIOS]([user_name])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [404_NOT_FOUND].[Sucursal_Usuario]
	ADD CONSTRAINT [R_46] FOREIGN KEY ([suc_cod_post]) REFERENCES [404_NOT_FOUND].[SUCURSALES]([suc_cod_post])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

--Triggers
if object_id('[404_NOT_FOUND].hash_password', 'TR') is not null
	drop trigger [404_NOT_FOUND].hash_password
go


create Trigger [404_NOT_FOUND].hash_password on [404_NOT_FOUND].[USUARIOS] instead of insert
as
	declare @pass varchar(20)
	declare @usu varchar(20)
	declare @sucursal varchar(100)
	select @pass = HASHBYTES('SHA2_256', user_pass) from inserted
	select @usu = user_name from inserted
	
	insert into [404_NOT_FOUND].[USUARIOS] (user_name, user_pass,user_inhabilitado,user_intentos_fallidos) values(@usu,@pass,0,0)
	
go

if object_id('[404_NOT_FOUND].verificar_estado_rol_a_asignar', 'TR') is not null
	drop trigger [404_NOT_FOUND].verificar_estado_rol_a_asignar
go


create Trigger [404_NOT_FOUND].verificar_estado_rol_a_asignar on [404_NOT_FOUND].[Roles_Usuarios] after insert, update
as
	declare @rol int
	declare @usuario varchar(20)

	declare @rolElim int

	select @rol = rol_id, @usuario = user_name from inserted
	select @rolElim = rol_id from deleted

	if(@rol in (select rol_id from [404_NOT_FOUND].[Roles] where rol_inhabilitado = 1))
	begin
		if(@rolElim is null) delete from [404_NOT_FOUND].[Roles_Usuarios] where rol_id = @rol and user_name = @usuario
		else update [404_NOT_FOUND].[Roles_Usuarios] set rol_id = @rolElim where user_name = @usuario 
		 
		raiserror('Rol que se quiere asignar al usuario se encuentra inhabilitado',16,0)
	end

go

if object_id('[404_NOT_FOUND].verificar_estado_suc_a_asignar', 'TR') is not null
	drop trigger [404_NOT_FOUND].verificar_estado_suc_a_asignar
go


create Trigger [404_NOT_FOUND].verificar_estado_suc_a_asignar on [404_NOT_FOUND].[Sucursal_Usuario] after insert, update
as
	declare @suc int
	declare @usuario varchar(20)

	declare @sucElim int

	select @suc = suc_cod_post, @usuario = user_name from inserted
	select @sucElim = suc_cod_post from deleted

	if(@suc in (select suc_cod_post from [404_NOT_FOUND].[SUCURSALES] where suc_habilitado = 0))
	begin
		if(@sucElim is null) delete from [404_NOT_FOUND].[Roles_Usuarios] where rol_id = @suc and user_name = @usuario
		else update [404_NOT_FOUND].[Roles_Usuarios] set rol_id = @sucElim where user_name = @usuario 
		raiserror('La sucursal que se quiere asignar al usuario se encuentra inhabilitada',16,0)
	end

go


--Stored Procedures

use GD2C2017
GO

/*
* Stored_Procedures ---> Facturas
*/

if object_id('[404_NOT_FOUND].[sp_buscar_facturas]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_facturas]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_facturas](@factura integer,@cliente numeric(8),@cuit varchar(13),@fecha_alta datetime,@fecha_vencimiento datetime)
 AS
 BEGIN
    declare @query nvarchar(1024)
    set @query = 'SELECT * FROM [404_NOT_FOUND].FACTURAS WHERE 1=1'
  
	if(@factura > 0) SET @query += ' AND fact_numero LIKE '+QUOTENAME(@factura,'''') +' '; 
    if(@cliente > 0) SET @query += ' AND fact_cliente LIKE '+QUOTENAME(@cliente,'''') +' ';
    if(LEN(@cuit) > 0) SET @query += ' AND fact_emp_cuit LIKE '+QUOTENAME(@cuit,'''')+' ';
    if(LEN(@fecha_alta) > 0) SET @query += ' AND CAST(fact_fecha_alta as date) = '+QUOTENAME(@fecha_alta,'''')+' ';
    if(LEN(@fecha_vencimiento) > 0) SET @query += ' AND CAST(fact_fecha_vencimiento as date) = '+QUOTENAME(@fecha_vencimiento,'''')+' ';
          
    print @query
    execute sp_executesql @query
 END
 go

 if object_id('[404_NOT_FOUND].[sp_buscar_items]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_items]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_items](@numero_factura integer)
 AS
 BEGIN
   select * from [404_NOT_FOUND].Items_Factura where @numero_factura = item_fact_numero
 END
 go

if object_id('[404_NOT_FOUND].[sp_agregar_factura]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_factura]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_factura](@numero_factura integer,@cuit varchar(13),@cliente numeric(8),
@fecha_alta smalldatetime, @fecha_vencimiento smalldatetime,@total float,@habilitada int)
 AS
 BEGIN
   INSERT INTO [404_NOT_FOUND].FACTURAS(fact_numero,fact_emp_cuit,fact_cliente,
   fact_fecha_alta,fact_fecha_vencimiento,fact_total,f.fact_habilitada)
   VALUES (@numero_factura,@cuit,@cliente,@fecha_alta,@fecha_vencimiento,@total,@habilitada)
 END
 go

 if object_id('[404_NOT_FOUND].[sp_agregar_item]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_item]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_item](@numero_factura integer,@detalle varchar(50),@cantidad integer,
@monto float)
 AS
 BEGIN
   INSERT INTO [404_NOT_FOUND].Items_Factura(item_fact_numero,item_detalle,
   item_cantidad,item_monto)
   VALUES (@numero_factura,@detalle,@cantidad,@monto)
 END
 go

if object_id('[404_NOT_FOUND].[sp_modificar_factura]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_modificar_factura]
go

create PROCEDURE [404_NOT_FOUND].[sp_modificar_factura](@numero_factura integer,@cuit varchar(13),@cliente numeric(8),
@fecha_alta smalldatetime, @fecha_vencimiento smalldatetime,@total float,@habilitada int)
 AS
 BEGIN
 
		 UPDATE [404_NOT_FOUND].FACTURAS 
		 SET fact_numero = @numero_factura,fact_emp_cuit = @cuit,fact_cliente = @cliente,
		 fact_fecha_alta =@fecha_alta, fact_fecha_vencimiento = @fecha_vencimiento,
		 fact_total =  @total, fact_habilitada = @habilitada
		 WHERE fact_numero = @numero_factura

 END
 go

if object_id('[404_NOT_FOUND].[sp_eliminar_items_factura]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_eliminar_items_factura]
go

create PROCEDURE [404_NOT_FOUND].[sp_eliminar_items_factura](@numero_factura integer)
 AS
 BEGIN
 
		 DELETE FROM [404_NOT_FOUND].Items_Factura 
		 WHERE item_fact_numero = @numero_factura

 END
 go

 if object_id('[404_NOT_FOUND].[sp_inhabilitar_factura]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_inhabilitar_factura]
go

create PROCEDURE [404_NOT_FOUND].[sp_inhabilitar_factura](@numero_factura integer)
 AS
 BEGIN

 UPDATE [404_NOT_FOUND].FACTURAS SET fact_habilitada = 0
 where fact_numero = @numero_factura

 END
 go


  /*
* Stored_Procedures ---> Pagos
*/
 if object_id('[404_NOT_FOUND].[sp_buscar_facturas_pagas_actuales]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_facturas_pagas_actuales]
go

 create PROCEDURE [404_NOT_FOUND].[sp_buscar_facturas_pagas_actuales](@factura integer,@cliente numeric(8),@cuit varchar(13))
 AS
 BEGIN
    declare @query nvarchar(1024)
    set @query = 'SELECT f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
	 FROM [404_NOT_FOUND].Facturas f JOIN
	(([404_NOT_FOUND].Pagos p JOIN [404_NOT_FOUND].Item_Pago ip on p.pago_id = ip.pago_id) LEFT JOIN 
	([404_NOT_FOUND].Devoluciones d JOIN [404_NOT_FOUND].Item_Devolucion id on d.dev_id = id.dev_id )
	on ip.fact_numero = id.fact_numero) 
	on f.fact_numero = ip.fact_numero
	group by f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
	having (max(d.dev_fecha) is null OR (max(d.dev_fecha)<max(p.pago_fecha_cobro)))'
  
	if(@factura > 0) SET @query += ' AND fact_numero LIKE '+QUOTENAME(@factura,'''') +' '; 
    if(@cliente > 0) SET @query += ' AND fact_cliente LIKE '+QUOTENAME(@cliente,'''') +' ';
    if(LEN(@cuit) > 0) SET @query += ' AND fact_emp_cuit LIKE '+QUOTENAME(@cuit,'''')+' ';
          
    print @query
    execute sp_executesql @query
 END
 go

if object_id('[404_NOT_FOUND].[sp_buscar_facturas_pendientes_de_pago]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_facturas_pendientes_de_pago]
go

 create PROCEDURE [404_NOT_FOUND].[sp_buscar_facturas_pendientes_de_pago](@factura integer,@cliente numeric(8),@cuit varchar(13))
 AS
 BEGIN
    declare @query nvarchar(1024)
    set @query = 'SELECT f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
	 FROM [404_NOT_FOUND].Facturas f LEFT JOIN
	(([404_NOT_FOUND].Pagos p JOIN [404_NOT_FOUND].Item_Pago ip on p.pago_id = ip.pago_id) LEFT JOIN 
	([404_NOT_FOUND].Devoluciones d JOIN [404_NOT_FOUND].Item_Devolucion id on d.dev_id = id.dev_id )
	on ip.fact_numero = id.fact_numero) 
	on f.fact_numero = ip.fact_numero
	group by f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
	having (max(p.pago_fecha_cobro) is null OR (max(d.dev_fecha)>max(p.pago_fecha_cobro)))'
  
	if(@factura > 0) SET @query += ' AND fact_numero LIKE '+QUOTENAME(@factura,'''') +' '; 
    if(@cliente > 0) SET @query += ' AND fact_cliente LIKE '+QUOTENAME(@cliente,'''') +' ';
    if(LEN(@cuit) > 0) SET @query += ' AND fact_emp_cuit LIKE '+QUOTENAME(@cuit,'''')+' ';
          
    print @query
    execute sp_executesql @query
 END
 go

 if object_id('[404_NOT_FOUND].[sp_agregar_pago]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_pago]
go
create PROCEDURE [404_NOT_FOUND].[sp_agregar_pago](@cliente numeric(8), @sucursal int,@medio_pago varchar(20),
													@total float,@fecha_cobro smalldatetime, @pago_id int out)
AS
	set @pago_id = 0
	select top 1 @pago_id = pago_id + 1 from [404_NOT_FOUND].[Pagos] order by pago_id desc
	insert into [404_NOT_FOUND].[Pagos](pago_id,pago_fecha_cobro,pago_suc_cod_post,pago_total,pago_cliente,pago_medio)
	values(@pago_id,@fecha_cobro,@sucursal,@total,@cliente,@medio_pago)
go



 if object_id('[404_NOT_FOUND].[sp_agregar_item_pago]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_item_pago]
go
create PROCEDURE [404_NOT_FOUND].[sp_agregar_item_pago](@factura int,@pago_id int)
AS
	insert into [404_NOT_FOUND].[Item_Pago](fact_numero,pago_id) values(@factura,@pago_id)
go


/*
* Stored-Procedures--->Devoluciones
*/

 if object_id('[404_NOT_FOUND].[sp_agregar_devolucion]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_devolucion]
go
create PROCEDURE [404_NOT_FOUND].[sp_agregar_devolucion](@motivo varchar(50),@fecha_devolucion smalldatetime, @devolucion_id int out)
AS
	set @devolucion_id = 0
	select top 1 @devolucion_id = dev_id + 1 from [404_NOT_FOUND].[Devoluciones] order by dev_id desc

	insert into [404_NOT_FOUND].[Devoluciones](dev_motivo,dev_fecha,dev_id)
	values(@motivo,@fecha_devolucion,@devolucion_id)
go



 if object_id('[404_NOT_FOUND].[sp_agregar_item_devolucion]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_item_devolucion]
go
create PROCEDURE [404_NOT_FOUND].[sp_agregar_item_devolucion](@factura int,@devolucion_id int)
AS
	insert into [404_NOT_FOUND].[Item_Devolucion](fact_numero,dev_id) values(@factura,@devolucion_id)
go

 /*
*Stored-Procedures --->Rendiciones
*/

 if object_id('[404_NOT_FOUND].[sp_buscar_facturas_pendientes_de_rendicion_de_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_facturas_pendientes_de_rendicion_de_empresa]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_facturas_pendientes_de_rendicion_de_empresa](@cuit varchar(13))
 AS
 BEGIN

	SELECT f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
	 FROM [404_NOT_FOUND].Facturas f JOIN
	(([404_NOT_FOUND].Pagos p JOIN [404_NOT_FOUND].Item_Pago ip on p.pago_id = ip.pago_id) LEFT JOIN 
	([404_NOT_FOUND].Devoluciones d JOIN [404_NOT_FOUND].Item_Devolucion id on d.dev_id = id.dev_id )
	on ip.fact_numero = id.fact_numero) 
	on f.fact_numero = ip.fact_numero
	where f.fact_numero not in (SELECT fact_numero from [404_NOT_FOUND].Item_Rendicion)
	group by f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
	having (max(d.dev_fecha) is null OR (max(d.dev_fecha)<max(p.pago_fecha_cobro)))
	and fact_emp_cuit like @cuit
  
 END
 go


  if object_id('[404_NOT_FOUND].[sp_buscar_facturas_rendidas_actuales]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_facturas_rendidas_actuales]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_facturas_rendidas_actuales](@cuit varchar(13))
 AS
 BEGIN
	
	 declare @query nvarchar(1024)
    set @query = 'SELECT f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_total,f.fact_fecha_vencimiento,f.fact_fecha_alta,f.fact_habilitada
					from [404_NOT_FOUND].Item_Rendicion i JOIN [404_NOT_FOUND].FACTURAS f on i.fact_numero = f.fact_numero'

    if(LEN(@cuit) > 0) SET @query += 'WHERE f.fact_emp_cuit LIKE '+QUOTENAME(@cuit,'''')+' ';
          
    print @query
    execute sp_executesql @query
 END
 go

 if object_id('[404_NOT_FOUND].[sp_buscar_facturas_a_rendir_de_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_facturas_a_rendir_de_empresa]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_facturas_a_rendir_de_empresa](@cuit varchar(13),@fecha datetime)
 AS

	print @fecha
	if (1 = (select emp_habilitado from [404_NOT_FOUND].[EMPRESAS] where @cuit = emp_cuit) and
			 month(@fecha) not in (select month(rend_fecha) from [404_NOT_FOUND].[Rendiciones] where rend_empresa = @cuit))
	begin
	select f.fact_numero,f.fact_cliente,f.fact_emp_cuit,f.fact_fecha_alta,f.fact_fecha_vencimiento,f.fact_total,f.fact_habilitada
	from [404_NOT_FOUND].[FACTURAS] f join [404_NOT_FOUND].[Item_Pago] ip on (f.fact_numero = ip.fact_numero)
									  join [404_NOT_FOUND].[Pagos] p on (ip.pago_id = p.pago_id)
									  left join [404_NOT_FOUND].[Item_Devolucion] id on (id.fact_numero = f.fact_numero)
									  left join [404_NOT_FOUND].[Devoluciones] d on (id.dev_id = d.dev_id)
	where f.fact_emp_cuit = @cuit
		and f.fact_numero not in (select fact_numero from [404_NOT_FOUND].[Item_Rendicion])
		and (p.pago_fecha_cobro >= d.dev_fecha or d.dev_fecha is null) and year(@fecha) >= year(p.pago_fecha_cobro)
																	   and month(@fecha) >= month(p.pago_fecha_cobro)
																	   and day(@fecha) >= day(p.pago_fecha_cobro)
	order by 1 desc
	end
 go


if object_id('[404_NOT_FOUND].[sp_rendir_facturas]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_rendir_facturas]
go
create PROCEDURE [404_NOT_FOUND].[sp_rendir_facturas](@fecha smalldatetime, @porcentajeComision decimal(5,2),@total float,@total_comision float,@cantidad int, @empresa char(13), @id_rend int out)
AS
	set @id_rend = 0
	select top 1 @id_rend = rend_id + 1 from [404_NOT_FOUND].[Rendiciones] order by rend_id desc
	insert into [404_NOT_FOUND].[Rendiciones] values(@fecha,@porcentajeComision,@total,@total_comision,@id_rend,@cantidad,@empresa)
go

if object_id('[404_NOT_FOUND].[sp_insert_items_rendicion]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_insert_items_rendicion]
go
create PROCEDURE [404_NOT_FOUND].[sp_insert_items_rendicion](@fact_id int, @rend_id int)
AS

	insert into [404_NOT_FOUND].[Item_Rendicion] values(@fact_id,@rend_id)

go

 /*
* Stored_Procedures ---> Usuarios
*/


if object_id('[404_NOT_FOUND].[sp_obtener_roles]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_obtener_roles]
go

create procedure [404_NOT_FOUND].[sp_obtener_roles](@user varchar(20))
as
	select * from [404_NOT_FOUND].Roles_Usuarios RU join [404_NOT_FOUND].[Roles] R on (RU.rol_id = R.rol_id)
	where user_name = @user and R.rol_inhabilitado = 0
go

if object_id('[404_NOT_FOUND].[sp_obtener_sucursales]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_obtener_sucursales]
go

create procedure [404_NOT_FOUND].[sp_obtener_sucursales](@user varchar(20))
as
	select * 
	from [404_NOT_FOUND].Sucursal_Usuario SU join [404_NOT_FOUND].[SUCURSALES] S on (S.suc_cod_post = SU.suc_cod_post)
	where user_name = @user
go

if object_id('[404_NOT_FOUND].[sp_validar_sucursal]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_validar_sucursal]
go

create procedure [404_NOT_FOUND].[sp_validar_sucursal](@suc int, @salida int out)
as
	if(@suc not in (select suc_cod_post from [404_NOT_FOUND].[SUCURSALES] where suc_habilitado = 1)) set @salida = 0
	else set @salida = 1
go


if object_id('[404_NOT_FOUND].[sp_autenticar_usuario]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_autenticar_usuario]
go

create procedure [404_NOT_FOUND].[sp_autenticar_usuario](@user varchar(20),@password varchar(20), @salida int output)
as
	declare @pass varchar(20)
	set @pass = HASHBYTES('SHA2_256', @password)
	if exists (select user_name from [404_NOT_FOUND].[USUARIOS] where @user = user_name and user_inhabilitado = 1) set @salida = -1
	else
	begin
		if exists (select user_name from [404_NOT_FOUND].[USUARIOS] where @user = user_name and @pass = user_pass and user_inhabilitado = 0) set @salida = 1
		else
		begin
			set @salida = 0

			if exists (select user_name from [404_NOT_FOUND].[USUARIOS] where @user = user_name and user_inhabilitado = 0)
			begin
				update [404_NOT_FOUND].[USUARIOS] set user_intentos_fallidos = user_intentos_fallidos + 1 where @user = user_name
				if ((select user_intentos_fallidos from [404_NOT_FOUND].[USUARIOS] where @user = user_name and user_inhabilitado = 0) = 3)
				begin
					set @salida = -1
					update [404_NOT_FOUND].[USUARIOS] set user_inhabilitado = 1 where @user = user_name
				end
			end
		end
	end
go
--Logins a 0---> update [404_NOT_FOUND].[USUARIOS] set user_inhabilitado = 0, user_intentos_fallidos = 0

if object_id('[404_NOT_FOUND].[sp_buscar_fact_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_fact_empresa]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_fact_empresa](@fecha_desde datetime,@fecha_hasta datetime, @cant_elementos int)
as

	if (@cant_elementos = 0) set @cant_elementos = 5
	
	select top (@cant_elementos) emp_nombre, count(*) total,(select count(*) 
																from [404_NOT_FOUND].[Rendiciones] R join [404_NOT_FOUND].[Item_Rendicion] I on (R.rend_id = I.rend_id) 
																where rend_fecha >= @fecha_desde and rend_fecha <= @fecha_hasta and I.fact_numero = fact_numero) rendidos,
															(select count(*)
																from [404_NOT_FOUND].[Rendiciones] left join [404_NOT_FOUND].[EMPRESAS] on (rend_empresa = emp_cuit)
																where rend_fecha >= @fecha_desde and rend_fecha <= @fecha_hasta) * 100 / count(*) porcentaje
	from [404_NOT_FOUND].[FACTURAS] left join [404_NOT_FOUND].[EMPRESAS] on (fact_emp_cuit = emp_cuit)
	where fact_fecha_alta >= @fecha_desde and fact_fecha_alta <= @fecha_hasta
	group by emp_nombre
	order by 4 desc
go


if object_id('[404_NOT_FOUND].[sp_buscar_rend_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_rend_empresa]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_rend_empresa](@fecha_desde datetime,@fecha_hasta datetime, @cant_elementos int)
as

	if (@cant_elementos = 0) set @cant_elementos = 5
	
	select top (@cant_elementos) emp_nombre, count(*) cantidad,sum(rend_total) monto/*(select sum(rend_total) 
																from [404_NOT_FOUND].[Rendiciones] R join [404_NOT_FOUND].[Item_Rendicion] I on (R.rend_id = I.rend_id)
																where rend_fecha >= @fecha_desde and rend_fecha <= @fecha_hasta) monto*/
	from [404_NOT_FOUND].[Rendiciones] left join [404_NOT_FOUND].[EMPRESAS] on (rend_empresa = emp_cuit)
	where rend_fecha >= @fecha_desde and rend_fecha <= @fecha_hasta
	group by emp_nombre
	order by 3 desc
go

if object_id('[404_NOT_FOUND].[sp_buscar_clie_pagos_totales]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_clie_pagos_totales]
go

create procedure [404_NOT_FOUND].[sp_buscar_clie_pagos_totales](@fecha_desde datetime,@fecha_hasta datetime, @cant_elementos int)
as

	if (@cant_elementos = 0) set @cant_elementos = 5

	select top (@cant_elementos) clie_dni,clie_apellido,clie_nombre,clie_mail, count(distinct I.pago_id) cant_pagos, sum(P.pago_total) total
	from [404_NOT_FOUND].[Pagos] P join [404_NOT_FOUND].[Item_Pago] I on (I.pago_id = P.pago_id)
									join [404_NOT_FOUND].[FACTURAS] F on (F.fact_numero = I.fact_numero)
									join [404_NOT_FOUND].[CLIENTES]  on (clie_dni = F.fact_cliente)
	where pago_fecha_cobro >= @fecha_desde and pago_fecha_cobro <= @fecha_hasta
	group by clie_dni,clie_apellido,clie_nombre,clie_mail
	order by 5 desc
go

if object_id('[404_NOT_FOUND].[sp_buscar_clie_pagos_porcentaje]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_clie_pagos_porcentaje]
go

create procedure [404_NOT_FOUND].[sp_buscar_clie_pagos_porcentaje](@fecha_desde datetime,@fecha_hasta datetime, @cant_elementos int)
as
	if (@cant_elementos = 0) set @cant_elementos = 5

	select top (@cant_elementos) clie_dni,clie_apellido,clie_nombre,clie_mail, count(F.fact_numero) cant_fact, (select count (*)
																							from [404_NOT_FOUND].[FACTURAS] F1 join [404_NOT_FOUND].[Item_Pago] I on (F1.fact_numero = I.fact_numero)
																							where clie_dni = F1.fact_cliente and F1.fact_fecha_alta >= @fecha_desde and F1.fact_fecha_alta <= @fecha_hasta) cant_pagos,
																						(select count (*)
																							from [404_NOT_FOUND].[FACTURAS] F1 join [404_NOT_FOUND].[Item_Pago] I on (F1.fact_numero = I.fact_numero)
																							where clie_dni = F1.fact_cliente and F1.fact_fecha_alta >= @fecha_desde and F1.fact_fecha_alta <= @fecha_hasta) * 100 / count(F.fact_numero) porcentaje									
	from [404_NOT_FOUND].[CLIENTES] join [404_NOT_FOUND].[FACTURAS] F on (clie_dni = F.fact_cliente) 
	where F.fact_fecha_alta >= @fecha_desde and F.fact_fecha_alta <= @fecha_hasta
	group by clie_dni,clie_apellido,clie_nombre,clie_mail
	order by 7 desc
go

/*
*Stored Procedures ---> Empresas
*/

if object_id('[404_NOT_FOUND].[sp_buscar_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_empresa]
go

create procedure [404_NOT_FOUND].[sp_buscar_empresa](@cuit varchar(13))
as
	select * from [404_NOT_FOUND].EMPRESAS where emp_cuit = @cuit
go

if object_id('[404_NOT_FOUND].[sp_buscar_empresas_habilitadas]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_empresas_habilitadas]
go

create procedure [404_NOT_FOUND].[sp_buscar_empresas_habilitadas]
as
	select * from [404_NOT_FOUND].EMPRESAS where emp_habilitado = 1
go


if object_id('[404_NOT_FOUND].[sp_buscar_fact_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_fact_empresa]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_fact_empresa](@fecha_desde datetime,@fecha_hasta datetime, @cant_elementos int)
as

	if (@cant_elementos = 0) set @cant_elementos = 5
	
	select top (@cant_elementos) emp_nombre, count(*) total, (select count(*) 
															from [404_NOT_FOUND].[Rendiciones] R join [404_NOT_FOUND].[Item_Rendicion] IR on (R.rend_id = IR.rend_id)
																								 join [404_NOT_FOUND].[FACTURAS] F1 on (IR.fact_numero = F1.fact_numero)
															where R.rend_empresa = E.emp_cuit and fact_fecha_alta >= @fecha_desde and fact_fecha_alta <= @fecha_hasta) rendidos,
															(select count(*)
															from [404_NOT_FOUND].[Rendiciones] R join [404_NOT_FOUND].[Item_Rendicion] IR on (R.rend_id = IR.rend_id)
																								 join [404_NOT_FOUND].[FACTURAS] F1 on (IR.fact_numero = F1.fact_numero)
															where R.rend_empresa = E.emp_cuit and fact_fecha_alta >= @fecha_desde and fact_fecha_alta <= @fecha_hasta) * 100 / count(*) porcentaje
	from [404_NOT_FOUND].[FACTURAS] left join [404_NOT_FOUND].[EMPRESAS] E on (fact_emp_cuit = E.emp_cuit)
	where fact_fecha_alta >= @fecha_desde and fact_fecha_alta <= @fecha_hasta
	group by E.emp_nombre,E.emp_cuit
	order by 4 desc
go




if object_id('[404_NOT_FOUND].[sp_buscar_rubros]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_rubros]
go

create procedure [404_NOT_FOUND].[sp_buscar_rubros]
as
	select * from [404_NOT_FOUND].Rubros
go

if object_id('[404_NOT_FOUND].[sp_eliminar_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_eliminar_empresa]
go

create procedure [404_NOT_FOUND].[sp_eliminar_empresa] (@cuit varchar(13))
as
	UPDATE [404_NOT_FOUND].EMPRESAS
	SET emp_habilitado = 0
	where emp_cuit = @cuit
go

if object_id('[404_NOT_FOUND].[sp_modificar_empresa]', 'P') is not null
 	drop procedure [404_NOT_FOUND].[sp_modificar_empresa]
 go
 
 create PROCEDURE [404_NOT_FOUND].[sp_modificar_empresa](@cuit varchar(13),@nombre varchar(50),@rubro integer,
 @direccion varchar(60),@habilitado bit)
  AS
  BEGIN
  
 		 UPDATE [404_NOT_FOUND].EMPRESAS 
 		 SET emp_cuit = @cuit,emp_nombre = @nombre,emp_direccion = @direccion,
 		 emp_rubro =@rubro, emp_habilitado = @habilitado
 		 WHERE emp_cuit = @cuit
 
  END
  go



if object_id('[404_NOT_FOUND].[sp_buscar_empresas]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_empresas]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_empresas](@cuit varchar(13),@nombre varchar(50),@rubro int)
 AS
 BEGIN
    declare @query nvarchar(512)
    set @query = 'SELECT * FROM [404_NOT_FOUND].EMPRESAS WHERE 1=1'
  
    if(LEN(@cuit) > 0) SET @query += ' AND emp_cuit LIKE '+QUOTENAME(@cuit,'''') +' ';
    if(LEN(@nombre) > 0) SET @query += ' AND emp_nombre LIKE '+QUOTENAME(@nombre,'''')+' ';
    if(@rubro > 0) SET @query += ' AND emp_rubro LIKE '+QUOTENAME(@rubro,'''')+' ';
       
    print @query
    execute sp_executesql @query
 END
 go

  if object_id('[404_NOT_FOUND].[sp_agregar_empresa]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_empresa]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_empresa](@cuit varchar(13),@nombre varchar(50),@rubro integer,
@direccion varchar(60),@habilitado bit)
 AS
 BEGIN
   INSERT INTO [404_NOT_FOUND].EMPRESAS(emp_cuit,emp_nombre,emp_rubro,emp_direccion,emp_habilitado)
   VALUES (@cuit,@nombre,@rubro,@direccion,@habilitado)
 END
 go


/*
*Stored Procedures ---> Clientes
*/

if object_id('[404_NOT_FOUND].[sp_buscar_clientes]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_clientes]
go


create PROCEDURE [404_NOT_FOUND].[sp_buscar_clientes](@dni numeric(8),@nombre varchar(30),@apellido varchar(30))
 AS
 BEGIN
    declare @query nvarchar(512)
    set @query = 'SELECT * FROM [404_NOT_FOUND].CLIENTES WHERE 1=1'
  
    if(LEN(@dni) > 0) SET @query += ' AND clie_dni= '+QUOTENAME(@dni,'''') +' ';
    if(LEN(@nombre) > 0) SET @query += ' AND clie_nombre LIKE '+QUOTENAME(@nombre,'''')+' ';
    if(LEN(@apellido) > 0) SET @query += ' AND clie_apellido LIKE '+QUOTENAME(@apellido,'''')+' ';
       
    print @query
    execute sp_executesql @query
 END
 go


if object_id('[404_NOT_FOUND].[sp_buscar_cliente]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_cliente]
go

create procedure [404_NOT_FOUND].[sp_buscar_cliente](@dni numeric(8))
as
	select * from [404_NOT_FOUND].CLIENTES where clie_dni = @dni
go

if object_id('[404_NOT_FOUND].[sp_buscar_direccion]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_direccion]
go

create procedure [404_NOT_FOUND].[sp_buscar_direccion](@dni numeric(8))
as
	select * from [404_NOT_FOUND].Direcciones where clie_dni = @dni
go

if object_id('[404_NOT_FOUND].[sp_buscar_cliente_mail]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_cliente_mail]
go

create procedure [404_NOT_FOUND].[sp_buscar_cliente_mail](@mail varchar(50))
as
	select * from [404_NOT_FOUND].CLIENTES where clie_mail = @mail
go

if object_id('[404_NOT_FOUND].[sp_agregar_cliente]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_cliente]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_cliente](@dni numeric(8), @apellido varchar(30), @nombre varchar(30), @fecha_nac smalldatetime, @mail varchar(50), @habilitado bit, @telefono varchar(20), @localidad varchar(20), @cp numeric(4),@calle varchar(60), @piso smallint, @dpto char(1))
 AS
 BEGIN
   INSERT INTO [404_NOT_FOUND].CLIENTES(clie_dni,clie_apellido,clie_nombre,clie_fecha_nac,clie_mail,clie_habilitado,clie_telefono)
   VALUES (@dni, @apellido, @nombre, @fecha_nac, @mail, @habilitado, @telefono)
   INSERT INTO [404_NOT_FOUND].Direcciones(clie_dni,dir_cod_postal,dir_localidad,dir_piso,dir_depto,dir_calle)
   VALUES (@dni, @cp, @localidad, @piso, @dpto, @calle)
 END
 go

if object_id('[404_NOT_FOUND].[sp_modificar_cliente]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_modificar_cliente]
go

create PROCEDURE [404_NOT_FOUND].[sp_modificar_cliente](@dni numeric(8), @apellido varchar(30), @nombre varchar(30), @fecha_nac smalldatetime, @mail varchar(50), @habilitado bit,  @telefono varchar(20), @localidad varchar(20), @cp numeric(4),@calle varchar(60), @piso smallint=null, @dpto char=null)
 AS
 BEGIN
 
		 UPDATE [404_NOT_FOUND].CLIENTES 
		 SET clie_dni = @dni, clie_apellido = @apellido,clie_nombre = @nombre,
		 clie_fecha_nac =@fecha_nac, clie_mail = @mail,
		 clie_telefono =  @telefono, clie_habilitado=@habilitado
		 WHERE clie_dni = @dni

		 UPDATE [404_NOT_FOUND].Direcciones 
		 SET clie_dni = @dni ,dir_cod_postal = @cp,dir_localidad = @localidad,
		 dir_piso =@piso, dir_depto = @dpto,
		 dir_calle =  @calle
		 WHERE clie_dni = @dni

 END
 go

 if object_id('[404_NOT_FOUND].[sp_eliminar_cliente]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_eliminar_cliente]
go

create PROCEDURE [404_NOT_FOUND].[sp_eliminar_cliente] (@dni numeric(8))
 as
  begin
	UPDATE [404_NOT_FOUND].CLIENTES
	SET clie_habilitado = 0
	where clie_dni = @dni
  end
 go

if object_id('[404_NOT_FOUND].[sp_habilitar_cliente]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_habilitar_cliente]
go

create PROCEDURE [404_NOT_FOUND].[sp_habilitar_cliente] (@dni numeric(8))
as
 begin
	UPDATE [404_NOT_FOUND].CLIENTES
	SET clie_habilitado = 1
	where clie_dni = @dni
  end
 go

/*
*Stored Procedures ---> Sucursales
*/

if object_id('[404_NOT_FOUND].[sp_buscar_sucursal]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_sucursal]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_sucursal](@codigo_postal integer)
	AS
		BEGIN
			select * from [404_NOT_FOUND].SUCURSALES where suc_cod_post = @codigo_postal
		END
	go

if object_id('[404_NOT_FOUND].[sp_agregar_sucursal]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_sucursal]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_sucursal](@codigo_postal integer,@nombre varchar(20),@direccion varchar(60),
@habilitado bit)
	AS
		BEGIN
			INSERT INTO [404_NOT_FOUND].SUCURSALES(suc_cod_post,suc_nombre,suc_direccion,suc_habilitado)
			VALUES (@codigo_postal, @nombre, @direccion, @habilitado)
		END
	go

if object_id('[404_NOT_FOUND].[sp_buscar_sucursales]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_sucursales]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_sucursales](@codigo_postal int,@nombre varchar(20),@direccion varchar(60))
 AS
  BEGIN
    declare @query nvarchar(512)
    set @query = 'SELECT * FROM [404_NOT_FOUND].SUCURSALES WHERE 1=1'
  
    if((@codigo_postal) > 0) SET @query += ' AND suc_cod_post LIKE '+QUOTENAME(@codigo_postal,'''') +' ';
    if(LEN(@nombre) > 0) SET @query += ' AND suc_nombre LIKE '+QUOTENAME(@nombre,'''')+' ';
    if(LEN(@direccion) > 0) SET @query += ' AND suc_direccion LIKE '+QUOTENAME(@direccion,'''')+' ';
       
    print @query
    execute sp_executesql @query
  END
 go

 if object_id('[404_NOT_FOUND].[sp_eliminar_sucursal]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_eliminar_sucursal]
go

create PROCEDURE [404_NOT_FOUND].[sp_eliminar_sucursal] (@codigo_postal int)
 as
  begin
	UPDATE [404_NOT_FOUND].SUCURSALES
	SET suc_habilitado = 0
	where suc_cod_post = @codigo_postal
  end
 go

if object_id('[404_NOT_FOUND].[sp_habilitar_sucursal]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_habilitar_sucursal]
go

create PROCEDURE [404_NOT_FOUND].[sp_habilitar_sucursal] (@codigo_postal int)
as
 begin
	UPDATE [404_NOT_FOUND].SUCURSALES
	SET suc_habilitado = 1
	where suc_cod_post = @codigo_postal
  end
 go

if object_id('[404_NOT_FOUND].[sp_modificar_sucursal]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_modificar_sucursal]
go

create PROCEDURE [404_NOT_FOUND].[sp_modificar_sucursal](@codigo_postal int,@nombre varchar(20),@direccion varchar(60),@habilitado bit)
 AS
  BEGIN
		 UPDATE [404_NOT_FOUND].SUCURSALES 
		 SET suc_nombre = @nombre,suc_direccion = @direccion, suc_habilitado = @habilitado
		 WHERE suc_cod_post = @codigo_postal
  END
 go

 /*
*Stored Procedures ---> Funcionalidades
*/

if object_id('[404_NOT_FOUND].[sp_buscar_funcionalidades]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_buscar_funcionalidades]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_funcionalidades]
 AS
  BEGIN
		 SELECT * FROM [404_NOT_FOUND].Funcionalidades
  END
 go

 /*
*Stored Procedures ---> Roles
*/

if object_id('[404_NOT_FOUND].[sp_buscar_rol]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_rol]
go

create PROCEDURE [404_NOT_FOUND].[sp_buscar_rol](@nombre varchar(50))
	AS
		BEGIN
			select * from [404_NOT_FOUND].Roles where (rol_nombre = @nombre OR @nombre IS NULL)
		END
	go

if object_id('[404_NOT_FOUND].[sp_agregar_rol]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_rol]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_rol](@nombre varchar(20), @inhabilitado bit)

	AS
		BEGIN
			INSERT INTO [404_NOT_FOUND].Roles(rol_nombre,rol_inhabilitado)
			VALUES (@nombre, @inhabilitado)
		END
	go

if object_id('[404_NOT_FOUND].[sp_agregar_rol_funcionalidad]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_agregar_rol_funcionalidad]
go

create PROCEDURE [404_NOT_FOUND].[sp_agregar_rol_funcionalidad](@rol varchar(50), @funcionalidad varchar(40))
	AS
		BEGIN
			DECLARE @vc_IdRol int
			SELECT @vc_IdRol = rol_id FROM [404_NOT_FOUND].Roles where rol_nombre = @rol
			INSERT INTO [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre)
			VALUES (@vc_IdRol, @funcionalidad)
		END
	go


if object_id('[404_NOT_FOUND].[sp_eliminar_rol]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_eliminar_rol]
go

create PROCEDURE [404_NOT_FOUND].[sp_eliminar_rol] (@nombre varchar(50))
 as
  begin

	DECLARE @rol_id int
	SELECT @rol_id = rol_id FROM [404_NOT_FOUND].Roles WHERE rol_nombre = @nombre

	UPDATE [404_NOT_FOUND].Roles
	SET rol_inhabilitado = 1
	where rol_nombre = @nombre

	DELETE FROM [404_NOT_FOUND].Roles_Usuarios WHERE rol_id = @rol_id 
  end
 go


if object_id('[404_NOT_FOUND].[sp_modificar_rol]', 'P') is not null
	drop PROCEDURE [404_NOT_FOUND].[sp_modificar_rol]
go

create PROCEDURE [404_NOT_FOUND].[sp_modificar_rol] (@id int, @nombre varchar(50), @inhabilitado bit)
 as
  begin
	
	DELETE FROM [404_NOT_FOUND].Roles_Funcionalidades WHERE rol_id = @id
	UPDATE [404_NOT_FOUND].Roles SET rol_nombre = @nombre, rol_inhabilitado = @inhabilitado WHERE rol_id = @id
	
  end
 go

if object_id('[404_NOT_FOUND].[sp_buscar_rol_funcionalidades]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_buscar_rol_funcionalidades]
go

create procedure [404_NOT_FOUND].[sp_buscar_rol_funcionalidades](@rol_id integer)
as
	select * 
	from [404_NOT_FOUND].Roles r JOIN [404_NOT_FOUND].Roles_Funcionalidades rf
	ON r.rol_id = rf.rol_id
	where r.rol_id = @rol_id AND r.rol_inhabilitado = '0'
go

if object_id('[404_NOT_FOUND].[sp_tiene_funcionalidad]', 'P') is not null
	drop procedure [404_NOT_FOUND].[sp_tiene_funcionalidad]
go

create procedure [404_NOT_FOUND].[sp_tiene_funcionalidad](@rol_id integer,@funcionalidad varchar(50))
as

	select *
	from [404_NOT_FOUND].Roles_Funcionalidades
	where rol_id = @rol_id and func_nombre = @funcionalidad
go

--Migración

if object_id('[404_NOT_FOUND].migracion', 'P') is not null
	drop procedure [404_NOT_FOUND].migracion
go


create PROCEDURE [404_NOT_FOUND].migracion
as

	declare @fact_num integer, @fact_fecha smalldatetime, @fact_total float, @fact_fecha_vencimiento smalldatetime
	declare @pago_numero integer, @pago_fecha datetime, @pago_total float,@pago_medio varchar(20)
	declare @suc_nombre varchar(20), @suc_direccion varchar(50), @suc_cod_post integer
	declare @rend_num integer, @rend_fecha smalldatetime, @rend_comision float
	declare @emp_cuit char(13)

	declare cPagos CURSOR for select distinct [Nro_Factura],[Pago_nro],[Pago_Fecha],[Total],[FormaPagoDescripcion],Sucursal_Codigo_Postal from gd_esquema.Maestra where Pago_nro IS NOT NULL
	declare cRendicion CURSOR for select distinct [Nro_Factura],[Rendicion_Nro],[Rendicion_Fecha],[Factura_Total],[ItemRendicion_Importe],[Empresa_Cuit] from gd_esquema.Maestra  where [Rendicion_Nro] IS NOT NULL

	 --Migración Clientes, Direcciones, Sucursales, Rubros,Empresas, Facturas
	insert into [404_NOT_FOUND].CLIENTES (clie_dni,clie_apellido,clie_nombre,clie_fecha_nac,clie_mail,clie_habilitado,clie_telefono) select distinct [Cliente-Dni],[Cliente-Apellido],[Cliente-Nombre],[Cliente-Fecha_Nac],Cliente_Mail,1,NULL from gd_esquema.Maestra
	insert into [404_NOT_FOUND].Direcciones (clie_dni,dir_cod_postal,dir_localidad,dir_calle) select distinct [Cliente-Dni], [Cliente_Codigo_Postal],'No especificado',[Cliente_Direccion] from gd_esquema.Maestra
	insert into [404_NOT_FOUND].SUCURSALES (suc_cod_post,suc_nombre,suc_direccion,suc_habilitado) select distinct Sucursal_Codigo_Postal,Sucursal_Nombre, Sucursal_Dirección,1 from [gd_esquema].[Maestra] where Sucursal_Codigo_Postal is not null
	insert into [404_NOT_FOUND].[Rubros] (rubr_id,rubr_detalle) select distinct Empresa_Rubro, Rubro_Descripcion from [gd_esquema].[Maestra]
	insert into [404_NOT_FOUND].[EMPRESAS] (emp_cuit,emp_nombre,emp_direccion,emp_rubro,emp_habilitado) select distinct Empresa_Cuit,Empresa_Nombre,Empresa_Direccion,Empresa_Rubro,1 from [gd_esquema].[Maestra]
	insert into [404_NOT_FOUND].FACTURAS (fact_numero,fact_fecha_alta,fact_total,fact_fecha_vencimiento,fact_emp_cuit,fact_cliente,fact_habilitada) select distinct [Nro_Factura],[Factura_Fecha],[Factura_Total],[Factura_Fecha_Vencimiento],[Empresa_Cuit],[Cliente-Dni],1 from gd_esquema.Maestra 
	
	--Creación Funcionalidades
	insert into [404_NOT_FOUND].Funcionalidades values ('ABMROL','ABM de Rol')
	insert into [404_NOT_FOUND].Funcionalidades values ('ABMCLI','ABM de Cliente')
	insert into [404_NOT_FOUND].Funcionalidades values ('ABMEMP','ABM de Empresa')
	insert into [404_NOT_FOUND].Funcionalidades values ('ABMSUC','ABM de Sucursal')
	insert into [404_NOT_FOUND].Funcionalidades values ('ABMFAC','ABM de Facturas')
	insert into [404_NOT_FOUND].Funcionalidades values ('REGPAGFAC','Registro de Pago de Facturas')
	insert into [404_NOT_FOUND].Funcionalidades values ('RENFACCOB','Rendicion de Facturas Cobradas')
	insert into [404_NOT_FOUND].Funcionalidades values ('DEV','Devoluciones')
	insert into [404_NOT_FOUND].Funcionalidades values ('LISTEST','Listado Estadistico')
	
	--Migración hacia tabla Pagos e item_pagos
	open cPagos
	fetch next from cPagos into @fact_num,@pago_numero,@pago_fecha,@pago_total,@pago_medio,@suc_cod_post
		while @@FETCH_STATUS = 0
		begin
			insert into [404_NOT_FOUND].Pagos (pago_id,pago_fecha_cobro,pago_total,pago_medio,pago_suc_cod_post) values(@pago_numero,@pago_fecha,@pago_total,@pago_medio,@suc_cod_post)
			insert into [404_NOT_FOUND].Item_Pago (pago_id, fact_numero) values (@pago_numero,@fact_num)
			fetch next from cPagos into @fact_num,@pago_numero,@pago_fecha,@pago_total,@pago_medio,@suc_cod_post
		end
	close cPagos
	deallocate cPagos

	--Migración hacia tabla Rendiciones e Item_rendiciones
	open cRendicion
	fetch next from cRendicion into @fact_num,@rend_num,@rend_fecha,@fact_total,@rend_comision,@emp_cuit
		while @@FETCH_STATUS = 0
		begin
			insert into [404_NOT_FOUND].Rendiciones (rend_id,rend_fecha,rend_comision_porcent,rend_total,rend_comision,rend_cantidad,rend_empresa) values(@rend_num,@rend_fecha,10.00,@fact_total,@rend_comision,1,@emp_cuit)
			insert into [404_NOT_FOUND].Item_Rendicion (rend_id, fact_numero) values(@rend_num, @fact_num)
			fetch next from cRendicion into @fact_num,@rend_num,@rend_fecha,@fact_total,@rend_comision,@emp_cuit
		end
	close cRendicion
	deallocate cRendicion

	--Migración Items_Factura

	insert into [404_NOT_FOUND].Items_Factura (item_fact_numero,item_monto,item_cantidad) select distinct [Nro_Factura],[ItemFactura_Monto],[ItemFactura_Cantidad] from gd_esquema.Maestra order by 1

	--Creación usuario deafult TP 'admin'
	insert into [404_NOT_FOUND].[USUARIOS] (user_name,user_pass) values('admin','w23e')
	insert into [404_NOT_FOUND].[Sucursal_Usuario] (user_name, suc_cod_post) values ('admin',7210)
	insert into [404_NOT_FOUND].Roles (rol_nombre,rol_inhabilitado) values('Administrador General',0)
	--Creación usuario con funcionalidades cobrador
	insert into [404_NOT_FOUND].[Sucursal_Usuario] (user_name, suc_cod_post) values ('cobrador',7210)
	insert into [404_NOT_FOUND].[USUARIOS] (user_name,user_pass) values('cobrador','cobrador')
	insert into [404_NOT_FOUND].Roles (rol_nombre,rol_inhabilitado) values('Cobrador',0)
	--Creación usuario Administrador
	insert into [404_NOT_FOUND].[USUARIOS] (user_name,user_pass) values('administrador','administrador')
	insert into [404_NOT_FOUND].Roles (rol_nombre,rol_inhabilitado) values('Administrador',0)
	
	--Asignación de roles en tablas auxiliares
	insert into [404_NOT_FOUND].Roles_Usuarios (user_name,rol_id) values ('admin',(select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'))
	insert into [404_NOT_FOUND].Roles_Usuarios (user_name,rol_id) values ('cobrador',(select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'cobrador'))
	insert into [404_NOT_FOUND].Roles_Usuarios (user_name,rol_id) values ('administrador',(select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'))
	
	--Asignación de funcionalidades a roles
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'cobrador'),'REGPAGFAC')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'cobrador'),'DEV')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'LISTEST')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'RENFACCOB')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'ABMROL')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'ABMCLI')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'ABMEMP')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'ABMFAC')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'administrador'),'ABMSUC')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'REGPAGFAC')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'DEV')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'LISTEST')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'RENFACCOB')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'ABMROL')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'ABMCLI')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'ABMEMP')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'ABMFAC')
	insert into [404_NOT_FOUND].Roles_Funcionalidades (rol_id,func_nombre) values ((select rol_id from [404_NOT_FOUND].Roles where rol_nombre = 'Administrador General'),'ABMSUC')
go
---------------------------------------------------------------------------------------------------------
exec [404_NOT_FOUND].migracion



