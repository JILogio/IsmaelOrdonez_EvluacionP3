﻿using IsmaelOrdonez_EvluacionP3.Views;

namespace IsmaelOrdonez_EvluacionP3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//Routing.RegisterRoute("index", typeof());
		Routing.RegisterRoute("search", typeof(SearchItemPage));

    }
}
