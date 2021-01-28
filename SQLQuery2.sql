--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'

Select * from Products where CategoryID=1 or categoryId = 3

Select * from Products where CategoryID=1 and unitprice >=10

select * from Products where CategoryID=1 order by UnitPrice desc

select count (*) Adet from Products 

select CategoryID, count (*) from products where UnitPrice>20 group by CategoryID having count(*)<10

