using SimpleCrud.Services.Objects;
using SimpleCrud.Services.ServiceModels;

namespace SimpleCrud.WebApp.Models
{
    public class StudentViewModel
    {
        public IEnumerable<StudentObj> Students { get; set; } = new List<StudentObj>();

    }
}
