using NUnit.Framework;

namespace addressbook_test_autoit
{
    public class TestsBase
    {
        public AppManager app;

        [SetUp]
        public void InitApplication()
        {
            app = new AppManager();
        }

        [TearDown]
        public void StopApplication()
        {
            AppManager.Stop();
        }
    }
}