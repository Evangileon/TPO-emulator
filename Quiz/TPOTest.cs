using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace TPO.Quiz
{
	class TPOTest : IEnumerable
    {
        int TPONO;

        
        List<TPOPart> Parts;

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (TPOPart p in Parts)
            {
                yield return p;
            }
        }

        public void AddPart(TPOPart part)
        {
            this.Parts.Add(part);
        }
    }
}
