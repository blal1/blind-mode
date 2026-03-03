using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

[Token(Token = "0x200001E")]
public class SubTabEditVC : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private AccordionTabGroupWidget component;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ElementObjectManager _tabsList;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private InfinityScrollView isv;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Selector selector;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Dictionary<(int, int), bool> badgeMap;

	[Token(Token = "0x1700000A")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3E5230", Offset = "0x3E4430", VA = "0x1803E5230", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x3E4740", Offset = "0x3E3940", VA = "0x1803E4740", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x3E4F80", Offset = "0x3E4180", VA = "0x1803E4F80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x3E5150", Offset = "0x3E4350", VA = "0x1803E5150")]
	private void Update()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x3E3E90", Offset = "0x3E3090", VA = "0x1803E3E90")]
	private void CreateData()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x3E4050", Offset = "0x3E3250", VA = "0x1803E4050")]
	private void CreatedDataByDataCount(int count, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnCreatedTabEntity(GameObject target)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x3E40A0", Offset = "0x3E32A0", VA = "0x1803E40A0")]
	private void OnChangedTab(int preIndex, int preSubIndex, int index, int subIndex)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x3E43A0", Offset = "0x3E35A0", VA = "0x1803E43A0")]
	private void OnClickedTab(int index, int subIndex)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x3E4E60", Offset = "0x3E4060", VA = "0x1803E4E60")]
	private void OnUpdateTabEntity(GameObject target, int index, int sectionIndex)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x3E4690", Offset = "0x3E3890", VA = "0x1803E4690")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x3E4BF0", Offset = "0x3E3DF0", VA = "0x1803E4BF0")]
	private void OnUpdateEntity(GameObject entity, int dataIdx)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x3E4BB0", Offset = "0x3E3DB0", VA = "0x1803E4BB0")]
	private bool OnInputDirection(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x3E51B0", Offset = "0x3E43B0", VA = "0x1803E51B0")]
	public SubTabEditVC()
	{
	}
}
