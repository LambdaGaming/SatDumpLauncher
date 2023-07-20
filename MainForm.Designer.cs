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
			LaunchButton.BackColor = Color.FromArgb(         68  ,         68  ,         68   );
			LaunchButton.Dock = DockStyle.Bottom;
			LaunchButton.FlatAppearance.BorderSize = 0;
			LaunchButton.FlatStyle = FlatStyle.Flat;
			LaunchButton.Font = new Font( "Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point );
			LaunchButton.ForeColor = Color.White;
			LaunchButton.Location = new Point( 0, 130 );
			LaunchButton.Name = "LaunchButton";
			LaunchButton.Size = new Size( 343, 52 );
			LaunchButton.TabIndex = 0;
			LaunchButton.Text = "LAUNCH";
			LaunchButton.UseVisualStyleBackColor = false;
			LaunchButton.Click += LaunchButton_Click;
			// 
			// NightlyCheck
			// 
			NightlyCheck.AutoSize = true;
			NightlyCheck.Checked = true;
			NightlyCheck.CheckState = CheckState.Checked;
			NightlyCheck.FlatStyle = FlatStyle.Flat;
			NightlyCheck.ForeColor = Color.White;
			NightlyCheck.Location = new Point( 12, 42 );
			NightlyCheck.Name = "NightlyCheck";
			NightlyCheck.Size = new Size( 147, 24 );
			NightlyCheck.TabIndex = 1;
			NightlyCheck.Text = "Use Nightly Builds";
			NightlyCheck.UseVisualStyleBackColor = true;
			// 
			// StatLabel
			// 
			StatLabel.AutoSize = true;
			StatLabel.Dock = DockStyle.Bottom;
			StatLabel.ForeColor = Color.White;
			StatLabel.Location = new Point( 0, 110 );
			StatLabel.Name = "StatLabel";
			StatLabel.Size = new Size( 35, 20 );
			StatLabel.TabIndex = 2;
			StatLabel.Text = "Test";
			// 
			// CleanCheck
			// 
			CleanCheck.AutoSize = true;
			CleanCheck.FlatStyle = FlatStyle.Flat;
			CleanCheck.ForeColor = Color.White;
			CleanCheck.Location = new Point( 12, 72 );
			CleanCheck.Name = "CleanCheck";
			CleanCheck.Size = new Size( 107, 24 );
			CleanCheck.TabIndex = 3;
			CleanCheck.Text = "Clean Install";
			CleanCheck.UseVisualStyleBackColor = true;
			// 
			// UpdateCheck
			// 
			UpdateCheck.AutoSize = true;
			UpdateCheck.FlatStyle = FlatStyle.Flat;
			UpdateCheck.ForeColor = Color.White;
			UpdateCheck.Location = new Point( 12, 12 );
			UpdateCheck.Name = "UpdateCheck";
			UpdateCheck.Size = new Size( 150, 24 );
			UpdateCheck.TabIndex = 4;
			UpdateCheck.Text = "Check For Updates";
			UpdateCheck.UseVisualStyleBackColor = true;
			// 
			// PathButton
			// 
			PathButton.BackColor = Color.FromArgb(         68  ,         68  ,         68   );
			PathButton.FlatAppearance.BorderSize = 0;
			PathButton.FlatStyle = FlatStyle.Flat;
			PathButton.ForeColor = Color.White;
			PathButton.Location = new Point( 204, 40 );
			PathButton.Name = "PathButton";
			PathButton.Size = new Size( 127, 29 );
			PathButton.TabIndex = 5;
			PathButton.Text = "Browse For Path";
			PathButton.UseVisualStyleBackColor = false;
			PathButton.Click += PathButton_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(         17  ,         17  ,         17   );
			ClientSize = new Size( 343, 182 );
			Controls.Add( PathButton );
			Controls.Add( UpdateCheck );
			Controls.Add( CleanCheck );
			Controls.Add( StatLabel );
			Controls.Add( NightlyCheck );
			Controls.Add( LaunchButton );
			Name = "MainForm";
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