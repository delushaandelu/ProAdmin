USE [proadmin_v1]
GO
/****** Object:  Table [dbo].[basicdata_student]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdata_student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[regid] [varchar](200) NOT NULL,
	[Firstname] [varchar](200) NULL,
	[Lastname] [varchar](200) NULL,
	[Nic] [varchar](200) NULL,
	[Dob] [varchar](200) NULL,
	[home_address] [varchar](200) NULL,
	[Home_tell] [varchar](200) NULL,
	[Staying_address] [varchar](200) NULL,
	[Stay_home_tell] [varchar](200) NULL,
	[Father_name] [varchar](200) NULL,
	[Parents_contact] [varchar](200) NULL,
	[Ol_School] [varchar](200) NULL,
	[Al_school] [varchar](200) NULL,
	[Ol_result] [varchar](200) NULL,
	[JoinDate] [varchar](200) NULL,
	[Batch] [varchar](200) NULL,
	[Scholarship] [varchar](200) NULL,
 CONSTRAINT [PK_basicdata_student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[data_examresults]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_examresults](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[exam] [varchar](50) NULL,
	[batch] [varchar](50) NULL,
	[regid] [varchar](50) NULL,
	[subject_1] [decimal](18, 2) NULL,
	[subject_2] [decimal](18, 2) NULL,
	[subject_3] [decimal](18, 2) NULL,
	[English] [decimal](18, 2) NULL,
	[git] [decimal](18, 2) NULL,
	[total_marks] [decimal](18, 2) NULL,
	[average_marks] [decimal](18, 2) NULL,
	[rank] [int] NULL,
	[avg_state] [varchar](50) NULL,
	[exam_date] [varchar](50) NULL,
 CONSTRAINT [PK_data_examresults] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_missing_exam_results]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_missing_exam_results]
AS
SELECT        dbo.basicdata_student.regid, dbo.basicdata_student.Firstname, dbo.basicdata_student.Batch, dbo.data_examresults.exam, dbo.data_examresults.subject_1, dbo.data_examresults.subject_2, dbo.data_examresults.subject_3, 
                         dbo.data_examresults.English, dbo.data_examresults.git, dbo.data_examresults.total_marks, dbo.data_examresults.average_marks, dbo.data_examresults.rank, dbo.data_examresults.avg_state, 
                         dbo.data_examresults.exam_date
FROM            dbo.basicdata_student LEFT OUTER JOIN
                         dbo.data_examresults ON dbo.basicdata_student.regid = dbo.data_examresults.regid
GO
/****** Object:  View [dbo].[view_missing_student_record]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_missing_student_record]
AS
SELECT        dbo.basicdata_student.regid, dbo.basicdata_student.Firstname, dbo.basicdata_student.Batch, dbo.data_examresults.exam, dbo.data_examresults.subject_1, dbo.data_examresults.subject_2, dbo.data_examresults.subject_3, 
                         dbo.data_examresults.English, dbo.data_examresults.git, dbo.data_examresults.total_marks, dbo.data_examresults.average_marks, dbo.data_examresults.rank, dbo.data_examresults.avg_state, 
                         dbo.data_examresults.exam_date
FROM            dbo.basicdata_student LEFT OUTER JOIN
                         dbo.data_examresults ON dbo.basicdata_student.regid = dbo.data_examresults.regid
GO
/****** Object:  View [dbo].[view_exam_results_summary]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_exam_results_summary]
AS
SELECT        dbo.data_examresults.batch, dbo.data_examresults.exam_date, dbo.basicdata_student.regid, dbo.basicdata_student.Firstname, dbo.basicdata_student.Lastname, dbo.basicdata_student.Al_school, 
                         dbo.data_examresults.subject_1, dbo.data_examresults.subject_2, dbo.data_examresults.subject_3, dbo.data_examresults.total_marks, dbo.data_examresults.rank, dbo.data_examresults.avg_state, 
                         dbo.data_examresults.average_marks, dbo.data_examresults.English, dbo.data_examresults.git, dbo.data_examresults.exam
FROM            dbo.basicdata_student INNER JOIN
                         dbo.data_examresults ON dbo.basicdata_student.regid = dbo.data_examresults.regid
GO
/****** Object:  Table [dbo].[basicdata_batch]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdata_batch](
	[batchid] [int] IDENTITY(1,1) NOT NULL,
	[batch] [varchar](50) NULL,
	[log] [varchar](50) NULL,
 CONSTRAINT [PK_basicdata_batch] PRIMARY KEY CLUSTERED 
(
	[batchid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basicdata_school]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdata_school](
	[schid] [int] IDENTITY(1,1) NOT NULL,
	[schoolname] [varchar](200) NULL,
	[log] [varchar](200) NULL,
 CONSTRAINT [PK_basicdata_school] PRIMARY KEY CLUSTERED 
(
	[schid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basicdata_subject]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdata_subject](
	[subid] [int] IDENTITY(1,1) NOT NULL,
	[subject] [varchar](100) NULL,
	[teacher] [varchar](200) NULL,
	[log] [varchar](50) NULL,
 CONSTRAINT [PK_basicdata_subject] PRIMARY KEY CLUSTERED 
(
	[subid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basicdata_university]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdata_university](
	[uniid] [int] IDENTITY(1,1) NOT NULL,
	[uniname] [varchar](200) NULL,
	[log] [varchar](100) NULL,
 CONSTRAINT [PK_basicdata_university] PRIMARY KEY CLUSTERED 
(
	[uniid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basicdata_users]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdata_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [varchar](200) NULL,
	[nic] [varchar](25) NULL,
	[email] [varchar](200) NULL,
	[phone] [int] NULL,
	[role] [varchar](200) NULL,
	[status] [varchar](200) NULL,
	[username] [varchar](200) NULL,
	[password] [varchar](200) NULL,
	[log] [varchar](200) NULL,
 CONSTRAINT [PK_basicdata_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basicdate_schedule]    Script Date: 7/21/2020 10:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basicdate_schedule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[exam] [varchar](200) NULL,
	[start_date] [varchar](200) NULL,
	[end_date] [varchar](200) NULL,
	[state] [varchar](50) NULL,
	[exam_type] [varchar](50) NULL,
	[batch] [varchar](50) NULL,
 CONSTRAINT [PK_basicdate_schedule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "basicdata_student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 281
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "data_examresults"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 313
               Right = 648
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_exam_results_summary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_exam_results_summary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[29] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "basicdata_student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 339
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "data_examresults"
            Begin Extent = 
               Top = 10
               Left = 423
               Bottom = 337
               Right = 927
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_missing_exam_results'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_missing_exam_results'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[29] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "basicdata_student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 339
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "data_examresults"
            Begin Extent = 
               Top = 10
               Left = 423
               Bottom = 337
               Right = 927
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_missing_student_record'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_missing_student_record'
GO
