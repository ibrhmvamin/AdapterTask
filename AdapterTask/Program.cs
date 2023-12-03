namespace AdapterTask
{
    //public class Program
    //{
    //    public abstract class AbstractDatabase
    //    {
    //        public abstract string GetById(int id);
    //        public abstract void DeleteById(int id);
    //        public abstract void Add(int id, string data);
    //        public abstract void Update(int id, string data);
    //    }

    //    public class MsSql : AbstractDatabase
    //    {
    //        public override string GetById(int id)
    //        {
    //            Console.WriteLine("Get from MsSql database");
    //            return string.Empty;
    //        }

    //        public override void DeleteById(int id)
    //        {
    //            Console.WriteLine("Delete from MsSql database");
    //        }

    //        public override void Add(int id, string data)
    //        {
    //            Console.WriteLine("Add to MsSql database");
    //        }

    //        public override void Update(int id, string data)
    //        {
    //            Console.WriteLine("Update in MsSql database");
    //        }
    //    }
    //         public class Oracle : AbstractDatabase
    //    {
    //        public override string GetById(int id)
    //        {
    //            Console.WriteLine("Get from Oracle database");
    //            return string.Empty;
    //        }

    //        public override void DeleteById(int id)
    //        {
    //            Console.WriteLine("Delete from Oracle database");
    //        }

    //        public override void Add(int id, string data)
    //        {
    //            Console.WriteLine("Add to Oracle database");
    //        }

    //        public override void Update(int id, string data)
    //        {
    //            Console.WriteLine("Update in Oracle database");
    //        }
    //    }

    //    public class WebSite
    //    {
    //        private readonly AbstractDatabase _database;

    //        public WebSite(AbstractDatabase database)
    //        {
    //            _database = database;
    //        }

    //        public void Run()
    //        {
    //            _database.Add(10, "Salam");
    //            _database.Update(1, "Yes");
    //            _database.GetById(1);
    //            _database.DeleteById(2);

    //            _database.Update(1, "Yes");
    //            _database.GetById(1);
    //            _database.DeleteById(2);

    //            _database.GetById(1);
    //            _database.DeleteById(2);
    //        }
    //    }


    //        static void Main()
    //        {
    //            WebSite mySite = new WebSite(new Oracle());
    //            mySite.Run();
    //        }


    //}

    public class Program
    {
        public interface IAbstractDatabase
        {
            public abstract string GetById(int id);
            public abstract void DeleteById(int id);
            public abstract void Add(int id, string data);
            public abstract void Update(int id, string data);
        }

        public class MsSql : IAbstractDatabase
        {
            public  string GetById(int id)
            {
                Console.WriteLine("Get from MsSql database");
                return string.Empty;
            }

            public  void DeleteById(int id)
            {
                Console.WriteLine("Delete from MsSql database");
            }

            public  void Add(int id, string data)
            {
                Console.WriteLine("Add to MsSql database");
            }

            public void Update(int id, string data)
            {
                Console.WriteLine("Update in MsSql database");
            }
        }
        public class Oracle : IAbstractDatabase
        {
            public string GetById(int id)
            {
                Console.WriteLine("Get from Oracle database");
                return string.Empty;
            }

            public void DeleteById(int id)
            {
                Console.WriteLine("Delete from Oracle database");
            }

            public void Add(int id, string data)
            {
                Console.WriteLine("Add to Oracle database");
            }

            public  void Update(int id, string data)
            {
                Console.WriteLine("Update in Oracle database");
            }
        }

        public class WebSite
        {
            private readonly IAbstractDatabase _database;

            public WebSite(IAbstractDatabase database)
            {
                _database = database;
            }

            public void Run()
            {
                _database.Add(10, "Salam");
                _database.Update(1, "Yes");
                _database.GetById(1);
                _database.DeleteById(2);

                _database.Update(1, "Yes");
                _database.GetById(1);
                _database.DeleteById(2);

                _database.GetById(1);
                _database.DeleteById(2);
            }
        }


        static void Main()
        {
            WebSite mySite = new WebSite(new Oracle());
            mySite.Run();
        }


    }
}