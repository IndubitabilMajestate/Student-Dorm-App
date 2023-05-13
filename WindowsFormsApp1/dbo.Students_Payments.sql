CREATE TABLE [dbo].[Students_Payments] (
    [Student_Id]  INT           NOT NULL,
    [Payment_Id]  INT           IDENTITY (1, 1) NOT NULL,
    [Paid]        BIT           NOT NULL ,
    [PaymentDate] DATE          NOT NULL,
    [PaymentType] NVARCHAR (50) NOT NULL,
    [SumToPay]    INT           NULL,
    PRIMARY KEY CLUSTERED ([Payment_Id] ASC),
    CONSTRAINT [FK_Students_paysid] FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Students] ([Id])
);

