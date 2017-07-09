CREATE TABLE [dbo].[LookupDayOfWeeks] (
    [DayOfWeekID] INT          IDENTITY (1, 1) NOT NULL,
    [DayOfWeek]   VARCHAR (50) CONSTRAINT [DF_LookupDayOfWeeks_DayOfWeek] DEFAULT ('') NOT NULL,
    [IsWeekDay]   BIT          CONSTRAINT [DF_LookupDayOfWeeks_IsWeekDay] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_LookupDayOfWeeks] PRIMARY KEY CLUSTERED ([DayOfWeekID] ASC)
);

