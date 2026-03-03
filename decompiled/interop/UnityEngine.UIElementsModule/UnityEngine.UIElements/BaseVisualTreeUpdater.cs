using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000508")]
internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x10")]
	private long frameCount;

	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x20")]
	private BaseVisualElementPanel m_Panel;

	[Token(Token = "0x1700096E")]
	private long UnityEngine_002EUIElements_002EIVisualTreeUpdater_002EFrameCount
	{
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80", Slot = "4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x9941A0", Offset = "0x9933A0", VA = "0x1809941A0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700096F")]
	public BaseVisualElementPanel panel
	{
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x276ACD0", Offset = "0x2769ED0", VA = "0x18276ACD0", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x2A2A950", Offset = "0x2A29B50", VA = "0x182A2A950", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000970")]
	public VisualElement visualTree
	{
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x2A2A870", Offset = "0x2A29A70", VA = "0x182A2A870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000971")]
	public abstract ProfilerMarker profilerMarker
	{
		[Token(Token = "0x600242C")]
		get;
	}

	[Token(Token = "0x14000030")]
	public event Action<BaseVisualElementPanel> panelChanged
	{
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x2A2A7C0", Offset = "0x2A299C0", VA = "0x182A2A7C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x2A2A8A0", Offset = "0x2A29AA0", VA = "0x182A2A8A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0x2A2A750", Offset = "0x2A29950", VA = "0x182A2A750", Slot = "10")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600242F")]
	public abstract void Update();

	[Token(Token = "0x6002430")]
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

	[Token(Token = "0x6002431")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseVisualTreeUpdater()
	{
	}
}
