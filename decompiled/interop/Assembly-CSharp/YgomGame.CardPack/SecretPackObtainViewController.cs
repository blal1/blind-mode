using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;

namespace YgomGame.CardPack;

[Token(Token = "0x200152C")]
public class SecretPackObtainViewController : BaseMenuViewController
{
	[Token(Token = "0x400CB77")]
	private const string k_ArgKeyIsExtend = "isExtend";

	[Token(Token = "0x400CB78")]
	private const string k_ArgKeyNameTextId = "nameTextId";

	[Token(Token = "0x400CB79")]
	private const string k_ArgKeyThumbType = "thumbType";

	[Token(Token = "0x400CB7A")]
	private const string k_ArgKeyThumbData = "thumbData";

	[Token(Token = "0x400CB7B")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400CB7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelBG3D;

	[Token(Token = "0x400CB7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelFoundTextLabel;

	[Token(Token = "0x400CB7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelPackThumbRoot;

	[Token(Token = "0x400CB7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelPackThumbHolder;

	[Token(Token = "0x400CB80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelPackNameTMP;

	[Token(Token = "0x400CB81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelBackShortcutButton;

	[Token(Token = "0x400CB82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelSmallBand;

	[Token(Token = "0x400CB83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelLargeBand;

	[Token(Token = "0x400CB84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject m_View3D;

	[Token(Token = "0x400CB85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string m_PackName;

	[Token(Token = "0x170013F6")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60082E9")]
		[Address(RVA = "0xCC7030", Offset = "0xCC6230", VA = "0x180CC7030", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60082EA")]
	[Address(RVA = "0xCC67C0", Offset = "0xCC59C0", VA = "0x180CC67C0")]
	public static void Open(bool isExtend, [Optional] Action callback)
	{
	}

	[Token(Token = "0x60082EB")]
	[Address(RVA = "0xCC65F0", Offset = "0xCC57F0", VA = "0x180CC65F0")]
	public static void Open(bool isExtend, string packNameTextId, int thumbType, string thumbData, [Optional] Action callback)
	{
	}

	[Token(Token = "0x60082EC")]
	[Address(RVA = "0xCC5FA0", Offset = "0xCC51A0", VA = "0x180CC5FA0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60082ED")]
	[Address(RVA = "0xCC6260", Offset = "0xCC5460", VA = "0x180CC6260", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60082EE")]
	[Address(RVA = "0xCC6970", Offset = "0xCC5B70", VA = "0x180CC6970")]
	private void Start()
	{
	}

	[Token(Token = "0x60082EF")]
	[Address(RVA = "0x4B6FD0", Offset = "0x4B61D0", VA = "0x1804B6FD0")]
	private void OnTMPaused(PlayableDirector director)
	{
	}

	[Token(Token = "0x60082F0")]
	[Address(RVA = "0xCC60A0", Offset = "0xCC52A0", VA = "0x180CC60A0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60082F1")]
	[Address(RVA = "0xCC61D0", Offset = "0xCC53D0", VA = "0x180CC61D0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60082F2")]
	[Address(RVA = "0xCC6EA0", Offset = "0xCC60A0", VA = "0x180CC6EA0")]
	public SecretPackObtainViewController()
	{
	}
}
