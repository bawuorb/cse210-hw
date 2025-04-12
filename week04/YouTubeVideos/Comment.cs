public class Comment
{
    private string commenterName;
    private string commentText;

    public Comment(string name, string text)
    {
        commenterName = name;
        commentText = text;
    }

    public string GetCommenterName()
    {
        return commenterName;
    }

    public string GetCommentText()
    {
        return commentText;
    }
}
