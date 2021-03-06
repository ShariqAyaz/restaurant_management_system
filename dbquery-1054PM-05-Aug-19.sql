USE [ESITERP]
GO
/****** Object:  UserDefinedDataType [dbo].[aaa]    Script Date: 05/08/2019 10:54:24 PM ******/
CREATE TYPE [dbo].[aaa] FROM [char](8000) NOT NULL
GO
/****** Object:  Table [dbo].[Account_head]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account_head](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Accounts_head_desc] [nvarchar](50) NOT NULL,
	[Accounts_head_shortcode] [nvarchar](50) NOT NULL,
	[from_code_range] [int] NOT NULL,
	[to_code_range] [int] NOT NULL,
 CONSTRAINT [PK_Accounts_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Accounts_head_desc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Accounts_head_shortcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[account_transactions]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account_transactions](
	[transaction_no] [int] IDENTITY(1,1) NOT NULL,
	[account_id] [int] NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[ref_doc_no] [int] NOT NULL,
	[description] [nvarchar](50) NOT NULL,
	[cr] [decimal](18, 2) NOT NULL,
	[dr] [decimal](18, 2) NOT NULL,
	[b_entity_id] [int] NOT NULL,
 CONSTRAINT [PK_account_transactions] PRIMARY KEY CLUSTERED 
(
	[transaction_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__account___85C678DDE366B244] UNIQUE NONCLUSTERED 
(
	[transaction_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Account_head_id] [int] NOT NULL,
	[Account_code] [int] NOT NULL,
	[Account_name] [nvarchar](50) NOT NULL,
	[Account_desc] [nvarchar](50) NOT NULL,
	[timestamp] [datetime] NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Account_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Account_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[appmodule]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appmodule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[module] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_modules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__modules__44C3FE98FEC09517] UNIQUE NONCLUSTERED 
(
	[module] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[apps]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[apps](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[app_name] [nvarchar](50) NOT NULL CONSTRAINT [DF_apps_app_name]  DEFAULT (''),
	[app_url] [nvarchar](250) NOT NULL CONSTRAINT [DF_apps_app_url]  DEFAULT (''),
	[app_ver] [nvarchar](50) NOT NULL CONSTRAINT [DF_apps_app_ver]  DEFAULT (''),
	[amid] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__apps__timestamp__2F10007B]  DEFAULT (getdate()),
 CONSTRAINT [PK_apps] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[b_entity]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[b_entity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[entity_name] [nvarchar](50) NOT NULL,
	[entity_location] [nvarchar](50) NOT NULL,
	[restaurant_sale_db] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_B_entity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOM]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOM](
	[id] [int] NOT NULL,
	[fg_id] [int] NOT NULL,
	[fg_Name] [nvarchar](max) NOT NULL,
	[version] [int] NOT NULL CONSTRAINT [DF_BOM_version]  DEFAULT ((1)),
	[isActive] [bit] NOT NULL CONSTRAINT [DF_BOM_isActive]  DEFAULT ((1)),
	[b_entity_id] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__BOM__timestamp__690797E6]  DEFAULT (getdate()),
 CONSTRAINT [PK_BOM] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [fgid-ver] UNIQUE NONCLUSTERED 
(
	[fg_id] ASC,
	[version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__BOM__3213E83EA34E2B2F] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOM_det]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOM_det](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bom_id] [int] NOT NULL,
	[iid] [int] NOT NULL,
	[iqty] [decimal](18, 2) NOT NULL CONSTRAINT [DF_BOM_det_iqty]  DEFAULT ((0)),
 CONSTRAINT [PK_BOM_det] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_BOM_det] UNIQUE NONCLUSTERED 
(
	[bom_id] ASC,
	[iid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[departments]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dept_name] [nvarchar](50) NOT NULL,
	[dept_cat_id] [int] NOT NULL,
	[isActive] [bit] NOT NULL DEFAULT ((1)),
	[b_entity_id] [int] NOT NULL,
 CONSTRAINT [PK_departments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dept_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dept_cat]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dept_cat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dept_cat] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dept_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[documents_types]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documents_types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doc_type_desc] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_documents_types] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__document__3213E83E95DA8B5E] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[documents_types_components]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documents_types_components](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doc_type_id] [int] NOT NULL,
	[component_name] [nvarchar](50) NOT NULL,
	[isMandatory] [bit] NOT NULL CONSTRAINT [DF_documents_types_components_isMandatory]  DEFAULT ((1)),
	[hasMany_lineitem] [bit] NOT NULL,
	[baseAccount] [bit] NOT NULL,
	[component_parent_table] [nvarchar](50) NOT NULL,
	[component_child_table] [nvarchar](50) NOT NULL,
	[dr_account_id] [int] NOT NULL,
	[uid] [int] NOT NULL,
 CONSTRAINT [PK_documents_types_components] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__document__3213E83EACA1E438] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grn_expense_det]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grn_expense_det](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[grn_no] [int] NOT NULL,
	[expense_desc] [nvarchar](100) NOT NULL,
	[exp_amt] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_grn_expense_det] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__grn_expe__39D8BA941B5B2AFC] UNIQUE NONCLUSTERED 
(
	[grn_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grn_items_det]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grn_items_det](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[grn_no] [int] NOT NULL,
	[iid] [int] NOT NULL,
	[irate] [decimal](18, 2) NOT NULL,
	[iqty] [decimal](18, 2) NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__grn_item___times__116A8EFB]  DEFAULT (getdate()),
 CONSTRAINT [PK_grn_item_det] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__grn_item__3213E83E7720E6D9] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grn_note]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grn_note](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[grn_no] [int] NOT NULL,
	[supplier_invoice] [nvarchar](50) NOT NULL CONSTRAINT [DF_grn_note_supplier_invoice]  DEFAULT (N'na'),
	[vendor_id] [int] NOT NULL,
	[GRDate] [datetime] NOT NULL,
	[uid] [int] NOT NULL,
	[b_entity_id] [int] NOT NULL,
	[remarks] [nvarchar](100) NULL,
	[isPosted] [int] NOT NULL CONSTRAINT [DF_grn_note_isPosted]  DEFAULT ((0)),
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__grn_note__timest__63A3C44B]  DEFAULT (getdate()),
 CONSTRAINT [PK_grn_note] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__grn_note__3213E83E7C89F11A] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__grn_note__39D8BA94CB526050] UNIQUE NONCLUSTERED 
(
	[grn_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[group_details]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[group_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[gid] [int] NOT NULL,
	[app_id] [int] NOT NULL,
	[action_id] [int] NOT NULL,
	[b_entity_id] [int] NOT NULL,
 CONSTRAINT [PK_group_details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_group_details] UNIQUE NONCLUSTERED 
(
	[app_id] ASC,
	[gid] ASC,
	[action_id] ASC,
	[b_entity_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__group_de__3213E83ED591BC3C] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item_mast]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_mast](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[iname] [nvarchar](100) NOT NULL,
	[idesc] [nvarchar](100) NOT NULL CONSTRAINT [DF__item_mast__idesc__300424B4]  DEFAULT ('NA'),
	[ibarcode] [nvarchar](100) NOT NULL CONSTRAINT [DF__item_mast__ibarc__30F848ED]  DEFAULT ('NA'),
	[main_cat_id] [int] NOT NULL,
	[sub_cat_id] [int] NOT NULL,
	[uom_purchase_id] [int] NOT NULL,
	[uom_consumption_id] [int] NOT NULL,
	[divisible_uop] [decimal](18, 2) NOT NULL CONSTRAINT [DF_item_mast_divisible_uop]  DEFAULT ((1)),
	[uid] [int] NOT NULL,
	[default_wh] [int] NOT NULL,
	[account_id] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__item_mast__times__31EC6D26]  DEFAULT (getdate()),
 CONSTRAINT [PK_item_mast_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__item_mas__135C835E18B8670B] UNIQUE NONCLUSTERED 
(
	[iname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__item_mas__3213E83EF745B391] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ibarcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[main_cat]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[main_cat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[main_cat] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_main_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[main_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[main_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[numerator]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[numerator](
	[grn] [int] NOT NULL,
	[store_doc_id] [int] NOT NULL,
	[ven_pay_no] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[store]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[store](
	[doc_id] [int] NOT NULL,
	[ref_doc_no] [int] NOT NULL,
	[doc_type_id] [int] NOT NULL,
	[doc_date] [datetime] NOT NULL,
	[uid] [int] NOT NULL,
	[remarks] [nvarchar](50) NOT NULL,
	[b_entity_id] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF_store_timestamp]  DEFAULT (getdate()),
 CONSTRAINT [PK_store_1] PRIMARY KEY CLUSTERED 
(
	[doc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[store_det]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[store_det](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doc_id] [int] NOT NULL,
	[iid] [int] NOT NULL,
	[increase_qty] [decimal](18, 2) NOT NULL,
	[decrease_qty] [decimal](18, 2) NOT NULL,
	[whid] [int] NOT NULL,
 CONSTRAINT [PK_store_det] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__store_de__3213E83E0CCB6F81] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sub_cat]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_cat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sub_cat] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sub_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[sub_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[sub_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UOM]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UOM](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UOM] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UOM] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_groups]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_groups](
	[id] [int] NOT NULL,
	[group_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_users_group] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [nvarchar](50) NOT NULL,
	[user_pass] [nvarchar](50) NOT NULL,
	[gid] [int] NOT NULL,
	[isActive] [bit] NOT NULL CONSTRAINT [DF_users_user_status]  DEFAULT ((1)),
	[isAdmin] [bit] NOT NULL CONSTRAINT [DF_users_isAdmin]  DEFAULT ((0)),
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__users__timestamp__34C8D9D1]  DEFAULT (getdate()),
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__users__CBA1B256CECD6434] UNIQUE NONCLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users_action]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users_action](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[action] [nvarchar](6) NOT NULL CONSTRAINT [DF_user_actions_action]  DEFAULT ('0'),
 CONSTRAINT [PK_user_actions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vendor_master]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendor_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](50) NOT NULL,
	[Contact_Person_name] [nvarchar](50) NOT NULL,
	[Contact_Person_Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[goods_desc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_vendor_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__vendor_m__3213E83EA505E158] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__vendor_m__7320A35704A3AFF7] UNIQUE NONCLUSTERED 
(
	[VendorName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vendor_payment_doc]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendor_payment_doc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vpno] [int] NOT NULL,
	[vendor_id] [int] NOT NULL,
	[vDate] [datetime] NOT NULL,
	[cr_acc_id] [int] NOT NULL,
	[dr_amount] [decimal](18, 2) NOT NULL,
	[uid] [int] NOT NULL,
	[b_entity_id] [int] NOT NULL,
	[remarks] [nvarchar](100) NOT NULL CONSTRAINT [DF_vendor_payment_doc_remarks]  DEFAULT (''),
	[isPosted] [int] NOT NULL CONSTRAINT [DF__vendor_pa__isPos__7EC1CEDB]  DEFAULT ((0)),
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__vendor_pa__times__7FB5F314]  DEFAULT (getdate()),
 CONSTRAINT [UQ__vendor_p__7126403B0047957C] UNIQUE NONCLUSTERED 
(
	[vpno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vendor_transactions]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendor_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ven_id] [int] NOT NULL,
	[ttype] [nvarchar](10) NOT NULL,
	[tdate] [datetime] NOT NULL CONSTRAINT [DF__vendor_tr__tdate__57FD0775]  DEFAULT (getdate()),
	[ref_doc_no] [int] NOT NULL,
	[dr] [decimal](18, 2) NOT NULL CONSTRAINT [DF__vendor_trans__dr__58F12BAE]  DEFAULT ((0)),
	[cr] [decimal](18, 2) NOT NULL CONSTRAINT [DF__vendor_trans__cr__59E54FE7]  DEFAULT ((0)),
	[remarks] [nvarchar](100) NOT NULL CONSTRAINT [DF__vendor_tr__remar__5AD97420]  DEFAULT ('-'),
	[b_entity_id] [int] NOT NULL,
	[uid] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF__vendor_tr__times__5BCD9859]  DEFAULT (getdate()),
 CONSTRAINT [PK_vendor_transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_vendor_transactions] UNIQUE NONCLUSTERED 
(
	[ref_doc_no] ASC,
	[ttype] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__vendor_t__3213E83E1A5F5E07] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[warehouse]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[wh_name] [nvarchar](50) NOT NULL,
	[wh_desc] [nvarchar](50) NOT NULL,
	[type_id] [int] NOT NULL,
	[location_id] [int] NOT NULL,
	[cat_id] [int] NOT NULL,
	[isActive] [bit] NOT NULL CONSTRAINT [DF_1warehouse_isActive]  DEFAULT ((1)),
	[uid] [int] NOT NULL,
	[b_entity_id] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL CONSTRAINT [DF_1warehouse_timestamp]  DEFAULT (getdate()),
 CONSTRAINT [UQ__warehous__3213E83EE08EA4F1] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[wh_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wh_cat]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wh_cat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cat_desc] [nvarchar](40) NOT NULL CONSTRAINT [DF_wh_cat_cat_desc]  DEFAULT (''),
 CONSTRAINT [PK_wh_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__wh_cat__206A16A6E964DF5A] UNIQUE NONCLUSTERED 
(
	[cat_desc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wh_location]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wh_location](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[location] [nvarchar](50) NOT NULL CONSTRAINT [DF_wh_location_location]  DEFAULT (''),
	[b_entity_id] [int] NOT NULL,
 CONSTRAINT [PK_wh_location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_wh_location] UNIQUE NONCLUSTERED 
(
	[b_entity_id] ASC,
	[location] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wh_type]    Script Date: 05/08/2019 10:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wh_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](30) NOT NULL CONSTRAINT [DF_warehouse_type_type]  DEFAULT (''),
 CONSTRAINT [PK_wh_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[account_transactions]  WITH CHECK ADD  CONSTRAINT [FK_account_transactions_Accounts_accid] FOREIGN KEY([account_id])
REFERENCES [dbo].[Accounts] ([id])
GO
ALTER TABLE [dbo].[account_transactions] CHECK CONSTRAINT [FK_account_transactions_Accounts_accid]
GO
ALTER TABLE [dbo].[account_transactions]  WITH CHECK ADD  CONSTRAINT [FK_account_transactions_b_entity] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[account_transactions] CHECK CONSTRAINT [FK_account_transactions_b_entity]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_account_head_headid] FOREIGN KEY([Account_head_id])
REFERENCES [dbo].[Account_head] ([id])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_account_head_headid]
GO
ALTER TABLE [dbo].[apps]  WITH CHECK ADD  CONSTRAINT [FK_apps_modules_mid] FOREIGN KEY([amid])
REFERENCES [dbo].[appmodule] ([id])
GO
ALTER TABLE [dbo].[apps] CHECK CONSTRAINT [FK_apps_modules_mid]
GO
ALTER TABLE [dbo].[BOM]  WITH CHECK ADD  CONSTRAINT [FK_BOM_B_entity_bentity_id] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[BOM] CHECK CONSTRAINT [FK_BOM_B_entity_bentity_id]
GO
ALTER TABLE [dbo].[BOM_det]  WITH CHECK ADD  CONSTRAINT [FK_BOM_det_BOM_bomid] FOREIGN KEY([bom_id])
REFERENCES [dbo].[BOM] ([id])
GO
ALTER TABLE [dbo].[BOM_det] CHECK CONSTRAINT [FK_BOM_det_BOM_bomid]
GO
ALTER TABLE [dbo].[BOM_det]  WITH CHECK ADD  CONSTRAINT [FK_BOM_det_item_mast_iid] FOREIGN KEY([iid])
REFERENCES [dbo].[item_mast] ([id])
GO
ALTER TABLE [dbo].[BOM_det] CHECK CONSTRAINT [FK_BOM_det_item_mast_iid]
GO
ALTER TABLE [dbo].[departments]  WITH CHECK ADD  CONSTRAINT [FK_departments_B_entity_bentityid] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[departments] CHECK CONSTRAINT [FK_departments_B_entity_bentityid]
GO
ALTER TABLE [dbo].[departments]  WITH CHECK ADD  CONSTRAINT [FK_departments_dept_cat_catid] FOREIGN KEY([dept_cat_id])
REFERENCES [dbo].[dept_cat] ([id])
GO
ALTER TABLE [dbo].[departments] CHECK CONSTRAINT [FK_departments_dept_cat_catid]
GO
ALTER TABLE [dbo].[documents_types_components]  WITH CHECK ADD  CONSTRAINT [FK_documents_types_components_Accounts_draccid] FOREIGN KEY([dr_account_id])
REFERENCES [dbo].[Accounts] ([id])
GO
ALTER TABLE [dbo].[documents_types_components] CHECK CONSTRAINT [FK_documents_types_components_Accounts_draccid]
GO
ALTER TABLE [dbo].[documents_types_components]  WITH CHECK ADD  CONSTRAINT [FK_documents_types_components_documents_types_doctypeid] FOREIGN KEY([doc_type_id])
REFERENCES [dbo].[documents_types] ([id])
GO
ALTER TABLE [dbo].[documents_types_components] CHECK CONSTRAINT [FK_documents_types_components_documents_types_doctypeid]
GO
ALTER TABLE [dbo].[documents_types_components]  WITH CHECK ADD  CONSTRAINT [FK_documents_types_components_users_uid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[documents_types_components] CHECK CONSTRAINT [FK_documents_types_components_users_uid]
GO
ALTER TABLE [dbo].[grn_expense_det]  WITH CHECK ADD  CONSTRAINT [FK_grn_expense_det_grn_note_grnno] FOREIGN KEY([grn_no])
REFERENCES [dbo].[grn_note] ([grn_no])
GO
ALTER TABLE [dbo].[grn_expense_det] CHECK CONSTRAINT [FK_grn_expense_det_grn_note_grnno]
GO
ALTER TABLE [dbo].[grn_items_det]  WITH CHECK ADD  CONSTRAINT [FK_grn_items_det_grn_note_grnno] FOREIGN KEY([grn_no])
REFERENCES [dbo].[grn_note] ([grn_no])
GO
ALTER TABLE [dbo].[grn_items_det] CHECK CONSTRAINT [FK_grn_items_det_grn_note_grnno]
GO
ALTER TABLE [dbo].[grn_items_det]  WITH CHECK ADD  CONSTRAINT [FK_grn_items_det_item_mast_iid] FOREIGN KEY([iid])
REFERENCES [dbo].[item_mast] ([id])
GO
ALTER TABLE [dbo].[grn_items_det] CHECK CONSTRAINT [FK_grn_items_det_item_mast_iid]
GO
ALTER TABLE [dbo].[grn_note]  WITH CHECK ADD  CONSTRAINT [FK_grn_note_b_entity_bentity_id] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[grn_note] CHECK CONSTRAINT [FK_grn_note_b_entity_bentity_id]
GO
ALTER TABLE [dbo].[grn_note]  WITH CHECK ADD  CONSTRAINT [FK_grn_note_users_uid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[grn_note] CHECK CONSTRAINT [FK_grn_note_users_uid]
GO
ALTER TABLE [dbo].[grn_note]  WITH CHECK ADD  CONSTRAINT [FK_grn_note_vendor_master_vendorid] FOREIGN KEY([vendor_id])
REFERENCES [dbo].[vendor_master] ([id])
GO
ALTER TABLE [dbo].[grn_note] CHECK CONSTRAINT [FK_grn_note_vendor_master_vendorid]
GO
ALTER TABLE [dbo].[group_details]  WITH CHECK ADD  CONSTRAINT [FK_group_details_apps] FOREIGN KEY([app_id])
REFERENCES [dbo].[apps] ([id])
GO
ALTER TABLE [dbo].[group_details] CHECK CONSTRAINT [FK_group_details_apps]
GO
ALTER TABLE [dbo].[group_details]  WITH CHECK ADD  CONSTRAINT [FK_group_details_b_entity_bentityid] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[group_details] CHECK CONSTRAINT [FK_group_details_b_entity_bentityid]
GO
ALTER TABLE [dbo].[group_details]  WITH CHECK ADD  CONSTRAINT [FK_group_details_user_groups_gid] FOREIGN KEY([gid])
REFERENCES [dbo].[user_groups] ([id])
GO
ALTER TABLE [dbo].[group_details] CHECK CONSTRAINT [FK_group_details_user_groups_gid]
GO
ALTER TABLE [dbo].[group_details]  WITH CHECK ADD  CONSTRAINT [FK_group_details_users_action_actionid] FOREIGN KEY([action_id])
REFERENCES [dbo].[users_action] ([ID])
GO
ALTER TABLE [dbo].[group_details] CHECK CONSTRAINT [FK_group_details_users_action_actionid]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_Accounts_accid] FOREIGN KEY([account_id])
REFERENCES [dbo].[Accounts] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_Accounts_accid]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_main_cat_maincatid] FOREIGN KEY([main_cat_id])
REFERENCES [dbo].[main_cat] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_main_cat_maincatid]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_sub_cat_subcatid] FOREIGN KEY([sub_cat_id])
REFERENCES [dbo].[sub_cat] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_sub_cat_subcatid]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_UOM_consumption] FOREIGN KEY([uom_consumption_id])
REFERENCES [dbo].[UOM] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_UOM_consumption]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_UOM_purchasing] FOREIGN KEY([uom_purchase_id])
REFERENCES [dbo].[UOM] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_UOM_purchasing]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_users_uid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_users_uid]
GO
ALTER TABLE [dbo].[item_mast]  WITH CHECK ADD  CONSTRAINT [FK_item_mast_warehouse_defaultwhid] FOREIGN KEY([default_wh])
REFERENCES [dbo].[warehouse] ([id])
GO
ALTER TABLE [dbo].[item_mast] CHECK CONSTRAINT [FK_item_mast_warehouse_defaultwhid]
GO
ALTER TABLE [dbo].[store]  WITH CHECK ADD  CONSTRAINT [FK_store_B_entity_bentity_id] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[store] CHECK CONSTRAINT [FK_store_B_entity_bentity_id]
GO
ALTER TABLE [dbo].[store]  WITH CHECK ADD  CONSTRAINT [FK_store_documents_types_doctypeid] FOREIGN KEY([doc_type_id])
REFERENCES [dbo].[documents_types] ([id])
GO
ALTER TABLE [dbo].[store] CHECK CONSTRAINT [FK_store_documents_types_doctypeid]
GO
ALTER TABLE [dbo].[store]  WITH CHECK ADD  CONSTRAINT [FK_store_users_uid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[store] CHECK CONSTRAINT [FK_store_users_uid]
GO
ALTER TABLE [dbo].[store_det]  WITH CHECK ADD  CONSTRAINT [FK_store_det_item_mast_iid] FOREIGN KEY([iid])
REFERENCES [dbo].[item_mast] ([id])
GO
ALTER TABLE [dbo].[store_det] CHECK CONSTRAINT [FK_store_det_item_mast_iid]
GO
ALTER TABLE [dbo].[store_det]  WITH CHECK ADD  CONSTRAINT [FK_store_det_store_docid] FOREIGN KEY([doc_id])
REFERENCES [dbo].[store] ([doc_id])
GO
ALTER TABLE [dbo].[store_det] CHECK CONSTRAINT [FK_store_det_store_docid]
GO
ALTER TABLE [dbo].[store_det]  WITH CHECK ADD  CONSTRAINT [FK_store_det_warehouse_destinationid] FOREIGN KEY([whid])
REFERENCES [dbo].[warehouse] ([id])
GO
ALTER TABLE [dbo].[store_det] CHECK CONSTRAINT [FK_store_det_warehouse_destinationid]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_user_groups_gid] FOREIGN KEY([gid])
REFERENCES [dbo].[user_groups] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_user_groups_gid]
GO
ALTER TABLE [dbo].[vendor_payment_doc]  WITH CHECK ADD  CONSTRAINT [FK_vendor_payment_doc_Accounts_accid] FOREIGN KEY([cr_acc_id])
REFERENCES [dbo].[Accounts] ([id])
GO
ALTER TABLE [dbo].[vendor_payment_doc] CHECK CONSTRAINT [FK_vendor_payment_doc_Accounts_accid]
GO
ALTER TABLE [dbo].[vendor_payment_doc]  WITH CHECK ADD  CONSTRAINT [FK_vendor_payment_doc_b_entity_bid] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[vendor_payment_doc] CHECK CONSTRAINT [FK_vendor_payment_doc_b_entity_bid]
GO
ALTER TABLE [dbo].[vendor_payment_doc]  WITH CHECK ADD  CONSTRAINT [FK_vendor_payment_doc_users_uid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[vendor_payment_doc] CHECK CONSTRAINT [FK_vendor_payment_doc_users_uid]
GO
ALTER TABLE [dbo].[vendor_payment_doc]  WITH CHECK ADD  CONSTRAINT [FK_vendor_payment_doc_vendor_master_vid] FOREIGN KEY([vendor_id])
REFERENCES [dbo].[vendor_master] ([id])
GO
ALTER TABLE [dbo].[vendor_payment_doc] CHECK CONSTRAINT [FK_vendor_payment_doc_vendor_master_vid]
GO
ALTER TABLE [dbo].[vendor_transactions]  WITH CHECK ADD  CONSTRAINT [FK_vendor_transactions_b_entity_bentity] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[vendor_transactions] CHECK CONSTRAINT [FK_vendor_transactions_b_entity_bentity]
GO
ALTER TABLE [dbo].[vendor_transactions]  WITH CHECK ADD  CONSTRAINT [FK_vendor_transactions_users_uid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[vendor_transactions] CHECK CONSTRAINT [FK_vendor_transactions_users_uid]
GO
ALTER TABLE [dbo].[vendor_transactions]  WITH CHECK ADD  CONSTRAINT [FK_vendor_transactions_vendor_master_venid] FOREIGN KEY([ven_id])
REFERENCES [dbo].[vendor_master] ([id])
GO
ALTER TABLE [dbo].[vendor_transactions] CHECK CONSTRAINT [FK_vendor_transactions_vendor_master_venid]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_B_entity_b_entity_id] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [FK_warehouse_B_entity_b_entity_id]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_users_userid] FOREIGN KEY([uid])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [FK_warehouse_users_userid]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_wh_cat_catid] FOREIGN KEY([cat_id])
REFERENCES [dbo].[wh_cat] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [FK_warehouse_wh_cat_catid]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_wh_location_locationid] FOREIGN KEY([location_id])
REFERENCES [dbo].[wh_location] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [FK_warehouse_wh_location_locationid]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_wh_type_typeid] FOREIGN KEY([type_id])
REFERENCES [dbo].[wh_type] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [FK_warehouse_wh_type_typeid]
GO
ALTER TABLE [dbo].[wh_location]  WITH CHECK ADD  CONSTRAINT [FK_wh_location_B_entity_bentity_id] FOREIGN KEY([b_entity_id])
REFERENCES [dbo].[b_entity] ([id])
GO
ALTER TABLE [dbo].[wh_location] CHECK CONSTRAINT [FK_wh_location_B_entity_bentity_id]
GO
EXEC sys.sp_addextendedproperty @name=N'a', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TYPE',@level1name=N'aaa'
GO
EXEC sys.sp_addextendedproperty @name=N'b', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TYPE',@level1name=N'aaa'
GO
EXEC sys.sp_addextendedproperty @name=N'c', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TYPE',@level1name=N'aaa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'REFERENCE DOCUMENT NUMBER AND TRANSACTION TYPE CANT BE SAME SYSTEM MUST STOP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vendor_transactions', @level2type=N'CONSTRAINT',@level2name=N'IX_vendor_transactions'
GO
