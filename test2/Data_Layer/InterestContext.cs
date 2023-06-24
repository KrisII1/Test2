using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data_Layer
{
    public class InterestContext : IDb<Interest, int>
    {
        KrisDbContext dbContext;
        public InterestContext(KrisDbContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public void Create(Interest item)
        {
            try
            {
                dbContext.Interests.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                dbContext.Interests.Remove(dbContext.Interests.Find(key));
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Interest Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Interest> query = dbContext.Interests;
                if (useNavigationalProperties)
                {
                    query=query.Include(p=> p.Area)
                        .Include(p=> p.Users);
                }
                return query.FirstOrDefault(p => p.Id == key);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Interest> ReadAll(bool useNavigationalProperties=false)
        {
            try
            {
                IQueryable<Interest> query = dbContext.Interests;
                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Area)
                        .Include(p => p.Users);
                }
                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Interest item,bool useNavigationalProperties=false)
        {
            try
            {
                if (useNavigationalProperties)
                {
                    Interest interestFromDb = Read(item.Id);

                    if (interestFromDb != null)
                    {
                        Create(item);
                        return;
                    }

                    interestFromDb.Name = item.Name;
                    interestFromDb.Area = item.Area;

                    dbContext.SaveChanges();
                }
                

                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
