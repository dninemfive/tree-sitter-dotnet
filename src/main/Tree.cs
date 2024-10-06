namespace d9.TreeSitter;
public class Tree : IDisposable
{
    private nint pointer;
    internal Tree(nint pointer)
        => this.pointer = pointer;
    public Node RootNode
        => TreeSitter.TreeRootNode(pointer);
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
