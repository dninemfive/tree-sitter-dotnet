using System.Runtime.InteropServices.Marshalling;

namespace d9.TreeSitter;
public readonly struct TreeCursorNode(string @type, string @name, int @startByte, int @endByte)
{
    internal readonly string type = @type, name = @name;
    internal readonly int startByte = @startByte, endByte = @endByte;
    public string Type => type;
    public string Name => name;
    public int StartByte => startByte;
    public int EndByte => endByte;
}
