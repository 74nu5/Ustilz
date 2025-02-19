namespace Ustilz.Network;

using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

using JetBrains.Annotations;

/// <summary>
///     Provides functionality to send Wake-on-LAN (WoL) magic packets to wake up computers on the network.
/// </summary>
[PublicAPI]
public static partial class WakeOnLan
{
    /// <summary>
    ///     Sends a Wake-on-LAN (WoL) magic packet to the specified MAC address.
    /// </summary>
    /// <param name="macAddress">The MAC address of the target device to wake up.</param>
    public static void Wake(string macAddress)
    {
        ArgumentNullException.ThrowIfNull(macAddress);

        var macAddressSanitize = GetReplacePattern().Replace(macAddress, string.Empty); // Remove any separators
        var payload = new byte[1024];
        var payloadIndex = 0;

        // Add 6 bytes with value 255 (FF) in our payload
        for (var i = 0; i < 6; i++)
        {
            payload[payloadIndex++] = 255;
        }

        // Repeat the device MAC address sixteen times
        for (var j = 0; j < 16; j++)
        {
            for (var k = 0; k < macAddressSanitize.Length; k += 2)
            {
                var s = macAddressSanitize.Substring(k, 2);
                payload[payloadIndex++] = byte.Parse(s, NumberStyles.HexNumber);
            }
        }

        using var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        sock.EnableBroadcast = true;
        sock.SendTo(payload, new IPEndPoint(IPAddress.Broadcast, 9)); // Port 9 is the discard port
    }

    /// <summary>
    ///     Gets the regular expression pattern to replace MAC address separators.
    /// </summary>
    /// <returns>A <see cref="Regex" /> object to match MAC address separators.</returns>
    [GeneratedRegex("[-|:]")]
    private static partial Regex GetReplacePattern();
}
