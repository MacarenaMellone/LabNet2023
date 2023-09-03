using Practica04.Linq.Data;

namespace Practica04.Linq.Logic
{
    public class BaseLogic
    {
        public readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
