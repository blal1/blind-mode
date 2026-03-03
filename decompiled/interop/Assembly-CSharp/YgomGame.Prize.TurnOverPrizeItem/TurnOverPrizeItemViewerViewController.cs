using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomGame.Menu.Common;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000BA9")]
public class TurnOverPrizeItemViewerViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000BAC")]
	[CompilerGenerated]
	private sealed class _003CyWaitBinding_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40097A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40097A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40097A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IAsyncProgressContent binding;

		[Token(Token = "0x40097A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x17000997")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004711")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000998")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004713")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600470E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitBinding_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600470F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004710")]
		[Address(RVA = "0x917890", Offset = "0x916A90", VA = "0x180917890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004712")]
		[Address(RVA = "0x917930", Offset = "0x916B30", VA = "0x180917930", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009796")]
	private const string k_VCPath = "Prize/TurnOverPrizeItem/TurnOverPrizeItemViewer";

	[Token(Token = "0x4009797")]
	private const string k_ArgKeyPrizeId = "prizeId";

	[Token(Token = "0x4009798")]
	private const string GOB_PACK_GROUP = "PackGroup";

	[Token(Token = "0x4009799")]
	private const string GOB_BOX_TEMPLATE = "BoxTemplate";

	[Token(Token = "0x400979A")]
	private const string IMG_BOX_COVER = "CoverImage";

	[Token(Token = "0x400979B")]
	private const string GOB_ITEM_LOCATER = "ItemLocater";

	[Token(Token = "0x400979C")]
	private const string GOB_CARD_LOCATER = "CardLocater";

	[Token(Token = "0x400979D")]
	private const string TXT_ITEM_NUM = "ItemNum";

	[Token(Token = "0x400979E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<object> m_PrizeDatas;

	[Token(Token = "0x17000996")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004702")]
		[Address(RVA = "0x90F6B0", Offset = "0x90E8B0", VA = "0x18090F6B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004703")]
	[Address(RVA = "0x90F5B0", Offset = "0x90E7B0", VA = "0x18090F5B0")]
	public static void Open(int prizeId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004704")]
	[Address(RVA = "0x90EB10", Offset = "0x90DD10", VA = "0x18090EB10", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004705")]
	[Address(RVA = "0x90EC00", Offset = "0x90DE00", VA = "0x18090EC00", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004706")]
	[Address(RVA = "0x90F7F0", Offset = "0x90E9F0", VA = "0x18090F7F0")]
	[IteratorStateMachine(typeof(_003CyWaitBinding_003Ed__14))]
	private IEnumerator yWaitBinding(IAsyncProgressContent binding, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004707")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TurnOverPrizeItemViewerViewController()
	{
	}
}
