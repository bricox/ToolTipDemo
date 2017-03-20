using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolTipTesting.Models
{
    public class Tooltip
    {
        public int Id { get; set; }
        public string PageId { get; set; }
        public string ElementId { get; set; }
        public string Tip { get; set; }

    }
}