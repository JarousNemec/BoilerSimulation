using System.CodeDom.Compiler;

namespace SimulaceBojleru;

public class Bojler
{
    public double Temp { get; set; }
    public double Level { get; set; }

    public bool BoilerManual { get; set; }
    public bool HeaterIsOn { get; set; }

    public Bojler(double initTemp, double initLevel)
    {
        Temp = initTemp;
        Level = initLevel;
    }

    public void Paint(Graphics g)
    {
        Color c = Color.Aqua;
        if (Temp < 30)
            c = Color.Blue;
        else if (Temp >= 30 && Temp < 55)
            c = Color.Yellow;
        else if (Temp >= 50 && Temp < 65)
            c = Color.Orange;
        else
            c = Color.Red;
        
        var brush = new SolidBrush(c);
        var pen = new Pen(Color.Black, 10);
        g.FillRectangle(brush, 200,20,150,300);
        g.DrawRectangle(pen, 200,20,150,300);
    }
}