namespace SatDumpLauncher
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run( new MainForm() );
			Properties.Settings.Default.Save();
		}
	}
}
