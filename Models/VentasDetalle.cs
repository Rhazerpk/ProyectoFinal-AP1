using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class VentasDetalle{

    [Key]
    public int Id { get; set; }
    public int VentaId { get; set; }
    public int EquipoId { get; set; }  
    public double Cantidad { get; set; }
    public decimal PrecioEquipo { get; set; }
    public string? Descripcion { get; set; }
    public decimal Importe { get; set; }
    public virtual Equipo? equipo {get; set;}
    public Ventas venta { get; set; } = new Ventas();

    public VentasDetalle()
    {
        Id = 0;
        VentaId = 0;
        EquipoId = 0;
        Cantidad = 0;    
        PrecioEquipo = 0;  
        Descripcion = string.Empty;  
        
    }

    public VentasDetalle(int id, int ventaId, int equipoId, int cantidad, decimal precioEquipo, string descripcion)
    {
        Id = id;
        VentaId = ventaId;
        EquipoId = equipoId;
        Cantidad = cantidad;
        PrecioEquipo = precioEquipo;
        Descripcion = descripcion; 

    }

    
}