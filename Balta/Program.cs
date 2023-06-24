// See https://aka.ms/new-console-template for more information

using Balta.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();

var courseOOP = new Course("Fundamento OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamento C#", "fundamentos-csharp  ");
var courseAspNet = new Course("Fundamento ASP.NET", "fundamentos-asp-net");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem2 = new CareerItem(3, "Aprenda OOP", string.Empty, courseOOP);
var careerItem = new CareerItem(1, "Comece por aqui", string.Empty, courseCsharp);
var careerItem3 = new CareerItem(2, "Aprenda .NET", string.Empty, courseAspNet);
careerDotNet.Items.Add(careerItem3);
careerDotNet.Items.Add(careerItem);
careerDotNet.Items.Add(careerItem2);
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);

    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
    }
}