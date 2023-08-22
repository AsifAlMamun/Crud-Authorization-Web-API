using DAL.EF.Models;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repos
{
    internal class CategoryRepo : Repo, IRepo<Category, int, bool>
    {
        public bool Create(Category obj)
        {
            db.Categories.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var obj = db.Categories.Find(id);
            db.Categories.Remove(obj);
            return db.SaveChanges() > 0;
           
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return (Category)db.Categories.Find();
        }

        public bool Update(Category obj)
        {
            var exp = db.Categories.Find(obj);

            return db.SaveChanges() > 0;
        }
    }
}
