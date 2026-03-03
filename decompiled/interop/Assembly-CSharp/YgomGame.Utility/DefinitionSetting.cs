using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x20008F3")]
[CreateAssetMenu(menuName = "Scriptable Object/DefinitonSetting")]
public class DefinitionSetting : ScriptableObject
{
	[Token(Token = "0x20008F4")]
	public enum ValueType
	{
		[Token(Token = "0x40088EB")]
		Int,
		[Token(Token = "0x40088EC")]
		Float,
		[Token(Token = "0x40088ED")]
		Vector2,
		[Token(Token = "0x40088EE")]
		Vector3,
		[Token(Token = "0x40088EF")]
		Quaternion,
		[Token(Token = "0x40088F0")]
		String,
		[Token(Token = "0x40088F1")]
		Color,
		[Token(Token = "0x40088F2")]
		Bool,
		[Token(Token = "0x40088F3")]
		IntList,
		[Token(Token = "0x40088F4")]
		FloatList,
		[Token(Token = "0x40088F5")]
		AnimationCurve
	}

	[Serializable]
	[Token(Token = "0x20008F5")]
	public class ValueContainer
	{
		[Token(Token = "0x40088F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x40088F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<float> floatValues;

		[Token(Token = "0x40088F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string stringValue;

		[Token(Token = "0x40088F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ValueType valueType;

		[Token(Token = "0x40088FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve animationCurve;

		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x7CE440", Offset = "0x7CD640", VA = "0x1807CE440")]
		public ValueContainer Copy()
		{
			return null;
		}

		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x7CE620", Offset = "0x7CD820", VA = "0x1807CE620")]
		public ValueContainer()
		{
		}
	}

	[Token(Token = "0x40088E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ValueContainer> list;

	[Token(Token = "0x60035A1")]
	[Address(RVA = "0x7BAE40", Offset = "0x7BA040", VA = "0x1807BAE40")]
	public IEnumerable<string> SelectLabels()
	{
		return null;
	}

	[Token(Token = "0x60035A2")]
	[Address(RVA = "0x7BAAD0", Offset = "0x7B9CD0", VA = "0x1807BAAD0")]
	public ValueContainer Get(string label, int index = 0)
	{
		return null;
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0x7BADA0", Offset = "0x7B9FA0", VA = "0x1807BADA0")]
	public bool Get(string label, out int res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A4")]
	[Address(RVA = "0x7BA930", Offset = "0x7B9B30", VA = "0x1807BA930")]
	public bool Get(string label, out float res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A5")]
	[Address(RVA = "0x7BA9D0", Offset = "0x7B9BD0", VA = "0x1807BA9D0")]
	public bool Get(string label, out Vector2 res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x7BA5F0", Offset = "0x7B97F0", VA = "0x1807BA5F0")]
	public bool Get(string label, out Vector3 res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A7")]
	[Address(RVA = "0x7BA380", Offset = "0x7B9580", VA = "0x1807BA380")]
	public bool Get(string label, out Quaternion res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A8")]
	[Address(RVA = "0x7BA590", Offset = "0x7B9790", VA = "0x1807BA590")]
	public bool Get(string label, out string res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A9")]
	[Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
	public bool Get(string label, out Color res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AA")]
	[Address(RVA = "0x7BA4F0", Offset = "0x7B96F0", VA = "0x1807BA4F0")]
	public bool Get(string label, out bool res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AB")]
	[Address(RVA = "0x7BAB90", Offset = "0x7B9D90", VA = "0x1807BAB90")]
	public bool Get(string label, out List<int> res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AC")]
	[Address(RVA = "0x7BA730", Offset = "0x7B9930", VA = "0x1807BA730")]
	public bool Get(string label, out List<float> res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AD")]
	[Address(RVA = "0x7BA2D0", Offset = "0x7B94D0", VA = "0x1807BA2D0")]
	public bool Get(string label, out AnimationCurve res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AE")]
	[Address(RVA = "0x7BA110", Offset = "0x7B9310", VA = "0x1807BA110")]
	public bool GetValue(string label, float time, out float res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AF")]
	[Address(RVA = "0x7B9970", Offset = "0x7B8B70", VA = "0x1807B9970")]
	public bool GetAsValueType(string label, out object res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035B0")]
	[Address(RVA = "0x7B9E50", Offset = "0x7B9050", VA = "0x1807B9E50")]
	public int GetOrDefault(string label, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60035B1")]
	[Address(RVA = "0x7B9EF0", Offset = "0x7B90F0", VA = "0x1807B9EF0")]
	public float GetOrDefault(string label, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60035B2")]
	[Address(RVA = "0x7B9C50", Offset = "0x7B8E50", VA = "0x1807B9C50")]
	public Vector2 GetOrDefault(string label, [Optional] Vector2 defaultValue)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60035B3")]
	[Address(RVA = "0x7B9F80", Offset = "0x7B9180", VA = "0x1807B9F80")]
	public Vector3 GetOrDefault(string label, [Optional] Vector3 defaultValue)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60035B4")]
	[Address(RVA = "0x7BA010", Offset = "0x7B9210", VA = "0x1807BA010")]
	public Quaternion GetOrDefault(string label, [Optional] Quaternion defaultValue)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60035B5")]
	[Address(RVA = "0x7B9D50", Offset = "0x7B8F50", VA = "0x1807B9D50")]
	public string GetOrDefault(string label, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x7B9DC0", Offset = "0x7B8FC0", VA = "0x1807B9DC0")]
	public Color GetOrDefault(string label, [Optional] Color defaultValue)
	{
		return default(Color);
	}

	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x7BA070", Offset = "0x7B9270", VA = "0x1807BA070")]
	public bool GetOrDefault(string label, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60035B8")]
	[Address(RVA = "0x7B9FE0", Offset = "0x7B91E0", VA = "0x1807B9FE0")]
	public List<int> GetOrDefault(string label, [Optional] List<int> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60035B9")]
	[Address(RVA = "0x7B9E20", Offset = "0x7B9020", VA = "0x1807B9E20")]
	public List<float> GetOrDefault(string label, [Optional] List<float> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60035BA")]
	[Address(RVA = "0x7B9C90", Offset = "0x7B8E90", VA = "0x1807B9C90")]
	public AnimationCurve GetOrDefault(string label, [Optional] AnimationCurve defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60035BB")]
	[Address(RVA = "0x7BAF60", Offset = "0x7BA160", VA = "0x1807BAF60")]
	public DefinitionSetting()
	{
	}
}
