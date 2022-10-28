# CategoryProductDB
Contain DB with Products and Categories. Product can correspond to many categories, one category can have many products.

Contain 3 table Products, Categories, CategoryProduct (сontains category and product relations).
### SQL query
```
SELECT 
Products.Name as ProductName, 
Categories.Name as CategoryName
FROM Products
LEFT JOIN CategoryProduct
  ON Products.id = CategoryProduct.ProductsId
LEFT JOIN Categories
  ON Categories.Id = CategoryProduct.CategoriesId
ORDER BY ProductName
```
### Products table
![alt text](https://github.com/artmklgnv/CategoryProductDB/raw/master/ConsoleApp2/Images/Products.jpg)
### Categories table
![alt text](https://github.com/artmklgnv/CategoryProductDB/raw/master/ConsoleApp2/Images/Categories.jpg)
### CategoryProduct table
![alt text](https://github.com/artmklgnv/CategoryProductDB/raw/master/ConsoleApp2/Images/CategoryProduct.jpg)
### SQL query result table
![alt text](https://github.com/artmklgnv/CategoryProductDB/raw/master/ConsoleApp2/Images/ResultTable.jpg)
