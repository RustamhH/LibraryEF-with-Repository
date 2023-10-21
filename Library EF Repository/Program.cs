using Library_EF_Repository.Repositories;
using Library_EF_Repository.Contexts;
using Library_EF_Repository.Entitys;

namespace Library_EF_Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Repository<Author> repositoryAuthor = new();
            //repositoryAuthor.Add(new Author() { Id = 1, FirstName = "Rustem", LastName = "Hesenli" });
            //repositoryAuthor.Add(new Author() { Id = 2, FirstName = "Hesen", LastName = "Abdullazade" });


            Repository<Category> repositoryCategory = new();
            //repositoryCategory.Add(new Category() { Id = 1, Name = "Romance" });

            Repository<Department> repositoryDepartment = new();
            //repositoryDepartment.Add(new Department() { Id = 1, Name = "Science" });

            Repository<Press> repositoryPress = new();
            //repositoryPress.Add(new Press() { Id = 1, Name = "Qanun" });

            Repository<Theme> repositoryTheme = new();
            //repositoryTheme.Add(new Theme() { Id = 1, Name = "Theme1" });
            
            Repository<Book> repositoryBook = new();
            //repositoryBook.Add(new Book() { Id = 1, Name = "1984", Pages = 123, YearPress = 1984, Quantity = 1, Id_Category = 1, Id_Author = 1, Id_Press = 1, Id_Theme = 1 });





            Console.WriteLine("Authors");
            foreach (var item in repositoryAuthor.GetAll())
            {
                Console.WriteLine(item.Id+" "+item.FirstName+" "+item.LastName);
            }
            Console.WriteLine("Books");
            foreach (var item in repositoryBook.GetAll())
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Pages+" "+item.YearPress+" "+item.Quantity+" "+item.Id_Author+" "+item.Id_Category+" "+item.Id_Press+" "+item.Id_Theme);
            }
            Console.WriteLine("Category");
            foreach (var item in repositoryCategory.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("Department");
            foreach (var item in repositoryDepartment.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("Press");
            foreach (var item in repositoryPress.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("Theme");
            foreach (var item in repositoryTheme.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }


            //repositoryAuthor.Remove(repositoryAuthor.GetById(2));
            //Console.WriteLine("Authors after remove");
            //foreach (var item in repositoryAuthor.GetAll())
            //{
            //    Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            //}
        }
    }
}