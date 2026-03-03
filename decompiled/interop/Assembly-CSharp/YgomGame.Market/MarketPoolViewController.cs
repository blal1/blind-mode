using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Market;

[Token(Token = "0x2000D22")]
public class MarketPoolViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000D23")]
	private interface ISource
	{
	}

	[Token(Token = "0x2000D24")]
	private class ItemHeaderSource : ISource
	{
		[Token(Token = "0x4009D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPeriod;

		[Token(Token = "0x4009DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int itemCategory;

		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ItemHeaderSource()
		{
		}
	}

	[Token(Token = "0x2000D25")]
	private class ItemGruopSource : ISource
	{
		[Token(Token = "0x4009DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly List<(bool isPeriod, int itemCategory, int itemId, object source)> items;

		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x9712B0", Offset = "0x9704B0", VA = "0x1809712B0")]
		public ItemGruopSource()
		{
		}
	}

	[Token(Token = "0x2000D28")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MarketPoolViewController _003C_003E4__this;

		[Token(Token = "0x17000B5B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004F48")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B5C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004F4A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x9796A0", Offset = "0x9788A0", VA = "0x1809796A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x97A170", Offset = "0x979370", VA = "0x18097A170", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009D8E")]
	private const int k_GrayoutType_Default = 0;

	[Token(Token = "0x4009D8F")]
	private const int k_GrayoutType_Grayout_OFF = 1;

	[Token(Token = "0x4009D90")]
	private const int k_GrayoutType_Grayout_ON = 2;

	[Token(Token = "0x4009D91")]
	private const string k_PrefPath = "Market/MarketPool";

	[Token(Token = "0x4009D92")]
	private const string k_ArgKey_MarketId = "marketId";

	[Token(Token = "0x4009D93")]
	private const string k_ELabel_ScrollView = "ScrollView";

	[Token(Token = "0x4009D94")]
	private const string k_ELabel_Header_Label = "Label";

	[Token(Token = "0x4009D95")]
	private const string k_ELabel_ItemGroupGrid = "ScrollView/ItemGruopTemplate";

	[Token(Token = "0x4009D96")]
	private const string k_ELabel_ItemGroup_ItemThumb = "Image";

	[Token(Token = "0x4009D97")]
	private const string k_ELabel_ItemGroup_GrayoutCover = "GrayoutCover";

	[Token(Token = "0x4009D98")]
	private const int k_TemplateIdx_Header = 1;

	[Token(Token = "0x4009D99")]
	private const int k_TemplateIdx_ItemGroup = 0;

	[Token(Token = "0x4009D9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x4009D9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<ISource> m_EntitySources;

	[Token(Token = "0x4009D9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<int> m_TemplateIdxs;

	[Token(Token = "0x4009D9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_GroupLength;

	[Token(Token = "0x4009D9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Dictionary<GameObject, List<ElementObjectManager>> m_ItemGroupWidgetsMap;

	[Token(Token = "0x17000B59")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000B5A")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x9771B0", Offset = "0x9763B0", VA = "0x1809771B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F34")]
	[Address(RVA = "0x976CB0", Offset = "0x975EB0", VA = "0x180976CB0")]
	public static void Open(int marketId, bool withRequest = true, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004F35")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004F36")]
	[Address(RVA = "0x976330", Offset = "0x975530", VA = "0x180976330", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004F37")]
	[Address(RVA = "0x977020", Offset = "0x976220", VA = "0x180977020")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__27))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6004F38")]
	[Address(RVA = "0x976020", Offset = "0x975220", VA = "0x180976020")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6004F39")]
	[Address(RVA = "0x975FC0", Offset = "0x9751C0", VA = "0x180975FC0")]
	private bool IsSelectableDataIndex(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F3A")]
	[Address(RVA = "0x976610", Offset = "0x975810", VA = "0x180976610")]
	private void OnUpdateEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6004F3B")]
	[Address(RVA = "0x976900", Offset = "0x975B00", VA = "0x180976900")]
	private void OnUpdateItemGroup(GameObject entity, ItemGruopSource source)
	{
	}

	[Token(Token = "0x6004F3C")]
	[Address(RVA = "0x975F10", Offset = "0x975110", VA = "0x180975F10")]
	private bool IsGrayout(bool isPeriod, int itemCategory, int itemId, object itemSource)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F3D")]
	[Address(RVA = "0x976820", Offset = "0x975A20", VA = "0x180976820")]
	private void OnUpdateHeader(GameObject entity, ItemHeaderSource source)
	{
	}

	[Token(Token = "0x6004F3E")]
	[Address(RVA = "0x977090", Offset = "0x976290", VA = "0x180977090")]
	public MarketPoolViewController()
	{
	}
}
