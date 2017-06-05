using System.Collections.Generic;
using Model;

namespace Bandtastic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bandtastic.BandtasticData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bandtastic.BandtasticData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.ProcurementBands.AddOrUpdate(x => x.Name,
                new ProcurementBand
                {
                    Name = "Band 8",
                    ProcurementType = new List<ProcurementType>
                {
                    new ProcurementType{Name = "Type 1", MaxDelegation = 10000},
                    new ProcurementType{Name = "Type 2", MaxDelegation = 10000},
                    new ProcurementType{Name = "Type 3", MaxDelegation = 0},
                    new ProcurementType{Name = "Type 4", MaxDelegation = 0},
                    new ProcurementType{Name = "Type 5", MaxDelegation = 10000}
                }
                }, new ProcurementBand
                {
                    Name = "Band 7",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 100000},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 100000},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 100000}
                    }
                }, new ProcurementBand
                {
                    Name = "Band 6",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 250000},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 250000},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 250000}
                    }
                }, new ProcurementBand
                {
                    Name = "Band 5",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 500000},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 500000},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 500000}
                    }
                }, new ProcurementBand
                {
                    Name = "Band 4",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 1000000},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 1000000},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 0},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 1000000}
                    }
                }, new ProcurementBand
                {
                    Name = "Band 3",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 10000000},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 10000000},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 10000000},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 150000},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 1000000}
                    }
                }, new ProcurementBand
                {
                    Name = "Band 2",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 250000},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 99999999}
                    }
                }, new ProcurementBand
                {
                    Name = "Band 1",
                    ProcurementType = new List<ProcurementType>
                    {
                        new ProcurementType{Name = "Type 1", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 2", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 3", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 4", MaxDelegation = 99999999},
                        new ProcurementType{Name = "Type 5", MaxDelegation = 99999999}
                    }
                });
        }
    }
}
