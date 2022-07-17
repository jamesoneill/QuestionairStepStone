using JO.QuestionairStepStone.Interfaces.Core;
using JO.QuestionairStepStone.Interfaces.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JO.QuestionairStepStone.WebAPI.Controllers
{
    [ApiController]
    [Route("api/questions")]
    public class QuestionairController : ControllerBase
    {
        private readonly IQuestionairService _questionairService;
        public QuestionairController(IQuestionairService questionairService)
        {
            _questionairService = questionairService;
        }

        [HttpGet]
        public async Task<IQuestionair> Get()
        {
            return await _questionairService.GetQuestionairAsync();
        }
    }
}