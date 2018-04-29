using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayScheduling.Data
{
    public class DALPlaceType
    {
        DaySchedulingModelDataModels Models = new DaySchedulingModelDataModels();
        public PlaceType Get(int? ID)
        {
            string query = @"SELECT * FROM PlaceType PT, WHERE PT.PlaceTypeID=@placeTypeID"; //cilem.akcay@hotmail.com
            var res = Models.Database.SqlQuery<PlaceType>(query, new SqlParameter("@placeTypeID", ID));
            return res.FirstOrDefault();
        }
    }
}
