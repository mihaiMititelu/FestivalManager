
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/14/2017 13:55:20
-- Generated from EDMX file: C:\Users\mititelu\documents\visual studio 2015\Projects\TSP.EntityLayer\TSP.EntityLayer\Festival.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FestivalDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FestivalPerformer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Performers] DROP CONSTRAINT [FK_FestivalPerformer];
GO
IF OBJECT_ID(N'[dbo].[FK_FestivalTicket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tickets] DROP CONSTRAINT [FK_FestivalTicket];
GO
IF OBJECT_ID(N'[dbo].[FK_PerformerTicket_Performer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerformerTicket] DROP CONSTRAINT [FK_PerformerTicket_Performer];
GO
IF OBJECT_ID(N'[dbo].[FK_PerformerTicket_Ticket]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerformerTicket] DROP CONSTRAINT [FK_PerformerTicket_Ticket];
GO
IF OBJECT_ID(N'[dbo].[FK_FestivalLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Festivals] DROP CONSTRAINT [FK_FestivalLocation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Festivals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Festivals];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Performers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Performers];
GO
IF OBJECT_ID(N'[dbo].[Tickets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tickets];
GO
IF OBJECT_ID(N'[dbo].[PerformerTicket]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerformerTicket];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Festivals'
CREATE TABLE [dbo].[Festivals] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DateAndTime] datetime  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] uniqueidentifier  NOT NULL,
    [Capacity] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Festival_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Performers'
CREATE TABLE [dbo].[Performers] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [RequestedPay] nvarchar(max)  NOT NULL,
    [FestivalId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Tickets'
CREATE TABLE [dbo].[Tickets] (
    [Id] int  NOT NULL,
    [FestivalId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PerformerTicket'
CREATE TABLE [dbo].[PerformerTicket] (
    [Performers_Id] uniqueidentifier  NOT NULL,
    [Tickets_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Festivals'
ALTER TABLE [dbo].[Festivals]
ADD CONSTRAINT [PK_Festivals]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Performers'
ALTER TABLE [dbo].[Performers]
ADD CONSTRAINT [PK_Performers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [PK_Tickets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Performers_Id], [Tickets_Id] in table 'PerformerTicket'
ALTER TABLE [dbo].[PerformerTicket]
ADD CONSTRAINT [PK_PerformerTicket]
    PRIMARY KEY CLUSTERED ([Performers_Id], [Tickets_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FestivalId] in table 'Performers'
ALTER TABLE [dbo].[Performers]
ADD CONSTRAINT [FK_FestivalPerformer]
    FOREIGN KEY ([FestivalId])
    REFERENCES [dbo].[Festivals]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FestivalPerformer'
CREATE INDEX [IX_FK_FestivalPerformer]
ON [dbo].[Performers]
    ([FestivalId]);
GO

-- Creating foreign key on [FestivalId] in table 'Tickets'
ALTER TABLE [dbo].[Tickets]
ADD CONSTRAINT [FK_FestivalTicket]
    FOREIGN KEY ([FestivalId])
    REFERENCES [dbo].[Festivals]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FestivalTicket'
CREATE INDEX [IX_FK_FestivalTicket]
ON [dbo].[Tickets]
    ([FestivalId]);
GO

-- Creating foreign key on [Performers_Id] in table 'PerformerTicket'
ALTER TABLE [dbo].[PerformerTicket]
ADD CONSTRAINT [FK_PerformerTicket_Performer]
    FOREIGN KEY ([Performers_Id])
    REFERENCES [dbo].[Performers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tickets_Id] in table 'PerformerTicket'
ALTER TABLE [dbo].[PerformerTicket]
ADD CONSTRAINT [FK_PerformerTicket_Ticket]
    FOREIGN KEY ([Tickets_Id])
    REFERENCES [dbo].[Tickets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerformerTicket_Ticket'
CREATE INDEX [IX_FK_PerformerTicket_Ticket]
ON [dbo].[PerformerTicket]
    ([Tickets_Id]);
GO

-- Creating foreign key on [Festival_Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_FestivalLocation]
    FOREIGN KEY ([Festival_Id])
    REFERENCES [dbo].[Festivals]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FestivalLocation'
CREATE INDEX [IX_FK_FestivalLocation]
ON [dbo].[Locations]
    ([Festival_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------