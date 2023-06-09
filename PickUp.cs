﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class PickUp : IVehiculo
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

        public void Acelerar(int cuanto)
        {
          
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

        public void Bocina()
        {
            
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


        public void FrenarPickUp(int cuanto)
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

            public void Cargar()
            {
                if (EstadoMotor == EstadoMotor.Encendido && VelocidadActual > 0)
                {
                    if (VelocidadActual < 0)
                        VelocidadActual = 0;
                    
                }
                else
                {
                    
                }
            }

        public void Frenar(int cuanto)
        {
            throw new NotImplementedException();
        }
    }
}


