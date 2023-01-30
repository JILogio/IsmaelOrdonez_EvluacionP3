using IsmaelOrdonez_EvluacionP3.Data;

namespace IsmaelOrdonez_EvluacionP3;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        string dbPath = FileAccessHelper.GetLocalFilePath("api.db3");
        builder.Services.AddSingleton<ApiBDD>(s => ActivatorUtilities.CreateInstance<ApiBDD>(s, dbPath));

        return builder.Build();
	}
}
