using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Solo;

[Token(Token = "0x200087C")]
public class BindingSoloCardThumb : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x200087D")]
	private class Data
	{
		[Token(Token = "0x4008679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BindTargetType type;

		[Token(Token = "0x400867A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int id;

		[Token(Token = "0x400867B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int mrk;

		[Token(Token = "0x600337D")]
		[Address(RVA = "0x768960", Offset = "0x767B60", VA = "0x180768960")]
		public Data(BindTargetType type, int id, int mrk)
		{
		}
	}

	[Token(Token = "0x200087E")]
	public enum BindTargetType
	{
		[Token(Token = "0x400867D")]
		DEFAULT,
		[Token(Token = "0x400867E")]
		OTHER
	}

	[Token(Token = "0x4008672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RawImage m_CardTextureImage;

	[Token(Token = "0x4008673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AspectRatioFitter m_AspectRatioFitter;

	[Token(Token = "0x4008674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Data currentData;

	[Token(Token = "0x4008675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Data requestData;

	[Token(Token = "0x4008677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool m_Visible;

	[Token(Token = "0x1700065E")]
	public bool isReady
	{
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600336D")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700065F")]
	public bool visible
	{
		[Token(Token = "0x600336E")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600336F")]
		[Address(RVA = "0x416710", Offset = "0x415910", VA = "0x180416710")]
		set
		{
		}
	}

	[Token(Token = "0x14000039")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6003370")]
		[Address(RVA = "0x766DB0", Offset = "0x765FB0", VA = "0x180766DB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x766E50", Offset = "0x766050", VA = "0x180766E50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0x765E40", Offset = "0x765040", VA = "0x180765E40")]
	private static BindingSoloCardThumb Binding(RectTransform root, SoloCardThumbSettings.ThumbSetting thumbSetting, BindTargetType bindTargetType, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0x765E20", Offset = "0x765020", VA = "0x180765E20")]
	public static BindingSoloCardThumb Binding(RectTransform root, SoloCardThumbSettings.ThumbSetting thumbSetting, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x765E00", Offset = "0x765000", VA = "0x180765E00")]
	public static BindingSoloCardThumb BindingOther(RectTransform root, SoloCardThumbSettings.ThumbSetting thumbSetting, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003375")]
	[Address(RVA = "0x7660D0", Offset = "0x7652D0", VA = "0x1807660D0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6003376")]
	[Address(RVA = "0x766650", Offset = "0x765850", VA = "0x180766650")]
	private void InnerBinding(SoloCardThumbSettings.ThumbSetting thumbSetting, BindTargetType bindTargetType, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6003377")]
	[Address(RVA = "0x766D80", Offset = "0x765F80", VA = "0x180766D80")]
	public void OnReload()
	{
	}

	[Token(Token = "0x6003378")]
	[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6003379")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x600337A")]
	[Address(RVA = "0x766BB0", Offset = "0x765DB0", VA = "0x180766BB0")]
	private void OnLoadCardTextureComplete(BindTargetType bindTargetType, SoloCardThumbSettings.ThumbSetting thumbSetting, bool fitPendulumAspect = true)
	{
	}

	[Token(Token = "0x600337B")]
	[Address(RVA = "0x765F90", Offset = "0x765190", VA = "0x180765F90")]
	private string GetTexPath(BindTargetType bindTargetType, int id)
	{
		return null;
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0x766DA0", Offset = "0x765FA0", VA = "0x180766DA0")]
	public BindingSoloCardThumb()
	{
	}
}
