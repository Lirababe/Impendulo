CREATE TABLE [dbo].[ScheduledVenues] (
    [ScheduleID] INT NOT NULL,
    [VenueID]    INT NOT NULL,
    CONSTRAINT [PK_ScheduledVenues] PRIMARY KEY CLUSTERED ([ScheduleID] ASC, [VenueID] ASC),
    CONSTRAINT [FK_ScheduledVenues_Schedules] FOREIGN KEY ([ScheduleID]) REFERENCES [dbo].[Schedules] ([ScheduleID]),
    CONSTRAINT [FK_ScheduledVenues_Venues] FOREIGN KEY ([VenueID]) REFERENCES [dbo].[Venues] ([VenueID])
);

