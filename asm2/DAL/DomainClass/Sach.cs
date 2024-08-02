using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace asm2.DAL.DomainClass;

[Table("Sach")]
[Index("Ma", Name = "UQ__Sach__3214CC9EE04D47C1", IsUnique = true)]
public partial class Sach
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(30)]
    public string? Ten { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayXuatBan { get; set; }

    public int? SoTrang { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? DonGia { get; set; }

    [Column("IdNXB")]
    public Guid? IdNxb { get; set; }

    public int? TrangThai { get; set; }

    [ForeignKey("IdNxb")]
    [InverseProperty("Saches")]
    public virtual Nxb? IdNxbNavigation { get; set; }
}
