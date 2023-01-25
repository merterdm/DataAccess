﻿using EfCoreSinema.Entities.Abstract;

namespace EfCoreSinema.Entities.Concrete
{
    public class Film:BaseEntity<Guid>
    {
        public string FilmAdi { get; set; }
        public string? Aciklama { get; set; }
        public short?  FilmSuresi{ get; set; }

        public ICollection<Kategori>? Kategoriler { get; set; }

        public ICollection<Gosterim>? Gosterimleri { get; set; }

    }
}