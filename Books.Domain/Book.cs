namespace Books.Domain;
//inherit from the base entity
public class Book:BaseEntity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    
}