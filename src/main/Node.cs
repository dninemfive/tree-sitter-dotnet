namespace d9.TreeSitter;
public readonly struct Node
{
    internal readonly int context0, context1, context2, context3;
    internal readonly nint id, tree;
    public Node() { }
    public Node this[int child]
        => TreeSitter.NodeChild(this, child);
    public int ChildCount
        => TreeSitter.NodeChildCount(this);
    public bool HasError
        => TreeSitter.NodeHasError(this);
    public int EndByte
        => TreeSitter.NodeEndByte(this);
    public override string ToString()
        => TreeSitter.NodeString(this);
    public int StartByte
        => TreeSitter.NodeStartByte(this);
    public string Type
        => TreeSitter.NodeType(this);
    public TreeCursor Walk()
        => new TreeCursor(TreeSitter.TreeCursorNew(this));
}
