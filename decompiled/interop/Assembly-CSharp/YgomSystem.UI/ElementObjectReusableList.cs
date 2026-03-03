using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Token(Token = "0x2000457")]
[RequireComponent(typeof(ElementObjectManager))]
public class ElementObjectReusableList : MonoBehaviour
{
	[Token(Token = "0x2000458")]
	private class EntityInfo
	{
		[Token(Token = "0x4001544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string label;

		[Token(Token = "0x4001545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly GameObject entity;

		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public EntityInfo(string label, GameObject entity)
		{
		}
	}

	[Token(Token = "0x400153E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_EntityParent;

	[Token(Token = "0x400153F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_EomCache;

	[Token(Token = "0x4001540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<EntityInfo> m_EntityInfos;

	[Token(Token = "0x4001541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<EntityInfo> m_ReusableInfos;

	[Token(Token = "0x4001542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<GameObject, string> onCreateEntityCallback;

	[Token(Token = "0x4001543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<GameObject, int, string> onUpdateEntityCallback;

	[Token(Token = "0x170002B5")]
	private Transform entityParent
	{
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x5FF160", Offset = "0x5FE360", VA = "0x1805FF160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B6")]
	private ElementObjectManager eom
	{
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x5FF1B0", Offset = "0x5FE3B0", VA = "0x1805FF1B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C14")]
	[Address(RVA = "0x5FE4A0", Offset = "0x5FD6A0", VA = "0x1805FE4A0")]
	private string GetLabelByIdx(int dataIndex, [Optional] IReadOnlyList<string> templateLabels)
	{
		return null;
	}

	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x5FE2D0", Offset = "0x5FD4D0", VA = "0x1805FE2D0")]
	private EntityInfo FindReusable(string label)
	{
		return null;
	}

	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x5FE420", Offset = "0x5FD620", VA = "0x1805FE420")]
	public GameObject GetEntityByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x5FE6B0", Offset = "0x5FD8B0", VA = "0x1805FE6B0")]
	public void Initialize(params string[] templateLabels)
	{
	}

	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x5FDFB0", Offset = "0x5FD1B0", VA = "0x1805FDFB0")]
	private EntityInfo CreateEntity(string label)
	{
		return null;
	}

	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x5FE110", Offset = "0x5FD310", VA = "0x1805FE110")]
	private EntityInfo CreateOrReuseEntity(int dataIndex, string label)
	{
		return null;
	}

	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x5FE800", Offset = "0x5FDA00", VA = "0x1805FE800")]
	private void ReturnEntity(EntityInfo entityInfo)
	{
	}

	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x5FE9B0", Offset = "0x5FDBB0", VA = "0x1805FE9B0")]
	private EntityInfo SetupEntityAt(int dataIndex, string label)
	{
		return null;
	}

	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x5FECB0", Offset = "0x5FDEB0", VA = "0x1805FECB0")]
	public void UpdateDataCount(IReadOnlyList<string> templateLabels)
	{
	}

	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x5FEE70", Offset = "0x5FE070", VA = "0x1805FEE70")]
	public void UpdateDataCount(int dataCount, [Optional] IReadOnlyList<string> templateLabels)
	{
	}

	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x5FF000", Offset = "0x5FE200", VA = "0x1805FF000")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x5FF0B0", Offset = "0x5FE2B0", VA = "0x1805FF0B0")]
	public ElementObjectReusableList()
	{
	}
}
