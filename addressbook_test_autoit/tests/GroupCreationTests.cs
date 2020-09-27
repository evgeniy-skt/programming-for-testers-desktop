using NUnit.Framework;

namespace addressbook_test_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestsBase
    {
        [Test]
        public void TestGroupCreation()
        {
            var oldGroups = app.Groups.GetGroupList();
            var newGroup = new GroupData {Name = "Test"};
            app.Groups.Add(newGroup);
            var newGroups = app.Groups.GetGroupList();
            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}