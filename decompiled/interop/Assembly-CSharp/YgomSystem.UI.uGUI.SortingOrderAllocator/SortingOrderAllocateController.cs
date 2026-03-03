using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI.uGUI.SortingOrderAllocator;

[Token(Token = "0x2000585")]
public class SortingOrderAllocateController : MonoBehaviour
{
	[Token(Token = "0x4001ADF")]
	[FieldOffset(Offset = "0x20")]
	[Header("Assign by runtime")]
	[SerializeField]
	private List<SortingOrderAllocateGroup> m_Groups;

	[Token(Token = "0x4001AE0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<SortingOrderAllocateEntry> m_Entries;

	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, SortingOrderAllocateGroup> m_GroupMap;

	[Token(Token = "0x4001AE2")]
	[FieldOffset(Offset = "0x0")]
	private static SortingOrderAllocateController s_Instance;

	[Token(Token = "0x170003DE")]
	private static SortingOrderAllocateController instance
	{
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x669860", Offset = "0x668A60", VA = "0x180669860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003DF")]
	private static bool exists
	{
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x6697F0", Offset = "0x6689F0", VA = "0x1806697F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60023CC")]
	[Address(RVA = "0x668FB0", Offset = "0x6681B0", VA = "0x180668FB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x668B30", Offset = "0x667D30", VA = "0x180668B30")]
	public static void Assign(SortingOrderAllocateGroup group)
	{
	}

	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x6691E0", Offset = "0x6683E0", VA = "0x1806691E0")]
	public static bool Remove(SortingOrderAllocateGroup group)
	{
		return default(bool);
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x668C60", Offset = "0x667E60", VA = "0x180668C60")]
	public static void Assign(SortingOrderAllocateEntry entry)
	{
	}

	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x6690D0", Offset = "0x6682D0", VA = "0x1806690D0")]
	public static bool Remove(SortingOrderAllocateEntry entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x669000", Offset = "0x668200", VA = "0x180669000")]
	private void ReleaseCheck()
	{
	}

	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x6692F0", Offset = "0x6684F0", VA = "0x1806692F0")]
	private void UpdateOrder()
	{
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x668F20", Offset = "0x668120", VA = "0x180668F20")]
	private int CompareGroup(SortingOrderAllocateGroup a, SortingOrderAllocateGroup b)
	{
		return default(int);
	}

	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x668D90", Offset = "0x667F90", VA = "0x180668D90")]
	private int CompareEntry(SortingOrderAllocateEntry a, SortingOrderAllocateEntry b)
	{
		return default(int);
	}

	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SortingOrderAllocateController()
	{
	}
}
