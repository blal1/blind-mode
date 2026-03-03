using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.LocalFileSystem;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002AE")]
public class AssetBundleLoader : BaseAssetBundleLoader
{
	[Token(Token = "0x20002AF")]
	internal class RequestCache : AbstractReferenceCache<LocalFileAssetBundleLoadRequest>
	{
		[Token(Token = "0x6001060")]
		[Address(RVA = "0xE731A0", Offset = "0xE723A0", VA = "0x180E731A0", Slot = "4")]
		protected override LocalFileAssetBundleLoadRequest LoadRequest(string key, params object[] param)
		{
			return null;
		}

		[Token(Token = "0x6001061")]
		[Address(RVA = "0xE73260", Offset = "0xE72460", VA = "0x180E73260", Slot = "5")]
		protected override void RemoveCacheAction(LocalFileAssetBundleLoadRequest value)
		{
		}

		[Token(Token = "0x6001062")]
		[Address(RVA = "0xE732B0", Offset = "0xE724B0", VA = "0x180E732B0")]
		public RequestCache()
		{
		}
	}

	[Token(Token = "0x20002B0")]
	[CompilerGenerated]
	private sealed class _003CyLoadRequestCache_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x20")]
		public AssetBundleLoader _003C_003E4__this;

		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x28")]
		public string loadPath;

		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x30")]
		public Action<AssetBundle> callback;

		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x38")]
		private LocalFileAssetBundleLoadRequest _003Crequest_003E5__2;

		[Token(Token = "0x1700019A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001066")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001068")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001063")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyLoadRequestCache_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001064")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001065")]
		[Address(RVA = "0xE83180", Offset = "0xE82380", VA = "0x180E83180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001067")]
		[Address(RVA = "0xE832B0", Offset = "0xE824B0", VA = "0x180E832B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x40")]
	private DependenciesList dlcList;

	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x48")]
	private DependenciesList dlcStreamingList;

	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x50")]
	private RequestCache reqCache;

	[Token(Token = "0x6001057")]
	[Address(RVA = "0xE697E0", Offset = "0xE689E0", VA = "0x180E697E0")]
	private void loadDLCList()
	{
	}

	[Token(Token = "0x6001058")]
	[Address(RVA = "0xE692B0", Offset = "0xE684B0", VA = "0x180E692B0", Slot = "19")]
	protected override List<string> GetWithDependenciesList(Resource res)
	{
		return null;
	}

	[Token(Token = "0x6001059")]
	[Address(RVA = "0xE69490", Offset = "0xE68690", VA = "0x180E69490", Slot = "11")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600105A")]
	[Address(RVA = "0xE69850", Offset = "0xE68A50", VA = "0x180E69850", Slot = "20")]
	[IteratorStateMachine(typeof(_003CyLoadRequestCache_003Ed__7))]
	protected override IEnumerator yLoadRequestCache(string loadPath, Action<AssetBundle> callback)
	{
		return null;
	}

	[Token(Token = "0x600105B")]
	[Address(RVA = "0xE69540", Offset = "0xE68740", VA = "0x180E69540", Slot = "21")]
	protected override void RemoveRequestCache(string loadPath)
	{
	}

	[Token(Token = "0x600105C")]
	[Address(RVA = "0xE69280", Offset = "0xE68480", VA = "0x180E69280", Slot = "22")]
	protected override void ClearRequestCache()
	{
	}

	[Token(Token = "0x600105D")]
	[Address(RVA = "0xE69240", Offset = "0xE68440", VA = "0x180E69240", Slot = "15")]
	public override void ClearCache()
	{
	}

	[Token(Token = "0x600105E")]
	[Address(RVA = "0x5ECDA0", Offset = "0x5EBFA0", VA = "0x1805ECDA0")]
	private void CardIllustPathNotificator(object value)
	{
	}

	[Token(Token = "0x600105F")]
	[Address(RVA = "0xE695A0", Offset = "0xE687A0", VA = "0x180E695A0")]
	public AssetBundleLoader()
	{
	}
}
