using System.Runtime.InteropServices;

namespace d9.TreeSitter;

public static partial class Languages
{
    public const string TREESITTER_DLL = "TODO";

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint agda();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint bash();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint c();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint cSharp();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint cpp();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint css();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint dart();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint elm();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint embeddedTemplate();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint eno();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint go();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint haskell();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint html();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint java();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint javascript();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint julia();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint kotlin();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint lua();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint markdown();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint ocaml();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint php();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint python();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint ruby();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint rust();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint scala();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint scss();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint swift();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint toml();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint tsx();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint typescript();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint vue();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint yaml();

    [LibraryImport(TREESITTER_DLL)]
    private static partial nint wasm();
}
