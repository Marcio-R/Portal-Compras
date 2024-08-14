using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaCelulares.Models;

// TODO: Herdar da classe "Smartphone"
public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
    {
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
    }
}