namespace MauiApp1;
public partial class MainPage : ContentPage
{
    public MainPage()
	{
        InitializeComponent();
        var timer = new System.Timers.Timer(1000);

        timer.Elapsed += (sender, e) =>
        {

            if (DateTime.Now.Second / 5.0 == 0)
            {
                sec.EnableAnimation = false;
            }

            if ((DateTime.Now.Minute / 5.0) + (DateTime.Now.Second / 360.0) == 0)
            {
                min.EnableAnimation = false;
            }

            if ((DateTime.Now.Hour % 12) + (DateTime.Now.Minute / 60.0) == 0)
            {
                hou.EnableAnimation = false;
            }

            sec.Value = DateTime.Now.Second / 5.0;
            min.Value = (DateTime.Now.Minute / 5.0) + (DateTime.Now.Second / 360.0);
            hou.Value = (DateTime.Now.Hour % 12) + (DateTime.Now.Minute / 60.0);

            if (sec.Value == 0)
            {
                sec.EnableAnimation = true;
            }

            if (min.Value == 0)
            {
                min.EnableAnimation = true;
            }

            if (hou.Value == 0)
            {
                hou.EnableAnimation = true;
            }

        };

        timer.Start();

    }

}

