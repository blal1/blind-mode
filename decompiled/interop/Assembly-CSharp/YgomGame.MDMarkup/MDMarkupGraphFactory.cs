using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CE1")]
public class MDMarkupGraphFactory : MonoBehaviour
{
	[Token(Token = "0x2000CE2")]
	public enum Style
	{
		[Token(Token = "0x4009CA4")]
		Default,
		[Token(Token = "0x4009CA5")]
		Pager
	}

	[Token(Token = "0x2000CE3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x4009CA6")]
		[FieldOffset(Offset = "0x10")]
		public MDMarkupGraphFactory _003C_003E4__this;

		[Token(Token = "0x4009CA7")]
		[FieldOffset(Offset = "0x18")]
		public GameObject indent0Template;

		[Token(Token = "0x4009CA8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject indent1Template;

		[Token(Token = "0x4009CA9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject indent2Template;

		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x960070", Offset = "0x95F270", VA = "0x180960070")]
		internal void _003CyInitialize_003Eb__0(string loadedPath)
		{
		}

		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x9601B0", Offset = "0x95F3B0", VA = "0x1809601B0")]
		internal void _003CyInitialize_003Eb__1(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE0")]
		[Address(RVA = "0x960220", Offset = "0x95F420", VA = "0x180960220")]
		internal void _003CyInitialize_003Eb__2(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE1")]
		[Address(RVA = "0x960290", Offset = "0x95F490", VA = "0x180960290")]
		internal void _003CyInitialize_003Eb__3(UnityEngine.Object res)
		{
		}
	}

	[Token(Token = "0x2000CE4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x4009CAA")]
		[FieldOffset(Offset = "0x10")]
		public GameObject separatorTemplate;

		[Token(Token = "0x4009CAB")]
		[FieldOffset(Offset = "0x18")]
		public GameObject spacerSTemplate;

		[Token(Token = "0x4009CAC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject spacerMTemplate;

		[Token(Token = "0x4009CAD")]
		[FieldOffset(Offset = "0x28")]
		public GameObject spacerLTemplate;

		[Token(Token = "0x4009CAE")]
		[FieldOffset(Offset = "0x30")]
		public ElementObjectManager textTemplate;

		[Token(Token = "0x4009CAF")]
		[FieldOffset(Offset = "0x38")]
		public ElementObjectManager imageTemplate;

		[Token(Token = "0x4009CB0")]
		[FieldOffset(Offset = "0x40")]
		public ElementObjectManager header1Template;

		[Token(Token = "0x4009CB1")]
		[FieldOffset(Offset = "0x48")]
		public ElementObjectManager header2Template;

		[Token(Token = "0x4009CB2")]
		[FieldOffset(Offset = "0x50")]
		public ElementObjectManager tableRootTemplate;

		[Token(Token = "0x4009CB3")]
		[FieldOffset(Offset = "0x58")]
		public ElementObjectManager tableRowTemplate;

		[Token(Token = "0x4009CB4")]
		[FieldOffset(Offset = "0x60")]
		public ElementObjectManager tableCellTextHeaderTemplate;

		[Token(Token = "0x4009CB5")]
		[FieldOffset(Offset = "0x68")]
		public ElementObjectManager tableCellTextNormalTemplate;

		[Token(Token = "0x4009CB6")]
		[FieldOffset(Offset = "0x70")]
		public ElementObjectManager tableCellTextImageTemplate;

		[Token(Token = "0x4009CB7")]
		[FieldOffset(Offset = "0x78")]
		public ElementObjectManager tableCellCardTemplate;

		[Token(Token = "0x4009CB8")]
		[FieldOffset(Offset = "0x80")]
		public ElementObjectManager tableCellItemTemplate;

		[Token(Token = "0x4009CB9")]
		[FieldOffset(Offset = "0x88")]
		public ElementObjectManager tableCellBannerTemplate;

		[Token(Token = "0x4009CBA")]
		[FieldOffset(Offset = "0x90")]
		public ElementObjectManager tableCellButtonSTemplate;

		[Token(Token = "0x4009CBB")]
		[FieldOffset(Offset = "0x98")]
		public ElementObjectManager tableCellButtonMTemplate;

		[Token(Token = "0x4009CBC")]
		[FieldOffset(Offset = "0xA0")]
		public ElementObjectManager tableCellButtonLTemplate;

		[Token(Token = "0x4009CBD")]
		[FieldOffset(Offset = "0xA8")]
		public ElementObjectManager tableCellTableTemplate;

		[Token(Token = "0x4009CBE")]
		[FieldOffset(Offset = "0xB0")]
		public ElementObjectManager fullTextPageTemplate;

		[Token(Token = "0x6004DE2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6004DE3")]
		[Address(RVA = "0x960300", Offset = "0x95F500", VA = "0x180960300")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__0(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE4")]
		[Address(RVA = "0x960910", Offset = "0x95FB10", VA = "0x180960910")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__1(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0x960A10", Offset = "0x95FC10", VA = "0x180960A10")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__2(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x960A80", Offset = "0x95FC80", VA = "0x180960A80")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__3(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x960AF0", Offset = "0x95FCF0", VA = "0x180960AF0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__4(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x960B80", Offset = "0x95FD80", VA = "0x180960B80")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__5(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x960C10", Offset = "0x95FE10", VA = "0x180960C10")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__6(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x960CA0", Offset = "0x95FEA0", VA = "0x180960CA0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__7(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x960D30", Offset = "0x95FF30", VA = "0x180960D30")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__8(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x960DC0", Offset = "0x95FFC0", VA = "0x180960DC0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__9(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x960370", Offset = "0x95F570", VA = "0x180960370")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__10(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x960400", Offset = "0x95F600", VA = "0x180960400")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__11(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x960490", Offset = "0x95F690", VA = "0x180960490")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__12(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x960520", Offset = "0x95F720", VA = "0x180960520")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__13(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x9605B0", Offset = "0x95F7B0", VA = "0x1809605B0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__14(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x960640", Offset = "0x95F840", VA = "0x180960640")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__15(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x9606D0", Offset = "0x95F8D0", VA = "0x1809606D0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__16(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x960760", Offset = "0x95F960", VA = "0x180960760")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__17(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x9607F0", Offset = "0x95F9F0", VA = "0x1809607F0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__18(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x960880", Offset = "0x95FA80", VA = "0x180960880")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__19(UnityEngine.Object res)
		{
		}

		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x960980", Offset = "0x95FB80", VA = "0x180960980")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__20(UnityEngine.Object res)
		{
		}
	}

	[Token(Token = "0x2000CE5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_1
	{
		[Token(Token = "0x4009CBF")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager template;

		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_1()
		{
		}

		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x960E50", Offset = "0x960050", VA = "0x180960E50")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__21(UnityEngine.Object res)
		{
		}
	}

	[Token(Token = "0x2000CE6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_2
	{
		[Token(Token = "0x4009CC0")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager template;

		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_2()
		{
		}

		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x960EE0", Offset = "0x9600E0", VA = "0x180960EE0")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__22(UnityEngine.Object res)
		{
		}
	}

	[Token(Token = "0x2000CE7")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_3
	{
		[Token(Token = "0x4009CC1")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager template;

		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_3()
		{
		}

		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x960F70", Offset = "0x960170", VA = "0x180960F70")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__23(UnityEngine.Object res)
		{
		}
	}

	[Token(Token = "0x2000CE8")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_4
	{
		[Token(Token = "0x4009CC2")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager template;

		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_4()
		{
		}

		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0x961000", Offset = "0x960200", VA = "0x180961000")]
		internal void _003CLoadOrGetMarkupFactory_003Eb__24(UnityEngine.Object res)
		{
		}
	}

	[Token(Token = "0x2000CE9")]
	[CompilerGenerated]
	private sealed class _003CLoadOrGetMarkupFactory_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009CC3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009CC4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009CC5")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupGraphFactory _003C_003E4__this;

		[Token(Token = "0x4009CC6")]
		[FieldOffset(Offset = "0x28")]
		public MDMarkupDef.MarkupType markupType;

		[Token(Token = "0x4009CC7")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		[Token(Token = "0x4009CC8")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass41_1 _003C_003E8__2;

		[Token(Token = "0x4009CC9")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass41_2 _003C_003E8__3;

		[Token(Token = "0x4009CCA")]
		[FieldOffset(Offset = "0x48")]
		private _003C_003Ec__DisplayClass41_3 _003C_003E8__4;

		[Token(Token = "0x4009CCB")]
		[FieldOffset(Offset = "0x50")]
		private _003C_003Ec__DisplayClass41_4 _003C_003E8__5;

		[Token(Token = "0x4009CCC")]
		[FieldOffset(Offset = "0x58")]
		public Action<IMDMarkupWidgetFactory> callback;

		[Token(Token = "0x17000B0B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004E03")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004E05")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E00")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadOrGetMarkupFactory_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004E01")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004E02")]
		[Address(RVA = "0x95D600", Offset = "0x95C800", VA = "0x18095D600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E04")]
		[Address(RVA = "0x95F880", Offset = "0x95EA80", VA = "0x18095F880", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CEA")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009CCD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009CCE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009CCF")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupGraphFactory _003C_003E4__this;

		[Token(Token = "0x4009CD0")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		[Token(Token = "0x4009CD1")]
		[FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x17000B0D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004E09")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004E0B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E06")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004E08")]
		[Address(RVA = "0x961F10", Offset = "0x961110", VA = "0x180961F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x962580", Offset = "0x961780", VA = "0x180962580", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009C81")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_MDTemplateContainerPath;

	[Token(Token = "0x4009C82")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_MDTemplateContainerPagerPath;

	[Token(Token = "0x4009C83")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_CLabelIndent0Template;

	[Token(Token = "0x4009C84")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_CLabelIndent1Template;

	[Token(Token = "0x4009C85")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_CLabelIndent2Template;

	[Token(Token = "0x4009C86")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_CLabelHeader1Template;

	[Token(Token = "0x4009C87")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_CLabelHeader2Template;

	[Token(Token = "0x4009C88")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_CLabelTextTemplate;

	[Token(Token = "0x4009C89")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_CLabelImageTemplate;

	[Token(Token = "0x4009C8A")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_CLabelSeparatorTemplate;

	[Token(Token = "0x4009C8B")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_CLabelSpacerSTemplate;

	[Token(Token = "0x4009C8C")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_CLabelSpacerMTemplate;

	[Token(Token = "0x4009C8D")]
	[FieldOffset(Offset = "0x80")]
	private readonly string k_CLabelSpacerLTemplate;

	[Token(Token = "0x4009C8E")]
	[FieldOffset(Offset = "0x88")]
	private readonly string k_CLabelTableRootTemplate;

	[Token(Token = "0x4009C8F")]
	[FieldOffset(Offset = "0x90")]
	private readonly string k_CLabelTableRowTemplate;

	[Token(Token = "0x4009C90")]
	[FieldOffset(Offset = "0x98")]
	private readonly string k_CLabelTableCellTextHeaderTemplate;

	[Token(Token = "0x4009C91")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string k_CLabelTableCellTextNormalTemplate;

	[Token(Token = "0x4009C92")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string k_CLabelTableCellImageTemplate;

	[Token(Token = "0x4009C93")]
	[FieldOffset(Offset = "0xB0")]
	private readonly string k_CLabelTableCellCardTemplate;

	[Token(Token = "0x4009C94")]
	[FieldOffset(Offset = "0xB8")]
	private readonly string k_CLabelTableCellItemTemplate;

	[Token(Token = "0x4009C95")]
	[FieldOffset(Offset = "0xC0")]
	private readonly string k_CLabelTableCellBannerTemplate;

	[Token(Token = "0x4009C96")]
	[FieldOffset(Offset = "0xC8")]
	private readonly string k_CLabelTableCellButtonSTemplate;

	[Token(Token = "0x4009C97")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_CLabelTableCellButtonMTemplate;

	[Token(Token = "0x4009C98")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_CLabelTableCellButtonLTemplate;

	[Token(Token = "0x4009C99")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_CLabelTableCellTableTemplate;

	[Token(Token = "0x4009C9A")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_CLabelFullImagePageTemplate;

	[Token(Token = "0x4009C9B")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_CLabelFullTextPageTemplate;

	[Token(Token = "0x4009C9C")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_CLabelHalfImageTextPageTemplate;

	[Token(Token = "0x4009C9D")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_CLabelHalfImageMarkupPageTemplate;

	[Token(Token = "0x4009C9E")]
	[FieldOffset(Offset = "0x108")]
	public Style style;

	[Token(Token = "0x4009C9F")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private AssetLinkContainer m_MDTemplateContainer;

	[Token(Token = "0x4009CA0")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<MDMarkupDef.MarkupType, IMDMarkupWidgetFactory> m_FactoryCacheMap;

	[Token(Token = "0x4009CA1")]
	[FieldOffset(Offset = "0x120")]
	private MDMarkupIndentFactory m_IndentFactory;

	[Token(Token = "0x4009CA2")]
	[FieldOffset(Offset = "0x128")]
	private Coroutine m_InitializeCoroutine;

	[Token(Token = "0x17000B0A")]
	public MDMarkupIndentFactory indentFactory
	{
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004DD7")]
	[Address(RVA = "0x953130", Offset = "0x952330", VA = "0x180953130")]
	private string GetContainerPath(Style style)
	{
		return null;
	}

	[Token(Token = "0x6004DD8")]
	[Address(RVA = "0x953150", Offset = "0x952350", VA = "0x180953150")]
	public void Initialize(Action onComplete)
	{
	}

	[Token(Token = "0x6004DD9")]
	[Address(RVA = "0x953900", Offset = "0x952B00", VA = "0x180953900")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__39))]
	private IEnumerator yInitialize(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004DDA")]
	[Address(RVA = "0x9532E0", Offset = "0x9524E0", VA = "0x1809532E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004DDB")]
	[Address(RVA = "0x953240", Offset = "0x952440", VA = "0x180953240")]
	[IteratorStateMachine(typeof(_003CLoadOrGetMarkupFactory_003Ed__41))]
	public IEnumerator LoadOrGetMarkupFactory(MDMarkupDef.MarkupType markupType, Action<IMDMarkupWidgetFactory> callback)
	{
		return null;
	}

	[Token(Token = "0x6004DDC")]
	[Address(RVA = "0x953390", Offset = "0x952590", VA = "0x180953390")]
	public MDMarkupGraphFactory()
	{
	}
}
