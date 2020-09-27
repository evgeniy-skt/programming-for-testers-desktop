namespace addressbook_test_autoit
{
    public class AppManager
    {
        public static string WIN_TITLE = "Free Address Book";

        public AppManager()
        {
            Aux.Run(@"c:\Users\e.ivanchenko\AddressBookNative4\AddressBook.exe", "", Aux.SW_SHOW);
            Aux.WinWait(WIN_TITLE);
            Aux.WinActivate(WIN_TITLE);
            Aux.WinWaitActive(WIN_TITLE);

            new GroupHelper(this);
        }

        public static void Stop()
        {
            Aux.ControlClick("Free Address Book", "", "WindowsForms10.BUTTON.app.0.62e44910");
        }

        public GroupHelper Groups { get; }
        public static global::AutoItX3.Interop.AutoItX3 Aux { get; set; }
    }
}