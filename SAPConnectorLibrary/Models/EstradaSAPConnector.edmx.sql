
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2018 19:50:02
-- Generated from EDMX file: C:\Users\GustavoMarino\Documents\Visual Studio 2017\Projects\EstradaSAPConnector\SAPConnectorLibrary\Models\EstradaSAPConnector.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SAPConnector];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FondoFijoRendicionGastos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionABC] DROP CONSTRAINT [FK_FondoFijoRendicionGastos];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EstadosSAPC_FondoFijo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FondoFijo] DROP CONSTRAINT [FK_SAPC_EstadosSAPC_FondoFijo];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EndPointSAPC_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Session] DROP CONSTRAINT [FK_SAPC_EndPointSAPC_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EndPointSAPC_FondoFijo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FondoFijo] DROP CONSTRAINT [FK_SAPC_EndPointSAPC_FondoFijo];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_SessionSAPC_SAPRPCCall]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_SessionSAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_Adelantos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_Adelantos];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_SAPRPCCall]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_FondoFijoSAPC_Adelantos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Adelantos] DROP CONSTRAINT [FK_SAPC_FondoFijoSAPC_Adelantos];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_RendicionGastos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_RendicionGastos];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_SAPRPCCall]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EstadosSAPC_RendicionGastos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionABC] DROP CONSTRAINT [FK_SAPC_EstadosSAPC_RendicionGastos];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_RendicionGastosSAPC_FacturaProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FacturaProveedor] DROP CONSTRAINT [FK_SAPC_RendicionGastosSAPC_FacturaProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EstadosSAPC_Adelantos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Adelantos] DROP CONSTRAINT [FK_SAPC_EstadosSAPC_Adelantos];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_ComprobanteSAPC_RendicionComp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Comprobante] DROP CONSTRAINT [FK_SAPC_ComprobanteSAPC_RendicionComp];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_RendicionComp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_RendicionComp];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_SAPRPCCall]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_FondoFijoSAPC_RendicionComp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionComp] DROP CONSTRAINT [FK_SAPC_FondoFijoSAPC_RendicionComp];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EstadosSAPC_RendicionComp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionComp] DROP CONSTRAINT [FK_SAPC_EstadosSAPC_RendicionComp];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EndPointSAPC_SAPRPCCall]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_SAPRPCCall] DROP CONSTRAINT [FK_SAPC_EndPointSAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_ProveedorSAPC_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Comprobante] DROP CONSTRAINT [FK_SAPC_ProveedorSAPC_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_ProveedorSAPC_FacturaProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FacturaProveedor] DROP CONSTRAINT [FK_SAPC_ProveedorSAPC_FacturaProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_CECOSAPC_FacturaProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FacturaProveedor] DROP CONSTRAINT [FK_CECOSAPC_FacturaProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_CECOSAPC_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Comprobante] DROP CONSTRAINT [FK_CECOSAPC_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_PercepcionesSAPC_FacturaProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FacturaProveedor] DROP CONSTRAINT [FK_PercepcionesSAPC_FacturaProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_PercepcionesSAPC_FacturaProveedor1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FacturaProveedor] DROP CONSTRAINT [FK_PercepcionesSAPC_FacturaProveedor1];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_JurisdiccionesSAPC_Percepciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Percepciones] DROP CONSTRAINT [FK_SAPC_JurisdiccionesSAPC_Percepciones];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EmpleadoSAPC_FacturaProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_FacturaProveedor] DROP CONSTRAINT [FK_SAPC_EmpleadoSAPC_FacturaProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EmpleadoSAPC_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Comprobante] DROP CONSTRAINT [FK_SAPC_EmpleadoSAPC_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EmpleadoSAPC_RendicionABC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionABC] DROP CONSTRAINT [FK_SAPC_EmpleadoSAPC_RendicionABC];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EmpleadoSAPC_RendicionComp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_RendicionComp] DROP CONSTRAINT [FK_SAPC_EmpleadoSAPC_RendicionComp];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_AdelantosSAPC_Empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Adelantos] DROP CONSTRAINT [FK_SAPC_AdelantosSAPC_Empleado];
GO
IF OBJECT_ID(N'[dbo].[FK_SAPC_EndPointSAPC_Empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SAPC_Empleado] DROP CONSTRAINT [FK_SAPC_EndPointSAPC_Empleado];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SAPC_RendicionABC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_RendicionABC];
GO
IF OBJECT_ID(N'[dbo].[SAPC_FacturaProveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_FacturaProveedor];
GO
IF OBJECT_ID(N'[dbo].[SAPC_FondoFijo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_FondoFijo];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Session]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Session];
GO
IF OBJECT_ID(N'[dbo].[SAPC_SAPRPCCall]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[SAPC_EndPoint]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_EndPoint];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Adelantos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Adelantos];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Estados];
GO
IF OBJECT_ID(N'[dbo].[SAPC_RendicionComp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_RendicionComp];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Comprobante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Proveedores];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Empleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Empleado];
GO
IF OBJECT_ID(N'[dbo].[SAPC_CECO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_CECO];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Percepciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Percepciones];
GO
IF OBJECT_ID(N'[dbo].[SAPC_Jurisdicciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_Jurisdicciones];
GO
IF OBJECT_ID(N'[dbo].[SAPC_AdelantosSAPC_SAPRPCCall]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall];
GO
IF OBJECT_ID(N'[dbo].[SAPC_RendicionCompSAPC_SAPRPCCall]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SAPC_RendicionABC'
CREATE TABLE [dbo].[SAPC_RendicionABC] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SAPNroDoc] nvarchar(max)  NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [FondoFijo_Id] int  NULL,
    [Estado_Id] int  NOT NULL,
    [RendidoPor_Id] int  NULL
);
GO

-- Creating table 'SAPC_FacturaProveedor'
CREATE TABLE [dbo].[SAPC_FacturaProveedor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoDocumento] nvarchar(max)  NOT NULL,
    [ImporteNeto] decimal(18,0)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [PtoVenta] decimal(18,0)  NOT NULL,
    [NumeroDocumento] decimal(18,0)  NOT NULL,
    [BaseIVA21] decimal(18,0)  NOT NULL,
    [BaseIVA105] decimal(18,0)  NOT NULL,
    [BaseIVA27] decimal(18,0)  NOT NULL,
    [BaseIVA0] decimal(18,0)  NOT NULL,
    [ImporteTotalAPagar] decimal(18,0)  NOT NULL,
    [Percepcion1Importe] decimal(18,0)  NOT NULL,
    [Percepcion2Importe] decimal(18,0)  NOT NULL,
    [RendicionGastos_Id] int  NOT NULL,
    [Proveedor_Id] int  NOT NULL,
    [CECO_Id] int  NOT NULL,
    [Percepcion1_Id] int  NULL,
    [Percepcion2_Id] int  NULL,
    [SAPC_EmpleadoSAPC_FacturaProveedor_SAPC_FacturaProveedor_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_FondoFijo'
CREATE TABLE [dbo].[SAPC_FondoFijo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [CreadoEn] nvarchar(max)  NOT NULL,
    [SAPId] nvarchar(max)  NOT NULL,
    [Estado_Id] int  NOT NULL,
    [EndPoint_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_Session'
CREATE TABLE [dbo].[SAPC_Session] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartedOn] datetime  NOT NULL,
    [FinishedOn] datetime  NOT NULL,
    [ErrorMessage] nvarchar(max)  NOT NULL,
    [ErrorCode] nvarchar(max)  NOT NULL,
    [EndPoint_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_SAPRPCCall'
CREATE TABLE [dbo].[SAPC_SAPRPCCall] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Method] nvarchar(max)  NOT NULL,
    [StartedOn] nvarchar(max)  NOT NULL,
    [FinishedOn] nvarchar(max)  NOT NULL,
    [ErrorCode] nvarchar(max)  NOT NULL,
    [ErrorMsg] nvarchar(max)  NOT NULL,
    [InputParameters] nvarchar(max)  NOT NULL,
    [Results] nvarchar(max)  NOT NULL,
    [Session_Id] int  NOT NULL,
    [EndPoint_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_EndPoint'
CREATE TABLE [dbo].[SAPC_EndPoint] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [URLAdelantos] nvarchar(max)  NOT NULL,
    [LastConnectionOn] datetime  NULL,
    [URLRendicionABC] nvarchar(max)  NOT NULL,
    [URLRendicionNoABC] nvarchar(max)  NOT NULL,
    [LoginName] nvarchar(max)  NOT NULL,
    [LoginPassword] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SAPC_Adelantos'
CREATE TABLE [dbo].[SAPC_Adelantos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SAPNroDoc] nvarchar(max)  NULL,
    [Fecha] datetime  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [FondoFijo_Id] int  NULL,
    [Estado_Id] int  NOT NULL,
    [PedidoPorEmpleado_Id] int  NULL
);
GO

-- Creating table 'SAPC_Estados'
CREATE TABLE [dbo].[SAPC_Estados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [EntityName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SAPC_RendicionComp'
CREATE TABLE [dbo].[SAPC_RendicionComp] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SAPNroDoc] nvarchar(max)  NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [FondoFijo_Id] int  NULL,
    [Estado_Id] int  NOT NULL,
    [RendidoPor_Id] int  NULL
);
GO

-- Creating table 'SAPC_Comprobante'
CREATE TABLE [dbo].[SAPC_Comprobante] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Importe] decimal(18,0)  NOT NULL,
    [RendicionComp_Id] int  NOT NULL,
    [Proveedor_Id] int  NOT NULL,
    [CECO_Id] int  NOT NULL,
    [SAPC_EmpleadoSAPC_Comprobante_SAPC_Comprobante_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_Proveedores'
CREATE TABLE [dbo].[SAPC_Proveedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [CUIT] nvarchar(max)  NOT NULL,
    [CtaContable] nvarchar(max)  NOT NULL,
    [SAPId] nvarchar(max)  NOT NULL,
    [Calle] nvarchar(max)  NOT NULL,
    [CPostal] nvarchar(max)  NOT NULL,
    [Flag] bit  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [Poblacion] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [UltimaActualizacion] datetime  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SAPC_Empleado'
CREATE TABLE [dbo].[SAPC_Empleado] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [CtaContable] nvarchar(max)  NOT NULL,
    [SAPEndPoint_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_CECO'
CREATE TABLE [dbo].[SAPC_CECO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [CodCECO] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SAPC_Percepciones'
CREATE TABLE [dbo].[SAPC_Percepciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [CtaContable] nvarchar(max)  NOT NULL,
    [Jurisdiccion_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_Jurisdicciones'
CREATE TABLE [dbo].[SAPC_Jurisdicciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SAPC_AdelantosSAPC_SAPRPCCall'
CREATE TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall] (
    [Adelantos_Id] int  NOT NULL,
    [RPCCalls_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_RendicionGastosSAPC_SAPRPCCall'
CREATE TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall] (
    [RendicionesGastos_Id] int  NOT NULL,
    [RPCCalls_Id] int  NOT NULL
);
GO

-- Creating table 'SAPC_RendicionCompSAPC_SAPRPCCall'
CREATE TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall] (
    [RendicionesComprobantes_Id] int  NOT NULL,
    [RPCCalls_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SAPC_RendicionABC'
ALTER TABLE [dbo].[SAPC_RendicionABC]
ADD CONSTRAINT [PK_SAPC_RendicionABC]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [PK_SAPC_FacturaProveedor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_FondoFijo'
ALTER TABLE [dbo].[SAPC_FondoFijo]
ADD CONSTRAINT [PK_SAPC_FondoFijo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Session'
ALTER TABLE [dbo].[SAPC_Session]
ADD CONSTRAINT [PK_SAPC_Session]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_SAPRPCCall]
ADD CONSTRAINT [PK_SAPC_SAPRPCCall]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_EndPoint'
ALTER TABLE [dbo].[SAPC_EndPoint]
ADD CONSTRAINT [PK_SAPC_EndPoint]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Adelantos'
ALTER TABLE [dbo].[SAPC_Adelantos]
ADD CONSTRAINT [PK_SAPC_Adelantos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Estados'
ALTER TABLE [dbo].[SAPC_Estados]
ADD CONSTRAINT [PK_SAPC_Estados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_RendicionComp'
ALTER TABLE [dbo].[SAPC_RendicionComp]
ADD CONSTRAINT [PK_SAPC_RendicionComp]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Comprobante'
ALTER TABLE [dbo].[SAPC_Comprobante]
ADD CONSTRAINT [PK_SAPC_Comprobante]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Proveedores'
ALTER TABLE [dbo].[SAPC_Proveedores]
ADD CONSTRAINT [PK_SAPC_Proveedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Empleado'
ALTER TABLE [dbo].[SAPC_Empleado]
ADD CONSTRAINT [PK_SAPC_Empleado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_CECO'
ALTER TABLE [dbo].[SAPC_CECO]
ADD CONSTRAINT [PK_SAPC_CECO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Percepciones'
ALTER TABLE [dbo].[SAPC_Percepciones]
ADD CONSTRAINT [PK_SAPC_Percepciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SAPC_Jurisdicciones'
ALTER TABLE [dbo].[SAPC_Jurisdicciones]
ADD CONSTRAINT [PK_SAPC_Jurisdicciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Adelantos_Id], [RPCCalls_Id] in table 'SAPC_AdelantosSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall]
ADD CONSTRAINT [PK_SAPC_AdelantosSAPC_SAPRPCCall]
    PRIMARY KEY CLUSTERED ([Adelantos_Id], [RPCCalls_Id] ASC);
GO

-- Creating primary key on [RendicionesGastos_Id], [RPCCalls_Id] in table 'SAPC_RendicionGastosSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall]
ADD CONSTRAINT [PK_SAPC_RendicionGastosSAPC_SAPRPCCall]
    PRIMARY KEY CLUSTERED ([RendicionesGastos_Id], [RPCCalls_Id] ASC);
GO

-- Creating primary key on [RendicionesComprobantes_Id], [RPCCalls_Id] in table 'SAPC_RendicionCompSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall]
ADD CONSTRAINT [PK_SAPC_RendicionCompSAPC_SAPRPCCall]
    PRIMARY KEY CLUSTERED ([RendicionesComprobantes_Id], [RPCCalls_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FondoFijo_Id] in table 'SAPC_RendicionABC'
ALTER TABLE [dbo].[SAPC_RendicionABC]
ADD CONSTRAINT [FK_FondoFijoRendicionGastos]
    FOREIGN KEY ([FondoFijo_Id])
    REFERENCES [dbo].[SAPC_FondoFijo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FondoFijoRendicionGastos'
CREATE INDEX [IX_FK_FondoFijoRendicionGastos]
ON [dbo].[SAPC_RendicionABC]
    ([FondoFijo_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'SAPC_FondoFijo'
ALTER TABLE [dbo].[SAPC_FondoFijo]
ADD CONSTRAINT [FK_SAPC_EstadosSAPC_FondoFijo]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[SAPC_Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EstadosSAPC_FondoFijo'
CREATE INDEX [IX_FK_SAPC_EstadosSAPC_FondoFijo]
ON [dbo].[SAPC_FondoFijo]
    ([Estado_Id]);
GO

-- Creating foreign key on [EndPoint_Id] in table 'SAPC_Session'
ALTER TABLE [dbo].[SAPC_Session]
ADD CONSTRAINT [FK_SAPC_EndPointSAPC_Session]
    FOREIGN KEY ([EndPoint_Id])
    REFERENCES [dbo].[SAPC_EndPoint]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EndPointSAPC_Session'
CREATE INDEX [IX_FK_SAPC_EndPointSAPC_Session]
ON [dbo].[SAPC_Session]
    ([EndPoint_Id]);
GO

-- Creating foreign key on [EndPoint_Id] in table 'SAPC_FondoFijo'
ALTER TABLE [dbo].[SAPC_FondoFijo]
ADD CONSTRAINT [FK_SAPC_EndPointSAPC_FondoFijo]
    FOREIGN KEY ([EndPoint_Id])
    REFERENCES [dbo].[SAPC_EndPoint]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EndPointSAPC_FondoFijo'
CREATE INDEX [IX_FK_SAPC_EndPointSAPC_FondoFijo]
ON [dbo].[SAPC_FondoFijo]
    ([EndPoint_Id]);
GO

-- Creating foreign key on [Session_Id] in table 'SAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_SessionSAPC_SAPRPCCall]
    FOREIGN KEY ([Session_Id])
    REFERENCES [dbo].[SAPC_Session]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_SessionSAPC_SAPRPCCall'
CREATE INDEX [IX_FK_SAPC_SessionSAPC_SAPRPCCall]
ON [dbo].[SAPC_SAPRPCCall]
    ([Session_Id]);
GO

-- Creating foreign key on [Adelantos_Id] in table 'SAPC_AdelantosSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_Adelantos]
    FOREIGN KEY ([Adelantos_Id])
    REFERENCES [dbo].[SAPC_Adelantos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RPCCalls_Id] in table 'SAPC_AdelantosSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_AdelantosSAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_SAPRPCCall]
    FOREIGN KEY ([RPCCalls_Id])
    REFERENCES [dbo].[SAPC_SAPRPCCall]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_SAPRPCCall'
CREATE INDEX [IX_FK_SAPC_AdelantosSAPC_SAPRPCCall_SAPC_SAPRPCCall]
ON [dbo].[SAPC_AdelantosSAPC_SAPRPCCall]
    ([RPCCalls_Id]);
GO

-- Creating foreign key on [FondoFijo_Id] in table 'SAPC_Adelantos'
ALTER TABLE [dbo].[SAPC_Adelantos]
ADD CONSTRAINT [FK_SAPC_FondoFijoSAPC_Adelantos]
    FOREIGN KEY ([FondoFijo_Id])
    REFERENCES [dbo].[SAPC_FondoFijo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_FondoFijoSAPC_Adelantos'
CREATE INDEX [IX_FK_SAPC_FondoFijoSAPC_Adelantos]
ON [dbo].[SAPC_Adelantos]
    ([FondoFijo_Id]);
GO

-- Creating foreign key on [RendicionesGastos_Id] in table 'SAPC_RendicionGastosSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_RendicionGastos]
    FOREIGN KEY ([RendicionesGastos_Id])
    REFERENCES [dbo].[SAPC_RendicionABC]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RPCCalls_Id] in table 'SAPC_RendicionGastosSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_SAPRPCCall]
    FOREIGN KEY ([RPCCalls_Id])
    REFERENCES [dbo].[SAPC_SAPRPCCall]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_SAPRPCCall'
CREATE INDEX [IX_FK_SAPC_RendicionGastosSAPC_SAPRPCCall_SAPC_SAPRPCCall]
ON [dbo].[SAPC_RendicionGastosSAPC_SAPRPCCall]
    ([RPCCalls_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'SAPC_RendicionABC'
ALTER TABLE [dbo].[SAPC_RendicionABC]
ADD CONSTRAINT [FK_SAPC_EstadosSAPC_RendicionGastos]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[SAPC_Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EstadosSAPC_RendicionGastos'
CREATE INDEX [IX_FK_SAPC_EstadosSAPC_RendicionGastos]
ON [dbo].[SAPC_RendicionABC]
    ([Estado_Id]);
GO

-- Creating foreign key on [RendicionGastos_Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [FK_SAPC_RendicionGastosSAPC_FacturaProveedor]
    FOREIGN KEY ([RendicionGastos_Id])
    REFERENCES [dbo].[SAPC_RendicionABC]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_RendicionGastosSAPC_FacturaProveedor'
CREATE INDEX [IX_FK_SAPC_RendicionGastosSAPC_FacturaProveedor]
ON [dbo].[SAPC_FacturaProveedor]
    ([RendicionGastos_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'SAPC_Adelantos'
ALTER TABLE [dbo].[SAPC_Adelantos]
ADD CONSTRAINT [FK_SAPC_EstadosSAPC_Adelantos]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[SAPC_Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EstadosSAPC_Adelantos'
CREATE INDEX [IX_FK_SAPC_EstadosSAPC_Adelantos]
ON [dbo].[SAPC_Adelantos]
    ([Estado_Id]);
GO

-- Creating foreign key on [RendicionComp_Id] in table 'SAPC_Comprobante'
ALTER TABLE [dbo].[SAPC_Comprobante]
ADD CONSTRAINT [FK_SAPC_ComprobanteSAPC_RendicionComp]
    FOREIGN KEY ([RendicionComp_Id])
    REFERENCES [dbo].[SAPC_RendicionComp]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_ComprobanteSAPC_RendicionComp'
CREATE INDEX [IX_FK_SAPC_ComprobanteSAPC_RendicionComp]
ON [dbo].[SAPC_Comprobante]
    ([RendicionComp_Id]);
GO

-- Creating foreign key on [RendicionesComprobantes_Id] in table 'SAPC_RendicionCompSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_RendicionComp]
    FOREIGN KEY ([RendicionesComprobantes_Id])
    REFERENCES [dbo].[SAPC_RendicionComp]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RPCCalls_Id] in table 'SAPC_RendicionCompSAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_SAPRPCCall]
    FOREIGN KEY ([RPCCalls_Id])
    REFERENCES [dbo].[SAPC_SAPRPCCall]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_SAPRPCCall'
CREATE INDEX [IX_FK_SAPC_RendicionCompSAPC_SAPRPCCall_SAPC_SAPRPCCall]
ON [dbo].[SAPC_RendicionCompSAPC_SAPRPCCall]
    ([RPCCalls_Id]);
GO

-- Creating foreign key on [FondoFijo_Id] in table 'SAPC_RendicionComp'
ALTER TABLE [dbo].[SAPC_RendicionComp]
ADD CONSTRAINT [FK_SAPC_FondoFijoSAPC_RendicionComp]
    FOREIGN KEY ([FondoFijo_Id])
    REFERENCES [dbo].[SAPC_FondoFijo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_FondoFijoSAPC_RendicionComp'
CREATE INDEX [IX_FK_SAPC_FondoFijoSAPC_RendicionComp]
ON [dbo].[SAPC_RendicionComp]
    ([FondoFijo_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'SAPC_RendicionComp'
ALTER TABLE [dbo].[SAPC_RendicionComp]
ADD CONSTRAINT [FK_SAPC_EstadosSAPC_RendicionComp]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[SAPC_Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EstadosSAPC_RendicionComp'
CREATE INDEX [IX_FK_SAPC_EstadosSAPC_RendicionComp]
ON [dbo].[SAPC_RendicionComp]
    ([Estado_Id]);
GO

-- Creating foreign key on [EndPoint_Id] in table 'SAPC_SAPRPCCall'
ALTER TABLE [dbo].[SAPC_SAPRPCCall]
ADD CONSTRAINT [FK_SAPC_EndPointSAPC_SAPRPCCall]
    FOREIGN KEY ([EndPoint_Id])
    REFERENCES [dbo].[SAPC_EndPoint]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EndPointSAPC_SAPRPCCall'
CREATE INDEX [IX_FK_SAPC_EndPointSAPC_SAPRPCCall]
ON [dbo].[SAPC_SAPRPCCall]
    ([EndPoint_Id]);
GO

-- Creating foreign key on [Proveedor_Id] in table 'SAPC_Comprobante'
ALTER TABLE [dbo].[SAPC_Comprobante]
ADD CONSTRAINT [FK_SAPC_ProveedorSAPC_Comprobante]
    FOREIGN KEY ([Proveedor_Id])
    REFERENCES [dbo].[SAPC_Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_ProveedorSAPC_Comprobante'
CREATE INDEX [IX_FK_SAPC_ProveedorSAPC_Comprobante]
ON [dbo].[SAPC_Comprobante]
    ([Proveedor_Id]);
GO

-- Creating foreign key on [Proveedor_Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [FK_SAPC_ProveedorSAPC_FacturaProveedor]
    FOREIGN KEY ([Proveedor_Id])
    REFERENCES [dbo].[SAPC_Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_ProveedorSAPC_FacturaProveedor'
CREATE INDEX [IX_FK_SAPC_ProveedorSAPC_FacturaProveedor]
ON [dbo].[SAPC_FacturaProveedor]
    ([Proveedor_Id]);
GO

-- Creating foreign key on [CECO_Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [FK_CECOSAPC_FacturaProveedor]
    FOREIGN KEY ([CECO_Id])
    REFERENCES [dbo].[SAPC_CECO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CECOSAPC_FacturaProveedor'
CREATE INDEX [IX_FK_CECOSAPC_FacturaProveedor]
ON [dbo].[SAPC_FacturaProveedor]
    ([CECO_Id]);
GO

-- Creating foreign key on [CECO_Id] in table 'SAPC_Comprobante'
ALTER TABLE [dbo].[SAPC_Comprobante]
ADD CONSTRAINT [FK_CECOSAPC_Comprobante]
    FOREIGN KEY ([CECO_Id])
    REFERENCES [dbo].[SAPC_CECO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CECOSAPC_Comprobante'
CREATE INDEX [IX_FK_CECOSAPC_Comprobante]
ON [dbo].[SAPC_Comprobante]
    ([CECO_Id]);
GO

-- Creating foreign key on [Percepcion1_Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [FK_PercepcionesSAPC_FacturaProveedor]
    FOREIGN KEY ([Percepcion1_Id])
    REFERENCES [dbo].[SAPC_Percepciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PercepcionesSAPC_FacturaProveedor'
CREATE INDEX [IX_FK_PercepcionesSAPC_FacturaProveedor]
ON [dbo].[SAPC_FacturaProveedor]
    ([Percepcion1_Id]);
GO

-- Creating foreign key on [Percepcion2_Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [FK_PercepcionesSAPC_FacturaProveedor1]
    FOREIGN KEY ([Percepcion2_Id])
    REFERENCES [dbo].[SAPC_Percepciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PercepcionesSAPC_FacturaProveedor1'
CREATE INDEX [IX_FK_PercepcionesSAPC_FacturaProveedor1]
ON [dbo].[SAPC_FacturaProveedor]
    ([Percepcion2_Id]);
GO

-- Creating foreign key on [Jurisdiccion_Id] in table 'SAPC_Percepciones'
ALTER TABLE [dbo].[SAPC_Percepciones]
ADD CONSTRAINT [FK_SAPC_JurisdiccionesSAPC_Percepciones]
    FOREIGN KEY ([Jurisdiccion_Id])
    REFERENCES [dbo].[SAPC_Jurisdicciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_JurisdiccionesSAPC_Percepciones'
CREATE INDEX [IX_FK_SAPC_JurisdiccionesSAPC_Percepciones]
ON [dbo].[SAPC_Percepciones]
    ([Jurisdiccion_Id]);
GO

-- Creating foreign key on [SAPC_EmpleadoSAPC_FacturaProveedor_SAPC_FacturaProveedor_Id] in table 'SAPC_FacturaProveedor'
ALTER TABLE [dbo].[SAPC_FacturaProveedor]
ADD CONSTRAINT [FK_SAPC_EmpleadoSAPC_FacturaProveedor]
    FOREIGN KEY ([SAPC_EmpleadoSAPC_FacturaProveedor_SAPC_FacturaProveedor_Id])
    REFERENCES [dbo].[SAPC_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EmpleadoSAPC_FacturaProveedor'
CREATE INDEX [IX_FK_SAPC_EmpleadoSAPC_FacturaProveedor]
ON [dbo].[SAPC_FacturaProveedor]
    ([SAPC_EmpleadoSAPC_FacturaProveedor_SAPC_FacturaProveedor_Id]);
GO

-- Creating foreign key on [SAPC_EmpleadoSAPC_Comprobante_SAPC_Comprobante_Id] in table 'SAPC_Comprobante'
ALTER TABLE [dbo].[SAPC_Comprobante]
ADD CONSTRAINT [FK_SAPC_EmpleadoSAPC_Comprobante]
    FOREIGN KEY ([SAPC_EmpleadoSAPC_Comprobante_SAPC_Comprobante_Id])
    REFERENCES [dbo].[SAPC_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EmpleadoSAPC_Comprobante'
CREATE INDEX [IX_FK_SAPC_EmpleadoSAPC_Comprobante]
ON [dbo].[SAPC_Comprobante]
    ([SAPC_EmpleadoSAPC_Comprobante_SAPC_Comprobante_Id]);
GO

-- Creating foreign key on [RendidoPor_Id] in table 'SAPC_RendicionABC'
ALTER TABLE [dbo].[SAPC_RendicionABC]
ADD CONSTRAINT [FK_SAPC_EmpleadoSAPC_RendicionABC]
    FOREIGN KEY ([RendidoPor_Id])
    REFERENCES [dbo].[SAPC_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EmpleadoSAPC_RendicionABC'
CREATE INDEX [IX_FK_SAPC_EmpleadoSAPC_RendicionABC]
ON [dbo].[SAPC_RendicionABC]
    ([RendidoPor_Id]);
GO

-- Creating foreign key on [RendidoPor_Id] in table 'SAPC_RendicionComp'
ALTER TABLE [dbo].[SAPC_RendicionComp]
ADD CONSTRAINT [FK_SAPC_EmpleadoSAPC_RendicionComp]
    FOREIGN KEY ([RendidoPor_Id])
    REFERENCES [dbo].[SAPC_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EmpleadoSAPC_RendicionComp'
CREATE INDEX [IX_FK_SAPC_EmpleadoSAPC_RendicionComp]
ON [dbo].[SAPC_RendicionComp]
    ([RendidoPor_Id]);
GO

-- Creating foreign key on [PedidoPorEmpleado_Id] in table 'SAPC_Adelantos'
ALTER TABLE [dbo].[SAPC_Adelantos]
ADD CONSTRAINT [FK_SAPC_AdelantosSAPC_Empleado]
    FOREIGN KEY ([PedidoPorEmpleado_Id])
    REFERENCES [dbo].[SAPC_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_AdelantosSAPC_Empleado'
CREATE INDEX [IX_FK_SAPC_AdelantosSAPC_Empleado]
ON [dbo].[SAPC_Adelantos]
    ([PedidoPorEmpleado_Id]);
GO

-- Creating foreign key on [SAPEndPoint_Id] in table 'SAPC_Empleado'
ALTER TABLE [dbo].[SAPC_Empleado]
ADD CONSTRAINT [FK_SAPC_EndPointSAPC_Empleado]
    FOREIGN KEY ([SAPEndPoint_Id])
    REFERENCES [dbo].[SAPC_EndPoint]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SAPC_EndPointSAPC_Empleado'
CREATE INDEX [IX_FK_SAPC_EndPointSAPC_Empleado]
ON [dbo].[SAPC_Empleado]
    ([SAPEndPoint_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------