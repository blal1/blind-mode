using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CA6")]
public class ColosseumResultVersusViewController : BaseMenuViewController
{
	[Token(Token = "0x4010007")]
	public const string PREF_PATH = "Colosseum/ColosseumResultVersus";

	[Token(Token = "0x4010008")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string ARGS_VERSUSID;

	[Token(Token = "0x4010009")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string ARGS_CALLBACK;

	[Token(Token = "0x401000A")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string E_Image;

	[Token(Token = "0x401000B")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string E_Button;

	[Token(Token = "0x401000C")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string E_TextMyPoint;

	[Token(Token = "0x401000D")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string E_TextMyPointLabel;

	[Token(Token = "0x401000E")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string E_TextTotalPoint;

	[Token(Token = "0x401000F")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string E_TextTotalPointLabel;

	[Token(Token = "0x4010010")]
	[FieldOffset(Offset = "0x100")]
	private readonly string E_TextPercent;

	[Token(Token = "0x4010011")]
	[FieldOffset(Offset = "0x108")]
	private readonly string E_TextBase;

	[Token(Token = "0x4010012")]
	[FieldOffset(Offset = "0x110")]
	private readonly string E_Root;

	[Token(Token = "0x4010013")]
	[FieldOffset(Offset = "0x118")]
	private readonly string E_ImageBg;

	[Token(Token = "0x4010014")]
	[FieldOffset(Offset = "0x120")]
	private readonly string E_ImageMonster;

	[Token(Token = "0x4010015")]
	[FieldOffset(Offset = "0x128")]
	private readonly string E_ImageIconEffLoop;

	[Token(Token = "0x4010016")]
	[FieldOffset(Offset = "0x130")]
	private readonly string E_ImageIcon;

	[Token(Token = "0x4010017")]
	[FieldOffset(Offset = "0x138")]
	private readonly string E_ImageIconEff;

	[Token(Token = "0x4010018")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private float totalAnimationTime;

	[Token(Token = "0x4010019")]
	[FieldOffset(Offset = "0x144")]
	private int versus_id;

	[Token(Token = "0x401001A")]
	[FieldOffset(Offset = "0x148")]
	private bool isStartedTween;

	[Token(Token = "0x401001B")]
	[FieldOffset(Offset = "0x150")]
	private UnityAction m_OnFinished;

	[Token(Token = "0x401001C")]
	[FieldOffset(Offset = "0x158")]
	private int m_GroupNum;

	[Token(Token = "0x17001BE5")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B98B")]
		[Address(RVA = "0x546460", Offset = "0x545660", VA = "0x180546460", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B98C")]
	[Address(RVA = "0x543600", Offset = "0x542800", VA = "0x180543600")]
	public static Dictionary<string, object> GetArgs(int logoId, UnityAction onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B98D")]
	[Address(RVA = "0x5438F0", Offset = "0x542AF0", VA = "0x1805438F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B98E")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600B98F")]
	[Address(RVA = "0x543AF0", Offset = "0x542CF0", VA = "0x180543AF0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B990")]
	[Address(RVA = "0x543710", Offset = "0x542910", VA = "0x180543710")]
	private void Init_2VS()
	{
	}

	[Token(Token = "0x600B991")]
	[Address(RVA = "0x543830", Offset = "0x542A30", VA = "0x180543830")]
	private void Init_3VS()
	{
	}

	[Token(Token = "0x600B992")]
	[Address(RVA = "0x544110", Offset = "0x543310", VA = "0x180544110")]
	private void Play_2VS()
	{
	}

	[Token(Token = "0x600B993")]
	[Address(RVA = "0x5445B0", Offset = "0x5437B0", VA = "0x1805445B0")]
	private void SetGroup_2VS(int groupNo, long ownPercent, long rivalPercent, long totalPoint, bool isPlayEffect)
	{
	}

	[Token(Token = "0x600B994")]
	[Address(RVA = "0x544240", Offset = "0x543440", VA = "0x180544240")]
	private void Play_3VS()
	{
	}

	[Token(Token = "0x600B995")]
	[Address(RVA = "0x545210", Offset = "0x544410", VA = "0x180545210")]
	private void SetGroup_3VS(int groupNo, long ownPercent, long rivalPercent1, long rivalPercent2, long totalPoint, bool isPlayEffect)
	{
	}

	[Token(Token = "0x600B996")]
	[Address(RVA = "0x544080", Offset = "0x543280", VA = "0x180544080", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B997")]
	[Address(RVA = "0x543F50", Offset = "0x543150", VA = "0x180543F50", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x600B998")]
	[Address(RVA = "0x545F10", Offset = "0x545110", VA = "0x180545F10")]
	private void Update()
	{
	}

	[Token(Token = "0x600B999")]
	[Address(RVA = "0x5461B0", Offset = "0x5453B0", VA = "0x1805461B0")]
	public ColosseumResultVersusViewController()
	{
	}
}
