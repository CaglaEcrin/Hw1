using Hw1;
Books books1 = new Books()
{
    Id = 1,
    Name = "K�rk Mantolu Madonna",
    Author = "Sabahattin Ali",
    Publisher = "Yap� Kredi Yay�nlar�",
    PublishedDate = new DateTime(1943),


};

Books books2 = new Books()
{
    Id = 2,
    Name = "Tutunamayanlar",
    Author = "O�uz Atay",
    Publisher = "�leti�im Yay�nlar�",
    PublishedDate = new DateTime(1972),


};

Books books3 = new Books()
{
    Id = 3,
    Name = "Tehlikeli Oyunlar",
    Author = "O�uz Atay",
    Publisher = "�leti�im Yay�nlar�",
    PublishedDate = new DateTime(1973),


};

Books books4 = new Books()
{
    Id = 4,
    Name = "Sineklerin Tanr�s�",
    Author = "William Golding",
    Publisher = "T�rkiye �� Bankas� Yay�nlar�",
    PublishedDate = new DateTime(2006),


};

Books books5 = new Books()
{
    Id = 5,
    Name = "Dirili�",
    Author = "Lev Nikolayevi� Tolstoy",
    Publisher = "T�rkiye �� Bankas� Yay�nlar�",
    PublishedDate = new DateTime(2009),


};

Books books6 = new Books()
{
    Id = 6,
    Name = "�eker Portakal�",
    Author = "Jose Mauro De Vasconcelos",
    Publisher = "Can Yay�nlar�",
    PublishedDate = new DateTime(2000),


};

Books books7 = new Books()
{
    Id = 7,
    Name = "Delifi�ek",
    Author = "Jose Mauro De Vasconcelos",
    Publisher = "Can Yay�nlar�",
    PublishedDate = new DateTime(2013),


};


Books books8 = new Books()
{
    Id = 8,
    Name = "Ola�an�st� Bir Gece",
    Author = "Stefan Zweig",
    Publisher = "T�rkiye �� Bankas� Yay�nlar�",
    PublishedDate = new DateTime(2015),


};

Author author1 = new Author()
{
    Id = 1,
    Name = "Sabahattin",
    Surname = "Ali",
    Gender = "Erkek",
    Birthdate = new DateTime(1907, 02, 25),


};

Author author2 = new Author()
{
    Id = 2,
    Name = "O�uz",
    Surname = "Atay",
    Gender = "Erkek",
    Birthdate = new DateTime(1934, 10, 12),


};

Author author3 = new Author()
{
    Id = 3,
    Name = "William ",
    Surname = "Golding",
    Gender = "Erkek",
    Birthdate = new DateTime(1911, 09, 19),


};

BookDataContext db = new BookDataContext();
db.Books.Add(books1);
db.SaveChanges();

db.Books.Add(books2);
db.SaveChanges();

db.Books.Add(books3);
db.SaveChanges();

db.Books.Add(books4);
db.SaveChanges();

db.Books.Add(books5);
db.SaveChanges();

db.Books.Add(books6);
db.SaveChanges();

db.Books.Add(books7);
db.SaveChanges();

db.Books.Add(books8);
db.SaveChanges();

AuthorDataContext dbb = new AuthorDataContext();
dbb.Author.Add(author1);
dbb.SaveChanges();

dbb.Author.Add(author2);
dbb.SaveChanges();

dbb.Author.Add(author3);
dbb.SaveChanges();

//var Books = Booksdb.Books.Where(b =>b.Id == 5).FirstOrDefault();
//Console.WriteLine($" ID : {Books.Id}, Name: {Books.Name}");


//var Books = Booksdb.Books.Where(b=>b.Publisher=="T�rkiye �� Bankas� Yay�nlar�")FirstOrDefault();


//var Books = Booksdb.Books.Find(1);
//if (Books != null)
//{Booksdb.Books.Remove(Books);
//Booksdb.SaveChanges();
//}else
//{
//Console.WriteLine("No books!);
//}

