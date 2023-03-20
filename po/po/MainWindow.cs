using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
   
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        btnAceptar.Clicked += BtnAceptar_Clicked;
    }

    private void BtnAceptar_Clicked(object sender, EventArgs e)
    {
        string nombre = entry1.Text;

        Dato.Text = $"Bienvenido {nombre}";
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)

    {
        Application.Quit();
        a.RetVal = true;
    }
}
