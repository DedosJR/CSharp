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
        Double c, f;
        c = double.Parse(entry1.Text);
        //Proceso
        f = (c * 1.8) + 32;
        //Salida
        entry2.Text = f.ToString();

    }
}
