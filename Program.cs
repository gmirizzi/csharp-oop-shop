using csharp_oop_shop;

Prodotto newProduct = new Prodotto("Amaca", 32);
Console.WriteLine(newProduct.code);
Console.WriteLine(newProduct.getExtendedName());
newProduct.iva = 10;
Console.WriteLine(newProduct.getPriceWIva());

