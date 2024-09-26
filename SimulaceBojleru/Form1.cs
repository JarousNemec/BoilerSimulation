namespace SimulaceBojleru;

public partial class Form1 : Form
{
    private Simulation _simulation;

    public Form1()
    {
        InitializeComponent();
    }

    private void _tbarSprchaTemp_ValueChanged(object sender, EventArgs e)
    {
        _simulation.UpdateSprchaTemp(_tbarSprchaTemp.Value / (double)100);
    }

    private void _tbarSprchaFlow_ValueChanged(object sender, EventArgs e)
    {
        _simulation.UpdateSprchaFlow(_tbarSprchaFlow.Value / (double)100);
    }

    private void _tbarUmyvadloTemp_ValueChanged(object sender, EventArgs e)
    {
        _simulation.UpdateUmyvadloTemp(_tbarUmyvadloTemp.Value / (double)100);
    }

    private void _tbarUmyvadloFlow_ValueChanged(object sender, EventArgs e)
    {
        _simulation.UpdateUmyvadloFlow(_tbarUmyvadloFlow.Value / (double)100);
    }

    private void _chboxHeater_CheckStateChanged(object sender, EventArgs e)
    {
        _simulation.UpdateBojlerManualControlState(_chboxHeater.Checked);
    }

    private void _tbarSpeed_ValueChanged(object sender, EventArgs e)
    {
        _simulation.UpdateSpeed((ushort)_tbarSpeed.Value);
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        _simulation.Bathroom.Paint(g);
        _lblLevel.Text = _simulation.Bathroom.Bojler.Level + " L";
        _lblTemp.Text = Math.Round(_simulation.Bathroom.Bojler.Temp, MidpointRounding.ToZero) + " C";
        _lblSprchaFlow.Text = Math.Round(_simulation.Bathroom.Sprcha.Flow, 0) + " l/min";
        _lblSprchaTemp.Text = Math.Round(_simulation.Bathroom.Sprcha.Temp, 0) + " C";
        _lblUmyvadloFlow.Text = Math.Round(_simulation.Bathroom.Umyvadlo.Flow, 0) + " l/min";
        _lblUmyvadloTemp.Text = Math.Round(_simulation.Bathroom.Umyvadlo.Temp, 0) + " C";
        _lblControl.Text = _simulation.Bathroom.Bojler.BoilerManual ? "Man" : "Auto";
        _lblHeater.Text = _simulation.Bathroom.Bojler.HeaterIsOn ? "On" : "Off";
        _lblRunningTime.Text = new DateTime(_simulation.RunningTime).ToString("HH:mm:ss");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var coldWater = 10;
        double bojlerHeightInDecimeters = 20;
        double bojlerWidthInDecimeters = 5;

        double capacity = CalculateCapacity(bojlerHeightInDecimeters, bojlerWidthInDecimeters);

        var bathroom = new Bathroom(coldWater, capacity, _tbarSprchaTemp.Value, _tbarSprchaFlow.Value,
            _tbarUmyvadloTemp.Value, _tbarUmyvadloFlow.Value, coldWater);
        _simulation = new Simulation(bathroom);
        _simulation.OnPaintScene += SimulationOnOnPaintScene;
        _simulation.Start();
    }

    private void SimulationOnOnPaintScene(Bathroom bathroom)
    {
        Invalidate();
    }

    private double CalculateCapacity(double height, double width)
    {
        return height * (3.14 * Math.Pow(width / 2, 2));
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _simulation.Dispose();
    }
}