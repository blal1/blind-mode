using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.DiceRally;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001D2F")]
public class ColosseumDialogMangaer : MonoBehaviour
{
	[Token(Token = "0x401023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ColosseumDuelDialog duelDialog;

	[Token(Token = "0x401023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool infoDialog_isOpen;

	[Token(Token = "0x401023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Selector m_HeaderSelector;

	[Token(Token = "0x401023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Selector m_ParentSelector;

	[Token(Token = "0x401023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Selector m_OverItemSelector;

	[Token(Token = "0x401023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Tuple<string, UnityAction>> m_ItemList;

	[Token(Token = "0x17001BF5")]
	public float duelDialogWidth
	{
		[Token(Token = "0x600BB87")]
		[Address(RVA = "0x571F80", Offset = "0x571180", VA = "0x180571F80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BF6")]
	public bool isOpenDialog
	{
		[Token(Token = "0x600BB88")]
		[Address(RVA = "0x572030", Offset = "0x571230", VA = "0x180572030")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600BB89")]
	[Address(RVA = "0x571A80", Offset = "0x570C80", VA = "0x180571A80")]
	public void InitDialog(Selector parent, Selector header, [Optional] Selector overItemSelector)
	{
	}

	[Token(Token = "0x600BB8A")]
	[Address(RVA = "0x571A60", Offset = "0x570C60", VA = "0x180571A60")]
	public ElementObjectManager GetDuelDialogEOM()
	{
		return null;
	}

	[Token(Token = "0x600BB8B")]
	[Address(RVA = "0x571B60", Offset = "0x570D60", VA = "0x180571B60")]
	public void OpenDuelDialog(bool isTween = true)
	{
	}

	[Token(Token = "0x600BB8C")]
	[Address(RVA = "0x5717C0", Offset = "0x5709C0", VA = "0x1805717C0")]
	public void CloseDuelDialog(bool isTween = true)
	{
	}

	[Token(Token = "0x600BB8D")]
	[Address(RVA = "0x571DD0", Offset = "0x570FD0", VA = "0x180571DD0")]
	public void SetDuelDialogClosedCallback(Action<bool> action)
	{
	}

	[Token(Token = "0x600BB8E")]
	[Address(RVA = "0x571E00", Offset = "0x571000", VA = "0x180571E00")]
	public void SetDuelDialogOpenedCallback(Action<bool> action)
	{
	}

	[Token(Token = "0x600BB8F")]
	[Address(RVA = "0x571E30", Offset = "0x571030", VA = "0x180571E30")]
	public void UpdateDuelDialog(DiceRallySpace space)
	{
	}

	[Token(Token = "0x600BB90")]
	[Address(RVA = "0x571C60", Offset = "0x570E60", VA = "0x180571C60")]
	public void OpenInfoDialog()
	{
	}

	[Token(Token = "0x600BB91")]
	[Address(RVA = "0x5718B0", Offset = "0x570AB0", VA = "0x1805718B0")]
	public void CloseInfoDialog()
	{
	}

	[Token(Token = "0x600BB92")]
	[Address(RVA = "0x571730", Offset = "0x570930", VA = "0x180571730")]
	public void CloseAllDialog(bool isTween = true)
	{
	}

	[Token(Token = "0x600BB93")]
	[Address(RVA = "0x571630", Offset = "0x570830", VA = "0x180571630")]
	public void AddInfoItem(string text, UnityAction onClick)
	{
	}

	[Token(Token = "0x600BB94")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ColosseumDialogMangaer()
	{
	}
}
