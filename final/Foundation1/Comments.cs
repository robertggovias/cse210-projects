// Clase que representa un comentario
public class Comments
{
    private string _commentAuthor;
    private string _commentContent;

    public Comments(string commentAuthor, string commentContent)
    {
        _commentAuthor = commentAuthor;
        _commentContent = commentContent;
    }

    public void DisplayOneComment()
    {
        Console.WriteLine($"{_commentAuthor}: {_commentContent}");
        // Implementación para mostrar un comentario
    }
}
