using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mirabeau.Feature.Forms.Models
{
    public class SCContactVM
    {
        public string SelectedProfileId { get; set; }
        public IEnumerable<SCContactProfileVM> ContactProfiles { get; set; }
        public List<SCProfileFieldVM> ContactProfileFields { get; set; }
    }
}