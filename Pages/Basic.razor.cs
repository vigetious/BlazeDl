using System;
using blazor_electron_youtubedl.Data;
using Microsoft.AspNetCore.Components;

namespace blazor_electron_youtubedl.Pages {
    public partial class Basic: ComponentBase {
        private Data.Basic basic = new Data.Basic();
        private string done { get; set; }

        private void HandleValidSubmit() {
            YoutubeDl.runYoutubeDl(basic);
            done = "Done!";
        }
    }
}