public interface IConnectable
{
    // Establishes a connection.
    void Connect();

    // Terminates the connection.
    void Disconnect();

    // Indicates whether the connection is currently established.
    bool IsConnected { get; }
}