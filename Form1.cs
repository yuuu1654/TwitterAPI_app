using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;

namespace TwitterAPI_app
{
    //API Key →　w0awBK3aTPitMJw1pYw2LjBnz
    //API Secret Key  →　uAut9ntk8UX5e2aVudrW0riACCkxsPGQ5fEHJ0QdKJs5DiA4qH
    //Access Token　→　1422513092160757761-16w9PQ06I7XNk4CT0PjOLL6zixIuOz
    //Access Token Secret　→　KA9qBamGlNHR1FR1OdloE2wbltv1UkuBde8gROVT6F6nJ

    public partial class FormTwitterPost : Form
    {
        //Twitter認証用セッション変数(sampleAPI_app)
        private string api_key = "w0awBK3aTPitMJw1pYw2LjBnz"; 
        private string api_secret_key = "uAut9ntk8UX5e2aVudrW0riACCkxsPGQ5fEHJ0QdKJs5DiA4qH";
        private string access_token = "1422513092160757761-16w9PQ06I7XNk4CT0PjOLL6zixIuOz";
        private string access_token_secret = "KA9qBamGlNHR1FR1OdloE2wbltv1UkuBde8gROVT6F6nJ";

        /**/
        ITwitterCredentials temp;

        //コンストラクタ
        public FormTwitterPost()
        {
            InitializeComponent();
            temp = Auth.SetUserCredentials(api_key, api_secret_key, access_token, access_token_secret);
            bool result = temp.AreSetupForUserAuthentication();

        }

        private void FormTwitterPost_Load(object sender, EventArgs e)
        {
            //フォームを読み込んだ時の認証処理
            var user = User.GetAuthenticatedUser(); //ユーザーの取得
            var getTweets = Timeline.GetUserTimeline(user, 10);　//ツイートを取得
            var followers = User.GetFollowers(user.ScreenName); //フォロワーの取得

            profilePic.ImageLocation = user.ProfileImageUrl; //プロフィール画像を取得
            lblName.Text = user.Name;                        //プロフィール名の取得
            lblHander.Text = "@" + user.ScreenName;          //ユーザー名の取得


            //フォロワーの総数を表示させる
            displayFollowers.Text = "View Followers! (" + followers.Count() + ")";

            //取得したツイートを順番に表示させる処理
            foreach(var tweet in getTweets)
            {
                txtTweets.AppendText("-->" + tweet.FullText + " - " + tweet.TweetLocalCreationDate + Environment.NewLine + "__TWEET END__" + Environment.NewLine);
            }
            
        }
        

        //ツイートボタンをクリックしたときの処理
        private  void butTweet_Click(object sender, EventArgs e)
        {
            
            if (lblImage.Text != "")
            {
                byte[] file = File.ReadAllBytes(imgAttach.ImageLocation);
                //Tweet.PublishTweetWithImage(txtTweet.Text, file);
            }
            else
            {
                Tweet.PublishTweet(txtTweet.Text); //タイムラインにツイートを投稿
            }

            MessageBox.Show("ツイートを送信しました");

        }

        private void attachImage_Click(object sender, EventArgs e)
        {
            //画像をPictureBox、画像のパスをLabelに反映させる

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            imgAttach.ImageLocation = ofd.FileName;
            lblImage.Text = ofd.FileName;
        }

        private void displayFollowers_Click(object sender, EventArgs e)
        {
            //フォロワーボタンをクリックした時にフォローフォームを呼び出す
            Followers showFollowers = new Followers();
            showFollowers.Show();
        }
    }
}
