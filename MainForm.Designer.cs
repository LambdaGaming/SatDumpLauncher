namespace SatDumpLauncher
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			LaunchButton = new Button();
			SuspendLayout();
			// 
			// LaunchButton
			// 
			LaunchButton.BackColor = Color.FromArgb(         68  ,         68  ,         68   );
			LaunchButton.Dock = DockStyle.Bottom;
			LaunchButton.FlatAppearance.BorderSize = 0;
			LaunchButton.FlatStyle = FlatStyle.Flat;
			LaunchButton.Font = new Font( "Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point );
			LaunchButton.ForeColor = Color.White;
			LaunchButton.Location = new Point( 0, 123 );
			LaunchButton.Name = "LaunchButton";
			LaunchButton.Size = new Size( 422, 32 );
			LaunchButton.TabIndex = 0;
			LaunchButton.Text = "LAUNCH";
			LaunchButton.UseVisualStyleBackColor = false;
			LaunchButton.Click += LaunchButton_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(         17  ,         17  ,         17   );
			ClientSize = new Size( 422, 155 );
			Controls.Add( LaunchButton );
			Name = "MainForm";
			Text = "SatDump Launcher";
			ResumeLayout( false );
		}

		#endregion

		private Button LaunchButton;
	}
}