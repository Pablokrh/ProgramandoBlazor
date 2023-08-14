using Web_DesesperanzaAPI.Models;
using System.Text;
using LinqSnippets;
using Microsoft.EntityFrameworkCore.Storage;



/*
ConsultasLinq consultasLinq = new ConsultasLinq();
consultasLinq.Consultas();
*/

Snippets Snippets=new Snippets();
Snippets.SkipTakeLinq();

//Snippets.GetPage();
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
/*
Snippets.LinqVariables(numbers);
Snippets.ZipDeLinq();
Snippets.RangeAndRepeat();


Snippets.StudentLinq();
Snippets.AggregateQueries();
Snippets.GroupBy();

*/

List<Post> posts = new List<Post>()
{
    new Post()
    {
        Id = 1,
        Title="My first Post",
        Content="Hello Friends, I'm fan of Lanus",
        Created=DateTime.Now,
        Comments=new List<Comment>()
        {
            new Comment()
            {
                Id=1,
                Created=DateTime.Now,
                Title="Mi primer comentario",
                Content="La culpa no es del que da de comer, si no del chancho que quisimos ser",
            },
             new Comment()
            {
                Id=2,
                Created=DateTime.Now,
                Title="Mi Segundo comentario",
                Content="Cómo será la laguna, que el chancho la cruza al trote",
            }

        }
    },
     new Post()
    {
        Id = 2,
        Title="My first Post",
        Content="Hello Friends, I'm fan of Lanus",
        Created=DateTime.Now,
        Comments=new List<Comment>()
        {
            new Comment()
            {
                Id=3,
                Created=DateTime.Now,
                Title="Un tercer comentario",
                Content="El que se quema con queso ve un caballo y llora",
            },
             new Comment()
            {
                Id=4,
                Created=DateTime.Now,
                Title="Un cuarto comentario",
                Content="El que se quema con lecha ve una vaca y llora",
            }
        }
    }


};

var comentariosConContenido = posts.SelectMany(
    post => post.Comments, (post, comment) => new { PostId = post.Id, commentContent = comment.Content });

foreach (var item in comentariosConContenido)
{
    Console.WriteLine(item.commentContent);
}



/*
 * 
 * Esto es lo que aún no funca
public class ConsultasLinq
{
    Category categoria=new Category();
    Chapter chapter=new Chapter();
    Course course=new Course();
    Student student=new Student();
    User user=new User();
    
    
    public void Consultas()
    {
        Console.WriteLine(  "Hola Mundo!");
    }

}
*/