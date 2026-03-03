using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BB3")]
public class BindingEventLogo : MonoBehaviour, IAsyncProgressContainer, ILoadingIconHandler
{
	[Token(Token = "0x2001BB4")]
	public enum PrefabType
	{
		[Token(Token = "0x400FAFC")]
		NONE,
		[Token(Token = "0x400FAFD")]
		TYPE,
		[Token(Token = "0x400FAFE")]
		ATTRIBUTE
	}

	[Serializable]
	[Token(Token = "0x2001BB5")]
	public class Context
	{
		[Token(Token = "0x400FAFF")]
		[FieldOffset(Offset = "0x10")]
		public PrefabType prefabType;

		[Token(Token = "0x400FB00")]
		[FieldOffset(Offset = "0x14")]
		public int logoId;

		[Token(Token = "0x400FB01")]
		[FieldOffset(Offset = "0x18")]
		public List<int> subIds;

		[Token(Token = "0x400FB02")]
		[FieldOffset(Offset = "0x20")]
		public bool isLarge;

		[Token(Token = "0x600B47A")]
		[Address(RVA = "0x4C3650", Offset = "0x4C2850", VA = "0x1804C3650")]
		public bool IsEqualSubIds(Context other)
		{
			return default(bool);
		}

		[Token(Token = "0x600B47B")]
		[Address(RVA = "0x4C3600", Offset = "0x4C2800", VA = "0x1804C3600")]
		public void Import(Context other)
		{
		}

		[Token(Token = "0x600B47C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Context()
		{
		}
	}

	[Token(Token = "0x400FAF4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Context eventLogoContext;

	[Token(Token = "0x400FAF5")]
	[FieldOffset(Offset = "0x28")]
	private bool onLoadStart;

	[Token(Token = "0x400FAF6")]
	[FieldOffset(Offset = "0x30")]
	private GameObject bindChild;

	[Token(Token = "0x400FAF7")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager bindEom;

	[Token(Token = "0x400FAF8")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Visible;

	[Token(Token = "0x400FAF9")]
	[FieldOffset(Offset = "0x48")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x17001BA8")]
	public Context EventLogoContext
	{
		[Token(Token = "0x600B465")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA9")]
	public bool visible
	{
		[Token(Token = "0x600B466")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B467")]
		[Address(RVA = "0x4B69C0", Offset = "0x4B5BC0", VA = "0x1804B69C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001BAA")]
	private IReadOnlyList<IAsyncProgressContent> YgomGame_002EMenu_002ECommon_002EIAsyncProgressContainer_002EasyncProgressContents
	{
		[Token(Token = "0x600B468")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000E1")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x600B469")]
		[Address(RVA = "0x4B6880", Offset = "0x4B5A80", VA = "0x1804B6880", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600B46A")]
		[Address(RVA = "0x4B6920", Offset = "0x4B5B20", VA = "0x1804B6920", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600B46B")]
	[Address(RVA = "0x4B5740", Offset = "0x4B4940", VA = "0x1804B5740")]
	public static BindingEventLogo Binding(GameObject target, Context context)
	{
		return null;
	}

	[Token(Token = "0x600B46C")]
	[Address(RVA = "0x4B5FB0", Offset = "0x4B51B0", VA = "0x1804B5FB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600B46D")]
	[Address(RVA = "0x4B67D0", Offset = "0x4B59D0", VA = "0x1804B67D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600B46E")]
	[Address(RVA = "0x4B65B0", Offset = "0x4B57B0", VA = "0x1804B65B0")]
	private void UpdateData(Context context)
	{
	}

	[Token(Token = "0x600B46F")]
	[Address(RVA = "0x4B5950", Offset = "0x4B4B50", VA = "0x1804B5950")]
	public void Load(bool isEqualPrefab, bool isEqualLogo, bool isEqualSubIds, bool isEqualIsLarge)
	{
	}

	[Token(Token = "0x600B470")]
	[Address(RVA = "0x4B5410", Offset = "0x4B4610", VA = "0x1804B5410")]
	private void BindEventLogoMonster(GameObject parent, Context context)
	{
	}

	[Token(Token = "0x600B471")]
	[Address(RVA = "0x4B5810", Offset = "0x4B4A10", VA = "0x1804B5810", Slot = "6")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600B472")]
	[Address(RVA = "0x4B5F10", Offset = "0x4B5110", VA = "0x1804B5F10")]
	private void RefreshVisible()
	{
	}

	[Token(Token = "0x600B473")]
	[Address(RVA = "0x4B57B0", Offset = "0x4B49B0", VA = "0x1804B57B0")]
	private void ClearProgressContents()
	{
	}

	[Token(Token = "0x600B474")]
	[Address(RVA = "0x4B52E0", Offset = "0x4B44E0", VA = "0x1804B52E0")]
	private void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x600B475")]
	[Address(RVA = "0x4B6810", Offset = "0x4B5A10", VA = "0x1804B6810")]
	public BindingEventLogo()
	{
	}
}
