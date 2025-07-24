using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NETMVC.Models
{
    public class Person
    {
    [Key]
    public string PersonID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    }
}