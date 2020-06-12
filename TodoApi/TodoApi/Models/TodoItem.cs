
namespace TodoApi.Models
{
    public class TodoItem
    {
        /* La propriété Id est la clé unique dans la BDD*/
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
