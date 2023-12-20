using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Adapter;

public interface ISquarePeg
{
    public int GetWidth();

}
public class SquarePeg : ISquarePeg
{
	private readonly int width;
	public SquarePeg(int width)
	{
		this.width = width;
	}
    public int GetWidth()
    {
        return width;
    }
}
