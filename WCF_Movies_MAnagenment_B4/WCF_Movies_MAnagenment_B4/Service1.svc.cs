using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Movies_MAnagenment_B4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        MoviesDBEntities db = new MoviesDBEntities();
        public void Add(Movie m)
        {
            db.Movies.Add(m);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            db.Movies.Remove(GetById(Id));
            db.SaveChanges();
        }

        public void Edit(Movie m)
        {
            db.Entry(m).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();   
        }

        public Movie GetById(int Id)
        {
            return db.Movies.Find(Id);
        }
        public List<Movie> Search(string Search)
        {
     
           if(!string.IsNullOrWhiteSpace(Search))
            {
                return db.Movies.Where(m => m.Title.Contains(Search)).ToList();
            }
            return db.Movies.ToList();
        }
    }
}
