using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200053B")]
internal class GradientSettingsAtlas : IDisposable
{
	[Token(Token = "0x200053C")]
	private struct RawTexture
	{
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x0")]
		public Color32[] rgba;

		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x8")]
		public int width;

		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0xC")]
		public int height;

		[Token(Token = "0x6002556")]
		[Address(RVA = "0x2A535F0", Offset = "0x2A527F0", VA = "0x182A535F0")]
		public void WriteRawInt2Packed(int v0, int v1, int destX, int destY)
		{
		}

		[Token(Token = "0x6002557")]
		[Address(RVA = "0x2A53540", Offset = "0x2A52740", VA = "0x182A53540")]
		public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY)
		{
		}
	}

	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x0")]
	private static ProfilerMarker s_MarkerWrite;

	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x8")]
	private static ProfilerMarker s_MarkerCommit;

	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x10")]
	private readonly int m_Length;

	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x14")]
	private readonly int m_ElemWidth;

	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x18")]
	private BestFitAllocator m_Allocator;

	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D m_Atlas;

	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x28")]
	private RawTexture m_RawAtlas;

	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x10")]
	private static int s_TextureCounter;

	[Token(Token = "0x1700098E")]
	internal int length
	{
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x27BFAA0", Offset = "0x27BECA0", VA = "0x1827BFAA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700098F")]
	protected bool disposed
	{
		[Token(Token = "0x6002548")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000990")]
	public Texture2D atlas
	{
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x276ACD0", Offset = "0x2769ED0", VA = "0x18276ACD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000991")]
	public bool MustCommit
	{
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x689960", Offset = "0x688B60", VA = "0x180689960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x74E7C0", Offset = "0x74D9C0", VA = "0x18074E7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600254A")]
	[Address(RVA = "0x2A4B6E0", Offset = "0x2A4A8E0", VA = "0x182A4B6E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600254B")]
	[Address(RVA = "0x2A4B750", Offset = "0x2A4A950", VA = "0x182A4B750", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600254C")]
	[Address(RVA = "0x2A4BF50", Offset = "0x2A4B150", VA = "0x182A4BF50")]
	public GradientSettingsAtlas(int length = 4096)
	{
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0x2A4B930", Offset = "0x2A4AB30", VA = "0x182A4B930")]
	public void Reset()
	{
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0x2A4B440", Offset = "0x2A4A640", VA = "0x182A4B440")]
	public Alloc Add(int count)
	{
		return default(Alloc);
	}

	[Token(Token = "0x6002550")]
	[Address(RVA = "0x2A4B9F0", Offset = "0x2A4ABF0", VA = "0x182A4B9F0")]
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap)
	{
	}

	[Token(Token = "0x6002553")]
	[Address(RVA = "0x2A4B520", Offset = "0x2A4A720", VA = "0x182A4B520")]
	public void Commit()
	{
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0x2A4B7C0", Offset = "0x2A4A9C0", VA = "0x182A4B7C0")]
	private void PrepareAtlas()
	{
	}
}
