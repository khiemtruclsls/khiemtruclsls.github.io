create table Category(
CateId int identity primary key,
CateName nvarchar(150)
)
create table Product(
ProductId int identity primary key,
ProName nvarchar(200),
ProPrice int ,
ProCateId int not null Foreign key references Category(CateId), 
)
Create Table Bill (
BillId int identity primary key ,
BuyName nvarchar(200),
BillDate dateTime,
Total int null
)
drop table Bill
drop table Cart
Create table Cart (
ProId int Foreign key references Product(ProductId),
ProPrice int, 
ProQuantity int ,
BillId int Foreign key references Bill(BillId)
primary key (ProId,BillId)
)

INSERT Category(CateName) VALUES('Vegetation')
INSERT Category(CateName) VALUES('Fruits')
INSERT Category(CateName) VALUES('Water')
INSERT Category(CateName) VALUES('FastFood')
INSERT Category(CateName) VALUES('Cereals')
INSERT Category(CateName) VALUES('Milk')


insert into Product (ProName, ProPrice, ProCateId) values ('Steel Wool S.o.s', 164, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Peppercorns - Green', 95, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Cheese - Cheddar, Mild', 200, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Wine - Chateau Aqueria Tavel', 171, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Soup - Campbells, Creamy', 11, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Prunes - Pitted', 18, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Energy Drink - Franks Pineapple', 157, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Lamb Rack - Ontario', 197, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Cheese - Blue', 30, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Cookie Dough - Double', 103, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Lid - 16 Oz And 32 Oz', 126, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Cheese - Mozzarella, Shredded', 193, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Cup Translucent 9 Oz', 71, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Beer - Steamwhistle', 19, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Beer - Heinekin', 124, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Pickles - Gherkins', 190, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Pepperoni Slices', 32, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Parsley Italian - Fresh', 196, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Mousse - Passion Fruit', 139, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Vector Energy Bar', 81, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Pork - Bacon Cooked Slcd', 94, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Chocolate - Semi Sweet, Calets', 108, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Appetizer - Spring Roll, Veg', 179, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Vinegar - White', 186, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Beans - Fava, Canned', 78, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Salt - Sea', 16, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Pasta - Cheese / Spinach Bauletti', 141, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Sauce - Thousand Island', 95, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Parsley - Dried', 51, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Tomato - Plum With Basil', 62, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Bread Crumbs - Japanese Style', 21, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Chocolate - Compound Coating', 174, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Lobster - Canned Premium', 52, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Bread Cranberry Foccacia', 161, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Arizona - Green Tea', 14, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Crush - Grape, 355 Ml', 97, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Cheese - Shred Cheddar / Mozza', 152, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Ezy Change Mophandle', 117, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Kale - Red', 111, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Foam Tray S2', 121, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Table Cloth 90x90 Colour', 132, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Sauce - Soya, Dark', 117, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Bay Leaf', 117, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Beer - Blue Light', 126, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Bread - Assorted Rolls', 165, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Tilapia - Fillets', 38, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Sugar - Monocystal / Rock', 74, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Bread - Crusty Italian Poly', 44, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Carbonated Water - Lemon Lime', 130, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Fish - Artic Char, Cold Smoked', 21, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Chicken - Breast, 5 - 7 Oz', 95, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Appetizer - Seafood Assortment', 92, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Strawberries', 158, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Macaroons - Two Bite Choc', 127, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Cheese - Shred Cheddar / Mozza', 11, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Muffin Mix - Oatmeal', 114, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Mushroom - Oyster, Fresh', 165, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Soup - Beef Conomme, Dry', 32, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Bar Special K', 171, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Sauce - Demi Glace', 198, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Lamb - Rack', 37, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Mushroom - Trumpet, Dry', 24, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Pastry - Banana Muffin - Mini', 22, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Bagel - 12 Grain Preslice', 16, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Soup - Campbells Beef Strogonoff', 119, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Dates', 92, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Pecan Raisin - Tarts', 133, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Wine - Blue Nun Qualitatswein', 40, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Nut - Chestnuts, Whole', 143, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Soda Water - Club Soda, 355 Ml', 47, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Basil - Dry, Rubbed', 128, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Pork - Bacon, Double Smoked', 57, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Beer - Corona', 170, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Beef - Salted', 152, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Bar Mix - Lemon', 117, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Gooseberry', 177, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Thyme - Lemon, Fresh', 49, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Sea Bass - Whole', 71, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Halibut - Steaks', 25, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Cranberry Foccacia', 13, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Pernod', 190, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Gelatine Leaves - Bulk', 145, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Southern Comfort', 56, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Apple - Fuji', 48, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Wine - Pinot Grigio Collavini', 164, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Greens Mustard', 147, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Sprouts - Peppercress', 68, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Ice Cream - Strawberry', 176, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Steampan - Half Size Shallow', 134, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Soup - Campbells, Beef Barley', 68, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Juice - Ocean Spray Cranberry', 181, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Tofu - Soft', 58, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Sausage - Meat', 163, 2);
insert into Product (ProName, ProPrice, ProCateId) values ('Pepper - Black, Ground', 177, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Orange Roughy 4/6 Oz', 136, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Cookie Trail Mix', 110, 3);
insert into Product (ProName, ProPrice, ProCateId) values ('Nut - Pistachio, Shelled', 49, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Beer - Moosehead', 63, 1);
insert into Product (ProName, ProPrice, ProCateId) values ('Everfresh Products', 165, 4);
insert into Product (ProName, ProPrice, ProCateId) values ('Garlic Powder', 56, 1);
