CREATE TABLE [dbo].[PublicHolidays] (
    [PublicHolidayID]   INT         IDENTITY (1, 1) NOT NULL,
    [PublicHolidayDate] DATE        CONSTRAINT [DF_PublicHolidays_PublicHolidayDate] DEFAULT (getdate()) NOT NULL,
    [PublicHolidayYear] VARCHAR (4) CONSTRAINT [DF_PublicHolidays_PublicHolidayYear] DEFAULT ((2017)) NOT NULL,
    CONSTRAINT [PK_PublicHolidays] PRIMARY KEY CLUSTERED ([PublicHolidayID] ASC)
);

