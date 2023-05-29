using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class CuatroPorCuatro : IVehiculo
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

        }

        public void Acelerar(int cuanto)
        {
            if (EstadoMotor == EstadoMotor.Encendido)
            {
                VelocidadActual += cuanto;

            }
            else
            {

            }
        }

        public void Encender()
        {
            if (EstadoMotor == EstadoMotor.Apagado)
            {
                EstadoMotor = EstadoMotor.Encendido;

            }
            else
            {

            }
        }

        public void Frenar(int cuanto)
        {
            if (EstadoMotor == EstadoMotor.Encendido && VelocidadActual > 0)
            {
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                    VelocidadActual = 0;

            }
            else
            {

            }
        }

        public void ActivarTraccion4x4()
        {
            if (EstadoMotor == EstadoMotor.Encendido && VelocidadActual > 0)
            {

            }
            else
            {

            }
        }

        public void Apagar()
        {
            if (EstadoMotor == EstadoMotor.Encendido)
            {
                EstadoMotor = EstadoMotor.Apagado;
                VelocidadActual = 0;

            }
            else
            {

            }
        }

    }

}
