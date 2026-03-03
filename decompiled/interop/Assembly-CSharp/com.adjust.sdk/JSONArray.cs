using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DCC")]
public class JSONArray : JSONNode, IEnumerable
{
	[Token(Token = "0x2001DCD")]
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010559")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401055A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x401055B")]
		[FieldOffset(Offset = "0x20")]
		public JSONArray _003C_003E4__this;

		[Token(Token = "0x401055C")]
		[FieldOffset(Offset = "0x28")]
		private List<JSONNode>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17001C48")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BEAC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C49")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BEAE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BEA8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BEA9")]
		[Address(RVA = "0x59E520", Offset = "0x59D720", VA = "0x18059E520", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BEAA")]
		[Address(RVA = "0x59E330", Offset = "0x59D530", VA = "0x18059E330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BEAB")]
		[Address(RVA = "0x59E5B0", Offset = "0x59D7B0", VA = "0x18059E5B0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600BEAD")]
		[Address(RVA = "0x59E4E0", Offset = "0x59D6E0", VA = "0x18059E4E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001DCE")]
	[CompilerGenerated]
	private sealed class _003Cget_Childs_003Ed__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401055D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401055E")]
		[FieldOffset(Offset = "0x18")]
		private JSONNode _003C_003E2__current;

		[Token(Token = "0x401055F")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4010560")]
		[FieldOffset(Offset = "0x28")]
		public JSONArray _003C_003E4__this;

		[Token(Token = "0x4010561")]
		[FieldOffset(Offset = "0x30")]
		private List<JSONNode>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17001C4A")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x600BEB3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C4B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BEB5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BEAF")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003Cget_Childs_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BEB0")]
		[Address(RVA = "0x59EC80", Offset = "0x59DE80", VA = "0x18059EC80", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BEB1")]
		[Address(RVA = "0x59E9F0", Offset = "0x59DBF0", VA = "0x18059E9F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BEB2")]
		[Address(RVA = "0x59ED10", Offset = "0x59DF10", VA = "0x18059ED10")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600BEB4")]
		[Address(RVA = "0x59EC40", Offset = "0x59DE40", VA = "0x18059EC40", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600BEB6")]
		[Address(RVA = "0x59EBA0", Offset = "0x59DDA0", VA = "0x18059EBA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600BEB7")]
		[Address(RVA = "0x59EBA0", Offset = "0x59DDA0", VA = "0x18059EBA0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4010558")]
	[FieldOffset(Offset = "0x10")]
	private List<JSONNode> m_List;

	[Token(Token = "0x17001C44")]
	public override JSONNode this[int aIndex]
	{
		[Token(Token = "0x600BE9A")]
		[Address(RVA = "0x59BBF0", Offset = "0x59ADF0", VA = "0x18059BBF0", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BE9B")]
		[Address(RVA = "0x59BD60", Offset = "0x59AF60", VA = "0x18059BD60", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001C45")]
	public override JSONNode this[string aKey]
	{
		[Token(Token = "0x600BE9C")]
		[Address(RVA = "0x59BB70", Offset = "0x59AD70", VA = "0x18059BB70", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BE9D")]
		[Address(RVA = "0x59BCB0", Offset = "0x59AEB0", VA = "0x18059BCB0", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001C46")]
	public override int Count
	{
		[Token(Token = "0x600BE9E")]
		[Address(RVA = "0x59BB30", Offset = "0x59AD30", VA = "0x18059BB30", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C47")]
	public override IEnumerable<JSONNode> Childs
	{
		[Token(Token = "0x600BEA2")]
		[Address(RVA = "0x59BAB0", Offset = "0x59ACB0", VA = "0x18059BAB0", Slot = "16")]
		[IteratorStateMachine(typeof(_003Cget_Childs_003Ed__13))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BE9F")]
	[Address(RVA = "0x59B2F0", Offset = "0x59A4F0", VA = "0x18059B2F0", Slot = "4")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x600BEA0")]
	[Address(RVA = "0x59B410", Offset = "0x59A610", VA = "0x18059B410", Slot = "14")]
	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x600BEA1")]
	[Address(RVA = "0x59B4C0", Offset = "0x59A6C0", VA = "0x18059B4C0", Slot = "15")]
	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x600BEA3")]
	[Address(RVA = "0x59B3A0", Offset = "0x59A5A0", VA = "0x18059B3A0", Slot = "29")]
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__14))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600BEA4")]
	[Address(RVA = "0x59B620", Offset = "0x59A820", VA = "0x18059B620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600BEA5")]
	[Address(RVA = "0x59B7E0", Offset = "0x59A9E0", VA = "0x18059B7E0", Slot = "17")]
	public override string ToString(string aPrefix)
	{
		return null;
	}

	[Token(Token = "0x600BEA6")]
	[Address(RVA = "0x59B520", Offset = "0x59A720", VA = "0x18059B520", Slot = "28")]
	public override void Serialize(BinaryWriter aWriter)
	{
	}

	[Token(Token = "0x600BEA7")]
	[Address(RVA = "0x59BA30", Offset = "0x59AC30", VA = "0x18059BA30")]
	public JSONArray()
	{
	}
}
