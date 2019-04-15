namespace DesignPatterns.Decorador
{
    public class ChannelDecorator : IChannel
    {
        protected IChannel channel;

        public ChannelDecorator(IChannel ch)
        {
            channel = ch;
        }

        public void Send(byte[] m)
        {
            channel.Send(m);
        }

        public byte[] Recv()
        {
            return channel.Recv();
        }

    }
}
