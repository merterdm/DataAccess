﻿namespace EfCore_RelatedDataSave
{
    public class Address
    {
        public int Id { get; set; }
        public string? Ulke { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public Person Person { get; set; }
    }
}