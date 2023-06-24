using Data_Layer;
using System;

namespace ServiceLayer
{
    public static class ContextGenerator
        {
            private static KrisDbContext dbContext;
            private static UserContext usercontext;
            private static InterestContext interestContext;

            public static KrisDbContext GetDbContext()
            {
                if (dbContext == null)
                {
                    SetDbContext();
                }
                return dbContext;
            }

            public static void SetDbContext()
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                }

                dbContext = new KrisDbContext();
            }

            public static UserContext GetUserContext()
            {
                if (usercontext == null)
                {
                    SetUserContext();
                }

                return usercontext;
            }

            public static void SetUserContext()
            {
                usercontext = new UserContext(GetDbContext());
            }

            public static InterestContext GetInterestContext()
            {
                if (interestContext == null)
                {
                SetInterestContext();
                }

                return interestContext;
            }

            public static void SetInterestContext()
            {
                interestContext = new InterestContext(GetDbContext());
            }
        }


    }

