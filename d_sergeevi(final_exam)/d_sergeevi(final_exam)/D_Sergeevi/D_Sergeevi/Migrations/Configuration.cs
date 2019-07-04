namespace D_Sergeevi.Migrations
{
    using D_Sergeevi.Modals;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<D_Sergeevi.Context.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(D_Sergeevi.Context.MyDbContext context)
        {
            Random rnd = new Random();

            context.Students.AddOrUpdate(x => x.Id,
                    new Student("John Doe"),
                    new Student("Charles Dickens"),
                    new Student("Miguel de Cervantes"),
                    new Student("James Hetfield"),
                    new Student("Dimebag Darrel")
                    );
            
            context.Subjects.AddOrUpdate(x => x.Id,
                new Subject("Algorithmes"),
                new Subject("Calculus"),
                new Subject("English"),
                new Subject("Software Security"),
                new Subject("Music")
             );

            context.GradesSet.AddOrUpdate(x => x.Id,
                new Grades(new Student(1, "John Doe"), new Subject(1, "Algorithmes"), rnd.Next(0, 6)),
                new Grades(new Student(2, "Charles Dickens"), new Subject(2, "Calculus"), rnd.Next(0, 6)),
                new Grades(new Student(3,"Miguel de Cervantes"), new Subject(3, "English"), rnd.Next(0, 6)),
                new Grades(new Student(4, "James Hetfield"), new Subject(4, "Music"), rnd.Next(0, 6)),
                new Grades(new Student(5, "Dimebag Darrel"), new Subject(4, "Music"), rnd.Next(0, 6))
              );         
        }
    }
}
