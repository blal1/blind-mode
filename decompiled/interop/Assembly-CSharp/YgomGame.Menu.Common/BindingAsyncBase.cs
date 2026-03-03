using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001416")]
public abstract class BindingAsyncBase : MonoBehaviour, IBinding, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x400C504")]
	[FieldOffset(Offset = "0x20")]
	private IEnumerator m_BindingRoutine;

	[Token(Token = "0x17001317")]
	public bool visible
	{
		[Token(Token = "0x6007CD4")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000099")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007CD5")]
		[Address(RVA = "0xC559E0", Offset = "0xC54BE0", VA = "0x180C559E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007CD6")]
		[Address(RVA = "0xC55A80", Offset = "0xC54C80", VA = "0x180C55A80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007CD7")]
	[Address(RVA = "0xC557E0", Offset = "0xC549E0", VA = "0x180C557E0", Slot = "11")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CD8")]
	[Address(RVA = "0xC55750", Offset = "0xC54950", VA = "0x180C55750")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007CD9")]
	[Address(RVA = "0xC55970", Offset = "0xC54B70", VA = "0x180C55970", Slot = "7")]
	[ContextMenu("Call SourceChanged")]
	public void SourceChanged()
	{
	}

	[Token(Token = "0x6007CDA")]
	[Address(RVA = "0xC559D0", Offset = "0xC54BD0", VA = "0x180C559D0", Slot = "14")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6007CDB")]
	[Address(RVA = "0xC55820", Offset = "0xC54A20", VA = "0x180C55820", Slot = "9")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007CDC")]
	[Address(RVA = "0xC55810", Offset = "0xC54A10", VA = "0x180C55810", Slot = "15")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6007CDD")]
	[Address(RVA = "0xC558F0", Offset = "0xC54AF0", VA = "0x180C558F0", Slot = "6")]
	[ContextMenu("Call ReleaseResources")]
	public void ReleaseResources()
	{
	}

	[Token(Token = "0x6007CDE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	protected virtual void OnSourceChange()
	{
	}

	[Token(Token = "0x6007CDF")]
	protected abstract IEnumerator yBindingRoutine();

	[Token(Token = "0x6007CE0")]
	protected abstract void OnReleaseResources();

	[Token(Token = "0x6007CE1")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected BindingAsyncBase()
	{
	}
}
