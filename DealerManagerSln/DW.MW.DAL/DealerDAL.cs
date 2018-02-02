using System;
using DW.MW.Entities;
using System.Collections.Generic;

namespace DW.MW.DAL
{
    public class DealerDAL
    {
        public List<Dealer> GetDealers()
        {
            return new List<Dealer>()
            {
                new Dealer {ID=101, Location="Chennai", Name="Kannan Dealers", YearOfEstablishment = new DateTime(2012, 01, 22) },
                new Dealer {ID=101, Location="Trichy", Name="Kumaran Dealers", YearOfEstablishment = new DateTime(2011, 01, 22) },
                new Dealer {ID=101, Location="Madurai", Name="Murugan Dealers", YearOfEstablishment = new DateTime(2010, 01, 22) },
                new Dealer {ID=101, Location="Coimbatore", Name="Vasantha Dealers", YearOfEstablishment = new DateTime(2013, 01, 22) },
                new Dealer {ID=101, Location="Kumbakonam", Name="Boopalan Dealers", YearOfEstablishment = new DateTime(2014, 01, 22) },
                new Dealer {ID=101, Location="Chennai", Name="Balaji Dealers", YearOfEstablishment = new DateTime(2002, 01, 22) },
                new Dealer {ID=101, Location="Nagapattinam", Name="Rani Dealers", YearOfEstablishment = new DateTime(2002, 01, 22) }
            };
        }
    }
}
