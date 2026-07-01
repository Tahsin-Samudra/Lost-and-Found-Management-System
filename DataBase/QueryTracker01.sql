Use LostStuff

Select * From Login

DELETE FROM Login;

select max(Id) from Login where Id like 'A-%'

Insert into Login(Id, Password, Name, Role, PhoneNumber) Values (
	'A-001',
	'123',
	'Tester',
	'Admin',
	'012345334'
)

Select * From Lost_Item
Drop Table Lost_Item

Create Table Lost_Item(
	ItemID varchar(40) primary key,
	ItemName varchar(Max),
	Picture varchar(Max),
	Type varchar(50),
	Status varchar(20), 
	Lost_Place varchar(50), 
	Item_shelf_no varchar(50)
)

Create Table Submission (
	SubmissionID varchar(40) primary key,
	ItemName varchar(max),
	Picture varchar(max),
	ItemID varchar(40),
	Submitted_By varchar(max),
	SubmissionTime varchar(15),
	SubmittedOn varchar(15),

	Foreign Key(ItemID) References Lost_Item(ItemID)
);

Update Lost_Item Set Status = 'Not Returned' Where ItemID = 'I-004'

Insert into TReturn(ReturnID, ItemName, Picture, ItemID, Returned_By, ReturnedTime, ReturnedOn) Values ('R-001', 'Chosma', ' ', ' ','Sayem', '12:01:15', '01-4-2026')

Create Table TReturn (
	ReturnID varchar(40) primary key,
	ItemName varchar(max),
	Picture varchar(max),
	ItemID varchar(40),
	Returned_By varchar(max),
	ReturnedTime varchar(15),
	ReturnedOn varchar(15),

	Foreign Key(ItemID) References Lost_Item(ItemID)
);



Select * From TReturn;

Select * From Submission

Delete From Submission Where SubmissionID = 'S-001';

Drop Table Submission

Delete From TReturn