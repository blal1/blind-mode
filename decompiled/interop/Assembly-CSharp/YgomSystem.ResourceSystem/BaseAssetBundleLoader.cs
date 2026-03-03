using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002B1")]
public abstract class BaseAssetBundleLoader : BaseLoader, ISpriteTagLoader
{
	[Token(Token = "0x20002B2")]
	protected internal class AssetBundleCache
	{
		[Token(Token = "0x20002B3")]
		[CompilerGenerated]
		private sealed class _003CLoadAsync_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F31")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000F32")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000F33")]
			[FieldOffset(Offset = "0x20")]
			public AssetBundleCache _003C_003E4__this;

			[Token(Token = "0x4000F34")]
			[FieldOffset(Offset = "0x28")]
			private AssetBundleRequest _003Creq_003E5__2;

			[Token(Token = "0x1700019F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6001088")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600108A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001085")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CLoadAsync_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6001086")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001087")]
			[Address(RVA = "0xE7F0F0", Offset = "0xE7E2F0", VA = "0x180E7F0F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001089")]
			[Address(RVA = "0xE7F1A0", Offset = "0xE7E3A0", VA = "0x180E7F1A0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x10")]
		private List<WeakReference> weakRefs;

		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x18")]
		private AssetBundle bundle;

		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x20")]
		private bool unloadAll;

		[Token(Token = "0x1700019D")]
		public bool IsAlive
		{
			[Token(Token = "0x600107D")]
			[Address(RVA = "0xE68F10", Offset = "0xE68110", VA = "0x180E68F10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019E")]
		public UnityEngine.Object[] Target
		{
			[Token(Token = "0x600107E")]
			[Address(RVA = "0xE69060", Offset = "0xE68260", VA = "0x180E69060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600107C")]
		[Address(RVA = "0xCCCDA0", Offset = "0xCCBFA0", VA = "0x180CCCDA0")]
		public AssetBundleCache(AssetBundle asset, bool unload = false)
		{
		}

		[Token(Token = "0x600107F")]
		[Address(RVA = "0xE68950", Offset = "0xE67B50", VA = "0x180E68950")]
		public bool IsContains(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0xE68B10", Offset = "0xE67D10", VA = "0x180E68B10")]
		public bool IsSpriteAtlas()
		{
			return default(bool);
		}

		[Token(Token = "0x6001081")]
		[Address(RVA = "0xE68CE0", Offset = "0xE67EE0", VA = "0x180E68CE0")]
		public void Release()
		{
		}

		[Token(Token = "0x6001082")]
		[Address(RVA = "0xE68CA0", Offset = "0xE67EA0", VA = "0x180E68CA0")]
		public void Load()
		{
		}

		[Token(Token = "0x6001083")]
		[Address(RVA = "0xE68C30", Offset = "0xE67E30", VA = "0x180E68C30")]
		[IteratorStateMachine(typeof(_003CLoadAsync_003Ed__12))]
		public IEnumerator LoadAsync()
		{
			return null;
		}

		[Token(Token = "0x6001084")]
		[Address(RVA = "0xE68DB0", Offset = "0xE67FB0", VA = "0x180E68DB0")]
		private void SetObjects(UnityEngine.Object[] objects)
		{
		}
	}

	[Token(Token = "0x20002B4")]
	protected internal class AssetCache : AbstractReferenceCache<AssetBundleCache>
	{
		[Token(Token = "0x600108B")]
		[Address(RVA = "0xE69C90", Offset = "0xE68E90", VA = "0x180E69C90", Slot = "4")]
		protected override AssetBundleCache LoadRequest(string key, params object[] param)
		{
			return null;
		}

		[Token(Token = "0x600108C")]
		[Address(RVA = "0xE69DA0", Offset = "0xE68FA0", VA = "0x180E69DA0", Slot = "5")]
		protected override void RemoveCacheAction(AssetBundleCache value)
		{
		}

		[Token(Token = "0x600108D")]
		[Address(RVA = "0xE69900", Offset = "0xE68B00", VA = "0x180E69900", Slot = "6")]
		public override void Clear()
		{
		}

		[Token(Token = "0x600108E")]
		[Address(RVA = "0xE69C30", Offset = "0xE68E30", VA = "0x180E69C30")]
		public List<string> ExistsKeys()
		{
			return null;
		}

		[Token(Token = "0x600108F")]
		[Address(RVA = "0xE69E80", Offset = "0xE69080", VA = "0x180E69E80")]
		public AssetCache()
		{
		}
	}

	[Token(Token = "0x20002B5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x10")]
		public AssetBundle assetBundle;

		[Token(Token = "0x6001090")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6001091")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CLoadAsync_003Eb__0(AssetBundle _assetbundle)
		{
		}
	}

	[Token(Token = "0x20002B6")]
	[CompilerGenerated]
	private sealed class _003CLoadAsync_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x20")]
		public BaseAssetBundleLoader _003C_003E4__this;

		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x28")]
		public Resource res;

		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x38")]
		private AssetBundleCache _003Ccache_003E5__2;

		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x40")]
		private List<string>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x58")]
		private string _003CloadPath_003E5__4;

		[Token(Token = "0x170001A1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001098")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001092")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAsync_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001093")]
		[Address(RVA = "0xE80160", Offset = "0xE7F360", VA = "0x180E80160", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0xE7F750", Offset = "0xE7E950", VA = "0x180E7F750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001095")]
		[Address(RVA = "0xE801F0", Offset = "0xE7F3F0", VA = "0x180E801F0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0xE80120", Offset = "0xE7F320", VA = "0x180E80120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F27")]
	private const int kAssetCacheFrame = 10;

	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, HashSet<string>> m_loadedDic;

	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, int> m_unloadReqDic;

	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, string> m_loadingDic;

	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, string> m_spriteTagDic;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x38")]
	private List<string> m_unloadKeys;

	[Token(Token = "0x1700019C")]
	protected virtual AssetCache assetCache
	{
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600106B")]
	protected abstract List<string> GetWithDependenciesList(Resource res);

	[Token(Token = "0x600106C")]
	protected abstract IEnumerator yLoadRequestCache(string loadPath, Action<AssetBundle> callback);

	[Token(Token = "0x600106D")]
	protected abstract void RemoveRequestCache(string loadPath);

	[Token(Token = "0x600106E")]
	protected abstract void ClearRequestCache();

	[Token(Token = "0x600106F")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	protected static bool GetUnloadAllOption(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6001070")]
	[Address(RVA = "0xE6A1B0", Offset = "0xE693B0", VA = "0x180E6A1B0")]
	private void AddLoadedList(Resource res, List<string> addList)
	{
	}

	[Token(Token = "0x6001071")]
	[Address(RVA = "0xE6A090", Offset = "0xE69290", VA = "0x180E6A090")]
	private void AddLoadedList(Resource res, string addPath)
	{
	}

	[Token(Token = "0x6001072")]
	[Address(RVA = "0xE6ADF0", Offset = "0xE69FF0", VA = "0x180E6ADF0", Slot = "12")]
	public override void Load(Resource res, uint crc)
	{
	}

	[Token(Token = "0x6001073")]
	[Address(RVA = "0xE6AC50", Offset = "0xE69E50", VA = "0x180E6AC50", Slot = "13")]
	[IteratorStateMachine(typeof(_003CLoadAsync_003Ed__20))]
	public override IEnumerator LoadAsync(Resource res, uint key)
	{
		return null;
	}

	[Token(Token = "0x6001074")]
	[Address(RVA = "0xE6ACE0", Offset = "0xE69EE0", VA = "0x180E6ACE0")]
	private void LoadCancel(Resource res)
	{
	}

	[Token(Token = "0x6001075")]
	[Address(RVA = "0xE6B1D0", Offset = "0xE6A3D0", VA = "0x180E6B1D0")]
	private void UnloadAction(Resource res)
	{
	}

	[Token(Token = "0x6001076")]
	[Address(RVA = "0xE6B4C0", Offset = "0xE6A6C0", VA = "0x180E6B4C0")]
	private void UnloadRequest(Resource res)
	{
	}

	[Token(Token = "0x6001077")]
	[Address(RVA = "0xE6A700", Offset = "0xE69900", VA = "0x180E6A700", Slot = "14")]
	public override void LateUpdate()
	{
	}

	[Token(Token = "0x6001078")]
	[Address(RVA = "0xE6A350", Offset = "0xE69550", VA = "0x180E6A350", Slot = "15")]
	public override void ClearCache()
	{
	}

	[Token(Token = "0x6001079")]
	[Address(RVA = "0xE6A270", Offset = "0xE69470", VA = "0x180E6A270")]
	public void AddSpriteTagDic(string loadPath)
	{
	}

	[Token(Token = "0x600107A")]
	[Address(RVA = "0xE6A660", Offset = "0xE69860", VA = "0x180E6A660", Slot = "16")]
	public string GetPathFromSpriteAtlasTag(string tag)
	{
		return null;
	}

	[Token(Token = "0x600107B")]
	[Address(RVA = "0xE6B600", Offset = "0xE6A800", VA = "0x180E6B600")]
	protected BaseAssetBundleLoader()
	{
	}
}
