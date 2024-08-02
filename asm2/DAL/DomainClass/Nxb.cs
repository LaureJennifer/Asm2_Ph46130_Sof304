using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace asm2.DAL.DomainClass;

[Table("NXB")]
[Index("Ma", Name = "UQ__NXB__3214CC9E1BAAF1F3", IsUnique = true)]
public partial class Nxb
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdNxbNavigation")]
    public virtual ICollection<Sach> Saches { get; } = new List<Sach>();
}
