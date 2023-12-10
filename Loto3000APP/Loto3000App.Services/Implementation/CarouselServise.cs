using Azure.Core;
using Loto3000App.Services.Interfaces;

namespace Loto3000App.Services.Implementation
{
    public class CarouselServise : ICarouselInteface
    {
        public List<int> DraftNumbers()
        {
            List<int> result = new List<int>();
            Random rnd = new Random();
            while (result.Count < 8)
            {
                int number = rnd.Next(1, 37);
                if (!result.Contains(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
