using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomGame.Utility;

namespace YgomGame.Shop;

[Token(Token = "0x2000922")]
public class ShopPackHighlightMMASource : MDMarkupSourceAssetInterface, IMDMarkupSourceRequireTextData
{
	[Token(Token = "0x2000923")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40089F0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40089F1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40089F2")]
		[FieldOffset(Offset = "0x20")]
		public ShopPackHighlightMMASource _003C_003E4__this;

		[Token(Token = "0x1700069C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60036EE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x7EA960", Offset = "0x7E9B60", VA = "0x1807EA960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x7EAEA0", Offset = "0x7EA0A0", VA = "0x1807EAEA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40089E7")]
	private const string k_ArgKey_ShopId = "shop_id";

	[Token(Token = "0x40089E8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[TextArea]
	public string captionJson;

	[Token(Token = "0x40089E9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[TextArea]
	public string highlightTemplateJson;

	[Token(Token = "0x40089EA")]
	[FieldOffset(Offset = "0x38")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x40089EB")]
	[FieldOffset(Offset = "0x40")]
	private string m_PackName;

	[Token(Token = "0x40089EC")]
	[FieldOffset(Offset = "0x48")]
	private string m_PackThumbPath;

	[Token(Token = "0x40089ED")]
	[FieldOffset(Offset = "0x50")]
	private string m_PackDesc;

	[Token(Token = "0x40089EE")]
	[FieldOffset(Offset = "0x58")]
	private List<int> m_HighlightMrks;

	[Token(Token = "0x1700069A")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700069B")]
	public string invalidMessageText
	{
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60036E2")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520", Slot = "10")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60036E3")]
	[Address(RVA = "0x7DCD10", Offset = "0x7DBF10", VA = "0x1807DCD10", Slot = "8")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__15))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x60036E4")]
	[Address(RVA = "0x7DCA60", Offset = "0x7DBC60", VA = "0x1807DCA60", Slot = "9")]
	public override void Output(List<IMDMarkupContent> res)
	{
	}

	[Token(Token = "0x60036E5")]
	[Address(RVA = "0x7DC0F0", Offset = "0x7DB2F0", VA = "0x1807DC0F0")]
	private void BindCaption(Dictionary<string, IMDMarkupId> idMap)
	{
	}

	[Token(Token = "0x60036E6")]
	[Address(RVA = "0x7DC400", Offset = "0x7DB600", VA = "0x1807DC400")]
	private void BindHighlight(Dictionary<string, IMDMarkupId> idMap, int mrk)
	{
	}

	[Token(Token = "0x60036E7")]
	[Address(RVA = "0x7DC820", Offset = "0x7DBA20", VA = "0x1807DC820")]
	private string GetCardDesc(int mrk)
	{
		return null;
	}

	[Token(Token = "0x60036E8")]
	[Address(RVA = "0x7DCD00", Offset = "0x7DBF00", VA = "0x1807DCD00")]
	public ShopPackHighlightMMASource()
	{
	}
}
