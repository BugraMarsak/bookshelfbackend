CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [UserId]           VARCHAR (50) NOT NULL,
    [OperationClaimId] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

