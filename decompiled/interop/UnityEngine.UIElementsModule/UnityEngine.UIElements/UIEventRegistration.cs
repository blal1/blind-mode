using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000472")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class UIEventRegistration
{
	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x0")]
	private static List<IUIElementsUtility> s_Utilities;

	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x2A19F80", Offset = "0x2A19180", VA = "0x182A19F80")]
	static UIEventRegistration()
	{
	}

	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x2A19C40", Offset = "0x2A18E40", VA = "0x182A19C40")]
	internal static void RegisterUIElementSystem(IUIElementsUtility utility)
	{
	}

	[Token(Token = "0x60021AB")]
	[Address(RVA = "0x2A19E20", Offset = "0x2A19020", VA = "0x182A19E20")]
	private static void TakeCapture()
	{
	}

	[Token(Token = "0x60021AC")]
	[Address(RVA = "0x2A19CC0", Offset = "0x2A18EC0", VA = "0x182A19CC0")]
	private static void ReleaseCapture()
	{
	}

	[Token(Token = "0x60021AD")]
	[Address(RVA = "0x2A19690", Offset = "0x2A18890", VA = "0x182A19690")]
	private static bool EndContainerGUIFromException(Exception exception)
	{
		return default(bool);
	}

	[Token(Token = "0x60021AE")]
	[Address(RVA = "0x2A19A30", Offset = "0x2A18C30", VA = "0x182A19A30")]
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr)
	{
		return default(bool);
	}

	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x2A19530", Offset = "0x2A18730", VA = "0x182A19530")]
	private static void CleanupRoots()
	{
	}

	[Token(Token = "0x60021B0")]
	[Address(RVA = "0x2A198D0", Offset = "0x2A18AD0", VA = "0x182A198D0")]
	internal static void MakeCurrentIMGUIContainerDirty()
	{
	}
}
