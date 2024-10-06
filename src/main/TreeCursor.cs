namespace d9.TreeSitter;
public class TreeCursor : IDisposable
{
    internal int context0, context1;
    internal long id;
    internal nint pointer, tree;
    internal TreeCursor(nint pointer)
        => this.pointer = pointer;
    public Node CurrentNode
        => TreeSitter.TreeCursorCurrentNode(pointer);
    public string CurrentFieldName
        => TreeSitter.TreeCursorCurrentFieldName(pointer);
    public TreeCursorNode CurrentTreeCursorNode
        => TreeSitter.TreeCursorCurrentTreeCursorNode(pointer);
    public bool GotoFirstChild()
        => TreeSitter.TreeCursorGotoFirstChild(pointer);
    public bool GotoNextSibling()
        => TreeSitter.TreeCursorGotoNextSibling(pointer);
    public bool GotoParent()
        => TreeSitter.TreeCursorGotoParent(pointer);
    private bool _disposed = false;
    public void Dispose()
    {
        if(!_disposed)
        {
            TreeSitter.TreeCursorDelete(pointer);
            _disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
