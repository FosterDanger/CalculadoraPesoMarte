using TecNM.Practica1.Core.Services.interfaces;
using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Services;


public class MwService: IWmService
{
    public WM ProcessWm(Person person)
    {
        var wm = new WM();
        wm.WeightM = (float) (person.Weight * ( 3.711 / 9.81));

        return wm;
    }
}