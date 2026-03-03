using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200059A")]
[UnityEngine.Scripting.RequiredByNativeCode]
internal readonly struct LayoutDataAccess
{
	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_Manager;

	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0x8")]
	private readonly LayoutDataStore m_Nodes;

	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x18")]
	private readonly LayoutDataStore m_Configs;

	[Token(Token = "0x17000A19")]
	public bool IsValid
	{
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x2A6E0C0", Offset = "0x2A6D2C0", VA = "0x182A6E0C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002781")]
	[Address(RVA = "0x2A6E0A0", Offset = "0x2A6D2A0", VA = "0x182A6E0A0")]
	internal LayoutDataAccess(int manager, LayoutDataStore nodes, LayoutDataStore configs)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002782")]
	private unsafe ref T GetTypedNodeDataRef<T>(LayoutHandle handle, LayoutNodeDataType type) where T : struct
	{
		return ref *(T*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002783")]
	private unsafe ref T GetTypedConfigDataRef<T>(LayoutHandle handle, LayoutConfigDataType type) where T : struct
	{
		return ref *(T*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002784")]
	[Address(RVA = "0x2A6DE30", Offset = "0x2A6D030", VA = "0x182A6DE30")]
	public unsafe ref LayoutNodeData GetNodeData(LayoutHandle handle)
	{
		return ref *(LayoutNodeData*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002785")]
	[Address(RVA = "0x2A6DF20", Offset = "0x2A6D120", VA = "0x182A6DF20")]
	public unsafe ref LayoutStyleData GetStyleData(LayoutHandle handle)
	{
		return ref *(LayoutStyleData*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002786")]
	[Address(RVA = "0x2A6DCC0", Offset = "0x2A6CEC0", VA = "0x182A6DCC0")]
	public unsafe ref LayoutComputedData GetComputedData(LayoutHandle handle)
	{
		return ref *(LayoutComputedData*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002787")]
	[Address(RVA = "0x2A6DD40", Offset = "0x2A6CF40", VA = "0x182A6DD40")]
	public unsafe ref LayoutConfigData GetConfigData(LayoutHandle handle)
	{
		return ref *(LayoutConfigData*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002788")]
	[Address(RVA = "0x2A6DDC0", Offset = "0x2A6CFC0", VA = "0x182A6DDC0")]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002789")]
	[Address(RVA = "0x2A6DFA0", Offset = "0x2A6D1A0", VA = "0x182A6DFA0")]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600278A")]
	[Address(RVA = "0x2A6DEB0", Offset = "0x2A6D0B0", VA = "0x182A6DEB0")]
	public VisualElement GetOwner(LayoutHandle handle)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x600278B")]
	[Address(RVA = "0x2A6E020", Offset = "0x2A6D220", VA = "0x182A6E020")]
	public void SetOwner(LayoutHandle handle, VisualElement value)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600278C")]
	[Address(RVA = "0x2A6DC50", Offset = "0x2A6CE50", VA = "0x182A6DC50")]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle)
	{
		return null;
	}
}
