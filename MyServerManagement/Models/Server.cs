using System.ComponentModel.DataAnnotations;

namespace MyServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }

        public int ServerId { get; set; }
        public bool IsOnline { get; set; }

        [Required] //https://learn.microsoft.com/en-gb/dotnet/api/system.componentmodel.dataannotations?view=net-8.0
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }
    }
}
