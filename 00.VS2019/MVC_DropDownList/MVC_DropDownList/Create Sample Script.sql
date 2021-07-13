create table [dbo].[category] (
categoryId int,
categoryName  [nvarchar](30) NULL
)
 
insert into [category](categoryId,categoryName)values(1,'Mobiles');
insert into [category](categoryId,categoryName)values(2,'TVs');
insert into [category](categoryId,categoryName)values(3,'Laptops');
 
create Table [dbo].[subcategories](
subcatId int,
Fk_CatId int,
Subcategoryname  [nvarchar](30) NULL
)
 
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(1,1,'Iphone');
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(2,1,'Redmi');
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(3,1,'samsung');
 
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(4,2,'LG Tvs');
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(5,2,'Sony Bravia Full HD');
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(6,2,'TCL P6 Ultra HD LED');
 
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(7,3,'HP');
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(8,3,'Dell');
insert into [subcategories](subcatId,Fk_CatId,Subcategoryname)values(9,3,'iBall ');