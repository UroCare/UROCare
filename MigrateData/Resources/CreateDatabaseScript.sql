/****** Object:  Table [dbo].[Param_Master]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Param_Master](
	[Param_Id] [nvarchar](80) NULL,
	[Param_Value] [nvarchar](50) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Master].[Param_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Master', @level2type=N'COLUMN',@level2name=N'Param_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Master].[Param_Value]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Master', @level2type=N'COLUMN',@level2name=N'Param_Value'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Master]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Master'
GO
/****** Object:  Table [dbo].[Param_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Param_Dtls](
	[Param_ID] [nvarchar](50) NULL,
	[Param_Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Param_Dtls$Param_ID] ON [dbo].[Param_Dtls] 
(
	[Param_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Dtls].[Param_ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Dtls', @level2type=N'COLUMN',@level2name=N'Param_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Dtls].[Param_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Dtls', @level2type=N'COLUMN',@level2name=N'Param_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Param_Dtls].[Param_ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Param_Dtls', @level2type=N'INDEX',@level2name=N'Param_Dtls$Param_ID'
GO
/****** Object:  Table [dbo].[Investigation_Master]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investigation_Master](
	[Sr_No] [int] NOT NULL,
	[Test_Name] [nvarchar](150) NULL,
	[Description] [nvarchar](255) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Created_Dte] [datetime2](0) NULL,
	[Modified_By] [nvarchar](30) NULL,
	[Modified_Dte] [datetime2](0) NULL,
 CONSTRAINT [Investigation_Master$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Sr_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Sr_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Sr_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Test_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Test_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Description]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Created_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Created_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Modified_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Modified_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[Modified_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'COLUMN',@level2name=N'Modified_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Master].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Master', @level2type=N'CONSTRAINT',@level2name=N'Investigation_Master$PrimaryKey'
GO
/****** Object:  Table [dbo].[Doctors_List]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors_List](
	[DR_NO] [int] NOT NULL,
	[Doctor_Name] [nvarchar](80) NOT NULL,
	[At_Post] [nvarchar](100) NOT NULL,
	[Taluka] [nvarchar](50) NULL,
	[District] [nvarchar](50) NULL,
	[Phone] [nvarchar](15) NULL,
	[Mobile] [nvarchar](10) NULL,
	[Birth_Dte] [datetime2](0) NULL,
	[Dr_Email] [nvarchar](50) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [Doctors_List$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[DR_NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[DR_NO]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'DR_NO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Doctor_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Doctor_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[At_Post]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'At_Post'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Taluka]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Taluka'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[District]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'District'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Phone]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Mobile]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Birth_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Birth_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Dr_Email]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Dr_Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Doctors_List].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doctors_List', @level2type=N'CONSTRAINT',@level2name=N'Doctors_List$PrimaryKey'
GO
/****** Object:  Table [dbo].[Image_Master]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image_Master](
	[Image_Id] [int] NOT NULL,
	[Image_Name] [nvarchar](100) NULL,
	[Path] [nvarchar](250) NULL,
 CONSTRAINT [Image_Master$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Image_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Image_Master$Image_Id] ON [dbo].[Image_Master] 
(
	[Image_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Image_Master].[Image_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Image_Master', @level2type=N'COLUMN',@level2name=N'Image_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Image_Master].[Image_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Image_Master', @level2type=N'COLUMN',@level2name=N'Image_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Image_Master].[Path]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Image_Master', @level2type=N'COLUMN',@level2name=N'Path'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Image_Master]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Image_Master'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Image_Master].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Image_Master', @level2type=N'CONSTRAINT',@level2name=N'Image_Master$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Image_Master].[Image_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Image_Master', @level2type=N'INDEX',@level2name=N'Image_Master$Image_Id'
GO
/****** Object:  Table [dbo].[User_Master]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Master](
	[User_Id] [nvarchar](20) NOT NULL,
	[User_Name] [nvarchar](80) NOT NULL,
	[User_Pwd] [nvarchar](20) NOT NULL,
	[Date_Pwd_Change] [datetime2](0) NOT NULL,
	[Active_User] [nvarchar](1) NULL,
	[Attempts_No] [smallint] NULL,
	[Lock_User] [nvarchar](1) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [User_Master$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [User_Master$User_Id] ON [dbo].[User_Master] 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[User_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'User_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[User_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'User_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[User_Pwd]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'User_Pwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Date_Pwd_Change]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Date_Pwd_Change'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Active_User]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Active_User'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Attempts_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Attempts_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Lock_User]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Lock_User'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'CONSTRAINT',@level2name=N'User_Master$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Master].[User_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Master', @level2type=N'INDEX',@level2name=N'User_Master$User_Id'
GO
/****** Object:  Table [dbo].[Patient_Info]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Info](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[Reg_Date] [datetime2](0) NOT NULL,
	[Salutation] [nvarchar](20) NOT NULL,
	[Patient_Name] [nvarchar](80) NOT NULL,
	[Age_Yr] [smallint] NULL,
	[Age_Mnth] [smallint] NULL,
	[Sex] [smallint] NULL,
	[Occupation] [nvarchar](50) NULL,
	[DR_No] [int] NULL,
	[At_Post] [nvarchar](80) NOT NULL,
	[Town] [nvarchar](50) NOT NULL,
	[District] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Prov_Diagnosis] [nvarchar](150) NULL,
	[Final_Diagnosis] [nvarchar](150) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [Patient_Info$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Patient_Info$Doctors_ListPatient_Info] ON [dbo].[Patient_Info] 
(
	[DR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Patient_Info$Ref_Dr_Code] ON [dbo].[Patient_Info] 
(
	[DR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Reg_Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Reg_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Salutation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Salutation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Patient_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Patient_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Age_Yr]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Age_Yr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Age_Mnth]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Age_Mnth'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Sex]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Occupation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Occupation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[DR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'DR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[At_Post]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'At_Post'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Town]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Town'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[District]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'District'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[State]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Phone]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Mobile]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Prov_Diagnosis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Prov_Diagnosis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Final_Diagnosis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Final_Diagnosis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'CONSTRAINT',@level2name=N'Patient_Info$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Doctors_ListPatient_Info]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'INDEX',@level2name=N'Patient_Info$Doctors_ListPatient_Info'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Ref_Dr_Code]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'INDEX',@level2name=N'Patient_Info$Ref_Dr_Code'
GO
/****** Object:  Table [dbo].[User_Login_Dtl]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login_Dtl](
	[User_Id] [nvarchar](20) NOT NULL,
	[Login_Dte] [datetime2](0) NULL,
	[Logout_Dte] [datetime2](0) NULL,
	[Role] [nvarchar](80) NULL,
	[User_Stat] [nvarchar](1) NOT NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [User_Login_Dtl$User_Id] ON [dbo].[User_Login_Dtl] 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [User_Login_Dtl$User_MasterUser_Login_Dtl] ON [dbo].[User_Login_Dtl] 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[User_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'COLUMN',@level2name=N'User_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[Login_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'COLUMN',@level2name=N'Login_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[Logout_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'COLUMN',@level2name=N'Logout_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'COLUMN',@level2name=N'Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[User_Stat]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'COLUMN',@level2name=N'User_Stat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[User_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'INDEX',@level2name=N'User_Login_Dtl$User_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[User_MasterUser_Login_Dtl]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'INDEX',@level2name=N'User_Login_Dtl$User_MasterUser_Login_Dtl'
GO
/****** Object:  Table [dbo].[User_Role]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Role](
	[User_Id] [nvarchar](20) NULL,
	[Role] [smallint] NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [User_Role$User_Id] ON [dbo].[User_Role] 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [User_Role$User_MasterUser_Role] ON [dbo].[User_Role] 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[User_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'COLUMN',@level2name=N'User_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'COLUMN',@level2name=N'Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[User_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'INDEX',@level2name=N'User_Role$User_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[User_MasterUser_Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'INDEX',@level2name=N'User_Role$User_MasterUser_Role'
GO
/****** Object:  Table [dbo].[X_Ray]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[X_Ray](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[SR_No] [int] NOT NULL,
	[XRay_Dte] [datetime2](0) NULL,
	[XRay_Name] [nvarchar](70) NULL,
	[File_Path] [nvarchar](150) NULL,
	[Comments] [nvarchar](250) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [X_Ray$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[SR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [X_Ray$Patient_InfoX_Ray] ON [dbo].[X_Ray] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[SR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'SR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[XRay_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'XRay_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[XRay_Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'XRay_Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[File_Path]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'File_Path'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Comments]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'CONSTRAINT',@level2name=N'X_Ray$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Patient_InfoX_Ray]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'INDEX',@level2name=N'X_Ray$Patient_InfoX_Ray'
GO
/****** Object:  Table [dbo].[Investigation]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investigation](
	[Gu_No] [int] NULL,
	[Gu_Year] [int] NULL,
	[Urine] [nvarchar](250) NULL,
	[HB] [nvarchar](6) NULL,
	[TC] [nvarchar](7) NULL,
	[DC] [nvarchar](8) NULL,
	[SR_NA_Plus] [nvarchar](5) NULL,
	[SR_K_Plus] [nvarchar](5) NULL,
	[SR_CA_Plus] [nvarchar](5) NULL,
	[SR_Uric_Acid] [nvarchar](5) NULL,
	[HIV] [nvarchar](20) NULL,
	[SR_Creat] [nvarchar](5) NULL,
	[HBS_AG] [nvarchar](20) NULL,
	[BUL] [nvarchar](5) NULL,
	[ESR] [nvarchar](20) NULL,
	[Urine_Chyle] [nvarchar](80) NULL,
	[BSL] [nvarchar](80) NULL,
	[USG] [nvarchar](250) NULL,
	[KUB] [nvarchar](250) NULL,
	[IVP] [nvarchar](250) NULL,
	[RGU] [nvarchar](250) NULL,
	[MCU] [nvarchar](250) NULL,
	[NCHCT] [nvarchar](250) NULL,
	[DTPA_Reno] [nvarchar](250) NULL,
	[TRUS] [nvarchar](250) NULL,
	[Sr_PSA] [nvarchar](50) NULL,
	[CT_Scan] [nvarchar](250) NULL,
	[Urine_CS] [nvarchar](250) NULL,
	[IgM] [nvarchar](50) NULL,
	[IgA] [nvarchar](50) NULL,
	[IgG] [nvarchar](50) NULL,
	[Urine_AFB] [nvarchar](50) NULL,
	[BACTEC] [nvarchar](50) NULL,
	[PCR] [nvarchar](50) NULL,
	[Volume] [nvarchar](50) NULL,
	[PH] [nvarchar](50) NULL,
	[Calcium] [nvarchar](50) NULL,
	[Uric_Acid] [nvarchar](50) NULL,
	[Sodium] [nvarchar](50) NULL,
	[Oxalate] [nvarchar](50) NULL,
	[Citrate] [nvarchar](50) NULL,
	[Sulfate] [nvarchar](50) NULL,
	[Phosphorous] [nvarchar](50) NULL,
	[Stone_Analysis] [nvarchar](250) NULL,
	[Bone_Scan] [nvarchar](250) NULL,
	[MRI] [nvarchar](250) NULL,
	[Others] [nvarchar](250) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Investigation$Patient_InfoInvestigation] ON [dbo].[Investigation] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Investigation$SR_Uric_Acid] ON [dbo].[Investigation] 
(
	[SR_Uric_Acid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Investigation$Uric_Acid] ON [dbo].[Investigation] 
(
	[Uric_Acid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Urine]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Urine'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[HB]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'HB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[TC]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'TC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[DC]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'DC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[SR_NA_Plus]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'SR_NA_Plus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[SR_K_Plus]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'SR_K_Plus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[SR_CA_Plus]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'SR_CA_Plus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[SR_Uric_Acid]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'SR_Uric_Acid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[HIV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'HIV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[SR_Creat]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'SR_Creat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[HBS_AG]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'HBS_AG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[BUL]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'BUL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[ESR]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'ESR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Urine_Chyle]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Urine_Chyle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[BSL]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'BSL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[USG]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'USG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[KUB]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'KUB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[IVP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'IVP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[RGU]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'RGU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[MCU]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'MCU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[NCHCT]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'NCHCT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[DTPA_Reno]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'DTPA_Reno'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[TRUS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'TRUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Sr_PSA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Sr_PSA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[CT_Scan]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'CT_Scan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Urine_CS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Urine_CS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[IgM]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'IgM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[IgA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'IgA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[IgG]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'IgG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Urine_AFB]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Urine_AFB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[BACTEC]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'BACTEC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[PCR]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'PCR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Volume]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[PH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'PH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Calcium]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Calcium'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Uric_Acid]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Uric_Acid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Sodium]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Sodium'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Oxalate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Oxalate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Citrate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Citrate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Sulfate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Sulfate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Phosphorous]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Phosphorous'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Stone_Analysis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Stone_Analysis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Bone_Scan]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Bone_Scan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[MRI]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'MRI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Others]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Others'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Patient_InfoInvestigation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'INDEX',@level2name=N'Investigation$Patient_InfoInvestigation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[SR_Uric_Acid]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'INDEX',@level2name=N'Investigation$SR_Uric_Acid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Uric_Acid]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'INDEX',@level2name=N'Investigation$Uric_Acid'
GO
/****** Object:  Table [dbo].[Images]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Images](
	[GU_No] [int] NOT NULL,
	[GU_Year] [int] NOT NULL,
	[Sr_No] [int] NOT NULL,
	[Image_Id] [int] NULL,
	[Image_Date] [datetime2](0) NULL,
	[Comments] [nvarchar](255) NULL,
	[Image_Captured] [varbinary](max) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Created_Dte] [datetime2](0) NULL,
	[Modified_By] [nvarchar](30) NULL,
	[Modified_Dte] [datetime2](0) NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [Images$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[GU_No] ASC,
	[GU_Year] ASC,
	[Sr_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [Images$Image_Id] ON [dbo].[Images] 
(
	[Image_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Images$Image_MasterImages] ON [dbo].[Images] 
(
	[Image_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Images$Patient_InfoImages] ON [dbo].[Images] 
(
	[GU_No] ASC,
	[GU_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[GU_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'GU_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[GU_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'GU_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Sr_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Sr_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Image_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Image_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Image_Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Image_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Comments]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Image_Captured]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Image_Captured'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Created_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Created_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Modified_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Modified_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Modified_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'COLUMN',@level2name=N'Modified_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'CONSTRAINT',@level2name=N'Images$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Image_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'INDEX',@level2name=N'Images$Image_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Image_MasterImages]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'INDEX',@level2name=N'Images$Image_MasterImages'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Patient_InfoImages]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'INDEX',@level2name=N'Images$Patient_InfoImages'
GO
/****** Object:  Table [dbo].[Operation_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operation_Dtls](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[SR_No] [int] NOT NULL,
	[Operation_Dte] [datetime2](0) NULL,
	[Anesthesia] [nvarchar](70) NULL,
	[Anaesthesiologist] [int] NULL,
	[Opern_Procedure] [nvarchar](100) NULL,
	[Details] [nvarchar](250) NULL,
	[Remarks] [nvarchar](150) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Created_Dte] [datetime2](0) NULL,
	[Modified_By] [nvarchar](30) NULL,
	[Modified_Dte] [datetime2](0) NULL,
 CONSTRAINT [Operation_Dtls$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[SR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Operation_Dtls$Doctors_ListOperation_Dtls] ON [dbo].[Operation_Dtls] 
(
	[Anaesthesiologist] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Operation_Dtls$Operation_DtlsGu_No] ON [dbo].[Operation_Dtls] 
(
	[Gu_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Operation_Dtls$Patient_InfoOperation_Dtls] ON [dbo].[Operation_Dtls] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[SR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'SR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Operation_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Operation_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Anesthesia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Anesthesia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Anaesthesiologist]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Anaesthesiologist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Opern_Procedure]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Opern_Procedure'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Details]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Details'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Remarks]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Created_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Created_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Modified_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Modified_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Modified_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'COLUMN',@level2name=N'Modified_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Operation_Dtls$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Doctors_ListOperation_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'INDEX',@level2name=N'Operation_Dtls$Doctors_ListOperation_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Operation_DtlsGu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'INDEX',@level2name=N'Operation_Dtls$Operation_DtlsGu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Patient_InfoOperation_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'INDEX',@level2name=N'Operation_Dtls$Patient_InfoOperation_Dtls'
GO
/****** Object:  Table [dbo].[IPD]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IPD](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[SR_No] [int] NOT NULL,
	[IPD_No] [nvarchar](30) NOT NULL,
	[Admission_Dte] [datetime2](0) NULL,
	[Discharge_Dte] [datetime2](0) NULL,
	[Complaints] [nvarchar](250) NULL,
	[Advice] [nvarchar](250) NULL,
	[Followup_Dte] [datetime2](0) NULL,
	[Prov_Diagnosis] [nvarchar](150) NULL,
	[Final_Diagnosis] [nvarchar](150) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [IPD$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[SR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IPD$Patient_InfoIPD] ON [dbo].[IPD] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[SR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'SR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[IPD_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'IPD_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Admission_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Admission_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Discharge_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Discharge_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Complaints]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Complaints'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Advice]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Advice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Followup_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Followup_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Prov_Diagnosis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Prov_Diagnosis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Final_Diagnosis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Final_Diagnosis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'CONSTRAINT',@level2name=N'IPD$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Patient_InfoIPD]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'INDEX',@level2name=N'IPD$Patient_InfoIPD'
GO
/****** Object:  Table [dbo].[Investigation_Test_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investigation_Test_Dtls](
	[GU_No] [int] NULL,
	[GU_Year] [int] NULL,
	[Sr_No] [int] NULL,
	[Test_Date] [datetime2](0) NULL,
	[Test_Id] [int] NULL,
	[Test_Done] [nvarchar](1) NULL,
	[Test_Done_Date] [datetime2](0) NULL,
	[Test_Dtls] [nvarchar](255) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Created_Dte] [datetime2](0) NULL,
	[Modified_By] [nvarchar](30) NULL,
	[Modified_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Investigation_Test_Dtls$Investigation_Test_DtlsSr_No] ON [dbo].[Investigation_Test_Dtls] 
(
	[Sr_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Investigation_Test_Dtls$Patient_InfoInvestigation_Test_Dtls] ON [dbo].[Investigation_Test_Dtls] 
(
	[GU_No] ASC,
	[GU_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Investigation_Test_Dtls$Test_Id] ON [dbo].[Investigation_Test_Dtls] 
(
	[Test_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[GU_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'GU_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[GU_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'GU_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Sr_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Sr_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Test_Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Test_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Test_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Test_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Test_Done]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Test_Done'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Test_Done_Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Test_Done_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Test_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Test_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Created_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Created_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Modified_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Modified_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Modified_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'COLUMN',@level2name=N'Modified_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Investigation_Test_DtlsSr_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'INDEX',@level2name=N'Investigation_Test_Dtls$Investigation_Test_DtlsSr_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Patient_InfoInvestigation_Test_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'INDEX',@level2name=N'Investigation_Test_Dtls$Patient_InfoInvestigation_Test_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Test_Id]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'INDEX',@level2name=N'Investigation_Test_Dtls$Test_Id'
GO
/****** Object:  Table [dbo].[Urology_History]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urology_History](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[Chief_Compl] [nvarchar](250) NULL,
	[Frequency] [nvarchar](70) NULL,
	[Hesitancy] [nvarchar](70) NULL,
	[Nocturia] [nvarchar](70) NULL,
	[Poor_Stream] [nvarchar](70) NULL,
	[Urgency] [nvarchar](70) NULL,
	[Intermittency] [nvarchar](70) NULL,
	[Dysuria] [nvarchar](70) NULL,
	[Straining] [nvarchar](70) NULL,
	[Pyuria] [nvarchar](70) NULL,
	[Sense_Incompl_Void] [nvarchar](70) NULL,
	[Lithiuria] [nvarchar](70) NULL,
	[Terminal_Dribbling] [nvarchar](70) NULL,
	[Chyluria] [nvarchar](70) NULL,
	[Urge_Inc] [nvarchar](70) NULL,
	[Fever] [nvarchar](70) NULL,
	[Stress_Inc] [nvarchar](70) NULL,
	[IPSS] [nvarchar](70) NULL,
	[BPI] [nvarchar](70) NULL,
	[Pain] [nvarchar](70) NULL,
	[Others] [nvarchar](250) NULL,
	[Medication] [nvarchar](70) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
	[Personal] [nvarchar](150) NULL,
	[Surgery] [nvarchar](150) NULL,
	[MH] [nvarchar](150) NULL,
	[Allergies] [nvarchar](150) NULL,
	[OB_GY] [nvarchar](150) NULL,
	[Past] [nvarchar](250) NULL,
	[Family] [nvarchar](150) NULL,
	[Hematuria] [nvarchar](70) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Urology_History$Patient_InfoUrology_History] ON [dbo].[Urology_History] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Urology_History$Sense_Incompl_Void] ON [dbo].[Urology_History] 
(
	[Sense_Incompl_Void] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Chief_Compl]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Chief_Compl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Frequency]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Frequency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Hesitancy]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Hesitancy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Nocturia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Nocturia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Poor_Stream]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Poor_Stream'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Urgency]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Urgency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Intermittency]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Intermittency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Dysuria]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Dysuria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Straining]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Straining'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Pyuria]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Pyuria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Sense_Incompl_Void]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Sense_Incompl_Void'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Lithiuria]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Lithiuria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Terminal_Dribbling]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Terminal_Dribbling'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Chyluria]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Chyluria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Urge_Inc]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Urge_Inc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Fever]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Fever'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Stress_Inc]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Stress_Inc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[IPSS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'IPSS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[BPI]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'BPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Pain]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Pain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Others]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Others'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Medication]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Medication'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Personal]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Personal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Surgery]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Surgery'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[MH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'MH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Allergies]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Allergies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[OB_GY]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'OB_GY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Past]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Past'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Family]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Family'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Hematuria]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'COLUMN',@level2name=N'Hematuria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Patient_InfoUrology_History]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'INDEX',@level2name=N'Urology_History$Patient_InfoUrology_History'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Sense_Incompl_Void]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'INDEX',@level2name=N'Urology_History$Sense_Incompl_Void'
GO
/****** Object:  Table [dbo].[UDS]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UDS](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[Complaints] [nvarchar](200) NULL,
	[Assoc_Illness] [nvarchar](200) NULL,
	[Anal_Tone] [nvarchar](200) NULL,
	[BCR] [nvarchar](200) NULL,
	[Exam_Other] [nvarchar](200) NULL,
	[Peak_Flow_Rate] [nvarchar](200) NULL,
	[Voided_Volume] [nvarchar](200) NULL,
	[Residual_Volume] [nvarchar](200) NULL,
	[Uroflow_Rmks] [nvarchar](200) NULL,
	[Filling_Rate] [nvarchar](80) NULL,
	[Capacity] [nvarchar](80) NULL,
	[Compliance] [nvarchar](80) NULL,
	[Stability] [nvarchar](80) NULL,
	[Sensation] [nvarchar](80) NULL,
	[DLPP] [nvarchar](80) NULL,
	[VLPP] [nvarchar](80) NULL,
	[Stress_Inc] [nvarchar](80) NULL,
	[Fill_Other] [nvarchar](200) NULL,
	[Fill_Rmks] [nvarchar](200) NULL,
	[Detrusor_Press] [nvarchar](80) NULL,
	[VoidPhase_Flow_Rate] [nvarchar](80) NULL,
	[Sph_Activity] [nvarchar](80) NULL,
	[Residual_Urine] [nvarchar](80) NULL,
	[Void_Other] [nvarchar](200) NULL,
	[Void_Rmks] [nvarchar](200) NULL,
	[Conclusion] [nvarchar](200) NULL,
	[Advise] [nvarchar](200) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [UDS$Patient_InfoUDS] ON [dbo].[UDS] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Complaints]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Complaints'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Assoc_Illness]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Assoc_Illness'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Anal_Tone]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Anal_Tone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[BCR]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'BCR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Exam_Other]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Exam_Other'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Peak_Flow_Rate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Peak_Flow_Rate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Voided_Volume]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Voided_Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Residual_Volume]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Residual_Volume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Uroflow_Rmks]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Uroflow_Rmks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Filling_Rate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Filling_Rate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Capacity]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Capacity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Compliance]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Compliance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Stability]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Stability'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Sensation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Sensation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[DLPP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'DLPP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[VLPP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'VLPP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Stress_Inc]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Stress_Inc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Fill_Other]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Fill_Other'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Fill_Rmks]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Fill_Rmks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Detrusor_Press]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Detrusor_Press'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[VoidPhase_Flow_Rate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'VoidPhase_Flow_Rate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Sph_Activity]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Sph_Activity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Residual_Urine]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Residual_Urine'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Void_Other]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Void_Other'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Void_Rmks]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Void_Rmks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Conclusion]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Conclusion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Advise]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Advise'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Patient_InfoUDS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'INDEX',@level2name=N'UDS$Patient_InfoUDS'
GO
/****** Object:  Table [dbo].[Treatment_Advised]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment_Advised](
	[Gu_No] [int] NULL,
	[Gu_Year] [int] NULL,
	[Treatment_Adv] [nvarchar](250) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Treatment_Advised$Patient_InfoTreatment_Advised] ON [dbo].[Treatment_Advised] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Treatment_Adv]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Treatment_Adv'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Patient_InfoTreatment_Advised]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'INDEX',@level2name=N'Treatment_Advised$Patient_InfoTreatment_Advised'
GO
/****** Object:  Table [dbo].[Treatement_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatement_Dtls](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[SR_No] [int] NOT NULL,
	[Treatment_Dte] [datetime2](0) NULL,
	[Treatment_Given] [nvarchar](250) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [Treatement_Dtls$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[SR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Treatement_Dtls$Patient_InfoTreatement_Dtls] ON [dbo].[Treatement_Dtls] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[SR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'SR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Treatment_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Treatment_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Treatment_Given]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Treatment_Given'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Treatement_Dtls$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Patient_InfoTreatement_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'INDEX',@level2name=N'Treatement_Dtls$Patient_InfoTreatement_Dtls'
GO
/****** Object:  Table [dbo].[Prescription_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription_Dtls](
	[GU_No] [int] NOT NULL,
	[GU_Year] [int] NOT NULL,
	[Sr_No] [int] NOT NULL,
	[Prescription_Date] [datetime2](0) NULL,
	[Prescription_Dtls] [nvarchar](max) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Created_Dte] [datetime2](0) NULL,
	[Modified_By] [nvarchar](30) NULL,
	[Modified_Dte] [datetime2](0) NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [Prescription_Dtls$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[GU_No] ASC,
	[GU_Year] ASC,
	[Sr_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Prescription_Dtls$Patient_InfoPrescription_Dtls] ON [dbo].[Prescription_Dtls] 
(
	[GU_No] ASC,
	[GU_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[GU_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'GU_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[GU_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'GU_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Sr_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Sr_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Prescription_Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Prescription_Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Prescription_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Prescription_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Created_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Created_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Modified_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Modified_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Modified_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'COLUMN',@level2name=N'Modified_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Prescription_Dtls$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Patient_InfoPrescription_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'INDEX',@level2name=N'Prescription_Dtls$Patient_InfoPrescription_Dtls'
GO
/****** Object:  Table [dbo].[Follow_Up]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Follow_Up](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[SR_No] [int] NOT NULL,
	[Follow_Dte] [datetime2](0) NULL,
	[Complaints] [nvarchar](250) NULL,
	[Evaluation] [nvarchar](250) NULL,
	[Treatment] [nvarchar](250) NULL,
	[Next_Dte] [datetime2](0) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [Follow_Up$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[SR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Follow_Up$Patient_InfoFollow_Up] ON [dbo].[Follow_Up] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[SR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'SR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Follow_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Follow_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Complaints]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Complaints'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Evaluation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Evaluation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Treatment]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Treatment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Next_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Next_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'CONSTRAINT',@level2name=N'Follow_Up$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Patient_InfoFollow_Up]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'INDEX',@level2name=N'Follow_Up$Patient_InfoFollow_Up'
GO
/****** Object:  Table [dbo].[ESWL]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESWL](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[SR_No] [int] NOT NULL,
	[ESWL_Dte] [datetime2](0) NULL,
	[ESWL_Size] [nvarchar](50) NULL,
	[Side] [nvarchar](50) NULL,
	[Site] [nvarchar](50) NULL,
	[Shock_Waves] [nvarchar](50) NULL,
	[ESWL_Level] [nvarchar](50) NULL,
	[Fluroscopy] [nvarchar](50) NULL,
	[Analgesic] [nvarchar](50) NULL,
	[IV_Fluids] [nvarchar](50) NULL,
	[Complications] [nvarchar](150) NULL,
	[Comments] [nvarchar](150) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
 CONSTRAINT [ESWL$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[SR_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [ESWL$Patient_InfoESWL] ON [dbo].[ESWL] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[SR_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'SR_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[ESWL_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'ESWL_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[ESWL_Size]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'ESWL_Size'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Side]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Side'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Site]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Site'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Shock_Waves]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Shock_Waves'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[ESWL_Level]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'ESWL_Level'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Fluroscopy]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Fluroscopy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Analgesic]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Analgesic'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[IV_Fluids]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'IV_Fluids'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Complications]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Complications'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Comments]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'CONSTRAINT',@level2name=N'ESWL$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Patient_InfoESWL]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'INDEX',@level2name=N'ESWL$Patient_InfoESWL'
GO
/****** Object:  Table [dbo].[Bill_Entry]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Entry](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[Sr_No] [int] NOT NULL,
	[Bill_Dte] [datetime2](0) NULL,
	[Room_Rent] [float] NULL,
	[Nursing] [float] NULL,
	[Visit] [float] NULL,
	[Lithotripsy] [float] NULL,
	[Operation] [float] NULL,
	[OT_Charges] [float] NULL,
	[Hospital_Inj] [float] NULL,
	[Own_Inj] [float] NULL,
	[IV_Fluid] [float] NULL,
	[Bill_Procedure] [float] NULL,
	[Misc] [float] NULL,
	[Anaesthesia] [float] NULL,
	[Uroflow] [float] NULL,
	[Urodynamic] [float] NULL,
	[Others] [float] NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [Bill_Entry$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Gu_No] ASC,
	[Gu_Year] ASC,
	[Sr_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Bill_Entry$IV_Fluid] ON [dbo].[Bill_Entry] 
(
	[IV_Fluid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Bill_Entry$Patient_InfoBill_Entry] ON [dbo].[Bill_Entry] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Sr_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Sr_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Bill_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Bill_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Room_Rent]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Room_Rent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Nursing]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Nursing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Visit]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Visit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Lithotripsy]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Lithotripsy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Operation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Operation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[OT_Charges]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'OT_Charges'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Hospital_Inj]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Hospital_Inj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Own_Inj]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Own_Inj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[IV_Fluid]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'IV_Fluid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Bill_Procedure]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Bill_Procedure'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Misc]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Misc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Anaesthesia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Anaesthesia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Uroflow]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Uroflow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Urodynamic]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Urodynamic'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Others]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Others'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'CONSTRAINT',@level2name=N'Bill_Entry$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[IV_Fluid]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'INDEX',@level2name=N'Bill_Entry$IV_Fluid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Patient_InfoBill_Entry]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'INDEX',@level2name=N'Bill_Entry$Patient_InfoBill_Entry'
GO
/****** Object:  Table [dbo].[Andrology]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Andrology](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[Complaint] [nvarchar](150) NULL,
	[Married_Since] [nvarchar](30) NULL,
	[Signi_Illness] [nvarchar](150) NULL,
	[Treatment_Taken] [nvarchar](150) NULL,
	[Alcoholism] [nvarchar](50) NULL,
	[Fever] [nvarchar](50) NULL,
	[Smoking] [nvarchar](50) NULL,
	[Mumps_Orchits] [nvarchar](50) NULL,
	[Erection] [nvarchar](50) NULL,
	[Ejaculation] [nvarchar](50) NULL,
	[General_Exam] [nvarchar](50) NULL,
	[Virilization] [nvarchar](50) NULL,
	[PA] [nvarchar](50) NULL,
	[PR] [nvarchar](50) NULL,
	[VAS] [nvarchar](50) NULL,
	[Varicocele] [nvarchar](50) NULL,
	[Testis] [nvarchar](50) NULL,
	[Epididymis] [nvarchar](50) NULL,
	[Semen_Analysis] [nvarchar](50) NULL,
	[SR_FSH] [nvarchar](50) NULL,
	[LH] [nvarchar](50) NULL,
	[Testosterone] [nvarchar](50) NULL,
	[Prolactin] [nvarchar](50) NULL,
	[Testi_Biopsy] [nvarchar](150) NULL,
	[Others] [nvarchar](150) NULL,
	[Treatment_Given] [nvarchar](150) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Andrology$Patient_InfoAndrology] ON [dbo].[Andrology] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Complaint]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Complaint'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Married_Since]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Married_Since'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Signi_Illness]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Signi_Illness'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Treatment_Taken]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Treatment_Taken'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Alcoholism]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Alcoholism'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Fever]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Fever'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Smoking]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Smoking'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Mumps_Orchits]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Mumps_Orchits'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Erection]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Erection'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Ejaculation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Ejaculation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[General_Exam]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'General_Exam'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Virilization]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Virilization'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[PA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'PA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[PR]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'PR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[VAS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'VAS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Varicocele]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Varicocele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Testis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Testis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Epididymis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Epididymis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Semen_Analysis]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Semen_Analysis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[SR_FSH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'SR_FSH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[LH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'LH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Testosterone]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Testosterone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Prolactin]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Prolactin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Testi_Biopsy]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Testi_Biopsy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Others]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Others'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Treatment_Given]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Treatment_Given'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Patient_InfoAndrology]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'INDEX',@level2name=N'Andrology$Patient_InfoAndrology'
GO
/****** Object:  Table [dbo].[Patient_Examination]    Script Date: 04/07/2012 20:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Examination](
	[Gu_No] [int] NOT NULL,
	[Gu_Year] [int] NOT NULL,
	[G_E] [nvarchar](100) NULL,
	[Pulse] [nvarchar](20) NULL,
	[BP] [nvarchar](10) NULL,
	[Weight] [nvarchar](3) NULL,
	[Abdomen] [nvarchar](150) NULL,
	[Genitalia] [nvarchar](150) NULL,
	[Anal_Tone] [nvarchar](80) NULL,
	[BCR] [nvarchar](80) NULL,
	[Prostate] [nvarchar](100) NULL,
	[PR_Others] [nvarchar](100) NULL,
	[P_S] [nvarchar](80) NULL,
	[P_V] [nvarchar](80) NULL,
	[CNS] [nvarchar](80) NULL,
	[CVS] [nvarchar](80) NULL,
	[R_S] [nvarchar](80) NULL,
	[Others] [nvarchar](80) NULL,
	[Remarks] [nvarchar](150) NULL,
	[Created_By] [nvarchar](30) NULL,
	[Create_Dte] [datetime2](0) NULL,
	[Modify_By] [nvarchar](30) NULL,
	[Modify_Dte] [datetime2](0) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Patient_Examination$Patient_InfoPatient_Examination] ON [dbo].[Patient_Examination] 
(
	[Gu_No] ASC,
	[Gu_Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Gu_No]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Gu_No'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Gu_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Gu_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[G_E]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'G_E'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Pulse]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Pulse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[BP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'BP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Weight]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Weight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Abdomen]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Abdomen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Genitalia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Genitalia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Anal_Tone]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Anal_Tone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[BCR]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'BCR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Prostate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Prostate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[PR_Others]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'PR_Others'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[P_S]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'P_S'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[P_V]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'P_V'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[CNS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'CNS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[CVS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'CVS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[R_S]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'R_S'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Others]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Others'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Remarks]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Created_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Created_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Create_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Create_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Modify_By]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Modify_By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Modify_Dte]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'COLUMN',@level2name=N'Modify_Dte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Patient_InfoPatient_Examination]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'INDEX',@level2name=N'Patient_Examination$Patient_InfoPatient_Examination'
GO
/****** Object:  Default [DF__Investiga__Sr_No__440B1D61]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Master] ADD  DEFAULT ((0)) FOR [Sr_No]
GO
/****** Object:  Default [DF__Doctors_L__DR_NO__36B12243]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List] ADD  DEFAULT ((0)) FOR [DR_NO]
GO
/****** Object:  Default [DF__Image_Mas__Image__3D5E1FD2]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Image_Master] ADD  DEFAULT ((0)) FOR [Image_Id]
GO
/****** Object:  Default [DF__User_Mast__Activ__619B8048]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master] ADD  DEFAULT ('Y') FOR [Active_User]
GO
/****** Object:  Default [DF__User_Mast__Attem__628FA481]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master] ADD  DEFAULT ((0)) FOR [Attempts_No]
GO
/****** Object:  Default [DF__User_Mast__Lock___6383C8BA]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master] ADD  DEFAULT ('N') FOR [Lock_User]
GO
/****** Object:  Default [DF__Patient_I__Gu_No__52593CB8]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Patient_I__Gu_Ye__534D60F1]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Patient_Inf__Sex__5441852A]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info] ADD  DEFAULT ((0)) FOR [Sex]
GO
/****** Object:  Default [DF__User_Logi__User___60A75C0F]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Login_Dtl] ADD  DEFAULT ('A') FOR [User_Stat]
GO
/****** Object:  Default [DF__User_Role__Role__6477ECF3]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Role] ADD  DEFAULT ((0)) FOR [Role]
GO
/****** Object:  Default [DF__X_Ray__Gu_No__656C112C]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__X_Ray__Gu_Year__66603565]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__X_Ray__SR_No__6754599E]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray] ADD  DEFAULT ((0)) FOR [SR_No]
GO
/****** Object:  Default [DF__Investiga__Gu_No__4222D4EF]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Investiga__Gu_Ye__4316F928]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Images__GU_No__3E52440B]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images] ADD  DEFAULT ((0)) FOR [GU_No]
GO
/****** Object:  Default [DF__Images__GU_Year__3F466844]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images] ADD  DEFAULT ((0)) FOR [GU_Year]
GO
/****** Object:  Default [DF__Images__Sr_No__403A8C7D]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images] ADD  DEFAULT ((0)) FOR [Sr_No]
GO
/****** Object:  Default [DF__Images__Image_Id__412EB0B6]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images] ADD  DEFAULT ((0)) FOR [Image_Id]
GO
/****** Object:  Default [DF__Operation__Gu_No__4CA06362]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Operation__Gu_Ye__4D94879B]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Operation__SR_No__4E88ABD4]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls] ADD  DEFAULT ((0)) FOR [SR_No]
GO
/****** Object:  Default [DF__Operation__Anaes__4F7CD00D]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls] ADD  DEFAULT ((0)) FOR [Anaesthesiologist]
GO
/****** Object:  Default [DF__IPD__Gu_No__49C3F6B7]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__IPD__Gu_Year__4AB81AF0]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__IPD__SR_No__4BAC3F29]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD] ADD  DEFAULT ((0)) FOR [SR_No]
GO
/****** Object:  Default [DF__Investiga__GU_No__44FF419A]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls] ADD  DEFAULT ((0)) FOR [GU_No]
GO
/****** Object:  Default [DF__Investiga__GU_Ye__45F365D3]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls] ADD  DEFAULT ((0)) FOR [GU_Year]
GO
/****** Object:  Default [DF__Investiga__Sr_No__46E78A0C]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls] ADD  DEFAULT ((0)) FOR [Sr_No]
GO
/****** Object:  Default [DF__Investiga__Test___47DBAE45]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls] ADD  DEFAULT ((0)) FOR [Test_Id]
GO
/****** Object:  Default [DF__Investiga__Test___48CFD27E]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls] ADD  DEFAULT ('N') FOR [Test_Done]
GO
/****** Object:  Default [DF__Urology_H__Gu_No__5EBF139D]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Urology_H__Gu_Ye__5FB337D6]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__UDS__Gu_No__5CD6CB2B]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__UDS__Gu_Year__5DCAEF64]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Treatment__Gu_No__5AEE82B9]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatment_Advised] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Treatment__Gu_Ye__5BE2A6F2]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatment_Advised] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Treatemen__Gu_No__5812160E]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Treatemen__Gu_Ye__59063A47]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Treatemen__SR_No__59FA5E80]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls] ADD  DEFAULT ((0)) FOR [SR_No]
GO
/****** Object:  Default [DF__Prescript__GU_No__5535A963]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls] ADD  DEFAULT ((0)) FOR [GU_No]
GO
/****** Object:  Default [DF__Prescript__GU_Ye__5629CD9C]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls] ADD  DEFAULT ((0)) FOR [GU_Year]
GO
/****** Object:  Default [DF__Prescript__Sr_No__571DF1D5]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls] ADD  DEFAULT ((0)) FOR [Sr_No]
GO
/****** Object:  Default [DF__Follow_Up__Gu_No__3A81B327]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Follow_Up__Gu_Ye__3B75D760]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Follow_Up__SR_No__3C69FB99]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up] ADD  DEFAULT ((0)) FOR [SR_No]
GO
/****** Object:  Default [DF__ESWL__Gu_No__37A5467C]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__ESWL__Gu_Year__38996AB5]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__ESWL__SR_No__398D8EEE]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL] ADD  DEFAULT ((0)) FOR [SR_No]
GO
/****** Object:  Default [DF__Bill_Entr__Gu_No__25869641]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Bill_Entr__Gu_Ye__267ABA7A]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Bill_Entr__Sr_No__276EDEB3]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Sr_No]
GO
/****** Object:  Default [DF__Bill_Entr__Room___286302EC]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Room_Rent]
GO
/****** Object:  Default [DF__Bill_Entr__Nursi__29572725]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Nursing]
GO
/****** Object:  Default [DF__Bill_Entr__Visit__2A4B4B5E]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Visit]
GO
/****** Object:  Default [DF__Bill_Entr__Litho__2B3F6F97]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Lithotripsy]
GO
/****** Object:  Default [DF__Bill_Entr__Opera__2C3393D0]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Operation]
GO
/****** Object:  Default [DF__Bill_Entr__OT_Ch__2D27B809]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [OT_Charges]
GO
/****** Object:  Default [DF__Bill_Entr__Hospi__2E1BDC42]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Hospital_Inj]
GO
/****** Object:  Default [DF__Bill_Entr__Own_I__2F10007B]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Own_Inj]
GO
/****** Object:  Default [DF__Bill_Entr__IV_Fl__300424B4]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [IV_Fluid]
GO
/****** Object:  Default [DF__Bill_Entr__Bill___30F848ED]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Bill_Procedure]
GO
/****** Object:  Default [DF__Bill_Entry__Misc__31EC6D26]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Misc]
GO
/****** Object:  Default [DF__Bill_Entr__Anaes__32E0915F]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Anaesthesia]
GO
/****** Object:  Default [DF__Bill_Entr__Urofl__33D4B598]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Uroflow]
GO
/****** Object:  Default [DF__Bill_Entr__Urody__34C8D9D1]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Urodynamic]
GO
/****** Object:  Default [DF__Bill_Entr__Other__35BCFE0A]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry] ADD  DEFAULT ((0)) FOR [Others]
GO
/****** Object:  Default [DF__Andrology__Gu_No__239E4DCF]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Andrology__Gu_Ye__24927208]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Default [DF__Patient_E__Gu_No__5070F446]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination] ADD  DEFAULT ((0)) FOR [Gu_No]
GO
/****** Object:  Default [DF__Patient_E__Gu_Ye__5165187F]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination] ADD  DEFAULT ((0)) FOR [Gu_Year]
GO
/****** Object:  Check [SSMA_CC$Param_Master$Param_Id$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Param_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Param_Master$Param_Id$disallow_zero_length] CHECK  ((len([Param_Id])>(0)))
GO
ALTER TABLE [dbo].[Param_Master] CHECK CONSTRAINT [SSMA_CC$Param_Master$Param_Id$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Param_Master$Param_Value$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Param_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Param_Master$Param_Value$disallow_zero_length] CHECK  ((len([Param_Value])>(0)))
GO
ALTER TABLE [dbo].[Param_Master] CHECK CONSTRAINT [SSMA_CC$Param_Master$Param_Value$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Param_Dtls$Param_ID$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Param_Dtls]  WITH CHECK ADD  CONSTRAINT [SSMA_CC$Param_Dtls$Param_ID$disallow_zero_length] CHECK  ((len([Param_ID])>(0)))
GO
ALTER TABLE [dbo].[Param_Dtls] CHECK CONSTRAINT [SSMA_CC$Param_Dtls$Param_ID$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Param_Dtls$Param_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Param_Dtls]  WITH CHECK ADD  CONSTRAINT [SSMA_CC$Param_Dtls$Param_Name$disallow_zero_length] CHECK  ((len([Param_Name])>(0)))
GO
ALTER TABLE [dbo].[Param_Dtls] CHECK CONSTRAINT [SSMA_CC$Param_Dtls$Param_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Master$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Master$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Investigation_Master] CHECK CONSTRAINT [SSMA_CC$Investigation_Master$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Master$Description$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Master$Description$disallow_zero_length] CHECK  ((len([Description])>(0)))
GO
ALTER TABLE [dbo].[Investigation_Master] CHECK CONSTRAINT [SSMA_CC$Investigation_Master$Description$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Master$Modified_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Master$Modified_By$disallow_zero_length] CHECK  ((len([Modified_By])>(0)))
GO
ALTER TABLE [dbo].[Investigation_Master] CHECK CONSTRAINT [SSMA_CC$Investigation_Master$Modified_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Master$Test_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Master$Test_Name$disallow_zero_length] CHECK  ((len([Test_Name])>(0)))
GO
ALTER TABLE [dbo].[Investigation_Master] CHECK CONSTRAINT [SSMA_CC$Investigation_Master$Test_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$At_Post$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$At_Post$disallow_zero_length] CHECK  ((len([At_Post])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$At_Post$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$District$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$District$disallow_zero_length] CHECK  ((len([District])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$District$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Doctor_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Doctor_Name$disallow_zero_length] CHECK  ((len([Doctor_Name])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Doctor_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Dr_Email$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Dr_Email$disallow_zero_length] CHECK  ((len([Dr_Email])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Dr_Email$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Mobile$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Mobile$disallow_zero_length] CHECK  ((len([Mobile])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Mobile$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Phone$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Phone$disallow_zero_length] CHECK  ((len([Phone])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Phone$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Doctors_List$Taluka$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Doctors_List]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Doctors_List$Taluka$disallow_zero_length] CHECK  ((len([Taluka])>(0)))
GO
ALTER TABLE [dbo].[Doctors_List] CHECK CONSTRAINT [SSMA_CC$Doctors_List$Taluka$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Image_Master$Image_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Image_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Image_Master$Image_Name$disallow_zero_length] CHECK  ((len([Image_Name])>(0)))
GO
ALTER TABLE [dbo].[Image_Master] CHECK CONSTRAINT [SSMA_CC$Image_Master$Image_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Image_Master$Path$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Image_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Image_Master$Path$disallow_zero_length] CHECK  ((len([Path])>(0)))
GO
ALTER TABLE [dbo].[Image_Master] CHECK CONSTRAINT [SSMA_CC$Image_Master$Path$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$Active_User$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$Active_User$disallow_zero_length] CHECK  ((len([Active_User])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$Active_User$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$Active_User$validation_rule]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$Active_User$validation_rule] CHECK  (([Active_User]='Y' OR [Active_User]='N'))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$Active_User$validation_rule]
GO
/****** Object:  Check [SSMA_CC$User_Master$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$Lock_User$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$Lock_User$disallow_zero_length] CHECK  ((len([Lock_User])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$Lock_User$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$Lock_User$validation_rule]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$Lock_User$validation_rule] CHECK  (([Lock_User]='Y' OR [Lock_User]='N'))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$Lock_User$validation_rule]
GO
/****** Object:  Check [SSMA_CC$User_Master$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$User_Id$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$User_Id$disallow_zero_length] CHECK  ((len([User_Id])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$User_Id$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$User_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$User_Name$disallow_zero_length] CHECK  ((len([User_Name])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$User_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Master$User_Pwd$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Master]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Master$User_Pwd$disallow_zero_length] CHECK  ((len([User_Pwd])>(0)))
GO
ALTER TABLE [dbo].[User_Master] CHECK CONSTRAINT [SSMA_CC$User_Master$User_Pwd$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$At_Post$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$At_Post$disallow_zero_length] CHECK  ((len([At_Post])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$At_Post$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$District$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$District$disallow_zero_length] CHECK  ((len([District])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$District$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Final_Diagnosis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Final_Diagnosis$disallow_zero_length] CHECK  ((len([Final_Diagnosis])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Final_Diagnosis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Mobile$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Mobile$disallow_zero_length] CHECK  ((len([Mobile])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Mobile$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Occupation$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Occupation$disallow_zero_length] CHECK  ((len([Occupation])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Occupation$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Patient_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Patient_Name$disallow_zero_length] CHECK  ((len([Patient_Name])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Patient_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Phone$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Phone$disallow_zero_length] CHECK  ((len([Phone])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Phone$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Prov_Diagnosis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Prov_Diagnosis$disallow_zero_length] CHECK  ((len([Prov_Diagnosis])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Prov_Diagnosis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Salutation$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Salutation$disallow_zero_length] CHECK  ((len([Salutation])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Salutation$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Sex$validation_rule]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Sex$validation_rule] CHECK  (([Sex]=(0) OR [Sex]=(1)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Sex$validation_rule]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$State$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$State$disallow_zero_length] CHECK  ((len([State])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$State$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Info$Town$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Info$Town$disallow_zero_length] CHECK  ((len([Town])>(0)))
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [SSMA_CC$Patient_Info$Town$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Login_Dtl$Role$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Login_Dtl]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Login_Dtl$Role$disallow_zero_length] CHECK  ((len([Role])>(0)))
GO
ALTER TABLE [dbo].[User_Login_Dtl] CHECK CONSTRAINT [SSMA_CC$User_Login_Dtl$Role$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Login_Dtl$User_Id$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Login_Dtl]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Login_Dtl$User_Id$disallow_zero_length] CHECK  ((len([User_Id])>(0)))
GO
ALTER TABLE [dbo].[User_Login_Dtl] CHECK CONSTRAINT [SSMA_CC$User_Login_Dtl$User_Id$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Login_Dtl$User_Stat$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Login_Dtl]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Login_Dtl$User_Stat$disallow_zero_length] CHECK  ((len([User_Stat])>(0)))
GO
ALTER TABLE [dbo].[User_Login_Dtl] CHECK CONSTRAINT [SSMA_CC$User_Login_Dtl$User_Stat$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Login_Dtl$User_Stat$validation_rule]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Login_Dtl]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Login_Dtl$User_Stat$validation_rule] CHECK  (([User_Stat]='I' OR [User_Stat]='A'))
GO
ALTER TABLE [dbo].[User_Login_Dtl] CHECK CONSTRAINT [SSMA_CC$User_Login_Dtl$User_Stat$validation_rule]
GO
/****** Object:  Check [SSMA_CC$User_Role$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Role]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Role$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [SSMA_CC$User_Role$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Role$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Role]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Role$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [SSMA_CC$User_Role$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$User_Role$User_Id$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Role]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$User_Role$User_Id$disallow_zero_length] CHECK  ((len([User_Id])>(0)))
GO
ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [SSMA_CC$User_Role$User_Id$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$X_Ray$Comments$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$X_Ray$Comments$disallow_zero_length] CHECK  ((len([Comments])>(0)))
GO
ALTER TABLE [dbo].[X_Ray] CHECK CONSTRAINT [SSMA_CC$X_Ray$Comments$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$X_Ray$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$X_Ray$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[X_Ray] CHECK CONSTRAINT [SSMA_CC$X_Ray$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$X_Ray$File_Path$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$X_Ray$File_Path$disallow_zero_length] CHECK  ((len([File_Path])>(0)))
GO
ALTER TABLE [dbo].[X_Ray] CHECK CONSTRAINT [SSMA_CC$X_Ray$File_Path$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$X_Ray$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$X_Ray$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[X_Ray] CHECK CONSTRAINT [SSMA_CC$X_Ray$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$X_Ray$XRay_Name$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$X_Ray$XRay_Name$disallow_zero_length] CHECK  ((len([XRay_Name])>(0)))
GO
ALTER TABLE [dbo].[X_Ray] CHECK CONSTRAINT [SSMA_CC$X_Ray$XRay_Name$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$BACTEC$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$BACTEC$disallow_zero_length] CHECK  ((len([BACTEC])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$BACTEC$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Bone_Scan$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Bone_Scan$disallow_zero_length] CHECK  ((len([Bone_Scan])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Bone_Scan$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$BSL$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$BSL$disallow_zero_length] CHECK  ((len([BSL])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$BSL$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$BUL$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$BUL$disallow_zero_length] CHECK  ((len([BUL])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$BUL$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Calcium$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Calcium$disallow_zero_length] CHECK  ((len([Calcium])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Calcium$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Citrate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Citrate$disallow_zero_length] CHECK  ((len([Citrate])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Citrate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$CT_Scan$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$CT_Scan$disallow_zero_length] CHECK  ((len([CT_Scan])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$CT_Scan$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$DC$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$DC$disallow_zero_length] CHECK  ((len([DC])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$DC$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$DTPA_Reno$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$DTPA_Reno$disallow_zero_length] CHECK  ((len([DTPA_Reno])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$DTPA_Reno$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$ESR$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$ESR$disallow_zero_length] CHECK  ((len([ESR])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$ESR$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$HB$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$HB$disallow_zero_length] CHECK  ((len([HB])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$HB$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$HBS_AG$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$HBS_AG$disallow_zero_length] CHECK  ((len([HBS_AG])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$HBS_AG$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$HIV$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$HIV$disallow_zero_length] CHECK  ((len([HIV])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$HIV$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$IgA$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$IgA$disallow_zero_length] CHECK  ((len([IgA])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$IgA$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$IgG$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$IgG$disallow_zero_length] CHECK  ((len([IgG])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$IgG$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$IgM$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$IgM$disallow_zero_length] CHECK  ((len([IgM])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$IgM$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$IVP$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$IVP$disallow_zero_length] CHECK  ((len([IVP])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$IVP$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$KUB$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$KUB$disallow_zero_length] CHECK  ((len([KUB])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$KUB$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$MCU$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$MCU$disallow_zero_length] CHECK  ((len([MCU])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$MCU$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$MRI$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$MRI$disallow_zero_length] CHECK  ((len([MRI])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$MRI$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$NCHCT$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$NCHCT$disallow_zero_length] CHECK  ((len([NCHCT])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$NCHCT$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Others$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Others$disallow_zero_length] CHECK  ((len([Others])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Others$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Oxalate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Oxalate$disallow_zero_length] CHECK  ((len([Oxalate])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Oxalate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$PCR$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$PCR$disallow_zero_length] CHECK  ((len([PCR])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$PCR$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$PH$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$PH$disallow_zero_length] CHECK  ((len([PH])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$PH$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Phosphorous$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Phosphorous$disallow_zero_length] CHECK  ((len([Phosphorous])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Phosphorous$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$RGU$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$RGU$disallow_zero_length] CHECK  ((len([RGU])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$RGU$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Sodium$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Sodium$disallow_zero_length] CHECK  ((len([Sodium])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Sodium$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$SR_CA_Plus$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$SR_CA_Plus$disallow_zero_length] CHECK  ((len([SR_CA_Plus])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$SR_CA_Plus$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$SR_Creat$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$SR_Creat$disallow_zero_length] CHECK  ((len([SR_Creat])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$SR_Creat$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$SR_K_Plus$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$SR_K_Plus$disallow_zero_length] CHECK  ((len([SR_K_Plus])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$SR_K_Plus$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$SR_NA_Plus$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$SR_NA_Plus$disallow_zero_length] CHECK  ((len([SR_NA_Plus])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$SR_NA_Plus$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Sr_PSA$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Sr_PSA$disallow_zero_length] CHECK  ((len([Sr_PSA])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Sr_PSA$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$SR_Uric_Acid$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$SR_Uric_Acid$disallow_zero_length] CHECK  ((len([SR_Uric_Acid])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$SR_Uric_Acid$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Stone_Analysis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Stone_Analysis$disallow_zero_length] CHECK  ((len([Stone_Analysis])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Stone_Analysis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Sulfate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Sulfate$disallow_zero_length] CHECK  ((len([Sulfate])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Sulfate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$TC$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$TC$disallow_zero_length] CHECK  ((len([TC])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$TC$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$TRUS$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$TRUS$disallow_zero_length] CHECK  ((len([TRUS])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$TRUS$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Uric_Acid$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Uric_Acid$disallow_zero_length] CHECK  ((len([Uric_Acid])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Uric_Acid$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Urine$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Urine$disallow_zero_length] CHECK  ((len([Urine])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Urine$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Urine_AFB$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Urine_AFB$disallow_zero_length] CHECK  ((len([Urine_AFB])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Urine_AFB$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Urine_Chyle$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Urine_Chyle$disallow_zero_length] CHECK  ((len([Urine_Chyle])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Urine_Chyle$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Urine_CS$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Urine_CS$disallow_zero_length] CHECK  ((len([Urine_CS])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Urine_CS$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$USG$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$USG$disallow_zero_length] CHECK  ((len([USG])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$USG$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation$Volume$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation$Volume$disallow_zero_length] CHECK  ((len([Volume])>(0)))
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [SSMA_CC$Investigation$Volume$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Images$Comments$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Images$Comments$disallow_zero_length] CHECK  ((len([Comments])>(0)))
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [SSMA_CC$Images$Comments$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Images$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Images$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [SSMA_CC$Images$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Images$Modified_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Images$Modified_By$disallow_zero_length] CHECK  ((len([Modified_By])>(0)))
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [SSMA_CC$Images$Modified_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Operation_Dtls$Anesthesia$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Operation_Dtls$Anesthesia$disallow_zero_length] CHECK  ((len([Anesthesia])>(0)))
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [SSMA_CC$Operation_Dtls$Anesthesia$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Operation_Dtls$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Operation_Dtls$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [SSMA_CC$Operation_Dtls$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Operation_Dtls$Details$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Operation_Dtls$Details$disallow_zero_length] CHECK  ((len([Details])>(0)))
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [SSMA_CC$Operation_Dtls$Details$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Operation_Dtls$Modified_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Operation_Dtls$Modified_By$disallow_zero_length] CHECK  ((len([Modified_By])>(0)))
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [SSMA_CC$Operation_Dtls$Modified_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Operation_Dtls$Opern_Procedure$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Operation_Dtls$Opern_Procedure$disallow_zero_length] CHECK  ((len([Opern_Procedure])>(0)))
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [SSMA_CC$Operation_Dtls$Opern_Procedure$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Operation_Dtls$Remarks$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Operation_Dtls$Remarks$disallow_zero_length] CHECK  ((len([Remarks])>(0)))
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [SSMA_CC$Operation_Dtls$Remarks$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$Advice$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$Advice$disallow_zero_length] CHECK  ((len([Advice])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$Advice$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$Complaints$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$Complaints$disallow_zero_length] CHECK  ((len([Complaints])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$Complaints$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$Final_Diagnosis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$Final_Diagnosis$disallow_zero_length] CHECK  ((len([Final_Diagnosis])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$Final_Diagnosis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$IPD_No$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$IPD_No$disallow_zero_length] CHECK  ((len([IPD_No])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$IPD_No$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$IPD$Prov_Diagnosis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$IPD$Prov_Diagnosis$disallow_zero_length] CHECK  ((len([Prov_Diagnosis])>(0)))
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [SSMA_CC$IPD$Prov_Diagnosis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Test_Dtls$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Test_Dtls$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Investigation_Test_Dtls] CHECK CONSTRAINT [SSMA_CC$Investigation_Test_Dtls$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Test_Dtls$Modified_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Test_Dtls$Modified_By$disallow_zero_length] CHECK  ((len([Modified_By])>(0)))
GO
ALTER TABLE [dbo].[Investigation_Test_Dtls] CHECK CONSTRAINT [SSMA_CC$Investigation_Test_Dtls$Modified_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Investigation_Test_Dtls$Test_Done$validation_rule]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Investigation_Test_Dtls$Test_Done$validation_rule] CHECK  (([Test_Done]='Y' OR [Test_Done]='N'))
GO
ALTER TABLE [dbo].[Investigation_Test_Dtls] CHECK CONSTRAINT [SSMA_CC$Investigation_Test_Dtls$Test_Done$validation_rule]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Allergies$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Allergies$disallow_zero_length] CHECK  ((len([Allergies])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Allergies$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$BPI$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$BPI$disallow_zero_length] CHECK  ((len([BPI])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$BPI$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Chief_Compl$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Chief_Compl$disallow_zero_length] CHECK  ((len([Chief_Compl])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Chief_Compl$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Chyluria$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Chyluria$disallow_zero_length] CHECK  ((len([Chyluria])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Chyluria$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Dysuria$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Dysuria$disallow_zero_length] CHECK  ((len([Dysuria])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Dysuria$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Family$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Family$disallow_zero_length] CHECK  ((len([Family])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Family$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Fever$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Fever$disallow_zero_length] CHECK  ((len([Fever])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Fever$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Frequency$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Frequency$disallow_zero_length] CHECK  ((len([Frequency])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Frequency$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Hematuria$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Hematuria$disallow_zero_length] CHECK  ((len([Hematuria])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Hematuria$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Hesitancy$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Hesitancy$disallow_zero_length] CHECK  ((len([Hesitancy])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Hesitancy$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Intermittency$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Intermittency$disallow_zero_length] CHECK  ((len([Intermittency])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Intermittency$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$IPSS$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$IPSS$disallow_zero_length] CHECK  ((len([IPSS])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$IPSS$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Lithiuria$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Lithiuria$disallow_zero_length] CHECK  ((len([Lithiuria])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Lithiuria$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Medication$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Medication$disallow_zero_length] CHECK  ((len([Medication])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Medication$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$MH$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$MH$disallow_zero_length] CHECK  ((len([MH])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$MH$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Nocturia$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Nocturia$disallow_zero_length] CHECK  ((len([Nocturia])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Nocturia$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$OB_GY$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$OB_GY$disallow_zero_length] CHECK  ((len([OB_GY])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$OB_GY$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Others$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Others$disallow_zero_length] CHECK  ((len([Others])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Others$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Pain$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Pain$disallow_zero_length] CHECK  ((len([Pain])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Pain$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Past$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Past$disallow_zero_length] CHECK  ((len([Past])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Past$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Personal$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Personal$disallow_zero_length] CHECK  ((len([Personal])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Personal$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Poor_Stream$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Poor_Stream$disallow_zero_length] CHECK  ((len([Poor_Stream])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Poor_Stream$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Pyuria$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Pyuria$disallow_zero_length] CHECK  ((len([Pyuria])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Pyuria$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Sense_Incompl_Void$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Sense_Incompl_Void$disallow_zero_length] CHECK  ((len([Sense_Incompl_Void])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Sense_Incompl_Void$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Straining$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Straining$disallow_zero_length] CHECK  ((len([Straining])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Straining$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Stress_Inc$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Stress_Inc$disallow_zero_length] CHECK  ((len([Stress_Inc])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Stress_Inc$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Surgery$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Surgery$disallow_zero_length] CHECK  ((len([Surgery])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Surgery$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Terminal_Dribbling$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Terminal_Dribbling$disallow_zero_length] CHECK  ((len([Terminal_Dribbling])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Terminal_Dribbling$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Urge_Inc$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Urge_Inc$disallow_zero_length] CHECK  ((len([Urge_Inc])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Urge_Inc$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Urology_History$Urgency$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Urology_History$Urgency$disallow_zero_length] CHECK  ((len([Urgency])>(0)))
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [SSMA_CC$Urology_History$Urgency$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Advise$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Advise$disallow_zero_length] CHECK  ((len([Advise])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Advise$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Anal_Tone$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Anal_Tone$disallow_zero_length] CHECK  ((len([Anal_Tone])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Anal_Tone$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Assoc_Illness$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Assoc_Illness$disallow_zero_length] CHECK  ((len([Assoc_Illness])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Assoc_Illness$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$BCR$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$BCR$disallow_zero_length] CHECK  ((len([BCR])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$BCR$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Capacity$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Capacity$disallow_zero_length] CHECK  ((len([Capacity])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Capacity$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Complaints$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Complaints$disallow_zero_length] CHECK  ((len([Complaints])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Complaints$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Compliance$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Compliance$disallow_zero_length] CHECK  ((len([Compliance])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Compliance$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Conclusion$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Conclusion$disallow_zero_length] CHECK  ((len([Conclusion])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Conclusion$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Detrusor_Press$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Detrusor_Press$disallow_zero_length] CHECK  ((len([Detrusor_Press])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Detrusor_Press$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$DLPP$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$DLPP$disallow_zero_length] CHECK  ((len([DLPP])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$DLPP$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Exam_Other$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Exam_Other$disallow_zero_length] CHECK  ((len([Exam_Other])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Exam_Other$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Fill_Other$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Fill_Other$disallow_zero_length] CHECK  ((len([Fill_Other])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Fill_Other$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Fill_Rmks$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Fill_Rmks$disallow_zero_length] CHECK  ((len([Fill_Rmks])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Fill_Rmks$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Filling_Rate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Filling_Rate$disallow_zero_length] CHECK  ((len([Filling_Rate])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Filling_Rate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Peak_Flow_Rate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Peak_Flow_Rate$disallow_zero_length] CHECK  ((len([Peak_Flow_Rate])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Peak_Flow_Rate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Residual_Urine$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Residual_Urine$disallow_zero_length] CHECK  ((len([Residual_Urine])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Residual_Urine$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Residual_Volume$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Residual_Volume$disallow_zero_length] CHECK  ((len([Residual_Volume])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Residual_Volume$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Sensation$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Sensation$disallow_zero_length] CHECK  ((len([Sensation])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Sensation$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Sph_Activity$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Sph_Activity$disallow_zero_length] CHECK  ((len([Sph_Activity])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Sph_Activity$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Stability$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Stability$disallow_zero_length] CHECK  ((len([Stability])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Stability$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Stress_Inc$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Stress_Inc$disallow_zero_length] CHECK  ((len([Stress_Inc])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Stress_Inc$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Uroflow_Rmks$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Uroflow_Rmks$disallow_zero_length] CHECK  ((len([Uroflow_Rmks])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Uroflow_Rmks$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$VLPP$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$VLPP$disallow_zero_length] CHECK  ((len([VLPP])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$VLPP$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Void_Other$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Void_Other$disallow_zero_length] CHECK  ((len([Void_Other])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Void_Other$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Void_Rmks$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Void_Rmks$disallow_zero_length] CHECK  ((len([Void_Rmks])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Void_Rmks$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$Voided_Volume$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$Voided_Volume$disallow_zero_length] CHECK  ((len([Voided_Volume])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$Voided_Volume$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$UDS$VoidPhase_Flow_Rate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$UDS$VoidPhase_Flow_Rate$disallow_zero_length] CHECK  ((len([VoidPhase_Flow_Rate])>(0)))
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [SSMA_CC$UDS$VoidPhase_Flow_Rate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Treatment_Advised$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatment_Advised]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Treatment_Advised$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Treatment_Advised] CHECK CONSTRAINT [SSMA_CC$Treatment_Advised$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Treatment_Advised$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatment_Advised]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Treatment_Advised$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Treatment_Advised] CHECK CONSTRAINT [SSMA_CC$Treatment_Advised$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Treatment_Advised$Treatment_Adv$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatment_Advised]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Treatment_Advised$Treatment_Adv$disallow_zero_length] CHECK  ((len([Treatment_Adv])>(0)))
GO
ALTER TABLE [dbo].[Treatment_Advised] CHECK CONSTRAINT [SSMA_CC$Treatment_Advised$Treatment_Adv$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Treatement_Dtls$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Treatement_Dtls$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Treatement_Dtls] CHECK CONSTRAINT [SSMA_CC$Treatement_Dtls$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Treatement_Dtls$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Treatement_Dtls$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Treatement_Dtls] CHECK CONSTRAINT [SSMA_CC$Treatement_Dtls$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Treatement_Dtls$Treatment_Given$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Treatement_Dtls$Treatment_Given$disallow_zero_length] CHECK  ((len([Treatment_Given])>(0)))
GO
ALTER TABLE [dbo].[Treatement_Dtls] CHECK CONSTRAINT [SSMA_CC$Treatement_Dtls$Treatment_Given$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Prescription_Dtls$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Prescription_Dtls$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Prescription_Dtls] CHECK CONSTRAINT [SSMA_CC$Prescription_Dtls$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Prescription_Dtls$Modified_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Prescription_Dtls$Modified_By$disallow_zero_length] CHECK  ((len([Modified_By])>(0)))
GO
ALTER TABLE [dbo].[Prescription_Dtls] CHECK CONSTRAINT [SSMA_CC$Prescription_Dtls$Modified_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Prescription_Dtls$Prescription_Dtls$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Prescription_Dtls$Prescription_Dtls$disallow_zero_length] CHECK  ((len([Prescription_Dtls])>(0)))
GO
ALTER TABLE [dbo].[Prescription_Dtls] CHECK CONSTRAINT [SSMA_CC$Prescription_Dtls$Prescription_Dtls$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Follow_Up$Complaints$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Follow_Up$Complaints$disallow_zero_length] CHECK  ((len([Complaints])>(0)))
GO
ALTER TABLE [dbo].[Follow_Up] CHECK CONSTRAINT [SSMA_CC$Follow_Up$Complaints$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Follow_Up$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Follow_Up$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Follow_Up] CHECK CONSTRAINT [SSMA_CC$Follow_Up$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Follow_Up$Evaluation$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Follow_Up$Evaluation$disallow_zero_length] CHECK  ((len([Evaluation])>(0)))
GO
ALTER TABLE [dbo].[Follow_Up] CHECK CONSTRAINT [SSMA_CC$Follow_Up$Evaluation$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Follow_Up$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Follow_Up$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Follow_Up] CHECK CONSTRAINT [SSMA_CC$Follow_Up$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Follow_Up$Treatment$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Follow_Up$Treatment$disallow_zero_length] CHECK  ((len([Treatment])>(0)))
GO
ALTER TABLE [dbo].[Follow_Up] CHECK CONSTRAINT [SSMA_CC$Follow_Up$Treatment$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Analgesic$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Analgesic$disallow_zero_length] CHECK  ((len([Analgesic])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Analgesic$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Comments$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Comments$disallow_zero_length] CHECK  ((len([Comments])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Comments$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Complications$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Complications$disallow_zero_length] CHECK  ((len([Complications])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Complications$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$ESWL_Level$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$ESWL_Level$disallow_zero_length] CHECK  ((len([ESWL_Level])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$ESWL_Level$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$ESWL_Size$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$ESWL_Size$disallow_zero_length] CHECK  ((len([ESWL_Size])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$ESWL_Size$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Fluroscopy$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Fluroscopy$disallow_zero_length] CHECK  ((len([Fluroscopy])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Fluroscopy$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$IV_Fluids$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$IV_Fluids$disallow_zero_length] CHECK  ((len([IV_Fluids])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$IV_Fluids$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Shock_Waves$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Shock_Waves$disallow_zero_length] CHECK  ((len([Shock_Waves])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Shock_Waves$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Side$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Side$disallow_zero_length] CHECK  ((len([Side])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Side$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$ESWL$Site$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$ESWL$Site$disallow_zero_length] CHECK  ((len([Site])>(0)))
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [SSMA_CC$ESWL$Site$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Bill_Entry$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Bill_Entry$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Bill_Entry] CHECK CONSTRAINT [SSMA_CC$Bill_Entry$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Bill_Entry$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Bill_Entry$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Bill_Entry] CHECK CONSTRAINT [SSMA_CC$Bill_Entry$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Alcoholism$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Alcoholism$disallow_zero_length] CHECK  ((len([Alcoholism])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Alcoholism$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Complaint$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Complaint$disallow_zero_length] CHECK  ((len([Complaint])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Complaint$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Ejaculation$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Ejaculation$disallow_zero_length] CHECK  ((len([Ejaculation])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Ejaculation$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Epididymis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Epididymis$disallow_zero_length] CHECK  ((len([Epididymis])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Epididymis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Erection$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Erection$disallow_zero_length] CHECK  ((len([Erection])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Erection$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Fever$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Fever$disallow_zero_length] CHECK  ((len([Fever])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Fever$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$General_Exam$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$General_Exam$disallow_zero_length] CHECK  ((len([General_Exam])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$General_Exam$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$LH$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$LH$disallow_zero_length] CHECK  ((len([LH])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$LH$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Married_Since$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Married_Since$disallow_zero_length] CHECK  ((len([Married_Since])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Married_Since$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Mumps_Orchits$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Mumps_Orchits$disallow_zero_length] CHECK  ((len([Mumps_Orchits])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Mumps_Orchits$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Others$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Others$disallow_zero_length] CHECK  ((len([Others])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Others$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$PA$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$PA$disallow_zero_length] CHECK  ((len([PA])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$PA$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$PR$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$PR$disallow_zero_length] CHECK  ((len([PR])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$PR$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Prolactin$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Prolactin$disallow_zero_length] CHECK  ((len([Prolactin])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Prolactin$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Semen_Analysis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Semen_Analysis$disallow_zero_length] CHECK  ((len([Semen_Analysis])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Semen_Analysis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Signi_Illness$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Signi_Illness$disallow_zero_length] CHECK  ((len([Signi_Illness])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Signi_Illness$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Smoking$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Smoking$disallow_zero_length] CHECK  ((len([Smoking])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Smoking$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$SR_FSH$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$SR_FSH$disallow_zero_length] CHECK  ((len([SR_FSH])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$SR_FSH$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Testi_Biopsy$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Testi_Biopsy$disallow_zero_length] CHECK  ((len([Testi_Biopsy])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Testi_Biopsy$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Testis$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Testis$disallow_zero_length] CHECK  ((len([Testis])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Testis$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Testosterone$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Testosterone$disallow_zero_length] CHECK  ((len([Testosterone])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Testosterone$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Treatment_Given$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Treatment_Given$disallow_zero_length] CHECK  ((len([Treatment_Given])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Treatment_Given$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Treatment_Taken$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Treatment_Taken$disallow_zero_length] CHECK  ((len([Treatment_Taken])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Treatment_Taken$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Varicocele$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Varicocele$disallow_zero_length] CHECK  ((len([Varicocele])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Varicocele$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$VAS$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$VAS$disallow_zero_length] CHECK  ((len([VAS])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$VAS$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Andrology$Virilization$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Andrology$Virilization$disallow_zero_length] CHECK  ((len([Virilization])>(0)))
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [SSMA_CC$Andrology$Virilization$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Abdomen$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Abdomen$disallow_zero_length] CHECK  ((len([Abdomen])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Abdomen$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Anal_Tone$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Anal_Tone$disallow_zero_length] CHECK  ((len([Anal_Tone])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Anal_Tone$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$BCR$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$BCR$disallow_zero_length] CHECK  ((len([BCR])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$BCR$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$BP$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$BP$disallow_zero_length] CHECK  ((len([BP])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$BP$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$CNS$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$CNS$disallow_zero_length] CHECK  ((len([CNS])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$CNS$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Created_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Created_By$disallow_zero_length] CHECK  ((len([Created_By])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Created_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$CVS$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$CVS$disallow_zero_length] CHECK  ((len([CVS])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$CVS$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$G_E$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$G_E$disallow_zero_length] CHECK  ((len([G_E])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$G_E$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Genitalia$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Genitalia$disallow_zero_length] CHECK  ((len([Genitalia])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Genitalia$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Modify_By$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Modify_By$disallow_zero_length] CHECK  ((len([Modify_By])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Modify_By$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Others$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Others$disallow_zero_length] CHECK  ((len([Others])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Others$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$P_S$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$P_S$disallow_zero_length] CHECK  ((len([P_S])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$P_S$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$P_V$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$P_V$disallow_zero_length] CHECK  ((len([P_V])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$P_V$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$PR_Others$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$PR_Others$disallow_zero_length] CHECK  ((len([PR_Others])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$PR_Others$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Prostate$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Prostate$disallow_zero_length] CHECK  ((len([Prostate])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Prostate$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Pulse$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Pulse$disallow_zero_length] CHECK  ((len([Pulse])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Pulse$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$R_S$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$R_S$disallow_zero_length] CHECK  ((len([R_S])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$R_S$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Remarks$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Remarks$disallow_zero_length] CHECK  ((len([Remarks])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Remarks$disallow_zero_length]
GO
/****** Object:  Check [SSMA_CC$Patient_Examination$Weight$disallow_zero_length]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Patient_Examination$Weight$disallow_zero_length] CHECK  ((len([Weight])>(0)))
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [SSMA_CC$Patient_Examination$Weight$disallow_zero_length]
GO
/****** Object:  ForeignKey [Patient_Info$Doctors_ListPatient_Info]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Info]  WITH NOCHECK ADD  CONSTRAINT [Patient_Info$Doctors_ListPatient_Info] FOREIGN KEY([DR_No])
REFERENCES [dbo].[Doctors_List] ([DR_NO])
GO
ALTER TABLE [dbo].[Patient_Info] CHECK CONSTRAINT [Patient_Info$Doctors_ListPatient_Info]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Info].[Doctors_ListPatient_Info]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Info', @level2type=N'CONSTRAINT',@level2name=N'Patient_Info$Doctors_ListPatient_Info'
GO
/****** Object:  ForeignKey [User_Login_Dtl$User_MasterUser_Login_Dtl]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Login_Dtl]  WITH NOCHECK ADD  CONSTRAINT [User_Login_Dtl$User_MasterUser_Login_Dtl] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User_Master] ([User_Id])
GO
ALTER TABLE [dbo].[User_Login_Dtl] CHECK CONSTRAINT [User_Login_Dtl$User_MasterUser_Login_Dtl]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Login_Dtl].[User_MasterUser_Login_Dtl]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Login_Dtl', @level2type=N'CONSTRAINT',@level2name=N'User_Login_Dtl$User_MasterUser_Login_Dtl'
GO
/****** Object:  ForeignKey [User_Role$User_MasterUser_Role]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[User_Role]  WITH NOCHECK ADD  CONSTRAINT [User_Role$User_MasterUser_Role] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User_Master] ([User_Id])
GO
ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [User_Role$User_MasterUser_Role]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[User_Role].[User_MasterUser_Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Role', @level2type=N'CONSTRAINT',@level2name=N'User_Role$User_MasterUser_Role'
GO
/****** Object:  ForeignKey [X_Ray$Patient_InfoX_Ray]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[X_Ray]  WITH NOCHECK ADD  CONSTRAINT [X_Ray$Patient_InfoX_Ray] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[X_Ray] CHECK CONSTRAINT [X_Ray$Patient_InfoX_Ray]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[X_Ray].[Patient_InfoX_Ray]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'X_Ray', @level2type=N'CONSTRAINT',@level2name=N'X_Ray$Patient_InfoX_Ray'
GO
/****** Object:  ForeignKey [Investigation$Patient_InfoInvestigation]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation]  WITH NOCHECK ADD  CONSTRAINT [Investigation$Patient_InfoInvestigation] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Investigation] CHECK CONSTRAINT [Investigation$Patient_InfoInvestigation]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation].[Patient_InfoInvestigation]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation', @level2type=N'CONSTRAINT',@level2name=N'Investigation$Patient_InfoInvestigation'
GO
/****** Object:  ForeignKey [Images$Image_MasterImages]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images]  WITH NOCHECK ADD  CONSTRAINT [Images$Image_MasterImages] FOREIGN KEY([Image_Id])
REFERENCES [dbo].[Image_Master] ([Image_Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [Images$Image_MasterImages]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Image_MasterImages]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'CONSTRAINT',@level2name=N'Images$Image_MasterImages'
GO
/****** Object:  ForeignKey [Images$Patient_InfoImages]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Images]  WITH NOCHECK ADD  CONSTRAINT [Images$Patient_InfoImages] FOREIGN KEY([GU_No], [GU_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [Images$Patient_InfoImages]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Images].[Patient_InfoImages]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Images', @level2type=N'CONSTRAINT',@level2name=N'Images$Patient_InfoImages'
GO
/****** Object:  ForeignKey [Operation_Dtls$Doctors_ListOperation_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [Operation_Dtls$Doctors_ListOperation_Dtls] FOREIGN KEY([Anaesthesiologist])
REFERENCES [dbo].[Doctors_List] ([DR_NO])
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [Operation_Dtls$Doctors_ListOperation_Dtls]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Doctors_ListOperation_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Operation_Dtls$Doctors_ListOperation_Dtls'
GO
/****** Object:  ForeignKey [Operation_Dtls$Patient_InfoOperation_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Operation_Dtls]  WITH NOCHECK ADD  CONSTRAINT [Operation_Dtls$Patient_InfoOperation_Dtls] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Operation_Dtls] CHECK CONSTRAINT [Operation_Dtls$Patient_InfoOperation_Dtls]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Operation_Dtls].[Patient_InfoOperation_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Operation_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Operation_Dtls$Patient_InfoOperation_Dtls'
GO
/****** Object:  ForeignKey [IPD$Patient_InfoIPD]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[IPD]  WITH NOCHECK ADD  CONSTRAINT [IPD$Patient_InfoIPD] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[IPD] CHECK CONSTRAINT [IPD$Patient_InfoIPD]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[IPD].[Patient_InfoIPD]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IPD', @level2type=N'CONSTRAINT',@level2name=N'IPD$Patient_InfoIPD'
GO
/****** Object:  ForeignKey [Investigation_Test_Dtls$Patient_InfoInvestigation_Test_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Investigation_Test_Dtls]  WITH NOCHECK ADD  CONSTRAINT [Investigation_Test_Dtls$Patient_InfoInvestigation_Test_Dtls] FOREIGN KEY([GU_No], [GU_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Investigation_Test_Dtls] CHECK CONSTRAINT [Investigation_Test_Dtls$Patient_InfoInvestigation_Test_Dtls]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Investigation_Test_Dtls].[Patient_InfoInvestigation_Test_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Investigation_Test_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Investigation_Test_Dtls$Patient_InfoInvestigation_Test_Dtls'
GO
/****** Object:  ForeignKey [Urology_History$Patient_InfoUrology_History]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Urology_History]  WITH NOCHECK ADD  CONSTRAINT [Urology_History$Patient_InfoUrology_History] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Urology_History] CHECK CONSTRAINT [Urology_History$Patient_InfoUrology_History]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Urology_History].[Patient_InfoUrology_History]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Urology_History', @level2type=N'CONSTRAINT',@level2name=N'Urology_History$Patient_InfoUrology_History'
GO
/****** Object:  ForeignKey [UDS$Patient_InfoUDS]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[UDS]  WITH NOCHECK ADD  CONSTRAINT [UDS$Patient_InfoUDS] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[UDS] CHECK CONSTRAINT [UDS$Patient_InfoUDS]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[UDS].[Patient_InfoUDS]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UDS', @level2type=N'CONSTRAINT',@level2name=N'UDS$Patient_InfoUDS'
GO
/****** Object:  ForeignKey [Treatment_Advised$Patient_InfoTreatment_Advised]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatment_Advised]  WITH NOCHECK ADD  CONSTRAINT [Treatment_Advised$Patient_InfoTreatment_Advised] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Treatment_Advised] CHECK CONSTRAINT [Treatment_Advised$Patient_InfoTreatment_Advised]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatment_Advised].[Patient_InfoTreatment_Advised]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatment_Advised', @level2type=N'CONSTRAINT',@level2name=N'Treatment_Advised$Patient_InfoTreatment_Advised'
GO
/****** Object:  ForeignKey [Treatement_Dtls$Patient_InfoTreatement_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Treatement_Dtls]  WITH NOCHECK ADD  CONSTRAINT [Treatement_Dtls$Patient_InfoTreatement_Dtls] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Treatement_Dtls] CHECK CONSTRAINT [Treatement_Dtls$Patient_InfoTreatement_Dtls]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Treatement_Dtls].[Patient_InfoTreatement_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Treatement_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Treatement_Dtls$Patient_InfoTreatement_Dtls'
GO
/****** Object:  ForeignKey [Prescription_Dtls$Patient_InfoPrescription_Dtls]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Prescription_Dtls]  WITH NOCHECK ADD  CONSTRAINT [Prescription_Dtls$Patient_InfoPrescription_Dtls] FOREIGN KEY([GU_No], [GU_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Prescription_Dtls] CHECK CONSTRAINT [Prescription_Dtls$Patient_InfoPrescription_Dtls]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Prescription_Dtls].[Patient_InfoPrescription_Dtls]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Prescription_Dtls', @level2type=N'CONSTRAINT',@level2name=N'Prescription_Dtls$Patient_InfoPrescription_Dtls'
GO
/****** Object:  ForeignKey [Follow_Up$Patient_InfoFollow_Up]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Follow_Up]  WITH NOCHECK ADD  CONSTRAINT [Follow_Up$Patient_InfoFollow_Up] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Follow_Up] CHECK CONSTRAINT [Follow_Up$Patient_InfoFollow_Up]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Follow_Up].[Patient_InfoFollow_Up]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Follow_Up', @level2type=N'CONSTRAINT',@level2name=N'Follow_Up$Patient_InfoFollow_Up'
GO
/****** Object:  ForeignKey [ESWL$Patient_InfoESWL]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[ESWL]  WITH NOCHECK ADD  CONSTRAINT [ESWL$Patient_InfoESWL] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[ESWL] CHECK CONSTRAINT [ESWL$Patient_InfoESWL]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[ESWL].[Patient_InfoESWL]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ESWL', @level2type=N'CONSTRAINT',@level2name=N'ESWL$Patient_InfoESWL'
GO
/****** Object:  ForeignKey [Bill_Entry$Patient_InfoBill_Entry]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Bill_Entry]  WITH NOCHECK ADD  CONSTRAINT [Bill_Entry$Patient_InfoBill_Entry] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Bill_Entry] CHECK CONSTRAINT [Bill_Entry$Patient_InfoBill_Entry]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Bill_Entry].[Patient_InfoBill_Entry]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill_Entry', @level2type=N'CONSTRAINT',@level2name=N'Bill_Entry$Patient_InfoBill_Entry'
GO
/****** Object:  ForeignKey [Andrology$Patient_InfoAndrology]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Andrology]  WITH NOCHECK ADD  CONSTRAINT [Andrology$Patient_InfoAndrology] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Andrology] CHECK CONSTRAINT [Andrology$Patient_InfoAndrology]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Andrology].[Patient_InfoAndrology]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Andrology', @level2type=N'CONSTRAINT',@level2name=N'Andrology$Patient_InfoAndrology'
GO
/****** Object:  ForeignKey [Patient_Examination$Patient_InfoPatient_Examination]    Script Date: 04/07/2012 20:23:52 ******/
ALTER TABLE [dbo].[Patient_Examination]  WITH NOCHECK ADD  CONSTRAINT [Patient_Examination$Patient_InfoPatient_Examination] FOREIGN KEY([Gu_No], [Gu_Year])
REFERENCES [dbo].[Patient_Info] ([Gu_No], [Gu_Year])
GO
ALTER TABLE [dbo].[Patient_Examination] CHECK CONSTRAINT [Patient_Examination$Patient_InfoPatient_Examination]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'URO Care.[Patient_Examination].[Patient_InfoPatient_Examination]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Patient_Examination', @level2type=N'CONSTRAINT',@level2name=N'Patient_Examination$Patient_InfoPatient_Examination'
GO
