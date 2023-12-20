using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Adapter;

public interface IRoundPeg
{
	public int GetRadius();
}

public class RoundPeg : IRoundPeg
{
	private readonly int radius;
	public RoundPeg(int radius)
	{
		this.radius= radius;
	}
    public int GetRadius()
    {
        return radius;
    }
}


