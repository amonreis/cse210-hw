using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create video objects
        var video1 = new Video("Japanese N5 Listening", "Mika Real Japanese", 1295);
        var video2 = new Video("10 MUST-KNOWN FACTS about Japanese before you start learning", "NihongoDekita with Sayaka", 603);
        var video3 = new Video("How to become fluent in Japanese in 2024", "TAKASHii", 812);

        // Add comments to video1
        video1.AddComment(new Comment("Andre Maracas", "Thank you very much for this one! Please do more talks on ~N4 level if you have the opportunity, anything casual regarding Sensei is appreciated!!"));
        video1.AddComment(new Comment("Daniel", "Great video, finally I have found a video where I can understand at least 35%."));
        video1.AddComment(new Comment("Zevle", "miku-sensei and sayuri-sensei, thank you for another very helpful video!"));

        // Add comments to video2
        video2.AddComment(new Comment("Nathan Taylor", "I love that you don't edit out your little mistakes, makes it more friendly and inviting, like actually talking to someone :)"));
        video2.AddComment(new Comment("Eve", "you make Japanese sound so easy! no verb conjugation, no distinction between singular and plural, super easy question structure, (almost) no irregular verbs... that's very motivating to hear :)"));
        video2.AddComment(new Comment("Charlott", "This actually made me feel a lot less stressed about learning Japanese, yes it will be difficult but I think after this video it will be a bit easier/less stressful that I was making it out to be. I am going to rewatch and take notes, it was very helpful, thank you!"));

        // Add comments to video3
        video3.AddComment(new Comment("Daniel Seeley", "I need to become fluent in being motivated first!"));
        video3.AddComment(new Comment("Jobe", "Nothing helps you learn better than being around people who speak the language you’re trying to learn."));
        video3.AddComment(new Comment("Hector", "I love how everyone learned Japanese in their own way. How one can learn a language most efficiently is something that entirely depends on the person. It's just something that everyone has to find out for themselves"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display details for each video
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine(); // For spacing between videos
        }
    }
}