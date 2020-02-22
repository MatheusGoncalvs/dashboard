IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE TABLE [MOVIM_GIM] (
        [SQL_MCODBUS] varchar(15) NOT NULL,
        [SQL_MDATMOV] decimal(8, 0) NOT NULL,
        [SQL_MROTCAL] decimal(2, 0) NOT NULL,
        [SQL_MSEQUEN] decimal(5, 0) NOT NULL,
        [SQL_MCONTRO] decimal(1, 0) NOT NULL,
        [SQL_MANOMES] decimal(6, 0) NOT NULL,
        [SQL_MSEQDIG] decimal(7, 0) NOT NULL,
        [SQL_MDIGVER] varchar(1) NOT NULL,
        [SQL_MLOTE] decimal(2, 0) NOT NULL,
        [SQL_MDOCUME] varchar(16) NOT NULL,
        [SQL_MORDSER] decimal(10, 0) NOT NULL,
        [SQL_MFORNEC] decimal(6, 0) NOT NULL,
        [SQL_MCLIENT] decimal(7, 0) NOT NULL,
        [SQL_MCODVEN] decimal(3, 0) NOT NULL,
        [SQL_MCOMVEN] varchar(1) NOT NULL,
        [SQL_MCODCCU] decimal(5, 0) NOT NULL,
        [SQL_MUNIDAD] varchar(2) NOT NULL,
        [SQL_MQTDMOV] decimal(11, 3) NOT NULL,
        [SQL_MVALMOV] decimal(15, 4) NOT NULL,
        [SQL_MCUSVEN] decimal(15, 4) NOT NULL,
        [SQL_MTIPPAG] varchar(3) NOT NULL,
        [SQL_MPRZVEN] decimal(5, 2) NOT NULL,
        [SQL_MSEQKIL] decimal(2, 0) NOT NULL,
        [SQL_MSUBULTCOM] decimal(9, 2) NOT NULL,
        [SQL_MVALAGRTOT] decimal(9, 2) NOT NULL,
        [SQL_MINDFAB] varchar(1) NOT NULL,
        [SQL_MINDLOT] varchar(1) NOT NULL,
        [SQL_MNUMLOT] varchar(20) NOT NULL,
        [SQL_MDATVAL] decimal(8, 0) NOT NULL,
        [SQL_MCHALOT] decimal(5, 0) NOT NULL,
        [SQL_MINDGRA] varchar(1) NOT NULL,
        [SQL_MDESCOR] varchar(15) NOT NULL,
        [SQL_MTAMANH] varchar(5) NOT NULL,
        [SQL_MCDBGRA] varchar(20) NOT NULL,
        [SQL_MCHAGRA] decimal(5, 0) NOT NULL,
        [SQL_MRESPEN] varchar(1) NOT NULL,
        [SQL_MMOVREP] varchar(1) NOT NULL,
        [SQL_MCHAREP] decimal(5, 0) NOT NULL,
        [SQL_MCODUSU] decimal(3, 0) NOT NULL,
        [SQL_MDATULTALT] decimal(6, 0) NOT NULL,
        [SQL_MFILLER] varchar(24) NOT NULL,
        CONSTRAINT [PK__MOVIM_GI__F721DA235EBF139D] PRIMARY KEY ([SQL_MCODBUS], [SQL_MDATMOV], [SQL_MROTCAL], [SQL_MSEQUEN])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE TABLE [VENDEDOR_GIM] (
        [SQL_VCODVEN] decimal(3, 0) NOT NULL,
        [SQL_VNOMPT1] varchar(15) NOT NULL,
        [SQL_VNOMPT2] varchar(20) NOT NULL,
        [SQL_VENDVEN] varchar(40) NOT NULL,
        [SQL_VCIDVEN] varchar(20) NOT NULL,
        [SQL_VESTVEN] varchar(2) NOT NULL,
        [SQL_VCEPVEN] decimal(9, 0) NOT NULL,
        [SQL_VTELVEN] varchar(20) NOT NULL,
        [SQL_VFAXVEN] varchar(15) NOT NULL,
        [SQL_VPESCON] varchar(15) NOT NULL,
        [SQL_VINSEST] varchar(15) NOT NULL,
        [SQL_VPRAREC] varchar(30) NOT NULL,
        [SQL_VIDENTI] decimal(13, 0) NOT NULL,
        [SQL_VDATCAD] decimal(8, 0) NOT NULL,
        [SQL_VOBSERV] varchar(40) NOT NULL,
        [SQL_VLISPRE] varchar(3) NOT NULL,
        [SQL_VTIPO] decimal(2, 0) NOT NULL,
        [SQL_VCGCCPF] decimal(14, 0) NOT NULL,
        [SQL_VCOMISSVEL] decimal(4, 2) NOT NULL,
        [SQL_VBANCON] varchar(20) NOT NULL,
        [SQL_VCOMISS_GRU] varchar(32) NOT NULL,
        [SQL_VCOTAS_GRU] varchar(180) NOT NULL,
        [SQL_VCUSHOR] decimal(9, 2) NOT NULL,
        [SQL_VCODAUT] varchar(8) NOT NULL,
        [SQL_VCODREG] varchar(3) NOT NULL,
        [SQL_VINDFVE] varchar(1) NOT NULL,
        [SQL_VCODSUP] decimal(3, 0) NOT NULL,
        [SQL_VEMAVEN] varchar(50) NOT NULL,
        [SQL_VFILLER] varchar(36) NOT NULL,
        CONSTRAINT [PK__VENDEDOR__67C348E0367C1819] PRIMARY KEY ([SQL_VCODVEN])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE INDEX [SQL_CHMOVIM_UA] ON [MOVIM_GIM] ([SQL_MDATULTALT]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE INDEX [SQL_CHMOVIM_CD] ON [MOVIM_GIM] ([SQL_MCLIENT], [SQL_MDATMOV]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE INDEX [SQL_CHMOVIM_VD] ON [MOVIM_GIM] ([SQL_MCODVEN], [SQL_MDATMOV]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE INDEX [SQL_CHMOVIM_AM] ON [MOVIM_GIM] ([SQL_MANOMES], [SQL_MCODBUS], [SQL_MDATMOV], [SQL_MROTCAL], [SQL_MSEQUEN]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    CREATE INDEX [SQL_VNOMPT1] ON [VENDEDOR_GIM] ([SQL_VNOMPT1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200218230651_sofdatabaseMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200218230651_sofdatabaseMigration', N'2.2.6-servicing-10079');
END;

GO

