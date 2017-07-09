
CREATE PROCEDURE GetCurriculumCoursePreRequisiteCourse
--GetCurriculumCoursePreRequisiteCourse 4142,6060
	@CurriculumID int, --4142
	@EnrollmentID int --6060
AS
--set @CurriculumID = 4142;
--set @EnrollmentID = 6060;

	WITH CoursePiorirty(CurriculumCourseID, CurriculumCourseParentID, CurriculumID,CourseID,EnrollmentTypeID,Duration,Cost,  ComponentLevel) AS
(

SELECT  b.[CurriculumCourseID]
      ,b.[CurriculumCourseParentID]
      ,b.[CurriculumID]
      ,b.[CourseID]
      ,b.[EnrollmentTypeID]
      ,b.[Duration]
      ,b.[Cost],
	  0 AS ComponentLevel
  FROM [CurriculumCourses] b
  where 
  --b.[CurriculumID] = 1 and
   [CurriculumCourseID] = @CurriculumID 

  Union ALL

  SELECT  c.[CurriculumCourseID]
      ,c.[CurriculumCourseParentID]
      ,c.[CurriculumID]
      ,c.[CourseID]
      ,c.[EnrollmentTypeID]
      ,c.[Duration]
      ,c.[Cost],
	 ComponentLevel + 1
  FROM [CurriculumCourses] c
  inner join CoursePiorirty CP
  on CP.CurriculumCourseParentID = c.CurriculumCourseID    
)

select CurriculumCourseID, CurriculumCourseParentID, CurriculumID,CourseID,EnrollmentTypeID,Duration,Cost, ComponentLevel
from CoursePiorirty CP
where  CurriculumCourseID not in (@CurriculumID) and CurriculumCourseID in (
											SELECT          CurriculumCourseID
											FROM            CurriculumCourseEnrollments d
											WHERE        (d.EnrollmentID = @EnrollmentID) AND d.CurriculumCourseEnrollmentID not in (
																									
																									SELECT         CurriculumCourseEnrollmentID 
																											FROM            Schedules s
																											WHERE        (s.EnrollmentID = @EnrollmentID)
																									))
order by ComponentLevel desc;