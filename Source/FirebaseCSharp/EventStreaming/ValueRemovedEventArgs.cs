using System;

namespace FirebaseCSharp.EventStreaming
{
    public class ValueRemovedEventArgs : EventArgs
    {
        public ValueRemovedEventArgs(string path)
        {
            Path = path;
        }

        public string Path { get; private set; }
    }
}