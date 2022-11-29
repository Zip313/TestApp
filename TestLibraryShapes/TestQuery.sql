
SELECT p.Name as pname,c.Name as cname 
from Products p
LEFT JOIN CategoryReferences cr
	ON cr.ProductId=p.ProductId
LEFT JOIN Category c
	ON c.CategoryId=cr.CategoryId