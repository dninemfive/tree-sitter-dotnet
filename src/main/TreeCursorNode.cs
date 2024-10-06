﻿using System.Runtime.InteropServices.Marshalling;

namespace d9.TreeSitter;
public readonly struct TreeCursorNode
{
    public readonly string Type, Name;
    public readonly int StartByte, EndByte;
    public TreeCursorNode(string type, string name, int startByte, int endByte)
    {
        Type = type;
        Name = name;
        StartByte = startByte;
        EndByte = endByte;
    }
}
