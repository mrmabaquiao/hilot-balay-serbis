
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/23/2015 22:20:40
-- Generated from EDMX file: D:\Projects\HomeServiceV1\HomeService.Domain\HomeServiceDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HomeService];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProfessionProfileProfession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfileProfessions] DROP CONSTRAINT [FK_ProfessionProfileProfession];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contacts] DROP CONSTRAINT [FK_ProfileContact];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileProfileProfession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfileProfessions] DROP CONSTRAINT [FK_ProfileProfileProfession];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[Professions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Professions];
GO
IF OBJECT_ID(N'[dbo].[ProfileProfessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfileProfessions];
GO
IF OBJECT_ID(N'[dbo].[Profiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profiles];
GO
IF OBJECT_ID(N'[HomeServiceModelStoreContainer].[vw_GetProfileDetails]', 'U') IS NOT NULL
    DROP TABLE [HomeServiceModelStoreContainer].[vw_GetProfileDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
    [ProfileId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Professions'
CREATE TABLE [dbo].[Professions] (
    [ProfessionId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [ContactId] int IDENTITY(1,1) NOT NULL,
    [ContactNumber] nvarchar(max)  NOT NULL,
    [IsDefault] bit  NOT NULL,
    [ProfileId] int  NOT NULL
);
GO

-- Creating table 'ProfileProfessions'
CREATE TABLE [dbo].[ProfileProfessions] (
    [ProfileProfessionId] int IDENTITY(1,1) NOT NULL,
    [ProfileId] int  NOT NULL,
    [ProfessionId] int  NOT NULL
);
GO

-- Creating table 'vw_GetProfileDetails'
CREATE TABLE [dbo].[vw_GetProfileDetails] (
    [ProfileId] int  NOT NULL,
    [ProfileName] nvarchar(max)  NOT NULL,
    [ContactNumber] nvarchar(max)  NOT NULL,
    [Profession] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProfileId] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([ProfileId] ASC);
GO

-- Creating primary key on [ProfessionId] in table 'Professions'
ALTER TABLE [dbo].[Professions]
ADD CONSTRAINT [PK_Professions]
    PRIMARY KEY CLUSTERED ([ProfessionId] ASC);
GO

-- Creating primary key on [ContactId] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([ContactId] ASC);
GO

-- Creating primary key on [ProfileProfessionId] in table 'ProfileProfessions'
ALTER TABLE [dbo].[ProfileProfessions]
ADD CONSTRAINT [PK_ProfileProfessions]
    PRIMARY KEY CLUSTERED ([ProfileProfessionId] ASC);
GO

-- Creating primary key on [ProfileId], [ProfileName], [ContactNumber], [Profession] in table 'vw_GetProfileDetails'
ALTER TABLE [dbo].[vw_GetProfileDetails]
ADD CONSTRAINT [PK_vw_GetProfileDetails]
    PRIMARY KEY CLUSTERED ([ProfileId], [ProfileName], [ContactNumber], [Profession] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProfileId] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [FK_ProfileContact]
    FOREIGN KEY ([ProfileId])
    REFERENCES [dbo].[Profiles]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileContact'
CREATE INDEX [IX_FK_ProfileContact]
ON [dbo].[Contacts]
    ([ProfileId]);
GO

-- Creating foreign key on [ProfileId] in table 'ProfileProfessions'
ALTER TABLE [dbo].[ProfileProfessions]
ADD CONSTRAINT [FK_ProfileProfileProfession]
    FOREIGN KEY ([ProfileId])
    REFERENCES [dbo].[Profiles]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileProfileProfession'
CREATE INDEX [IX_FK_ProfileProfileProfession]
ON [dbo].[ProfileProfessions]
    ([ProfileId]);
GO

-- Creating foreign key on [ProfessionId] in table 'ProfileProfessions'
ALTER TABLE [dbo].[ProfileProfessions]
ADD CONSTRAINT [FK_ProfessionProfileProfession]
    FOREIGN KEY ([ProfessionId])
    REFERENCES [dbo].[Professions]
        ([ProfessionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfessionProfileProfession'
CREATE INDEX [IX_FK_ProfessionProfileProfession]
ON [dbo].[ProfileProfessions]
    ([ProfessionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------