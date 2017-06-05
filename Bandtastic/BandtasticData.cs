namespace Bandtastic
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Model;


    public class BandtasticData : DbContext
    {
        // Your context has been configured to use a 'BandtasticData' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Bandtastic.BandtasticData' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BandtasticData' 
        // connection string in the application configuration file.
        public BandtasticData()
            : base("name=BandtasticData")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<FinancialBand> FinancialBands { get; set; }
        public virtual DbSet<ProcurementBand> ProcurementBands { get; set; }
        public virtual DbSet<ProcurementType> ProcurementTypes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}