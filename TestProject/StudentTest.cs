using Microsoft.EntityFrameworkCore;
using StudentControl.Domain.Model;
using StudentControl.Infastructure;
using StudentControl.Infrastructure.Repository;

namespace TestProject
{
    public class StudentTest
    {
        private readonly Context context;

        public StudentRepository StudentRepository { get { return new StudentRepository(context); } }

        public StudentTest()
        {
            var ContextOptions = new DbContextOptionsBuilder<Context>()
                .UseMySql(@"server=localhost;user=App;password=1234567890!;database=TestDB", new MySqlServerVersion(new Version(8, 0, 30)))
                .Options;

            context = new Context(ContextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var student1 = new Student
            {
                Name = "Name1", 
                Surname = "Surname1", 
                Status = Status.Studying, 
                Graduate = 1
            };
            var student2 = new Student
            {
                Name = "Name3",
                Surname = "Surname1",
                Status = Status.Studying,
                Graduate = 1
            };
            var Order = new Order { Number = "1", Name = Name.Priem, Date = new DateTime() };
            student1.Orders.Add(Order);
            student2.Orders.Add(Order);
            student1.Orders.Add(new Order { Number = "21", Name = Name.Group_formation, Date = new DateTime() });
            student2.Orders.Add(new Order { Number = "22", Name = Name.Group_formation, Date = new DateTime() });

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.SaveChanges();
            context.ChangeTracker.Clear();
        }

        [Fact]
        public void Create_DB()
        {
            var StudentTest = new StudentTest();
            var Repository = StudentTest.StudentRepository;

            Assert.Equal(1, 1);
        }

        [Fact]
        public void Add_in_DB()
        {
            var StudentTest = new StudentTest();
            var Repository = StudentTest.StudentRepository;

            var student2 = new Student
            {
                Name = "Name2",
                Surname = "Surname2",
                Status = Status.Studying,
                Graduate = 1,
            };

            Repository.AddAsync(student2).Wait();
            Repository.ChangeTrackerClear();

            Assert.True(Repository.GetAllAsync().Result.Count == 3);
            Assert.Equal("Name1", Repository.GetByNameAsync("Name1").Result.Name);
            Assert.Equal("Name2", Repository.GetByNameAsync("Name2").Result.Name);
            Assert.Equal("Name3", Repository.GetByNameAsync("Name3").Result.Name);
            Assert.Equal(2, Repository.GetByNameAsync("Name1").Result.Orders.Count);

        }

        [Fact]
        public void Update_in_DB()
        {
            var StudentTest = new StudentTest();
            var Repository = StudentTest.StudentRepository;
            var ExistingStudent = Repository.GetByNameAsync("Name1").Result;
            Repository.ChangeTrackerClear();

            ExistingStudent.Name = "ChangedName1";
            ExistingStudent.Orders.Add(new Order { Number = "3", Name = Name.Transfer, Date = new DateTime() });
            Repository.UpdateAsync(ExistingStudent).Wait();
            


            Assert.Equal("ChangedName1", Repository.GetByNameAsync("ChangedName1").Result.Name);
            Assert.Equal(3, Repository.GetByNameAsync("ChangedName1").Result.Orders.Count);
           
        }

        [Fact]
        public void DeleteUpdate_in_DB()
        {
            var StudentTest = new StudentTest();
            var Repository = StudentTest.StudentRepository;
            var Student = Repository.GetByNameAsync("Name1").Result;

            Repository.ChangeTrackerClear();

            Student.Orders.RemoveAt(0);
            Repository.UpdateAsync(Student).Wait();

            Assert.Equal(1, Repository.GetByNameAsync("Name1").Result.Orders.Count);
        }

    }
}