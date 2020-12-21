using OOPLessons.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOPLessons.Helpers
{
    class IdComparisonHelper : IComparer,IComparer<Id>
    {
        public int Compare(object obj1, object obj2)
        {
            Id id1 = obj1 as Id;
            Id id2 = obj2 as Id;

            if (id1.ID < id2.ID)
            {
                return -1;
            }

            if (id1.ID > id2.ID)
            {
                return 1;
            }

            return 0;
        }

        public int Compare([AllowNull] Id id1, [AllowNull] Id id2)
        {
            if (id1.ID < id2.ID)
            {
                return -1;
            }

            if (id1.ID > id2.ID)
            {
                return 1;
            }

            return 0;
        }
    }
}
