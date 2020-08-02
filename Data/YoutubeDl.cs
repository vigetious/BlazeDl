using System;
using System.Diagnostics;

namespace blazor_electron_youtubedl.Data {
    public class YoutubeDl {

        public static void runYoutubeDl(Basic basic) {
            var proc = new Process() {
                StartInfo = new ProcessStartInfo {
                    FileName = "youtube-dl",
                    Arguments = $"-o {basic.Directory}test {basic.VideoUrl}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
    }
}