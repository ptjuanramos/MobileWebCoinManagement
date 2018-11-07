using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MobileWebCoinManagement.Models {
    class LoginInformation {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Grant_type { get; set; }
    }
}