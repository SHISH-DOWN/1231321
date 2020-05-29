using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using static System.Math;

namespace Solar
{
  
        public class AddOnce
        {
            
            public Planets[] doit;
            public List<Planets> PlanetsList = new List<Planets>();
            public void AddIt(object sender, EventArgs e)
            {
                Planets Mercyriy = new Planets()
                {
                    Id = 1,
                    Name = "Mercyriy",
                    R = 24397000,
                    M = 3.33 * Pow(10.0, 23.0)
                };
                Planets Venus = new Planets
                {
                    Id = 2,
                    Name = "Venus",
                    R = 6051000,
                    M = 4.86 * Pow(10.0, 24)
                };
                Planets Earth = new Planets
                {
                    Id = 3,
                    Name = "Ertch",
                    R = 6371000,
                    M = 5.972 * Pow(10.0, 24)
                };
                Planets Mars = new Planets
                {
                    Id = 4,
                    Name = "Mars",
                    R = 3396000,
                    M = 6.417 * Pow(10.0, 23.0)
                };
                Planets Upiter = new Planets
                {
                    Id = 5,
                    Name = "Upiter",
                    R = 69911000,
                    M = 1.89 * Pow(10, 27)
                };
                Planets Saturn = new Planets
                {
                    Id = 6,
                    Name = "Saturn",
                    R = 58388000,
                    M = 5.68 * Pow(10, 26)
                };
                Planets Uran = new Planets
                {
                    Id = 7,
                    Name = "Uran",
                    R = 25559000,
                    M = 8.681 * Pow(10, 26)
                };
                Planets Neptun = new Planets
                {
                    Id = 8,
                    Name = "Neptun",
                    R = 24662000,
                    M = 1.024 * Pow(10, 26)
                };
                using (PlanetsContext save = new PlanetsContext())
                {

                    doit = new Planets[] { Mercyriy, Venus, Earth, Mars, Upiter, Saturn, Uran, Neptun };
                    if (save.Planets.ToList().Count < 8)  
                    {
                        save.Planets.AddRange(doit);
                        save.SaveChanges();
                    }
                    
                }
                
                
            }

       
    }
}

    
