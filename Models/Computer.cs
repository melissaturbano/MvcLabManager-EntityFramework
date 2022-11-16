using System.ComponentModel.DataAnnotations;
namespace MvcLabManager.Models;


public class Computer 
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Ram { get; set; }

    [Required]
    public string Processor { get; set; }

    public Computer() {}
    public Computer(int id, string ram, string processor)
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }
}