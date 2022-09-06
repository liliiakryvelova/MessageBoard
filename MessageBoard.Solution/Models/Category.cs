using System.Collections.Generic;

namespace MessageBoard.Models
{
    public class Category
    {
        public Category()
        {
            this.Messages = new HashSet<Message>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}