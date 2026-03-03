using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CB5")]
[CreateAssetMenu(menuName = "Scriptable Object/MMA/MMASourceFormat生成")]
public class MDMarkupSourceCardTable : MDMarkupSourceAssetInterface
{
	[Serializable]
	[Token(Token = "0x2000CB6")]
	public class FormatData
	{
		[Token(Token = "0x4009BDC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string key;

		[Token(Token = "0x4009BDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[TextArea]
		public string value;

		[Token(Token = "0x6004D07")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FormatData()
		{
		}
	}

	[Token(Token = "0x2000CB9")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009BE3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009BE4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000AEA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004D12")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AEB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004D14")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D0F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004D10")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004D11")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D13")]
		[Address(RVA = "0x964DA0", Offset = "0x963FA0", VA = "0x180964DA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009BD6")]
	[FieldOffset(Offset = "0x28")]
	public string mrkLabel;

	[Token(Token = "0x4009BD7")]
	[FieldOffset(Offset = "0x30")]
	[TextArea]
	public string tableBodyTemplate;

	[Token(Token = "0x4009BD8")]
	[FieldOffset(Offset = "0x38")]
	[TextArea]
	public string tableCellTemplate;

	[Token(Token = "0x4009BD9")]
	[FieldOffset(Offset = "0x40")]
	public string outNamesKey;

	[Token(Token = "0x4009BDA")]
	[FieldOffset(Offset = "0x48")]
	public string outNamesBody;

	[Token(Token = "0x4009BDB")]
	[FieldOffset(Offset = "0x50")]
	public string outNamesSplit;

	[Token(Token = "0x6004D04")]
	[Address(RVA = "0x959250", Offset = "0x958450", VA = "0x180959250", Slot = "8")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__7))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x6004D05")]
	[Address(RVA = "0x958720", Offset = "0x957920", VA = "0x180958720", Slot = "9")]
	public override void Output(List<IMDMarkupContent> res)
	{
	}

	[Token(Token = "0x6004D06")]
	[Address(RVA = "0x959180", Offset = "0x958380", VA = "0x180959180")]
	public MDMarkupSourceCardTable()
	{
	}
}
