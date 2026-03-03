using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018AC")]
public abstract class DuelInfoDialogBase : DuelTransitionUIBase
{
	[Token(Token = "0x20018AD")]
	public enum Place
	{
		[Token(Token = "0x400E75B")]
		Near,
		[Token(Token = "0x400E75C")]
		Nearer,
		[Token(Token = "0x400E75D")]
		Center,
		[Token(Token = "0x400E75E")]
		Farer,
		[Token(Token = "0x400E75F")]
		Far,
		[Token(Token = "0x400E760")]
		Farest
	}

	[Token(Token = "0x20018AE")]
	protected class OperationInfo : OperationInfoBase
	{
		[Token(Token = "0x6009EAD")]
		[Address(RVA = "0xEC9CB0", Offset = "0xEC8EB0", VA = "0x180EC9CB0")]
		public static OperationInfo CloseOperation(DuelInfoDialogBase dialog)
		{
			return null;
		}

		[Token(Token = "0x6009EAE")]
		[Address(RVA = "0xEC9DF0", Offset = "0xEC8FF0", VA = "0x180EC9DF0")]
		public static OperationInfo SetPlaceOperation(DuelInfoDialogBase dialog, Place place, bool immediate)
		{
			return null;
		}

		[Token(Token = "0x6009EAF")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		public OperationInfo()
		{
		}
	}

	[Token(Token = "0x400E74D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected GameObject prefabUI;

	[Token(Token = "0x400E74E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Action cancelCallback;

	[Token(Token = "0x400E74F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Action decisionCallback;

	[Token(Token = "0x400E750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Action closeCallback;

	[Token(Token = "0x400E751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected ElementObjectManager ui;

	[Token(Token = "0x400E752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Selector selector;

	[Token(Token = "0x400E753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected ExtendedTextMeshProUGUI textMessage;

	[Token(Token = "0x400E754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected ContentSizeFitter dialogFitter;

	[Token(Token = "0x400E755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected GameObject dialogObject;

	[Token(Token = "0x400E756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Place currentPlace;

	[Token(Token = "0x400E757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Place targetPlace;

	[Token(Token = "0x400E758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float timer;

	[Token(Token = "0x400E759")]
	private const float placeChangeTime = 1f;

	[Token(Token = "0x17001822")]
	protected override UITransitionUtil.BlockType openCloseBlockType
	{
		[Token(Token = "0x6009EA0")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(UITransitionUtil.BlockType);
		}
	}

	[Token(Token = "0x6009EA1")]
	[Address(RVA = "0xEB78E0", Offset = "0xEB6AE0", VA = "0x180EB78E0")]
	public void ReqClose()
	{
	}

	[Token(Token = "0x6009EA2")]
	[Address(RVA = "0xEB7A60", Offset = "0xEB6C60", VA = "0x180EB7A60")]
	public void ReqSetPlace(Place place, bool immediate)
	{
	}

	[Token(Token = "0x6009EA3")]
	[Address(RVA = "0xEB7570", Offset = "0xEB6770", VA = "0x180EB7570")]
	private void OnClickCancel()
	{
	}

	[Token(Token = "0x6009EA4")]
	[Address(RVA = "0xEB7600", Offset = "0xEB6800", VA = "0x180EB7600")]
	private void OnClickDecision()
	{
	}

	[Token(Token = "0x6009EA5")]
	[Address(RVA = "0xEB7CB0", Offset = "0xEB6EB0", VA = "0x180EB7CB0", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009EA6")]
	[Address(RVA = "0xEB7530", Offset = "0xEB6730", VA = "0x180EB7530", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009EA7")]
	[Address(RVA = "0xEB7690", Offset = "0xEB6890", VA = "0x180EB7690")]
	protected void Open(string message, Place place, bool cancelable, Action cancelCallback, [Optional] Action closeCallback, bool decidable = false, [Optional] Action decisionCallback)
	{
	}

	[Token(Token = "0x6009EA8")]
	[Address(RVA = "0xEB7C80", Offset = "0xEB6E80", VA = "0x180EB7C80")]
	protected void SetPlace(Place place, bool immediate)
	{
	}

	[Token(Token = "0x6009EA9")]
	[Address(RVA = "0xEB7F40", Offset = "0xEB7140", VA = "0x180EB7F40", Slot = "14")]
	protected override void UpdateUI()
	{
	}

	[Token(Token = "0x6009EAA")]
	[Address(RVA = "0xEB7CF0", Offset = "0xEB6EF0", VA = "0x180EB7CF0")]
	private void UpdatePlace()
	{
	}

	[Token(Token = "0x6009EAB")]
	[Address(RVA = "0xEB74A0", Offset = "0xEB66A0", VA = "0x180EB74A0")]
	private void Close()
	{
	}

	[Token(Token = "0x6009EAC")]
	[Address(RVA = "0xEB7F60", Offset = "0xEB7160", VA = "0x180EB7F60")]
	protected DuelInfoDialogBase()
	{
	}
}
