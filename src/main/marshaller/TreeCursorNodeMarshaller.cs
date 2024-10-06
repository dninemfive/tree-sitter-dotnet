using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace d9.TreeSitter;
[CustomMarshaller(typeof(TreeCursorNode), MarshalMode.Default, typeof(TreeCursorNodeMarshaller))]
internal unsafe static class TreeCursorNodeMarshaller
{
    internal readonly struct Unmanaged(TreeCursorNode tcn)
    {
        internal readonly string type = tcn.type, name = tcn.name;
        internal readonly int startByte = tcn.startByte, endByte = tcn.endByte;
    }
    public static Unmanaged ConvertToUnmanaged(TreeCursorNode managed)
        => new(managed);
    public static TreeCursorNode ConvertToManaged(Unmanaged unmanaged)
        => new(unmanaged.type, unmanaged.name, unmanaged.startByte, unmanaged.endByte);
}
