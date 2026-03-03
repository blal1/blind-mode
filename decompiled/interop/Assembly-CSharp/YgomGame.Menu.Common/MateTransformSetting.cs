using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200148A")]
public class MateTransformSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200148B")]
	public class Data
	{
		[Token(Token = "0x400C6D3")]
		[FieldOffset(Offset = "0x10")]
		public int mateId;

		[Token(Token = "0x400C6D4")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x400C6D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("eulerAngles")]
		public Vector3 rotation;

		[Token(Token = "0x400C6D6")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 scale;

		[Token(Token = "0x6007F99")]
		[Address(RVA = "0xC73F50", Offset = "0xC73150", VA = "0x180C73F50")]
		public Data()
		{
		}

		[Token(Token = "0x6007F9A")]
		[Address(RVA = "0xC74020", Offset = "0xC73220", VA = "0x180C74020")]
		public Data(int mateId, Vector3 position, Vector3 rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x6007F9B")]
		[Address(RVA = "0xC73DD0", Offset = "0xC72FD0", VA = "0x180C73DD0")]
		public void CopyTo(Data target)
		{
		}

		[Token(Token = "0x6007F9C")]
		[Address(RVA = "0xC73EC0", Offset = "0xC730C0", VA = "0x180C73EC0")]
		public void ImportTransform(Transform transform)
		{
		}

		[Token(Token = "0x6007F9D")]
		[Address(RVA = "0xC73E20", Offset = "0xC73020", VA = "0x180C73E20")]
		public void ExportLocate(Transform transform)
		{
		}
	}

	[Token(Token = "0x400C6D1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Data> m_Datas;

	[Token(Token = "0x400C6D2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<MateTransformSetting> m_Fallbacks;

	[Token(Token = "0x6007F93")]
	[Address(RVA = "0xC77A20", Offset = "0xC76C20", VA = "0x180C77A20")]
	public Data FindByMateId(int mateId)
	{
		return null;
	}

	[Token(Token = "0x6007F94")]
	[Address(RVA = "0xC78020", Offset = "0xC77220", VA = "0x180C78020")]
	public bool TryApplyTransform(int mateId, Transform target)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F95")]
	[Address(RVA = "0xC77E80", Offset = "0xC77080", VA = "0x180C77E80")]
	public void SubmitData(Data from)
	{
	}

	[Token(Token = "0x6007F96")]
	[Address(RVA = "0xC77DB0", Offset = "0xC76FB0", VA = "0x180C77DB0")]
	public void SetSetting(Data mateSetting)
	{
	}

	[Token(Token = "0x6007F97")]
	[Address(RVA = "0xC77C80", Offset = "0xC76E80", VA = "0x180C77C80")]
	public bool IsExistMateId(int mateId)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F98")]
	[Address(RVA = "0xC78150", Offset = "0xC77350", VA = "0x180C78150")]
	public MateTransformSetting()
	{
	}
}
