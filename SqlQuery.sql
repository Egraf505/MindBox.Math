SELECT product.title, category.title
FROM product
LEFT JOIN product_category ON product.id = product_category.product_id
LEFT JOIN category ON category.id = product_category.category_id
ORDER BY product.title
