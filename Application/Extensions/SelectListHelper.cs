using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Application.Extensions
{
    public static class SelectListHelper
    {
        public static SelectList ToSelectList<T>(this IEnumerable<T> list, Func<T, string> text, Func<T, object> value, string defaultOptionText = "", string defaultOptionValue = "", string selectedOption = "")
        {
            var items = MakeSelectListItem<T>(list, text, value);
            InsertDefaultSelectItem(defaultOptionText, defaultOptionValue, items);
            return ReturnSelectListWithOrNotSelectedOption(selectedOption, items);
        }

        private static List<SelectListItem> MakeSelectListItem<T>(IEnumerable<T> list, Func<T, string> text, Func<T, object> value)
        {
            var items = list.Select(f => new SelectListItem()
            {
                Text = text(f),
                Value = value(f).ToString()
            }).ToList();
            return items;
        }

        private static void InsertDefaultSelectItem(string defaultOptionText, string defaultOptionValue, List<SelectListItem> items)
        {
            if (!string.IsNullOrEmpty(defaultOptionText))
            {
                items.Insert(0, new SelectListItem()
                {
                    Text = defaultOptionText,
                    Value = defaultOptionValue
                });
            }
        }

        private static SelectList ReturnSelectListWithOrNotSelectedOption(string selectedOption, List<SelectListItem> items)
        {
            if (!selectedOption.Equals(""))
                return new SelectList(items, "Value", "Text", selectedOption);
            else
                return new SelectList(items, "Value", "Text");            
        }
    }
}
