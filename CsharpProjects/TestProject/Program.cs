﻿
/*string[] fraudulentOrderIDs = new string[3];//crear un array sin inizializar 

fraudulentOrderIDs [0] = "A123";
fraudulentOrderIDs [1] = "B456";
fraudulentOrderIDs [2] = "C789";*/

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};//inicializar elementos en un array
///fraudulentOrderIDs [3] = "D000";
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reaging First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");