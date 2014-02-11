using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class Program
   {
      static void Main(string[] args)
      {
         OurList myList = new OurList();
         for (int i = 0; i < 10; i++)
            myList.PushBack(i);

         Console.WriteLine("The 5th value on the list is {0}", myList.GetNthValue(5));

         Console.WriteLine();
         Console.WriteLine("Press any key to continue ...");
         Console.ReadKey();
      }
   }

   public class OurList
   {
      private class OurListNode
      {
         public double mData { get; set; }
         public OurListNode mNext { get; set; }
         public OurListNode(double d = 0, OurListNode ln = null)
         {
            mData = d;
            mNext = ln;
         }
      }

      private OurListNode mFirst;
      

      public double GetNthValue(int input) // **my code here** hops along list specified amount
      {
         OurListNode pTemp= mFirst;
         if (pTemp != null)
         {
            for (int i = 0; i < input; i++)
            {
               pTemp = pTemp.mNext;
            }
            return pTemp.mData;          
         }

         else
         {return 0;}         
      }

      public OurList()     // shown in class notes
      {
         mFirst = null;
      }

      public void Clear()     // shown in class notes
      {
         mFirst = null;
      }

      public void PushFront(double number)     // shown in class notes
      {
         mFirst = new OurListNode(number, mFirst);
      }

      public void PopFront()     // shown in class notes
      {
         if (mFirst != null)
            mFirst = mFirst.mNext;
      }

      public void PushBack(double number)     // shown in class notes
      {
         if (mFirst == null)
            PushFront(number);
         else
         {
            OurListNode mTmp = mFirst;
            while (mTmp.mNext != null)
               mTmp = mTmp.mNext;

            mTmp.mNext = new OurListNode(number, null);
         }
      }

      public void PopBack()     // shown in class notes
      {
         if (mFirst == null)
            return;
         else if (mFirst.mNext == null)
            PopFront();
         else
         {
            OurListNode pTmp = mFirst;
            while (pTmp.mNext != null && pTmp.mNext.mNext != null)
               pTmp = pTmp.mNext;

            pTmp.mNext = null;
         }
      }

      public void Display()     // shown in class notes
      {
         OurListNode pTmp = mFirst;
         while (pTmp != null)
         {
            Console.Write("{0}, ", pTmp.mData);
            pTmp = pTmp.mNext;
         }
         Console.WriteLine();
      }

      public bool isEmpty()     // shown in class notes
      {
         if (mFirst == null)
            return true;
         else
            return false;
      }
      public OurList(OurList aList)   // a Deep copy
      {
         mFirst = null;
         OurListNode pCopy = aList.mFirst;

         while (pCopy != null)
         {
            PushBack(pCopy.mData);
            pCopy = pCopy.mNext;
         }
      }
   }
}

/* Read out:
 * 
 * The 5th value on the list is 6

Press any key to continue ...


*/
