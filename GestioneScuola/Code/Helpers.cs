using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneScuola.Code
{
    static class Helpers
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["GestioneScuola.Properties.Settings.SCUOLAConnectionString"].ConnectionString;
        }
    }
}
