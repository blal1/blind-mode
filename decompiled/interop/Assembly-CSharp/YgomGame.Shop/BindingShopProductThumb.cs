using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;

namespace YgomGame.Shop;

[Token(Token = "0x20009C1")]
public class BindingShopProductThumb : BindingAsyncBase
{
	[Token(Token = "0x20009C2")]
	public enum ThumbType
	{
		[Token(Token = "0x4008DA1")]
		CardIllust = 1,
		[Token(Token = "0x4008DA2")]
		Image,
		[Token(Token = "0x4008DA3")]
		Prefab
	}

	[Serializable]
	[Token(Token = "0x20009C3")]
	public class Context
	{
		[Token(Token = "0x4008DA4")]
		[FieldOffset(Offset = "0x10")]
		public ThumbType thumbType;

		[Token(Token = "0x4008DA5")]
		[FieldOffset(Offset = "0x14")]
		public ShopCardThumbSettings.Format format;

		[Token(Token = "0x4008DA6")]
		[FieldOffset(Offset = "0x18")]
		public int mrk;

		[Token(Token = "0x4008DA7")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x4008DA8")]
		[FieldOffset(Offset = "0x28")]
		public bool enabledAspectRatio;

		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x811140", Offset = "0x810340", VA = "0x180811140")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x810FE0", Offset = "0x8101E0", VA = "0x180810FE0")]
		public void ImportWork(int thumbType, string thumbData)
		{
		}

		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x8110D0", Offset = "0x8102D0", VA = "0x1808110D0")]
		public bool IsEqualParams(Context other)
		{
			return default(bool);
		}

		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x811080", Offset = "0x810280", VA = "0x180811080")]
		public void Import(Context other)
		{
		}

		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x811180", Offset = "0x810380", VA = "0x180811180")]
		public Context()
		{
		}
	}

	[Token(Token = "0x20009C4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x4008DA9")]
		[FieldOffset(Offset = "0x10")]
		public BindingShopProductThumb _003C_003E4__this;

		[Token(Token = "0x4008DAA")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D reqTex;

		[Token(Token = "0x4008DAB")]
		[FieldOffset(Offset = "0x20")]
		public bool progressBlock;

		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x8428E0", Offset = "0x841AE0", VA = "0x1808428E0")]
		internal void _003CyBindingCardIllustRoutine_003Eb__0(Texture2D tex)
		{
		}
	}

	[Token(Token = "0x20009C5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x4008DAC")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D reqTex;

		[Token(Token = "0x4008DAD")]
		[FieldOffset(Offset = "0x18")]
		public BindingShopProductThumb _003C_003E4__this;

		[Token(Token = "0x4008DAE")]
		[FieldOffset(Offset = "0x20")]
		public bool progressBlock;

		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x842980", Offset = "0x841B80", VA = "0x180842980")]
		internal void _003CyBindingImageRoutine_003Eb__0(string loadedPath)
		{
		}
	}

	[Token(Token = "0x20009C7")]
	[CompilerGenerated]
	private sealed class _003CyBindingCardIllustRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008DB2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008DB3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008DB4")]
		[FieldOffset(Offset = "0x20")]
		public BindingShopProductThumb _003C_003E4__this;

		[Token(Token = "0x4008DB5")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		[Token(Token = "0x170007E0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BA6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BA8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingCardIllustRoutine_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x842E60", Offset = "0x842060", VA = "0x180842E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x843280", Offset = "0x842480", VA = "0x180843280", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20009C8")]
	[CompilerGenerated]
	private sealed class _003CyBindingImageRoutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008DB6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008DB7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008DB8")]
		[FieldOffset(Offset = "0x20")]
		public BindingShopProductThumb _003C_003E4__this;

		[Token(Token = "0x4008DB9")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		[Token(Token = "0x4008DBA")]
		[FieldOffset(Offset = "0x30")]
		private string _003Cpath_003E5__2;

		[Token(Token = "0x170007E2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BAC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BAE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingImageRoutine_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x8432C0", Offset = "0x8424C0", VA = "0x1808432C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x843A10", Offset = "0x842C10", VA = "0x180843A10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20009C9")]
	[CompilerGenerated]
	private sealed class _003CyBindingPrefabRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008DBB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008DBC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008DBD")]
		[FieldOffset(Offset = "0x20")]
		public BindingShopProductThumb _003C_003E4__this;

		[Token(Token = "0x4008DBE")]
		[FieldOffset(Offset = "0x28")]
		private BindingGameObjectEx _003CbindingGob_003E5__2;

		[Token(Token = "0x170007E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BB2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BB4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingPrefabRoutine_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x843A50", Offset = "0x842C50", VA = "0x180843A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x844120", Offset = "0x843320", VA = "0x180844120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20009CA")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008DBF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008DC0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008DC1")]
		[FieldOffset(Offset = "0x20")]
		public BindingShopProductThumb _003C_003E4__this;

		[Token(Token = "0x4008DC2")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CtargetBindingRoutine_003E5__2;

		[Token(Token = "0x170007E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003BB8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003BBA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x844160", Offset = "0x843360", VA = "0x180844160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x844390", Offset = "0x843590", VA = "0x180844390", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008D8F")]
	internal const string k_JLabel_WallpaperAsImg = "wallpaper_as_img";

	[Token(Token = "0x4008D90")]
	internal const string k_JLabel_WallpaperStopAnimation = "wallpaper_stop_anim";

	[Token(Token = "0x4008D91")]
	internal const string k_JLabel_MaskImageRef = "mask_img";

	[Token(Token = "0x4008D92")]
	[FieldOffset(Offset = "0x30")]
	private ShopCardThumbSettings m_ShopCardThumbSettings;

	[Token(Token = "0x4008D93")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_RectMask;

	[Token(Token = "0x4008D94")]
	[FieldOffset(Offset = "0x40")]
	private AspectRatioFitter m_RectAspectRatioFitter;

	[Token(Token = "0x4008D95")]
	[FieldOffset(Offset = "0x48")]
	private RawImage m_RawImage;

	[Token(Token = "0x4008D96")]
	[FieldOffset(Offset = "0x50")]
	private Texture m_RawImageTex;

	[Token(Token = "0x4008D97")]
	[FieldOffset(Offset = "0x58")]
	private Rect m_RawImageUV;

	[Token(Token = "0x4008D98")]
	[FieldOffset(Offset = "0x68")]
	private AspectRatioFitter m_ImageAspectRatioFitter;

	[Token(Token = "0x4008D99")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_BindedObject;

	[Token(Token = "0x4008D9A")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<string, object> m_ModifyArgs;

	[Token(Token = "0x4008D9B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Context m_Context;

	[Token(Token = "0x4008D9C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private string m_PathSfx;

	[Token(Token = "0x4008D9D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private string m_SwitchGroupLabel;

	[Token(Token = "0x4008D9E")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsInitialized;

	[Token(Token = "0x4008D9F")]
	[FieldOffset(Offset = "0xA0")]
	private string m_CachedResourcePath;

	[Token(Token = "0x170007DB")]
	public Context context
	{
		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DC")]
	public Dictionary<string, object> modifyArgs
	{
		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		set
		{
		}
	}

	[Token(Token = "0x170007DD")]
	public string pathSfx
	{
		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		set
		{
		}
	}

	[Token(Token = "0x170007DE")]
	public string switchGroupLabel
	{
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		set
		{
		}
	}

	[Token(Token = "0x170007DF")]
	public bool enabledAspectRatio
	{
		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x80C510", Offset = "0x80B710", VA = "0x18080C510")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x80C530", Offset = "0x80B730", VA = "0x18080C530")]
		set
		{
		}
	}

	[Token(Token = "0x6003B87")]
	[Address(RVA = "0x80BDB0", Offset = "0x80AFB0", VA = "0x18080BDB0")]
	private bool IsUseRawImage(ThumbType thumbType)
	{
		return default(bool);
	}

	[Token(Token = "0x6003B88")]
	[Address(RVA = "0x80B1A0", Offset = "0x80A3A0", VA = "0x18080B1A0")]
	public static BindingShopProductThumb Attach(RectTransform root)
	{
		return null;
	}

	[Token(Token = "0x6003B89")]
	[Address(RVA = "0x80B290", Offset = "0x80A490", VA = "0x18080B290")]
	public static BindingShopProductThumb Binding(RectTransform root, Context context)
	{
		return null;
	}

	[Token(Token = "0x6003B8A")]
	[Address(RVA = "0x80B270", Offset = "0x80A470", VA = "0x18080B270")]
	public void Binding()
	{
	}

	[Token(Token = "0x6003B8B")]
	[Address(RVA = "0x80C6A0", Offset = "0x80B8A0", VA = "0x18080C6A0", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__37))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003B8C")]
	[Address(RVA = "0x80B660", Offset = "0x80A860", VA = "0x18080B660")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6003B8D")]
	[Address(RVA = "0x80C550", Offset = "0x80B750", VA = "0x18080C550")]
	[IteratorStateMachine(typeof(_003CyBindingCardIllustRoutine_003Ed__39))]
	private IEnumerator yBindingCardIllustRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003B8E")]
	[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", VA = "0x18080C5C0")]
	[IteratorStateMachine(typeof(_003CyBindingImageRoutine_003Ed__40))]
	private IEnumerator yBindingImageRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003B8F")]
	[Address(RVA = "0x80C630", Offset = "0x80B830", VA = "0x18080C630")]
	[IteratorStateMachine(typeof(_003CyBindingPrefabRoutine_003Ed__41))]
	private IEnumerator yBindingPrefabRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003B90")]
	[Address(RVA = "0x80BDC0", Offset = "0x80AFC0", VA = "0x18080BDC0", Slot = "15")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003B91")]
	[Address(RVA = "0x80C080", Offset = "0x80B280", VA = "0x18080C080")]
	private void RefreshVisible(bool ready)
	{
	}

	[Token(Token = "0x6003B92")]
	[Address(RVA = "0x80C2E0", Offset = "0x80B4E0", VA = "0x18080C2E0")]
	private void SetResourcePathCache(string resourcePath)
	{
	}

	[Token(Token = "0x6003B93")]
	[Address(RVA = "0x80C290", Offset = "0x80B490", VA = "0x18080C290")]
	private void ReleaseResoucePathCache()
	{
	}

	[Token(Token = "0x6003B94")]
	[Address(RVA = "0x80BE40", Offset = "0x80B040", VA = "0x18080BE40", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6003B95")]
	[Address(RVA = "0x80B3C0", Offset = "0x80A5C0", VA = "0x18080B3C0")]
	public void CaptureTo(BindingShopProductThumb target)
	{
	}

	[Token(Token = "0x6003B96")]
	[Address(RVA = "0x80C3F0", Offset = "0x80B5F0", VA = "0x18080C3F0")]
	public BindingShopProductThumb()
	{
	}
}
