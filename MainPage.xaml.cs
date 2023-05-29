using MauiApp1.Clases;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
   
    private bool sedanImageVisible = false;
    private bool sedanInfoVisible = false;
    private bool pickUpInfoVisible = false;
    private bool suvInfoVisible = false;
    private bool cuatroPorCuatroInfoVisible = false;
  

    public MainPage()
    {
        InitializeComponent();
    }
   
    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel.Text = string.Empty;
            sedanImage.IsVisible = false;

            EncenderBtn.IsVisible = false;
            AcelerarBtn.IsVisible = false;
            BocinaBtn.IsVisible = false;
            FrenarBtn.IsVisible = false;
            ApagarBtn.IsVisible = false;
        }
        else
        {
            sedan = new Sedan();
            sedan.Marca = "Toyota";
            sedan.Modelo = "Corolla";
            sedan.Color = "Gris";
            sedan.Anio = 2021;
            sedan.Placa = "DEF456";
            sedan.Tipo = "Sedán";

            string sedanInfo = $"Marca: {sedan.Marca}\nModelo: {sedan.Modelo}\nColor: {sedan.Color}\nAño: {sedan.Anio}\nPlaca: {sedan.Placa}\nTipo: {sedan.Tipo}";
            sedanLabel.Text = sedanInfo;

            sedanInfoVisible = true;
            sedanImage.IsVisible = true;

            EncenderBtn.IsVisible = true;
            AcelerarBtn.IsVisible = true;
            BocinaBtn.IsVisible = true;
            FrenarBtn.IsVisible = true;
            ApagarBtn.IsVisible = true;
        }
    }
    Sedan sedan;

    private void OnEncenderClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedan.Encender();
            sedanLabel.Text += "\n\nTSTSTSTS RUUUUUUN\n";
        }
        else
        {
            sedanLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnAcelerarClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            if (sedan.EstadoMotor == EstadoMotor.Encendido)
            {
                sedan.Acelerar(40);
                sedanLabel.Text += "Acelerando a 40 km/h\n";
            }
            else
            {
                sedanLabel.Text = "Enciende el carro para acelerar\n";
            }
        }
        else
        {
            sedanLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnBocinaClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            if (sedan.EstadoMotor == EstadoMotor.Encendido)
            {
                sedan.Bocina();
                sedanLabel.Text += "PEEP PEEP\n";
            }
            else
            {
                sedanLabel.Text = "Enciende el carro para bocinar\n";
            }
        }
        else
        {
            sedanLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnFrenarClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            if (sedan.EstadoMotor == EstadoMotor.Encendido)
            {
                sedan.Frenar(20);
                sedanLabel.Text += "Frenando\n";
            }
            else
            {
                sedanLabel.Text = "Enciende el carro para frenar\n";
            }
        }
        else
        {
            sedanLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnApagarClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            if (sedan.EstadoMotor == EstadoMotor.Encendido)
            {
                sedan.Apagar();
                sedanLabel.Text += "Apagando el carro\n SSSSSSSSSSSS\nAuto Apagado";
            }
            else
            {
                sedanLabel.Text = "Enciende el carro para apagarlo\n";
            }
        }
        else
        {
            sedanLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUpInfoVisible = false;
            pickUpLabel.Text = string.Empty;
            pickUpImage.IsVisible = false;

            EncenderBtnPickUp.IsVisible = false;
            AcelerarBtnPickUp.IsVisible = false;
            BocinaBtnPickUp.IsVisible = false;
            CargarBtnPickUp.IsVisible = false;
            ApagarBtnPickUp.IsVisible = false;
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Marca = "Ford";
            pickUp.Modelo = "Ranger";
            pickUp.Color = "Naranja";
            pickUp.Anio = 2022;
            pickUp.Placa = "P 863JK";
            pickUp.Tipo = "PickUp";
            //pickUp.Encender();
            //pickUp.Acelerar(50);
            //pickUp.Bocina();
            //pickUp.Cargar();
            //pickUp.Apagar();

            string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}";
            pickUpLabel.Text = pickUpInfo; // Muestra la información
            
            pickUpInfoVisible = true;
            pickUpImage.IsVisible = true;

            EncenderBtnPickUp.IsVisible = true;
            AcelerarBtnPickUp.IsVisible = true;
            BocinaBtnPickUp.IsVisible = true;
            CargarBtnPickUp.IsVisible = true;
            ApagarBtnPickUp.IsVisible = true;
        }
  
    }
    PickUp pickUp;
    private void OnEncenderPickUpClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUp = new PickUp();
            pickUp.Encender();
            pickUpLabel.Text += "\n\nTSTSTSTS RUUUUUUN\n";
        }

    }

    private void OnAcelerarPickUpClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            if (pickUp.EstadoMotor == EstadoMotor.Encendido)
            {
                pickUp.Acelerar(40);
                pickUpLabel.Text += "Acelerando a 40 km/h\n";
            }
            else
            {
                pickUpLabel.Text = "Enciende el carro para acelerar\n";
            }
        }
        else
        {
            pickUpLabel.Text = "Enciende primero el Auto\n";
        }
    }

    private void OnBocinaPickUpClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            if (pickUp.EstadoMotor == EstadoMotor.Encendido)
            {
                pickUp.Bocina();
                pickUpLabel.Text += "PEEP PEEP\n";
            }
            else
            {
                pickUpLabel.Text = "Enciende el carro para bocinar\n";
            }
        }
        else
        {
            pickUpLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }
    private void OnCargarPickUpClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            if (pickUp.EstadoMotor == EstadoMotor.Encendido)
            {
                pickUp.Cargar();
                pickUpLabel.Text += "Auto Cargado con 200lb\n";
            }
        }
    }
    private void OnApagarPickUpClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            if (pickUp.EstadoMotor == EstadoMotor.Encendido)
            {
                pickUp.Apagar();
                pickUpLabel.Text += "Apagando el carro\n SSSSSSSSSSSS\nAuto Apagado";
            }
            else
            {
                sedanLabel.Text = "Enciende el carro para apagarlo\n";
            }
        }
        else
        {
            sedanLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            suvInfoVisible = false;
            suvLabel.Text = string.Empty;
            suvImage.IsVisible = false;
        }
        else
        {
            SUV suv = new SUV();
            suv.Marca = "Jeep";
            suv.Modelo = "Wrangler";
            suv.Color = "Negro";
            suv.Anio = 2023;
            suv.Placa = "GHI789";
            suv.Tipo = "SUV";
            suv.Encender();
            suv.Acelerar(60);
            suv.Bocina();
            suv.ActivarTraccion4x4();
            suv.Apagar();

            string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}";
            suvLabel.Text = suvInfo; // Muestra la información

            suvInfoVisible = true;
            suvImage.IsVisible = true;  
        }
    }
    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            cuatroPorCuatroInfoVisible = false;
            cuatroPorCuatroLabel.Text = string.Empty;
            cuatroImage.IsVisible = false;
        }
        else
        {
            CuatroPorCuatro cuatroPorCuatro = new CuatroPorCuatro();
            cuatroPorCuatro.Marca = "Mazda";
            cuatroPorCuatro.Modelo = "CX5";
            cuatroPorCuatro.Color = "Gris";
            cuatroPorCuatro.Anio = 2023;
            cuatroPorCuatro.Placa = "JKL012";
            cuatroPorCuatro.Tipo = "4x4";
            cuatroPorCuatro.Encender();
            cuatroPorCuatro.Acelerar(70);
            cuatroPorCuatro.Bocina();
            cuatroPorCuatro.ConducirTerrenosDificiles();
            cuatroPorCuatro.Apagar();

            string cuatroPorCuatroInfo = $"Marca: {cuatroPorCuatro.Marca}\nModelo: {cuatroPorCuatro.Modelo}\nColor: {cuatroPorCuatro.Color}\nAño: {cuatroPorCuatro.Anio}\nPlaca: {cuatroPorCuatro.Placa}\nTipo: {cuatroPorCuatro.Tipo}";
            cuatroPorCuatroLabel.Text = cuatroPorCuatroInfo; // Muestra la información

            cuatroPorCuatroInfoVisible = true;
            cuatroImage.IsVisible = true;
        }
    }

}

