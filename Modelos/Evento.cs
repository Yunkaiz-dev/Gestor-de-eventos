﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gestor_de_eventos.Modelos;

public partial class Evento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string Ubicacion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public decimal? Capacidad { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
