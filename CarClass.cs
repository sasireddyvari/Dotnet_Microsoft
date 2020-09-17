using System;
namespace _clas
{

    class car
    {
        string _carmake, _model;
        int _mfgyear, _price;
        public car(string carmake, int mfgyear, string model, int price)
        {
            _carmake = carmake;
            _mfgyear = mfgyear;
            _model = model;
            _price = price;
        }
        public void DisplayCar()
        {
            Console.WriteLine("The car details are as below");
            Console.WriteLine("carmake :{0} ", _carmake);
            Console.WriteLine("manufactured year:{0}", _mfgyear);
            Console.WriteLine("model :{0} ", _model);
            Console.WriteLine("Price :{0} ", _price);


        }
    }
    public class program
    {
        public void Main()
        {
            car toyato = new car("Toyato", 1890, "ToyatoCamry", 1700000);
            toyato.DisplayCar();

        }
    }
}