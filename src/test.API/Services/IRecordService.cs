using test.API.DTOs;
using test.API.Models;

namespace test.API.Services;

public interface IRecordService
{
    List<RecordResponseDTO> GetRecordsAsync();
    Task<bool> CreateRecordAsync(RecordCreateDTO dto);

}