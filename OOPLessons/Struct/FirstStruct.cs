using System.Collections;

namespace OOPLessons.Struct
{
    struct FirstStruct
    {
        int id;

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
