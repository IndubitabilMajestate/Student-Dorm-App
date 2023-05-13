CREATE TABLE [dbo].[WashroomReservations] (
    [IdReservation] INT      IDENTITY (1, 1) NOT NULL,
    [RoomNumber]    INT      NOT NULL,
    [DateOfRes]     DATETIME NOT NULL,
    [TimeOfRes]     DATETIME NOT NULL,
    [Floor]         INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([IdReservation] ASC),
    CONSTRAINT [FK_Studentsrooms_Washroom] FOREIGN KEY ([RoomNumber]) REFERENCES [dbo].[Students_Rooms] ([Room]),
	CONSTRAINT unique_reservation_constraint UNIQUE (RoomNumber, DateOfRes, TimeOfRes, Floor),
);


GO

CREATE INDEX [nonuniquedate] ON [dbo].[WashroomReservations] ([DateOfRes])
