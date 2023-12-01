using RecuPOO2023.Datos;
using RecuPOO2023.Entidades;

namespace RecuPOO2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(1000);
            Pesos peso = new Pesos(20000);
            Pesos peso2 = new Pesos(1000);
            Euro euro = new Euro(1000);

            Billetera billetera = new Billetera();

            Console.WriteLine(billetera.ExtraerDinero(new Pesos(100)));

            string info = billetera;
            Console.WriteLine(info);


            Console.WriteLine(billetera.IngresarDinero(dolar));
            Console.WriteLine(billetera.IngresarDinero(euro));
            Console.WriteLine(billetera.IngresarDinero(peso));
            Console.WriteLine(billetera.IngresarDinero(peso2));

            Dolar dolarRetirar = new Dolar(2000);
            Console.WriteLine(billetera.ExtraerDinero(dolarRetirar));

            Pesos pesoRetirar = new Pesos(1500);
            Console.WriteLine(billetera.ExtraerDinero(pesoRetirar));

            Console.WriteLine("Datos de las monedas en la billetera:");
            info = billetera;
            Console.WriteLine(info);
            Console.WriteLine(billetera[0].MostrarInfo());
            Console.WriteLine(billetera[1].MostrarInfo());
            //Console.WriteLine(billetera[2].MostrarInfo());
            //Console.WriteLine(billetera[3].MostrarInfo());

            Console.WriteLine("_______________________________________________");
            Console.WriteLine($"Cotizacion en Dolares ");
           
            Console.WriteLine($"Con esta cantidad de {peso.Cantidad} Pesos, puede comprar {peso.CalcularValorEnDolares()} Dolares ");
            Console.WriteLine($"Con esta otra cantidad de {peso2.Cantidad} Pesos, puede comprar {peso2.CalcularValorEnDolares()} Dolares ");
            Console.WriteLine($"Con esta otra cantidad de {euro.Cantidad} Euros, puede comprar {euro.CalcularValorEnDolares()} Dolares ");


            Console.WriteLine("_______________________________________________");
            Console.WriteLine($"Cotizacion en Euros");

            Console.WriteLine($"Con esta cantidad de {peso.Cantidad} Pesos, puede comprar {peso.CotizacionRespectoDolar()} euros ");
            Console.WriteLine($"Con esta otra cantidad de {peso2.Cantidad} Pesos, puede comprar {peso2.CotizacionRespectoDolar()} euros ");
            Console.WriteLine($"Con esta otra cantidad de {euro.Cantidad} Euros, puede comprar {euro.CalcularValorEnDolares()} Dolares ");


            

           

            List<Moneda> datosMonedas = billetera.ObtenerDatosMonedas();

            //ManejadorArchivoXml manejadorArchivo = new ManejadorArchivoXml();
            //manejadorArchivo.GuardarMonedas(billetera.GetMonedas());
        }
    }
}
