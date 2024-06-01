
using StorageManagement;

Storage storage = new Storage();

Electronic phone = new Electronic("Phone", 3999.99, 12 );
Electronic computer = new Electronic("Computer", 12999.99, 24);

Food bread = new Food("Bread", 2.99, 040624);
Food cheese = new Food("Cheese", 8.99, 270624);

Clothing shirt = new Clothing("Shirt", 25.79, "XL");
Clothing jeans = new Clothing("Jeans", 45.89, "XL");

storage.AddProduct(phone);
storage.AddProduct(computer);
storage.AddProduct(bread);
storage.AddProduct(cheese);
storage.AddProduct(shirt);
storage.AddProduct(jeans);

storage.RemoveProduct(phone);

storage.PrintProducts();
