using System;
namespace WebApi.Controllers
{

    [Route("api/v1/hedge")]
    [ApiController]
    [SwaggerTag("Dados relacionados à Hedge")]

    public class HedgeController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [SwaggerResponse(StatusCodes.Status200OK, Description = "HedgeFund", Type = typeof(IEnumerable<HedgeFund>))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Description = "Caso sejam informados parâmetros inválidos.")]
        [SwaggerResponse(StatusCodes.StatusStatus204NoContent, Description = "Caso a busca não retorne valores.")]
        public async Task<IActionResult> GetAsync([Required] string cnpj, DateTime startDate, DateTime endDate)
        {
            await _hedgeService.GetHedgeFundByCnpjAsync(cnpj, startDate, endDate);

            return Ok();
        }
    }
}