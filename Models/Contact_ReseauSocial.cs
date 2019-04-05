using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremiumcontactMaster.Models
{
   public class Contact_ReseauSocial
{
    public int IDContactReseauSocial { get; set; }

    public int? IDContact { get; set; }

    public int IDTypeReseauSocial { get; set; }

    public string URLReseauSocial { get; set; }

}

}
