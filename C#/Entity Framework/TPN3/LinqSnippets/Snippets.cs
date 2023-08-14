using System;
using System.Linq;
using System.Collections;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Net.Security;

namespace LinqSnippets
{
    public class Snippets
    {
        static public void BasicLinq()
        {
            string[] cars =
            {
                "VW Golf",
                "VW California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat León"
            };

            //Select * from cars
            var carList = from car in cars select car;
            //Selecciona todos los autos del array cars.

            //Select where
            var audiList = from car in cars where cars.Contains("Audi") select car;



        }
        
        static public void Numbers()
        
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var processedNumberList = numbers
                .Select(num => num * 3)
                .Where(num=>num!=9)
                .OrderBy(num=>num);

            //Multiplica todo por 3, luego, deja por fuera al número que sea 9 y luego lo ordena ascendentemente.

        }      

        static public void SearchExamples()
        {
            List<string> textList = new List<string>() { "a", "bx", "c", "e", "cj", "f", "c" };

            var first=textList.First();

            var cText=textList.First(text=>text.Equals("c"));
            //Acá se guarda la primera vez que un texto sea (no que contenga) la c.
            var firstElement = textList.First(text=>text.Contains("j"));

            var firstElement2 =textList.Contains("j"); //Funca esta?

            string? firstOrDefaultText = textList.FirstOrDefault(text => text.Contains("z"));
            //Devuelve una Z o una cadena de texto vacía.

            var lastOrDefaultText = textList.LastOrDefault(text => text.Contains("z"));

            var uniqueElements = textList.SingleOrDefault();
            //En caso de haber elementos repetidos en la lista, tomaría uno solo de ellos. Es casi igual que el .Single();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] oddEvenNumbers = { 0,2,6 };

            //obtener números que no se repiten en ninguna de las listas:
            var myEvenNumbers = evenNumbers.Except(oddEvenNumbers);
        }

        static public void MultipleSelects()
        {
            string[] MyOpinion =
            {
                "Opinión 1, text 1",
                "Opinión 2, text 2",
                "Opinión 3, text 3",
            };

            var myOpinionSelection = MyOpinion.SelectMany(opinion => opinion.Split(","));
            //Guarda los valores, separados, por la coma, habrían 6 entonces valores, y no tres.

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id = 1,
                    Name = "Enterprise One",
                    Employees = new[]
                    {
                        new Employee()
                        {
                            Id = 1,
                            Name = "Carlos Sluzky",
                            Email = "Charly@gmail.com",
                            Salary = 3600,

                        },
                        new Employee()
                        {
                            Id = 2,
                            Name = "Francisco Varela",
                            Email = "PanchitoChileno@argentina.com.ar",
                            Salary = 1600,

                        },
                        new Employee()
                        {
                            Id = 3,
                            Name = "Osvaldo Laport",
                            Email = "TroncazoDeMalo@hotmail.com",
                            Salary = 2200,

                        }
                    }
                },
                new Enterprise()
                {
                    Id = 2,
                    Name = "Enterprise Twelve",
                    Employees = new[]
                    {
                        new Employee()
                        {
                            Id = 4,
                            Name = "Marcos Olazábal ",
                            Email = "Ola@demar.com",
                            Salary = 658,

                        },
                        new Employee()
                        {
                            Id = 5,
                            Name = "Valentino Moroder",
                            Email = "Tino@Atolonico.com",
                            Salary = 1000,

                        },
                        new Employee()
                        {
                            Id = 6,
                            Name = "Pablo Krojzl",
                            Email = "pablokrh@hotmail.com",
                            Salary = 360,

                        }
                    }
                }
            };

            //Obtener todos los empleados de todas las empresas:
            var employeeList = enterprises.SelectMany(enterprise => enterprise.Employees);

            //Ver si una lista está vacía
            var hasEnterprises=enterprises.Any();

            //Ver si una lista tiene empleados. Si una lista de empresas, no si una empresa tiene empleados.
            var hasEmployees=enterprises.Any(enter=>enter.Employees.Any());

            //Que tengan empleados de mas de 900 euros

            bool hasEmployeeWithSalaryMoreOrEqualThan900 = enterprises.Any(enterprise =>
            enterprise.Employees.Any(employee => employee.Salary >= 900));
        }

        public static void linqCollections()
        {
            var firstList = new List<string> { "a", "b", "c" };
            var secondList = new List<string> { "a", "c", "d" };

            //inner join. BUsca los elementos compartidos por las 2 listas.
            var commonResult = from element in firstList
                               join secondElement in secondList 
                               on element equals secondElement
                               select new { element, secondElement };

            var commonResult2 = firstList.Join(
                secondList, element => element, secondElement => secondElement,
                (element, secondElement) => new { element, secondElement });
            //2 formas distintas

            //Outer joint -LEFT:

            var leftOuterJoin = from element in firstList
                                join secondElement in secondList
                                on element equals secondElement
                                into temporalList
                                from temporalElement in temporalList.DefaultIfEmpty()
                                where element != temporalElement
                                select new { Element = element };
            //Hasta el into, busca los elementos comunes en ambas listas, y las guarda en una lista temporal. 
            //Luego quiere obtener los elementos de la lista 1 que no están en la lista temporal (de los elementos comunes)
            //Left significa que es lo de la izquierda, es decir, de la lista 1.

            //Forma "Simplificada"
            var leftOuterJoin2 = from element in firstList
                                 from secondElement in secondList.Where(s => s == element).DefaultIfEmpty()
                                 select new { Element = element, SecondElement = secondElement };



            //Outer joint -Right:

            var RightOuterJoin = from secondElement in secondList
                                join element in firstList
                                on secondElement equals element
                                into temporalList
                                from temporalElement in temporalList.DefaultIfEmpty()
                                where secondElement != temporalElement
                                select new { Element = secondElement };

            //Unión!! Sin los elementos repetidos.

            var unionList = leftOuterJoin.Union(RightOuterJoin);


        }

        static public void SkipTakeLinq()
        {
            var myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(  "Lista completa");
            myList.ForEach(num=>Console.Write(num + " ") );
            Console.WriteLine("\n---------------------------\n");
            var skipOneAndTwo=myList.Skip(2);
            //Devuelve la lista sin los primeros 2 índices.

            Console.WriteLine("Lista sin primer ni segundo valor");
            foreach (var item in skipOneAndTwo)
            {
                Console.Write( item + " ");
            }

           // Console.WriteLine( skipOneAndTwo);
            Console.WriteLine("\n---------------------------\n");


            var skipLastTwo=myList.SkipLast(2);
            //Ignora los últimos 2.



            //Devuelve la lista cuyos número no sean menores que 4
            Console.WriteLine("Lista cuyos números no son menores que 4");
            var skipWhile = myList.SkipWhile(num => num < 4);
            foreach (var item in skipWhile)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n---------------------------\n");


            var take =myList.Take(2);
            //Toma solamente los primeros 2 valores

        }


        //Paginación llama a esto => Paging con skip y take
        //int pageNumber dice, por ejemplo, "dame la página 2" e int resultsPerPage dice "dame de 10 en 10"

        static public IEnumerable<T> GetPage<T>(IEnumerable<T>Collection, int pageNumber, int resultsPerPage)
        {
            int startIndex=(pageNumber-1)*resultsPerPage;

            return Collection.Skip(startIndex).Take(resultsPerPage);


        }
            
        static public void LinqVariables(IEnumerable<int> numbers)
        {
            //Let crea una variable local

            var elementAlCuadradoMayorAMedia = from number in numbers
                                               let average = numbers.Average()
                                               let nSquared = Math.Pow(number, 2)
                                               where nSquared > average
                                               select number;
            //crea 2 variables locales, la primera es la media de todos los números
            //La segunda, eleva a cada número al cuadrado.
            //Luego compara cada número al cuadradoncon la media y retorna dichos números.
            Console.WriteLine("Printeo de elementos de lista cuyo valor si se los eleva al cuadrado es mayor al promedio de sus valores originales:");
            foreach (var item in elementAlCuadradoMayorAMedia)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine("\n--------------------------\n");

            Console.WriteLine("Promedio:" + numbers.Average()+"\n");

            Console.WriteLine("No hace falta descripción");
            foreach (var item in elementAlCuadradoMayorAMedia)
            {
                Console.WriteLine(  "Number: {0} Square: {1}", item, Math.Pow(item,2));

            }
            Console.WriteLine("\n--------------------------\n");

        }

        static public void ZipDeLinq()
        {
            //Intercala elementos.
            int[] numeros = { 1, 2, 3, 4, 5,6 };
            //Hay un valor mas en esta primera lista que en la segunda, por eso lo ignora.

            string[] stringNumeros = { "uno", "dos", "tres", "cuatro", "cinco"};

            IEnumerable<string> zipNumeros = numeros.Zip(stringNumeros, (number, word) => number + "= " + word);

            foreach (var item in zipNumeros)
            {
                Console.WriteLine(item);   

            }
        }

        static public void RangeAndRepeat()
        {
            //Generar colección de 1 al 100

            var first100=Enumerable.Range(1, 100);

            Console.WriteLine("\n-------------------------------------------------");
            foreach (var item in first100)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine("\n-------------------------------------------------\n");

            //Repetir un valor N veces


            IEnumerable <string>CincoXsPrimeraForma = Enumerable.Repeat("X", 5);
            IEnumerable CincoXsSegundaForma = Enumerable.Repeat("X", 5);
            var CincoXsTerceraForma = Enumerable.Repeat("X", 5);

            foreach (var item in CincoXsPrimeraForma)
            {
                Console.Write(item+"/");
            }

        }
        static public void StudentLinq()
        {
            var ClassRoom = new[]
            {
                new Student
                {
                    Id=1,
                    Name="Martín",
                    Grade=57,
                    Certified=true,
                },

                new Student
                {
                    Id=2,
                    Name="Pablo",
                    Grade=89,
                    Certified=true,
                },
                new Student
                {
                    Id=3,
                    Name="Carlos",
                    Grade=24,
                    Certified=false,
                },
                new Student
                {
                    Id=4,
                    Name="Ana",
                    Grade=95,
                    Certified=true,
                },
                new Student
                {
                    Id=5,
                    Name="Álvaro",
                    Grade=73,
                    Certified=false,
                },
                new Student
                {
                    Id=6,
                    Name="Jazmín",
                    Grade=51,
                    Certified=false,
                }


            };
            var certifiedStudents = from estudiantina in ClassRoom
                                    where estudiantina.Certified
                                    select estudiantina;

            var notCertifiedStudents= from estudiantina in ClassRoom
                                      where estudiantina.Certified==false
                                      select estudiantina;

            Console.WriteLine("Estudiantes aprobados:");
            foreach (Student student in certifiedStudents)
            {
                Console.WriteLine("Estudiante {0} obtuvo {1}", student.Name, student.Grade);
            }
            Console.WriteLine("\n-----------------------------------------------\nEstudiantes no aprobados");

            foreach (Student student in notCertifiedStudents)
            {
                Console.WriteLine("Estudiante {0} obtuvo {1}", student.Name, student.Grade);
            }

            var aprobadoYCertificado = from est in ClassRoom
                                       where est.Certified == true && est.Grade >= 65
                                       select est; //est.Grade o est.Name podría hacerse

            Console.WriteLine("\nAprobados y certificados:\n");
            foreach (var item in aprobadoYCertificado)
            {
                Console.WriteLine(item.Name+ ". Nota: "+ item.Grade + ". Certificado: "+ item.Certified);
            }


        }

        static public void All()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            bool areSmallerThan10 = numbers.All(x => x < 10); //devuelve true, ya que son todos menores que 10
            bool areLargerThan3 = numbers.All(x => x > 3); //devuelve false, ya que no son todos mayores que 3

            var emptyList = new List<int> { };
            bool allNumbersAreGreaterThan0 = numbers.All(x => x < 0); //Sería true, pese a estar vacía.



        }

        static public void AggregateQueries()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //Le suma a un número la suma previa y así... Devuelve solo el número final..
            int sum = numbers.Aggregate((sumaPrevia, actual) => sumaPrevia + actual);

            string[] words = { "hello", ", ", "my", "name", "is", "Pablo" };          
            string greeting = words.Aggregate((prevGreeting, current) => prevGreeting + current);
            Console.WriteLine(greeting);


        }

        static public void DistinctValues()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            var numbersSinRepeat = numbers.Distinct();
            //Retorna lista sin valores repetidos.

        }

        static public void GroupBy()
        {
            //Group by, arma Ienumerables distintos
            List<int> numerazzione = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numeros = numerazzione.GroupBy(x => x % 2 == 0);
            // var numImpares = numerazzione.GroupBy(x => x % 2 != 0);

            //Te devuelve 2 grupos, 2 IEnumerable.
            //Imprime primero los que no cumplen el requisito y luego los que si
            foreach (var group in numeros)
            {
                foreach (var valor in group)
                {
                    Console.Write(valor+", ");
                }
                Console.WriteLine("\n---------------------\n");

            }

            var ClassRoom = new[]
            {
                new Student
                {
                    Id=1,
                    Name="Martín",
                    Grade=57,
                    Certified=true,
                },

                new Student
                {
                    Id=2,
                    Name="Pablo",
                    Grade=89,
                    Certified=true,
                },
                new Student
                {
                    Id=3,
                    Name="Carlos",
                    Grade=24,
                    Certified=false,
                },
                new Student
                {
                    Id=4,
                    Name="Ana",
                    Grade=95,
                    Certified=true,
                },
                new Student
                {
                    Id=5,
                    Name="Álvaro",
                    Grade=73,
                    Certified=false,
                },
                new Student
                {
                    Id=6,
                    Name="Jazmín",
                    Grade=51,
                    Certified=false,
                }


            };
            var certifiedQuery = ClassRoom.GroupBy(estud => estud.Certified && estud.Grade >= 50);

            foreach (var item in certifiedQuery)
            {
                Console.WriteLine("********** {0} ************", item.Key);

                foreach (var student in item) 
                {
                    Console.WriteLine(student.Name + ". Está certificado: "+student.Certified+ ". Nota: "+student.Grade);
                }

            }


        }


    }
}