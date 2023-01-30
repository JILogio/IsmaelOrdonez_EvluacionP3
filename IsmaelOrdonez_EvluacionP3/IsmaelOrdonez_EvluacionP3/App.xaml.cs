using IsmaelOrdonez_EvluacionP3.Data;

namespace IsmaelOrdonez_EvluacionP3;

public partial class App : Application
{
	public static ApiBDD apiRepo { get; private set; }
    public App(ApiBDD repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		apiRepo = repo;
	}
}
