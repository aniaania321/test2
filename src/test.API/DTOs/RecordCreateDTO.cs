using System.ComponentModel.DataAnnotations;
using Task = test.API.Models.Task;

namespace test.API.DTOs;

public class RecordCreateDTO
{
    [Required]
    public int LanguageId { get; set; }
    [Required]
    public int StudentId { get; set; }
    
    public Task Task { get; set; }
    [Required]
    public int ExecutionTime { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
}