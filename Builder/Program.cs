// See https://aka.ms/new-console-template for more information
using Builder.Builders;
using Builder.Directors;
using Builder.Products;

VehicleBuilder vehicleHachtBuilder = new();
Director directorHacth = new(vehicleHachtBuilder);
directorHacth.ConstructorHachtCar();
Vehicle hacht = vehicleHachtBuilder.Build();

VehicleBuilder vehicleSedanBuilder = new();
Director directorSedan = new(vehicleSedanBuilder);
directorSedan.ConstructorSedanCar();
Vehicle sedan = vehicleSedanBuilder.Build();

VehicleBuilder vehicleSuvBuilder = new();
Director directorSuv = new(vehicleSuvBuilder);
directorSuv.ConstructorSuvCar();
Vehicle suv = vehicleSuvBuilder.Build();

Console.WriteLine(hacht.ToString()); 
Console.WriteLine();
Console.WriteLine(sedan.ToString());
Console.WriteLine();
Console.WriteLine(suv.ToString());
Console.ReadKey();