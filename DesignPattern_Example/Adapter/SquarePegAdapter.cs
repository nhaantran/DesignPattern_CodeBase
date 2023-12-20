using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Adapter;

public class SquarePegAdapter : IRoundPeg, ISquarePeg
{
    private readonly SquarePeg squarePeg;
    public SquarePegAdapter(SquarePeg squarePeg)
    {
        this.squarePeg = squarePeg;
    }
    public int GetRadius()
    {
        return (int) (squarePeg.GetWidth() * Math.Sqrt(2)/2);
    }
    public int GetWidth()
    {
        return this.squarePeg.GetWidth();
    }
}
