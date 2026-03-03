using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200029A")]
public static class PointerCaptureHelper
{
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x2B6AB80", Offset = "0x2B69D80", VA = "0x182B6AB80")]
	private static PointerDispatchState GetStateFor(IEventHandler handler)
	{
		return null;
	}

	[Token(Token = "0x6001220")]
	[Address(RVA = "0x2B6AC20", Offset = "0x2B69E20", VA = "0x182B6AC20")]
	public static bool HasPointerCapture(this IEventHandler handler, int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001221")]
	[Address(RVA = "0x2B6A920", Offset = "0x2B69B20", VA = "0x182B6A920")]
	public static void CapturePointer(this IEventHandler handler, int pointerId)
	{
	}

	[Token(Token = "0x6001222")]
	[Address(RVA = "0x2B6ADF0", Offset = "0x2B69FF0", VA = "0x182B6ADF0")]
	public static void ReleasePointer(this IEventHandler handler, int pointerId)
	{
	}

	[Token(Token = "0x6001223")]
	[Address(RVA = "0x2B6AAF0", Offset = "0x2B69CF0", VA = "0x182B6AAF0")]
	public static IEventHandler GetCapturingElement(this IPanel panel, int pointerId)
	{
		return null;
	}

	[Token(Token = "0x6001224")]
	[Address(RVA = "0x2B6AEE0", Offset = "0x2B6A0E0", VA = "0x182B6AEE0")]
	public static void ReleasePointer(this IPanel panel, int pointerId)
	{
	}

	[Token(Token = "0x6001225")]
	[Address(RVA = "0x2B6A8A0", Offset = "0x2B69AA0", VA = "0x182B6A8A0")]
	internal static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId)
	{
	}

	[Token(Token = "0x6001226")]
	[Address(RVA = "0x2B6AD00", Offset = "0x2B69F00", VA = "0x182B6AD00")]
	internal static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId)
	{
	}

	[Token(Token = "0x6001227")]
	[Address(RVA = "0x2B6AF70", Offset = "0x2B6A170", VA = "0x182B6AF70")]
	internal static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt)
	{
		return default(bool);
	}

	[Token(Token = "0x6001228")]
	[Address(RVA = "0x2B6AD80", Offset = "0x2B69F80", VA = "0x182B6AD80")]
	internal static void ProcessPointerCapture(this IPanel panel, int pointerId)
	{
	}
}
