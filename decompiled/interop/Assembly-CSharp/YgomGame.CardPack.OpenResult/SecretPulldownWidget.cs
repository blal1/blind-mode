using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Shop;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.OpenResult;

[Token(Token = "0x200154A")]
public class SecretPulldownWidget : ElementWidgetBase
{
	[Token(Token = "0x200154B")]
	public class ExpandsWidget : ElementWidgetBase
	{
		[Token(Token = "0x400CC18")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelLineHead;

		[Token(Token = "0x400CC19")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelLineTemplate;

		[Token(Token = "0x400CC1A")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_ELineLabelText;

		[Token(Token = "0x400CC1B")]
		[FieldOffset(Offset = "0x38")]
		private readonly ElementObjectManager m_LineTemplate;

		[Token(Token = "0x400CC1C")]
		[FieldOffset(Offset = "0x40")]
		private List<ElementObjectManager> m_LineEoms;

		[Token(Token = "0x6008399")]
		[Address(RVA = "0xCBE070", Offset = "0xCBD270", VA = "0x180CBE070")]
		public ExpandsWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x600839A")]
		[Address(RVA = "0xCBDD10", Offset = "0xCBCF10", VA = "0x180CBDD10")]
		public void Binding(IReadOnlyList<int> shopIds)
		{
		}
	}

	[Token(Token = "0x400CC08")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelBody;

	[Token(Token = "0x400CC09")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelLabelRoot;

	[Token(Token = "0x400CC0A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLabelText;

	[Token(Token = "0x400CC0B")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelExpands;

	[Token(Token = "0x400CC0C")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_TweenOpen;

	[Token(Token = "0x400CC0D")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_TweenClose;

	[Token(Token = "0x400CC0E")]
	[FieldOffset(Offset = "0x50")]
	public readonly SelectionItem labelSelectionItem;

	[Token(Token = "0x400CC0F")]
	[FieldOffset(Offset = "0x58")]
	public readonly SelectionItem expandsSelectionItem;

	[Token(Token = "0x400CC10")]
	[FieldOffset(Offset = "0x60")]
	private readonly GameObject m_Body;

	[Token(Token = "0x400CC11")]
	[FieldOffset(Offset = "0x68")]
	private readonly GameObject m_LabelRoot;

	[Token(Token = "0x400CC12")]
	[FieldOffset(Offset = "0x70")]
	private readonly TMP_Text m_LabelText;

	[Token(Token = "0x400CC13")]
	[FieldOffset(Offset = "0x78")]
	private readonly ExpandsWidget m_ExpandsWidget;

	[Token(Token = "0x400CC14")]
	[FieldOffset(Offset = "0x80")]
	private readonly ProductContext m_PackProductContent;

	[Token(Token = "0x400CC15")]
	[FieldOffset(Offset = "0x88")]
	private List<int> m_ShopIds;

	[Token(Token = "0x400CC16")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsExpanded;

	[Token(Token = "0x400CC17")]
	[FieldOffset(Offset = "0x91")]
	private bool m_ExpandDirty;

	[Token(Token = "0x1700140F")]
	public GameObject body
	{
		[Token(Token = "0x6008391")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001410")]
	public bool isExpanded
	{
		[Token(Token = "0x6008392")]
		[Address(RVA = "0xCC7E30", Offset = "0xCC7030", VA = "0x180CC7E30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008393")]
	[Address(RVA = "0xCC79E0", Offset = "0xCC6BE0", VA = "0x180CC79E0")]
	public SecretPulldownWidget(ElementObjectManager eom, GameObject pulldownRoot)
	{
	}

	[Token(Token = "0x6008394")]
	[Address(RVA = "0xCC7470", Offset = "0xCC6670", VA = "0x180CC7470")]
	public void Binding(IReadOnlyList<int> shopIds)
	{
	}

	[Token(Token = "0x6008395")]
	[Address(RVA = "0xCC7840", Offset = "0xCC6A40", VA = "0x180CC7840")]
	public void OpenExpand(bool isTween = true, bool enableRetry = false)
	{
	}

	[Token(Token = "0x6008396")]
	[Address(RVA = "0xCC7680", Offset = "0xCC6880", VA = "0x180CC7680")]
	public void CloseExpand(bool isTween = true, bool enableRetry = false)
	{
	}

	[Token(Token = "0x6008397")]
	[Address(RVA = "0xCC77F0", Offset = "0xCC69F0", VA = "0x180CC77F0")]
	private void OnTweenOpenStart()
	{
	}

	[Token(Token = "0x6008398")]
	[Address(RVA = "0xCC77A0", Offset = "0xCC69A0", VA = "0x180CC77A0")]
	private void OnTweenCloseEnd()
	{
	}
}
