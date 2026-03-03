using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.ElementSystem;

[Token(Token = "0x20002FE")]
[DisallowMultipleComponent]
public class ElementObjectManager : MonoBehaviour
{
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x20")]
	public SortedDictionary<string, ElementObject> elements;

	[NonSerialized]
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x28")]
	public List<ElementObject> tempElements;

	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<string, int> labelCounter;

	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0x40")]
	public ElementObject[] serializedElements;

	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x48")]
	private bool applied;

	[Token(Token = "0x170001E1")]
	public bool error
	{
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x405C90", Offset = "0x404E90", VA = "0x180405C90")]
	private void Awake()
	{
	}

	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x406830", Offset = "0x405A30", VA = "0x180406830")]
	public void SetElement(ElementObject element)
	{
	}

	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x405A30", Offset = "0x404C30", VA = "0x180405A30")]
	private void ArrangementElements()
	{
	}

	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x406980", Offset = "0x405B80", VA = "0x180406980")]
	private void SetupChildrenElements()
	{
	}

	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x406B20", Offset = "0x405D20", VA = "0x180406B20")]
	private void SetupSerializedElements()
	{
	}

	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x4062E0", Offset = "0x4054E0", VA = "0x1804062E0")]
	private void Reset()
	{
	}

	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x406A30", Offset = "0x405C30", VA = "0x180406A30")]
	public void SetupElements()
	{
	}

	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x405870", Offset = "0x404A70", VA = "0x180405870")]
	public void ApplySerializedElements()
	{
	}

	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x405CA0", Offset = "0x404EA0", VA = "0x180405CA0")]
	private void CheckSameLabel()
	{
	}

	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x406030", Offset = "0x405230", VA = "0x180406030")]
	public int GetElementsCount()
	{
		return default(int);
	}

	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x406280", Offset = "0x405480", VA = "0x180406280")]
	public bool IsExistsLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x406080", Offset = "0x405280", VA = "0x180406080")]
	public SortedDictionary<string, ElementObject>.KeyCollection GetLabels()
	{
		return null;
	}

	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x405F80", Offset = "0x405180", VA = "0x180405F80")]
	public GameObject GetElement(string label)
	{
		return null;
	}

	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x4060D0", Offset = "0x4052D0", VA = "0x1804060D0")]
	public GameObject GetNestedElement(string label)
	{
		return null;
	}

	[Token(Token = "0x60012DE")]
	public T GetElement<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60012DF")]
	public T GetNestedElement<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x406780", Offset = "0x405980", VA = "0x180406780")]
	public void SetCallback(string label, UnityAction callback)
	{
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x4068D0", Offset = "0x405AD0", VA = "0x1804068D0")]
	public void SetNestedCallback(string label, UnityAction callback)
	{
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x406570", Offset = "0x405770", VA = "0x180406570")]
	public void SetCallbackInt(string label, UnityAction<int> callback)
	{
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x4064C0", Offset = "0x4056C0", VA = "0x1804064C0")]
	public void SetCallbackFloat(string label, UnityAction<float> callback)
	{
	}

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x4066D0", Offset = "0x4058D0", VA = "0x1804066D0")]
	public void SetCallbackVector2(string label, UnityAction<Vector2> callback)
	{
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x406410", Offset = "0x405610", VA = "0x180406410")]
	public void SetCallbackBool(string label, UnityAction<bool> callback)
	{
	}

	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x406620", Offset = "0x405820", VA = "0x180406620")]
	public void SetCallbackString(string label, UnityAction<string> callback)
	{
	}

	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x406D60", Offset = "0x405F60", VA = "0x180406D60")]
	public ElementObjectManager()
	{
	}
}
