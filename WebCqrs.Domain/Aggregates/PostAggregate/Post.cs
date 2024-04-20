using Microsoft.VisualBasic;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        private readonly List<PostComment> _postComments = new List<PostComment>();
        private readonly List<PostInteraction> _interaction = new List<PostInteraction>();
        private Post()
        {
        }
        public Guid PostId { get;  private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private  set; }
        public string TextContent { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set;}
        public IEnumerable<PostComment> Comments { get { return _postComments; } } 
        public IEnumerable<PostInteraction> Interactions { get { return _interaction; } }

        // Factories
        public static Post CreatePost(Guid userProfileId, string textContent) {
            return new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

        // public methods
        public void UpdatePostText(string newText) { 
            TextContent = newText;
            LastModified = DateTime.UtcNow;
        }

        public void AddPostComment(PostComment newComment)
        { 
            _postComments.Add(newComment);
        }

        public void RemovePostComment(PostComment toRemove) { 
            _postComments.Remove(toRemove);
        }

        public void AddInteractions(PostInteraction newInteraction) { 
            _interaction.Add(newInteraction);
        }

        public void RemoveInteractions(PostInteraction toRemove)
        {
            _interaction.Remove(toRemove);
        }
    }
}
