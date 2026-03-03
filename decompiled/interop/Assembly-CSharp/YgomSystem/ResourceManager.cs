using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;
using YgomSystem.ResourceSystem;

namespace YgomSystem;

[Token(Token = "0x200015F")]
public class ResourceManager : MonoBehaviour
{
	[Token(Token = "0x2000160")]
	public enum UnloadCheckLevel
	{
		[Token(Token = "0x4000849")]
		None,
		[Token(Token = "0x400084A")]
		VeryLow,
		[Token(Token = "0x400084B")]
		Low,
		[Token(Token = "0x400084C")]
		Middle,
		[Token(Token = "0x400084D")]
		High,
		[Token(Token = "0x400084E")]
		Force
	}

	[Token(Token = "0x2000161")]
	public delegate void RequestCompleteHandler(string path);

	[Token(Token = "0x2000162")]
	public delegate void ErrorHandler(string path);

	[Token(Token = "0x2000163")]
	public delegate bool? RetryHandler(bool isstart);

	[Token(Token = "0x2000164")]
	public delegate void ProgressHandler(bool isshow);

	[Token(Token = "0x2000165")]
	public enum ReqType
	{
		[Token(Token = "0x4000850")]
		Sound,
		[Token(Token = "0x4000851")]
		Sound2,
		[Token(Token = "0x4000852")]
		Sound3,
		[Token(Token = "0x4000853")]
		Sound4,
		[Token(Token = "0x4000854")]
		Default,
		[Token(Token = "0x4000855")]
		Default2,
		[Token(Token = "0x4000856")]
		Default3,
		[Token(Token = "0x4000857")]
		Default4,
		[Token(Token = "0x4000858")]
		Default5,
		[Token(Token = "0x4000859")]
		Default6,
		[Token(Token = "0x400085A")]
		Default7,
		[Token(Token = "0x400085B")]
		Default8,
		[Token(Token = "0x400085C")]
		Default9,
		[Token(Token = "0x400085D")]
		Default10,
		[Token(Token = "0x400085E")]
		Default11,
		[Token(Token = "0x400085F")]
		Default12,
		[Token(Token = "0x4000860")]
		Default13,
		[Token(Token = "0x4000861")]
		Default14,
		[Token(Token = "0x4000862")]
		Default15,
		[Token(Token = "0x4000863")]
		Default16,
		[Token(Token = "0x4000864")]
		Default17,
		[Token(Token = "0x4000865")]
		Default18,
		[Token(Token = "0x4000866")]
		Default19,
		[Token(Token = "0x4000867")]
		Default20,
		[Token(Token = "0x4000868")]
		Default21,
		[Token(Token = "0x4000869")]
		Default22,
		[Token(Token = "0x400086A")]
		Default23,
		[Token(Token = "0x400086B")]
		Default24,
		[Token(Token = "0x400086C")]
		Default25,
		[Token(Token = "0x400086D")]
		Default26,
		[Token(Token = "0x400086E")]
		Default27,
		[Token(Token = "0x400086F")]
		Default28,
		[Token(Token = "0x4000870")]
		Default29,
		[Token(Token = "0x4000871")]
		Default30,
		[Token(Token = "0x4000872")]
		Default31,
		[Token(Token = "0x4000873")]
		Default32,
		[Token(Token = "0x4000874")]
		Num
	}

	[Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class _003CCheckUnloadResourcesAsyncRoutine_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnloadCheckLevel unloadLevel;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x170000F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckUnloadResourcesAsyncRoutine_003Ed__82(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xB09A00", Offset = "0xB08C00", VA = "0x180B09A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xB09A80", Offset = "0xB08C80", VA = "0x180B09A80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class _003CRebuildMaterialsAsync_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ResourceManager _003C_003E4__this;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEngine.Object[] assets;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Type systemTypeInstance;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Material> _003Cmtrls_003E5__2;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, Texture> _003Ctexs_003E5__3;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, object> _003CmatInfo_003E5__4;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _003Climit_003E5__5;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _003Cmtrl_003E5__6;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, object>.Enumerator _003C_003E7__wrap6;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private KeyValuePair<string, object> _003Ckvp_003E5__8;

		[Token(Token = "0x170000F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CRebuildMaterialsAsync_003Ed__109(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xB0A6D0", Offset = "0xB098D0", VA = "0x180B0A6D0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xB0A190", Offset = "0xB09390", VA = "0x180B0A190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xB0A760", Offset = "0xB09960", VA = "0x180B0A760")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xB0A690", Offset = "0xB09890", VA = "0x180B0A690", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class _003CUnloadResourcesAsyncRoutine_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onComplete;

		[Token(Token = "0x170000F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUnloadResourcesAsyncRoutine_003Ed__84(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xB0C520", Offset = "0xB0B720", VA = "0x180B0C520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xB0C7F0", Offset = "0xB0B9F0", VA = "0x180B0C7F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class _003CUpdateLoadQueue_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<uint, string> requestDictionary;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ResourceManager _003C_003E4__this;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReqType queueId;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint[] _003CreqKeys_003E5__2;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private uint _003Ckey_003E5__4;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Resource _003Cres_003E5__5;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IResourceLoader _003Cloader_003E5__6;

		[Token(Token = "0x170000F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdateLoadQueue_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xB0C830", Offset = "0xB0BA30", VA = "0x180B0C830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xB0CFC0", Offset = "0xB0C1C0", VA = "0x180B0CFC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000835")]
	private const bool IsDisableErrorPath = false;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ResourceManager s_instance;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ErrorHandler errorHandler;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RetryHandler retryHandler;

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ProgressHandler progressHandler;

	[Token(Token = "0x400083A")]
	private const int SoundQueueNum = 4;

	[Token(Token = "0x400083B")]
	private const int DefaultQueueNum = 32;

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<uint, Resource> resourceDictionary;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<uint, string>[] requestDictionaries;

	[Token(Token = "0x400083E")]
	private const bool defaultSoundLoadSlot = true;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool m_useSoundLoadSlot;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Coroutine[] updateLoadQueues;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int m_UnloadWaitCnt;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_UnloadingResources;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ResourceLoader resourceLoader;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ResTypeChecker resTypeChecker;

	[Token(Token = "0x4000846")]
	private const string matInfoPostfix = ".matinfo";

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, Shader> shaderCache;

	[Token(Token = "0x170000EE")]
	public float HttpTimeOut
	{
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x7DBBC0", Offset = "0x7DADC0", VA = "0x1807DBBC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x7DBBE0", Offset = "0x7DADE0", VA = "0x1807DBBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000EF")]
	public static int unloadWaitCnt
	{
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xB01BE0", Offset = "0xB00DE0", VA = "0x180B01BE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0xAFE120", Offset = "0xAFD320", VA = "0x180AFE120")]
	public static int GetUnloadWaitLimit(UnloadCheckLevel unloadLevel)
	{
		return default(int);
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0xAFD1C0", Offset = "0xAFC3C0", VA = "0x180AFD1C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0xAFEDA0", Offset = "0xAFDFA0", VA = "0x180AFEDA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0xB00850", Offset = "0xAFFA50", VA = "0x180B00850")]
	private void Update()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0xAFE980", Offset = "0xAFDB80", VA = "0x180AFE980")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0xAFE180", Offset = "0xAFD380", VA = "0x180AFE180")]
	public static bool IsAbortReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0xAFD050", Offset = "0xAFC250", VA = "0x180AFD050")]
	private void AtlasRequested(string spriteAtlasname, Action<SpriteAtlas> callback)
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0xB004B0", Offset = "0xAFF6B0", VA = "0x180B004B0")]
	private void UnloadResource(Resource res)
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0xB001E0", Offset = "0xAFF3E0", VA = "0x180B001E0")]
	private void RemoveRequest(Dictionary<uint, string> requestDictionary, uint key)
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0xB00170", Offset = "0xAFF370", VA = "0x180B00170")]
	private void RemoveRequest(uint key, ReqType queueId)
	{
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0xAFCE60", Offset = "0xAFC060", VA = "0x180AFCE60")]
	private ReqType AddRequest(uint crc, string path)
	{
		return default(ReqType);
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0xB007B0", Offset = "0xAFF9B0", VA = "0x180B007B0")]
	[IteratorStateMachine(typeof(_003CUpdateLoadQueue_003Ed__39))]
	private IEnumerator UpdateLoadQueue(Dictionary<uint, string> requestDictionary, ReqType queueId)
	{
		return null;
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0xAFD9F0", Offset = "0xAFCBF0", VA = "0x180AFD9F0")]
	private void DestroyAllResources()
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0xB00B50", Offset = "0xAFFD50", VA = "0x180B00B50")]
	private uint findResource(string path)
	{
		return default(uint);
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0xB02300", Offset = "0xB01500", VA = "0x180B02300")]
	private uint load(string path, Type systemTypeInstance, RequestCompleteHandler completeHandler, bool disableErrorNotify)
	{
		return default(uint);
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0xB02D00", Offset = "0xB01F00", VA = "0x180B02D00")]
	private void unload(string path, bool force)
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0xB02A90", Offset = "0xB01C90", VA = "0x180B02A90")]
	private void unload(uint crc, bool force)
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0xB02780", Offset = "0xB01980", VA = "0x180B02780")]
	private void resetData()
	{
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0xB01E80", Offset = "0xB01080", VA = "0x180B01E80")]
	private uint loadImmediate(string path, Type systemTypeInstance, RequestCompleteHandler completeHandler, bool disableErrorNotify)
	{
		return default(uint);
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0xB01A00", Offset = "0xB00C00", VA = "0x180B01A00")]
	private Resource getResource(string path, out string workPath)
	{
		return null;
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0xB019E0", Offset = "0xB00BE0", VA = "0x180B019E0")]
	private Resource getResource(string path)
	{
		return null;
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0xB01960", Offset = "0xB00B60", VA = "0x180B01960")]
	private Resource getResource(uint crc)
	{
		return null;
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0xB01C60", Offset = "0xB00E60", VA = "0x180B01C60")]
	private bool isDone(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0xB01C30", Offset = "0xB00E30", VA = "0x180B01C30")]
	private bool isDone(uint crc)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0xB01CA0", Offset = "0xB00EA0", VA = "0x180B01CA0")]
	private bool isError(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0xB01CE0", Offset = "0xB00EE0", VA = "0x180B01CE0")]
	private bool isError(uint crc)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0xB01D80", Offset = "0xB00F80", VA = "0x180B01D80")]
	private bool isRequested(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0xB01D10", Offset = "0xB00F10", VA = "0x180B01D10")]
	private bool isRequested(uint crc)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0xB01B50", Offset = "0xB00D50", VA = "0x180B01B50")]
	private string getWorkPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0xB00990", Offset = "0xAFFB90", VA = "0x180B00990")]
	private bool checkAssetType(Type assetType, Type loadType)
	{
		return default(bool);
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0xB00DB0", Offset = "0xAFFFB0", VA = "0x180B00DB0")]
	private UnityEngine.Object getAsset(string path, Type getSystemType)
	{
		return null;
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0xB01620", Offset = "0xB00820", VA = "0x180B01620")]
	private byte[] getBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x60008D3")]
	private List<T> getAssets<T>(string path)
	{
		return null;
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0xB00B10", Offset = "0xAFFD10", VA = "0x180B00B10")]
	private void clearCache()
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0xAFE100", Offset = "0xAFD300", VA = "0x180AFE100")]
	private string GetErrorPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0xAFD660", Offset = "0xAFC860", VA = "0x180AFD660")]
	private void CallErrorHandler(Resource res, bool disableErrorPath = false)
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0xAFDCA0", Offset = "0xAFCEA0", VA = "0x180AFDCA0")]
	public static void EnableSoundLoadSlot()
	{
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0xAFDC10", Offset = "0xAFCE10", VA = "0x180AFDC10")]
	public static void DisableSoundLoadSlot()
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0xAFD960", Offset = "0xAFCB60", VA = "0x180AFD960")]
	public static void DefaultSoundLoadSlot()
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0xAFECA0", Offset = "0xAFDEA0", VA = "0x180AFECA0")]
	public static bool Load(string path, [Optional] Type systemTypeInstance, bool disableErrorNotify = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60008DB")]
	public static bool Load<T>(string path, bool disableErrorNotify = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0xAFECC0", Offset = "0xAFDEC0", VA = "0x180AFECC0")]
	public static bool Load(string path, out uint crc, [Optional] Type systemTypeInstance, bool disableErrorNotify = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60008DD")]
	public static bool Load<T>(string path, out uint crc, bool disableErrorNotify = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0xAFEBA0", Offset = "0xAFDDA0", VA = "0x180AFEBA0")]
	public static bool Load(RequestCompleteHandler handler, string path, [Optional] Type systemTypeInstance)
	{
		return default(bool);
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0xAFEBC0", Offset = "0xAFDDC0", VA = "0x180AFEBC0")]
	public static bool Load(RequestCompleteHandler handler, string path, bool disableErrorNotify, [Optional] Type systemTypeInstance)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0xAFEB80", Offset = "0xAFDD80", VA = "0x180AFEB80")]
	public static bool LoadImmediate(string path, [Optional] Type systemTypeInstance, bool disableErrorNotify = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0xAFEB60", Offset = "0xAFDD60", VA = "0x180AFEB60")]
	public static bool LoadImmediate(RequestCompleteHandler handler, string path, [Optional] Type systemTypeInstance)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0xAFEA80", Offset = "0xAFDC80", VA = "0x180AFEA80")]
	public static bool LoadImmediate(RequestCompleteHandler handler, string path, bool disableErrorNotify, [Optional] Type systemTypeInstance)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0xAFE9A0", Offset = "0xAFDBA0", VA = "0x180AFE9A0")]
	public static bool LoadImmediate(string path, out uint crc, [Optional] Type systemTypeInstance, bool disableErrorNotify = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0xB006E0", Offset = "0xAFF8E0", VA = "0x180B006E0")]
	public static void Unload(string path, bool force = false)
	{
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0xB00630", Offset = "0xAFF830", VA = "0x180B00630")]
	public static void Unload(uint crc, bool force = false)
	{
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0xAFD000", Offset = "0xAFC200", VA = "0x180AFD000")]
	public static void AddUnloadWaitCnt(int addCnt = 1)
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0xAFE700", Offset = "0xAFD900", VA = "0x180AFE700")]
	public static bool IsNeedUnloadResources(UnloadCheckLevel unloadLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0xAFD770", Offset = "0xAFC970", VA = "0x180AFD770")]
	public static bool CheckUnloadResourcesAsync(UnloadCheckLevel unloadLevel, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0xAFD6F0", Offset = "0xAFC8F0", VA = "0x180AFD6F0")]
	[IteratorStateMachine(typeof(_003CCheckUnloadResourcesAsyncRoutine_003Ed__82))]
	public static IEnumerator CheckUnloadResourcesAsyncRoutine(UnloadCheckLevel unloadLevel, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0xB00570", Offset = "0xAFF770", VA = "0x180B00570")]
	public static void UnloadResourcesAsync([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0xB00500", Offset = "0xAFF700", VA = "0x180B00500")]
	[IteratorStateMachine(typeof(_003CUnloadResourcesAsyncRoutine_003Ed__84))]
	public static IEnumerator UnloadResourcesAsyncRoutine([Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0xAFE400", Offset = "0xAFD600", VA = "0x180AFE400")]
	public static bool IsDone(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0xAFE4D0", Offset = "0xAFD6D0", VA = "0x180AFE4D0")]
	public static bool IsDone(uint crc)
	{
		return default(bool);
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0xAFE580", Offset = "0xAFD780", VA = "0x180AFE580")]
	public static bool IsError(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0xAFE650", Offset = "0xAFD850", VA = "0x180AFE650")]
	public static bool IsError(uint crc)
	{
		return default(bool);
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0xAFE850", Offset = "0xAFDA50", VA = "0x180AFE850")]
	public static bool IsRequested(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0xAFE7B0", Offset = "0xAFD9B0", VA = "0x180AFE7B0")]
	public static bool IsRequested(uint crc)
	{
		return default(bool);
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0xAFDF90", Offset = "0xAFD190", VA = "0x180AFDF90")]
	public static UnityEngine.Object GetAsset(string path, [Optional] Type getSystemType)
	{
		return null;
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0xAFE050", Offset = "0xAFD250", VA = "0x180AFE050")]
	public static byte[] GetBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x60008F4")]
	public static List<T> GetAssets<T>(string path)
	{
		return null;
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0xB002D0", Offset = "0xAFF4D0", VA = "0x180B002D0")]
	public static void SetErrorHandler(ErrorHandler handler)
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0xB00410", Offset = "0xAFF610", VA = "0x180B00410")]
	public static void SetRetryHandler(RetryHandler handler)
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0xB00370", Offset = "0xAFF570", VA = "0x180B00370")]
	public static void SetProgressHandler(ProgressHandler handler)
	{
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0xAFD860", Offset = "0xAFCA60", VA = "0x180AFD860")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0xB00240", Offset = "0xAFF440", VA = "0x180B00240")]
	public static void ResetRequest()
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0xAFE2C0", Offset = "0xAFD4C0", VA = "0x180AFE2C0")]
	public static bool IsAsyncLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0xAFDD30", Offset = "0xAFCF30", VA = "0x180AFDD30")]
	public static bool Exists(string filename)
	{
		return default(bool);
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0xAFD910", Offset = "0xAFCB10", VA = "0x180AFD910")]
	public static byte[] Decompress(byte[] compressData)
	{
		return null;
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0xB00120", Offset = "0xAFF320", VA = "0x180B00120")]
	private string RemoveAutoConvertPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0xAFD910", Offset = "0xAFCB10", VA = "0x180AFD910")]
	private static byte[] decompressedData(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0xB02900", Offset = "0xB01B00", VA = "0x180B02900")]
	private Texture2D spriteToTexture2D(Sprite spr)
	{
		return null;
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0xB02970", Offset = "0xB01B70", VA = "0x180B02970")]
	private Sprite texture2DToSprite(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0xB00D20", Offset = "0xAFFF20", VA = "0x180B00D20")]
	private void finishLoadAsset(uint key, Resource res)
	{
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0xAFEE80", Offset = "0xAFE080", VA = "0x180AFEE80")]
	[IteratorStateMachine(typeof(_003CRebuildMaterialsAsync_003Ed__109))]
	private IEnumerator RebuildMaterialsAsync(UnityEngine.Object[] assets, string path, Type systemTypeInstance)
	{
		return null;
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0xAFEF40", Offset = "0xAFE140", VA = "0x180AFEF40")]
	private void RebuildMaterialsImmediate(UnityEngine.Object[] assets, string path, Type systemTypeInstance)
	{
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0xAFFA70", Offset = "0xAFEC70", VA = "0x180AFFA70")]
	private bool RebuildMaterials_Prepare(UnityEngine.Object[] assets, string path, Type systemTypeInstance, out byte[] matInfoBytes, out Dictionary<string, Material> mtrls, out Dictionary<string, Texture> texs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0xAFFFE0", Offset = "0xAFF1E0", VA = "0x180AFFFE0")]
	private void RebuildMaterials_UnpackInfo(byte[] matInfoBytes, out Dictionary<string, object> matInfo)
	{
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0xAFF1A0", Offset = "0xAFE3A0", VA = "0x180AFF1A0")]
	private void RebuildMaterials_ApplyToMaterial(object matInfoValue, Material mtrl, Dictionary<string, Texture> texs)
	{
	}

	[Token(Token = "0x6000907")]
	[Address(RVA = "0xB00980", Offset = "0xAFFB80", VA = "0x180B00980")]
	public ResourceManager()
	{
	}
}
