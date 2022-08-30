using System;
namespace KenBox_csharp
{
    public class KenBox
    {
        private readonly KenBox containedBox;

        public KenBox() { }

        public KenBox(KenBox box)
        {
            this.containedBox = box;
        }

        public int getNumberOfChildBoxesRecurse(KenBox box)
        {
            if (box.containedBox is KenBox)
            {
                return getNumberOfChildBoxesRecurse(box.containedBox) + 1;
            }
            return 0;
        }

        public int NumberOfContainedBoxesRecursive
        {
            get
            {
                return getNumberOfChildBoxesRecurse(this);
            }
        }

        public int NumberOfContainedBoxesIterative
        {
            get
            {
                int i = 0;
                KenBox child = this.containedBox;
                while (child is KenBox)
                {
                    i++;
                    if (child.containedBox is KenBox) { child = child.containedBox;  }
                    else { child = null; }
                }
                return i;
            }
        }
    }
}

