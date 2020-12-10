using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab5100
{
    class film:Exception, ICloneable
    {
        public film()
        {

        }
        public string name;
        public int release;
        public int times_of_film;

        public filmslb6 strct = new filmslb6(); 
        
        public film(string name_of_film, int year_of_release, int times_of_film,int count_of_adverts, parts pr = parts.one)
        {
            strct.name_of_film = name_of_film;
            strct.year_of_release = year_of_release;
            strct.times_of_film = times_of_film;
            strct.count_of_adverts = count_of_adverts;
            strct.pr = pr;
        }
        public film(string name, int release, int times_of_film,int count_of_adverts, int a)
        {
            this.name = name;
            this.release = release;
            this.times_of_film = times_of_film;
            strct.count_of_adverts = count_of_adverts;
        }
             public override string ToString()
        {
            return $"name  {name}, release {release}, release{release}";
        }

        object ICloneable.Clone()
        {
            return new film(strct.name_of_film = strct.name_of_film, strct.year_of_release = strct.year_of_release, times_of_film = this.times_of_film, strct.count_of_adverts = strct.count_of_adverts);
        }
        #region lb7

        #endregion
    }
}
