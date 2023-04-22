using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public static class ValidatableBall
    {
        public static List<string> BallValidatable(this Ivalidatable validatable)
        {
            List<string> error = new List<string>();

            var type = validatable.GetType();
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var Attributs = property.GetCustomAttributes(false);
                foreach (var attrs in Attributs)
                {
                    if (attrs is RangeAttribute range)
                    {
                        if (!range.IsValid(property.GetValue(validatable)))
                        {
                            error.Add($"{property.Name} Значени не входит в диапазон");
                        }

                    }

                }
            }
            return error;
        }
    }
}
