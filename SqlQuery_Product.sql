SELECT name_product, name_category
FROM product LEFT JOIN  category
ON  product.product_id = category.category_id
ORDER BY name_product; 