using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x200188E")]
public abstract class DuelDialogBase : DuelUIBase
{
	[Token(Token = "0x400E654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected GameObject prefabDialogBase;

	[Token(Token = "0x400E655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ElementObjectManager dialogBaseUI;

	[Token(Token = "0x400E656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Selector baseSelector;

	[Token(Token = "0x400E657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SelectionItem screenItem;

	[Token(Token = "0x400E658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected bool fieldViewing;

	[Token(Token = "0x400E659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform fieldViewRoot;

	[Token(Token = "0x400E65A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject fieldViewIconOn;

	[Token(Token = "0x400E65B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject fieldViewIconOff;

	[Token(Token = "0x400E65C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private TweenPositionTo tweenStartFieldView;

	[Token(Token = "0x400E65D")]
	private const float fieldViewToPosOffset = 18f;

	[Token(Token = "0x400E65E")]
	private const string tweenLabelStartFieldView = "StartFieldView";

	[Token(Token = "0x400E65F")]
	private const string tweenLabelFinishFieldView = "FinishFieldView";

	[Token(Token = "0x400E660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool useCardInfo;

	[Token(Token = "0x400E661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected ElementObjectManager ui;

	[Token(Token = "0x400E663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Selector selector;

	[Token(Token = "0x400E664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected RectTransform dialog;

	[Token(Token = "0x400E665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected List<Selector> selectors;

	[Token(Token = "0x170017F1")]
	protected abstract bool useFieldView
	{
		[Token(Token = "0x6009D4B")]
		get;
	}

	[Token(Token = "0x170017F2")]
	protected override UITransitionUtil.BlockType openCloseBlockType
	{
		[Token(Token = "0x6009D4C")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(UITransitionUtil.BlockType);
		}
	}

	[Token(Token = "0x6009D4D")]
	[Address(RVA = "0xEA7900", Offset = "0xEA6B00", VA = "0x180EA7900", Slot = "5")]
	public override void Initialize(RunEffectWorker effectWorker, bool createUI = true)
	{
	}

	[Token(Token = "0x6009D4E")]
	[Address(RVA = "0xEA7280", Offset = "0xEA6480", VA = "0x180EA7280", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009D4F")]
	[Address(RVA = "0xEA8160", Offset = "0xEA7360", VA = "0x180EA8160")]
	private void SetSelectorPriority()
	{
	}

	[Token(Token = "0x6009D50")]
	[Address(RVA = "0xEA6EC0", Offset = "0xEA60C0", VA = "0x180EA6EC0")]
	private void CreateBaseUI()
	{
	}

	[Token(Token = "0x6009D51")]
	[Address(RVA = "0xEA8210", Offset = "0xEA7410", VA = "0x180EA8210")]
	protected void SetupFieldViewButton(ElementObjectManager eom, string buttonLabel, string shortcutLabel, string iconOnLabel, string iconOffLabel)
	{
	}

	[Token(Token = "0x6009D52")]
	[Address(RVA = "0xEA8080", Offset = "0xEA7280", VA = "0x180EA8080")]
	protected void SetDialogSize(Vector2 size)
	{
	}

	[Token(Token = "0x6009D53")]
	[Address(RVA = "0xEA7A40", Offset = "0xEA6C40", VA = "0x180EA7A40")]
	private void OnChangeFieldView(bool fieldViewing, bool isAbort)
	{
	}

	[Token(Token = "0x6009D54")]
	[Address(RVA = "0xEA8530", Offset = "0xEA7730", VA = "0x180EA8530", Slot = "18")]
	protected virtual void StartFieldView()
	{
	}

	[Token(Token = "0x6009D55")]
	[Address(RVA = "0xEA74D0", Offset = "0xEA66D0", VA = "0x180EA74D0", Slot = "19")]
	protected virtual void FinishFieldView(bool isAbort)
	{
	}

	[Token(Token = "0x6009D56")]
	[Address(RVA = "0xEA6D30", Offset = "0xEA5F30", VA = "0x180EA6D30", Slot = "20")]
	public virtual void Abort()
	{
	}

	[Token(Token = "0x6009D57")]
	public abstract void OnCancel();

	[Token(Token = "0x6009D58")]
	[Address(RVA = "0xEA7EA0", Offset = "0xEA70A0", VA = "0x180EA7EA0", Slot = "7")]
	protected override void Open([Optional] Action openedCallback)
	{
	}

	[Token(Token = "0x6009D59")]
	[Address(RVA = "0xEA6D50", Offset = "0xEA5F50", VA = "0x180EA6D50", Slot = "8")]
	protected override void Close([Optional] Action closedCallback)
	{
	}

	[Token(Token = "0x6009D5A")]
	[Address(RVA = "0xEA84A0", Offset = "0xEA76A0", VA = "0x180EA84A0", Slot = "11")]
	protected override void ShowUI()
	{
	}

	[Token(Token = "0x6009D5B")]
	[Address(RVA = "0xEA7870", Offset = "0xEA6A70", VA = "0x180EA7870", Slot = "12")]
	protected override void HideUI()
	{
	}

	[Token(Token = "0x6009D5C")]
	[Address(RVA = "0xEA7B30", Offset = "0xEA6D30", VA = "0x180EA7B30")]
	public void OpenCardInfo(int mixid, int efx, bool effectidflag)
	{
	}

	[Token(Token = "0x6009D5D")]
	[Address(RVA = "0xEA7DB0", Offset = "0xEA6FB0", VA = "0x180EA7DB0")]
	public void OpenCardInfobyCardID(int cardID)
	{
	}

	[Token(Token = "0x6009D5E")]
	[Address(RVA = "0xEA79C0", Offset = "0xEA6BC0", VA = "0x180EA79C0")]
	private void OnChangeDuelLogOpenClose(bool isOpen)
	{
	}

	[Token(Token = "0x6009D5F")]
	[Address(RVA = "0xEA8B40", Offset = "0xEA7D40", VA = "0x180EA8B40")]
	protected DuelDialogBase()
	{
	}
}
