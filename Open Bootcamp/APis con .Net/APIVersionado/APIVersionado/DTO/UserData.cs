namespace APIVersionado.DTO
{
    public class User
    {
        public string? id { get; set; }

        public string? title { get; set; } //Mr o Mrs

        public string? firstName { get; set; }
        
        public string? lastName { get; set;}

        public string? picture { get; set; }

    }

    public class UsersResponseData
    {
        public User[]? data { get; set; }
        public int ? total { get; set; }
        public int? page { get; set; }
        public int limit { get; set; }
        //Hace falta un controlador para cada uno de estos.
    }
}
