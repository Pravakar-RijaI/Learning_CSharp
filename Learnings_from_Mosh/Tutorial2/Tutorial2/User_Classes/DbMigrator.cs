using System;

namespace Composition
{
    internal class DbMigrator
    {
        private Logger logger = new Logger();

        /*public DbMigrator(Logger logger)
        {
            _logger = logger;
        }*/
        public void Migrate()
        {
            logger.LoggMessage("UIOP");
            Console.WriteLine("Migrating Db.");
        }
    }
}
