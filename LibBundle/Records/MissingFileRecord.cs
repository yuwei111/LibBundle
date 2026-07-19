using System;
using System.IO;

namespace LibBundle.Records
{
    public class MissingFileRecord  FileRecord
    {
        public MissingFileRecord(string path, ulong hash)
             base(new BinaryReader(new MemoryStream()))
        {
            this.path = path;
            NameHash = hash;

            BundleIndex = -1;
            Offset = 0;
            Size = 0;

            bundleRecord = null;
            parent = null;
        }


        public override byte[] Read(Stream stream = null)
        {
            throw new FileNotFoundException(
                $Missing file record {path}
            );
        }


        public override void Write(byte[] data)
        {
            throw new InvalidOperationException(
                $Cannot write missing file {path}
            );
        }


        public override void Move(BundleRecord target)
        {
            throw new InvalidOperationException(
                $Cannot move missing file {path}
            );
        }
    }
}