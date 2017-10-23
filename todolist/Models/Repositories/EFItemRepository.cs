//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ToDoList.Models;

//namespace BasicAuthentication.Models
//{
//    public class EFItemRepository 
//    {
//        ApplicationDbContext db = new ApplicationDbContext();

//        public EFItemRepository(ApplicationDbContext connection = null)
//        {
//            if (connection == null)
//            {
//                this.db = new ApplicationDbContext();
//            }
//            else
//            {
//                this.db = connection;
//            }
//        }

//        //public IQueryable<Item> Items
//        //{ get { return db.Items; } }

//        //public Item Save(Item item)
//        //{
//        //    db.Items.Add(item);
//        //    db.SaveChanges();
//        //    return item;
//        //}

//        //public Item Edit(Item item)
//        //{
//        //    db.Entry(item).State = EntityState.Modified;
//        //    db.SaveChanges();
//        //    return item;
//        //}

//        //public void Remove(Item item)
//        //{
//        //    db.Items.Remove(item);
//        //    db.SaveChanges();
//        //}

//        //public void DeleteAll()
//        //{
//        //    db.Items.RemoveRange();
//        //    //method that deletes all from items db
//        //}
//    }
//}
