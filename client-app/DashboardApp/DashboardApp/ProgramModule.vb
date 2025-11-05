Module ProgramModule
    Public Sub Main()
        ' Create and show the splash screen
        Dim splashScreen As New frmSplashScreen()
        splashScreen.Show()
        'splashScreen.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly

        ' Perform your loading operations here (e.g., database connection, data loading)
        ' For a simple delay, you can use Thread.Sleep, but it blocks the UI thread.
        System.Threading.Thread.Sleep(3000) ' Example: show for 3 seconds

        ' Hide the splash screen after the main form is shown
        splashScreen.Hide()

        ' Create and show the main form
        Dim mainForm As New frmLogin()
        mainForm.Show()
        mainForm.SetDesktopLocation(
            (Screen.PrimaryScreen.WorkingArea.Width - mainForm.Width) \ 2,
            (Screen.PrimaryScreen.WorkingArea.Height - mainForm.Height) \ 2)

        ' Run the application context (optional depending on project type, but common in manual control)
        Application.Run(mainForm)
    End Sub
End Module
