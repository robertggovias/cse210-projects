using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> _videosList = [];
        _videosList.Add(new Videos(
                "I Didn’t Feel Good Enough, But I Was Good Enough for God | His Grace",
                "The Church of Jesus Christ of Latter-day Saints",
                308,[]));
        _videosList.Add(new Videos(
                "Inspiring Short: The Miracle of the Ordinary",
                "Lawrence E. Corbridge",180,[]));        
        _videosList.Add(new Videos(
                "Inspiring Short: It's Never Too Late", "Matthew Wickman", 240, []));

        _videosList[0].AddCommentToVideo(new Comments(
                "@drewcano7865", "I had a very similar experience"));
        _videosList[0].AddCommentToVideo(new Comments(
                    "@matthewhart5573",
                    "Whoever reading this Heavenly Father loves you so much!"));
        _videosList[0].AddCommentToVideo(new Comments(
                    "@jacobbrown2015",
                    "Through His Grace, we can trade perfection for progression. Thank you for telling your story!"
                ));
        _videosList[0].AddCommentToVideo(new Comments(
                    "@dwyanewade8645",
                    "Love the fact that because God loves us,  we are infinitely good enough 🙏 We are going to be okay fellas."));

        _videosList[1].AddCommentToVideo(new Comments(
                    "@jacobadamsbaseball",
                    "I remember having similar feelings as a young man just looking at our dog in the back yard sitting there. Beautiful!"));
        _videosList[1].AddCommentToVideo(new Comments(
                    "@pacard33",
                    "I love Lawrence Corbridge. He has been one of the most inspiring speakers the Church has had.  What a great man and an even greater testimony."));
        _videosList[1].AddCommentToVideo(new Comments(
                    "@maryfranjeppesen8932",
                    "Love love love this!!"));
        _videosList[1].AddCommentToVideo(new Comments(
                    "@deegrappendorf5300",
                    "Such a beautiful message!"));
        _videosList[1].AddCommentToVideo(new Comments(
                    "@danielmaluenda9731",
                    "This really is extraordinary"));

        _videosList[2].AddCommentToVideo(new Comments(
                    "@intigniadickey2224",
                    "I like how the film was able to capture the beauty of this man's story   : )"));
        _videosList[2].AddCommentToVideo(new Comments(
                    "@joelgriffitts1385",
                    "The gospel of second chances. And third and fourth and on and on. I'm counting on it."));


        //My mind goes automaticly to create menu, sorry
        int chossenElection = 0;
        while (chossenElection != 5)
        {
            // Implementación del menú principal
            Console.Clear();
            Console.WriteLine(
                "Welcome to the Youtube video management system:\n Chosse an option:\n  1. Register a video\n  2. Register a comment to a video\n  3. Display video list\n  4. Display comment list for a video\n  5. quit\n "
            );

            chossenElection = int.Parse(Console.ReadLine());
            switch (chossenElection)
            {
                case 1:
                    Console.Clear();
                    MenuToAddVideos();
                    break;
                case 2:
                    Console.Clear();
                    MenuToAddComment();
                    break;
                case 3:
                    Console.Clear();
                    DisplayVideoList();                    
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    DisplayCommentsForVideo();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Thanks for using our system");
                    break;
            }
        }

        void MenuToAddVideos()
        {
            // Implementación del menú para agregar videos
            Console.WriteLine("Lets register 3 important detail about the video");
            Console.WriteLine("could you provide the title?");
            string videoTitle = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice title, but who is the author?");
            string author = Console.ReadLine();
            Console.Clear();
            Console.Write("How long is the video?\nHow many seconds it has:");
            int length = int.Parse(Console.ReadLine());
            Console.Clear();
            List<Comments> commentGoup = new List<Comments>();
            commentGoup = [];
            _videosList.Add(new Videos(videoTitle, author, length, commentGoup));
            Console.Clear();
            Console.WriteLine($"Thanks for registering the video {videoTitle}.");
            Thread.Sleep(1500);
        }

        void MenuToAddComment()
        {
            Console.Write(
                "Please, provide the Number of the video, you can find it using the menu options, just choosing number 3. Display video list\n Video number: "
            );
            int i = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();
            Console.Write(
                $"Great! lets start with the author who comment about thevideo {_videosList[i].GetVideoTitle()}.\nWho write this commment: "
            );
            string commentAuthor = Console.ReadLine();
            Console.Clear();
            Console.Write($"Thanks, so what {commentAuthor} says?\n Please write the comment: ");
            string commentContent = Console.ReadLine();
            _videosList[i].AddCommentToVideo(new Comments(commentAuthor, commentContent));
            Console.Clear();
            Console.WriteLine("Thanks for registering this comment!");
            Thread.Sleep(1500);

            // Implementación del menú para agregar comentarios
        }
        void DisplayVideoList()
        {
            int index = 1;
            foreach (var i in _videosList)
            {
                Console.Write($"{index}. ");
                i.DisplayOneVideo();
                index++;
            }
        }
        void DisplayCommentsForVideo()
        {
            Console.WriteLine(
                "Each video has his own number order, if you provide that number I will give you all the comments for that video"
            );
            int i = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();
            Console.WriteLine($"The comments for the video {_videosList[i].GetVideoTitle()} are:\n");
            _videosList[i].DisplayAllCommentsFromOneVideo();
        }
    }
}
