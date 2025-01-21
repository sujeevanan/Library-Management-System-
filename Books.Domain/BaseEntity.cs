namespace Books.Domain;
//other classes should inherit this class
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
}