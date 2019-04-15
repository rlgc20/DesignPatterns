using System.Text;

namespace DesignPatterns.Decorador
{
    public class ZipDecorator : ChannelDecorator
    {
        protected IChannel ch2;

        public ZipDecorator(IChannel ch1)
        {
            this.channel = ch2;
            new ChannelDecorator(ch2);
        }

        public void Send()
        {
            new ChannelDecorator(ch2).Send(Encoding.ASCII.GetBytes("compactacao de vetor"));
        }

        public byte[] Recv()
        {
            new ChannelDecorator(ch2).Recv();
            byte[] m = Encoding.ASCII.GetBytes("descompactacao de vetor");
            return m;
        }
    }
}
