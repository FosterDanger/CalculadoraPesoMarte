using TecNM.Practica1.Core.Entities;
namespace TecNM.Practica1.Core.Services.interfaces;

public interface IWmService
{
    WM ProcessWm(Person person);
}