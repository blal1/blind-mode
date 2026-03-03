using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace YgomSystem.Video;

[Token(Token = "0x20001E5")]
public class MDVideoPlayerBase
{
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x10")]
	protected VideoPlayer videoPlayer;

	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x40")]
	public Action onDestroy;

	[Token(Token = "0x17000142")]
	public virtual VideoSource source
	{
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0xC0EAE0", Offset = "0xC0DCE0", VA = "0x180C0EAE0", Slot = "4")]
		get
		{
			return default(VideoSource);
		}
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0xC0EE00", Offset = "0xC0E000", VA = "0x180C0EE00", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000143")]
	public virtual long frame
	{
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0xC0EA60", Offset = "0xC0DC60", VA = "0x180C0EA60", Slot = "6")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0xC0EDE0", Offset = "0xC0DFE0", VA = "0x180C0EDE0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000144")]
	public virtual ulong frameCount
	{
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0xC0EA20", Offset = "0xC0DC20", VA = "0x180C0EA20", Slot = "8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000145")]
	public virtual bool isPaused
	{
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xC0EA80", Offset = "0xC0DC80", VA = "0x180C0EA80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000146")]
	public virtual bool isLooping
	{
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000147")]
	public virtual string url
	{
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0xC0EB20", Offset = "0xC0DD20", VA = "0x180C0EB20", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0xC0EE40", Offset = "0xC0E040", VA = "0x180C0EE40", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x17000148")]
	public virtual RenderTexture targetTexture
	{
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xC0EB00", Offset = "0xC0DD00", VA = "0x180C0EB00", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0xC0EE20", Offset = "0xC0E020", VA = "0x180C0EE20", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x17000149")]
	public virtual VideoClip clip
	{
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0xC0E9E0", Offset = "0xC0DBE0", VA = "0x180C0E9E0", Slot = "16")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0xC0EDC0", Offset = "0xC0DFC0", VA = "0x180C0EDC0", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x1700014A")]
	public virtual bool isPrepared
	{
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0xC0EAA0", Offset = "0xC0DCA0", VA = "0x180C0EAA0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700014B")]
	public virtual float frameRate
	{
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0xC0EA40", Offset = "0xC0DC40", VA = "0x180C0EA40", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700014C")]
	public virtual double length
	{
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0xC0EAC0", Offset = "0xC0DCC0", VA = "0x180C0EAC0", Slot = "20")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700014D")]
	public virtual double clockTime
	{
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xC0EA00", Offset = "0xC0DC00", VA = "0x180C0EA00", Slot = "21")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x14000005")]
	public virtual event VideoPlayer.EventHandler prepareCompleted
	{
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xC0E8A0", Offset = "0xC0DAA0", VA = "0x180C0E8A0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0xC0EC80", Offset = "0xC0DE80", VA = "0x180C0EC80", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public virtual event VideoPlayer.EventHandler loopPointReached
	{
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0xC0E800", Offset = "0xC0DA00", VA = "0x180C0E800", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0xC0EBE0", Offset = "0xC0DDE0", VA = "0x180C0EBE0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public virtual event VideoPlayer.ErrorEventHandler errorReceived
	{
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0xC0E760", Offset = "0xC0D960", VA = "0x180C0E760", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0xC0EB40", Offset = "0xC0DD40", VA = "0x180C0EB40", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public virtual event VideoPlayer.EventHandler started
	{
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0xC0E940", Offset = "0xC0DB40", VA = "0x180C0E940", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0xC0ED20", Offset = "0xC0DF20", VA = "0x180C0ED20", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0xC0E5D0", Offset = "0xC0D7D0", VA = "0x180C0E5D0")]
	public MDVideoPlayerBase(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6000B89")]
	[Address(RVA = "0xC0E4F0", Offset = "0xC0D6F0", VA = "0x180C0E4F0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x5CE6F0", Offset = "0x5CD8F0", VA = "0x1805CE6F0")]
	private void OnPreparecompleted(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0xC0E530", Offset = "0xC0D730", VA = "0x180C0E530")]
	private void OnLoopPointReached(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0xC0E510", Offset = "0xC0D710", VA = "0x180C0E510")]
	private void OnErrorReceived(VideoPlayer source, string message)
	{
	}

	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x406F30", Offset = "0x406130", VA = "0x180406F30")]
	private void OnStarted(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0xC0E570", Offset = "0xC0D770", VA = "0x180C0E570", Slot = "30")]
	public virtual void Play()
	{
	}

	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0xC0E590", Offset = "0xC0D790", VA = "0x180C0E590", Slot = "31")]
	public virtual void Prepare()
	{
	}

	[Token(Token = "0x6000B90")]
	[Address(RVA = "0xC0E550", Offset = "0xC0D750", VA = "0x180C0E550", Slot = "32")]
	public virtual void Pause()
	{
	}

	[Token(Token = "0x6000B91")]
	[Address(RVA = "0xC0E5B0", Offset = "0xC0D7B0", VA = "0x180C0E5B0", Slot = "33")]
	public virtual void Stop()
	{
	}

	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "34")]
	public virtual void ClearBuffer(Color color)
	{
	}
}
