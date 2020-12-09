using System;

namespace OOPLessons.Interfaces
{
    // 1. Երբ պետք է բազային ֆունկցիոնալ բոլոր ժառանգ տիպերում ->
    // 2. Երբ պետ է որ ժառանգ տիպերը ունենան որոշակի ֆունկցիոնալի ընդհանուր ռեալիզացիա

    // Երբ պետք է ստեղծել որոշակի ֆունկցիոնալ ցվրված օբյեկտների համար, որոնք կարող ենք ոչնչով կապված չլինել իրար հետ

    // private static
    // if method not public -> explicit implementation
    // abstract class can make interface member abstract to put duty of implementation on a child class

    // interface inheritance example
    // IClonable
    // IComparable or IComparer

    interface IMyInterface
    {
        public void Do();
    }

    interface IMyInterface2 
    {
        public string Do(int a);
    }

    class MyClass : IMyInterface, IMyInterface2
    {
        public void Do()
        {
            throw new NotImplementedException();
        }

        public string Do(int a)
        {
            throw new NotImplementedException();
        }
    }
}
