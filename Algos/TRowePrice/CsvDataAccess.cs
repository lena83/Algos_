using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
    public class CsvDataAccess : IDataAccess
    {
        private readonly string _filePath;
        private readonly CsvConfiguration _config;
        public CsvDataAccess(string filePath)
        {
            _filePath = filePath;
            _config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

        }

        public List<Trade> LoadTrades()
        {
            using var sr = new StreamReader(_filePath);
            using var csv = new CsvReader(sr, _config);

            var s =  csv.GetRecords<Trade>();
            return s.ToList();
        }
    }
}
