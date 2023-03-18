select p.Name, c.Name from Products p 
left join RelProductsCategories rel on rel.ProductId = p.Id 
left join Categories c on rel.CategoryId = c.Id 