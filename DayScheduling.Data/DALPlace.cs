using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayScheduling.Data
{
    public class DALPlace
    {
        DaySchedulingModelDataModels Models = new DaySchedulingModelDataModels();

        public Place Get(int ID)
        {
            string query = @"SELECT * FROM Place P WHERE P.PlaceID=@placeID"; 
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@placeID", ID));
            return res.FirstOrDefault();
        }

        public List<Place> GetList()
        {
            string query = @"SELECT * FROM Place";
            var res = Models.Database.SqlQuery<Place>(query);
            return res.ToList();
        }

        public Place getBreakfastPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 10) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 10)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget),new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            else if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getCulturelPlace(int provinceID,string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
             query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND ((P.PlaceTypeID = 80) OR (P.PlaceTypeID = 140)) ORDER BY P.PlaceRate DESC";
            else
             query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND ((P.PlaceTypeID = 80) OR (P.PlaceTypeID = 140))";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            else if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getShoppingPlace(int provinceID, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND (P.PlaceTypeID = 70) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND (P.PlaceTypeID = 70)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            else if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }

        public Place getBeachPlace(int provinceID, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND (P.PlaceTypeID = 90) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND (P.PlaceTypeID = 90)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getRelaxingPlace(int provinceID, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND ((P.PlaceTypeID = 80) OR (P.PlaceTypeID = 100) OR (P.PlaceTypeID = 140) OR (P.PlaceTypeID = 110))  ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND ((P.PlaceTypeID = 80) OR (P.PlaceTypeID = 100) OR (P.PlaceTypeID = 140) OR (P.PlaceTypeID = 110))";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getFunPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND ((P.PlaceTypeID = 14) 
            OR (P.PlaceTypeID = 70) OR (P.PlaceTypeID = 80) OR (P.PlaceTypeID = 110) OR (P.PlaceTypeID = 130)) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND ((P.PlaceTypeID = 14) 
            OR (P.PlaceTypeID = 70) OR (P.PlaceTypeID = 80) OR (P.PlaceTypeID = 110) OR (P.PlaceTypeID = 130)) ";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }

        public Place getOutdoorPlace(int provinceID, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND ((P.PlaceTypeID = 100) OR (P.PlaceTypeID = 90)) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND ((P.PlaceTypeID = 100) OR (P.PlaceTypeID = 90))";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }



        public Place getFastFoodPlace(int provinceID, int budget, string Popularity, int NOF,string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 11) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 11)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getMeatChickenPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 12) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 12)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getSeaFoodPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 13) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 13)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getDesertPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 30) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 30)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getHomemadePlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 15) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 15)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }

        public Place getRestaurantPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 3) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 3)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getTavernPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 40) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 40)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getBarPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 50) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 50)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
        public Place getClubPlace(int provinceID, int budget, string Popularity, int NOF, string rate)
        {
            string query = "";
            if (!string.IsNullOrEmpty(rate))
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 60) ORDER BY P.PlaceRate DESC";
            else
                query = @"SELECT * FROM Place P WHERE P.ProvinceID = @provinceID AND P.PlacePrice <= @budget AND P.PlacePopularityID = @Popularity AND((P.NumberOfPerson>=@NOF) OR (P.NumberOfPerson = 0)) AND (P.PlaceTypeID = 60)";
            var res = Models.Database.SqlQuery<Place>(query, new SqlParameter("@provinceID", provinceID), new SqlParameter("@budget", budget), new SqlParameter("@Popularity", Popularity), new SqlParameter("@NOF", NOF));
            List<Place> pList = res.ToList<Place>();
            if (pList.Count != 0 && !string.IsNullOrEmpty(rate))
            {
                return res.FirstOrDefault();
            }
            if (pList.Count != 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pList.Count);
                return pList[index];
            }
            return null;
        }
    }
}
