namespace MultiplayerBattleshipGameServer
{
    public class WebResponseHandler
    {
        public static async Task Response(HttpContext context)
        {
            if (context.Request.Path == "/postuser")
            {
                var form = context.Request.Form;
                string name = form["name"];
                string age = form["age"];
                string[] languages = form["languages"];
                // создаем из массива languages одну строку
                string langList = "";
                foreach (var lang in languages)
                {
                    langList += $" {lang}";
                }
                await context.Response.WriteAsync($"<div><p>Name: {name}</p>" +
                    $"<p>Age: {age}</p>" +
                    $"<div>Languages:{langList}</div></div>");
            }
            else
            {
                await context.Response.SendFileAsync("html/index.html");
            }
        }

    }
}
