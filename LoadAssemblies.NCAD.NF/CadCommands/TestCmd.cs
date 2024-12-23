using HostMgd.ApplicationServices;

 
using LoadAssemblies.Views.Windows;

using Teigha.Runtime;

namespace LoadAssemblies.NCAD.CadCommands
{
    public static class TestCmd
    {
        [CommandMethod("test-aio")]
        public static void TestAllInOneCommand()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            if (doc == null)
            {
                return;
            }

            TestWindow win = new TestWindow();
            Application.ShowModalWindow(win);
        }
    }
}
