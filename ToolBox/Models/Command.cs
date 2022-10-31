using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Models
{
    public class Command
    {
        internal string Query { get; set; }
        internal bool IsStoredProcedure { get; set; }
        internal Dictionary<string, object> Parameters { get; set; }

        public Command(string query, bool isStoredProcedure = false)
        {
            this.Query = query;
            this.Parameters = new Dictionary<string, object>();
            this.IsStoredProcedure = isStoredProcedure;
        }

        public void AddParameter(string parameterName, object value)
        {
            this.Parameters.Add(parameterName, value ?? DBNull.Value);
        }
    }
}
