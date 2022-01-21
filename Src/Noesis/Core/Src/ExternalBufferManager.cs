
namespace Noesis
{
    using System;

    public static class ExternalBufferManager
    {
        private static IBufferManager BufferManager;

        public interface IBufferManager
        {
            public abstract ByteArraySegment Rent(int minSize);

            public abstract void Return(ref ByteArraySegment buffer);
        }

        public static ByteArraySegment Rent(int minSize) => BufferManager.Rent(minSize);

        public static void Return(ref ByteArraySegment buffer) => BufferManager.Return(ref buffer);

        public static void Setup(IBufferManager bufferManager)
        {
            BufferManager = bufferManager;
        }

        public readonly struct ByteArraySegment
        {
            public static readonly ByteArraySegment Empty = new ByteArraySegment(Array.Empty<byte>(), 0);

            public readonly int Length;

            private readonly byte[] data;

            public ByteArraySegment(byte[] data, int length)
            {
                this.data = data;
                this.Length = length;
            }

            public byte[] Data => this.data ?? Array.Empty<byte>();
        }
    }
}