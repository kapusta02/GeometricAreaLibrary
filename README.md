Используемые технологии: .net 7, c#, для тестирования - Xunit.

Реализовано:

Написание на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Доп задания:
- Юнит-тесты
- Легкость добавления других фигур
- Проверку на то, является ли треугольник прямоугольным

Задание 3.

```SQL
SELECT 
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;
```
