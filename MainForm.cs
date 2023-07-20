using Newtonsoft.Json;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;

namespace SatDumpLauncher
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			StatLabel.Text = "";
			if ( Properties.Settings.Default.AppPath != string.Empty )
			{
				Environment.CurrentDirectory = Properties.Settings.Default.AppPath;
			}
		}

		private void LaunchButton_Click( object sender, EventArgs e )
		{
			LaunchButton.Enabled = false;
			if ( UpdateCheck.Checked || !File.Exists( "satdump-ui.exe" ) )
			{
				if ( CleanCheck.Checked )
				{
					CleanInstall();
				}
				DownloadUpdate();
				Process.Start( "satdump-ui.exe" );
				Application.Exit();
			}

		}

		private void DownloadUpdate()
		{
			StatLabel.Text = "Downloading update...";
			using ( WebClient client = new() )
			{
				client.Headers.Add( "User-Agent: Other" );
				string url = "";
				if ( NightlyCheck.Checked )
				{
					url = "https://github.com/SatDump/SatDump/releases/download/nightly/SatDump-Windows_x64_MSVC.zip";
				}
				else
				{
					try
					{
						string json = client.DownloadString( "https://api.github.com/repos/SatDump/SatDump/tags" );
						dynamic versions = JsonConvert.DeserializeObject( json );
						url = $"https://github.com/SatDump/SatDump/releases/latest/download/SatDump_Windows_x64_{versions[1].name}.zip";
					}
					catch ( Exception e )
					{
						var msg = MessageBox.Show( "Something went wrong while downloading SatDump version info: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
						if ( msg == DialogResult.OK ) Application.Exit();
					}
				}

				try
				{
					client.DownloadFile( url, "SatDump.zip" );
				}
				catch ( Exception e )
				{
					var msg = MessageBox.Show( "Something went wrong while downloading the update: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if ( msg == DialogResult.OK ) Application.Exit();
				}

				try
				{
					StatLabel.Text = "Installing update...";
					ZipFile.ExtractToDirectory( "SatDump.zip", Environment.CurrentDirectory );
				}
				catch ( UnauthorizedAccessException )
				{
					var msg = MessageBox.Show( "Couldn't install the update. Try restarting the launcher with admin privileges.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if ( msg == DialogResult.OK ) Application.Exit();
				}
				catch ( Exception e )
				{
					var msg = MessageBox.Show( "Something went wrong while installing the update: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if ( msg == DialogResult.OK ) Application.Exit();
				}
			}
		}

		private void CleanInstall()
		{
			DirectoryInfo d = new( Environment.CurrentDirectory );
			foreach ( FileInfo file in d.GetFiles() )
			{
				if ( file.Name == "SatDumpLauncher.exe" ) continue;
				file.Delete();
			}
			foreach ( DirectoryInfo dir in d.GetDirectories() )
			{
				dir.Delete( true );
			}
		}

		private void PathButton_Click( object sender, EventArgs e )
		{
			FolderBrowserDialog dialog = new();
			if ( dialog.ShowDialog() == DialogResult.OK )
			{
				Environment.CurrentDirectory = dialog.SelectedPath;
				Properties.Settings.Default.AppPath = dialog.SelectedPath;
			}
		}
	}
}
