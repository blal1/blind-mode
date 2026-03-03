using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001428")]
public class BindingGameObjectEx : BindingGameObject, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x2001429")]
	public enum FitMode
	{
		[Token(Token = "0x400C56F")]
		NONE,
		[Token(Token = "0x400C570")]
		SIZE,
		[Token(Token = "0x400C571")]
		SCALE,
		[Token(Token = "0x400C572")]
		SCALE_FIT_LOWEST,
		[Token(Token = "0x400C573")]
		SCALE_FIT_HIGHEST,
		[Token(Token = "0x400C574")]
		SCALE_FIT_IN_PARENT,
		[Token(Token = "0x400C575")]
		SCALE_ENVELOPE_PARENT
	}

	[Token(Token = "0x400C56C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x1700132D")]
	public bool visible
	{
		[Token(Token = "0x6007D4A")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400009A")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007D4B")]
		[Address(RVA = "0xC5B9F0", Offset = "0xC5ABF0", VA = "0x180C5B9F0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007D4C")]
		[Address(RVA = "0xC5BA90", Offset = "0xC5AC90", VA = "0x180C5BA90", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007D4D")]
	[Address(RVA = "0xC5B400", Offset = "0xC5A600", VA = "0x180C5B400")]
	public static BindingGameObjectEx Binding(GameObject target, string prefabPath, bool fitParentSize = false, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D4E")]
	[Address(RVA = "0xC5B0D0", Offset = "0xC5A2D0", VA = "0x180C5B0D0")]
	public static BindingGameObjectEx Binding(GameObject target, string prefabPath, FitMode fitMode = FitMode.NONE, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D4F")]
	[Address(RVA = "0xC5A830", Offset = "0xC59A30", VA = "0x180C5A830")]
	private static BindingGameObjectEx BindingFitModeNone(GameObject target, string prefabPath, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D50")]
	[Address(RVA = "0xC5AFC0", Offset = "0xC5A1C0", VA = "0x180C5AFC0")]
	private static BindingGameObjectEx BindingFitModeSize(GameObject target, string prefabPath, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D51")]
	[Address(RVA = "0xC5AEA0", Offset = "0xC5A0A0", VA = "0x180C5AEA0")]
	private static BindingGameObjectEx BindingFitModeScale(GameObject target, string prefabPath, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D52")]
	[Address(RVA = "0xC5AD80", Offset = "0xC59F80", VA = "0x180C5AD80")]
	private static BindingGameObjectEx BindingFitModeScaleLowestOrHighest(GameObject target, string prefabPath, bool isHighest, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D53")]
	[Address(RVA = "0xC5AC60", Offset = "0xC59E60", VA = "0x180C5AC60")]
	private static BindingGameObjectEx BindingFitModeScaleByParent(GameObject target, string prefabPath, bool envelopeParent, bool async = true, bool rebind = true, [Optional] UnityAction<GameObject> onCreated, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6007D54")]
	[Address(RVA = "0xC5B550", Offset = "0xC5A750", VA = "0x180C5B550", Slot = "8")]
	public new bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007D55")]
	[Address(RVA = "0xC5B830", Offset = "0xC5AA30", VA = "0x180C5B830", Slot = "6")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007D56")]
	[Address(RVA = "0xC5B4F0", Offset = "0xC5A6F0", VA = "0x180C5B4F0")]
	protected void ClearProgressContent()
	{
	}

	[Token(Token = "0x6007D57")]
	[Address(RVA = "0xC5A750", Offset = "0xC59950", VA = "0x180C5A750")]
	protected void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x6007D58")]
	[Address(RVA = "0xC5B430", Offset = "0xC5A630", VA = "0x180C5B430")]
	public static Vector3 CalcFitScale(FitMode fitMode, Vector2 parentSize, Vector2 childSize)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6007D59")]
	[Address(RVA = "0xC5B6A0", Offset = "0xC5A8A0", VA = "0x180C5B6A0", Slot = "4")]
	protected override void PostModifiyByArgs(GameObject go)
	{
	}

	[Token(Token = "0x6007D5A")]
	[Address(RVA = "0xC5B9E0", Offset = "0xC5ABE0", VA = "0x180C5B9E0")]
	public BindingGameObjectEx()
	{
	}
}
