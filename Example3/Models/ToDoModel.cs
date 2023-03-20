using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example3.Models;

[Table("ToDoModel")]
public class ToDoModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Ok { get; set; }

}
 
