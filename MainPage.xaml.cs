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
   
    private void OnSedanCounterClicked(object sender, EventArgs e)
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

    private void OnSedanEncenderClicked(object sender, EventArgs e)
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

    private void OnSedanAcelerarClicked(object sender, EventArgs e)
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

    private void OnSedanBocinaClicked(object sender, EventArgs e)
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

    private void OnSedanFrenarClicked(object sender, EventArgs e)
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

    private void OnSedanApagarClicked(object sender, EventArgs e)
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

    private void OnPickUpCounterClicked(object sender, EventArgs e)
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
            FrenarBtnPickUp.IsVisible = false;
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
   
            string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}";
            pickUpLabel.Text = pickUpInfo; 
            pickUpInfoVisible = true;
            pickUpImage.IsVisible = true;

            EncenderBtnPickUp.IsVisible = true;
            AcelerarBtnPickUp.IsVisible = true;
            BocinaBtnPickUp.IsVisible = true;
            FrenarBtnPickUp.IsVisible = true;
            CargarBtnPickUp.IsVisible = true;
            ApagarBtnPickUp.IsVisible = true;
        }
  
    }
    PickUp pickUp;
    private void OnPickUpEncenderClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUp = new PickUp();
            pickUp.Encender();
            pickUpLabel.Text += "\n\nTSTSTSTS RUUUUUUN\n";
        }

    }

    private void OnPickUpAcelerarClicked(object sender, EventArgs e)
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

    private void OnPickUpBocinaClicked(object sender, EventArgs e)
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
    private void OnPickUpFrenarClicked(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            if (pickUp.EstadoMotor == EstadoMotor.Encendido)
            {
                pickUp.FrenarPickUp(20);
                pickUpLabel.Text += "FRENANDO EL AUTO HASTA 0 KM\n";
            }
            else
            {
                pickUpLabel.Text = "Acelera para frenar\n";
            }
        }
        else
        {
            pickUpLabel.Text = "Enciende el auto primero\n";
        }
    }
    private void OnPickUpCargarClicked(object sender, EventArgs e)
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
    private void OnPickUpApagarClicked(object sender, EventArgs e)
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

            EncenderSUVBtn.IsVisible = false;
            AcelerarSUVBtn.IsVisible = false;
            BocinaSUVBtn.IsVisible = false;
            FrenarSUVBtn.IsVisible = false;
            Traccion4x4Btn.IsVisible = false;
            ApagarSUVBtn.IsVisible = false;
        }
        else
        {
            suv = new SUV();
            suv.Marca = "Jeep";
            suv.Modelo = "Wrangler";
            suv.Color = "Negro";
            suv.Anio = 2023;
            suv.Placa = "GHI789";
            suv.Tipo = "SUV";

            string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}";
            suvLabel.Text = suvInfo;

            suvInfoVisible = true;
            suvImage.IsVisible = true;

            EncenderSUVBtn.IsVisible = true;
            AcelerarSUVBtn.IsVisible = true;
            BocinaSUVBtn.IsVisible = true;
            FrenarSUVBtn.IsVisible = true;
            Traccion4x4Btn.IsVisible = true;
            ApagarSUVBtn.IsVisible = true;
        }
    }

    SUV suv;

    private void OnSUVEncenderClicked(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            suv.Encender();
            suvLabel.Text += "\n\nTSTSTSTS RUUUUUUN\n";
        }
        else
        {
            suvLabel.Text = "Ingrese la llave correctamente\n";
        }
    }

    private void OnSUVAcelerarClicked(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            if (suv.EstadoMotor == EstadoMotor.Encendido)
            {
                suv.Acelerar(40);
                suvLabel.Text += "Acelerando a 40 km/h\n";
            }
            else
            {
                suvLabel.Text = "Enciende el carro para acelerar\n";
            }
        }
        else
        {
            suvLabel.Text = "Enciende el auto primero\n";
        }
    }

    private void OnSUVBocinaClicked(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            if (suv.EstadoMotor == EstadoMotor.Encendido)
            {
                suv.Bocina();
                suvLabel.Text += "PEEP PEEP\n";
            }
            else
            {
                suvLabel.Text = "Enciende el carro para bocinar\n";
            }
        }
        else
        {
            suvLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnSUVFrenarClicked(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            if (suv.EstadoMotor == EstadoMotor.Encendido)
            {
                suv.Frenar(20);
                suvLabel.Text += "Frenando\n";
            }
            else
            {
                suvLabel.Text = "Enciende el carro para frenar\n";
            }
        }
        else
        {
            suvLabel.Text = "Enciende el Auto correctamente\n";
        }
    }
    private void OnSUVTraccion4x4Clicked(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            if (suv.EstadoMotor == EstadoMotor.Encendido)
            {
                suv.ActivarTraccion4x4();
                suvLabel.Text += "\nTracción 4x4 activada\n";
            }
            else
            {
                suvLabel.Text = "Enciende el carro para activar la tracción 4x4\n";
            }
        }
        else
        {
            suvLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void OnSUVApagarClicked(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            if (suv.EstadoMotor == EstadoMotor.Encendido)
            {
                suv.Apagar();
                suvLabel.Text += "Apagando el carro\n SSSSSSSSSSSS\nAuto Apagado";
            }
            else
            {
                suvLabel.Text = "Enciende el carro para apagarlo\n";
            }
        }
        else
        {
            suvLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }
    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            cuatroPorCuatroInfoVisible = false;
            cuatroPorcuatroLabel.Text = string.Empty;
            cuatroImage.IsVisible = false;

            Encender4x4Btn.IsVisible = false;
            Acelerar4x4Btn.IsVisible = false;
            Bocina4x4Btn.IsVisible = false;
            Frenar4x4Btn.IsVisible = false;
            MarchaTerrenosDificilesBtn.IsVisible = false;
            Apagar4x4Btn.IsVisible = false;
        }
        else
        {
            cuatroPorCuatro = new CuatroPorCuatro();
            cuatroPorCuatro.Marca = "Mazda";
            cuatroPorCuatro.Modelo = "CX5";
            cuatroPorCuatro.Color = "Gris";
            cuatroPorCuatro.Anio = 2023;
            cuatroPorCuatro.Placa = "JKL012";
            cuatroPorCuatro.Tipo = "4x4";
    

            string cuatroPorCuatroInfo = $"Marca: {cuatroPorCuatro.Marca}\nModelo: {cuatroPorCuatro.Modelo}\nColor: {cuatroPorCuatro.Color}\nAño: {cuatroPorCuatro.Anio}\nPlaca: {cuatroPorCuatro.Placa}\nTipo: {cuatroPorCuatro.Tipo}";
            cuatroPorcuatroLabel.Text = cuatroPorCuatroInfo; 
            cuatroPorCuatroInfoVisible = true;
            cuatroImage.IsVisible = true;

            Encender4x4Btn.IsVisible = true;
            Acelerar4x4Btn.IsVisible = true;
            Bocina4x4Btn.IsVisible = true;
            Frenar4x4Btn.IsVisible = true;
            MarchaTerrenosDificilesBtn.IsVisible = true;
            Apagar4x4Btn.IsVisible = true;
        }
    }
    CuatroPorCuatro cuatroPorCuatro;

    private void On4x4EncenderClicked(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            cuatroPorCuatro.Encender();
            cuatroPorcuatroLabel.Text += "\n\nTSTSTSTS RUUUUUUN\n";
        }
        else
        {
            cuatroPorcuatroLabel.Text = "Ingrese la llave correctamente\n";
        }
    }

    private void On4x4AcelerarClicked(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            if (cuatroPorCuatro.EstadoMotor == EstadoMotor.Encendido)
            {
                cuatroPorCuatro.Acelerar(40);
                cuatroPorcuatroLabel.Text += "Acelerando a 40 km/h\n";
            }
            else
            {
                cuatroPorcuatroLabel.Text = "Enciende el carro para acelerar\n";
            }
        }
        else
        {
            cuatroPorcuatroLabel.Text = "Enciende el auto primero\n";
        }
    }

    private void On4x4BocinaClicked(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            if (cuatroPorCuatro.EstadoMotor == EstadoMotor.Encendido)
            {
                cuatroPorCuatro.Bocina();
                cuatroPorcuatroLabel.Text += "PEEP PEEP\n";
            }
            else
            {
                cuatroPorcuatroLabel.Text = "Enciende el carro para bocinar\n";
            }
        }
        else
        {
            cuatroPorcuatroLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }

    private void On4x4FrenarClicked(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            if (cuatroPorCuatro.EstadoMotor == EstadoMotor.Encendido)
            {
                cuatroPorCuatro.Frenar(20);
                cuatroPorcuatroLabel.Text += "Frenando\n";
            }
            else
            {
                cuatroPorcuatroLabel.Text = "Enciende el carro para frenar\n";
            }
        }
        else
        {
            cuatroPorcuatroLabel.Text = "Enciende el Auto correctamente\n";
        }
    }
    private void On4x4MarchaTerrenosDificilesClicked(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            if (cuatroPorCuatro.EstadoMotor == EstadoMotor.Encendido)
            {
                cuatroPorCuatro.ActivarTraccion4x4();
                cuatroPorcuatroLabel.Text += "Marcha de terrenos difíciles activada\n";
            }
            else
            {
                cuatroPorcuatroLabel.Text = "Enciende el carro para activar la marcha de terrenos difíciles\n";
            }
        }
        else
        {
            cuatroPorcuatroLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }
    private void On4x4ApagarClicked(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            if (cuatroPorCuatro.EstadoMotor == EstadoMotor.Encendido)
            {
                cuatroPorCuatro.Apagar();
                cuatroPorcuatroLabel.Text += "Apagando el carro\n SSSSSSSSSSSS\nAuto Apagado";
            }
            else
            {
                cuatroPorcuatroLabel.Text = "Enciende el carro para apagarlo\n";
            }
        }
        else
        {
            cuatroPorcuatroLabel.Text = "Selecciona el tipo de Auto primero\n";
        }
    }
}

