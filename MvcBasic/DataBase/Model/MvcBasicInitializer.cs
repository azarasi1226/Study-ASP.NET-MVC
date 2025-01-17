﻿using MvcBasic.DataBase.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcBasic.DataBase.Model
{
    public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            InitializeMember().ForEach(x => context.Members.Add(x));

            #region 記事関係
            var article = new Article
            {
                Url = "http://www.buildinsider.net/web/jquerymobileref",
                Title = "jQuery Mobile逆引きリファレンス",
                Category = CategoryEnum.Reference,
                Description = "jQuery Mobileの基本機能を目的別リファレンスの形式でまとめます。",
                Viewcount = 36452,
                Published = DateTime.Parse("2014-01-09"),
                Released = true
            };
            context.Articles.Add(article);
            context.Comments.Add(new Comment
            {
                Name = "井上鈴子",
                Body = "目的別で探しやすく重宝しています。",
                Updated = DateTime.Parse("2014-06-01"),
                Article = article
            });
            context.Comments.Add(new Comment
            {
                Name = "和田翔太",
                Body = "寸例が載っているのでわかりやすいと思います。",
                Updated = DateTime.Parse("2014-06-11"),
                Article = article
            });

            var article2 = new Article
            {
                Url = "http://codezine.jp/article/corner/518",
                Title = "Bootstrapでレスポンシブでリッチなサイトを構築",
                Category = CategoryEnum.DotNet,
                Description = "ASP.NET MVC5のひな形ページで使用されているBootstrapというフレームワークについて紹介します。",
                Viewcount = 9312,
                Published = DateTime.Parse("2014-05-22"),
                Released = true
            };
            context.Articles.Add(article2);
            context.Comments.Add(new Comment
            {
                Name = "田中三郎",
                Body = "まとめ方が良くてわかりやすかったです。",
                Updated = DateTime.Parse("2014-06-15"),
                Article = article2
            });

            var article3 = new Article
            {
                Url = "http://codezine.jp/article/corner/511",
                Title = "ASP.NET Identity入門",
                Category = CategoryEnum.DotNet,
                Description = "新しい認証、資格管理システムである「ASP.NET Identity」について、どのように使うのか、どんな仕組みで動いているのかを紹介していきます。",
                Viewcount = 8046,
                Published = DateTime.Parse("2014-04-25"),
                Released = true
            };
            context.Articles.Add(article3);
            context.Comments.Add(new Comment
            {
                Name = "和田翔太",
                Body = "自分で調べていて分からなかったところが、分かって良かったです。",
                Updated = DateTime.Parse("2014-07-02"),
                Article = article3
            });

            var article4 = new Article
            {
                Url = "http://codezine.jp/article/corner/513",
                Title = "Amazon Web Servicesによるクラウド超入門",
                Category = CategoryEnum.Cloud,
                Description = "Amazon Web Servicesを使ってクラウドシステム上に簡単なWebシステムを構築していきます。",
                Viewcount = 25687,
                Published = DateTime.Parse("2014-04-25"),
                Released = true
            };
            context.Articles.Add(article4);

            var article5 = new Article
            {
                Url = "http://www.buildinsider.net/web/jqueryuiref",
                Title = "jQuery UI逆引きリファレンス",
                Category = CategoryEnum.Reference,
                Description = "jQuery UIの基本機能を目的別リファレンスの形式でまとめます。",
                Viewcount = 56710,
                Published = DateTime.Parse("2013-07-11"),
                Released = true
            };
            context.Articles.Add(article5);
            context.Comments.Add(new Comment
            {
                Name = "井上鈴子",
                Body = "用例の結果もみられるので、便利です。欲を言うとサンプルコードをダウンロードできるようにしてほしい。",
                Updated = DateTime.Parse("2014-07-01"),
                Article = article5
            });

            var article6 = new Article
            {
                Url = "http://www.wings.msn.to/mvc5",
                Title = "ASP.NET MVC 入門",
                Category = CategoryEnum.DotNet,
                Description = "ASP.NET MVCをこれから始める人のために、詳しく丁寧に段階を追って解説します。",
                Viewcount = 0,
                Published = DateTime.Parse("2015-01-20"),
                Released = false
            };
            context.Articles.Add(article6);

            var article7 = new Article
            {
                Url = "http://www.wings.msn.to/azure",
                Title = "Azure新機能TIPS",
                Category = CategoryEnum.Cloud,
                Description = "Microsoft Azureの新機能についてTIPS形式で、使い方などを解説します。",
                Viewcount = 13469,
                Published = DateTime.Parse("2014-04-25"),
                Released = true
            };
            context.Articles.Add(article7);


            var author1 = new Author
            {
                Name = "山田太郎",
                Email = "taro@wings.msn.to",
                Birth = DateTime.Parse("1970-12-10"),
                Articles = new List<Article> { article, article2, article3, article5, article6 }
            };
            context.Authors.Add(author1);

            var author2 = new Author
            {
                Name = "鈴木久美",
                Email = "kumi@wings.msn.to",
                Birth = DateTime.Parse("1985-11-12"),
                Articles = new List<Article> { article, article4, article7 }
            };
            context.Authors.Add(author2);

            var author3 = new Author
            {
                Name = "佐藤敏夫",
                Email = "toshi@wings.msn.to",
                Birth = DateTime.Parse("1975-05-26"),
                Articles = new List<Article> { article, article2 }
            };
            context.Authors.Add(author3);
            #endregion
            context.SaveChanges();
        }

        private List<Member> InitializeMember()
        {
            return new List<Member>
            {
                new Member
                {
                    Name = "山田リオ",
                    Email = "rio@wings.msn.to",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "ピアノが好きです。"
                },
                new Member
                {
                    Name = "日尾直弘",
                    Email = "naohiro@wings.msn.to",
                    Birth = DateTime.Parse("1975-07-19"),
                    Married = false,
                    Memo = "子供にも優しいお医者さんです。"
                },
                new Member
                {
                    Name = "掛谷直美",
                    Email = "naomi@wings.msn.to",
                    Birth = DateTime.Parse("1985-08-09"),
                    Married = false,
                    Memo = "フラワーアレンジメントを勉強中です"
                },
                new Member
                {
                    Name = "木村次郎",
                    Email = "jiro@wings.msn.to",
                    Birth = DateTime.Parse("1970-12-15"),
                    Married = true,
                    Memo = "山登りが趣味です。休日はよく山へ出かけます。"
                },
                new Member
                {
                    Name = "鈴木恵子",
                    Email = "keiko@wings.msn.to",
                    Birth = DateTime.Parse("1984-11-23"),
                    Married = true,
                    Memo = "子供と一緒にアニメを見るのが好きです。"
                },
                new Member
                {
                    Name = "木村恭平",
                    Email = "kimura@wings.msn.to",
                    Birth = DateTime.Parse("1992-11-30"),
                    Married = false,
                    Memo = "コミックマーケットで出店するのが趣味です。"
                },
                new Member
                {
                    Name = "和田朋子",
                    Email = "wada@wings.msn.to",
                    Birth = DateTime.Parse("2012-11-11"),
                    Married = false,
                    Memo = "野菜を最近食べられるようになりました。"
                },
                new Member
                {
                    Name = "空条承太郎",
                    Email = "zyoutarou@wings.msn.to",
                    Birth = DateTime.Parse("1978-03-03"),
                    Married = true,
                    Memo = "スタープラチナでDIOをぶちのめします"
                },
                new Member
                {
                    Name = "ジョセフ・ジョースター",
                    Email = "zyo-suta-@wings.msn.to",
                    Birth = DateTime.Parse("1943-12-26"),
                    Married = true,
                    Memo = "アメリカの不動産王です。"
                },
                new Member
                {
                    Name = "安藤和樹",
                    Email = "andou@wings.msn.to",
                    Birth = DateTime.Parse("1997-12-26"),
                    Married = false,
                    Memo = "負けず嫌いです。"
                },
                new Member
                {
                    Name = "渡辺領域",
                    Email = "watanabe@wings.msn.to",
                    Birth = DateTime.Parse("1977-01-23"),
                    Married = true,
                    Memo = "頭の良さなら誰にも負けません。"
                }
            };
        }
    }
}