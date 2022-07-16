using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class program
{
    static void Main(string[] args)
    {
        List<string>[] res = new List<string>[3];
        
        for(int i = 0; i < 3; i++)
        {
            res[i] = new List<string>();
        }

        res[0].Add("abc");
        res[0].Add("def");
        res[1].Add("ghi");
        res[1].Add("jkl");
        res[2].Add("mno");
        res[2].Add("pqr");

        for(int i = 0; i<3; i++)
        {
            for(int j =0;j<res[i].Count;j++)
            {
                Console.Write($"{res[i][j]}");
            }
            Console.WriteLine("|");
        }

        Console.Read();
    }
}

class Phone
{
    public string Brandt { get; set; }
    public double Price { get; set; }
    public override bool Equals(object? obj)
    {
        if(obj is Phone p)
        {
            return (this.Price == p.Price) && (this.Brandt == p.Brandt);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Brandt, Price);
    }
}