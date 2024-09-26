namespace SimulaceBojleru;

public class Bathroom
{
    public Bojler Bojler { get; set; }
    public Valve Sprcha { get; set; }
    public Valve Umyvadlo { get; set; }

    public double BojlerOutputFlow { get; set; } = 0;
    public double ColdWaterTemp { get; private set; }
    public Bathroom(double bojlerTemp, double bojlerLevel, int valveTempSprcha, int valveFlowSprcha, int valveTempUmyvadlo, int valveFlowUmyvadlo, double coldWaterTemp)
    {
        Bojler = new Bojler(bojlerTemp, bojlerLevel);
        Sprcha = new Valve();
        Umyvadlo = new Valve();
        Sprcha.Temp = valveTempSprcha;
        Sprcha.Flow = valveFlowSprcha;
        Umyvadlo.Temp = valveTempUmyvadlo;
        Umyvadlo.Flow = valveFlowUmyvadlo;
        ColdWaterTemp = coldWaterTemp;
    }

    public void Paint(Graphics g)
    {
        Bojler.Paint(g);
    }
}