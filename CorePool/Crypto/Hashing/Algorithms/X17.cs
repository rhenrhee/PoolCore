using System;
using CorePool.Contracts;
using CorePool.Native;

namespace CorePool.Crypto.Hashing.Algorithms
{
    public unsafe class X17 : IHashAlgorithm
    {
        public void Digest(ReadOnlySpan<byte> data, Span<byte> result, params object[] extra)
        {
            Contract.Requires<ArgumentException>(result.Length >= 32, $"{nameof(result)} must be greater or equal 32 bytes");

            fixed (byte* input = data)
            {
                fixed (byte* output = result)
                {
                    LibMultihash.x17(input, output, (uint) data.Length);
                }
            }
        }
    }
}
