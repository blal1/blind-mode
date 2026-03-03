using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004CD")]
public class TransitionAlongDirection : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20004CE")]
	public class Setting
	{
		[Token(Token = "0x40017BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[EnumFlags]
		[Tooltip("対象")]
		protected DirectionFlag m_Directions;

		[Token(Token = "0x40017BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("グループ名を限定")]
		private List<string> m_ReserveGroup;

		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("グループ名を限定")]
		private List<string> m_IgnoreGroup;

		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_ContainGoThrough;

		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_MaskSelectorRect;

		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("選択対象/優先度")]
		public SelectTarget[] m_SelectTargetOrder;

		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 1f)]
		[Header("対象とする内積閾値")]
		private float m_SelectionAngle;

		[Token(Token = "0x1700033F")]
		public DirectionFlag directions
		{
			[Token(Token = "0x6001FF8")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(DirectionFlag);
			}
		}

		[Token(Token = "0x17000340")]
		public List<string> reserveGroup
		{
			[Token(Token = "0x6001FF9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000341")]
		public List<string> ignoreGroup
		{
			[Token(Token = "0x6001FFA")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000342")]
		public bool containGoThrough
		{
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000343")]
		public SelectTarget[] selectTargetOrder
		{
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000344")]
		public float selectionAngle
		{
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x5DC210", Offset = "0x5DB410", VA = "0x1805DC210")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000345")]
		public bool maskSelectorRect
		{
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x62E020", Offset = "0x62D220", VA = "0x18062E020")]
		public void Import(Setting other)
		{
		}

		[Token(Token = "0x6002000")]
		[Address(RVA = "0x62E090", Offset = "0x62D290", VA = "0x18062E090")]
		public bool IsDirection(PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x6002001")]
		[Address(RVA = "0x62E0D0", Offset = "0x62D2D0", VA = "0x18062E0D0")]
		public void SetDirection(PadInputDirection direction)
		{
		}

		[Token(Token = "0x6002002")]
		[Address(RVA = "0x62E100", Offset = "0x62D300", VA = "0x18062E100")]
		public void UnsetDirection(PadInputDirection direction)
		{
		}

		[Token(Token = "0x6002003")]
		[Address(RVA = "0x62E130", Offset = "0x62D330", VA = "0x18062E130")]
		public Setting()
		{
		}
	}

	[Token(Token = "0x20004CF")]
	public enum DirectionFlag
	{
		[Token(Token = "0x40017C6")]
		Up = 1,
		[Token(Token = "0x40017C7")]
		Down = 2,
		[Token(Token = "0x40017C8")]
		Left = 4,
		[Token(Token = "0x40017C9")]
		Right = 8
	}

	[Token(Token = "0x20004D0")]
	public enum SelectTarget
	{
		[Token(Token = "0x40017CB")]
		Item,
		[Token(Token = "0x40017CC")]
		Selector,
		[Token(Token = "0x40017CD")]
		Clustor
	}

	[Token(Token = "0x20004D1")]
	public enum SearchType
	{
		[Token(Token = "0x40017CF")]
		Near,
		[Token(Token = "0x40017D0")]
		Dot
	}

	[Token(Token = "0x20004D2")]
	private interface IItemSearcher
	{
		[Token(Token = "0x6002004")]
		List<SelectionItem> Search(SelectionItem fromItem, Setting setting, Vector2 dir);
	}

	[Token(Token = "0x20004D3")]
	private class NearItemSearcher : IItemSearcher
	{
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x10")]
		private List<SelectionItem> m_SearchItemList;

		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<SelectionItem, float> m_SearchDistanceMap;

		[Token(Token = "0x6002005")]
		[Address(RVA = "0x636340", Offset = "0x635540", VA = "0x180636340")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002006")]
		[Address(RVA = "0x6363C0", Offset = "0x6355C0", VA = "0x1806363C0", Slot = "4")]
		public List<SelectionItem> Search(SelectionItem fromItem, Setting setting, Vector2 dir)
		{
			return null;
		}

		[Token(Token = "0x6002007")]
		[Address(RVA = "0x636CC0", Offset = "0x635EC0", VA = "0x180636CC0")]
		public NearItemSearcher()
		{
		}
	}

	[Token(Token = "0x20004D4")]
	private class DotItemSearcher : IItemSearcher
	{
		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x10")]
		private List<SelectionItem> m_SelectTargetList;

		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x18")]
		private List<SelectionItem> m_SearchItemList;

		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<SelectionItem, float> m_SearchWeightMap;

		[Token(Token = "0x6002009")]
		[Address(RVA = "0x635770", Offset = "0x634970", VA = "0x180635770")]
		public void Clear()
		{
		}

		[Token(Token = "0x600200A")]
		[Address(RVA = "0x635820", Offset = "0x634A20", VA = "0x180635820", Slot = "4")]
		public List<SelectionItem> Search(SelectionItem fromItem, Setting setting, Vector2 dir)
		{
			return null;
		}

		[Token(Token = "0x600200B")]
		[Address(RVA = "0x636250", Offset = "0x635450", VA = "0x180636250")]
		public DotItemSearcher()
		{
		}
	}

	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Setting m_Setting;

	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SearchType m_SearchType;

	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0x30")]
	protected SelectionItem m_SelectionItem;

	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x38")]
	private IItemSearcher m_ItemSearcher;

	[Token(Token = "0x1700033D")]
	public Setting setting
	{
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700033E")]
	private IItemSearcher itemSearcher
	{
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x6305A0", Offset = "0x62F7A0", VA = "0x1806305A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x62F690", Offset = "0x62E890", VA = "0x18062F690")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x62F820", Offset = "0x62EA20", VA = "0x18062F820")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x62F510", Offset = "0x62E710", VA = "0x18062F510")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x62F1B0", Offset = "0x62E3B0", VA = "0x18062F1B0")]
	public void ApplyTransition()
	{
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x62FC00", Offset = "0x62EE00", VA = "0x18062FC00")]
	public bool TrySelectInput(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x62F7C0", Offset = "0x62E9C0", VA = "0x18062F7C0", Slot = "4")]
	protected virtual void OnInputUp()
	{
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x62F6A0", Offset = "0x62E8A0", VA = "0x18062F6A0", Slot = "5")]
	protected virtual void OnInputDown()
	{
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x62F700", Offset = "0x62E900", VA = "0x18062F700", Slot = "6")]
	protected virtual void OnInputLeft()
	{
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x62F760", Offset = "0x62E960", VA = "0x18062F760", Slot = "7")]
	protected virtual void OnInputRight()
	{
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x62FD40", Offset = "0x62EF40", VA = "0x18062FD40")]
	protected bool TrySelectNearItem(Vector2 dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x62FD50", Offset = "0x62EF50", VA = "0x18062FD50")]
	protected bool TrySelectNearItem(SelectionItem selectionItem, Vector2 dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x62F8E0", Offset = "0x62EAE0", VA = "0x18062F8E0")]
	private bool TryProvisinalSelectItem(SelectionItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x62FA70", Offset = "0x62EC70", VA = "0x18062FA70")]
	private bool TryProvisinalSelectSelector(Selector selector)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x62F880", Offset = "0x62EA80", VA = "0x18062F880")]
	private bool TryProvisinalSelectClustor(SelectorCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x6304D0", Offset = "0x62F6D0", VA = "0x1806304D0")]
	public TransitionAlongDirection()
	{
	}
}
