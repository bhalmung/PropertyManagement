using System;

namespace attribute
{
    internal class FileAttribute : Attribute
    {
        public string File;

        public FileAttribute(string v)
        {
            this.File = v;
        }
    }
}