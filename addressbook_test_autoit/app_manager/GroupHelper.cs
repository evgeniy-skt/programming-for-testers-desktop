using System.Collections.Generic;

namespace addressbook_test_autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUP_WIN_TITLE = "Group editor";

        public GroupHelper(AppManager appManager) : base(appManager)
        {
        }

        public List<GroupData> GetGroupList()
        {
            var list = new List<GroupData>();
            OpenGroupDialog();
            var count = _aux.ControlTreeView(GROUP_WIN_TITLE, "", "WindowsForm10.SysTreeView32.app.0.62e4491",
                "GetItemCount", "#0", "");
            for (var i = 0; i < int.Parse(count); i++)
            {
                var item = _aux.ControlTreeView(GROUP_WIN_TITLE, "", "WindowsForm10.SysTreeView32.app.0.62e4491",
                    "GetText", "#0|#" + i, "");
                list.Add(new GroupData()
                {
                    Name = item
                });
            }

            CloseGroupsDialog();
            return list;
        }

        public void Add(GroupData newGroup)
        {
            OpenGroupDialog();
            _aux.ControlClick(WIN_TITLE, "", "WindowsForm10.Button.app.0.62e4493");
            _aux.Send(newGroup.Name);
            _aux.Send("{ENTER}");
            CloseGroupsDialog();
        }

        private void CloseGroupsDialog()
        {
            _aux.ControlClick(WIN_TITLE, "", "WindowsForm10.Button.app.0.62e4494");
        }

        private void OpenGroupDialog()
        {
            _aux.ControlClick(WIN_TITLE, "", "WindowsForm10.Button.app.0.62e44912");
            _aux.WinWait(GROUP_WIN_TITLE);
        }
    }
}