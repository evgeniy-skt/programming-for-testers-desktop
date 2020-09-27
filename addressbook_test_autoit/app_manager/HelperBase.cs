namespace addressbook_test_autoit
{
    public class HelperBase
    {
        protected AppManager _appManager;
        protected string WIN_TITLE;
        protected AutoItX3.Interop.AutoItX3 _aux;

        protected HelperBase(AppManager appManager)
        {
            _appManager = appManager;
            WIN_TITLE = AppManager.WIN_TITLE;
            _aux = AppManager.Aux;
        }
    }
}