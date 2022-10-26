using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Frog : IEnumerable<int>
    {
        private List<int> Pond;

        public Frog(params int[] pond)
        {
            Pond = new List<int>(pond);
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Pond.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return Pond[i];
                }
            }
            bool even = Pond.Count % 2 == 0;

            for (int i = Pond.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return Pond[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
