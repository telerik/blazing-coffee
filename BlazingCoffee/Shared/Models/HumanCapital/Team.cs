using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazingCoffee.Shared.Models
{
    public class Team
        {
            public int TeamId { get; set; }
            public string TeamName { get; set; }
            public string TeamColor { get; set; }
        
            [JsonIgnore]
            // ^^^^^^^
            // System.Text.Json does not identify circular references.
            // We need to ignore the employees reference otherwise it will loop.
            public List<Employee> Employees { get; set; }
        }

    }

