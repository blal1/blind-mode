using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001484")]
public class MateCaptureCreator : MonoBehaviour
{
	[Token(Token = "0x2001485")]
	public class Request
	{
		[Token(Token = "0x400C6BB")]
		[FieldOffset(Offset = "0x10")]
		public GameObject owner;

		[Token(Token = "0x400C6BC")]
		[FieldOffset(Offset = "0x18")]
		public Action<RenderTexture> callback;

		[Token(Token = "0x6007F7B")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public Request(GameObject owner, Action<RenderTexture> callback)
		{
		}
	}

	[Token(Token = "0x2001486")]
	public class Cache
	{
		[Token(Token = "0x400C6BD")]
		[FieldOffset(Offset = "0x10")]
		public MateCaptureContext context;

		[Token(Token = "0x400C6BE")]
		[FieldOffset(Offset = "0x18")]
		public RenderTexture renderTexture;

		[Token(Token = "0x400C6BF")]
		[FieldOffset(Offset = "0x20")]
		public List<GameObject> referer;

		[Token(Token = "0x400C6C0")]
		[FieldOffset(Offset = "0x28")]
		public int renderTextureId;

		[Token(Token = "0x17001395")]
		public int refererCnt
		{
			[Token(Token = "0x6007F7C")]
			[Address(RVA = "0xC70AD0", Offset = "0xC6FCD0", VA = "0x180C70AD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6007F7D")]
		[Address(RVA = "0xC70A00", Offset = "0xC6FC00", VA = "0x180C70A00")]
		public Cache(MateCaptureContext context, RenderTexture renderTexture, int renderTextureId)
		{
		}

		[Token(Token = "0x6007F7E")]
		[Address(RVA = "0xC708A0", Offset = "0xC6FAA0", VA = "0x180C708A0")]
		public RenderTexture AssignRef(GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x6007F7F")]
		[Address(RVA = "0xC70960", Offset = "0xC6FB60", VA = "0x180C70960")]
		public void Release()
		{
		}
	}

	[Token(Token = "0x2001487")]
	public class CreateSequncer
	{
		[Token(Token = "0x2001488")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x400C6C7")]
			[FieldOffset(Offset = "0x10")]
			public CreateSequncer instance;

			[Token(Token = "0x400C6C8")]
			[FieldOffset(Offset = "0x18")]
			public MateTransformSetting setting;

			[Token(Token = "0x400C6C9")]
			[FieldOffset(Offset = "0x20")]
			public bool loadingSettingPath;

			[Token(Token = "0x400C6CA")]
			[FieldOffset(Offset = "0x28")]
			public GameObject matePrefab;

			[Token(Token = "0x400C6CB")]
			[FieldOffset(Offset = "0x30")]
			public bool initializedMate;

			[Token(Token = "0x400C6CC")]
			[FieldOffset(Offset = "0x38")]
			public CreateSequncer _003C_003E4__this;

			[Token(Token = "0x6007F88")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6007F89")]
			[Address(RVA = "0xC7EC10", Offset = "0xC7DE10", VA = "0x180C7EC10")]
			internal void _003CyProgress_003Eb__0(string path)
			{
			}

			[Token(Token = "0x6007F8A")]
			[Address(RVA = "0xC7ED10", Offset = "0xC7DF10", VA = "0x180C7ED10")]
			internal void _003CyProgress_003Eb__1(string path)
			{
			}

			[Token(Token = "0x6007F8B")]
			[Address(RVA = "0x439370", Offset = "0x438570", VA = "0x180439370")]
			internal void _003CyProgress_003Eb__2()
			{
			}

			[Token(Token = "0x6007F8C")]
			[Address(RVA = "0xC7EDF0", Offset = "0xC7DFF0", VA = "0x180C7EDF0")]
			internal void _003CyProgress_003Eb__3(int rtId, RenderTexture renderTexture, Texture2D texture)
			{
			}
		}

		[Token(Token = "0x2001489")]
		[CompilerGenerated]
		private sealed class _003CyProgress_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400C6CD")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400C6CE")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400C6CF")]
			[FieldOffset(Offset = "0x20")]
			public CreateSequncer _003C_003E4__this;

			[Token(Token = "0x400C6D0")]
			[FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

			[Token(Token = "0x17001398")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007F90")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001399")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007F92")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007F8D")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyProgress_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007F8E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007F8F")]
			[Address(RVA = "0xC83600", Offset = "0xC82800", VA = "0x180C83600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007F91")]
			[Address(RVA = "0xC83F90", Offset = "0xC83190", VA = "0x180C83F90", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400C6C1")]
		[FieldOffset(Offset = "0x10")]
		public MateCaptureContext context;

		[Token(Token = "0x400C6C2")]
		[FieldOffset(Offset = "0x18")]
		public List<Request> requests;

		[Token(Token = "0x400C6C3")]
		[FieldOffset(Offset = "0x20")]
		private int m_RenderTextureId;

		[Token(Token = "0x400C6C4")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_RenderTexture;

		[Token(Token = "0x400C6C5")]
		[FieldOffset(Offset = "0x30")]
		private IEnumerator m_ProgressSeq;

		[Token(Token = "0x400C6C6")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_MateLocator;

		[Token(Token = "0x17001396")]
		public RenderTexture renderTexture
		{
			[Token(Token = "0x6007F80")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001397")]
		public int renderTextureId
		{
			[Token(Token = "0x6007F81")]
			[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6007F82")]
		[Address(RVA = "0xC73C60", Offset = "0xC72E60", VA = "0x180C73C60")]
		public void Start()
		{
		}

		[Token(Token = "0x6007F83")]
		[Address(RVA = "0xC73A70", Offset = "0xC72C70", VA = "0x180C73A70")]
		public bool Progress()
		{
			return default(bool);
		}

		[Token(Token = "0x6007F84")]
		[Address(RVA = "0xC73D60", Offset = "0xC72F60", VA = "0x180C73D60")]
		[IteratorStateMachine(typeof(_003CyProgress_003Ed__12))]
		private IEnumerator yProgress()
		{
			return null;
		}

		[Token(Token = "0x6007F85")]
		[Address(RVA = "0xC73A60", Offset = "0xC72C60", VA = "0x180C73A60")]
		public void Abort()
		{
		}

		[Token(Token = "0x6007F86")]
		[Address(RVA = "0xC73AC0", Offset = "0xC72CC0", VA = "0x180C73AC0")]
		public void Release(bool isRenderTexture = true)
		{
		}

		[Token(Token = "0x6007F87")]
		[Address(RVA = "0xC73CE0", Offset = "0xC72EE0", VA = "0x180C73CE0")]
		public CreateSequncer()
		{
		}
	}

	[Token(Token = "0x400C6B7")]
	[FieldOffset(Offset = "0x0")]
	private static MateCaptureCreator s_InstanceCache;

	[Token(Token = "0x400C6B8")]
	[FieldOffset(Offset = "0x20")]
	private List<CreateSequncer> m_Sequencers;

	[Token(Token = "0x400C6B9")]
	[FieldOffset(Offset = "0x28")]
	private List<CreateSequncer> m_CompletedSequencers;

	[Token(Token = "0x400C6BA")]
	[FieldOffset(Offset = "0x30")]
	private List<Cache> m_Caches;

	[Token(Token = "0x17001394")]
	private static MateCaptureCreator s_Instance
	{
		[Token(Token = "0x6007F76")]
		[Address(RVA = "0xC77920", Offset = "0xC76B20", VA = "0x180C77920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007F77")]
	[Address(RVA = "0xC76830", Offset = "0xC75A30", VA = "0x180C76830")]
	public static void GetMateCapture(GameObject owner, MateCaptureContext context, Action<RenderTexture> callback)
	{
	}

	[Token(Token = "0x6007F78")]
	[Address(RVA = "0xC76D40", Offset = "0xC75F40", VA = "0x180C76D40")]
	public static void RereaseMateCapture(GameObject owner)
	{
	}

	[Token(Token = "0x6007F79")]
	[Address(RVA = "0xC772F0", Offset = "0xC764F0", VA = "0x180C772F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6007F7A")]
	[Address(RVA = "0xC77830", Offset = "0xC76A30", VA = "0x180C77830")]
	public MateCaptureCreator()
	{
	}
}
