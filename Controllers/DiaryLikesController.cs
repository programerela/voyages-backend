
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Security.Claims;
using Voyages.Data;
using Voyages.DTOs.Requests;
using Voyages.DTOs.Responses;
using Voyages.Interfaces;
using Voyages.Services;

namespace Voyages.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiaryLikesController : ControllerBase
    {
        private readonly IDiaryLikeService _diaryLikeService;
        private readonly IMapper _mapper;

        public DiaryLikesController(IMapper mapper, IDiaryLikeService diaryLikeService)
        {
            _mapper = mapper;
            _diaryLikeService = diaryLikeService;
        }

        private string GetCurrentUserId()
        {
            // Retrieve the user's ID from the current ClaimsPrincipal
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll() =>
        //   Ok(_mapper.Map<List<LikedDiaryResponse>>(await _diaryLikeService.GetAllDiaryLikes()));

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetLikedDiariesByUser([FromRoute] int userId)
        {
            var likedDiaries = await _diaryLikeService.GetLikedDiariesByUserId(userId);

            if (likedDiaries == null || likedDiaries.Count == 0)
                return NotFound("No liked diaries found for the user");

            return Ok(_mapper.Map<List<LikedDiaryResponse>>(likedDiaries));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var likedDiary = await _diaryLikeService.GetDiaryLikeById(id);

            if (likedDiary is null) return NotFound("Diary not found");

            return Ok(_mapper.Map<LikedDiaryResponse>(likedDiary));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLikedDiaryRequest request)
        {
            if (request is null) return BadRequest("Request cannot be null");

            var likedDiary = _mapper.Map<LikedDiary>(request);

            await _diaryLikeService.Create(likedDiary);

            return Ok(_mapper.Map<LikedDiaryResponse>(likedDiary));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var likedDiary = await _diaryLikeService.GetDiaryLikeById(id);

            if (likedDiary is null)
                return NotFound("Liked diary not found");

            await _diaryLikeService.Delete(likedDiary);

            return NoContent();
        }
    }
}
