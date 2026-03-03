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
[Token(Token = "0x2000C8E")]
public class MDMarkupContentReference : MDMarkupContentBase, IMDMarkupContentGenerator, IMDMarkupContent, IMDMarkupSource, IMDMarkupId, IMDMarkupOwnedId, IMDMarkupSourceRequireTextData, IMDMarkupContentAsyncLoader, IMDMarkupSourceSupportedInvalidMessage
{
	[Token(Token = "0x2000C8F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4009B7E")]
		[FieldOffset(Offset = "0x10")]
		public MDMarkupAssetJson referenceMMA;

		[Token(Token = "0x4009B7F")]
		[FieldOffset(Offset = "0x18")]
		public bool readyMMaAsset;

		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x949C70", Offset = "0x948E70", VA = "0x180949C70")]
		internal void _003CyLoadAsync_003Eb__0(string path)
		{
		}

		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
		internal void _003CyLoadAsync_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000C90")]
	[CompilerGenerated]
	private sealed class _003CyLoadAsync_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009B80")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009B81")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009B82")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupContentReference _003C_003E4__this;

		[Token(Token = "0x4009B83")]
		[FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x4009B84")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		[Token(Token = "0x4009B85")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, object> _003CsourceMDMarkupArgs_003E5__2;

		[Token(Token = "0x4009B86")]
		[FieldOffset(Offset = "0x40")]
		private MDMarkupAsset _003CmmaAsset_003E5__3;

		[Token(Token = "0x17000A7D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004C2C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004C2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyLoadAsync_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x94BF80", Offset = "0x94B180", VA = "0x18094BF80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x94C7E0", Offset = "0x94B9E0", VA = "0x18094C7E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009B79")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AssetPath(typeof(MDMarkupAssetJson))]
	public string source;

	[Token(Token = "0x4009B7A")]
	[FieldOffset(Offset = "0x30")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x4009B7B")]
	[FieldOffset(Offset = "0x38")]
	private List<IMDMarkupContent> m_OutputContents;

	[Token(Token = "0x4009B7C")]
	[FieldOffset(Offset = "0x40")]
	private int m_InvalidMessagePriority;

	[Token(Token = "0x4009B7D")]
	[FieldOffset(Offset = "0x48")]
	private string m_InvalidMessageText;

	[Token(Token = "0x17000A78")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x93C6A0", Offset = "0x93B8A0", VA = "0x18093C6A0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A79")]
	public override int contentIndent
	{
		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A7A")]
	public List<IMDMarkupContent> outputContents
	{
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A7B")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0", Slot = "27")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A7C")]
	public string invalidMessageText
	{
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004C1F")]
	[Address(RVA = "0x93C300", Offset = "0x93B500", VA = "0x18093C300", Slot = "19")]
	public override void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004C20")]
	[Address(RVA = "0x9385A0", Offset = "0x9377A0", VA = "0x1809385A0")]
	public MDMarkupContentReference()
	{
	}

	[Token(Token = "0x6004C21")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0", Slot = "25")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004C22")]
	[Address(RVA = "0x93C500", Offset = "0x93B700", VA = "0x18093C500", Slot = "26")]
	public void LoadAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6004C23")]
	[Address(RVA = "0x93C6B0", Offset = "0x93B8B0", VA = "0x18093C6B0")]
	[IteratorStateMachine(typeof(_003CyLoadAsync_003Ed__19))]
	private IEnumerator yLoadAsync(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004C24")]
	[Address(RVA = "0x93C590", Offset = "0x93B790", VA = "0x18093C590", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004C25")]
	[Address(RVA = "0x93C610", Offset = "0x93B810", VA = "0x18093C610", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}
}
