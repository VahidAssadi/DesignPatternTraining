namespace DesignPattern.Decorator
{
    public interface IStream
    {
        void Write(string data);
    }

    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class StreamDecorator : IStream
    {
        private IStream _stream;
        public StreamDecorator(IStream stream)
        {

            _stream = stream;
        }

        public virtual void Write(string data)
        {
            _stream.Write(data);
        }
    }
    public class EncryptedCloudStream : StreamDecorator
    {
        private readonly IStream _stream;

        public EncryptedCloudStream(IStream stream) : base(stream)
        {
            _stream = stream;
        }

        private string EncryptStream(string data)
        {
            return "dsfssffssfadas";
        }
        public override void Write(string data)
        {
            var encrypted = EncryptStream(data);
            _stream.Write(encrypted);
        }
    }
    public class CompressedCloudStream : StreamDecorator
    {
        private readonly IStream _stream;

        public CompressedCloudStream(IStream stream) : base(stream)
        {
            _stream = stream;
        }

        private string Compress(string data)
        {
            return "dsfssffssfadas";
        }

        public override void Write(string data)
        {
            var compressed = Compress(data);

            _stream.Write(compressed);
        }
    }
}
