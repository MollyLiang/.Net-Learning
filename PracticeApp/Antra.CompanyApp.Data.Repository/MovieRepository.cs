using Antra.CompanyApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Antra.CompanyApp.Data.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        DBHelper db;
        public MovieRepository()
        {
            db = new DBHelper();
        }
        public int Delete(int id)
        {
            string cmd = "Delete from Movie where Id=@movieid";
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("@movieid", id);
            return db.Execute(cmd, p);
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movie item)
        {
            string cmd = "Insert into Movie values (@moviename,@moviegenre)";
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("@moviename", item.MovieName);
            p.Add("@moviegenre", item.MovieGenre);
            return db.Execute(cmd, p);
        }

        public int Update(Movie item)
        {
            string cmd = "Update Movie set MovieName=@moviename, MovieGenre=@moviegenre where id=@id";
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("@moviename", item.MovieName);
            p.Add("@moviegenre", item.MovieGenre);
            p.Add("@id", item.Id);
            return db.Execute(cmd, p);
        }
    }
}
