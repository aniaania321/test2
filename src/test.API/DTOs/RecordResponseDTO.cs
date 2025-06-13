using test.API.Models;
using Task = System.Threading.Tasks.Task;

namespace test.API.DTOs;

public class RecordResponseDTO
{
    public int RecordId { get; set; }
    public Language Language { get; set; }
    public Models.Task Task { get; set; }
    public Student Student { get; set; }
    public int ExecutionTime { get; set; }
    public DateTime CreatedAt { get; set; }
    
}