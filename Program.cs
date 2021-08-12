using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

using Tweetinvi.Core.Interfaces.Streaminvi;
using Tweetinvi.Json;


namespace TwitterAPI_app
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TwitterCredentials.SetCredentials("xx", "xx", "xx", "xx");
            //Auth.SetUserCredentials("WC6cMoZsypasL2qOUhnljYwt8", "Mt5CYEOegfWMMFJbYWpO7rLmys417L4ewNx6ZsQmKD5JrkAYEe", "1422513092160757761-Uha4ZY4La0AXoG0FzpxkMPOyCRWt9Z", "6uvWzKJ14YnF18sLRw1PhVV0ltJSxH14IlwMhgkOrrBYy");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTwitterPost());
        }
    }
}
