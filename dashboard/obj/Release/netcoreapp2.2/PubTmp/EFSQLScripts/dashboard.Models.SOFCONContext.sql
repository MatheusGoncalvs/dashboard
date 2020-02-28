IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200222142207_insertPedidoEntitie')
BEGIN
    CREATE TABLE [pedidos] (
        [IdPedido] int NOT NULL IDENTITY,
        [IdItem] int NOT NULL,
        [QtdItem] float NOT NULL,
        [IdNfe] int NOT NULL,
        [IdCliente] int NOT NULL,
        [DataEmissao] datetime2 NOT NULL,
        [DataFaturamento] datetime2 NOT NULL,
        CONSTRAINT [PK_pedidos] PRIMARY KEY ([IdPedido])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200222142207_insertPedidoEntitie')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200222142207_insertPedidoEntitie', N'2.2.6-servicing-10079');
END;

GO

