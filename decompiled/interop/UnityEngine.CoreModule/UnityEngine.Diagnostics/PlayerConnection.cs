using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Diagnostics;

public static class PlayerConnection
{
	public static bool connected => UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected;

	public static void SendFile(string remoteFilePath, Il2CppStructArray<byte> data)
	{
	}
}
