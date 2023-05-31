using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentimentAnalyzer;

namespace SentimentAnalyzerApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SentimentAnalyzerController : ControllerBase
    {
        [HttpPost("/")]
        public ActionResult Analyze([FromBody] string text)
        {
            var inputText = new SentimentAnalysisModel.ModelInput();
            inputText.Review = text;
            var prediction = SentimentAnalysisModel.Predict(inputText);
            return Ok(prediction.PredictedLabel);
        }
    }
}
