using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057B")]
internal class VectorImageManager : IDisposable
{
	[Token(Token = "0x400138A")]
	[FieldOffset(Offset = "0x0")]
	public static List<VectorImageManager> instances;

	[Token(Token = "0x400138B")]
	[FieldOffset(Offset = "0x8")]
	private static ProfilerMarker s_MarkerRegister;

	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x10")]
	private static ProfilerMarker s_MarkerUnregister;

	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x10")]
	private readonly AtlasBase m_Atlas;

	[Token(Token = "0x400138E")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered;

	[Token(Token = "0x400138F")]
	[FieldOffset(Offset = "0x20")]
	private VectorImageRenderInfoPool m_RenderInfoPool;

	[Token(Token = "0x4001390")]
	[FieldOffset(Offset = "0x28")]
	private GradientRemapPool m_GradientRemapPool;

	[Token(Token = "0x4001391")]
	[FieldOffset(Offset = "0x30")]
	private GradientSettingsAtlas m_GradientSettingsAtlas;

	[Token(Token = "0x4001392")]
	[FieldOffset(Offset = "0x38")]
	private bool m_LoggedExhaustedSettingsAtlas;

	[Token(Token = "0x170009C4")]
	public Texture2D atlas
	{
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x2A68380", Offset = "0x2A67580", VA = "0x182A68380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C5")]
	protected bool disposed
	{
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x689960", Offset = "0x688B60", VA = "0x180689960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x74E7C0", Offset = "0x74D9C0", VA = "0x18074E7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x2A67E30", Offset = "0x2A67030", VA = "0x182A67E30")]
	public VectorImageManager(AtlasBase atlas)
	{
	}

	[Token(Token = "0x60026B1")]
	[Address(RVA = "0x2A67840", Offset = "0x2A66A40", VA = "0x182A67840", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x2A67720", Offset = "0x2A66920", VA = "0x182A67720", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60026B3")]
	[Address(RVA = "0x2A676F0", Offset = "0x2A668F0", VA = "0x182A676F0")]
	public void Commit()
	{
	}

	[Token(Token = "0x60026B4")]
	[Address(RVA = "0x2A675F0", Offset = "0x2A667F0", VA = "0x182A675F0")]
	public GradientRemap AddUser(VectorImage vi, VisualElement context)
	{
		return null;
	}

	[Token(Token = "0x60026B5")]
	[Address(RVA = "0x2A678B0", Offset = "0x2A66AB0", VA = "0x182A678B0")]
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context)
	{
		return null;
	}
}
