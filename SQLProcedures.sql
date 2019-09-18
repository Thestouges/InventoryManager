ALTER PROCEDURE [dbo].[AddItem]
	-- Add the parameters for the stored procedure here
	@item nvarchar(50),
	@type nvarchar(50),
	@quantity int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @ItemKey as int
	set @ItemKey = -1

    -- Insert statements for procedure here
	insert into Item (Item,Type,Quantity)
	values(@item,@type,@quantity)

	select @ItemKey = SCOPE_IDENTITY()

	exec WriteToLog @ItemKey,'Add Item', @quantity
END
Go

ALTER PROCEDURE [dbo].[AddItemType]
	-- Add the parameters for the stored procedure here
	@itemType nvarchar(50),
	@description nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert ItemTypes(Type,Description)
	values (@itemType, @description)
END
Go

ALTER PROCEDURE [dbo].[GetAllItemsTypes]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from ItemTypes
END
Go

ALTER PROCEDURE [dbo].[GetAllTypeItems]
	-- Add the parameters for the stored procedure here
	@type as nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from ItemTypes as A
	inner join Item as B on A.Type = B.Type
	where A.Type = @type
END
Go

ALTER PROCEDURE [dbo].[ModifyItemQuantity]
	-- Add the parameters for the stored procedure here
	@itemID nvarchar(50),
	@quantity int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Item set Quantity = @quantity
	where @itemID = @itemID

	exec WriteToLog @itemId, 'Modify', @quantity
END
Go

ALTER PROCEDURE [dbo].[ModifyItemType]
	-- Add the parameters for the stored procedure here
	@itemType nvarchar(50),
	@description nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update ItemTypes set Description = @description
	where Type = @itemType
END
Go

ALTER PROCEDURE [dbo].[RemoveItem]
	-- Add the parameters for the stored procedure here
	@itemID as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Item
	where ID = @itemID

	exec WriteToLog @itemID,'Remove Item', 0
END
Go

ALTER PROCEDURE [dbo].[WriteToLog]
	-- Add the parameters for the stored procedure here
	@itemID as int,
	@TransferType as nvarchar(50),
	@Quantity as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into [Log] (ItemID, Trans, Quantity, Timestamp)
	values(@itemID, @TransferType, @Quantity, GETDATE())
END
go