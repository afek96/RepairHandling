using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RepairHandlingSystem.DAL;

namespace RepairHandlingSystem.Managers
{
    public class PersonelManager
    {
        public PersonelManager()
        {

        }

        public Personel GetPersonelByUserName(string userName)
        {
            var temp = GetPersonel(new Personel() { UserName = userName });
            return temp.SingleOrDefault();
        }

        public bool CheckPassword(Personel user, string password)
        {
            return user.Password == CreatePasswordHash(password);
        }

        public IQueryable<Personel> GetPersonel(Personel searchCriteria)
        {
            DataClassesRepairDataContext dc = new DataClassesRepairDataContext();
            if (searchCriteria == null)
                return dc.Personels;

            return dc.Personels.Where(p => 
                (string.IsNullOrEmpty(searchCriteria.FirstName) || p.FirstName.StartsWith(searchCriteria.FirstName))
                && (string.IsNullOrEmpty(searchCriteria.LastName) || p.LastName.StartsWith(searchCriteria.LastName))
                && (string.IsNullOrEmpty(searchCriteria.UserName) || p.UserName.StartsWith(searchCriteria.UserName))
                && (string.IsNullOrEmpty(searchCriteria.Role) || p.Role.StartsWith(searchCriteria.Role))
                && (!searchCriteria.ExpiryDate.HasValue || !p.ExpiryDate.HasValue || p.ExpiryDate > searchCriteria.ExpiryDate));
        }

        public void AddPersonel(Personel personel)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                dc.Personels.InsertOnSubmit(personel);
                dc.SubmitChanges();
            }
        }

        public void EditPersonel(Personel personel)
        {
            using (DataClassesRepairDataContext dc = new DataClassesRepairDataContext())
            {
                var dbPersonel = dc.Personels.SingleOrDefault(p => p.IdPersonel == personel.IdPersonel);
                if (dbPersonel.Password != personel.Password)
                    personel.Password = CreatePasswordHash(personel.Password);

                dbPersonel.Edit(personel);
                
                dc.SubmitChanges();
            }
        }

        private string CreatePasswordHash(string password)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                return string.Concat(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(item => item.ToString("x2")));
            }
        }
    }
}
