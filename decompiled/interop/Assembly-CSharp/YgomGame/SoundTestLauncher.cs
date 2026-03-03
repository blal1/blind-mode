using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x2000631")]
public class SoundTestLauncher : ViewController
{
	[Token(Token = "0x2000632")]
	private class TestPlayerInfo
	{
		[Token(Token = "0x4001E34")]
		[FieldOffset(Offset = "0x10")]
		public GameObject player;

		[Token(Token = "0x4001E35")]
		[FieldOffset(Offset = "0x18")]
		public string soundLabel;

		[Token(Token = "0x4001E36")]
		[FieldOffset(Offset = "0x20")]
		public bool oneShot;

		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform label3d;

		[Token(Token = "0x600290F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TestPlayerInfo()
		{
		}
	}

	[Token(Token = "0x4001E2C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject prefabPlayer;

	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager ui;

	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager infoTemplate;

	[Token(Token = "0x4001E30")]
	[FieldOffset(Offset = "0x68")]
	private Transform infoListParent;

	[Token(Token = "0x4001E31")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform label3dParent;

	[Token(Token = "0x4001E32")]
	[FieldOffset(Offset = "0x78")]
	private List<TestPlayerInfo> playerList;

	[Token(Token = "0x4001E33")]
	[FieldOffset(Offset = "0x80")]
	private int createCounter;

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x6AF450", Offset = "0x6AE650", VA = "0x1806AF450", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600290A")]
	[Address(RVA = "0x6AFA50", Offset = "0x6AEC50", VA = "0x1806AFA50")]
	private void SetupScrollToSelectingItem(SelectionItem item, RectTransform itemRootRect)
	{
	}

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x6AF810", Offset = "0x6AEA10", VA = "0x1806AF810")]
	private void SetupAnalogInputShortcut(SelectionItem item, Transform player, InputField inputX, InputField inputY, InputField inputZ)
	{
	}

	[Token(Token = "0x600290C")]
	[Address(RVA = "0x6AF970", Offset = "0x6AEB70", VA = "0x1806AF970")]
	private void SetupPlayShortcut(SelectionItem item, TestPlayerInfo info)
	{
	}

	[Token(Token = "0x600290D")]
	[Address(RVA = "0x6AFB30", Offset = "0x6AED30", VA = "0x1806AFB30")]
	private void Update()
	{
	}

	[Token(Token = "0x600290E")]
	[Address(RVA = "0x6AFD10", Offset = "0x6AEF10", VA = "0x1806AFD10")]
	public SoundTestLauncher()
	{
	}
}
