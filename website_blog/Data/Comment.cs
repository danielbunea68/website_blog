using website_blog.Areas.Identity.Data;

namespace website_blog.Data

	
{
    public class Comment
    {
        public int Id { get; set; } 
        public int PostId {  get; set; }    
        public string blogUserId {  get; set; }
        public string CommentText {  get; set; }  
        public DateTime Created { get; set; }   

        public blogUser blogUser { get; set; }
    }
}
