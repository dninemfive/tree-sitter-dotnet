using System.Text;

namespace d9.TreeSitter;
public class Parser : IDisposable
{
    private nint pointer;
    internal Parser(nint pointer)
        => this.pointer = pointer;
    public Parser() : this(TreeSitter.ParserNew()) { }
    public nint Language { set => TreeSitter.ParserSetLanguage(pointer, value); }
    // https://stackoverflow.com/a/18698172
    public Tree ParseString(string source)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(source);
        return new Tree(TreeSitter.ParserParseBytes(pointer, bytes, bytes.Length));
    }
    private bool _disposed = false;
    public void Dispose()
    {
        if(!_disposed)
        {
            TreeSitter.ParserDelete(pointer);
            _disposed = true;
            GC.SuppressFinalize(this);
        }
    }
    public Node RootNode
        => TreeSitter.TreeRootNode(pointer);
}
