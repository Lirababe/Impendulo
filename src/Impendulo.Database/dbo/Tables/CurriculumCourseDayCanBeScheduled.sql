CREATE TABLE [dbo].[CurriculumCourseDayCanBeScheduled] (
    [CurriculumCourseDayCanBeScheduledID] INT      IDENTITY (1, 1) NOT NULL,
    [DayOfWeekID]                         INT      NOT NULL,
    [CurriculumCourseID]                  INT      NOT NULL,
    [StartTime]                           TIME (7) NOT NULL,
    [EndTime]                             TIME (7) NOT NULL,
    CONSTRAINT [PK_CurriculumCourseDayCanBeScheduled] PRIMARY KEY CLUSTERED ([CurriculumCourseDayCanBeScheduledID] ASC),
    CONSTRAINT [FK_CurriculumCourseDayCanBeScheduled_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CurriculumCourseDayCanBeScheduled_LookupDayOfWeeks] FOREIGN KEY ([DayOfWeekID]) REFERENCES [dbo].[LookupDayOfWeeks] ([DayOfWeekID])
);

