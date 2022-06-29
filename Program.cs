using csharp_oop_shop;

for (int i = 0; i < 5; i++)
{
    Prodotto newProduct = new Prodotto("Amaca", 32);
    Console.WriteLine(newProduct.code);
    Console.WriteLine(newProduct.getExtendedName());
    newProduct.iva = 10;
    Console.WriteLine(newProduct.getPriceWIva());
    Console.WriteLine(newProduct.formattedCode());
    Console.WriteLine();
}

