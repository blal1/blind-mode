using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001F0")]
[EventCategory(EventCategory.Geometry)]
public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
{
	[Token(Token = "0x17000278")]
	public Rect oldRect
	{
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x152EA40", Offset = "0x152DC40", VA = "0x18152EA40")]
		[CompilerGenerated]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x152EC60", Offset = "0x152DE60", VA = "0x18152EC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000279")]
	public Rect newRect
	{
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x152E910", Offset = "0x152DB10", VA = "0x18152E910")]
		[CompilerGenerated]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x152EB30", Offset = "0x152DD30", VA = "0x18152EB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700027A")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int layoutPass
	{
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x865350", Offset = "0x864550", VA = "0x180865350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x8653A0", Offset = "0x8645A0", VA = "0x1808653A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x2B17080", Offset = "0x2B16280", VA = "0x182B17080")]
	static GeometryChangedEvent()
	{
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x2B16F50", Offset = "0x2B16150", VA = "0x182B16F50")]
	public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
	{
		return null;
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x2B16FD0", Offset = "0x2B161D0", VA = "0x182B16FD0", Slot = "13")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x2B17040", Offset = "0x2B16240", VA = "0x182B17040")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x2B17160", Offset = "0x2B16360", VA = "0x182B17160")]
	public GeometryChangedEvent()
	{
	}
}
