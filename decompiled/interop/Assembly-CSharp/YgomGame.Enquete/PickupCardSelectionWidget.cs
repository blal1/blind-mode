using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E1D")]
public class PickupCardSelectionWidget : MonoBehaviour
{
	[Token(Token = "0x2000E1E")]
	public class CardTemplate
	{
		[Token(Token = "0x400A23E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int cardMrk;

		[Token(Token = "0x400A23F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ElementObjectManager eom;

		[Token(Token = "0x400A240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SelectionButton button;

		[Token(Token = "0x400A241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isRequier;

		[Token(Token = "0x400A242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject selectedCursor;

		[Token(Token = "0x17000CC3")]
		public bool isSelected
		{
			[Token(Token = "0x6005590")]
			[Address(RVA = "0x9B3E60", Offset = "0x9B3060", VA = "0x1809B3E60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005591")]
		[Address(RVA = "0x9B3CE0", Offset = "0x9B2EE0", VA = "0x1809B3CE0")]
		public void SetSelected(bool frag)
		{
		}

		[Token(Token = "0x6005592")]
		[Address(RVA = "0x9B3D70", Offset = "0x9B2F70", VA = "0x1809B3D70")]
		public CardTemplate(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x400A22E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int pickNum;

	[Token(Token = "0x400A22F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int requireNum;

	[Token(Token = "0x400A230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<int> m_SlotMRKs;

	[Token(Token = "0x400A231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Selector m_Selector;

	[Token(Token = "0x400A232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400A233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private BaseMenuViewController parentVC;

	[Token(Token = "0x400A234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<string, object> m_Args;

	[Token(Token = "0x400A235")]
	public const string k_Args_RequierNum = "requireNum";

	[Token(Token = "0x400A236")]
	public const string k_Args_pickNum = "pickNum";

	[Token(Token = "0x400A237")]
	public const string k_Args_pickedCards = "pickedCards";

	[Token(Token = "0x400A238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string Label_Template;

	[Token(Token = "0x400A239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<CardTemplate, bool> onClickCard;

	[Token(Token = "0x400A23A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<int> onSelectedCard;

	[Token(Token = "0x400A23B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int currentSelectBtnIndex;

	[Token(Token = "0x400A23C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<ElementObjectManager> templateList;

	[Token(Token = "0x400A23D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<CardTemplate> cardTemplates;

	[Token(Token = "0x17000CC0")]
	public List<int> holderMRKs
	{
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC1")]
	public bool isAddable
	{
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x9BD920", Offset = "0x9BCB20", VA = "0x1809BD920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CC2")]
	public Selector slector
	{
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600558B")]
	[Address(RVA = "0x9BCED0", Offset = "0x9BC0D0", VA = "0x1809BCED0")]
	public void Init(Transform parent, BaseMenuViewController parentVC, int id, [Optional] Action<Either<string, PickupCardSelectionWidget>> onInitalized, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600558C")]
	[Address(RVA = "0x9BCBF0", Offset = "0x9BBDF0", VA = "0x1809BCBF0")]
	public void Apply()
	{
	}

	[Token(Token = "0x600558D")]
	[Address(RVA = "0x9BCFA0", Offset = "0x9BC1A0", VA = "0x1809BCFA0")]
	public Either<string, PickupCardSelectionWidget> Initialize(ElementObjectManager eom, BaseMenuViewController parentVC, int id, Dictionary<string, object> args)
	{
		return null;
	}

	[Token(Token = "0x600558E")]
	[Address(RVA = "0x9BD560", Offset = "0x9BC760", VA = "0x1809BD560")]
	private string SetArgs(Dictionary<string, object> dic)
	{
		return null;
	}

	[Token(Token = "0x600558F")]
	[Address(RVA = "0x9BD7E0", Offset = "0x9BC9E0", VA = "0x1809BD7E0")]
	public PickupCardSelectionWidget()
	{
	}
}
