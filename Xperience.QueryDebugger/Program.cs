using System;
using CMS.DataEngine;
using CMS.Membership;

namespace Xperience.QueryDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            CMSApplication.Init();

            new ObjectQuery<UserSettingsInfo>()
                .From(new QuerySource(new QuerySourceTable("CMS_UserSettings", "US")))
                .DebugQuery("From")
                .Source(s => s.Join(new QuerySourceTable(
                    "CMS_User", "U"),
                    "US.UserSettingsUserID",
                    "U.UserID"))
                .DebugQuery("Join")
                .WhereLike("Email", "%@localhost.local")
                .DebugQuery("Like Email")
                .WhereTrue("UserEnabled")
                .DebugQuery("User Enabled");
        }
    }
}
