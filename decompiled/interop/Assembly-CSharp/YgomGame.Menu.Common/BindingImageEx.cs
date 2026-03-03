using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001433")]
public class BindingImageEx : BindingImage, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x400C59F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AspectRatioFitter.AspectMode m_AspectMode;

	[Token(Token = "0x1700133C")]
	public AspectRatioFitter.AspectMode aspectMode
	{
		[Token(Token = "0x6007D94")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		get
		{
			return default(AspectRatioFitter.AspectMode);
		}
		[Token(Token = "0x6007D95")]
		[Address(RVA = "0xC5D780", Offset = "0xC5C980", VA = "0x180C5D780")]
		set
		{
		}
	}

	[Token(Token = "0x1700133D")]
	public bool visible
	{
		[Token(Token = "0x6007D96")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400009C")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007D97")]
		[Address(RVA = "0xC5D640", Offset = "0xC5C840", VA = "0x180C5D640", Slot = "11")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007D98")]
		[Address(RVA = "0xC5D6E0", Offset = "0xC5C8E0", VA = "0x180C5D6E0", Slot = "12")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007D99")]
	[Address(RVA = "0xC5D310", Offset = "0xC5C510", VA = "0x180C5D310")]
	public static BindingImageEx Binding(GameObject target, string spritePath, string materialPath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D9A")]
	[Address(RVA = "0xC5D320", Offset = "0xC5C520", VA = "0x180C5D320")]
	public static BindingImageEx Binding(GameObject target, string spritePath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D9B")]
	[Address(RVA = "0xC5D350", Offset = "0xC5C550", VA = "0x180C5D350")]
	public static BindingImageEx Binding(Image target, string spritePath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D9C")]
	[Address(RVA = "0xC5D350", Offset = "0xC5C550", VA = "0x180C5D350")]
	public static BindingImageEx Binding(RawImage target, string spritePath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D9D")]
	[Address(RVA = "0xC5D190", Offset = "0xC5C390", VA = "0x180C5D190")]
	public static void BindingImageOrPrefab(Image target, string path, bool async = true, AspectRatioFitter.AspectMode imageAspectMode = AspectRatioFitter.AspectMode.None, BindingGameObjectEx.FitMode prefabFitMode = BindingGameObjectEx.FitMode.SCALE_FIT_HIGHEST, bool tryUseAssetSize = true, float overrideWidth = 0f, float overrideHeight = 0f, [Optional] Action<GameObject> onComplete, [Optional] Action handleOnFailedCallback)
	{
	}

	[Token(Token = "0x6007D9E")]
	[Address(RVA = "0xC5D3B0", Offset = "0xC5C5B0", VA = "0x180C5D3B0")]
	private static BindingImageEx InnerBinding(GameObject target, string spritePath, string materialPath, bool async = true, AspectRatioFitter.AspectMode aspectMode = AspectRatioFitter.AspectMode.None)
	{
		return null;
	}

	[Token(Token = "0x6007D9F")]
	[Address(RVA = "0xC5D5B0", Offset = "0xC5C7B0", VA = "0x180C5D5B0", Slot = "10")]
	private bool YgomSystem_002EUI_002EILoadingIconHandler_002EIsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DA0")]
	[Address(RVA = "0xC5D5B0", Offset = "0xC5C7B0", VA = "0x180C5D5B0", Slot = "7")]
	private bool YgomGame_002EMenu_002ECommon_002EIAsyncProgressContent_002EIsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DA1")]
	[Address(RVA = "0xC5D490", Offset = "0xC5C690", VA = "0x180C5D490")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DA2")]
	[Address(RVA = "0xC5D580", Offset = "0xC5C780", VA = "0x180C5D580", Slot = "8")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007DA3")]
	[Address(RVA = "0xC5D500", Offset = "0xC5C700", VA = "0x180C5D500", Slot = "5")]
	public override bool OnBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6007DA4")]
	[Address(RVA = "0xC5D540", Offset = "0xC5C740", VA = "0x180C5D540", Slot = "4")]
	public override void OnRebind()
	{
	}

	[Token(Token = "0x6007DA5")]
	[Address(RVA = "0xC5CFB0", Offset = "0xC5C1B0", VA = "0x180C5CFB0")]
	private void ApplyAspectRatio()
	{
	}

	[Token(Token = "0x6007DA6")]
	[Address(RVA = "0xC5D630", Offset = "0xC5C830", VA = "0x180C5D630")]
	public BindingImageEx()
	{
	}
}
