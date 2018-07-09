namespace _7.SocialMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SocialMediaPosts
    {
        public static Dictionary<string, Dictionary<string, string>> postComments =
            new Dictionary<string, Dictionary<string, string>>();

        public static Dictionary<string, int> likeCommand = new Dictionary<string, int>();

        public static Dictionary<string, int> dislikeCommand = new Dictionary<string, int>();

        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            while (input[0] != "drop" || input[1] != "the" || input[2] != "media")
            {
                string command = input[0];
                string postName = input[1];

                switch (command)
                {
                    case "post":
                        CreatePost(postName);
                        break;
                    case "like":
                        LikePost(postName);
                        break;
                    case "dislike":
                        DislikePost(postName);
                        break;
                    case "comment":
                        string commentator = input[2];
                        string content = string.Join(" ", input.Skip(3));
                        CommentPost(postName, commentator, content);
                        break;
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var data in postComments)
            {
                string postName = data.Key;
                var comments = data.Value;

                int likes = likeCommand[postName];
                int dislikes = dislikeCommand[postName];

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                if (comments.Count() == 0)
                {
                    Console.WriteLine("None");
                }

                foreach (var item in comments)
                {
                    string commentator = item.Key;
                    string content = item.Value;

                    Console.WriteLine($"*  {commentator}: {content}");
                }
            }
        }

        public static void CreatePost(string postName)
        {
            postComments.Add(postName, new Dictionary<string, string>());
            likeCommand.Add(postName, 0);
            dislikeCommand.Add(postName, 0);
        }

        public static void LikePost(string postName)
        {
            likeCommand[postName]++;
        }

        public static void DislikePost(string postName)
        {
            dislikeCommand[postName]++;
        }

        public static void CommentPost(string postName, string commentator, string content)
        {
            postComments[postName].Add(commentator, content);
        }
    }
}
