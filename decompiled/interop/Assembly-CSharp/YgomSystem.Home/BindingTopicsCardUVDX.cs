using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomSystem.Home;

[Token(Token = "0x2000387")]
[RequireComponent(typeof(Image))]
public class BindingTopicsCardUVDX : BindingAsyncBase, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2000388")]
	private class CardUVData
	{
		[Token(Token = "0x4001221")]
		[FieldOffset(Offset = "0x10")]
		public int mrk;

		[Token(Token = "0x4001222")]
		[FieldOffset(Offset = "0x14")]
		public Vector4 uvVector4;

		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x521430", Offset = "0x520630", VA = "0x180521430")]
		public CardUVData(int mrk, Vector4 uvVector4)
		{
		}
	}

	[Token(Token = "0x2000389")]
	public enum UVType
	{
		[Token(Token = "0x4001224")]
		PACK,
		[Token(Token = "0x4001225")]
		ACCESSORY
	}

	[Token(Token = "0x200038B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x10")]
		public BindingTopicsCardUVDX _003C_003E4__this;

		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x18")]
		public bool isLoadingCardIllust;

		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x20")]
		public List<CardUVData> cardUVList;

		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x52FCA0", Offset = "0x52EEA0", VA = "0x18052FCA0")]
		internal void _003CyBindingRoutine_003Eb__1(Dictionary<int, Texture2D> dic)
		{
		}
	}

	[Token(Token = "0x200038C")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0x20")]
		public BindingTopicsCardUVDX _003C_003E4__this;

		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0x30")]
		private uint _003CimageCrc_003E5__2;

		[Token(Token = "0x17000236")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60015C3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60015C5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x532F30", Offset = "0x532130", VA = "0x180532F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x5336C0", Offset = "0x5328C0", VA = "0x1805336C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001217")]
	private const string k_MaterialPath = "Images/Notification/Materials/TopicsCardUVDX";

	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UVType uvType;

	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int mrk1;

	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector4 uvVector4_1;

	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int mrk2;

	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector4 uvVector4_2;

	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string m_BackImagePath;

	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x68")]
	private Image m_ImageCache;

	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x70")]
	private Material m_ModifiedMaterial;

	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x78")]
	private uint m_UsingImageCrc;

	[Token(Token = "0x17000235")]
	private Image image
	{
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x5202B0", Offset = "0x51F4B0", VA = "0x1805202B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x520390", Offset = "0x51F590", VA = "0x180520390", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__14))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x5200B0", Offset = "0x51F2B0", VA = "0x1805200B0")]
	private Vector4 SetBaseUV(UVType _uvType, int _mrk)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x51FF60", Offset = "0x51F160", VA = "0x18051FF60", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x520000", Offset = "0x51F200", VA = "0x180520000")]
	private void Release()
	{
	}

	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x520290", Offset = "0x51F490", VA = "0x180520290")]
	public BindingTopicsCardUVDX()
	{
	}
}
