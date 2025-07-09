namespace WebAppAda.Middlewares
{
  public class AuthMiddlewares
  {
    private readonly RequestDelegate _next; 

    public AuthMiddlewares(RequestDelegate next)
    {
      _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
      if(context.Request.Query.TryGetValue("codigo", out var meuCodigo))
      {
        if(meuCodigo == "123")
        {
          await _next(context);
          return;
        }
      }

      context.Response.StatusCode = 200;
      context.Response.ContentType = "text/plain";
      await context.Response.WriteAsync("Nao autorizado...");
    }
  }



}