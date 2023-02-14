// See https://aka.ms/new-console-template for more information

using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;




public static class Program {
    public static void Main(String[] args){
        float weight = 0;

        System.Console.WriteLine("Ingresa tu peso: ");
        Single.TryParse(System.Console.ReadLine(), out weight);

        var person = new Person{Weight = weight};
        var service = new MwService();
        var manager = new WmManager(service);

        WM wm = manager.GetWM(person);

        System.Console.WriteLine($"Tu peso en Marte es: {wm.WeightM} ");

    }
}