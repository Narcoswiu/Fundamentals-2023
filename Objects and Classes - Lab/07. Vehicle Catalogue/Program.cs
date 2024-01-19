string command;
Catalog catalog = new Catalog();

while ((command = Console.ReadLine()) != "end")
{
    string[] carAndTruckInfo = command.Split("/");
    string carType = carAndTruckInfo[0];
    //catalog.Sorted = new List<string>();
   // catalog.Sorted.Add(carAndTruckInfo);
    if (carType == "Truck")
    {
        Truck truckInfo = new Truck();
        truckInfo.Brand = carAndTruckInfo[1];
        truckInfo.Model = carAndTruckInfo[2];
        truckInfo.Weight = int.Parse(carAndTruckInfo[3]);
        Catalog infoTruck = new Catalog();
        infoTruck.Trucks=new List<Truck>();
        infoTruck.Trucks.Add(truckInfo);
    }
    else if (carType == "Car")
    {
        Car car = new Car();
        car.Brand = carAndTruckInfo[1];
        car.Model = carAndTruckInfo[2];
        car.HorsePower = int.Parse(carAndTruckInfo[3]);
        Catalog infoCar = new Catalog();
        infoCar.Cars = new List<Car>();
        infoCar.Cars.Add(car);
    }
}

foreach (var VARIABLE in COLLECTION)
{
    
}


class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }
    public List<string> Sorted { get; set; }

}