using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_Desktop_App.Models
{
    public static class ShuffleHelper
    {
        private static Random random = new Random();

        public static void Shuffle<T>(ObservableCollection<T> collection)
        {
            int n = collection.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = collection[k];
                collection[k] = collection[n];
                collection[n] = value;
            }
        }
    }
}
