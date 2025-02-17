using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPoliApp.WinForms.Service
{
    public class MyService : IMyService
    {
        public string GetNombre(string nombre)
        {
            return nombre;
        }
    }
    public interface IMyService 
    {
        string GetNombre(string nombre);
    }
}
