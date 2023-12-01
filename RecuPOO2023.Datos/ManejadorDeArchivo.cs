using RecuPOO2023.Consola;
using RecuPOO2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Datos
{
    public class ManejadorDeArchivo:IArchivo
    {
        //public List<Moneda> lista { get ; set ; }

        //public static void Guardar(List<Moneda> lista, string archivo)
        //{
        //    using (var escritor = new StreamWriter(archivo, true))
        //    {
        //        foreach (var persona in lista)
        //        {
        //            var linea = ConstruirLinea(moneda);
        //            escritor.WriteLine(linea);

        //        }
        //    }
        //}

        //private static string ConstruirLinea(Moneda moneda)
        //{
        //    if (moneda.GetType() == typeof(Pesos))
        //    {
        //        return
        //            $"{moneda.Cantidad}|{moneda.CalcularValorEnPesos}|{((Jugador)persona).GetNumero()}|{((Jugador)persona).GetEsCapitan()}|{Tipo.Jugador}";
        //    }
        //    return $"{persona.Nombre}|{persona.Apellido}|{Tipo.Tecnico}";
        //}

        //public List<T> GetLista()
        //{
        //    throw new NotImplementedException();
        //}

        //List<Moneda> IArchivo.GetLista()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
