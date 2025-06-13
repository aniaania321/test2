using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using test.API.DTOs;
using test.API.Services;

namespace test.API.Controllers;

[ApiController]
[Route("api/languages")]
public class RecordController:ControllerBase
{
    private readonly IRecordService _recordService;
    public RecordController(IRecordService recordService)
    {
        _recordService = recordService;
    }
    [HttpGet]
    public List<RecordResponseDTO> GetRecords()
    {
            var records = _recordService.GetRecordsAsync();
            return records;
    }
    [HttpPost]
    public async Task<IActionResult> CreateDriver([FromBody] RecordCreateDTO dto)
    {
        
        var success = await _recordService.CreateRecordAsync(dto);
        if (!success)
            return NotFound($"Language with ID {dto.LanguageId} does not exist.");

        return Ok("Driver created successfully.");
    }

}//m