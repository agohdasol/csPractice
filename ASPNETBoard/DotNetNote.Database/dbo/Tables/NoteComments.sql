CREATE TABLE [dbo].[NoteComments] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [BoardName] NVARCHAR (50)   NULL,
    [BoardId]   INT             NOT NULL,
    [Name]      NVARCHAR (25)   NOT NULL,
    [Opinion]   NVARCHAR (4000) NOT NULL,
    [PostDate]  SMALLDATETIME   DEFAULT (getdate()) NULL,
    [Password]  NVARCHAR (20)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

