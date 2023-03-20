using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Activated(object sender, EventArgs e)
    {
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        //Declaracion de variables
        float v, d, t;

        //Entrada de datos
        v = float.Parse(entry1.Text); //Convertir datos de String a float
        t = float.Parse(entry2.Text); //Convertir datos de String a float


        //Procesos ( Formaulas y operaciones)
        d = v * t; // Utiliza formula de fisica

        //Salidad de datos
        entry3.Text = d.ToString(); //Desplegar el resultado, para la cual se debe corvertir de float a String 

    }


    protected void OnClearActivated(object sender, EventArgs e)
    {
    }

    protected void OnClearClicked(object sender, EventArgs e)
    {
        // Proceso de limpia

        entry1.Text = "";
        entry2.Text = "";
        entry3.Text = "";

    }
}
