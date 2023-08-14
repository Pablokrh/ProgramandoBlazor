using Humanizer;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;
using University_API.Controllers;
using University_API.DataAccess;
using University_API.Models;

namespace University_API.Services
{
    public class Services
    {
        private readonly UniversityContext _context;

        public Services(UniversityContext context)
        {
            _context = context;
        }


        public IEnumerable<Student> GetUsersWithCurses()
        {
            var listaUsuarios = from st in _context.Students where st.Courses.Count>0 select st;
            return listaUsuarios;    
        }


        public IEnumerable<Course> GetCourseWithStudents(string nivel)
        {
            Course c = new Course();
            string nivell = Level.Advanced.ToString();

            List<Course> cursoConEstudiante = (from cc in _context.Courses where cc.Students.Count > 0 select cc).ToList();

            List<Course> cursoNivel = new List<Course>();

            foreach (var item in cursoConEstudiante)
            {
                if (item.Level.ToString() == nivel)
                {
                    cursoNivel.Add(item);
                }

            }
            List<string> courses = new List<string>();
            
            if (cursoNivel.Count == 0)
            {
                courses.Add("es todo una gran poronga!!... El nivel sería: "+ nivel);
            }
            else
            {
                foreach (var item in cursoNivel)
                {
                    courses.Add("Descripción del curso: " + item.ShortDescription.ToString());

                }
            }
            
            

                              
            

                                               /*
                                               
                                               cc.Level.Find(Convert.ToString(Level.)==nivel));

                                               ; Level.ToString() == nivel select cc).ToList();*/
            return cursoNivel;
            // &&
        }

        public IEnumerable<Course> GetCourseWithoutStudents()
        {
            List<Course> cursosSinEstudiantes = (from cc in _context.Courses where cc.Students.Count== 0 select cc).ToList();

            return cursosSinEstudiantes;
           
        }

        public User SearchUsersByEmail(string email)
        {
            string msg = "";
            User? userMail = (from us in _context.Users
                           where us.Email ==email
                           select us).FirstOrDefault();

            if (userMail != null) 
            {
                User usuario = userMail;
            }
            
            else
            {              
                msg = "Usuario no encontrado";
            }
                      

               return userMail;
        }

        public IEnumerable<User> GetUsers()
        {            
            return _context.Users;
        }

       
        public User GetUser(int id)
        {
            User? user = _context.Users.Find(id);
            //(from u in _context.Users where u.Id == id select u).FirstOrDefault();
            return user;
        }
    }
    
}
