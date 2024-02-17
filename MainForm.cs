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

			ToolTip tooltip = new();
			tooltip.SetToolTip( UpdateCheck, "Automatically download and install the latest SatDump version." );
			tooltip.SetToolTip( NightlyCheck, "Download latest nightly build instead of latest release build." );
			tooltip.SetToolTip( CleanCheck, "Delete everything from the SatDump folder before installing the new version." );
			tooltip.SetToolTip( PathButton, "Browse for path containing the SatDump installation." );

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
			}
			Process.Start( "satdump-ui.exe" );
			Application.Exit();
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
					url = "https://github.com/SatDump/SatDump/releases/download/nightly/SatDump-Windows_x64_Portable.zip";
				}
				else
				{
					url = "https://github.com/SatDump/SatDump/releases/latest/download/SatDump-Windows_x64_Portable.zip";
				}

				try
				{
					client.DownloadFile( url, "SatDump.zip" );
				}
				catch ( Exception e )
				{
					var msg = MessageBox.Show( "Couldn't download the update. Try restarting the launcher with admin privileges. " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if ( msg == DialogResult.OK ) Application.Exit();
				}

				try
				{
					StatLabel.Text = "Installing update...";
					ZipFile.ExtractToDirectory( "SatDump.zip", Environment.CurrentDirectory, true );
				}
				catch ( Exception e )
				{
					var msg = MessageBox.Show( "Couldn't install the update. Try restarting the launcher with admin privileges. " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if ( msg == DialogResult.OK ) Application.Exit();
				}
				File.Delete( "SatDump.zip" );
			}
		}

		private void CleanInstall()
		{
			DirectoryInfo d = new( Environment.CurrentDirectory );
			foreach ( FileInfo file in d.GetFiles() )
			{
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
