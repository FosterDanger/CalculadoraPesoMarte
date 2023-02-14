using TecNM.Practica1.Core.Managers.interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.interfaces;

namespace TecNM.Practica1.Core.Managers;

public class WmManager : IWmManager
{
   private readonly IWmService _service;

    public WmManager(IWmService service)
    {
        _service = service;
    }

    public WM GetWM(Person person){
        return _service.ProcessWm(person);
    }
}