namespace DesignPatterns.Decorador
{
    public interface IChannel
    {
        void Send(byte[] m);
        byte[] Recv();
    }
}
