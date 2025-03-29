public class Videos
{
    private string _videoTitle;
    private string _author;
    private int _length;
    private List<Comments> _commentsListForVideo;

    public Videos(string videoTitle, string author, int length, List<Comments> commentGroup)
    {
        _videoTitle = videoTitle;
        _author = author;
        _length = length;
        _commentsListForVideo = commentGroup;
    }

    public void DisplayOneVideo()
    {
        // Implementación para mostrar el video
        Console.WriteLine(
            $"Title: {_videoTitle} - Author: {_author} - Length: {_length} seconds. with {_commentsListForVideo.Count} comments"
        );
    }

    public string GetVideoTitle()
    {
        return _videoTitle;
        // Implementación para obtener el título del video
    }

    public List<Comments> GetComments()
    {
        return _commentsListForVideo;
        // Implementación para obtener los comentarios de un video
    }

    public void AddCommentToVideo(Comments comment)
    {
        // Implementación para agregar un comentario a un video
        _commentsListForVideo.Add(comment);
    }

    public int GetQuantityOfCommentForVideoID()
    {
        // Implementación para obtener la cantidad de comentarios para un video por su ID
        return _commentsListForVideo.Count;
    }

    public void DisplayAllCommentsFromOneVideo()
    {
        foreach (var i in _commentsListForVideo)
        {
            i.DisplayOneComment();
        }
        // Implementación para mostrar todos los comentarios de un video
    }
}
