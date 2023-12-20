using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Adapter;

public interface IRoundHole
{
    public bool Fits(IRoundPeg peg);
    public int GetRadius();
}
public class RoundHole : IRoundHole
{
    private readonly int radius;
    public RoundHole(int radius) { this.radius = radius; }

    public bool Fits(IRoundPeg peg)
    {
        return this.radius >= peg.GetRadius();
    }

    public int GetRadius()
    {
        return radius;
    }
}
