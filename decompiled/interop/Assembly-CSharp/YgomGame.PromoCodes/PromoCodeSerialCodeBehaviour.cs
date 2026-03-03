using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B5A")]
public class PromoCodeSerialCodeBehaviour : PromoCodeBehaviourBase
{
	[Token(Token = "0x2000B5B")]
	[CompilerGenerated]
	private sealed class _003COnProgressUpdate_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096BB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096BC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40096BD")]
		[FieldOffset(Offset = "0x20")]
		public PromoCodeSerialCodeBehaviour _003C_003E4__this;

		[Token(Token = "0x40096BE")]
		[FieldOffset(Offset = "0x28")]
		private string _003CmmaPath_003E5__2;

		[Token(Token = "0x17000955")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60045A5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000956")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60045A7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressUpdate_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60045A3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x8F8250", Offset = "0x8F7450", VA = "0x1808F8250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x8F8880", Offset = "0x8F7A80", VA = "0x1808F8880", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40096B4")]
	internal const string k_Args_PromoCodeId = "promoCodeId";

	[Token(Token = "0x40096B5")]
	private const string k_EmbedMMAPath = "MDMarkupAsset/PromoCodes/PromoCodes_{0:D4}";

	[Token(Token = "0x40096B6")]
	private const string k_ELabel_EmbedMMAWidget = "EmbedMMAWidget";

	[Token(Token = "0x40096B7")]
	private const string k_ELabel_CodeInputWidget = "CodeInputWidget";

	[Token(Token = "0x40096B8")]
	[FieldOffset(Offset = "0x60")]
	private int m_PromoCodesId;

	[Token(Token = "0x40096B9")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<string, object> m_PromoCodeDataWork;

	[Token(Token = "0x40096BA")]
	[FieldOffset(Offset = "0x70")]
	private CodeInputWidget m_CodeInputWidget;

	[Token(Token = "0x17000950")]
	public override IPromoCodeBehaviour.Type type
	{
		[Token(Token = "0x6004591")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "21")]
		get
		{
			return default(IPromoCodeBehaviour.Type);
		}
	}

	[Token(Token = "0x17000951")]
	public override string viewLabel
	{
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x8ECB80", Offset = "0x8EBD80", VA = "0x1808ECB80", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000952")]
	public override string titleCategoryText
	{
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x8ECB20", Offset = "0x8EBD20", VA = "0x1808ECB20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000953")]
	public override string titleBodyText
	{
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x8ECB10", Offset = "0x8EBD10", VA = "0x1808ECB10", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000954")]
	public override bool useInputCoolTime
	{
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004596")]
	[Address(RVA = "0x8EC0D0", Offset = "0x8EB2D0", VA = "0x1808EC0D0")]
	public static string MakePromoCodesNameText(int promoCodesId)
	{
		return null;
	}

	[Token(Token = "0x6004597")]
	[Address(RVA = "0x8EBDD0", Offset = "0x8EAFD0", VA = "0x1808EBDD0")]
	private string MakeInputGuideText(int promoCodesId, PromoCodeFormat format, int length)
	{
		return null;
	}

	[Token(Token = "0x6004598")]
	[Address(RVA = "0x8EBFC0", Offset = "0x8EB1C0", VA = "0x1808EBFC0")]
	private string MakeOnErrorText(PromoCodesCode resultCode)
	{
		return null;
	}

	[Token(Token = "0x6004599")]
	[Address(RVA = "0x8ECB00", Offset = "0x8EBD00", VA = "0x1808ECB00")]
	public PromoCodeSerialCodeBehaviour(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600459A")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "26")]
	public override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600459B")]
	[Address(RVA = "0x8ECA00", Offset = "0x8EBC00", VA = "0x1808ECA00", Slot = "27")]
	[IteratorStateMachine(typeof(_003COnProgressUpdate_003Ed__22))]
	protected override IEnumerator OnProgressUpdate()
	{
		return null;
	}

	[Token(Token = "0x600459C")]
	[Address(RVA = "0x8ECA70", Offset = "0x8EBC70", VA = "0x1808ECA70", Slot = "28")]
	public override void OnReady()
	{
	}

	[Token(Token = "0x600459D")]
	[Address(RVA = "0x8ECA80", Offset = "0x8EBC80", VA = "0x1808ECA80")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600459E")]
	[Address(RVA = "0x8EC170", Offset = "0x8EB370", VA = "0x1808EC170")]
	private void OnCodeDecided(string promoCode)
	{
	}

	[Token(Token = "0x600459F")]
	[Address(RVA = "0x8EC3D0", Offset = "0x8EB5D0", VA = "0x1808EC3D0")]
	private void OnCodeSendResult(Handle h)
	{
	}

	[Token(Token = "0x60045A0")]
	[Address(RVA = "0x8EC5D0", Offset = "0x8EB7D0", VA = "0x1808EC5D0")]
	private void OnCodeSuccess(Dictionary<string, object> resultWork)
	{
	}

	[Token(Token = "0x60045A1")]
	[Address(RVA = "0x8EC250", Offset = "0x8EB450", VA = "0x1808EC250")]
	private void OnCodeFailed(Dictionary<string, object> resultWork, PromoCodesCode resultCode)
	{
	}
}
