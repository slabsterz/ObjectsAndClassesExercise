using System.Text.RegularExpressions;
using static Articles.Program;

namespace Articles
{
    public class Program
    {
        public class Article
        {
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Author = author;
                this.Content = content;
            }

            public void Edit(string content)
            {
                this.Content = content;
            }

            public void ChangeAuthor(string author)
            {
                this.Author = author;
            }

            public void Rename(string title)
            {
                this.Title = title;
            }

            public override string ToString()
            {
               return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }


        static void Main(string[] args)
        {
            string[] inputArticle = Console.ReadLine().Split(", ");
            string title = inputArticle[0];
            string content = inputArticle[1];
            string author = inputArticle[2];

            Article article = new Article(title, content, author);

            int cycles = int.Parse(Console.ReadLine());

            for (int i = 0; i < cycles; i++)
            {
                string commandsInput = Console.ReadLine();
                string[] commands = Regex.Split(commandsInput, "[:\\s]+");

                string command = commands[0];
                string editInput = string.Join(" ", commands.Skip(1));               

                switch (command)
                {
                    case "Edit":
                        article.Content = editInput;
                        break;
                    case "ChangeAuthor":
                        article.Author = editInput;
                        break;
                    case "Rename":
                        article.Title = editInput;
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}