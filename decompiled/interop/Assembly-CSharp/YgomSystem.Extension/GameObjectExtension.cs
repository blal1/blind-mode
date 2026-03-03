using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Extension;

[Token(Token = "0x2000358")]
public static class GameObjectExtension
{
	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x5234D0", Offset = "0x5226D0", VA = "0x1805234D0")]
	public static GameObject SafeRef(this GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60014F4")]
	public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60014F5")]
	public static T AddOrReplaceComponent<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60014F6")]
	public static void RemoveComponent<T>(this GameObject gameObject) where T : Component
	{
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x523790", Offset = "0x522990", VA = "0x180523790")]
	public static void SetSurfaceActive(this GameObject gameObject, bool value, params Selector[] selectors)
	{
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x523530", Offset = "0x522730", VA = "0x180523530")]
	public static void SetSurfaceActive(this GameObject gameObject, bool value, IReadOnlyList<Selector> selectors)
	{
	}

	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x5238B0", Offset = "0x522AB0", VA = "0x1805238B0")]
	public static void SetSurfaceActive(this GameObject gameObject, bool value, IReadOnlyList<SelectionItem> selectionItems)
	{
	}

	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x523370", Offset = "0x522570", VA = "0x180523370")]
	public static bool GetSurfaceActive(this GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x523440", Offset = "0x522640", VA = "0x180523440")]
	public static void PlayTweenLabel(this GameObject obj, string label = "", bool includeChildren = false, bool wakeup = false)
	{
	}

	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x523B10", Offset = "0x522D10", VA = "0x180523B10")]
	public static void StopTweenLabels(this GameObject obj, string[] labels, bool includeChildren = false)
	{
	}

	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x523320", Offset = "0x522520", VA = "0x180523320")]
	public static void DestroyWithEditModeCheck(Object obj)
	{
	}
}
