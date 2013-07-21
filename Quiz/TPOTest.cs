using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace TPO.Quiz
{
	class TPOTest : IEnumerable/*, TPOTestAction*/
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

    interface TPOTestAction
    {
        public bool IsTestNotPractice();
        public int GetTPONO();
        private void renewTPO(int no);
        public void StartTest(int tpono);
        public void StartTestFromPart(int tpono, string part);
    }
}
