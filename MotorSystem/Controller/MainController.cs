using MotorSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorSystem.Controller
{
    internal class MainController
    {
        public List<MotorDB> GetAllMotor()
        {
            using (MotorDBEntities1 db = new MotorDBEntities1())
            {
                return db.MotorDBs.ToList();
            }

        }
        public void AddMotor(MotorDB motorDB)
        {
            using (MotorDBEntities1 db = new MotorDBEntities1())
            {
                motorDB.Id = db.MotorDBs.ToList().LastOrDefault().Id + 1;
                db.MotorDBs.Add(motorDB);
                db.SaveChanges();

            }
        }
    }
}
