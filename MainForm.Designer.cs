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
			NightlyCheck = new CheckBox();
			StatLabel = new Label();
			CleanCheck = new CheckBox();
			UpdateCheck = new CheckBox();
			PathButton = new Button();
			SuspendLayout();
			// 
			// LaunchButton
			// 
			LaunchButton.BackColor = Color.FromArgb(       68,       68,       68 );
			LaunchButton.Dock = DockStyle.Bottom;
			LaunchButton.FlatAppearance.BorderSize = 0;
			LaunchButton.FlatStyle = FlatStyle.Flat;
			LaunchButton.Font = new Font( "Segoe UI", 16F );
			LaunchButton.ForeColor = Color.White;
			LaunchButton.Location = new Point( 0, 97 );
			LaunchButton.Margin = new Padding( 3, 2, 3, 2 );
			LaunchButton.Name = "LaunchButton";
			LaunchButton.Size = new Size( 300, 39 );
			LaunchButton.TabIndex = 0;
			LaunchButton.Text = "LAUNCH";
			LaunchButton.UseVisualStyleBackColor = false;
			LaunchButton.Click +=  LaunchButton_Click ;
			// 
			// NightlyCheck
			// 
			NightlyCheck.AutoSize = true;
			NightlyCheck.Checked = true;
			NightlyCheck.CheckState = CheckState.Checked;
			NightlyCheck.FlatStyle = FlatStyle.Flat;
			NightlyCheck.ForeColor = Color.White;
			NightlyCheck.Location = new Point( 10, 32 );
			NightlyCheck.Margin = new Padding( 3, 2, 3, 2 );
			NightlyCheck.Name = "NightlyCheck";
			NightlyCheck.Size = new Size( 119, 19 );
			NightlyCheck.TabIndex = 1;
			NightlyCheck.Text = "Use Nightly Builds";
			NightlyCheck.UseVisualStyleBackColor = true;
			// 
			// StatLabel
			// 
			StatLabel.AutoSize = true;
			StatLabel.Dock = DockStyle.Bottom;
			StatLabel.ForeColor = Color.White;
			StatLabel.Location = new Point( 0, 82 );
			StatLabel.Name = "StatLabel";
			StatLabel.Size = new Size( 27, 15 );
			StatLabel.TabIndex = 2;
			StatLabel.Text = "Test";
			// 
			// CleanCheck
			// 
			CleanCheck.AutoSize = true;
			CleanCheck.FlatStyle = FlatStyle.Flat;
			CleanCheck.ForeColor = Color.White;
			CleanCheck.Location = new Point( 10, 54 );
			CleanCheck.Margin = new Padding( 3, 2, 3, 2 );
			CleanCheck.Name = "CleanCheck";
			CleanCheck.Size = new Size( 87, 19 );
			CleanCheck.TabIndex = 3;
			CleanCheck.Text = "Clean Install";
			CleanCheck.UseVisualStyleBackColor = true;
			// 
			// UpdateCheck
			// 
			UpdateCheck.AutoSize = true;
			UpdateCheck.FlatStyle = FlatStyle.Flat;
			UpdateCheck.ForeColor = Color.White;
			UpdateCheck.Location = new Point( 10, 9 );
			UpdateCheck.Margin = new Padding( 3, 2, 3, 2 );
			UpdateCheck.Name = "UpdateCheck";
			UpdateCheck.Size = new Size( 113, 19 );
			UpdateCheck.TabIndex = 4;
			UpdateCheck.Text = "Update SatDump";
			UpdateCheck.UseVisualStyleBackColor = true;
			// 
			// PathButton
			// 
			PathButton.BackColor = Color.FromArgb(       68,       68,       68 );
			PathButton.FlatAppearance.BorderSize = 0;
			PathButton.FlatStyle = FlatStyle.Flat;
			PathButton.ForeColor = Color.White;
			PathButton.Location = new Point( 178, 30 );
			PathButton.Margin = new Padding( 3, 2, 3, 2 );
			PathButton.Name = "PathButton";
			PathButton.Size = new Size( 111, 22 );
			PathButton.TabIndex = 5;
			PathButton.Text = "Browse For Path";
			PathButton.UseVisualStyleBackColor = false;
			PathButton.Click +=  PathButton_Click ;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(       17,       17,       17 );
			ClientSize = new Size( 300, 136 );
			Controls.Add( PathButton );
			Controls.Add( UpdateCheck );
			Controls.Add( CleanCheck );
			Controls.Add( StatLabel );
			Controls.Add( NightlyCheck );
			Controls.Add( LaunchButton );
			Margin = new Padding( 3, 2, 3, 2 );
			Name = "MainForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SatDump Launcher";
			ResumeLayout( false );
			PerformLayout();
		}

		#endregion

		private Button LaunchButton;
		private CheckBox NightlyCheck;
		private Label StatLabel;
		private CheckBox CleanCheck;
		private CheckBox UpdateCheck;
		private Button PathButton;
	}
}