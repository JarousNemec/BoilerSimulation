using System.Timers;
using Timer = System.Timers.Timer;

namespace SimulaceBojleru;

public class Simulation : IDisposable
{
    private const long UPDATE_RATE = 100;

    public delegate void PaintScene(Bathroom bathroom);

    public event PaintScene? OnPaintScene;

    private const int HEATER_POWER = 4000;
    private const int HEAT_CAPACITY_OF_WATER = 4180;
    private const int HEAT_LOSS = -100;
    private readonly Timer _timer;
    public long RunningTime { get; set; } 

    public Bathroom Bathroom { get; private set; }

    public ushort SimulationSpeed { get; set; } = 1;


    public Simulation(Bathroom bathroom)
    {
        Bathroom = bathroom;
        _timer = new Timer();
        RunningTime = 0;
    }

    public void Start()
    {
        _timer.Interval = UPDATE_RATE;
        _timer.Elapsed += Update;
        _timer.Start();
    }

    private void Update(object? sender, ElapsedEventArgs e)
    {
        var frameSimTime = TimeSpan.TicksPerMillisecond * UPDATE_RATE * SimulationSpeed;
        RunningTime += frameSimTime;
        
        Bathroom.BojlerOutputFlow = 0;
        Bathroom.BojlerOutputFlow += Bathroom.Sprcha.HotFlow;
        Bathroom.BojlerOutputFlow += Bathroom.Umyvadlo.HotFlow;

        HeatBojler(HEAT_LOSS, false);
        
        if (Bathroom.BojlerOutputFlow > 0)
        {
            CoolBojler();
        }

        ControlBojler();
        HeatBojler(HEATER_POWER);
        
        OnPaintScene?.Invoke(Bathroom);
    }

    private void CoolBojler()
    {
        double coldWater = SimulationSpeed *((Bathroom.BojlerOutputFlow / 60) / 10);
        double hotWater = Bathroom.Bojler.Level - coldWater;
        Bathroom.Bojler.Temp =
            ((hotWater * HEAT_CAPACITY_OF_WATER * Bathroom.Bojler.Temp) +
             (coldWater * HEAT_CAPACITY_OF_WATER * Bathroom.ColdWaterTemp)) / ((hotWater *
                HEAT_CAPACITY_OF_WATER) + (coldWater * HEAT_CAPACITY_OF_WATER));
    }

    private void HeatBojler(int power, bool fuse = true)
    {
        var Q = (long)(SimulationSpeed * ((double)UPDATE_RATE/1000) * power);
        double waterMass = Bathroom.Bojler.Level;
        double futureBojlerTemp =
            (Q + waterMass * HEAT_CAPACITY_OF_WATER * Bathroom.Bojler.Temp) /
            (waterMass * HEAT_CAPACITY_OF_WATER);
        if (Bathroom.Bojler.HeaterIsOn || !fuse)
        {
            Bathroom.Bojler.Temp = futureBojlerTemp;
            UpdateValve(Bathroom.Umyvadlo);
            UpdateValve(Bathroom.Sprcha);
        }
    }

    private void ControlBojler()
    {
        if (Bathroom.Bojler.Temp > 80)
            Bathroom.Bojler.HeaterIsOn = false;
        else if (Bathroom.Bojler.Temp >= 70 && !Bathroom.Bojler.BoilerManual)
            Bathroom.Bojler.HeaterIsOn = false;
        else if (Bathroom.Bojler.BoilerManual)
            Bathroom.Bojler.HeaterIsOn = true;
        else if ((Bathroom.Bojler.HeaterIsOn && Bathroom.Bojler.Temp >= 50 && Bathroom.Bojler.Temp <= 70))
            Bathroom.Bojler.HeaterIsOn = true;
        else if ((!Bathroom.Bojler.HeaterIsOn && Bathroom.Bojler.Temp >= 50 && Bathroom.Bojler.Temp <= 70))
            Bathroom.Bojler.HeaterIsOn = false;
        else if (Bathroom.Bojler.Temp < 50)
            Bathroom.Bojler.HeaterIsOn = true;
    }

    public void UpdateBojlerManualControlState(bool state)
    {
        Bathroom.Bojler.BoilerManual = state;
    }

    public void UpdateSprchaTemp(double percentage)
    {
        var valve = Bathroom.Sprcha;
        valve.Percentage = percentage;
        UpdateValve(valve);
    }

    public void UpdateSprchaFlow(double flow)
    {
        var valve = Bathroom.Sprcha;
        valve.Flow = flow;
        UpdateValve(valve);
    }

    public void UpdateUmyvadloTemp(double percentage)
    {
        var valve = Bathroom.Umyvadlo;
        valve.Percentage = percentage;
        UpdateValve(valve);
    }

    public void UpdateUmyvadloFlow(double flow)
    {
        var valve = Bathroom.Umyvadlo;
        valve.Flow = flow;
        UpdateValve(valve);
    }

    private void UpdateValve(Valve valve)
    {
        valve.ColdFlow = valve.Flow * (1 - valve.Percentage);
        valve.HotFlow = valve.Flow * valve.Percentage;
        valve.Temp =
            ((valve.HotFlow * HEAT_CAPACITY_OF_WATER * Bathroom.Bojler.Temp) +
             (valve.ColdFlow * HEAT_CAPACITY_OF_WATER * Bathroom.ColdWaterTemp)) / ((valve.HotFlow *
                HEAT_CAPACITY_OF_WATER) + (valve.ColdFlow * HEAT_CAPACITY_OF_WATER));
        valve.Temp = double.IsNaN(valve.Temp)? 0: valve.Temp;
    }

    public void UpdateSpeed(ushort speed)
    {
        SimulationSpeed = speed;
    }

    public void Dispose()
    {
        _timer.Stop();
        _timer.Dispose();
    }
}