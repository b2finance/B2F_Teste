using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2F_Teste
{
    public static class Squirrel
    {
        public static async Task TryApplyUpdates()
        {
            var currentExe = Process.GetCurrentProcess().MainModule.FileName;
            var updateExe = Path.Combine(Path.GetDirectoryName(currentExe), "Update.exe");
            if (!File.Exists(updateExe)) return;

            // Feed aponta para GitHub, ex: https://github.com/SeuUser/SeuRepo/releases
            var feedUrl = "https://github.com/b2finance/B2F_Teste/releases";
            var start = Process.Start(updateExe, $"--update \"{feedUrl}\"");
            await start.WaitForExitAsync();
        }
    }
}
