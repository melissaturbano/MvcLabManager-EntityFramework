using System.ComponentModel.DataAnnotations;
namespace MvcLabManager.Models;


public class Lab 
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int Number { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Block { get; set; }

    public Lab() {}
    public Lab(int id, int number, string name, string block)
    {
        Id = id;
        Number = number;
        Name = name;
        Block = block;
    }
}