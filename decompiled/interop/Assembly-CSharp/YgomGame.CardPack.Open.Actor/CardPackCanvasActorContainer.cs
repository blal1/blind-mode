using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.HeaderFooter;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001572")]
public class CardPackCanvasActorContainer : ActorContainerBase<CardPackCanvasActorContainer>
{
	[Token(Token = "0x400CCE0")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelTouchArea;

	[Token(Token = "0x400CCE1")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOpenLabel;

	[Token(Token = "0x400CCE2")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelOpenAllCardButton;

	[Token(Token = "0x400CCE3")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelNextLabel;

	[Token(Token = "0x400CCE4")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x400CCE5")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelFinishLabel;

	[Token(Token = "0x400CCE6")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelFinishButton;

	[Token(Token = "0x400CCE7")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelSkipButton;

	[Token(Token = "0x400CCE8")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelProgressText;

	[Token(Token = "0x400CCE9")]
	[FieldOffset(Offset = "0x70")]
	private OutGameFooter m_Footer;

	[Token(Token = "0x400CCEA")]
	[FieldOffset(Offset = "0x78")]
	private SelectionButton m_TouchArea;

	[Token(Token = "0x400CCEB")]
	[FieldOffset(Offset = "0x80")]
	private SelectionButton m_OpenAllCardButton;

	[Token(Token = "0x400CCEC")]
	[FieldOffset(Offset = "0x88")]
	private TMP_Text m_ProgressText;

	[Token(Token = "0x400CCED")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_OpenLabel;

	[Token(Token = "0x400CCEE")]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_NextLabel;

	[Token(Token = "0x400CCEF")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_FinishLabel;

	[Token(Token = "0x400CCF0")]
	[FieldOffset(Offset = "0xA8")]
	private SelectionButton m_SkipButton;

	[Token(Token = "0x17001457")]
	public SelectionButton touchArea
	{
		[Token(Token = "0x600848C")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001458")]
	public SelectionButton openAllCardButton
	{
		[Token(Token = "0x600848D")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001459")]
	public bool skipButtonAble
	{
		[Token(Token = "0x600848F")]
		[Address(RVA = "0xA759E0", Offset = "0xA74BE0", VA = "0x180A759E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600848E")]
		[Address(RVA = "0xCD5AB0", Offset = "0xCD4CB0", VA = "0x180CD5AB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700145A")]
	public OutGameFooter footer
	{
		[Token(Token = "0x6008490")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000A9")]
	public event Action onDownTouchAreaEvent
	{
		[Token(Token = "0x6008491")]
		[Address(RVA = "0xCD5040", Offset = "0xCD4240", VA = "0x180CD5040")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008492")]
		[Address(RVA = "0xCD55D0", Offset = "0xCD47D0", VA = "0x180CD55D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000AA")]
	public event Action onUpTouchAreaEvent
	{
		[Token(Token = "0x6008493")]
		[Address(RVA = "0xCD5470", Offset = "0xCD4670", VA = "0x180CD5470")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008494")]
		[Address(RVA = "0xCD5A00", Offset = "0xCD4C00", VA = "0x180CD5A00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000AB")]
	public event Action onClickTouchAreaEvent
	{
		[Token(Token = "0x6008495")]
		[Address(RVA = "0xCD4F90", Offset = "0xCD4190", VA = "0x180CD4F90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008496")]
		[Address(RVA = "0xCD5520", Offset = "0xCD4720", VA = "0x180CD5520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000AC")]
	public event Action onInputAcceptEvent
	{
		[Token(Token = "0x6008497")]
		[Address(RVA = "0xCD51B0", Offset = "0xCD43B0", VA = "0x180CD51B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008498")]
		[Address(RVA = "0xCD5740", Offset = "0xCD4940", VA = "0x180CD5740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000AD")]
	public event Action onInputAcceptKeyEvent
	{
		[Token(Token = "0x6008499")]
		[Address(RVA = "0xCD5260", Offset = "0xCD4460", VA = "0x180CD5260")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600849A")]
		[Address(RVA = "0xCD57F0", Offset = "0xCD49F0", VA = "0x180CD57F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000AE")]
	public event Action onInputSub2KeyEvent
	{
		[Token(Token = "0x600849B")]
		[Address(RVA = "0xCD53C0", Offset = "0xCD45C0", VA = "0x180CD53C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600849C")]
		[Address(RVA = "0xCD5950", Offset = "0xCD4B50", VA = "0x180CD5950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000AF")]
	public event Action<SelectionItem.DragStatus, Vector2> onDragEvent
	{
		[Token(Token = "0x600849D")]
		[Address(RVA = "0xCD50F0", Offset = "0xCD42F0", VA = "0x180CD50F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600849E")]
		[Address(RVA = "0xCD5680", Offset = "0xCD4880", VA = "0x180CD5680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B0")]
	public event Action onInputSkipEvent
	{
		[Token(Token = "0x600849F")]
		[Address(RVA = "0xCD5310", Offset = "0xCD4510", VA = "0x180CD5310")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60084A0")]
		[Address(RVA = "0xCD58A0", Offset = "0xCD4AA0", VA = "0x180CD58A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60084A1")]
	[Address(RVA = "0xCD4790", Offset = "0xCD3990", VA = "0x180CD4790")]
	public static CardPackCanvasActorContainer Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x60084A2")]
	[Address(RVA = "0xCD4180", Offset = "0xCD3380", VA = "0x180CD4180", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x60084A3")]
	[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
	public void AssignFooter(OutGameFooter footer)
	{
	}

	[Token(Token = "0x60084A4")]
	[Address(RVA = "0xCD47D0", Offset = "0xCD39D0", VA = "0x180CD47D0")]
	public void MoveParent(Transform newParent)
	{
	}

	[Token(Token = "0x60084A5")]
	[Address(RVA = "0xCD4C90", Offset = "0xCD3E90", VA = "0x180CD4C90")]
	public void SetProgressText(int packIdx, int packTotal)
	{
	}

	[Token(Token = "0x60084A6")]
	[Address(RVA = "0xCD4C10", Offset = "0xCD3E10", VA = "0x180CD4C10")]
	public void SetLabelToOpen()
	{
	}

	[Token(Token = "0x60084A7")]
	[Address(RVA = "0xCD4B90", Offset = "0xCD3D90", VA = "0x180CD4B90")]
	public void SetLabelToNext()
	{
	}

	[Token(Token = "0x60084A8")]
	[Address(RVA = "0xCD4B10", Offset = "0xCD3D10", VA = "0x180CD4B10")]
	public void SetLabelToFinish()
	{
	}

	[Token(Token = "0x60084A9")]
	[Address(RVA = "0xCD3FC0", Offset = "0xCD31C0", VA = "0x180CD3FC0", Slot = "5")]
	public override void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x60084AA")]
	[Address(RVA = "0x79D110", Offset = "0x79C310", VA = "0x18079D110")]
	private void OnDownTouchArea()
	{
	}

	[Token(Token = "0x60084AB")]
	[Address(RVA = "0x88D2C0", Offset = "0x88C4C0", VA = "0x18088D2C0")]
	private void OnUpTouchArea()
	{
	}

	[Token(Token = "0x60084AC")]
	[Address(RVA = "0xCD4A70", Offset = "0xCD3C70", VA = "0x180CD4A70")]
	private void OnClickTouchArea()
	{
	}

	[Token(Token = "0x60084AD")]
	[Address(RVA = "0xCD4AC0", Offset = "0xCD3CC0", VA = "0x180CD4AC0")]
	private void OnInputAcceptKey()
	{
	}

	[Token(Token = "0x60084AE")]
	[Address(RVA = "0x4B7A80", Offset = "0x4B6C80", VA = "0x1804B7A80")]
	private void OnInputSub2Key()
	{
	}

	[Token(Token = "0x60084AF")]
	[Address(RVA = "0xA8E590", Offset = "0xA8D790", VA = "0x180A8E590")]
	private void OnClickSkipButton()
	{
	}

	[Token(Token = "0x60084B0")]
	[Address(RVA = "0xCD4DF0", Offset = "0xCD3FF0", VA = "0x180CD4DF0")]
	public CardPackCanvasActorContainer()
	{
	}
}
