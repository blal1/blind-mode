using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200060C")]
[RequireComponent(typeof(ElementObjectManager))]
public class ElementEntityFactory : MonoBehaviour
{
	[Token(Token = "0x4001D0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_ELabelTemplate;

	[Token(Token = "0x4001D0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string[] m_ELabelAdditionalTemplates;

	[Token(Token = "0x4001D10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform m_WidgetRoot;

	[Token(Token = "0x4001D11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_UseTemplateRoot;

	[Token(Token = "0x4001D12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<GameObject> m_Templates;

	[Token(Token = "0x4001D13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<GameObject, int> m_EntityToDataIndexTable;

	[Token(Token = "0x4001D14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<int, GameObject> m_DataIndexToEntityTable;

	[Token(Token = "0x4001D15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Stack<GameObject>> m_FreeEntityStack;

	[Token(Token = "0x4001D16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<GameObject> m_ActiveEntityList;

	[Token(Token = "0x4001D17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int m_DataCount;

	[Token(Token = "0x4001D18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<int> m_TemplateIdxList;

	[Token(Token = "0x4001D19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Action<GameObject, int> onCreatedEntityCallback;

	[Token(Token = "0x4001D1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Action<GameObject> onActivateEntityCallback;

	[Token(Token = "0x4001D1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action<GameObject, int> onUpdateEntityCallback;

	[Token(Token = "0x4001D1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Action<GameObject> onDeactivateEntityCallback;

	[Token(Token = "0x170004D4")]
	public Transform widgetRoot
	{
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D5")]
	public int dataCount
	{
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0x6A88E0", Offset = "0x6A7AE0", VA = "0x1806A88E0")]
	public GameObject GetEntityByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x6A8870", Offset = "0x6A7A70", VA = "0x1806A8870")]
	public int GetDataIndexByEntity(GameObject entity)
	{
		return default(int);
	}

	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x6A8950", Offset = "0x6A7B50", VA = "0x1806A8950")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x6A8E70", Offset = "0x6A8070", VA = "0x1806A8E70")]
	public void UpdateDataCount(int dataCount, [Optional] List<int> templateIdxList)
	{
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x6A90D0", Offset = "0x6A82D0", VA = "0x1806A90D0")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x6A8720", Offset = "0x6A7920", VA = "0x1806A8720")]
	private GameObject CreateItem(int templateIdx)
	{
		return null;
	}

	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x6A83B0", Offset = "0x6A75B0", VA = "0x1806A83B0")]
	private GameObject AddItem(int templateIdx, int dataIndex)
	{
		return null;
	}

	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x6A8C60", Offset = "0x6A7E60", VA = "0x1806A8C60")]
	private void RemoveItem(int dataIndex)
	{
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0x6A9170", Offset = "0x6A8370", VA = "0x1806A9170")]
	public ElementEntityFactory()
	{
	}
}
