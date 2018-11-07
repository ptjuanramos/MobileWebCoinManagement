using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileWebCoinManagement.Models;

namespace MobileWebCoinManagement.Services {
    class AccountService {
        private const String API_LOGIN_ENDPOINT = "localhost:49304/Api/Account/Login";

        public String Login(String username, String password) {
            HttpClient httpClient = new HttpClient();
        }

    }
}