
using System.Collections.Generic;

public class Make{
    public int Id{ get; set; }
    public string Name{ get; set; }
    public IList<Model> Models { get; set; }
}