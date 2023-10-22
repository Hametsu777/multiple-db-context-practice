namespace MultipleDbContextPractice.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        // Need to remove this so another Character table doesn't get created when adding migration. Table would get created
        // Since there is a relationship established between User and Character from the code or line below.
        //public List<Character> Characters { get; set; } = new List<Character>();
    }
}
