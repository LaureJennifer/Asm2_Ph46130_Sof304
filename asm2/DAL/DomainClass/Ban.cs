using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace asm2.DAL.DomainClass;

[Table("Ban")]
[Index("Ma", Name = "UQ__Ban__3214CC9E327CAF8B", IsUnique = true)]
public partial class Ban
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(30)]
    public string? Ten { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySinh { get; set; }

    [StringLength(30)]
    public string? SoThich { get; set; }

    public int? GioiTinh { get; set; }

    [Column("IdMQH")]
    public Guid? IdMqh { get; set; }

    public int? TrangThai { get; set; }

    [ForeignKey("IdMqh")]
    [InverseProperty("Bans")]
    public virtual MoiQuanHe? IdMqhNavigation { get; set; }
}
