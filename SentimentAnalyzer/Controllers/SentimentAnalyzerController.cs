using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SentimentAnalyzer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentimentAnalyzerController : ControllerBase
    {
        [HttpPost("/")]
        public ActionResult Analyze([FromBody] string text)
        {
            var inputText = new SentimentAnalysis.ModelInput();
            inputText.Review = text;
            var prediction = SentimentAnalysis.Predict(inputText);
            return Ok(prediction.PredictedLabel);
        }

    }
}
