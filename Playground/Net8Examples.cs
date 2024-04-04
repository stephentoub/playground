using System.Buffers;

namespace Playground;

public static class Net8Examples
{
    private static readonly SearchValues<char> s_hexChars = SearchValues.Create("0123456789abcdefABCDEF");

    public static int FindFirstHexChar(ReadOnlySpan<char> span) => span.IndexOfAny(s_hexChars);
}