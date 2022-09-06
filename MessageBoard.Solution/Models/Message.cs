using System;
using System.Globalization;

namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public string Description { get; set; }
    private DateTime _joined = DateTime.Now;

    public DateTime Date { get { return _joined;} set {_joined = value;}}

    public int CategoryId { get; set; }
  }
}