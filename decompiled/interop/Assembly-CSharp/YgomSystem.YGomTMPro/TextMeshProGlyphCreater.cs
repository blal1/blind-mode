using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x2000236")]
public class TextMeshProGlyphCreater : ITextMeshProGlyphCreateBuffer
{
	[Token(Token = "0x2000237")]
	private class CreateBuffer
	{
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x10")]
		public readonly TMP_FontAsset fontAsset;

		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<string> texts;

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0xD36DC0", Offset = "0xD35FC0", VA = "0x180D36DC0")]
		public CreateBuffer(TMP_FontAsset fontAsset)
		{
		}
	}

	[Token(Token = "0x2000238")]
	[CompilerGenerated]
	private sealed class _003CyCreate_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProGlyphCreater _003C_003E4__this;

		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x30")]
		public TMP_FontAsset fontAsset;

		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x38")]
		private TextElementEnumerator _003CcharEnum_003E5__2;

		[Token(Token = "0x17000166")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000167")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCreate_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0xD42B70", Offset = "0xD41D70", VA = "0x180D42B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0xD42E80", Offset = "0xD42080", VA = "0x180D42E80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000239")]
	[CompilerGenerated]
	private sealed class _003CyCreateByAllBuffer_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProGlyphCreater _003C_003E4__this;

		[Token(Token = "0x4000B6A")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<TMP_FontAsset, CreateBuffer>.ValueCollection.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x4000B6B")]
		[FieldOffset(Offset = "0x40")]
		private CreateBuffer _003CcreateBuffer_003E5__3;

		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x48")]
		private List<string>.Enumerator _003C_003E7__wrap3;

		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x60")]
		private IEnumerator _003CcreateRoutine_003E5__5;

		[Token(Token = "0x17000168")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCreateByAllBuffer_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0xD42850", Offset = "0xD41A50", VA = "0x180D42850", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0xD423A0", Offset = "0xD415A0", VA = "0x180D423A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0xD42990", Offset = "0xD41B90", VA = "0x180D42990")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0xD429E0", Offset = "0xD41BE0", VA = "0x180D429E0")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x6000D30")]
		[Address(RVA = "0xD42810", Offset = "0xD41A10", VA = "0x180D42810", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200023A")]
	[CompilerGenerated]
	private sealed class _003CyCreateByTMP_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProGlyphCreater _003C_003E4__this;

		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Text tmpText;

		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x30")]
		public string text;

		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator _003Croutine_003E5__2;

		[Token(Token = "0x1700016A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCreateByTMP_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0xD42A30", Offset = "0xD41C30", VA = "0x180D42A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D36")]
		[Address(RVA = "0xD42B30", Offset = "0xD41D30", VA = "0x180D42B30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x10")]
	private readonly int k_TMPGryphTryAddSpan;

	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<TMP_FontAsset, CreateBuffer> m_CreateBufferMap;

	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder m_Sb;

	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x28")]
	private List<TMP_FontAsset> m_SearchFontListCache;

	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x30")]
	private int m_RawCreatedLen;

	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0xD3C530", Offset = "0xD3B730", VA = "0x180D3C530")]
	[IteratorStateMachine(typeof(_003CyCreateByTMP_003Ed__6))]
	public IEnumerator yCreateByTMP(TMP_Text tmpText, string text)
	{
		return null;
	}

	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0xD3C0A0", Offset = "0xD3B2A0", VA = "0x180D3C0A0", Slot = "4")]
	public void AssignBuffer(TMP_Text tmpText, string text)
	{
	}

	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0xD3C4C0", Offset = "0xD3B6C0", VA = "0x180D3C4C0")]
	[IteratorStateMachine(typeof(_003CyCreateByAllBuffer_003Ed__8))]
	public IEnumerator yCreateByAllBuffer()
	{
		return null;
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0xD3C310", Offset = "0xD3B510", VA = "0x180D3C310")]
	private bool SetupTMP(TMP_Text tmpText, string text)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0xD3C5E0", Offset = "0xD3B7E0", VA = "0x180D3C5E0")]
	[IteratorStateMachine(typeof(_003CyCreate_003Ed__10))]
	private IEnumerator yCreate(TMP_FontAsset fontAsset, string text)
	{
		return null;
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0xD3C400", Offset = "0xD3B600", VA = "0x180D3C400")]
	private bool TryAddCharacters(TMP_FontAsset fontAsset, string characters)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D22")]
	[Address(RVA = "0xD3C4B0", Offset = "0xD3B6B0", VA = "0x180D3C4B0")]
	public TextMeshProGlyphCreater()
	{
	}
}
