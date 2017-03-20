using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToolTipTesting.Models;

namespace ToolTipTesting.Controllers
{
    public class TooltipController : ApiController
    {
        private static IList<Tooltip> toolTips;

        public TooltipController()
        {
            if (toolTips == null)
            {
                toolTips = new List<Tooltip>
            {
                new Tooltip
                {
                    Id = 1,
                    PageId = "page1",
                    ElementId = "#FirstName",
                    Tip = "Enter the first name of the person."
                },
                new Tooltip
                {
                    Id = 2,
                    PageId = "page1",
                    ElementId = "#LastName",
                    Tip = "Enter the last name of the person."
                }
            };
            }
        }

        public IEnumerable<Tooltip> Get()
        {
            return toolTips;
        }

        public IEnumerable<Tooltip> Post (Tooltip tooltip)
        {
            if (toolTips.Any(p => p.PageId == tooltip.PageId && p.ElementId == tooltip.ElementId))
            {
                toolTips.First(p => p.PageId == tooltip.PageId && p.ElementId == tooltip.ElementId).Tip = tooltip.Tip;
            }
            else
                toolTips.Add(tooltip);

            return toolTips;
        }
    }
}
