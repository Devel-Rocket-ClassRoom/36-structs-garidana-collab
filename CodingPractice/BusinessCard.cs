using System;
using System.Collections.Generic;
using System.Text;

struct BusinessCard
{
    public string Name;
    public int Age;
    public string Address;

    public BusinessCard(string name, int age)
    {
        Name = name;
        Age = age;
        Address = "";
    }
}