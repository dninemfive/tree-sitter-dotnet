using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace d9.TreeSitter;
// https://stackoverflow.com/a/1985651
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public readonly struct TreeCursorNode(string type, string name, int startByte, int endByte)
{
    [MarshalAs(UnmanagedType.BStr)]
    public readonly string Type = type, Name = name;
    public readonly int StartByte = startByte, EndByte = endByte;
}
