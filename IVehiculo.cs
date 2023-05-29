using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string Color { get; set; }
        int Anio { get; set; }
        string Placa { get; set; }
        string Tipo { get; set; }
        int VelocidadMaxima { get; }
        int VelocidadActual { get; }
        void Bocina();
        void Acelerar(int cuanto);
        void Encender();
        void Apagar();
        void Frenar(int cuanto);
    }

    public enum EstadoMotor
    {
        Apagado,
        Encendido
    }

    public enum Estado
    {
        Estacionado,
        EnMovimiento
    }

    public class Sedan : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima => 200;
        public int VelocidadActual { get; private set; }
        public EstadoMotor EstadoMotor { get; private set; }
        public Estado Estado { get; private set; }

        public void Bocina()
        {
            Console.WriteLine("BEEP BEEP");
        }

        public void Acelerar(int cuanto)
        {
            if (EstadoMotor == EstadoMotor.Encendido)
            {
                VelocidadActual += cuanto;
                Console.WriteLine($"Acelerando a {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("Enciende el carro para acelerar");
            }
        }

        public void Encender()
        {
            if (EstadoMotor == EstadoMotor.Apagado)
            {
                EstadoMotor = EstadoMotor.Encendido;
                Console.WriteLine("¡Carro encendido!");
            }
            else
            {
                Console.WriteLine("El carro ya está encendido");
            }
        }

        public void Apagar()
        {
            if (EstadoMotor == EstadoMotor.Encendido)
            {
                EstadoMotor = EstadoMotor.Apagado;
                VelocidadActual = 0;
                Console.WriteLine("Carro apagado");
            }
            else
            {
                Console.WriteLine("El carro ya está apagado");
            }
        }

        public void Frenar(int cuanto)
        {
            if (EstadoMotor == EstadoMotor.Encendido && VelocidadActual > 0)
            {
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                    VelocidadActual = 0;
                Console.WriteLine($"Frenando a {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("No es posible frenar en este momento");
            }
        }
    }
}

