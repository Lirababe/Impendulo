CREATE TABLE [dbo].[CompanyAssociatedSchedules] (
    [ScheduleID] INT NOT NULL,
    [CompanyID]  INT NOT NULL,
    CONSTRAINT [PK_CompanyAssociatedSchedules] PRIMARY KEY CLUSTERED ([ScheduleID] ASC, [CompanyID] ASC),
    CONSTRAINT [FK_CompanyAssociatedSchedules_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyAssociatedSchedules_Schedules] FOREIGN KEY ([ScheduleID]) REFERENCES [dbo].[Schedules] ([ScheduleID])
);

