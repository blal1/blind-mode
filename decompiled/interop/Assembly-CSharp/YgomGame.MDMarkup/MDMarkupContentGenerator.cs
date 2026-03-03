using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C82")]
public class MDMarkupContentGenerator : MDMarkupContentBase, IMDMarkupContentGenerator, IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId, IMDMarkupContentAsyncLoader, IMDMarkupSourceRequireTextData, IMDMarkupSourceSupportedInvalidMessage
{
	[Token(Token = "0x2000C83")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4009B4A")]
		[FieldOffset(Offset = "0x10")]
		public IMDMarkupSourceAsset sourceAsset;

		[Token(Token = "0x4009B4B")]
		[FieldOffset(Offset = "0x18")]
		public int contentLoadingCnt;

		[Token(Token = "0x4009B4C")]
		[FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x949BB0", Offset = "0x948DB0", VA = "0x180949BB0")]
		internal void _003CyLoadAsync_003Eb__0(string path)
		{
		}

		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x949D90", Offset = "0x948F90", VA = "0x180949D90")]
		internal void _003CyLoadAsync_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000C84")]
	[CompilerGenerated]
	private sealed class _003CyLoadAsync_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009B4D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009B4E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009B4F")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupContentGenerator _003C_003E4__this;

		[Token(Token = "0x4009B50")]
		[FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x4009B51")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		[Token(Token = "0x4009B52")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator _003CsetupRoutine_003E5__2;

		[Token(Token = "0x4009B53")]
		[FieldOffset(Offset = "0x40")]
		private List<IMDMarkupContent> _003CgeneratedContents_003E5__3;

		[Token(Token = "0x17000A64")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004BD6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A65")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004BD8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyLoadAsync_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x94B570", Offset = "0x94A770", VA = "0x18094B570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x94C820", Offset = "0x94BA20", VA = "0x18094C820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009B45")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AssetPath(typeof(MDMarkupSourceAssetInterface))]
	public string source;

	[Token(Token = "0x4009B46")]
	[FieldOffset(Offset = "0x30")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x4009B47")]
	[FieldOffset(Offset = "0x38")]
	private List<IMDMarkupContent> m_OutputContents;

	[Token(Token = "0x4009B48")]
	[FieldOffset(Offset = "0x40")]
	private int m_InvalidMessagePriority;

	[Token(Token = "0x4009B49")]
	[FieldOffset(Offset = "0x48")]
	private string m_InvalidMessageText;

	[Token(Token = "0x17000A5F")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x9385F0", Offset = "0x9377F0", VA = "0x1809385F0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A60")]
	public override int contentIndent
	{
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A61")]
	public List<IMDMarkupContent> outputContents
	{
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A62")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0", Slot = "27")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A63")]
	public string invalidMessageText
	{
		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BC9")]
	[Address(RVA = "0x938200", Offset = "0x937400", VA = "0x180938200", Slot = "19")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004BCA")]
	[Address(RVA = "0x9385A0", Offset = "0x9377A0", VA = "0x1809385A0")]
	public MDMarkupContentGenerator()
	{
	}

	[Token(Token = "0x6004BCB")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0", Slot = "26")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BCC")]
	[Address(RVA = "0x938400", Offset = "0x937600", VA = "0x180938400", Slot = "25")]
	public void LoadAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6004BCD")]
	[Address(RVA = "0x938600", Offset = "0x937800", VA = "0x180938600")]
	[IteratorStateMachine(typeof(_003CyLoadAsync_003Ed__19))]
	private IEnumerator yLoadAsync(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004BCE")]
	[Address(RVA = "0x938490", Offset = "0x937690", VA = "0x180938490", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BCF")]
	[Address(RVA = "0x938510", Offset = "0x937710", VA = "0x180938510", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}
}
