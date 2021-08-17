using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace TwitterAPI_app
{
    public partial class Followers : Form
    {
        //Twitter認証用セッション変数(sampleAPI_app)
        private string api_key = "w0awBK3aTPitMJw1pYw2LjBnz";
        private string api_secret_key = "uAut9ntk8UX5e2aVudrW0riACCkxsPGQ5fEHJ0QdKJs5DiA4qH";
        private string access_token = "1422513092160757761-16w9PQ06I7XNk4CT0PjOLL6zixIuOz";
        private string access_token_secret = "KA9qBamGlNHR1FR1OdloE2wbltv1UkuBde8gROVT6F6nJ";

        public Followers()
        {
            //認証処理
            InitializeComponent();
            Auth.SetUserCredentials(api_key, api_secret_key, access_token, access_token_secret);
        }

        private void Followers_Load(object sender, EventArgs e)
        {
            var user = User.GetAuthenticatedUser();                 //ユーザーの取得
            var getFollowers = User.GetFollowers(user.ScreenName);  //フォロワーオブジェクトの取得


            foreach(var tweetieBird in getFollowers)
            {
                PictureBox profilePic = new PictureBox(); //PictureBoxインスタンス生成
                Label getFollowerName = new Label();      //Labelインスタンス生成

                //FlowLayoutPanelに画像を追加する処理
                flowLayoutPanel1.Controls.Add(profilePic);
                flowLayoutPanel1.Controls.Add(getFollowerName);

                getFollowerName.Text = tweetieBird.ScreenName;
                getFollowerName.ForeColor = Color.Blue;

                //プロフィール画像のレイアウトを調整
                profilePic.Width = 60;
                profilePic.Height = 60;
                profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                profilePic.BorderStyle = BorderStyle.FixedSingle;

                //フォロワーのプロフィール画像を表示する処理
                profilePic.ImageLocation = tweetieBird.ProfileImageUrl;
            }
        }
    }
}
