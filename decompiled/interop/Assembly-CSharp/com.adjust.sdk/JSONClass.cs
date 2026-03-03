using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DCF")]
public class JSONClass : JSONNode, IEnumerable
{
	[Token(Token = "0x2001DD1")]
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010564")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010565")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010566")]
		[FieldOffset(Offset = "0x20")]
		public JSONClass _003C_003E4__this;

		[Token(Token = "0x4010567")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17001C50")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BECD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C51")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BECF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BEC9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BECA")]
		[Address(RVA = "0x59E860", Offset = "0x59DA60", VA = "0x18059E860", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BECB")]
		[Address(RVA = "0x59E600", Offset = "0x59D800", VA = "0x18059E600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BECC")]
		[Address(RVA = "0x59E8F0", Offset = "0x59DAF0", VA = "0x18059E8F0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600BECE")]
		[Address(RVA = "0x59E820", Offset = "0x59DA20", VA = "0x18059E820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001DD2")]
	[CompilerGenerated]
	private sealed class _003Cget_Childs_003Ed__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010568")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010569")]
		[FieldOffset(Offset = "0x18")]
		private JSONNode _003C_003E2__current;

		[Token(Token = "0x401056A")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x401056B")]
		[FieldOffset(Offset = "0x28")]
		public JSONClass _003C_003E4__this;

		[Token(Token = "0x401056C")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17001C52")]
		private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
		{
			[Token(Token = "0x600BED4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C53")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BED6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BED0")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003Cget_Childs_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BED1")]
		[Address(RVA = "0x59F050", Offset = "0x59E250", VA = "0x18059F050", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BED2")]
		[Address(RVA = "0x59ED90", Offset = "0x59DF90", VA = "0x18059ED90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BED3")]
		[Address(RVA = "0x59F0E0", Offset = "0x59E2E0", VA = "0x18059F0E0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600BED5")]
		[Address(RVA = "0x59F010", Offset = "0x59E210", VA = "0x18059F010", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600BED7")]
		[Address(RVA = "0x59EF70", Offset = "0x59E170", VA = "0x18059EF70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600BED8")]
		[Address(RVA = "0x59EF70", Offset = "0x59E170", VA = "0x18059EF70", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4010562")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, JSONNode> m_Dict;

	[Token(Token = "0x17001C4C")]
	public override JSONNode this[string aKey]
	{
		[Token(Token = "0x600BEB8")]
		[Address(RVA = "0x59CD60", Offset = "0x59BF60", VA = "0x18059CD60", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BEB9")]
		[Address(RVA = "0x59CE40", Offset = "0x59C040", VA = "0x18059CE40", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001C4D")]
	public override JSONNode this[int aIndex]
	{
		[Token(Token = "0x600BEBA")]
		[Address(RVA = "0x59CCC0", Offset = "0x59BEC0", VA = "0x18059CCC0", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BEBB")]
		[Address(RVA = "0x59CF00", Offset = "0x59C100", VA = "0x18059CF00", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001C4E")]
	public override int Count
	{
		[Token(Token = "0x600BEBC")]
		[Address(RVA = "0x59CC70", Offset = "0x59BE70", VA = "0x18059CC70", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C4F")]
	public override IEnumerable<JSONNode> Childs
	{
		[Token(Token = "0x600BEC1")]
		[Address(RVA = "0x59CBF0", Offset = "0x59BDF0", VA = "0x18059CBF0", Slot = "16")]
		[IteratorStateMachine(typeof(_003Cget_Childs_003Ed__14))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BEBD")]
	[Address(RVA = "0x59BE70", Offset = "0x59B070", VA = "0x18059BE70", Slot = "4")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x600BEBE")]
	[Address(RVA = "0x59C0C0", Offset = "0x59B2C0", VA = "0x18059C0C0", Slot = "13")]
	public override JSONNode Remove(string aKey)
	{
		return null;
	}

	[Token(Token = "0x600BEBF")]
	[Address(RVA = "0x59BFF0", Offset = "0x59B1F0", VA = "0x18059BFF0", Slot = "14")]
	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	[Token(Token = "0x600BEC0")]
	[Address(RVA = "0x59C190", Offset = "0x59B390", VA = "0x18059C190", Slot = "15")]
	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	[Token(Token = "0x600BEC2")]
	[Address(RVA = "0x59BF80", Offset = "0x59B180", VA = "0x18059BF80", Slot = "29")]
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__15))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600BEC3")]
	[Address(RVA = "0x59C4E0", Offset = "0x59B6E0", VA = "0x18059C4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600BEC4")]
	[Address(RVA = "0x59C7E0", Offset = "0x59B9E0", VA = "0x18059C7E0", Slot = "17")]
	public override string ToString(string aPrefix)
	{
		return null;
	}

	[Token(Token = "0x600BEC5")]
	[Address(RVA = "0x59C2E0", Offset = "0x59B4E0", VA = "0x18059C2E0", Slot = "28")]
	public override void Serialize(BinaryWriter aWriter)
	{
	}

	[Token(Token = "0x600BEC6")]
	[Address(RVA = "0x59CB70", Offset = "0x59BD70", VA = "0x18059CB70")]
	public JSONClass()
	{
	}
}
