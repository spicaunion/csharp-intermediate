using System;

namespace StackOverflowPost_exercise
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateEdited { get; private set; }
        public int Vote { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            DateCreated = DateTime.Now;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }

        public void Edit(string title, string description)
        {
            EditCore(title, description);
        }

        public void Edit(string description)
        {
            EditCore(this.Title, description);
        }

        private void EditCore(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            DateEdited = DateTime.Now;
        }
    }
}
