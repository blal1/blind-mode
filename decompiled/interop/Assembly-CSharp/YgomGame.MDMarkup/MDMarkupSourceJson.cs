using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CBA")]
[CreateAssetMenu(menuName = "Scriptable Object/MMA/MMASource生成")]
public class MDMarkupSourceJson : MDMarkupSourceAssetInterface
{
	[Token(Token = "0x2000CBB")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009BE6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009BE7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000AEC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004D1B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AED")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004D1D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D18")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004D19")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D1C")]
		[Address(RVA = "0x964D60", Offset = "0x963F60", VA = "0x180964D60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009BE5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[TextArea]
	public string json;

	[Token(Token = "0x6004D15")]
	[Address(RVA = "0x9592C0", Offset = "0x9584C0", VA = "0x1809592C0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__1))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x6004D16")]
	[Address(RVA = "0x9592A0", Offset = "0x9584A0", VA = "0x1809592A0", Slot = "9")]
	public override void Output(List<IMDMarkupContent> res)
	{
	}

	[Token(Token = "0x6004D17")]
	[Address(RVA = "0x958710", Offset = "0x957910", VA = "0x180958710")]
	public MDMarkupSourceJson()
	{
	}
}
