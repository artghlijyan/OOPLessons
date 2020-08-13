using System.Collections;

namespace OOPLessons.Struct
{
    readonly struct FirstStruct
    {
        readonly int id;

        public FirstStruct(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"ID = {this.id}";
        }
    }
}
