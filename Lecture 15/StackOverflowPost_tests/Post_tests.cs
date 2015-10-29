using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackOverflowPost_exercise;
using System;

namespace StackOverflowPost_tests
{
    [TestClass]
    public class PostTests
    {
        private string _title = "title";
        private string _description = "description";

        private string _newTitle = "new title";
        private string _newDescription = "new description";

        [TestMethod]
        public void Post_Creation_SetsTitleAndDescription()
        {
            var post = new Post(_title, _description);
            Assert.AreEqual(_title, post.Title);
            Assert.AreEqual(_description, post.Description);
        }

        [TestMethod]
        public void Post_Creation_SetsDateCreated()
        {
            var post = new Post(_title, _description);
            bool areSemiEqual = DateTimesAreSemiEqual(DateTime.Now, post.DateCreated, 1000);
            Assert.IsTrue(areSemiEqual);
        }

        [TestMethod]
        public void Post_VoteIsInitiallyZero()
        {
            var post = new Post(_title, _description);
            Assert.AreEqual(0, post.Vote);
        }

        [TestMethod]
        public void UpVote_IncrementsVote()
        {
            var post = new Post(_title, _description);
            int vote = post.Vote;
            post.UpVote();
            Assert.AreEqual(vote + 1, post.Vote);
        }

        [TestMethod]
        public void DownVote_DecrementsVote()
        {
            var post = new Post(_title, _description);
            int vote = post.Vote;
            post.DownVote();
            Assert.AreEqual(vote - 1, post.Vote);
        }

        [TestMethod]
        public void Edit_UpdatesDescription()
        {
            var post = new Post(_title, _description);
            post.Edit(_newDescription);
            Assert.AreEqual(_title, post.Title);
            Assert.AreEqual(_newDescription, post.Description);
        }

        [TestMethod]
        public void Edit_UpdatesTitleAndDescription()
        {
            var post = new Post(_title, _description);
            post.Edit(_newTitle, _newDescription);
            Assert.AreEqual(_newTitle, post.Title);
            Assert.AreEqual(_newDescription, post.Description);
        }

        [TestMethod]
        public void Edit_SetsDateEdited()
        {
            var post = new Post(_title, _description);
            post.Edit(_newDescription);
            bool areSemiEqual = DateTimesAreSemiEqual(DateTime.Now, post.DateEdited, 1000);
            Assert.IsTrue(areSemiEqual);
        }

        private bool DateTimesAreSemiEqual(DateTime time1, DateTime time2, int millisecondThreshold)
        {
            return (time2 - time1).TotalMilliseconds <= millisecondThreshold;
        }
    }
}
