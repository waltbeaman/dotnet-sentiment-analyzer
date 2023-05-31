using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimentAnalyzer;

namespace SentimentAnalyzerApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SentimentAnalyzerController : ControllerBase
    {
        [HttpPost("analyze")]
        public ActionResult Analyze([FromBody] SentimentAnalysisModel.ModelInput text)
        {
            var prediction = SentimentAnalysisModel.Predict(text);
            return Ok(prediction.PredictedLabel);
        }
    }
}
