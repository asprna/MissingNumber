// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using MissingNumber.App;
using MissingNumber.Interfaces;
using MissingNumber.Services;

var services = new ServiceCollection();
services.AddSingleton<IMissingNumberFinder, SumFormulaMissingNumberFinder>();
services.AddTransient<MissingNumberApp>();
var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetRequiredService<MissingNumberApp>();
app.Run();