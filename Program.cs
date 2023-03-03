using DBSchema;
using DBSchema.Responsitory;

Console.WriteLine("Hello, World!");
var AppDb = new AppDB();
Console.WriteLine("Connecting" + AppDb.ConnectionString);