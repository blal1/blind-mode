using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000518")]
public class BindingGameObject : MonoBehaviour
{
	[Token(Token = "0x40018EB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected string prefabPath;

	[Token(Token = "0x40018EC")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool IsDone;

	[Token(Token = "0x40018ED")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool immediate;

	[Token(Token = "0x40018EE")]
	[FieldOffset(Offset = "0x2A")]
	[SerializeField]
	public bool StartOnAwake;

	[NonSerialized]
	[Token(Token = "0x40018EF")]
	[FieldOffset(Offset = "0x2B")]
	public bool cacheResource;

	[Token(Token = "0x40018F0")]
	[FieldOffset(Offset = "0x2C")]
	protected bool IsSetParent;

	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x30")]
	protected string basePath;

	[Token(Token = "0x40018F2")]
	[FieldOffset(Offset = "0x38")]
	protected Dictionary<string, object> pathArgs;

	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x40")]
	private string m_CachedResourcePath;

	[Token(Token = "0x40018F4")]
	[FieldOffset(Offset = "0x48")]
	private Action<GameObject> onCreated;

	[Token(Token = "0x17000356")]
	public string PrefabPath
	{
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x631A40", Offset = "0x630C40", VA = "0x180631A40")]
		set
		{
		}
	}

	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x6316C0", Offset = "0x6308C0", VA = "0x1806316C0")]
	public void Rebind(bool force = false)
	{
	}

	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x6314C0", Offset = "0x6306C0", VA = "0x1806314C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x631670", Offset = "0x630870", VA = "0x180631670")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002100")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	protected void SetOnCreated(Action<GameObject> act)
	{
	}

	[Token(Token = "0x6002101")]
	[Address(RVA = "0x631700", Offset = "0x630900", VA = "0x180631700")]
	public void SetImmediate(bool immediate)
	{
	}

	[Token(Token = "0x6002102")]
	[Address(RVA = "0x6314F0", Offset = "0x6306F0", VA = "0x1806314F0")]
	public void LoadGameObject()
	{
	}

	[Token(Token = "0x6002103")]
	[Address(RVA = "0x631790", Offset = "0x630990", VA = "0x180631790")]
	protected void SplitPath()
	{
	}

	[Token(Token = "0x6002104")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	protected virtual void PostModifiyByArgs(GameObject go)
	{
	}

	[Token(Token = "0x6002105")]
	[Address(RVA = "0x631710", Offset = "0x630910", VA = "0x180631710")]
	private void SetResourcePathCache(string resourcePath)
	{
	}

	[Token(Token = "0x6002106")]
	[Address(RVA = "0x631670", Offset = "0x630870", VA = "0x180631670")]
	private void ReleaseResoucePathCache()
	{
	}

	[Token(Token = "0x6002107")]
	[Address(RVA = "0x631A30", Offset = "0x630C30", VA = "0x180631A30")]
	public BindingGameObject()
	{
	}
}
