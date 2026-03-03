using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomSystem.UI.uGUI.SortingOrderAllocator;

[Token(Token = "0x2000586")]
public class SortingOrderAllocateGroup : MonoBehaviour
{
	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_GroupLabel;

	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("m_Order")]
	private int m_GroupOrder;

	[Token(Token = "0x4001AE5")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool m_Unique;

	[Token(Token = "0x4001AE6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_MinSortingOrder;

	[Token(Token = "0x170003E0")]
	public string groupLabel
	{
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E1")]
	public int groupOrder
	{
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003E2")]
	public bool unique
	{
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x66A190", Offset = "0x669390", VA = "0x18066A190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003E3")]
	public int minSortingOrder
	{
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x668B30", Offset = "0x667D30", VA = "0x180668B30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x66A090", Offset = "0x669290", VA = "0x18066A090")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SortingOrderAllocateGroup()
	{
	}
}
