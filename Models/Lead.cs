using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cmrmodels2._0.Models
{
    public class Lead
    {
    [Key]
    public int LeadId { get; set; }

    [Required, StringLength(100)]
    public string FirstName { get; set; }

    [Required, StringLength(100)]
    public string LastName { get; set; }

    [Required, EmailAddress]
    public string Mail { get; set; }

    [Phone]
    public string PhoneNumber { get; set; }

    [StringLength(250)]
    public string Company { get; set; }

    [StringLength(500)]
    public string Notes { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public DateTime? LastContactDate { get; set; }

    public bool IsQualified { get; set; } = false;
    
    }
}