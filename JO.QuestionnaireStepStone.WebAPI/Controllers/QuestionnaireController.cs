using JO.QuestionnaireStepStone.Interfaces.Core;
using JO.QuestionnaireStepStone.Interfaces.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JO.QuestionnaireStepStone.WebAPI.Controllers
{
    [ApiController]
    [Route("api/questions")]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IQuestionnaireService _questionnaireService;
        public QuestionnaireController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        [HttpGet]
        public async Task<IQuestionnaire> Get()
        {
            return await _questionnaireService.GetQuestionnaireAsync();
        }
    }
}