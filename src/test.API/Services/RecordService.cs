using Microsoft.EntityFrameworkCore;
using test.API.Data;
using test.API.DTOs;
using test.API.Models;

namespace test.API.Services;

public class RecordService:IRecordService
{
    private readonly RecordDbContext _context;

    public RecordService(RecordDbContext context)
    {
        _context = context;
    }

    public List<RecordResponseDTO> GetRecordsAsync()=>
    
        _context.Records
            .Select(d => new RecordResponseDTO() {  RecordId= d.Id, Language = d.Language,Task= d.Task,Student = d.Student,ExecutionTime = d.ExecutionTime ,CreatedAt = d.CreatedAt})
            .ToList();
    
    public async Task<bool> CreateRecordAsync(RecordCreateDTO dto)
    {
        var record = new Record()
        {
            LanguageId = dto.LanguageId,
            Task = dto.Task,
            ExecutionTime = dto.ExecutionTime,
            CreatedAt = dto.CreatedAt,
        };
        _context.Records.Add(record);
        await _context.SaveChangesAsync();
        return true;
    }



}