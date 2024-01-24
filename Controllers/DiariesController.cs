using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Voyages.Data;
using Voyages.DTOs.Requests;
using Voyages.DTOs.Responses;
using Voyages.Interfaces;

namespace Voyages.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiariesController : ControllerBase
    {
        private readonly IDiaryService _diaryService;
        private readonly IMapper _mapper;

        public DiariesController(IDiaryService diaryService, IMapper mapper)
        {
            _diaryService = diaryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(_mapper.Map<List<DiaryResponse>>(await _diaryService.GetAllDiaries()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var diary = await _diaryService.GetDiaryById(id);

            if (diary is null) return NotFound("Diary not found");

            return Ok(_mapper.Map<DiaryResponse>(diary));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDiaryRequest request)
        {
            if (request is null) return BadRequest("Request cannot be null");

            var diary = _mapper.Map<Diary>(request);

            await _diaryService.Create(diary);

            return Ok(_mapper.Map<DiaryResponse>(diary));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateDiaryRequest request, [FromRoute] int id)
        {
            if (request is null) return BadRequest("Request cannot be null");

            var diary = await _diaryService.GetDiaryById(id);

            if (diary is null) return NotFound("Diary not found");

            _mapper.Map<UpdateDiaryRequest, Diary>(request, diary);

            await _diaryService.Update(diary);

            return Ok(_mapper.Map<DiaryResponse>(diary));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var diary = await _diaryService.GetDiaryById(id);

            if (diary is null) return NotFound("Diary not found");

            await _diaryService.Delete(diary);

            return NoContent();
        }
    }
}
