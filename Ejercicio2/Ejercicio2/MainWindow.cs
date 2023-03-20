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
        // Declaracion de variables
        float RC, RI, RB, PRC, PRI, P;

        //Datos de entrada 

        RC = float.Parse(entry1.Text);
        RI = float.Parse(entry2.Text);
        RB = float.Parse(entry3.Text);

        //Datos intermedios
        PRC = 4;
        PRI = -1;

        //Operacion
        P = (PRC * RC) + (PRI * RI);

        //Salida de datos

        entry4.Text = P.ToString();
    }

    protected void OnButton2Activated(object sender, EventArgs e)
    {
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        entry1.Text = "";
        entry2.Text = "";
        entry3.Text = "";
        entry4.Text = "";


    }

    protected void OnButton3Activated(object sender, EventArgs e)
    {
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        // Cerrar Ventana
        Application.Quit();
    }
}
