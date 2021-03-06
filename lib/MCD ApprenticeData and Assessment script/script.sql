
/****** Object:  Table [dbo].[Activities]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[ActivityID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleID] [int] NOT NULL,
	[ActivityCode] [varchar](20) NOT NULL,
	[ActivitiyDescription] [varchar](2000) NOT NULL,
 CONSTRAINT [PK_Activities] PRIMARY KEY CLUSTERED 
(
	[ActivityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[AddressTypeID] [int] NOT NULL,
	[CountryID] [int] NOT NULL,
	[ProvinceID] [int] NOT NULL,
	[AddressLineOne] [varchar](100) NOT NULL,
	[AddressLineTwo] [varchar](100) NOT NULL,
	[AddressTown] [varchar](50) NOT NULL,
	[AddressSuburb] [varchar](50) NOT NULL,
	[AddressAreaCode] [varchar](10) NOT NULL,
	[AddressIsDefault] [bit] NOT NULL,
	[AddressModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ApprienticeshipEnrollmentPaymentConfirmations]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApprienticeshipEnrollmentPaymentConfirmations](
	[ApprienticeshipPaymentConfirmationID] [int] IDENTITY(1,1) NOT NULL,
	[EnrollmentID] [int] NOT NULL,
	[ImageID] [int] NOT NULL,
	[DateLastUpdated] [datetime] NOT NULL,
 CONSTRAINT [PK_EngineeringEnrollmentPaymentConfirmations] PRIMARY KEY CLUSTERED 
(
	[ApprienticeshipPaymentConfirmationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ApprienticeshipEnrollments]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApprienticeshipEnrollments](
	[EnrollmentID] [int] NOT NULL,
	[LookupSectionalEnrollmentTypeID] [int] NOT NULL,
 CONSTRAINT [PK_ApprienticeshipEnrollments] PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Assessors]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assessors](
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_Assessors] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComapnyContacts]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComapnyContacts](
	[IndividualID] [int] NOT NULL,
	[CompanyID] [int] NOT NULL,
 CONSTRAINT [PK_ComapnyContacts_1] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC,
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Companies]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[CompanySETANumber] [varchar](50) NOT NULL,
	[CompanySicCode] [varchar](50) NOT NULL,
	[CompanySARSLevyRegistrationNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompanyAddresses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyAddresses](
	[CompanyID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_CompanyAddresses_1] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompanyContactDetails]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyContactDetails](
	[CompanyID] [int] NOT NULL,
	[ContactDetailID] [int] NOT NULL,
 CONSTRAINT [PK_CompanyContactDetails] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[ContactDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompanyEnquiry]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyEnquiry](
	[EnquiryID] [int] NOT NULL,
	[CompanyID] [int] NOT NULL,
 CONSTRAINT [PK_CompanyEnquiry] PRIMARY KEY CLUSTERED 
(
	[EnquiryID] ASC,
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[ContactDetailID] [int] IDENTITY(1,1) NOT NULL,
	[ContactDetailValue] [varchar](100) NOT NULL,
	[ContactTypeID] [int] NOT NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[ContactDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CostingModels]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CostingModels](
	[CostingModelID] [int] IDENTITY(1,1) NOT NULL,
	[CostingModelName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CostingModels] PRIMARY KEY CLUSTERED 
(
	[CostingModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseCategories]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseCategories](
	[CourseCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CourseCategoryName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CourseCategories] PRIMARY KEY CLUSTERED 
(
	[CourseCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[CourseName] [varchar](250) NOT NULL,
	[CourseDescription] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Courses_2] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseSchedules]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseSchedules](
	[CourseScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[IndividualID] [int] NOT NULL,
	[CourseScheduleStartDate] [date] NOT NULL,
	[CourseScheduleEndDate] [date] NOT NULL,
 CONSTRAINT [PK_CourseSchedules] PRIMARY KEY CLUSTERED 
(
	[CourseScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurricullumCourseCodes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurricullumCourseCodes](
	[CurriculumCourseID] [int] NOT NULL,
	[CurricullumCourseCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CurricullumCourseCodes] PRIMARY KEY CLUSTERED 
(
	[CurriculumCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCourseAssociatedSetas]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCourseAssociatedSetas](
	[SetaID] [int] NOT NULL,
	[CurriculumCourseID] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumCourseAssociatedSetas] PRIMARY KEY CLUSTERED 
(
	[SetaID] ASC,
	[CurriculumCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCourseEnrollments]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCourseEnrollments](
	[CurriculumCourseEnrollmentID] [int] IDENTITY(1,1) NOT NULL,
	[CurriculumCourseID] [int] NOT NULL,
	[EnrollmentID] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumCourseEnrollments] PRIMARY KEY CLUSTERED 
(
	[CurriculumCourseEnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCourseMinimumMaximums]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCourseMinimumMaximums](
	[CurriculumCourseID] [int] NOT NULL,
	[CurriculumCourseMinimum] [int] NOT NULL,
	[CurriculumCourseMaximum] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumCourseMinimumMaximums_1] PRIMARY KEY CLUSTERED 
(
	[CurriculumCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCourseModuleActivities]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCourseModuleActivities](
	[CurriculumCourseModuleID] [int] NOT NULL,
	[ActivityID] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumCourseModuleActivities] PRIMARY KEY CLUSTERED 
(
	[CurriculumCourseModuleID] ASC,
	[ActivityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCourseModules]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCourseModules](
	[CurriculumCourseModuleID] [int] IDENTITY(1,1) NOT NULL,
	[CurriculumCourseID] [int] NOT NULL,
	[ModuleID] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumCourseModules] PRIMARY KEY CLUSTERED 
(
	[CurriculumCourseModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCoursePredecessors]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCoursePredecessors](
	[CurriculumCoursePredecessorID] [int] IDENTITY(1,1) NOT NULL,
	[CurriculumCourseID] [int] NOT NULL,
	[PredecessorCurriculumCourseID] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumCoursePredecessors] PRIMARY KEY CLUSTERED 
(
	[CurriculumCoursePredecessorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumCourses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumCourses](
	[CurriculumCourseID] [int] IDENTITY(1,1) NOT NULL,
	[CurriculumCourseParentID] [int] NOT NULL,
	[CurriculumID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[EnrollmentTypeID] [int] NOT NULL,
	[Duration] [int] NOT NULL,
	[Cost] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_CurriculumCourses] PRIMARY KEY CLUSTERED 
(
	[CurriculumCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumEnquiries]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumEnquiries](
	[CurriculumEnquiryID] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryID] [int] NOT NULL,
	[CurriculumID] [int] NOT NULL,
	[EnquiryStatusID] [int] NOT NULL,
	[EnrollmentQuanity] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumEnquiries] PRIMARY KEY CLUSTERED 
(
	[CurriculumEnquiryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Curriculums]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curriculums](
	[CurriculumID] [int] IDENTITY(1,1) NOT NULL,
	[CostingModelID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[CurriculumName] [varchar](100) NOT NULL,
	[CurriculumIsSequenced] [bit] NOT NULL,
 CONSTRAINT [PK_Curriculums_1] PRIMARY KEY CLUSTERED 
(
	[CurriculumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepartmentResponsibleEmployees]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentResponsibleEmployees](
	[DepartmentID] [int] NOT NULL,
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_DepartmentResponsibleEmployees] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC,
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmailMessageRepository]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailMessageRepository](
	[EmailMessageRepositoryID] [int] IDENTITY(1,1) NOT NULL,
	[FromAddress] [varchar](250) NOT NULL,
	[ToAddress] [varchar](500) NOT NULL,
	[Subject] [varchar](250) NOT NULL,
	[Message] [varchar](max) NOT NULL,
 CONSTRAINT [PK_EmailMessageRepository] PRIMARY KEY CLUSTERED 
(
	[EmailMessageRepositoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmailMessageRepositoryAttachments]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailMessageRepositoryAttachments](
	[EmailMessageRepositoryAttachmentID] [int] IDENTITY(1,1) NOT NULL,
	[EmailMessageRepositoryID] [int] NOT NULL,
	[EmailAttachment] [image] NOT NULL,
 CONSTRAINT [PK_EmailMessageRepositoryAttachments] PRIMARY KEY CLUSTERED 
(
	[EmailMessageRepositoryAttachmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmailSystemOutGoingMessageAttachments]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailSystemOutGoingMessageAttachments](
	[EmailSystemOutGoingMessageAttachmentID] [int] IDENTITY(1,1) NOT NULL,
	[EmailSystemOutGoingMessageID] [int] NOT NULL,
	[AttachementImage] [image] NULL,
 CONSTRAINT [PK_EmailSystemOutGoingMessageAttachments] PRIMARY KEY CLUSTERED 
(
	[EmailSystemOutGoingMessageAttachmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmailSystemOutGoingMessages]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailSystemOutGoingMessages](
	[EmailSystemOutGoingMessageID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_EmailSystemOutGoingMessages] PRIMARY KEY CLUSTERED 
(
	[EmailSystemOutGoingMessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[IndividualID] [int] NOT NULL,
	[EmployeeNumber] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Enquiry]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enquiry](
	[EnquiryID] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryDate] [date] NOT NULL,
 CONSTRAINT [PK_Enquiry] PRIMARY KEY CLUSTERED 
(
	[EnquiryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[EnrollmentID] [int] IDENTITY(1,1) NOT NULL,
	[LookupEnrollmentProgressStateID] [int] NOT NULL,
	[CurriculumID] [int] NOT NULL,
	[DateIntitiated] [date] NOT NULL,
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_Enrollments] PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EquiryAssociatedContacts]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquiryAssociatedContacts](
	[IndividualID] [int] NOT NULL,
	[EnquiryID] [int] NOT NULL,
 CONSTRAINT [PK_EquiryAssociatedContacts] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC,
	[EnquiryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EquiryHistory]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquiryHistory](
	[EnqueryHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryID] [int] NOT NULL,
	[IndividualID] [int] NOT NULL,
	[LookupEquiyHistoryTypeID] [int] NOT NULL,
	[DateEnquiryUpdated] [datetime] NOT NULL,
	[EnquiryNotes] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_EquiryHistory] PRIMARY KEY CLUSTERED 
(
	[EnqueryHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacilitatorAssociatedCourses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacilitatorAssociatedCourses](
	[FacilitatorAssociatedCourseID] [int] IDENTITY(1,1) NOT NULL,
	[IndividualID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_FacilitatorAssociatedCourses] PRIMARY KEY CLUSTERED 
(
	[FacilitatorAssociatedCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacilitatorQualifications]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacilitatorQualifications](
	[FacilitatorQualificationID] [int] IDENTITY(1,1) NOT NULL,
	[QualificationID] [int] NOT NULL,
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_FacilitatorQualifications] PRIMARY KEY CLUSTERED 
(
	[FacilitatorQualificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facilitators]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facilitators](
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_Facilitator] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacilitatorSetaAccreditations]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacilitatorSetaAccreditations](
	[FacilitatorSetaAccreditationID] [int] IDENTITY(1,1) NOT NULL,
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_FacilitatorSetaAccreditations] PRIMARY KEY CLUSTERED 
(
	[FacilitatorSetaAccreditationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Files]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Files](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ContentType] [varchar](50) NOT NULL,
	[FileImage] [image] NOT NULL,
	[FileName] [varchar](100) NOT NULL,
	[FileExtension] [varchar](5) NULL,
	[DateCreated] [date] NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IndividualAddresses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndividualAddresses](
	[AddressID] [int] NOT NULL,
	[IndividualID] [int] NOT NULL,
 CONSTRAINT [PK_IndividualAddresses_1] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC,
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IndividualContactDetails]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndividualContactDetails](
	[IndividualID] [int] NOT NULL,
	[ContactDetailID] [int] NOT NULL,
 CONSTRAINT [PK_IndividualContactDetails_1] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC,
	[ContactDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Individuals]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Individuals](
	[IndividualID] [int] IDENTITY(1,1) NOT NULL,
	[TitleID] [int] NOT NULL,
	[IndividualFirstName] [varchar](30) NOT NULL,
	[IndividualSecondName] [varchar](30) NOT NULL,
	[IndividualLastname] [varchar](30) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Individuals] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[IndividualID] [int] NOT NULL,
	[DateLastChanged] [datetime] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupAddressTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupAddressTypes](
	[AddressTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AddressType] [varchar](25) NOT NULL,
 CONSTRAINT [PK_LookupAddressTypes] PRIMARY KEY CLUSTERED 
(
	[AddressTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupContactTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupContactTypes](
	[ContactTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ContactType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupContactTypes] PRIMARY KEY CLUSTERED 
(
	[ContactTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupCountries]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupCountries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](50) NOT NULL,
	[CountryCode] [varchar](10) NOT NULL,
 CONSTRAINT [PK_LookupCountries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupDepartments]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupDepartments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Departments_1] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupDisabilities]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupDisabilities](
	[DisabilityID] [int] IDENTITY(1,1) NOT NULL,
	[Disability] [varchar](25) NOT NULL,
 CONSTRAINT [PK_LookupDisabilities] PRIMARY KEY CLUSTERED 
(
	[DisabilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEnquiryStartDateTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEnquiryStartDateTypes](
	[EnquiryStartDateTypeID] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryStartDateType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupEnquiryStartDateTypes] PRIMARY KEY CLUSTERED 
(
	[EnquiryStartDateTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEnquiryStatuses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEnquiryStatuses](
	[EnquiryStatusID] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryStatus] [varchar](100) NOT NULL,
 CONSTRAINT [PK_LookupEnquiryStatuses] PRIMARY KEY CLUSTERED 
(
	[EnquiryStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEnquiryTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEnquiryTypes](
	[EnquiryTypeID] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupEnquiryTypes] PRIMARY KEY CLUSTERED 
(
	[EnquiryTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEnrollmentProgressStates]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEnrollmentProgressStates](
	[LookupEnrollmentProgressStateID] [int] IDENTITY(1,1) NOT NULL,
	[EnrollmentProgressCurrentState] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupEnrollmentProgressStates] PRIMARY KEY CLUSTERED 
(
	[LookupEnrollmentProgressStateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEnrollmentTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEnrollmentTypes](
	[EnrollmentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[EnrollmentType] [varchar](50) NULL,
 CONSTRAINT [PK_LookupEnrollmentTypes] PRIMARY KEY CLUSTERED 
(
	[EnrollmentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEquiryHistoryTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEquiryHistoryTypes](
	[LookupEquiyHistoryTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LookupEquiyHistoryTypeName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupEquiyHistoryTypes] PRIMARY KEY CLUSTERED 
(
	[LookupEquiyHistoryTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupEthnicities]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupEthnicities](
	[EthnicityID] [int] IDENTITY(1,1) NOT NULL,
	[Ethnicity] [varchar](25) NULL,
 CONSTRAINT [PK_LookupEthnicity] PRIMARY KEY CLUSTERED 
(
	[EthnicityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupGenders]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupGenders](
	[GenderID] [int] IDENTITY(1,1) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
 CONSTRAINT [PK_LookupGenders] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupMartialStatuses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupMartialStatuses](
	[MartialStatusID] [int] IDENTITY(1,1) NOT NULL,
	[MaritialStatus] [varchar](25) NOT NULL,
 CONSTRAINT [PK_LookupMartialStatuses] PRIMARY KEY CLUSTERED 
(
	[MartialStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupProvinces]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupProvinces](
	[ProvinceID] [int] IDENTITY(1,1) NOT NULL,
	[Province] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupProvinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupQualificationLevels]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupQualificationLevels](
	[QualificationLevelID] [int] IDENTITY(1,1) NOT NULL,
	[QualificationLevel] [varchar](100) NOT NULL,
 CONSTRAINT [PK_LookupQualifications] PRIMARY KEY CLUSTERED 
(
	[QualificationLevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupSectionalEnrollmentTypes]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupSectionalEnrollmentTypes](
	[LookupSectionalEnrollmentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LookupSectionalEnrollmentType] [varchar](50) NULL,
 CONSTRAINT [PK_LookupSectionalEnrollmentTypes] PRIMARY KEY CLUSTERED 
(
	[LookupSectionalEnrollmentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupSetas]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupSetas](
	[SetaID] [int] IDENTITY(1,1) NOT NULL,
	[SetsName] [varchar](50) NOT NULL,
	[SetaAbbriviation] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Setas] PRIMARY KEY CLUSTERED 
(
	[SetaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupTitles]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupTitles](
	[TitleID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](25) NOT NULL,
 CONSTRAINT [PK_LookupTitles] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LookupTypeOfRelations]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LookupTypeOfRelations](
	[TypeOfRelationID] [int] IDENTITY(1,1) NOT NULL,
	[TypeOfRelation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LookupTypeOfRelations] PRIMARY KEY CLUSTERED 
(
	[TypeOfRelationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Modules]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modules](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[ModuleName] [varchar](100) NULL,
 CONSTRAINT [PK_Modules] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NextOfKins]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NextOfKins](
	[IndividualID] [int] NOT NULL,
	[TypeOfRelationID] [int] NOT NULL,
 CONSTRAINT [PK_NextOfKins_1] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OldModules]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OldModules](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleName] [varchar](100) NULL,
	[ModuleDescription] [varchar](2000) NULL,
 CONSTRAINT [PK_OldModules] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Qualifications]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qualifications](
	[QualificationID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Qualifications] PRIMARY KEY CLUSTERED 
(
	[QualificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleStartDate] [date] NOT NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SMTPSettings]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SMTPSettings](
	[SmtpSettingID] [int] IDENTITY(1,1) NOT NULL,
	[PortNumber] [int] NOT NULL,
	[SMTPHost] [varchar](100) NOT NULL,
	[RequireAuthentication] [bit] NOT NULL,
	[RequiresSSL] [bit] NOT NULL,
	[FromAddress] [varchar](100) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[DisplayName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SMTPSettings] PRIMARY KEY CLUSTERED 
(
	[SmtpSettingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentAssociatedCompany]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAssociatedCompany](
	[StudentAssosiatedCompanyID] [int] IDENTITY(1,1) NOT NULL,
	[IndividualID] [int] NOT NULL,
	[CompanyID] [int] NOT NULL,
	[IsCurrentCompany] [bit] NOT NULL,
 CONSTRAINT [PK_StudentAssociatedCompany] PRIMARY KEY CLUSTERED 
(
	[StudentAssosiatedCompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentDisabilities]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentDisabilities](
	[StudentDisabilityID] [int] IDENTITY(1,1) NOT NULL,
	[IndividualID] [int] NOT NULL,
	[DisabilityID] [int] NOT NULL,
	[StudentDisabilityNotes] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_StudentDisabilities] PRIMARY KEY CLUSTERED 
(
	[StudentDisabilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentNextOfKins]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentNextOfKins](
	[StudentID] [int] NOT NULL,
	[NextOfKinID] [int] NOT NULL,
 CONSTRAINT [PK_StudentNextOfKins] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[NextOfKinID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[IndividualID] [int] NOT NULL,
	[QualificationLevelID] [int] NOT NULL,
	[MartialStatusID] [int] NOT NULL,
	[GenderID] [int] NOT NULL,
	[EthnicityID] [int] NOT NULL,
	[StudentIDNumber] [varchar](15) NOT NULL,
	[StudentCurrentPosition] [varchar](50) NOT NULL,
	[StudentlInitialDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[IndividualID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SystemAdministrator]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemAdministrator](
	[SystemAdministratorID] [int] NOT NULL,
	[SystemUserName] [varchar](50) NOT NULL,
	[SystemUserPassword] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SystemAdministrator] PRIMARY KEY CLUSTERED 
(
	[SystemAdministratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[test]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[id] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VenueAssociatedCurriculumCourses]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VenueAssociatedCurriculumCourses](
	[VenueAssociatedCurriculumCourseID] [int] IDENTITY(1,1) NOT NULL,
	[VenueID] [int] NOT NULL,
	[CurriculumCourseID] [int] NOT NULL,
 CONSTRAINT [PK_VenueAssociatedCurriculumCourses] PRIMARY KEY CLUSTERED 
(
	[VenueAssociatedCurriculumCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venues]    Script Date: 2017/04/07 11:26:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venues](
	[VenueID] [int] IDENTITY(1,1) NOT NULL,
	[Venue] [varchar](50) NOT NULL,
	[VenueMaxCapacity] [int] NOT NULL,
 CONSTRAINT [PK_Venues] PRIMARY KEY CLUSTERED 
(
	[VenueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Activities] ON 

INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1, 1, N'ID1', N'Recall applicable sections of the Manpower Training (Act No 56, 1981), with special reference to discipline and legal  responsibilities. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (2, 1, N'ID2', N'Recall terms and conditions of apprenticeship as Gazetted 26 July 1991.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (3, 2, N'SF1', N'Recall relevant regulations of the following Acts: Occupational Health and Safety Act (Act No 85, 1993) and Minerals Act and Regulations (Act No 50, 1991) ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (4, 2, N'SF2', N'Attend a standard industrial safety course accredited by the industry. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (5, 2, N'SF5', N'Identify relevant colour markings and symbolic safety signs.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (6, 2, N'SF6', N'Identify relevant colour codes for compressed gas cylinders.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (8, 3, N'MA1', N'Recall the terms, definitions and use of materials   pertaining to the trade with special reference to plates, tubes,   pipes and hollow sections')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (9, 3, N'MA2', N'Recall the physical properties and characteristics of metal. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (10, 3, N'MA3', N'Identify ferrous and non-ferrous metals.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (11, 3, N'MA7', N'Recall differences between ferrous, non-ferrous metals and non-metallic materials.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (12, 3, N'MA8', N'Identify steel profiles with respect to plates, chequer plate, angles, channels, RSJ; UB; UC; rounds, squares, hollow  sections, fasteners and flat bar.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (13, 5, N'MF2', N'Use and set a vernier - depth, inside and outside.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (14, 5, N'MF3', N'Use a tape measure and steel rule.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (15, 5, N'MF5', N'Use a machine level.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (16, 5, N'MF6', N'Use and set a vernier height gauge.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (17, 4, N'DS1', N'Recall terms and definitions pertaining to engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (18, 4, N'DS2', N'Interpret relevant symbols, abbreviations and tolerances.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (19, 4, N'DS7', N'Make free hand sketches including plan, front and side elevations.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (20, 4, N'DS8', N'Compile a material list from engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (21, 4, N'DS10', N'Identify surface textures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (22, 6, N'HT1', N'Identify measuring, checking, forming, cutting, marking and fastening tools and tooling aids.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (23, 6, N'HT2', N'Use measuring, checking, forming, cutting, marking and fastening tools and tooling aids.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (24, 6, N'HT3', N'Maintain measuring, checking, forming, cutting, marking and fastening tools and tooling  aids.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (25, 6, N'HT4', N'Use hand tools applicable to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (26, 7, N'WT1', N'Use fixed and portable drilling machines.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (27, 7, N'WT2', N'Use a fixed and portable grinding machines including replacing, setting, truing and ringing  of wheels.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (28, 7, N'WT3', N'Use a portable jig-saw.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (29, 7, N'WT17', N'Operate pneumatic and or electrical power tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (30, 7, N'WT21', N'Mount grinding stone to pedestal grinder. Maximum size:  250mm diameter wheel. RPM = 2 000')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (31, 7, N'WT22', N'Dress a grinding wheel.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (32, 8, N'MT9', N'Mark off a project applicable to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (33, 8, N'MO1', N'Mark off projects for manufacturing using all standard marking-off techniques and tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (34, 5, N'MF1', N'Use and set a micrometer - outside, depth, inside.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (35, 5, N'MF4', N'Use a calliper - inside and outside.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (38, 3, N'MA6', N'Handle materials and work pieces using chain blocks and overhead cranes by means of the correct lifting, stacking  and slinging methods and using tirfors for positioning work pieces.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (39, 10, N'BG2', N'Recall overhead crane hand signals.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (40, 10, N'BG3', N'Demonstrate overhead crane hand signals.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (41, 10, N'BG4', N'Use the following equipment: 
? chain block  :  2 ton max 
? coffin block  :  2 ton max 
? shackles  :  2 ton max 
? chain slings  :  2 ton max 
? wire rope slings  :  20mm diameter ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (42, 11, N'HS1', N'Fabricate a project applicable to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (43, 11, N'HS2', N'Sharpen chisels.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (44, 11, N'HS3', N'Sharpen drills')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (45, 11, N'HS4', N'Dress screwdrivers.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (46, 11, N'HS5', N'Sharpen punches.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (47, 11, N'HS6', N' Sharpen spikes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (48, 11, N'HS7', N'Sharpen marking-off tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (49, 11, N'HS8', N'Manufacture a project using the following techniques and material: filing, sawing, drilling, tapping, reaming. Material:  mild steel')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (50, 11, N'HS9', N'Harden and temper a centre punch.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (51, 12, N'KL1', N'Identify the following types of keys - gib-head, parallel, taper, feather, woodruff, and tangenial.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (52, 12, N'KL2', N'Manufacture a gib-head, parallel, taper and feather key.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (53, 12, N'KL3', N'Fit a gib-head, parallel, taper, feather key.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (54, 12, N'KL5', N'Remove a gib-head, parallel, taper and feather key.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (55, 12, N'KL6', N'Identify nuts and bolts')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (56, 12, N'KL7', N'Tighten nuts and bolts.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (57, 8, N'MT6', N'Mark off a seven-holed flange/coupling.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (58, 8, N'MT7', N'Mark off a five-holed flange/coupling.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (59, 8, N'MT8', N'Mark off a flange consisting of a centre hole.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (60, 5, N'MF7(14)', N'Use the following gauges: 
? telescopic 
? thread 
? feeler 
? double dial set indicator 
? belt tensioner   ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (61, 15, N'BE1', N'Identify plain metal bearing materials such as bronze, white metal, synthetic.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (62, 15, N'BE2', N'Identify solid, split and guide bearings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (63, 15, N'BE5', N'Make oil grooves and wedges.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (64, 15, N'BE6', N'Identify classes of bearings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (65, 15, N'BE7', N'Identify the following ball bearings - deep groove, angular contact, self-alignment and thrust.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (66, 15, N'BE8', N'Identify the following types of roller bearings - spherical, thrust, taper, and cylindrical.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (67, 15, N'BE9', N'Fit a bearing to a shaft using a hand operated press, sleeve, oil bath and or induction heater.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (68, 15, N'BE10', N'Remove a bearing from a shaft using a bearing puller or hand operated press.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (69, 15, N'BE11', N'Fit a spherical roller bearing and adaptor sleeve to a shaft.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (70, 15, N'BE12', N'Remove a spherical roller bearing from an adaptor sleeve and shaft.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (71, 15, N'BE13', N'Fit and remove a thrust bearing on a shaft (single direction).')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (72, 15, N'BE14', N'Fit a roller bearing on a shaft.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (73, 15, N'BE15', N'Recall types of bearing failures and their causes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (74, 14, N'LU1', N'Identify the following types of lubrication systems; force-feed, splash-feed and gravity feed.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (75, 14, N'LU2', N'Identify the following types of lubricants; oil, grease, copper compound, thread cutting compounds.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (76, 14, N'LU3', N'Diagnose faults in a force feed system.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (77, 14, N'LU4', N'Pack bearings with grease.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (78, 16, N'AS3', N'Identify the following types of fits on shafts and hole basis - clearance, transition, interference.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (80, 16, N'AS4', N'Fit a boss to a shaft with reference to clearance fit.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (81, 16, N'AS5', N'Fit a boss to a shaft with reference to transition fit.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (82, 16, N'AS6', N'Fit a boss to a shaft with reference to interference fit.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (83, 12, N'KL4', N'Install the following locking devices - lock-nuts, dowels, lock-plates, split pins, taper pins and wire method.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (84, 4, N'DS9', N'Identify type of fits from engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (85, 7, N'WT20', N'Use hand operated presses.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (86, 16, N'AS1', N'Dismantle a worm-wheel type reduction gearbox.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (87, 16, N'AS2', N'Assemble a worm-wheel type gearbox.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (88, 16, N'AS8', N'Fit seal and packing to mechanical components. e.g.: pumps, gearboxes, etc.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (89, 17, N'IM3', N'Install and level gearboxes, motors, machines and pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (90, 18, N'CP1', N'Identify the following types of couplings - flexible, rigid, slip couplings and universal couplings (carden shaft).')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (91, 18, N'CP2', N'Mount and align the following couplings: 
1. Flexible tyre coupling 
2. Rigid flange coupling 
3. Bibby tyre coupling 
4. Internal gear coupling.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (92, 18, N'CP7', N'Diagnose faults on the following couplings: fenner flex, rigid, bibby, and internal gear couplings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (93, 19, N'DR1', N'Identify the following types of drives - belt, gear, fluid and chain.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (94, 19, N'DR2', N'Identify A, B and C class V-belts.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (95, 19, N'DR3', N'Install and align a single belt-drive.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (96, 19, N'DR4', N'Install and align match-set belt drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (97, 19, N'DR5', N'Install and align chain drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (98, 19, N'DR7', N'Maintain belt drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (99, 19, N'DR8', N'Maintain gear drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (100, 19, N'DR9', N'Maintain chain drives.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (101, 19, N'DR10', N'Maintain a fluid drive.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (102, 19, N'DR11', N'Install jockey on V-belt and chain drive units.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (103, 20, N'BC1', N'Identify the following brake systems: 
? disc 
? thruster 
? electro-magnetic.')
GO
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (104, 20, N'BC2', N'Maintain disc brakes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (105, 20, N'BC3', N'Maintain thruster brakes - calliper type.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (106, 20, N'BC4', N'Maintain electro-magnetic brakes.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (107, 20, N'BC5', N'Identify centrifugal and multi-disc clutch systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (108, 20, N'BC7', N'Maintain a multi-disc clutch.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (109, 21, N'PU1', N'Identify the following types of pumps: 
? centrifugal 
? reciprocating 
? gear ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (110, 21, N'PU2', N'Define the terms positive and non positive displacement.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (111, 21, N'PU3', N'Install gland bush packing.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (112, 21, N'PU4', N'Install a mechanical seal.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (113, 21, N'PU5', N' Prime centrifugal, reciprocating and gear pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (114, 21, N'PU6', N'Diagnose faults on centrifugal, reciprocating and gear pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (115, 21, N'PU7', N'Interpret given flow diagrams and systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (116, 22, N'HY1', N'Interpret symbols and abbreviations.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (117, 22, N'HY2', N'Interpret elementary hydraulic circuit diagrams.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (118, 22, N'HY3', N'Identify the following hydraulic fluids: 
? petroleum based 
? emulsion based')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (119, 22, N'HY4', N'Install and maintain the following filters: 
? suction 
? pressure 
? return')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (120, 22, N'HY5', N'Install and maintain hydraulic tubing and fittings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (121, 22, N'HY6', N'Install and maintain flexible hydraulic hoses and fittings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (122, 22, N'HY7', N'Identify the following hydraulic pumps - vane, gear, and piston.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (123, 22, N'HY8', N'Install and maintain hydraulic pumps.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (124, 22, N'HY9', N'Service procedures of reservoir.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (125, 22, N'HY10', N'Install and maintain directional control, pressure and flow control valves.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (126, 22, N'HY11', N'Install and maintain hydraulic cylinders.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (127, 22, N'HY12', N'Identify and install accumulators.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (128, 22, N'HY13', N'Diagnose faults in basic hydraulic systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (129, 4, N'DS18', N'Compile material lists from hydraulic and pneumatic drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (130, 23, N'PN1', N'Interpret symbols and abbreviations.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (131, 23, N'PN2', N'Interpret pneumatic circuit diagrams.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (132, 23, N'PN3', N'Identify compressed air pipelines.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (133, 23, N'PN4', N'Install and maintain compressed air pipelines.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (134, 23, N'PN5', N'Install and maintain air service units.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (135, 23, N'PN6', N'Install and maintain cylinders.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (136, 23, N'PN7', N'Install and maintain directional control, flow control and pressure valves.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (137, 23, N'PN9', N'Testing of set safety valves.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (138, 23, N'PN10', N'Recall the service procedure for air receivers.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (139, 23, N'PN12', N'Diagnose faults in pneumatic systems.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (140, 11, N'HS10', N'Sharpen single point machine cutting tools.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (141, 24, N'CL1', N'Carry out routine inspection on centre lathe.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (142, 24, N'CL2', N'Compile a machining procedure.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (143, 24, N'CL3', N'Recall the parts of a centre lathe.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (144, 24, N'CL4', N'Set calibrated dials.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (145, 24, N'CL5', N'Set up a workpiece in a four-jaw chuck.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (146, 24, N'CL6', N'Identify types of cutting tools with reference to: 
(i) High speed toolbits 
(ii) Throw away bits (inserts tungsten carbide) ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (147, 24, N'CL7', N'Turn an external parallel workpiece.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (148, 24, N'CL8', N'Turn an internal parallel work piece.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (149, 24, N'CL9', N'Turn the following internal and external threads: 
(i)    "V" and acme / trapezoidal 
(ii)   Left hand and right hand 
(iii)  Single and two-start ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (150, 24, N'CL10', N'Turn an external and internal taper using a compound slide.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (151, 24, N'Cl11', N'Turn an external and internal radius.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (152, 24, N'CL12', N'Turn a work piece between centres.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (153, 24, N'CL13', N'Turn workpieces using fixed and travelling steadies.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (154, 5, N'MF8', N'Use a gear tooth vernier.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (155, 25, N'MM1', N'Carry out routine inspection on milling machine.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (156, 25, N'MM2', N'Compile a machining procedure.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (157, 25, N'MM3', N'Recall the parts of a universal milling machine.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (158, 25, N'MM4', N'Set calibrated dials.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (159, 25, N'MM5', N'Set up workpiece in a dividing head using a three-jaw chuck, and between centres.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (160, 25, N'MM6', N'Set up a work piece on a turntable.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (161, 25, N'MM7', N'Set up a workpiece in a machine vice.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (162, 25, N'MM8', N'Use a dividing head for simple and differential indexing.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (163, 25, N'MM10', N'Mount a universal head.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (164, 25, N'MM11', N'Identify high speed and tungsten cutting tools with reference to:
? Slot drills, Side and face cutters, End-mills, Slit-saws 
? Gear cutters, Ripping cutters, Face mills, Fly cutters ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (165, 25, N'MM12', N'Machine a spur gear.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (166, 25, N'MM13', N'Cut an external keyway.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (167, 25, N'MM14', N' Machine a hexagon.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (168, 25, N'MM15', N'Machine a cube using a machine vice.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (169, 25, N'MM16', N'Drill equal spaced holes on PCD''s.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (170, 25, N'MM17', N'Bore a hole.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (171, 25, N'MM18', N'Split a bush using a slit-saw.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (172, 25, N'MM19', N'Cut an internal keyway.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (173, 26, N'GC1', N'Identify and assemble gas cutting and heating equipment, including light up and shut-down procedures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (174, 26, N'GC2', N'Select nozzles and gas pressures for cutting and heating different materials of various thicknesses.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (175, 26, N'GC3', N'Hand cut and heat materials incidental to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (176, 2, N'SF3', N'Recall safety in welding and gas cutting.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (177, 27, N'GW10', N'Identify and set up oxygen-fuel gas welding equipment including light up, adjustment of gas pressures and shut  down procedures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (178, 27, N'GW11', N'Differentiate between brazing and gas welding consumables.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (179, 27, N'GW12', N'Prepare material for brazing and gas welding.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (180, 27, N'GW13', N'Braze and gas weld workpieces incidental to the trade.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (181, 28, N'AO1', N'Identify and set up AC and/or DC welding machines, equipment including starting up and shutting down  Procedures.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (182, 28, N'AO2', N'Differentiate between arc welding consumables.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (183, 28, N'AO3', N'Prepare material for arc welding.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (184, 28, N'AO4', N'Tack and arc weld workpieces incidental to the trade using manual metal arc welding techniques.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1036, 3, N'MA13', N'Recall characteristics of ferrous metals – mild steel and cast iron. ')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1037, 3, N'MA14', N'Recall characteristics of non-ferrous metals – copper, brass, aluminium, white metal and stainless steel.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1038, 4, N'DSE2', N'Recall symbols and abbreviations as used o engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1039, 4, N'DSE5', N'Interpret engineering drawings.')
INSERT [dbo].[Activities] ([ActivityID], [ModuleID], [ActivityCode], [ActivitiyDescription]) VALUES (1040, 8, N'MO2', N'Mark off a bus-bar.')
SET IDENTITY_INSERT [dbo].[Activities] OFF
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (7040, 2, 1, 2, N'24 Jonkershoek Street', N'', N'Sasolburg', N'Vaalpark', N'1948', 1, CAST(N'2017-03-08T10:55:56.510' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (7041, 2, 1, 3, N'sdgfsadfsadfSDFSADFSADF', N'sadfasd', N'sadfasdfsadf', N'sdfasd', N'123', 1, CAST(N'2017-03-10T15:05:55.747' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8003, 2, 1, 2, N'dfsadsffadsf', N'dfdsaf', N'dsfadsds', N'33333332', N'22222', 0, CAST(N'2017-03-09T20:06:41.237' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8004, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:09:55.307' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8005, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:10:14.497' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8006, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:12:22.023' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8007, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:13:53.570' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8008, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:16:02.877' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8009, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:18:38.313' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8010, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:21:30.803' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8011, 1, 1, 1, N'sdfvsdafasdfasdf', N'asdfasdfa', N'asdfasd', N'asdfasd', N'34324234', 0, CAST(N'2017-03-09T20:28:00.610' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8012, 1, 1, 1, N'', N'', N'', N'', N'34324234', 0, CAST(N'2017-03-09T20:33:32.977' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8013, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:34:37.637' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8014, 1, 1, 1, N'yyyyyy', N'', N'', N'', N'', 0, CAST(N'2017-03-09T20:38:09.267' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8015, 2, 1, 3, N'Testing', N'adfdas', N'sdfsda', N'sdfsfad', N'', 1, CAST(N'2017-03-10T10:00:00.637' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8016, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:13:18.247' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8017, 2, 1, 2, N'test', N'test', N'fdasfds', N'afdsf', N'1234', 1, CAST(N'2017-03-10T15:06:36.423' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8018, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:14:06.913' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8019, 1, 1, 1, N'ldkfgsalkjdfhdkajs', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:14:47.927' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8020, 1, 1, 1, N'dkjfhsdakjf', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:15:01.600' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8021, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:16:25.333' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8022, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T10:20:49.740' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8023, 2, 1, 2, N'24 jonkershoek Street', N'', N'Sasolburg', N'Vaalpark', N'1948', 1, CAST(N'2017-03-10T10:23:35.393' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8024, 1, 1, 1, N'sdfadsfdsf', N'', N'', N'', N'', 0, CAST(N'2017-03-10T14:34:48.433' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (8025, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-10T15:04:56.987' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9003, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:33:08.770' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9004, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:38:06.730' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9005, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:38:14.617' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9006, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-12T18:39:09.900' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9007, 1, 1, 2, N'8 Owen Horwood Street', N'', N'Sasolburb', N'Ext 11', N'1947', 0, CAST(N'2017-03-12T18:44:04.310' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9008, 1, 1, 1, N'', N'', N'', N'', N'', 0, CAST(N'2017-03-14T12:26:43.847' AS DateTime))
INSERT [dbo].[Addresses] ([AddressID], [AddressTypeID], [CountryID], [ProvinceID], [AddressLineOne], [AddressLineTwo], [AddressTown], [AddressSuburb], [AddressAreaCode], [AddressIsDefault], [AddressModifiedDate]) VALUES (9009, 2, 1, 1, N'fsdafsdafsadf', N'', N'', N'', N'', 1, CAST(N'2017-03-14T17:26:28.980' AS DateTime))
SET IDENTITY_INSERT [dbo].[Addresses] OFF
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (8056, 2004)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (9056, 2005)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (11051, 2004)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (11052, 2004)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (11073, 2017)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (11074, 2017)
INSERT [dbo].[ComapnyContacts] ([IndividualID], [CompanyID]) VALUES (11075, 2004)
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [CompanySETANumber], [CompanySicCode], [CompanySARSLevyRegistrationNumber]) VALUES (2004, N'Inspection & Specification Services(ISS)', N'90068521422', N'ABE7512-325', N'900685214')
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [CompanySETANumber], [CompanySicCode], [CompanySARSLevyRegistrationNumber]) VALUES (2005, N'Test Company', N'15253-220', N'50632586-1120', N'1111111')
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [CompanySETANumber], [CompanySicCode], [CompanySARSLevyRegistrationNumber]) VALUES (2017, N'Test Company', N'3452345', N'523453', N'3452345')
SET IDENTITY_INSERT [dbo].[Companies] OFF
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2004, 7040)
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2004, 8007)
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2004, 8010)
INSERT [dbo].[CompanyAddresses] ([CompanyID], [AddressID]) VALUES (2005, 8025)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2017, 10024)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2017, 10025)
INSERT [dbo].[CompanyContactDetails] ([CompanyID], [ContactDetailID]) VALUES (2017, 10026)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (59, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (60, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (61, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (62, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (63, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (64, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (65, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (66, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (71, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (72, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (73, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (86, 2005)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (87, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (88, 2005)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (89, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (91, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (92, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (93, 2017)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (94, 2004)
INSERT [dbo].[CompanyEnquiry] ([EnquiryID], [CompanyID]) VALUES (95, 2004)
SET IDENTITY_INSERT [dbo].[ContactDetails] ON 

INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10014, N'Brendanw@mweb.co.za', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10015, N'(082) 334-9956', 2)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10016, N'(016) 971-2259', 4)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10017, N'(086) 600-2259', 2007)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10018, N'mcsfrangipani@gmail.com', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10019, N'Brendanw@mweb.co.za', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10020, N'Test@provider.com', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10021, N'(082) 334-9956', 2)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10022, N'EmailTest@TestingItems.com', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10023, N'Testing@Somewhere.com', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10024, N'', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10025, N'(016) 971-2259', 4)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10026, N'(016) 971-2223', 2007)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10027, N'sadfasdfasd', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10028, N'jhfgkgkjjk', 1)
INSERT [dbo].[ContactDetails] ([ContactDetailID], [ContactDetailValue], [ContactTypeID]) VALUES (10029, N'sbunyambose@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[ContactDetails] OFF
SET IDENTITY_INSERT [dbo].[CostingModels] ON 

INSERT [dbo].[CostingModels] ([CostingModelID], [CostingModelName]) VALUES (1, N'Per Module')
INSERT [dbo].[CostingModels] ([CostingModelID], [CostingModelName]) VALUES (2, N'Per Day')
INSERT [dbo].[CostingModels] ([CostingModelID], [CostingModelName]) VALUES (3, N'Per Course')
SET IDENTITY_INSERT [dbo].[CostingModels] OFF
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1, 1004, N'NQF Level 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (2, 1004, N'NQF Level 3', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3, 1004, N'NQF Level 4', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (4, 2004, N'Orientation', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (5, 1005, N'Forklift', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (6, 2004, N'Measuring', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (7, 2004, N'Workshop Practice 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (8, 2005, N'short course 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (9, 1005, N'Mobile Crane C33', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (10, 1005, N'Mobile Crane C34', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1002, 2009, N'Recognition of Prior Learning (RPL)', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1003, 2004, N'Basic Lifting Techniques', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1004, 2004, N'Workshop Practice 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1005, 2004, N'Fitting', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1006, 2004, N'Bearings and Seals', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1007, 2004, N'Alignment', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1008, 2004, N'Pumps', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1009, 2004, N'Hydraulics and Pneumatics', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1010, 2004, N'Turning 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1011, 2004, N'Turning 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1012, 2004, N'Milling', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1013, 2004, N'Welding for Other Trades', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1014, 2004, N'Electrical 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1015, 2004, N'Electrical 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1018, 2004, N'AC & DC Machines', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1019, 2004, N'Wiring and Installations', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1020, 2004, N'Fault Finding', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1021, 2004, N'Electronics', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1022, 2004, N'PLC', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1023, 2009, N'Trade Test Readiness assessment (TTR)', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1024, 2009, N'Trade Test Gap training ( when not course aligned)', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1025, 2009, N'Trade Test Preparation - Fitter', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1026, 2009, N'Trade Test Preparation - Fitter and Turner', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1027, 2009, N'Trade Test Preparation -Turner', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1028, 2009, N'Trade Test Preparation - Electrician', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1029, 2009, N'Trade Test Preparation - Boilermaker', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1030, 2009, N'Trade Test Preparation - Weldr', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1031, 2009, N'Trade Test Preparation - Rigging', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (1032, 2009, N'Trade Test Preparation - Instumentation', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (2014, 2009, N'Trade Orientation - Fitter', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3014, 1006, N'Forklift - Capacity of 3000kg', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3015, 1006, N'Counter Balanced Lift Truck - F1 Capacity of 3000kg', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3016, 1006, N'Counter Balanced Lift Truck - F2 Capacity up to 7000kg', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3017, 2004, N'Machines', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3018, 2004, N'Boilermaking 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3019, 2004, N'Bilermaking 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3020, 2004, N'Developments and Structures', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3021, 2004, N'Development and Fabrication', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3022, 2004, N'AC / DC Machines', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3023, 2004, N'Wiring and Installations', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3024, 2004, N'Electronics', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3025, 2004, N'AC Machines', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3026, 2004, N'Instrumentation 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3027, 2004, N'Instrumentation 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3028, 2004, N'Slinging Tackle', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3029, 2004, N'Ropes', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3030, 2004, N'Lifting Tackle', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3031, 2004, N'Construction', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3032, 2004, N'Lifting Operation Training', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3034, 2004, N'Welding 1', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3035, 2004, N'Welding 2', N'')
INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (3036, 2004, N'Welding 3', N'')
SET IDENTITY_INSERT [dbo].[Courses] OFF
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (20, N'116254')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1022, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1023, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1028, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1029, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1030, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1031, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1032, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1033, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1034, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1035, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1036, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1037, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1038, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1039, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1040, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1041, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1042, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1043, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1044, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1045, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1046, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1047, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1048, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1049, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1050, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1051, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1052, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1053, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1054, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1055, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1056, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1057, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1058, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1059, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1060, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1062, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1063, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1064, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1065, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1066, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1067, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1068, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1069, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1070, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1071, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1072, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1073, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1074, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1075, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (1076, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2077, N'244365')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2078, N'244365')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2079, N'242974')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2080, N'242974')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2081, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2082, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2083, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2084, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2085, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2086, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2087, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2088, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2089, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2090, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2091, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2092, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2093, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2095, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2096, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2097, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2098, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2099, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2100, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2101, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2102, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2103, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2104, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2105, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2106, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2107, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2108, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2109, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2110, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2111, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2112, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2113, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2114, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2115, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2116, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2117, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2118, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2119, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2120, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2121, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2122, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2123, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2124, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2125, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2126, N'')
GO
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2127, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2128, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2129, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2130, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2131, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2132, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2133, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2134, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2135, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2136, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2137, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2138, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2139, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2140, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2141, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2142, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2143, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2144, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2145, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2146, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2147, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2148, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2149, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2150, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2151, N'')
INSERT [dbo].[CurricullumCourseCodes] ([CurriculumCourseID], [CurricullumCourseCode]) VALUES (2152, N'')
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1029)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1032)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1048)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (2, 1075)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (3, 1032)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (3, 1048)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (3, 1075)
INSERT [dbo].[CurriculumCourseAssociatedSetas] ([SetaID], [CurriculumCourseID]) VALUES (4, 1075)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (20, 2, 3)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1022, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1023, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1028, 1, 2)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1029, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1030, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1031, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1032, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1033, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1034, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1035, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1036, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1037, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1038, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1039, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1040, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1041, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1042, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1043, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1044, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1045, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1046, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1047, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1048, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1049, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1050, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1051, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1052, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1053, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1054, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1055, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1056, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1057, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1058, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1059, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1060, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1062, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1063, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1064, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1065, 1, 2)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1066, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1067, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1068, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1069, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1070, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1071, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1072, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1073, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1074, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1075, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (1076, 0, 0)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2077, 1, 4)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2078, 1, 1)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2079, 1, 4)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2080, 1, 1)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2081, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2082, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2083, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2084, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2085, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2086, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2087, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2088, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2089, 0, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2090, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2091, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2092, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2093, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2095, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2096, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2097, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2098, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2099, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2100, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2101, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2102, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2103, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2104, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2105, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2106, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2107, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2108, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2109, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2110, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2111, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2112, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2113, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2114, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2115, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2116, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2117, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2118, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2119, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2120, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2121, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2122, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2123, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2124, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2125, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2126, 1, 10)
GO
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2127, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2128, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2129, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2130, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2131, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2132, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2133, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2134, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2135, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2136, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2137, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2138, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2139, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2140, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2141, 1, 20)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2142, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2143, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2144, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2145, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2146, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2147, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2148, 1, 5)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2149, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2150, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2151, 1, 10)
INSERT [dbo].[CurriculumCourseMinimumMaximums] ([CurriculumCourseID], [CurriculumCourseMinimum], [CurriculumCourseMaximum]) VALUES (2152, 1, 10)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1069, 1)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1069, 2)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 3)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 4)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 5)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1070, 6)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 17)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 18)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 19)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 20)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1072, 21)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 22)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 23)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 24)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1074, 25)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 26)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 27)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 28)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 29)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1075, 30)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1076, 32)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1076, 33)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1077, 34)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1077, 35)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 38)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 39)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 40)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1078, 41)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 42)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 43)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 44)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 45)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 46)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 47)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 48)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 49)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1080, 50)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 51)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 52)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 53)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 54)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 55)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 56)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1081, 83)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1082, 57)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1082, 58)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1082, 59)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1083, 60)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 61)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 62)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 63)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 64)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 65)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 66)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 67)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 68)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 69)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 70)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 71)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 72)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1084, 73)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 78)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 80)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 81)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1086, 82)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1091, 1)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1091, 2)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 3)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 4)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 5)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (1092, 6)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (3091, 181)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (3091, 182)
INSERT [dbo].[CurriculumCourseModuleActivities] ([CurriculumCourseModuleID], [ActivityID]) VALUES (3091, 183)
SET IDENTITY_INSERT [dbo].[CurriculumCourseModules] ON 

INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1069, 1030, 1)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1070, 1030, 2)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1071, 1031, 3)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1072, 1031, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1073, 1031, 5)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1074, 1032, 6)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1075, 1032, 7)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1076, 1032, 8)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1077, 1032, 5)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1078, 1033, 10)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1080, 1034, 11)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1081, 1035, 12)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1082, 1035, 8)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1083, 1035, 5)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1084, 1036, 15)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1085, 1036, 14)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1086, 1036, 16)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1087, 1036, 12)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1088, 1036, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1089, 1036, 7)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1091, 1044, 1)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (1092, 1044, 2)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3091, 1029, 28)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3092, 1029, 16)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3093, 1029, 10)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3094, 1029, 15)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3095, 1029, 20)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3096, 1029, 24)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3097, 1029, 18)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3098, 1029, 4)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3099, 1029, 19)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3100, 1029, 26)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3101, 1029, 27)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3102, 1029, 11)
INSERT [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID], [CurriculumCourseID], [ModuleID]) VALUES (3103, 1029, 6)
SET IDENTITY_INSERT [dbo].[CurriculumCourseModules] OFF
SET IDENTITY_INSERT [dbo].[CurriculumCourses] ON 

INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (20, 0, 21, 9, 1, 1, CAST(15425.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1022, 2090, 6, 4, 2, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1023, 2103, 3, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1028, 0, 1018, 1002, 1, 2, CAST(440.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1029, 2081, 5, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1030, 0, 2, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1031, 1030, 2, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1032, 1031, 2, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1033, 1032, 2, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1034, 1033, 2, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1035, 1034, 2, 1005, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1036, 1035, 2, 1006, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1037, 0, 2, 1007, 1, 15, CAST(6060.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1038, 0, 2, 1008, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1039, 0, 2, 1009, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1040, 0, 2, 1010, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1041, 0, 2, 1011, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1042, 0, 2, 1012, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1043, 0, 2, 1013, 1, 10, CAST(5010.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1044, 0, 7, 4, 1, 2, CAST(734.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1045, 1044, 7, 6, 1, 9, CAST(3464.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1046, 1045, 7, 7, 1, 11, CAST(4235.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1047, 1046, 7, 1003, 1, 3, CAST(1152.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1048, 1052, 7, 1009, 1, 5, CAST(1925.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1049, 1047, 7, 1004, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1050, 1056, 7, 1014, 1, 15, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1051, 1050, 7, 1015, 1, 10, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1052, 1053, 7, 1008, 1, 5, CAST(1925.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1053, 1054, 7, 1007, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1054, 1055, 7, 1006, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1055, 1062, 7, 1005, 1, 15, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1056, 1049, 7, 1013, 1, 10, CAST(4770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1057, 1051, 7, 1018, 1, 20, CAST(7700.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1058, 1057, 7, 1019, 1, 20, CAST(8040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1059, 1058, 7, 1020, 1, 5, CAST(1925.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1060, 1059, 7, 1021, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1062, 1060, 7, 1022, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1063, 1064, 8, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1064, 2126, 8, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1065, 0, 1018, 1023, 1, 2, CAST(440.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1066, 0, 1018, 1024, 1, 1, CAST(440.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1067, 0, 1018, 1025, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1068, 0, 1018, 1026, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1069, 0, 1018, 1027, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1070, 0, 1018, 1028, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1071, 0, 1018, 1029, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1072, 0, 1018, 1030, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1073, 0, 1018, 1031, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1074, 0, 1018, 1032, 1, 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1075, 0, 11, 1, 1, 365, CAST(36500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (1076, 1075, 11, 2, 1, 365, CAST(45600.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2077, 0, 1019, 3014, 1, 3, CAST(5310.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2078, 0, 1019, 3014, 2, 1, CAST(1770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2079, 0, 1020, 3015, 1, 5, CAST(8850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2080, 0, 1020, 3015, 2, 1, CAST(1770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2081, 2082, 5, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2082, 2083, 5, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2083, 2084, 5, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2084, 2085, 5, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2085, 2086, 5, 3017, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2086, 2087, 5, 3018, 1, 20, CAST(10020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2087, 2088, 5, 3019, 1, 20, CAST(10020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2088, 2089, 5, 3020, 1, 15, CAST(7510.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2089, 0, 5, 3021, 1, 20, CAST(8720.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2090, 2091, 6, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2091, 2092, 6, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2092, 2093, 6, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2093, 2095, 6, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2095, 2096, 6, 1013, 1, 10, CAST(5010.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2096, 2097, 6, 1014, 1, 15, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2097, 2098, 6, 1015, 1, 15, CAST(6060.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2098, 2099, 6, 3022, 1, 25, CAST(10110.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2099, 2100, 6, 3023, 1, 5, CAST(8440.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2100, 2101, 6, 1020, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2101, 2102, 6, 3024, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2102, 0, 6, 1022, 1, 10, CAST(4030.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2103, 2104, 3, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2104, 2105, 3, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2105, 2106, 3, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2106, 2107, 3, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2107, 2108, 3, 1005, 1, 25, CAST(10110.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2108, 2109, 3, 1006, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2109, 2110, 3, 1007, 1, 15, CAST(6060.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2110, 2111, 3, 1008, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2111, 2112, 3, 1009, 1, 5, CAST(2020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2112, 0, 3, 1013, 1, 10, CAST(5010.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2113, 2114, 9, 4, 1, 2, CAST(734.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2114, 2115, 9, 6, 1, 9, CAST(3465.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2115, 2116, 9, 7, 1, 11, CAST(4235.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2116, 2117, 9, 1003, 1, 3, CAST(1152.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2117, 2118, 9, 1004, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2118, 2119, 9, 1013, 1, 5, CAST(2385.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2119, 2120, 9, 1014, 1, 15, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2120, 2121, 9, 1015, 1, 365, CAST(5775.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2121, 2122, 9, 3025, 1, 15, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2122, 2123, 9, 3024, 1, 10, CAST(3850.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2123, 2124, 9, 3026, 1, 30, CAST(13500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2124, 2125, 9, 3027, 1, 30, CAST(13500.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2125, 0, 9, 1022, 1, 10, CAST(4500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2126, 2127, 8, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2127, 2128, 8, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2128, 2129, 8, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2129, 2130, 8, 1013, 1, 10, CAST(5010.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2130, 2131, 8, 3028, 1, 20, CAST(11130.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2131, 2132, 8, 3029, 1, 20, CAST(6540.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2132, 2135, 8, 3030, 1, 15, CAST(6330.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2133, 0, 8, 1005, 1, 15, CAST(6330.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2134, 0, 8, 3032, 1, 20, CAST(8690.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2135, 0, 8, 3031, 1, 15, CAST(6330.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2136, 2137, 4, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2137, 2138, 4, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2138, 2139, 4, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2139, 2140, 4, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2140, 2141, 4, 1010, 1, 20, CAST(10020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2141, 2142, 4, 1011, 1, 20, CAST(10020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2142, 2143, 4, 1012, 1, 20, CAST(10020.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2143, 0, 4, 1013, 1, 10, CAST(5010.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2144, 2136, 4, 4, 1, 2, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2145, 2146, 1, 4, 1, 9, CAST(770.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2146, 2147, 1, 6, 1, 9, CAST(3640.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2147, 2148, 1, 7, 1, 11, CAST(4450.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2148, 2149, 1, 1003, 1, 3, CAST(1210.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2149, 2150, 1, 1004, 1, 10, CAST(4040.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2150, 2151, 1, 3034, 1, 25, CAST(12470.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2151, 2152, 1, 3035, 1, 30, CAST(14960.00 AS Decimal(10, 2)))
INSERT [dbo].[CurriculumCourses] ([CurriculumCourseID], [CurriculumCourseParentID], [CurriculumID], [CourseID], [EnrollmentTypeID], [Duration], [Cost]) VALUES (2152, 0, 1, 3036, 1, 30, CAST(14960.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[CurriculumCourses] OFF
SET IDENTITY_INSERT [dbo].[CurriculumEnquiries] ON 

INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (7, 80, 7, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (8, 81, 7, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (9, 82, 7, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (10, 82, 1, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (11, 82, 4, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (12, 82, 2, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (13, 82, 1019, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (14, 83, 7, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (15, 83, 6, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (16, 83, 8, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (17, 84, 7, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (18, 84, 2, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (19, 85, 9, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (20, 86, 6, 1, 4)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (21, 88, 7, 1, 6)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (22, 88, 1019, 1, 4)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (23, 88, 1, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (24, 89, 7, 1, 5)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (25, 91, 7, 1, 4)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (26, 92, 2, 1, 1)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (27, 93, 7, 1, 6)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (28, 93, 1019, 1, 5)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (29, 94, 7, 1, 4)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (30, 95, 6, 1, 4)
INSERT [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID], [EnquiryID], [CurriculumID], [EnquiryStatusID], [EnrollmentQuanity]) VALUES (31, 95, 1020, 1, 3)
SET IDENTITY_INSERT [dbo].[CurriculumEnquiries] OFF
SET IDENTITY_INSERT [dbo].[Curriculums] ON 

INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (1, 1, 2004, N'Welder', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (2, 1, 2004, N'Fitter and Turner', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (3, 1, 2004, N'Fitter', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (4, 1, 2004, N'Turner', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (5, 1, 2004, N'Boilermaking', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (6, 1, 2004, N'Electrical', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (7, 1, 2004, N'Millwright', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (8, 1, 2004, N'Rigging', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (9, 1, 2004, N'Instrumentation', 1)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (10, 2, 1004, N'National Certificate Electrical Engineering', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (11, 1, 1004, N'Engineering Fabrication', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (13, 1, 1004, N'Mechanical Engineering: Machining', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (15, 1, 1004, N'Metals Production', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (16, 1, 1004, N'Welding Application and Practice', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (17, 1, 2005, N'test', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (21, 1, 1005, N'Mobile Crane', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (1018, 2, 2009, N'Assessments', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (1019, 3, 1006, N'Fork Lift', 0)
INSERT [dbo].[Curriculums] ([CurriculumID], [CostingModelID], [DepartmentID], [CurriculumName], [CurriculumIsSequenced]) VALUES (1020, 3, 1006, N'Counter Balanced Lift Truck', 0)
SET IDENTITY_INSERT [dbo].[Curriculums] OFF
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (1004, 8057)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (1004, 9050)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (1004, 9051)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (1005, 9051)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (1006, 9051)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (2004, 9051)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (2004, 9055)
INSERT [dbo].[DepartmentResponsibleEmployees] ([DepartmentID], [IndividualID]) VALUES (2005, 9055)
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (8057, N'hgkghjkhk')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9050, N'7541256-01')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9051, N'1259652')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9052, N'8787')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9053, N'H12434')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9054, N'87465146')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (9055, N'ISS012356')
INSERT [dbo].[Employees] ([IndividualID], [EmployeeNumber]) VALUES (11071, N'82544')
SET IDENTITY_INSERT [dbo].[Enquiry] ON 

INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (1, CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (2, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (59, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (60, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (61, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (62, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (63, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (64, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (65, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (66, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (67, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (68, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (69, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (70, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (71, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (72, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (73, CAST(N'2017-04-02' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (74, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (75, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (76, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (77, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (78, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (79, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (80, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (81, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (82, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (83, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (84, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (85, CAST(N'2017-04-03' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (86, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (87, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (88, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (89, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (90, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (91, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (92, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (93, CAST(N'2017-04-04' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (94, CAST(N'2017-04-05' AS Date))
INSERT [dbo].[Enquiry] ([EnquiryID], [EnquiryDate]) VALUES (95, CAST(N'2017-04-06' AS Date))
SET IDENTITY_INSERT [dbo].[Enquiry] OFF
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 59)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 60)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 62)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 64)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 65)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 66)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 71)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 72)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 73)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 78)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 80)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 89)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 91)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 92)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (8056, 94)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (9056, 77)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (9056, 86)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (9056, 88)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11051, 61)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11051, 63)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11051, 81)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11052, 75)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11052, 76)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11052, 87)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11072, 83)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11073, 93)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11074, 84)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11074, 85)
INSERT [dbo].[EquiryAssociatedContacts] ([IndividualID], [EnquiryID]) VALUES (11075, 95)
SET IDENTITY_INSERT [dbo].[EquiryHistory] ON 

INSERT [dbo].[EquiryHistory] ([EnqueryHistoryID], [EnquiryID], [IndividualID], [LookupEquiyHistoryTypeID], [DateEnquiryUpdated], [EnquiryNotes]) VALUES (1, 94, 9051, 1, CAST(N'2017-04-05T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[EquiryHistory] ([EnqueryHistoryID], [EnquiryID], [IndividualID], [LookupEquiyHistoryTypeID], [DateEnquiryUpdated], [EnquiryNotes]) VALUES (2, 94, 9051, 2, CAST(N'2017-04-05T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[EquiryHistory] ([EnqueryHistoryID], [EnquiryID], [IndividualID], [LookupEquiyHistoryTypeID], [DateEnquiryUpdated], [EnquiryNotes]) VALUES (3, 95, 9051, 1, CAST(N'2017-04-06T11:11:27.927' AS DateTime), N'')
INSERT [dbo].[EquiryHistory] ([EnqueryHistoryID], [EnquiryID], [IndividualID], [LookupEquiyHistoryTypeID], [DateEnquiryUpdated], [EnquiryNotes]) VALUES (4, 95, 9051, 2, CAST(N'2017-04-06T11:11:27.927' AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[EquiryHistory] OFF
SET IDENTITY_INSERT [dbo].[FacilitatorAssociatedCourses] ON 

INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (83, 10051, 1)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (85, 10051, 3)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1002, 10052, 7)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1003, 10052, 1005)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1004, 10052, 1008)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1005, 10052, 1010)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1006, 10052, 1011)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (1007, 10052, 1004)
INSERT [dbo].[FacilitatorAssociatedCourses] ([FacilitatorAssociatedCourseID], [IndividualID], [CourseID]) VALUES (2024, 10050, 3015)
SET IDENTITY_INSERT [dbo].[FacilitatorAssociatedCourses] OFF
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10050)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10051)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10052)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10053)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10054)
INSERT [dbo].[Facilitators] ([IndividualID]) VALUES (10055)


INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8015, 9053)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8017, 8057)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8018, 9050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8019, 9051)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8020, 9051)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8021, 9052)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8022, 9054)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8023, 9055)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (8024, 9054)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9003, 10050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9004, 10050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9005, 10050)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9006, 10051)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9007, 10052)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9008, 10055)
INSERT [dbo].[IndividualAddresses] ([AddressID], [IndividualID]) VALUES (9009, 10053)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8056, 10014)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8056, 10015)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8056, 10016)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (8056, 10017)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9055, 10019)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9056, 10020)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (9056, 10021)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (11051, 10018)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (11052, 10022)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (11072, 10023)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (11073, 10027)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (11074, 10028)
INSERT [dbo].[IndividualContactDetails] ([IndividualID], [ContactDetailID]) VALUES (11075, 10029)
SET IDENTITY_INSERT [dbo].[Individuals] ON 

INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (8056, 1, N'Brendan1', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (8057, 1, N'deagsdfasdfasdfd', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9050, 1, N'Me', N'', N'Threm')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9051, 1, N'Testing', N'', N'wdafsdfsdafasdf')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9052, 1, N'estes', N'lkjk', N'tesdygvkhu')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9053, 1, N'Joe', N'', N'Bradery')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9054, 1, N'Helping me', N'', N'')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9055, 1, N'Brendan2', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (9056, 1, N'sosoi', N'', N'')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10050, 1, N'agdasfas', N'asdfas', N'sdfasd')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10051, 4, N'bvhgfd', N'rhtdh', N'fgdgfq')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10052, 1, N'Brendan3', N'Mark', N'Wood')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10053, 1, N'Test Facilitator', N'', N'dksfljsldk')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10054, 1, N'zdfhcfjgh', N'', N'')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (10055, 1, N'Facilitator', N'Facilitator', N'Facilitator')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11051, 1, N'Mary', N'Ann', N'Schulz')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11052, 1, N'Kevin', N'Cecil', N'Van Rooen')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11071, 1, N'Employee Test Frist Name', N'', N'Employee Test Last Name')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11072, 1, N'Add Contact Test', N'', N'Cotzee')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11073, 1, N'test', N'test', N'test')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11074, 1, N'Piet', N'', N'Neethling')
INSERT [dbo].[Individuals] ([IndividualID], [TitleID], [IndividualFirstName], [IndividualSecondName], [IndividualLastname]) VALUES (11075, 1, N'Sibusiso', N'Jefferey', N'Nyambose')
SET IDENTITY_INSERT [dbo].[Individuals] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([LoginID], [IndividualID], [DateLastChanged], [UserName], [Password]) VALUES (1, 9053, CAST(N'2017-03-26T21:48:58.767' AS DateTime), N'speedie', N'a')
INSERT [dbo].[Login] ([LoginID], [IndividualID], [DateLastChanged], [UserName], [Password]) VALUES (2, 9054, CAST(N'2017-03-26T21:51:18.217' AS DateTime), N'Brendan', N'Testing')
INSERT [dbo].[Login] ([LoginID], [IndividualID], [DateLastChanged], [UserName], [Password]) VALUES (3, 9052, CAST(N'2017-03-27T06:10:10.567' AS DateTime), N'test', N'test')
INSERT [dbo].[Login] ([LoginID], [IndividualID], [DateLastChanged], [UserName], [Password]) VALUES (4, 9050, CAST(N'2017-03-27T06:10:44.357' AS DateTime), N'test1', N'test')
INSERT [dbo].[Login] ([LoginID], [IndividualID], [DateLastChanged], [UserName], [Password]) VALUES (6, 11071, CAST(N'2017-04-03T10:03:42.367' AS DateTime), N'Employee Test Frist Name', N'Password!')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[LookupAddressTypes] ON 

INSERT [dbo].[LookupAddressTypes] ([AddressTypeID], [AddressType]) VALUES (1, N'Postal')
INSERT [dbo].[LookupAddressTypes] ([AddressTypeID], [AddressType]) VALUES (2, N'Residential')
SET IDENTITY_INSERT [dbo].[LookupAddressTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupContactTypes] ON 

INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (1, N'Email Address')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (2, N'Cell Number')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (3, N'Home Number')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (4, N'Office Number')
INSERT [dbo].[LookupContactTypes] ([ContactTypeID], [ContactType]) VALUES (2007, N'Fax Number')
SET IDENTITY_INSERT [dbo].[LookupContactTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupCountries] ON 

INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (1, N'South Africa', N'ZAR')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (2, N'Lesotho', N'LS')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (3, N'Mozambique', N'MZ')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (4, N'Zimbabwe', N'ZW')
INSERT [dbo].[LookupCountries] ([CountryID], [CountryName], [CountryCode]) VALUES (5, N'Namibia', N'NA')
SET IDENTITY_INSERT [dbo].[LookupCountries] OFF
SET IDENTITY_INSERT [dbo].[LookupDepartments] ON 

INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (1004, N'Learnership')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (1005, N'Lifting Operator Training (LOPT)')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (1006, N'Surface Mobile Equipment')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (2004, N'Apprenticeship')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (2005, N'Short Courses')
INSERT [dbo].[LookupDepartments] ([DepartmentID], [DepartmentName]) VALUES (2009, N'Training Related Services')
SET IDENTITY_INSERT [dbo].[LookupDepartments] OFF
SET IDENTITY_INSERT [dbo].[LookupDisabilities] ON 

INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (1, N'Mobility Impairments')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (2, N'Physical Impairments')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (3, N'Vision')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (4, N'Hearing')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (5, N'Cognitive or Learning')
INSERT [dbo].[LookupDisabilities] ([DisabilityID], [Disability]) VALUES (7, N'Other')
SET IDENTITY_INSERT [dbo].[LookupDisabilities] OFF
SET IDENTITY_INSERT [dbo].[LookupEnquiryStartDateTypes] ON 

INSERT [dbo].[LookupEnquiryStartDateTypes] ([EnquiryStartDateTypeID], [EnquiryStartDateType]) VALUES (1, N'Client Requested Date')
INSERT [dbo].[LookupEnquiryStartDateTypes] ([EnquiryStartDateTypeID], [EnquiryStartDateType]) VALUES (2, N'System Determined Date')
SET IDENTITY_INSERT [dbo].[LookupEnquiryStartDateTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupEnquiryStatuses] ON 

INSERT [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID], [EnquiryStatus]) VALUES (1, N'New')
INSERT [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID], [EnquiryStatus]) VALUES (2, N'Enrollment In Progress')
INSERT [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID], [EnquiryStatus]) VALUES (3, N'Awaiting Scheduling')
INSERT [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID], [EnquiryStatus]) VALUES (4, N'Schedule Finalised')
INSERT [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID], [EnquiryStatus]) VALUES (5, N'Enquiry Closed')
SET IDENTITY_INSERT [dbo].[LookupEnquiryStatuses] OFF
SET IDENTITY_INSERT [dbo].[LookupEnquiryTypes] ON 

INSERT [dbo].[LookupEnquiryTypes] ([EnquiryTypeID], [EnquiryType]) VALUES (1, N'Engineering')
INSERT [dbo].[LookupEnquiryTypes] ([EnquiryTypeID], [EnquiryType]) VALUES (2, N'LOPT')
SET IDENTITY_INSERT [dbo].[LookupEnquiryTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupEnrollmentProgressStates] ON 

INSERT [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID], [EnrollmentProgressCurrentState]) VALUES (1, N'In Progress')
INSERT [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID], [EnrollmentProgressCurrentState]) VALUES (2, N'Complete')
SET IDENTITY_INSERT [dbo].[LookupEnrollmentProgressStates] OFF
SET IDENTITY_INSERT [dbo].[LookupEnrollmentTypes] ON 

INSERT [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID], [EnrollmentType]) VALUES (1, N'Novice')
INSERT [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID], [EnrollmentType]) VALUES (2, N'Re-Certification')
SET IDENTITY_INSERT [dbo].[LookupEnrollmentTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupEquiryHistoryTypes] ON 

INSERT [dbo].[LookupEquiryHistoryTypes] ([LookupEquiyHistoryTypeID], [LookupEquiyHistoryTypeName]) VALUES (1, N'Company Contact')
INSERT [dbo].[LookupEquiryHistoryTypes] ([LookupEquiyHistoryTypeID], [LookupEquiyHistoryTypeName]) VALUES (2, N'Curriculum Selection')
SET IDENTITY_INSERT [dbo].[LookupEquiryHistoryTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupEthnicities] ON 

INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (1, N'Black African')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (2, N'White')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (3, N'Coloured')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (4, N'Indian')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (5, N'Asian')
INSERT [dbo].[LookupEthnicities] ([EthnicityID], [Ethnicity]) VALUES (6, N'Other/Unspecified')
SET IDENTITY_INSERT [dbo].[LookupEthnicities] OFF
SET IDENTITY_INSERT [dbo].[LookupGenders] ON 

INSERT [dbo].[LookupGenders] ([GenderID], [Gender]) VALUES (1, N'Male')
INSERT [dbo].[LookupGenders] ([GenderID], [Gender]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[LookupGenders] OFF
SET IDENTITY_INSERT [dbo].[LookupMartialStatuses] ON 

INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (1, N'Married')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (2, N'Widowed')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (3, N'Separated')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (4, N'Divorced')
INSERT [dbo].[LookupMartialStatuses] ([MartialStatusID], [MaritialStatus]) VALUES (5, N'Single')
SET IDENTITY_INSERT [dbo].[LookupMartialStatuses] OFF
SET IDENTITY_INSERT [dbo].[LookupProvinces] ON 

INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (1, N'Gauteng')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (2, N'Free State')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (3, N'Western Cape')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (4, N'Northern Cape')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (5, N'Eastern Cape')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (6, N'Limpopo')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (7, N'KwaZulu-Natal')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (8, N'Mpumalanga')
INSERT [dbo].[LookupProvinces] ([ProvinceID], [Province]) VALUES (9, N'North West')
SET IDENTITY_INSERT [dbo].[LookupProvinces] OFF
SET IDENTITY_INSERT [dbo].[LookupQualificationLevels] ON 

INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (1, N'NQF 1 (Grade 9/National Certificate)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (2, N'NQF 2 (National Certificate)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (3, N'NQF 3 (National Certificate)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (4, N'NQF 4 (Grade 12/Matric)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (5, N'NQF 5 (National Diplomas)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (6, N'NQF 6 (National Diplomas)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (7, N'NQF 7 (Bachelors Degree, B Techs, Advanced Diploma)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (8, N'NQF 8 (Honours Degree/Post-graduate Diploma)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (9, N'NQF 9 (Masters Degree)')
INSERT [dbo].[LookupQualificationLevels] ([QualificationLevelID], [QualificationLevel]) VALUES (10, N'NQF 10 (Doctrate)')
SET IDENTITY_INSERT [dbo].[LookupQualificationLevels] OFF
SET IDENTITY_INSERT [dbo].[LookupSectionalEnrollmentTypes] ON 

INSERT [dbo].[LookupSectionalEnrollmentTypes] ([LookupSectionalEnrollmentTypeID], [LookupSectionalEnrollmentType]) VALUES (1, N'Section 13')
INSERT [dbo].[LookupSectionalEnrollmentTypes] ([LookupSectionalEnrollmentTypeID], [LookupSectionalEnrollmentType]) VALUES (2, N'Section 28')
SET IDENTITY_INSERT [dbo].[LookupSectionalEnrollmentTypes] OFF
SET IDENTITY_INSERT [dbo].[LookupSetas] ON 

INSERT [dbo].[LookupSetas] ([SetaID], [SetsName], [SetaAbbriviation]) VALUES (2, N'Construction Education and Training Authority', N'CETA')
INSERT [dbo].[LookupSetas] ([SetaID], [SetsName], [SetaAbbriviation]) VALUES (3, N'Transport Education Training Authority', N'TETA')
INSERT [dbo].[LookupSetas] ([SetaID], [SetsName], [SetaAbbriviation]) VALUES (4, N'Mining Qualifications Authority', N'MQA')
SET IDENTITY_INSERT [dbo].[LookupSetas] OFF
SET IDENTITY_INSERT [dbo].[LookupTitles] ON 

INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (1, N'Mr')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (2, N'Mrs')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (3, N'Miss')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (4, N'Dr')
INSERT [dbo].[LookupTitles] ([TitleID], [Title]) VALUES (5, N'Prof')
SET IDENTITY_INSERT [dbo].[LookupTitles] OFF
SET IDENTITY_INSERT [dbo].[LookupTypeOfRelations] ON 

INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (1, N'Father')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (2, N'Mother')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (3, N'Brother')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (4, N'Sister')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (5, N'Uncle')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (6, N'Aunt')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (7, N'Friend')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (8, N'Husband')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (9, N'Wife')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (10, N'Girl Friend')
INSERT [dbo].[LookupTypeOfRelations] ([TypeOfRelationID], [TypeOfRelation]) VALUES (11, N'Boy Friend')
SET IDENTITY_INSERT [dbo].[LookupTypeOfRelations] OFF
SET IDENTITY_INSERT [dbo].[Modules] ON 

INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (1, 2004, N'Induction')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (2, 2004, N'Safety')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (3, 2004, N'Materials')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (4, 2004, N'Drawings and Sketches')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (5, 2004, N'Measuring Equipment')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (6, 2004, N'Hand tools')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (7, 2004, N'Workshop Tools')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (8, 2004, N'Marking Off')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (10, 2004, N'Basic Lifting Techniques')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (11, 2004, N'Hand Skills')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (12, 2004, N'Keys and Locking Devices')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (14, 2004, N'Lubrication')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (15, 2004, N'Bearings')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (16, 2004, N'Assemblies')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (17, 2004, N'Installation of Machinery')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (18, 2004, N'Couplings')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (19, 2004, N'Drives')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (20, 2004, N'Brakes and Clutches')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (21, 2004, N'Pumps')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (22, 2004, N'Hydraulics')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (23, 2004, N'Pneumatics')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (24, 2004, N'Centre Lathe Work')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (25, 2004, N'Milling Machine Work')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (26, 2004, N'Gas Cutting and Heating')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (27, 2004, N'Gas Welding and Brazing')
INSERT [dbo].[Modules] ([ModuleID], [DepartmentID], [ModuleName]) VALUES (28, 2004, N'Arc welding')
SET IDENTITY_INSERT [dbo].[Modules] OFF
SET IDENTITY_INSERT [dbo].[OldModules] ON 

INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (1, N'Module 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (2, N'Module 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (3, N'Module 3', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (4, N'Module 4', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (5, N'*AC/DC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (6, N'*Electrical 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (7, N'*Electrical 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (8, N'*Faultfinding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (9, N'*Wiring and Installation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (10, N'AC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (11, N'AC/DC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (12, N'Advance Arc Welding (All position, Full Penetration) (Stick Welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (13, N'Advance Gas Metal Arc Welding (CO2 - All Position, Full Penetration)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (14, N'Advance Gas Tungsten Arc Welding (Tig - Full Penetrstion)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (15, N'Advance Oxy-Fuel Gas Welding and Brazing (Full Penetration)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (16, N'Alignment', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (17, N'Aluminium Welding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (18, N'Analyse Units', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (19, N'Angle Grinders', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (20, N'Assembiles (Seals, Gaskets and Packings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (21, N'Assemblies(Gearboxes)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (22, N'Basic Arc Welding (Stick Welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (23, N'Basic center lathe work (Basic Turning', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (24, N'Basic Flow Management', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (25, N'Basic Fundamentals of Instrumentation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (26, N'Basic Gas Metal Arc welding (CO2)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (27, N'Basic Gas Tungsten Arc Welding (Tig) (Argon welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (28, N'Basic Hand Tools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (29, N'Basic Instrumentation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (30, N'Basic Level Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (31, N'Basic Lifting Techniques', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (32, N'Basic Millling Machine Work (Basic Milling)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (33, N'Basic Oxy-Fuel Gas Welding and Brazing', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (34, N'Basic Presure Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (35, N'Basic Surface Grinding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (36, N'Basic Temperature Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (37, N'Bearings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (38, N'Bearings and Seals 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (39, N'Bending and Bending Allowances', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (40, N'Bending Roll', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (41, N'Boilermaking 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (42, N'Boilermaking 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (43, N'Brakes/ Clutches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (44, N'Conductors (Current Carrying Capacity', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (45, N'Connecting to plugs ', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (46, N'Construction', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (47, N'Couplings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (48, N'DC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (49, N'Developmenents (Level 4)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (50, N'Development and fabrication', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (51, N'Development and structures', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (52, N'Developments (Level 3)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (53, N'Direct Drivers (Gear Drives)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (54, N'Drawing and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (55, N'Drawings and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (56, N'Drawings and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (57, N'Electical Prefixes and Units', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (58, N'Electircal Symbols', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (59, N'Electrical 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (60, N'Electrical 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (61, N'Electrical Safety', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (62, N'Electrical Testing Instruments(Portable & Panel Mounted)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (63, N'Electronics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (64, N'Electronics (Soldering Iron and Soft Soldering included)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (65, N'Electronics(PCL)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (66, N'Fault Finding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (67, N'Faultfinding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (68, N'Fitting', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (69, N'Flux core Welding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (70, N'Gas Cutting and Heating', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (71, N'Gouging', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (72, N'Guilotine', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (73, N'Hand and PowerTools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (74, N'Hand Drilling Machine', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (75, N'Hand Tools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (76, N'Hand Tools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (77, N'Hydraulics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (78, N'Hydraulics and Pneumatics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (79, N'Impact Wrench', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (80, N'Indirect drives (V-Brlts)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (81, N'Installations(Wire Distribution Boards)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (82, N'Instrumentation 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (83, N'Instrumentation 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (84, N'Interpret Electrical Drawings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (85, N'Joints and Profiles', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (86, N'Keys and locking Devices', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (87, N'Lifting Operation Training', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (88, N'Lifting Tackle', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (89, N'Machanes(Workshop)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (90, N'Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (91, N'Machines Gas Cutting (Straight Line Cutter)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (92, N'Marking off', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (93, N'Materials', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (94, N'Materials, Cables and Conductors', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (95, N'Measuring', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (96, N'Measuring Equipment', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (97, N'Milling', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (98, N'Motor Theory and Testing', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (99, N'Orientation', N'None')
GO
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (100, N'Panel Wiring', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (101, N'Pedestal Drilling Machine', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (102, N'Phase-Out Indcution Motors', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (103, N'Pipe Fiting', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (104, N'Pipe Systems', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (105, N'Pipe Welding (45Deg / 6G) (Argon/Stick Welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (106, N'PLC', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (107, N'Pneumatics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (108, N'Principles and Techniques of Marking Off', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (109, N'Principles of Drawings and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (110, N'Process Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (111, N'Protection Equipment Level 2 and 3', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (112, N'Pumps', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (113, N'PVC Welding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (114, N'Radial Arm Drill', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (115, N'Ropes', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (116, N'Slinging Tackle', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (117, N'Structural Boilermaker Work (Level 3)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (118, N'Structural Boilermaker Work (Level 4)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (119, N'Terminate Cables using Glands', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (120, N'Thermal Applications 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (121, N'Thermal Applications 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (122, N'Transformers', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (123, N'Turning 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (124, N'Turning 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (125, N'Valves, traps and Strainers', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (126, N'Welding 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (127, N'Welding 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (128, N'Welding 3', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (129, N'Welding for other trades', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (130, N'Wiring (Basic Circuits, lights and lamps)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (131, N'Wiring and Installations', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (132, N'Wiring Motors Starters (AC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (133, N'Workshop Practice 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (134, N'Workshop Practice 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (135, N'Workshops Tools (Drill, Grinder, Press)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (136, N'*AC/DC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (137, N'*Electrical 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (138, N'*Electrical 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (139, N'*Faultfinding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (140, N'*Wiring and Installation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (141, N'AC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (142, N'AC/DC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (143, N'Advance Arc Welding (All position, Full Penetration) (Stick Welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (144, N'Advance Gas Metal Arc Welding (CO2 - All Position, Full Penetration)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (145, N'Advance Gas Tungsten Arc Welding (Tig - Full Penetrstion)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (146, N'Advance Oxy-Fuel Gas Welding and Brazing (Full Penetration)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (147, N'Alignment', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (148, N'Aluminium Welding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (149, N'Analyse Units', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (150, N'Angle Grinders', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (151, N'Assembiles (Seals, Gaskets and Packings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (152, N'Assemblies(Gearboxes)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (153, N'Basic Arc Welding (Stick Welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (154, N'Basic center lathe work (Basic Turning', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (155, N'Basic Flow Management', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (156, N'Basic Fundamentals of Instrumentation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (157, N'Basic Gas Metal Arc welding (CO2)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (158, N'Basic Gas Tungsten Arc Welding (Tig) (Argon welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (159, N'Basic Hand Tools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (160, N'Basic Instrumentation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (161, N'Basic Level Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (162, N'Basic Lifting Techniques', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (163, N'Basic Millling Machine Work (Basic Milling)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (164, N'Basic Oxy-Fuel Gas Welding and Brazing', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (165, N'Basic Presure Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (166, N'Basic Surface Grinding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (167, N'Basic Temperature Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (168, N'Bearings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (169, N'Bearings and Seals 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (170, N'Bending and Bending Allowances', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (171, N'Bending Roll', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (172, N'Boilermaking 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (173, N'Boilermaking 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (174, N'Brakes/ Clutches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (175, N'Conductors (Current Carrying Capacity', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (176, N'Connecting to plugs ', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (177, N'Construction', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (178, N'Couplings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (179, N'DC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (180, N'Developmenents (Level 4)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (181, N'Development and fabrication', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (182, N'Development and structures', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (183, N'Developments (Level 3)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (184, N'Direct Drivers (Gear Drives)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (185, N'Drawing and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (186, N'Drawings and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (187, N'Drawings and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (188, N'Electical Prefixes and Units', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (189, N'Electircal Symbols', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (190, N'Electrical 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (191, N'Electrical 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (192, N'Electrical Safety', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (193, N'Electrical Testing Instruments(Portable & Panel Mounted)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (194, N'Electronics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (195, N'Electronics (Soldering Iron and Soft Soldering included)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (196, N'Electronics(PCL)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (197, N'Fault Finding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (198, N'Faultfinding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (199, N'Fitting', N'None')
GO
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (200, N'Flux core Welding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (201, N'Gas Cutting and Heating', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (202, N'Gouging', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (203, N'Guilotine', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (204, N'Hand and PowerTools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (205, N'Hand Drilling Machine', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (206, N'Hand Tools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (207, N'Hand Tools', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (208, N'Hydraulics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (209, N'Hydraulics and Pneumatics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (210, N'Impact Wrench', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (211, N'Indirect drives (V-Brlts)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (212, N'Installations(Wire Distribution Boards)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (213, N'Instrumentation 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (214, N'Instrumentation 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (215, N'Interpret Electrical Drawings', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (216, N'Joints and Profiles', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (217, N'Keys and locking Devices', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (218, N'Lifting Operation Training', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (219, N'Lifting Tackle', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (220, N'Machanes(Workshop)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (221, N'Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (222, N'Machines Gas Cutting (Straight Line Cutter)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (223, N'Marking off', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (224, N'Materials', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (225, N'Materials, Cables and Conductors', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (226, N'Measuring', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (227, N'Measuring Equipment', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (228, N'Milling', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (229, N'Motor Theory and Testing', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (230, N'Orientation', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (231, N'Panel Wiring', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (232, N'Pedestal Drilling Machine', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (233, N'Phase-Out Indcution Motors', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (234, N'Pipe Fiting', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (235, N'Pipe Systems', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (236, N'Pipe Welding (45Deg / 6G) (Argon/Stick Welding)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (237, N'PLC', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (238, N'Pneumatics', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (239, N'Principles and Techniques of Marking Off', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (240, N'Principles of Drawings and Sketches', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (241, N'Process Measurement', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (242, N'Protection Equipment Level 2 and 3', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (243, N'Pumps', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (244, N'PVC Welding', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (245, N'Radial Arm Drill', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (246, N'Ropes', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (247, N'Slinging Tackle', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (248, N'Structural Boilermaker Work (Level 3)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (249, N'Structural Boilermaker Work (Level 4)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (250, N'Terminate Cables using Glands', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (251, N'Thermal Applications 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (252, N'Thermal Applications 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (253, N'Transformers', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (254, N'Turning 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (255, N'Turning 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (256, N'Valves, traps and Strainers', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (257, N'Welding 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (258, N'Welding 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (259, N'Welding 3', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (260, N'Welding for other trades', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (261, N'Wiring (Basic Circuits, lights and lamps)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (262, N'Wiring and Installations', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (263, N'Wiring Motors Starters (AC Machines', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (264, N'Workshop Practice 1', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (265, N'Workshop Practice 2', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (266, N'Workshops Tools (Drill, Grinder, Press)', N'None')
INSERT [dbo].[OldModules] ([ModuleID], [ModuleName], [ModuleDescription]) VALUES (267, N'test', N'System.Windows.Forms.TextBox, Text: etst')
SET IDENTITY_INSERT [dbo].[OldModules] OFF
SET IDENTITY_INSERT [dbo].[SMTPSettings] ON 

INSERT [dbo].[SMTPSettings] ([SmtpSettingID], [PortNumber], [SMTPHost], [RequireAuthentication], [RequiresSSL], [FromAddress], [UserName], [Password], [DisplayName]) VALUES (1, 25, N'smtp.mweb.co.za', 0, 0, N'brendanw@mweb.co.za', N'Brendanw@mweb.co.za', N'speedie3', N'MCD Communication')
SET IDENTITY_INSERT [dbo].[SMTPSettings] OFF
SET IDENTITY_INSERT [dbo].[StudentAssociatedCompany] ON 

INSERT [dbo].[StudentAssociatedCompany] ([StudentAssosiatedCompanyID], [IndividualID], [CompanyID], [IsCurrentCompany]) VALUES (1, 8057, 2004, 1)
INSERT [dbo].[StudentAssociatedCompany] ([StudentAssosiatedCompanyID], [IndividualID], [CompanyID], [IsCurrentCompany]) VALUES (2, 8057, 2005, 0)
SET IDENTITY_INSERT [dbo].[StudentAssociatedCompany] OFF
SET IDENTITY_INSERT [dbo].[StudentDisabilities] ON 

INSERT [dbo].[StudentDisabilities] ([StudentDisabilityID], [IndividualID], [DisabilityID], [StudentDisabilityNotes]) VALUES (2002, 8057, 1, N'none')
INSERT [dbo].[StudentDisabilities] ([StudentDisabilityID], [IndividualID], [DisabilityID], [StudentDisabilityNotes]) VALUES (2003, 8057, 3, N'testing eyes')
INSERT [dbo].[StudentDisabilities] ([StudentDisabilityID], [IndividualID], [DisabilityID], [StudentDisabilityNotes]) VALUES (2004, 8057, 7, N'test')
SET IDENTITY_INSERT [dbo].[StudentDisabilities] OFF
INSERT [dbo].[Students] ([IndividualID], [QualificationLevelID], [MartialStatusID], [GenderID], [EthnicityID], [StudentIDNumber], [StudentCurrentPosition], [StudentlInitialDate]) VALUES (8057, 8, 5, 1, 2, N'800695014089', N'', CAST(N'2017-03-08T00:00:00.000' AS DateTime))
INSERT [dbo].[SystemAdministrator] ([SystemAdministratorID], [SystemUserName], [SystemUserPassword]) VALUES (8056, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Venues] ON 

INSERT [dbo].[Venues] ([VenueID], [Venue], [VenueMaxCapacity]) VALUES (1, N'Venue 1', 12)
SET IDENTITY_INSERT [dbo].[Venues] OFF
ALTER TABLE [dbo].[Activities] ADD  CONSTRAINT [DF_Activities_ActivityCode]  DEFAULT ((0)) FOR [ActivityCode]
GO
ALTER TABLE [dbo].[Activities] ADD  CONSTRAINT [DF_Activities_ActivitiyDescription]  DEFAULT ('None') FOR [ActivitiyDescription]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_AddressLineOne]  DEFAULT ('') FOR [AddressLineOne]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_AddressLineTwo]  DEFAULT ('') FOR [AddressLineTwo]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_AddressTown]  DEFAULT ('') FOR [AddressTown]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_Suburb]  DEFAULT ('') FOR [AddressSuburb]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_AddressAreaCode]  DEFAULT ('') FOR [AddressAreaCode]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_CompanyAddressIsDefault]  DEFAULT ((1)) FOR [AddressIsDefault]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_AddressModifiedDate]  DEFAULT (getdate()) FOR [AddressModifiedDate]
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollmentPaymentConfirmations] ADD  CONSTRAINT [DF_EngineeringEnrollmentPaymentConfirmations_DateLastUpdated]  DEFAULT (getdate()) FOR [DateLastUpdated]
GO
ALTER TABLE [dbo].[Companies] ADD  CONSTRAINT [DF_Companies_Company]  DEFAULT ('Unknown') FOR [CompanyName]
GO
ALTER TABLE [dbo].[Companies] ADD  CONSTRAINT [DF_Companies_CompanySETANumber]  DEFAULT ('') FOR [CompanySETANumber]
GO
ALTER TABLE [dbo].[Companies] ADD  CONSTRAINT [DF_Companies_CompanySicCode]  DEFAULT ('') FOR [CompanySicCode]
GO
ALTER TABLE [dbo].[ContactDetails] ADD  CONSTRAINT [DF_ContactDetails_ContactDetail]  DEFAULT ('Unknown') FOR [ContactDetailValue]
GO
ALTER TABLE [dbo].[CourseCategories] ADD  CONSTRAINT [DF_CourseCategories_CourseCategoryName]  DEFAULT ('Unknown') FOR [CourseCategoryName]
GO
ALTER TABLE [dbo].[Courses] ADD  CONSTRAINT [DF_Courses_CourseName_1]  DEFAULT ('Unknown') FOR [CourseName]
GO
ALTER TABLE [dbo].[Courses] ADD  CONSTRAINT [DF_Courses_CourseDescription_1]  DEFAULT ('None') FOR [CourseDescription]
GO
ALTER TABLE [dbo].[CurriculumCourseMinimumMaximums] ADD  CONSTRAINT [DF_CurriculumCourseMinimumMaximums_CurriculumCourseMinimum]  DEFAULT ((1)) FOR [CurriculumCourseMinimum]
GO
ALTER TABLE [dbo].[CurriculumCourseMinimumMaximums] ADD  CONSTRAINT [DF_CurriculumCourseMinimumMaximums_CurriculumCourseMaximum]  DEFAULT ((0)) FOR [CurriculumCourseMaximum]
GO
ALTER TABLE [dbo].[CurriculumCourses] ADD  CONSTRAINT [DF_CurriculumCourses_CurriculumCourseParentID]  DEFAULT ((0)) FOR [CurriculumCourseParentID]
GO
ALTER TABLE [dbo].[CurriculumCourses] ADD  CONSTRAINT [DF_CurriculumCourses_Duration]  DEFAULT ((1)) FOR [Duration]
GO
ALTER TABLE [dbo].[CurriculumCourses] ADD  CONSTRAINT [DF_CurriculumCourses_Cost]  DEFAULT ((0.00)) FOR [Cost]
GO
ALTER TABLE [dbo].[CurriculumEnquiries] ADD  CONSTRAINT [DF_CurriculumEnquiries_EnrollmentQuanity]  DEFAULT ((1)) FOR [EnrollmentQuanity]
GO
ALTER TABLE [dbo].[Curriculums] ADD  CONSTRAINT [DF_Curriculums_CostingModelID]  DEFAULT ((1)) FOR [CostingModelID]
GO
ALTER TABLE [dbo].[Curriculums] ADD  CONSTRAINT [DF_Curriculums_CurriculumIsSequenced]  DEFAULT ((0)) FOR [CurriculumIsSequenced]
GO
ALTER TABLE [dbo].[Enquiry] ADD  CONSTRAINT [DF_Enquiry_EnquiryDate]  DEFAULT (getdate()) FOR [EnquiryDate]
GO
ALTER TABLE [dbo].[Enrollments] ADD  CONSTRAINT [DF_Enrollments_DateIntitiated]  DEFAULT (getdate()) FOR [DateIntitiated]
GO
ALTER TABLE [dbo].[EquiryHistory] ADD  CONSTRAINT [DF_EquiryHistory_EnquiryHistoryDateCommunication Completed]  DEFAULT (getdate()) FOR [DateEnquiryUpdated]
GO
ALTER TABLE [dbo].[EquiryHistory] ADD  CONSTRAINT [DF_EquiryHistory_EnquiryNotes]  DEFAULT ('None') FOR [EnquiryNotes]
GO
ALTER TABLE [dbo].[Files] ADD  CONSTRAINT [DF_Files_FileExtension]  DEFAULT ('pdf') FOR [FileExtension]
GO
ALTER TABLE [dbo].[Individuals] ADD  CONSTRAINT [DF_Individuals_TitleID]  DEFAULT ((1)) FOR [TitleID]
GO
ALTER TABLE [dbo].[Individuals] ADD  CONSTRAINT [DF_Individuals_IndividualFirstName]  DEFAULT ('Unknown') FOR [IndividualFirstName]
GO
ALTER TABLE [dbo].[Individuals] ADD  CONSTRAINT [DF_Individuals_IndividualSecondName]  DEFAULT ('') FOR [IndividualSecondName]
GO
ALTER TABLE [dbo].[Individuals] ADD  CONSTRAINT [DF_Individuals_IndividualLastname]  DEFAULT ('Unknown') FOR [IndividualLastname]
GO
ALTER TABLE [dbo].[Login] ADD  CONSTRAINT [DF_Login_DateLastChanged]  DEFAULT (getdate()) FOR [DateLastChanged]
GO
ALTER TABLE [dbo].[LookupAddressTypes] ADD  CONSTRAINT [DF_LookupAddressTypes_AddressType]  DEFAULT ('Unknown') FOR [AddressType]
GO
ALTER TABLE [dbo].[LookupContactTypes] ADD  CONSTRAINT [DF_LookupContactTypes_ContactType]  DEFAULT ('') FOR [ContactType]
GO
ALTER TABLE [dbo].[LookupCountries] ADD  CONSTRAINT [DF_LookupCountries_Country]  DEFAULT ('South Africa') FOR [CountryName]
GO
ALTER TABLE [dbo].[LookupCountries] ADD  CONSTRAINT [DF_LookupCountries_CountryCode]  DEFAULT ('ZAR') FOR [CountryCode]
GO
ALTER TABLE [dbo].[LookupDisabilities] ADD  CONSTRAINT [DF_LookupDisabilities_Disability]  DEFAULT ('None') FOR [Disability]
GO
ALTER TABLE [dbo].[LookupEnquiryStartDateTypes] ADD  CONSTRAINT [DF_LookupEnquiryStartDateTypes_EnquiryStartDateType]  DEFAULT ('Unknown') FOR [EnquiryStartDateType]
GO
ALTER TABLE [dbo].[LookupEnquiryStatuses] ADD  CONSTRAINT [DF_LookupEnquiryStatuses_EnquiryStatus]  DEFAULT ('New') FOR [EnquiryStatus]
GO
ALTER TABLE [dbo].[LookupEnquiryTypes] ADD  CONSTRAINT [DF_LookupEnquiryTypes_EnquiryType]  DEFAULT ('Unknown') FOR [EnquiryType]
GO
ALTER TABLE [dbo].[LookupEnrollmentProgressStates] ADD  CONSTRAINT [DF_LookupEnrollmentProgressStates_EnrollmentProgressCurrentState]  DEFAULT ('In Progress') FOR [EnrollmentProgressCurrentState]
GO
ALTER TABLE [dbo].[LookupProvinces] ADD  CONSTRAINT [DF_LookupProvinces_Province]  DEFAULT ('Unknown') FOR [Province]
GO
ALTER TABLE [dbo].[LookupTypeOfRelations] ADD  CONSTRAINT [DF_LookupTypeOfRelations_TypeOfRelation]  DEFAULT ('Unknown') FOR [TypeOfRelation]
GO
ALTER TABLE [dbo].[Modules] ADD  CONSTRAINT [DF_Modules_DepartmentID]  DEFAULT ((2004)) FOR [DepartmentID]
GO
ALTER TABLE [dbo].[Schedules] ADD  CONSTRAINT [DF_Schedules_ScheduleStartDate]  DEFAULT (getdate()) FOR [ScheduleStartDate]
GO
ALTER TABLE [dbo].[SMTPSettings] ADD  CONSTRAINT [DF_SMTPSettings_PortNumber]  DEFAULT ((25)) FOR [PortNumber]
GO
ALTER TABLE [dbo].[SMTPSettings] ADD  CONSTRAINT [DF_SMTPSettings_SMTPHost]  DEFAULT ('smtp.mweb.co..za') FOR [SMTPHost]
GO
ALTER TABLE [dbo].[SMTPSettings] ADD  CONSTRAINT [DF_SMTPSettings_RequireAuthentication]  DEFAULT ((0)) FOR [RequireAuthentication]
GO
ALTER TABLE [dbo].[SMTPSettings] ADD  CONSTRAINT [DF_SMTPSettings_RequiresSSL]  DEFAULT ((0)) FOR [RequiresSSL]
GO
ALTER TABLE [dbo].[SMTPSettings] ADD  CONSTRAINT [DF_SMTPSettings_FromAddress]  DEFAULT ('info@mcdtraining.co.za') FOR [FromAddress]
GO
ALTER TABLE [dbo].[SMTPSettings] ADD  CONSTRAINT [DF_SMTPSettings_DisplayName]  DEFAULT ('MCD Communication') FOR [DisplayName]
GO
ALTER TABLE [dbo].[StudentAssociatedCompany] ADD  CONSTRAINT [DF_StudentAssociatedCompany_IsCurrentCompany]  DEFAULT ((0)) FOR [IsCurrentCompany]
GO
ALTER TABLE [dbo].[StudentDisabilities] ADD  CONSTRAINT [DF_StudentDisabilities_StudentDisabilityNotes]  DEFAULT ('None') FOR [StudentDisabilityNotes]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_IndividualIDNumber]  DEFAULT ((1234567891234.)) FOR [StudentIDNumber]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_StudentCurrentPosition]  DEFAULT ('Unknown') FOR [StudentCurrentPosition]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_IndividualInitialDate]  DEFAULT (getdate()) FOR [StudentlInitialDate]
GO
ALTER TABLE [dbo].[Venues] ADD  CONSTRAINT [DF_Venues_Venue]  DEFAULT ('Unknown') FOR [Venue]
GO
ALTER TABLE [dbo].[Venues] ADD  CONSTRAINT [DF_Venues_VenueMaxCapacity]  DEFAULT ((1)) FOR [VenueMaxCapacity]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_Activities_Modules] FOREIGN KEY([ModuleID])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_Activities_Modules]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_LookupAddressTypes] FOREIGN KEY([AddressTypeID])
REFERENCES [dbo].[LookupAddressTypes] ([AddressTypeID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_LookupAddressTypes]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_LookupCountries] FOREIGN KEY([CountryID])
REFERENCES [dbo].[LookupCountries] ([CountryID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_LookupCountries]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_LookupProvinces] FOREIGN KEY([ProvinceID])
REFERENCES [dbo].[LookupProvinces] ([ProvinceID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_LookupProvinces]
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollmentPaymentConfirmations]  WITH CHECK ADD  CONSTRAINT [FK_ApprienticeshipEnrollmentPaymentConfirmations_ApprienticeshipEnrollments] FOREIGN KEY([EnrollmentID])
REFERENCES [dbo].[ApprienticeshipEnrollments] ([EnrollmentID])
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollmentPaymentConfirmations] CHECK CONSTRAINT [FK_ApprienticeshipEnrollmentPaymentConfirmations_ApprienticeshipEnrollments]
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollments]  WITH CHECK ADD  CONSTRAINT [FK_ApprienticeshipEnrollments_Enrollments] FOREIGN KEY([EnrollmentID])
REFERENCES [dbo].[Enrollments] ([EnrollmentID])
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollments] CHECK CONSTRAINT [FK_ApprienticeshipEnrollments_Enrollments]
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollments]  WITH CHECK ADD  CONSTRAINT [FK_ApprienticeshipEnrollments_LookupSectionalEnrollmentTypes] FOREIGN KEY([LookupSectionalEnrollmentTypeID])
REFERENCES [dbo].[LookupSectionalEnrollmentTypes] ([LookupSectionalEnrollmentTypeID])
GO
ALTER TABLE [dbo].[ApprienticeshipEnrollments] CHECK CONSTRAINT [FK_ApprienticeshipEnrollments_LookupSectionalEnrollmentTypes]
GO
ALTER TABLE [dbo].[Assessors]  WITH CHECK ADD  CONSTRAINT [FK_Assessors_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[Assessors] CHECK CONSTRAINT [FK_Assessors_Individuals]
GO
ALTER TABLE [dbo].[ComapnyContacts]  WITH CHECK ADD  CONSTRAINT [FK_ComapnyContacts_Companies] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([CompanyID])
GO
ALTER TABLE [dbo].[ComapnyContacts] CHECK CONSTRAINT [FK_ComapnyContacts_Companies]
GO
ALTER TABLE [dbo].[ComapnyContacts]  WITH CHECK ADD  CONSTRAINT [FK_ComapnyContacts_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[ComapnyContacts] CHECK CONSTRAINT [FK_ComapnyContacts_Individuals]
GO
ALTER TABLE [dbo].[CompanyAddresses]  WITH CHECK ADD  CONSTRAINT [FK_CompanyAddresses_Addresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
GO
ALTER TABLE [dbo].[CompanyAddresses] CHECK CONSTRAINT [FK_CompanyAddresses_Addresses]
GO
ALTER TABLE [dbo].[CompanyAddresses]  WITH CHECK ADD  CONSTRAINT [FK_CompanyAddresses_Companies] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([CompanyID])
GO
ALTER TABLE [dbo].[CompanyAddresses] CHECK CONSTRAINT [FK_CompanyAddresses_Companies]
GO
ALTER TABLE [dbo].[CompanyContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_CompanyContactDetails_Companies] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([CompanyID])
GO
ALTER TABLE [dbo].[CompanyContactDetails] CHECK CONSTRAINT [FK_CompanyContactDetails_Companies]
GO
ALTER TABLE [dbo].[CompanyContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_CompanyContactDetails_ContactDetails] FOREIGN KEY([ContactDetailID])
REFERENCES [dbo].[ContactDetails] ([ContactDetailID])
GO
ALTER TABLE [dbo].[CompanyContactDetails] CHECK CONSTRAINT [FK_CompanyContactDetails_ContactDetails]
GO
ALTER TABLE [dbo].[CompanyEnquiry]  WITH CHECK ADD  CONSTRAINT [FK_CompanyEnquiry_Companies] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([CompanyID])
GO
ALTER TABLE [dbo].[CompanyEnquiry] CHECK CONSTRAINT [FK_CompanyEnquiry_Companies]
GO
ALTER TABLE [dbo].[CompanyEnquiry]  WITH CHECK ADD  CONSTRAINT [FK_CompanyEnquiry_Enquiry] FOREIGN KEY([EnquiryID])
REFERENCES [dbo].[Enquiry] ([EnquiryID])
GO
ALTER TABLE [dbo].[CompanyEnquiry] CHECK CONSTRAINT [FK_CompanyEnquiry_Enquiry]
GO
ALTER TABLE [dbo].[ContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_ContactDetails_LookupContactTypes] FOREIGN KEY([ContactTypeID])
REFERENCES [dbo].[LookupContactTypes] ([ContactTypeID])
GO
ALTER TABLE [dbo].[ContactDetails] CHECK CONSTRAINT [FK_ContactDetails_LookupContactTypes]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[CourseSchedules]  WITH CHECK ADD  CONSTRAINT [FK_CourseSchedules_Students] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Students] ([IndividualID])
GO
ALTER TABLE [dbo].[CourseSchedules] CHECK CONSTRAINT [FK_CourseSchedules_Students]
GO
ALTER TABLE [dbo].[CurricullumCourseCodes]  WITH CHECK ADD  CONSTRAINT [FK_CurricullumCourseCodes_CurriculumCourses] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurricullumCourseCodes] CHECK CONSTRAINT [FK_CurricullumCourseCodes_CurriculumCourses]
GO
ALTER TABLE [dbo].[CurriculumCourseAssociatedSetas]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseAssociatedSetas_CurriculumCourses] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurriculumCourseAssociatedSetas] CHECK CONSTRAINT [FK_CurriculumCourseAssociatedSetas_CurriculumCourses]
GO
ALTER TABLE [dbo].[CurriculumCourseAssociatedSetas]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseAssociatedSetas_Setas] FOREIGN KEY([SetaID])
REFERENCES [dbo].[LookupSetas] ([SetaID])
GO
ALTER TABLE [dbo].[CurriculumCourseAssociatedSetas] CHECK CONSTRAINT [FK_CurriculumCourseAssociatedSetas_Setas]
GO
ALTER TABLE [dbo].[CurriculumCourseEnrollments]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseEnrollments_CurriculumCourses] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
GO
ALTER TABLE [dbo].[CurriculumCourseEnrollments] CHECK CONSTRAINT [FK_CurriculumCourseEnrollments_CurriculumCourses]
GO
ALTER TABLE [dbo].[CurriculumCourseEnrollments]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseEnrollments_Enrollments1] FOREIGN KEY([EnrollmentID])
REFERENCES [dbo].[Enrollments] ([EnrollmentID])
GO
ALTER TABLE [dbo].[CurriculumCourseEnrollments] CHECK CONSTRAINT [FK_CurriculumCourseEnrollments_Enrollments1]
GO
ALTER TABLE [dbo].[CurriculumCourseMinimumMaximums]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseMinimumMaximums_CurriculumCourses1] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurriculumCourseMinimumMaximums] CHECK CONSTRAINT [FK_CurriculumCourseMinimumMaximums_CurriculumCourses1]
GO
ALTER TABLE [dbo].[CurriculumCourseModuleActivities]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseModuleActivities_Activities] FOREIGN KEY([ActivityID])
REFERENCES [dbo].[Activities] ([ActivityID])
GO
ALTER TABLE [dbo].[CurriculumCourseModuleActivities] CHECK CONSTRAINT [FK_CurriculumCourseModuleActivities_Activities]
GO
ALTER TABLE [dbo].[CurriculumCourseModuleActivities]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseModuleActivities_CurriculumCourseModules] FOREIGN KEY([CurriculumCourseModuleID])
REFERENCES [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurriculumCourseModuleActivities] CHECK CONSTRAINT [FK_CurriculumCourseModuleActivities_CurriculumCourseModules]
GO
ALTER TABLE [dbo].[CurriculumCourseModules]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseModules_CurriculumCourses] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurriculumCourseModules] CHECK CONSTRAINT [FK_CurriculumCourseModules_CurriculumCourses]
GO
ALTER TABLE [dbo].[CurriculumCourseModules]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourseModules_Modules] FOREIGN KEY([ModuleID])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[CurriculumCourseModules] CHECK CONSTRAINT [FK_CurriculumCourseModules_Modules]
GO
ALTER TABLE [dbo].[CurriculumCoursePredecessors]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCoursePredecessors_CurriculumCourses] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
GO
ALTER TABLE [dbo].[CurriculumCoursePredecessors] CHECK CONSTRAINT [FK_CurriculumCoursePredecessors_CurriculumCourses]
GO
ALTER TABLE [dbo].[CurriculumCourses]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourses_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[CurriculumCourses] CHECK CONSTRAINT [FK_CurriculumCourses_Courses]
GO
ALTER TABLE [dbo].[CurriculumCourses]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourses_Curriculums] FOREIGN KEY([CurriculumID])
REFERENCES [dbo].[Curriculums] ([CurriculumID])
GO
ALTER TABLE [dbo].[CurriculumCourses] CHECK CONSTRAINT [FK_CurriculumCourses_Curriculums]
GO
ALTER TABLE [dbo].[CurriculumCourses]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumCourses_LookupEnrollmentTypes] FOREIGN KEY([EnrollmentTypeID])
REFERENCES [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID])
GO
ALTER TABLE [dbo].[CurriculumCourses] CHECK CONSTRAINT [FK_CurriculumCourses_LookupEnrollmentTypes]
GO
ALTER TABLE [dbo].[CurriculumEnquiries]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumEnquiries_Curriculums] FOREIGN KEY([CurriculumID])
REFERENCES [dbo].[Curriculums] ([CurriculumID])
GO
ALTER TABLE [dbo].[CurriculumEnquiries] CHECK CONSTRAINT [FK_CurriculumEnquiries_Curriculums]
GO
ALTER TABLE [dbo].[CurriculumEnquiries]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumEnquiries_Enquiry] FOREIGN KEY([EnquiryID])
REFERENCES [dbo].[Enquiry] ([EnquiryID])
GO
ALTER TABLE [dbo].[CurriculumEnquiries] CHECK CONSTRAINT [FK_CurriculumEnquiries_Enquiry]
GO
ALTER TABLE [dbo].[CurriculumEnquiries]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumEnquiries_LookupEnquiryStatuses] FOREIGN KEY([EnquiryStatusID])
REFERENCES [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID])
GO
ALTER TABLE [dbo].[CurriculumEnquiries] CHECK CONSTRAINT [FK_CurriculumEnquiries_LookupEnquiryStatuses]
GO
ALTER TABLE [dbo].[Curriculums]  WITH CHECK ADD  CONSTRAINT [FK_Curriculums_CostingModels] FOREIGN KEY([CostingModelID])
REFERENCES [dbo].[CostingModels] ([CostingModelID])
GO
ALTER TABLE [dbo].[Curriculums] CHECK CONSTRAINT [FK_Curriculums_CostingModels]
GO
ALTER TABLE [dbo].[Curriculums]  WITH CHECK ADD  CONSTRAINT [FK_Curriculums_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Curriculums] CHECK CONSTRAINT [FK_Curriculums_Departments]
GO
ALTER TABLE [dbo].[DepartmentResponsibleEmployees]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentResponsibleEmployees_Employees] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Employees] ([IndividualID])
GO
ALTER TABLE [dbo].[DepartmentResponsibleEmployees] CHECK CONSTRAINT [FK_DepartmentResponsibleEmployees_Employees]
GO
ALTER TABLE [dbo].[DepartmentResponsibleEmployees]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentResponsibleEmployees_LookupDepartments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
GO
ALTER TABLE [dbo].[DepartmentResponsibleEmployees] CHECK CONSTRAINT [FK_DepartmentResponsibleEmployees_LookupDepartments]
GO
ALTER TABLE [dbo].[EmailMessageRepositoryAttachments]  WITH CHECK ADD  CONSTRAINT [FK_EmailMessageRepositoryAttachments_EmailMessageRepository] FOREIGN KEY([EmailMessageRepositoryID])
REFERENCES [dbo].[EmailMessageRepository] ([EmailMessageRepositoryID])
GO
ALTER TABLE [dbo].[EmailMessageRepositoryAttachments] CHECK CONSTRAINT [FK_EmailMessageRepositoryAttachments_EmailMessageRepository]
GO
ALTER TABLE [dbo].[EmailSystemOutGoingMessageAttachments]  WITH CHECK ADD  CONSTRAINT [FK_EmailSystemOutGoingMessageAttachments_EmailSystemOutGoingMessages] FOREIGN KEY([EmailSystemOutGoingMessageID])
REFERENCES [dbo].[EmailSystemOutGoingMessages] ([EmailSystemOutGoingMessageID])
GO
ALTER TABLE [dbo].[EmailSystemOutGoingMessageAttachments] CHECK CONSTRAINT [FK_EmailSystemOutGoingMessageAttachments_EmailSystemOutGoingMessages]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Individuals]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Curriculums] FOREIGN KEY([CurriculumID])
REFERENCES [dbo].[Curriculums] ([CurriculumID])
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Curriculums]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_LookupEnrollmentProgressStates] FOREIGN KEY([LookupEnrollmentProgressStateID])
REFERENCES [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID])
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_LookupEnrollmentProgressStates]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Students] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Students] ([IndividualID])
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Students]
GO
ALTER TABLE [dbo].[EquiryAssociatedContacts]  WITH CHECK ADD  CONSTRAINT [FK_EquiryAssociatedContacts_Enquiry] FOREIGN KEY([EnquiryID])
REFERENCES [dbo].[Enquiry] ([EnquiryID])
GO
ALTER TABLE [dbo].[EquiryAssociatedContacts] CHECK CONSTRAINT [FK_EquiryAssociatedContacts_Enquiry]
GO
ALTER TABLE [dbo].[EquiryAssociatedContacts]  WITH CHECK ADD  CONSTRAINT [FK_EquiryAssociatedContacts_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[EquiryAssociatedContacts] CHECK CONSTRAINT [FK_EquiryAssociatedContacts_Individuals]
GO
ALTER TABLE [dbo].[EquiryHistory]  WITH CHECK ADD  CONSTRAINT [FK_EquiryHistory_Employees] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Employees] ([IndividualID])
GO
ALTER TABLE [dbo].[EquiryHistory] CHECK CONSTRAINT [FK_EquiryHistory_Employees]
GO
ALTER TABLE [dbo].[EquiryHistory]  WITH CHECK ADD  CONSTRAINT [FK_EquiryHistory_Enquiry] FOREIGN KEY([EnquiryID])
REFERENCES [dbo].[Enquiry] ([EnquiryID])
GO
ALTER TABLE [dbo].[EquiryHistory] CHECK CONSTRAINT [FK_EquiryHistory_Enquiry]
GO
ALTER TABLE [dbo].[EquiryHistory]  WITH CHECK ADD  CONSTRAINT [FK_EquiryHistory_LookupEquiryHistoryTypes] FOREIGN KEY([LookupEquiyHistoryTypeID])
REFERENCES [dbo].[LookupEquiryHistoryTypes] ([LookupEquiyHistoryTypeID])
GO
ALTER TABLE [dbo].[EquiryHistory] CHECK CONSTRAINT [FK_EquiryHistory_LookupEquiryHistoryTypes]
GO
ALTER TABLE [dbo].[FacilitatorAssociatedCourses]  WITH CHECK ADD  CONSTRAINT [FK_FacilitatorAssociatedCourses_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[FacilitatorAssociatedCourses] CHECK CONSTRAINT [FK_FacilitatorAssociatedCourses_Courses]
GO
ALTER TABLE [dbo].[FacilitatorAssociatedCourses]  WITH CHECK ADD  CONSTRAINT [FK_FacilitatorAssociatedCourses_Facilitators] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Facilitators] ([IndividualID])
GO
ALTER TABLE [dbo].[FacilitatorAssociatedCourses] CHECK CONSTRAINT [FK_FacilitatorAssociatedCourses_Facilitators]
GO
ALTER TABLE [dbo].[FacilitatorQualifications]  WITH CHECK ADD  CONSTRAINT [FK_FacilitatorQualifications_Facilitators] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Facilitators] ([IndividualID])
GO
ALTER TABLE [dbo].[FacilitatorQualifications] CHECK CONSTRAINT [FK_FacilitatorQualifications_Facilitators]
GO
ALTER TABLE [dbo].[FacilitatorQualifications]  WITH CHECK ADD  CONSTRAINT [FK_FacilitatorQualifications_Qualifications] FOREIGN KEY([QualificationID])
REFERENCES [dbo].[Qualifications] ([QualificationID])
GO
ALTER TABLE [dbo].[FacilitatorQualifications] CHECK CONSTRAINT [FK_FacilitatorQualifications_Qualifications]
GO
ALTER TABLE [dbo].[Facilitators]  WITH CHECK ADD  CONSTRAINT [FK_Facilitators_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[Facilitators] CHECK CONSTRAINT [FK_Facilitators_Individuals]
GO
ALTER TABLE [dbo].[FacilitatorSetaAccreditations]  WITH CHECK ADD  CONSTRAINT [FK_FacilitatorSetaAccreditations_Facilitators] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Facilitators] ([IndividualID])
GO
ALTER TABLE [dbo].[FacilitatorSetaAccreditations] CHECK CONSTRAINT [FK_FacilitatorSetaAccreditations_Facilitators]
GO
ALTER TABLE [dbo].[IndividualAddresses]  WITH CHECK ADD  CONSTRAINT [FK_IndividualAddresses_Addresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
GO
ALTER TABLE [dbo].[IndividualAddresses] CHECK CONSTRAINT [FK_IndividualAddresses_Addresses]
GO
ALTER TABLE [dbo].[IndividualAddresses]  WITH CHECK ADD  CONSTRAINT [FK_IndividualAddresses_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[IndividualAddresses] CHECK CONSTRAINT [FK_IndividualAddresses_Individuals]
GO
ALTER TABLE [dbo].[IndividualContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_IndividualContactDetails_ContactDetails] FOREIGN KEY([ContactDetailID])
REFERENCES [dbo].[ContactDetails] ([ContactDetailID])
GO
ALTER TABLE [dbo].[IndividualContactDetails] CHECK CONSTRAINT [FK_IndividualContactDetails_ContactDetails]
GO
ALTER TABLE [dbo].[IndividualContactDetails]  WITH CHECK ADD  CONSTRAINT [FK_IndividualContactDetails_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[IndividualContactDetails] CHECK CONSTRAINT [FK_IndividualContactDetails_Individuals]
GO
ALTER TABLE [dbo].[Individuals]  WITH CHECK ADD  CONSTRAINT [FK_Individuals_LookupTitles] FOREIGN KEY([TitleID])
REFERENCES [dbo].[LookupTitles] ([TitleID])
GO
ALTER TABLE [dbo].[Individuals] CHECK CONSTRAINT [FK_Individuals_LookupTitles]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Employees] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Employees] ([IndividualID])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Employees]
GO
ALTER TABLE [dbo].[Modules]  WITH CHECK ADD  CONSTRAINT [FK_Modules_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Modules] CHECK CONSTRAINT [FK_Modules_Departments]
GO
ALTER TABLE [dbo].[NextOfKins]  WITH CHECK ADD  CONSTRAINT [FK_NextOfKins_Individuals] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[NextOfKins] CHECK CONSTRAINT [FK_NextOfKins_Individuals]
GO
ALTER TABLE [dbo].[NextOfKins]  WITH CHECK ADD  CONSTRAINT [FK_NextOfKins_LookupTypeOfRelations] FOREIGN KEY([TypeOfRelationID])
REFERENCES [dbo].[LookupTypeOfRelations] ([TypeOfRelationID])
GO
ALTER TABLE [dbo].[NextOfKins] CHECK CONSTRAINT [FK_NextOfKins_LookupTypeOfRelations]
GO
ALTER TABLE [dbo].[StudentAssociatedCompany]  WITH CHECK ADD  CONSTRAINT [FK_StudentAssociatedCompany_Companies] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([CompanyID])
GO
ALTER TABLE [dbo].[StudentAssociatedCompany] CHECK CONSTRAINT [FK_StudentAssociatedCompany_Companies]
GO
ALTER TABLE [dbo].[StudentAssociatedCompany]  WITH CHECK ADD  CONSTRAINT [FK_StudentAssociatedCompany_Students] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Students] ([IndividualID])
GO
ALTER TABLE [dbo].[StudentAssociatedCompany] CHECK CONSTRAINT [FK_StudentAssociatedCompany_Students]
GO
ALTER TABLE [dbo].[StudentDisabilities]  WITH CHECK ADD  CONSTRAINT [FK_StudentDisabilities_LookupDisabilities] FOREIGN KEY([DisabilityID])
REFERENCES [dbo].[LookupDisabilities] ([DisabilityID])
GO
ALTER TABLE [dbo].[StudentDisabilities] CHECK CONSTRAINT [FK_StudentDisabilities_LookupDisabilities]
GO
ALTER TABLE [dbo].[StudentDisabilities]  WITH CHECK ADD  CONSTRAINT [FK_StudentDisabilities_Students] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Students] ([IndividualID])
GO
ALTER TABLE [dbo].[StudentDisabilities] CHECK CONSTRAINT [FK_StudentDisabilities_Students]
GO
ALTER TABLE [dbo].[StudentNextOfKins]  WITH CHECK ADD  CONSTRAINT [FK_StudentNextOfKins_NextOfKins] FOREIGN KEY([NextOfKinID])
REFERENCES [dbo].[NextOfKins] ([IndividualID])
GO
ALTER TABLE [dbo].[StudentNextOfKins] CHECK CONSTRAINT [FK_StudentNextOfKins_NextOfKins]
GO
ALTER TABLE [dbo].[StudentNextOfKins]  WITH CHECK ADD  CONSTRAINT [FK_StudentNextOfKins_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([IndividualID])
GO
ALTER TABLE [dbo].[StudentNextOfKins] CHECK CONSTRAINT [FK_StudentNextOfKins_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Individuals1] FOREIGN KEY([IndividualID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Individuals1]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_LookupEthnicities] FOREIGN KEY([EthnicityID])
REFERENCES [dbo].[LookupEthnicities] ([EthnicityID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_LookupEthnicities]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_LookupGenders] FOREIGN KEY([GenderID])
REFERENCES [dbo].[LookupGenders] ([GenderID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_LookupGenders]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_LookupMartialStatuses] FOREIGN KEY([MartialStatusID])
REFERENCES [dbo].[LookupMartialStatuses] ([MartialStatusID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_LookupMartialStatuses]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_LookupQualificationLevels] FOREIGN KEY([QualificationLevelID])
REFERENCES [dbo].[LookupQualificationLevels] ([QualificationLevelID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_LookupQualificationLevels]
GO
ALTER TABLE [dbo].[SystemAdministrator]  WITH CHECK ADD  CONSTRAINT [FK_SystemAdministrator_Individuals] FOREIGN KEY([SystemAdministratorID])
REFERENCES [dbo].[Individuals] ([IndividualID])
GO
ALTER TABLE [dbo].[SystemAdministrator] CHECK CONSTRAINT [FK_SystemAdministrator_Individuals]
GO
ALTER TABLE [dbo].[VenueAssociatedCurriculumCourses]  WITH CHECK ADD  CONSTRAINT [FK_VenueAssociatedCurriculumCourses_CurriculumCourses] FOREIGN KEY([CurriculumCourseID])
REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
GO
ALTER TABLE [dbo].[VenueAssociatedCurriculumCourses] CHECK CONSTRAINT [FK_VenueAssociatedCurriculumCourses_CurriculumCourses]
GO
ALTER TABLE [dbo].[VenueAssociatedCurriculumCourses]  WITH CHECK ADD  CONSTRAINT [FK_VenueAssociatedCurriculumCourses_Venues] FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venues] ([VenueID])
GO
ALTER TABLE [dbo].[VenueAssociatedCurriculumCourses] CHECK CONSTRAINT [FK_VenueAssociatedCurriculumCourses_Venues]
GO
