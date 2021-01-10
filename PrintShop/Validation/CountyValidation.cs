using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CountyValidation
{
    public class CountyValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var county = Convert.ToString(value);
            
            List<string> counties = new List<string>(new string[]
            {
                "bucuresti", "ilfov", "galati", "suceava", "bacau", "bistrita-nasaud", "cluj", "neamt", "prahova",
                "arad", "valcea", "vrancea", "vaslui", "tulcea", "timis", "teleorman", "sibiu", "salaj", "satu mare",
                "olt", "mehedinti", "maramures", "iasi", "ialomita", "hunedoara", "harghita", "gorj", "giurgiu", "dolj", "dambovita",
                "covasna", "constanta", "calarasi", "caras-severin", "buzau", "brasov", "botosani", "bihor", "arges", "alba"
            });
            
            var matchingvalues = counties
                .Where(stringToCheck => stringToCheck.Equals(county));
            
            var res = matchingvalues.Any();
            return res;
        }
    }
}