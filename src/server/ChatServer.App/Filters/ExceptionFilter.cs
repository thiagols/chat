using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace ChatServer.App.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = 500;
            context.Result = new JsonResult(new { mensagem = "Desculpe, não estamos conseguindo processar sua requisição, por favor verifique sua conexão ou tente reiniciar nosso chat." });

            base.OnException(context);
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = 500;
            context.Result = new JsonResult(new { mensagem = "Desculpe, não estamos conseguindo processar sua requisição, por favor verifique sua conexão ou tente reiniciar nosso chat." });

            base.OnException(context);
            return base.OnExceptionAsync(context);
        }
    }
}
