namespace YourNamespace
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!; // Add the 'required' modifier to the 'UserName' property
        public int Age { get; set; }
    }
}