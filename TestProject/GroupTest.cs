using Microsoft.EntityFrameworkCore;
using StudentControl.Domain.Model;
using StudentControl.Infastructure;
using StudentControl.Infrastructure.Repository;

namespace TestProject
{
    public class GroupTest
    {
        private readonly Context context;

        public GroupRepository GroupRepository { get { return new GroupRepository(context); } }

        public GroupTest()
        {
            var ContextOptions = new DbContextOptionsBuilder<Context>()
                .UseMySql(@"server=localhost;user=App;password=1234567890!;database=TestDB", new MySqlServerVersion(new Version(8, 0, 30)))
                .Options;

            context = new Context(ContextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var Group1 = new Group {Name = "IST-021", NumberOfPeople = 1, Formofstudy = Formofstudy.Full_time, StudyProfile = "IDK1"};
            var Group2 = new Group {Name = "IST-012", NumberOfPeople = 1, Formofstudy = Formofstudy.Full_time, StudyProfile = "IDK2"};


            var student1 = new Student
            {
                Name = "Name1",
                Surname = "Surname1",
                Status = Status.Studying,
                Graduate = 1
            };
            var student2 = new Student
            {
                Name = "Name2",
                Surname = "Surname2",
                Status = Status.Studying,
                Graduate = 2
            };
            var student3 = new Student
            {
                Name = "Name3",
                Surname = "Surname3",
                Status = Status.Studying,
                Graduate = 1
            };
            var student4 = new Student
            {
                Name = "Name4",
                Surname = "Surname4",
                Status = Status.Studying,
                Graduate = 2
            };

            Group1.Students.Add(student1);
            Group1.Students.Add(student3);
            Group2.Students.Add(student2);
            Group2.Students.Add(student4);
            var Order = new Order { Number = "1", Name = Name.Priem, Date = new DateTime() };
            student1.Orders.Add(Order);
            student2.Orders.Add(Order);
            student1.Orders.Add(new Order { Number = "21", Name = Name.Group_formation, Date = new DateTime() });
            student2.Orders.Add(new Order { Number = "22", Name = Name.Group_formation, Date = new DateTime() });

            context.Groups.Add(Group1);
            context.Groups.Add(Group2);

            context.SaveChanges();
            context.ChangeTracker.Clear();
        }

        [Fact]
        public void Create_DB()
        {
            var StudentTest = new GroupTest();
            var Repository = StudentTest.GroupRepository;

            Assert.Equal(1, 1);
        }

        [Fact]
        public void Add_in_DB()
        {
            var GroupTest = new GroupTest();
            var Repository = GroupTest.GroupRepository;

            var Group = new Group()
            {
                Name = "IST-032",
                NumberOfPeople = 1,
                StudyProfile = "IDK3"
            };

            Group.Students.Add(new Student { Name = "NameTemp", Surname = "SurNameTemp" });

            Repository.AddAsync(Group).Wait();
            Repository.ChangeTrackerClear();

            Assert.True(Repository.GetAllAsync().Result.Count == 3);
            Assert.Equal("IST-021", Repository.GetByNameAsync("IST-021").Result.Name);
            Assert.Equal("IST-012", Repository.GetByNameAsync("IST-012").Result.Name);
            Assert.Equal("IST-032", Repository.GetByNameAsync("IST-032").Result.Name);
            Assert.Equal(1, Repository.GetByNameAsync("IST-032").Result.Students.Count);

        }

        [Fact]
        public void Update_in_DB()
        {
            var GroupTest = new GroupTest();
            var Repository = GroupTest.GroupRepository;
            var ExistingGroup = Repository.GetByNameAsync("IST-021").Result;
            Repository.ChangeTrackerClear();

            ExistingGroup.Name = "Changed";
            ExistingGroup.Students.Add(new Student { Name = "NewStudent", Surname = "Classified"});
            Repository.UpdateAsync(ExistingGroup).Wait();



            Assert.Equal("Changed", Repository.GetByNameAsync("Changed").Result.Name);
            Assert.Equal(3, Repository.GetByNameAsync("Changed").Result.Students.Count);

        }

        [Fact]
        public void DeleteUpdate_in_DB()
        {
            var GroupTest = new GroupTest();
            var Repository = GroupTest.GroupRepository;
            var Group = Repository.GetByNameAsync("IST-021").Result;

            Repository.ChangeTrackerClear();

            Group.Students.RemoveAt(0);
            Repository.UpdateAsync(Group).Wait();

            Assert.Equal(1, Repository.GetByNameAsync("IST-021").Result.Students.Count);
        }
    }
}
