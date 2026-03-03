using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000588")]
internal class LayoutManager : IDisposable
{
	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_Initialized;

	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0x1")]
	private static bool s_AppDomainUnloadRegistered;

	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0x8")]
	private static LayoutManager s_SharedInstance;

	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0x10")]
	private static readonly List<LayoutManager> s_Managers;

	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0x10")]
	private readonly int m_Index;

	[Token(Token = "0x40013D3")]
	[FieldOffset(Offset = "0x18")]
	private LayoutDataStore m_Nodes;

	[Token(Token = "0x40013D4")]
	[FieldOffset(Offset = "0x28")]
	private LayoutDataStore m_Configs;

	[Token(Token = "0x40013D5")]
	[FieldOffset(Offset = "0x38")]
	private readonly object m_SyncRoot;

	[Token(Token = "0x40013D6")]
	[FieldOffset(Offset = "0x40")]
	private readonly Stack<LayoutHandle> m_NodesToFree;

	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0x48")]
	private readonly LayoutHandle m_DefaultConfig;

	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0x50")]
	private readonly ManagedObjectStore<LayoutMeasureFunction> m_ManagedMeasureFunctions;

	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x58")]
	private readonly ManagedObjectStore<LayoutBaselineFunction> m_ManagedBaselineFunctions;

	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x60")]
	private readonly ManagedObjectStore<WeakReference<VisualElement>> m_ManagedOwners;

	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x68")]
	private int m_HighMark;

	[Token(Token = "0x170009CF")]
	public static LayoutManager SharedManager
	{
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x2A71200", Offset = "0x2A70400", VA = "0x182A71200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D0")]
	private static int DefaultCapacity
	{
		[Token(Token = "0x60026F7")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60026F4")]
	[Address(RVA = "0x2A70CD0", Offset = "0x2A6FED0", VA = "0x182A70CD0")]
	static LayoutManager()
	{
	}

	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x2A70410", Offset = "0x2A6F610", VA = "0x182A70410")]
	private static void Initialize()
	{
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x2A70860", Offset = "0x2A6FA60", VA = "0x182A70860")]
	private static void Shutdown()
	{
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x2A70100", Offset = "0x2A6F300", VA = "0x182A70100")]
	internal static LayoutManager GetManager(int index)
	{
		return null;
	}

	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x2A711A0", Offset = "0x2A703A0", VA = "0x182A711A0")]
	public LayoutManager(Allocator allocator)
	{
	}

	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x2A70D60", Offset = "0x2A6FF60", VA = "0x182A70D60")]
	public LayoutManager(Allocator allocator, int initialNodeCapacity)
	{
	}

	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x2A6FCE0", Offset = "0x2A6EEE0", VA = "0x182A6FCE0", Slot = "4")]
	public void Dispose()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60026FC")]
	[Address(RVA = "0x2A6FF80", Offset = "0x2A6F180", VA = "0x182A6FF80")]
	private LayoutDataAccess GetAccess()
	{
		return default(LayoutDataAccess);
	}

	[Token(Token = "0x60026FD")]
	[Address(RVA = "0x2A700A0", Offset = "0x2A6F2A0", VA = "0x182A700A0")]
	public LayoutConfig GetDefaultConfig()
	{
		return default(LayoutConfig);
	}

	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x2A6F500", Offset = "0x2A6E700", VA = "0x182A6F500")]
	public LayoutConfig CreateConfig()
	{
		return default(LayoutConfig);
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x2A6FA50", Offset = "0x2A6EC50", VA = "0x182A6FA50")]
	public void DestroyConfig(ref LayoutConfig config)
	{
	}

	[Token(Token = "0x6002700")]
	[Address(RVA = "0x2A6FA00", Offset = "0x2A6EC00", VA = "0x182A6FA00")]
	public LayoutNode CreateNode()
	{
		return default(LayoutNode);
	}

	[Token(Token = "0x6002701")]
	[Address(RVA = "0x2A6F610", Offset = "0x2A6E810", VA = "0x182A6F610")]
	private LayoutNode CreateNodeInternal(LayoutHandle configHandle)
	{
		return default(LayoutNode);
	}

	[Token(Token = "0x6002702")]
	[Address(RVA = "0x2A70A50", Offset = "0x2A6FC50", VA = "0x182A70A50")]
	private void TryFreeNodes()
	{
	}

	[Token(Token = "0x6002703")]
	[Address(RVA = "0x2A6FAB0", Offset = "0x2A6ECB0", VA = "0x182A6FAB0")]
	public void DestroyNode(ref LayoutNode node)
	{
	}

	[Token(Token = "0x6002704")]
	[Address(RVA = "0x2A6FE50", Offset = "0x2A6F050", VA = "0x182A6FE50")]
	private void FreeNode(LayoutHandle handle)
	{
	}

	[Token(Token = "0x6002705")]
	[Address(RVA = "0x2A701C0", Offset = "0x2A6F3C0", VA = "0x182A701C0")]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6002706")]
	[Address(RVA = "0x2A70670", Offset = "0x2A6F870", VA = "0x182A70670")]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value)
	{
	}

	[Token(Token = "0x6002707")]
	[Address(RVA = "0x2A70290", Offset = "0x2A6F490", VA = "0x182A70290")]
	public VisualElement GetOwner(LayoutHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6002708")]
	[Address(RVA = "0x2A70740", Offset = "0x2A6F940", VA = "0x182A70740")]
	public void SetOwner(LayoutHandle handle, VisualElement value)
	{
	}

	[Token(Token = "0x6002709")]
	[Address(RVA = "0x2A6FFD0", Offset = "0x2A6F1D0", VA = "0x182A6FFD0")]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle)
	{
		return null;
	}
}
