using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace UserManagementForGym.ViewModels
{
    public class ValidDate: ValidationAttribute
    {
        public override bool IsValid(object value )
        {
            DateTime dateTime;
            var isValid = DateTime. TryParseExact(Convert.ToString(value), " dd MMM yyy" , 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None, 
                out dateTime);

            return (isValid );
           
        }
    }





    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid);

        }
    }
}


