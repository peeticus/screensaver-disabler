# Windows ScreenSaver Disabler

Does your organization enforce a policy of password protected screensaver kicking-in
every five minutes, and you can't change it? If so, this utility is for you.

Some programs like the Windows Media Player, or PowerPoint in presentation mode 
prevent triggering the screensaver. With good reason. But you may be doing 
something else like reading documents on the screen while taking hand notes, or 
demoing something and you want to prevent the screen-saver-password disruptions.

Look to the source code to integrate this functionality in your own applications.
Please take a look to the win32 API function [SetThreadExecutionState](https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setthreadexecutionstate).


        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
		

This program is modified from the original in the following ways:
* .Net 5
* Runs as a tray icon app
* Has an option to auto-start.
