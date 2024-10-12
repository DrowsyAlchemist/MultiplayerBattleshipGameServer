namespace MultiplayerBattleshipGameServer
{
    public class WebResponseHandler
    {
        public static async Task Response(HttpContext context)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.SendFileAsync("html/index.html");
        }
    }
}
