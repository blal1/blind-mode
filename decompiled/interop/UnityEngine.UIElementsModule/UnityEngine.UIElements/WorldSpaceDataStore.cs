using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200050A")]
internal static class WorldSpaceDataStore
{
	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<uint, WorldSpaceData> m_WorldSpaceData;

	[Token(Token = "0x6002433")]
	[Address(RVA = "0x2A43010", Offset = "0x2A42210", VA = "0x182A43010")]
	public static void SetWorldSpaceData(VisualElement ve, WorldSpaceData data)
	{
	}

	[Token(Token = "0x6002434")]
	[Address(RVA = "0x2A42F50", Offset = "0x2A42150", VA = "0x182A42F50")]
	public static WorldSpaceData GetWorldSpaceData(VisualElement ve)
	{
		return default(WorldSpaceData);
	}
}
