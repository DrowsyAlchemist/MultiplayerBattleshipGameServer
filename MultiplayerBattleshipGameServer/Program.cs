using System.Net;
using MultiplayerBattleshipGameServer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.Run((context) => WebResponseHandler.Response(context));


app.Run();
