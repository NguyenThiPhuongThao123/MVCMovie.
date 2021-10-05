using System;

namespace MVCMovie.Models
{
    internal class MvcMovieContext : IDisposable
    {
        private object p;

        public MvcMovieContext(object p)
        {
            this.p = p;
        }

        public object Movie { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}