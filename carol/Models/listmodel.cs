using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace carol.Models
{
    public static class ListModel
    {
        public static SelectList GetGenderSelectList()
        {
            var genders = new List<SelectListModel>
            {
                new SelectListModel {Id = 1, Text = "Male"},
                new SelectListModel {Id = 2, Text = "Female"}
            };

            return new SelectList(genders, "Id", "Text");
        }
    }
}