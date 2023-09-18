﻿namespace BlazingPizza;

public class Address
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(100)]
    public string Line1 { get; set; }

    [MaxLength(100)]
    public string Line2 { get; set; }

    [MaxLength(50)]
    public string City { get; set; }

    [MaxLength(20)]
    public string Region { get; set; }

    [MaxLength(20)]
    public string PostalCode { get; set; }
}
