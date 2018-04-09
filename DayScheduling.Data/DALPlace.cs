using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayScheduling.Data
{
    public class DALPlace
    {
        DaySchedulingModelDataModels Models = new DaySchedulingModelDataModels();

        public List<string> GetPlaceTypeFromPlaceID(int ID)
        {
            var Id = ID;
            var queryResult =
                from P in Models.Places join PT in Models.PlaceTypes on P.PlaceTypeID equals PT.PlaceTypeID where P.PlaceID == Id select new { name = P.PlaceName, type = PT.PlaceType1, rate = P.PlaceRate, price = P.PlacePrice, description = P.PlaceDescription };
            List<string> result = new List<string>();
            result.Add(queryResult.FirstOrDefault().name);
            result.Add(queryResult.FirstOrDefault().type);
            result.Add(queryResult.FirstOrDefault().rate.ToString());
            result.Add(queryResult.FirstOrDefault().price.ToString());
            result.Add(queryResult.FirstOrDefault().description);
            return result;
            //string sql = @"SELECT PT.PlaceType,P.PlaceRate,P.PlacePrice FROM PlaceType PT, Place P WHERE P.PlaceTypeID = PT.PlaceTypeID AND P.PlaceID = @PlaceID";
            /*var rs = Models.Database.SqlQuery<string>("SELECT PlaceType FROM Place").ToList();*/
            //var result = Models.Database.SqlQuery<denemview>(sql, new SqlParameter("@PlaceID",Id)).ToList().FirstOrDefault();
            //Models.Database.ExecuteSqlCommand(result.ToString());
            //return result.ToString();
        }
    }
}
