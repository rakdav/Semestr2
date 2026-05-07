using EFProject;

using (DbShopContext db=new DbShopContext())
{
    #region Create
    //Client client = new Client();
    //client.CityClient = "Москва";
    //client.Email = "Yuliy@mail.ru";
    //client.FirstName = "Юлий";
    //client.LastName = "Цезаревич";
    //client.SurName = "Саржинский";
    //client.Firma = "Одни копыта";
    //client.Phone = "+78009675643";
    //db.Clients.Add(client);
    //await db.SaveChangesAsync();

    //Product product=new Product();
    //product.NameProduct = "Овес";
    //product.CityProduct = "Цезарь сити";
    //product.Remainder = 30;
    //product.Sort = "Высший";
    //product.Type = "Для лошадей";
    //   db.Products.Add(product);
    //   await db.SaveChangesAsync();

    //Sdelka sdelka=new Sdelka();
    //sdelka.DateSale = DateTime.Now.ToString();
    //sdelka.Count = 4;
    //sdelka.IdClientNavigation = client;
    //sdelka.IdProductNavigation = product;
    //   db.Sdelkas.Add(sdelka);
    //   await db.SaveChangesAsync();
    //for (int i = 0; i < 5; i++)
    //{
    //    Client client = new Client();
    //    client.CityClient = Faker.Address.City();
    //    client.Email = Faker.Internet.Email();
    //    client.FirstName = Faker.Name.First();
    //    client.LastName = Faker.Name.Last();
    //    client.SurName = Faker.Name.Middle();
    //    client.Firma = Faker.Company.Name();
    //    client.Phone = Faker.Phone.Number();
    //    db.Clients.Add(client);
    //    await db.SaveChangesAsync();

    //    Product product = new Product();
    //    product.NameProduct = Faker.Name.First();
    //    product.CityProduct = Faker.Address.City();
    //    product.Remainder = Faker.RandomNumber.Next(1,200);
    //    product.Sort = Faker.Lorem.Sentence(5);
    //    product.Type = Faker.Lorem.Sentence(5);
    //    db.Products.Add(product);
    //    await db.SaveChangesAsync();

    //    Sdelka sdelka = new Sdelka();
    //    sdelka.DateSale = DateTime.Now.ToString();
    //    sdelka.Count = Faker.RandomNumber.Next(1, 10);
    //    sdelka.IdClientNavigation = client;
    //    sdelka.IdProductNavigation = product;
    //    db.Sdelkas.Add(sdelka);
    //    await db.SaveChangesAsync();
    //}
    #endregion

    //#region Read
    //List<Product> productList=db.Products.ToList();
    //foreach (Product product in productList)
    //{
    //    Console.WriteLine(product);
    //}
    //#endregion

    #region Update
    //Client client = db.Clients.FirstOrDefault(p=>p.IdClient==4)!;
    //client.SurName = "Суслик";
    //await db.SaveChangesAsync();
    #endregion

    #region Delete
    Client client = db.Clients.FirstOrDefault(p => p.IdClient == 4)!;
    db.Clients.Remove(client);
    await db.SaveChangesAsync();
    #endregion
}
