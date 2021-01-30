using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketMockServer.WebSockets
{
    /// <summary>
    /// Wrapper that gives abstraction of <see cref="WebSocket"/> for other layers.
    /// </summary>
    public interface IWebSocketProxy
    {
        /// <summary>
        /// Closes web socket
        /// </summary>

        public Task CloseAsync(CancellationToken ct);

        /// <summary>
        /// Sends message to web socket
        /// </summary>
        public Task SendMessageAsync(string msg, CancellationToken ct);

        /// <summary>
        /// Receives data from web socket.
        /// </summary>
        public ValueTask<ValueWebSocketReceiveResult> ReceiveAsync(Memory<byte> buffer, CancellationToken ct);

        /// <summary>
        /// Web socket state.
        /// </summary>
        public WebSocketState State { get; }
    }
}
