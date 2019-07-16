IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Coordinators] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Website] nvarchar(max) NULL,
    [CellPhone] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Coordinators] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [GeoCoordinates] (
    [Id] uniqueidentifier NOT NULL,
    [Latitude] decimal(18,2) NOT NULL,
    [Longitude] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_GeoCoordinates] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Prices] (
    [Id] uniqueidentifier NOT NULL,
    [KidsPrice] decimal(18,2) NOT NULL,
    [AdultsPrice] decimal(18,2) NOT NULL,
    [SeniorCitizenPrice] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Prices] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Locations] (
    [Id] uniqueidentifier NOT NULL,
    [Surburb] nvarchar(max) NULL,
    [Town] nvarchar(max) NULL,
    [Province] nvarchar(max) NULL,
    [Country] nvarchar(max) NULL,
    [GpsLocationId] uniqueidentifier NULL,
    CONSTRAINT [PK_Locations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Locations_GeoCoordinates_GpsLocationId] FOREIGN KEY ([GpsLocationId]) REFERENCES [GeoCoordinates] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Events] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [PriceId] uniqueidentifier NULL,
    [LocationId] uniqueidentifier NULL,
    [CoordinatorId] uniqueidentifier NULL,
    [FromDate] datetime2 NOT NULL,
    [ToDate] datetime2 NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Events_Coordinators_CoordinatorId] FOREIGN KEY ([CoordinatorId]) REFERENCES [Coordinators] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Events_Locations_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [Locations] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Events_Prices_PriceId] FOREIGN KEY ([PriceId]) REFERENCES [Prices] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Images] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Base64] nvarchar(max) NULL,
    [EventId] uniqueidentifier NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Images_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Events_CoordinatorId] ON [Events] ([CoordinatorId]);

GO

CREATE INDEX [IX_Events_LocationId] ON [Events] ([LocationId]);

GO

CREATE INDEX [IX_Events_PriceId] ON [Events] ([PriceId]);

GO

CREATE INDEX [IX_Images_EventId] ON [Images] ([EventId]);

GO

CREATE INDEX [IX_Locations_GpsLocationId] ON [Locations] ([GpsLocationId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190716213919_initial', N'2.2.6-servicing-10079');

GO

