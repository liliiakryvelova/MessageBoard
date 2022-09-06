namespace MessageBoard.Models
{
  public class SearchMessagesByCategory
  {
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public SearchMessagesByCategory(string categoryname, string message)
    {
      CategoryName = categoryname;
      Description = message;
    }
  }
}