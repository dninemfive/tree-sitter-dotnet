using d9.TreeSitter;
using System.Runtime.InteropServices;

namespace d9.TreeSitter;
// TODO: is BStr the correct string marshal type?
// see https://learn.microsoft.com/en-us/dotnet/framework/interop/default-marshalling-for-strings and TreeSitter source
internal static partial class TreeSitter
{
    private const string TREESITTER_DLL = "todo";

    internal static Node NodeChild(Node node, int child) => nodeChild(node, child);
    [LibraryImport(TREESITTER_DLL)]
    private static partial Node nodeChild(Node node, int child);

    internal static int NodeChildCount(Node node) => nodeChildCount(node);
    [LibraryImport(TREESITTER_DLL)]
    private static partial int nodeChildCount(Node node);

    internal static bool NodeHasError(Node node) => nodeHasError(node);
    [LibraryImport(TREESITTER_DLL)]
    [return:MarshalAs(UnmanagedType.Bool)]
    private static partial bool nodeHasError(Node node);

    internal static int NodeEndByte(Node node) => nodeEndByte(node);
    [LibraryImport(TREESITTER_DLL)]
    private static partial int nodeEndByte(Node node);

    internal static int NodeStartByte(Node node) => nodeStartByte(node);
    [LibraryImport(TREESITTER_DLL)]
    private static partial int nodeStartByte(Node node);

    internal static string NodeString(Node node) => nodestring(node);
    [LibraryImport(TREESITTER_DLL)]
    [return: MarshalAs(UnmanagedType.BStr)]
    private static partial string nodestring(Node node);

    internal static string NodeType(Node node) => nodeType(node);
    [LibraryImport(TREESITTER_DLL)]
    [return: MarshalAs(UnmanagedType.BStr)]
    private static partial string nodeType(Node node);

    internal static nint ParserNew() => parserNew();
    [LibraryImport(TREESITTER_DLL)]
    private static partial nint parserNew();

    internal static void ParserDelete(nint parser) => parserDelete(parser);
    [LibraryImport(TREESITTER_DLL)]
    private static partial void parserDelete(nint parser);

    internal static void ParserSetLanguage(nint parser, nint language) => parserSetLanguage(parser, language);
    [LibraryImport(TREESITTER_DLL)]
    private static partial void parserSetLanguage(nint parser, nint language);

    internal static nint ParserParseBytes(nint parser, byte[] source, int length) => parserParseBytes(parser, source, length);
    [LibraryImport(TREESITTER_DLL)]
    private static partial nint parserParseBytes(nint parser, byte[] source, int length);

    internal static nint TreeCursorNew(Node node) => treeCursorNew(node);
    [LibraryImport(TREESITTER_DLL)]
    private static partial nint treeCursorNew(Node node);

    internal static TreeCursorNode TreeCursorCurrentTreeCursorNode(nint cursor) => treeCursorCurrentTreeCursorNode(cursor);
    [LibraryImport(TREESITTER_DLL)]
    private static partial TreeCursorNode treeCursorCurrentTreeCursorNode(nint cursor);

    internal static string TreeCursorCurrentFieldName(nint cursor) => treeCursorCurrentFieldName(cursor);
    [LibraryImport(TREESITTER_DLL)]
    [return: MarshalAs(UnmanagedType.BStr)]
    private static partial string treeCursorCurrentFieldName(nint cursor);

    internal static Node TreeCursorCurrentNode(nint cursor) => treeCursorCurrentNode(cursor);
    [LibraryImport(TREESITTER_DLL)]
    private static partial Node treeCursorCurrentNode(nint cursor);

    internal static void TreeCursorDelete(nint cursor) => treeCursorDelete(cursor);
    [LibraryImport(TREESITTER_DLL)]
    private static partial void treeCursorDelete(nint cursor);

    internal static bool TreeCursorGotoFirstChild(nint cursor) => treeCursorGotoFirstChild(cursor);
    [LibraryImport(TREESITTER_DLL)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool treeCursorGotoFirstChild(nint cursor);

    internal static bool TreeCursorGotoNextSibling(nint cursor) => treeCursorGotoNextSibling(cursor);
    [LibraryImport(TREESITTER_DLL)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool treeCursorGotoNextSibling(nint cursor);

    internal static bool TreeCursorGotoParent(nint cursor) => treeCursorGotoParent(cursor);
    [LibraryImport(TREESITTER_DLL)]
    [return:MarshalAs(UnmanagedType.Bool)]
    private static partial bool treeCursorGotoParent(nint cursor);

    internal static void TreeDelete(nint tree) => treeDelete(tree);
    [LibraryImport(TREESITTER_DLL)]
    private static partial void treeDelete(nint tree);

    internal static Node TreeRootNode(nint tree) => treeRootNode(tree);
    [LibraryImport(TREESITTER_DLL)]
    private static partial Node treeRootNode(nint tree);
}
