using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Certification;

[Token(Token = "0x200151D")]
public class CertificationDebugQuizSetting : ScriptableObject
{
	[Token(Token = "0x400CB34")]
	private const string debugQuizSettingPath = "Debug/Certification/CertificationDebugQuizSetting";

	[Token(Token = "0x400CB35")]
	[FieldOffset(Offset = "0x0")]
	public static CertificationDebugQuizSetting setting;

	[Token(Token = "0x400CB36")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<LvInfo> m_infoList;

	[Token(Token = "0x170013EC")]
	public List<LvInfo> QuizDebugDatas
	{
		[Token(Token = "0x60082A1")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60082A2")]
	[Address(RVA = "0xCBCFF0", Offset = "0xCBC1F0", VA = "0x180CBCFF0")]
	public static void Load(Action<CertificationDebugQuizSetting> onFinish)
	{
	}

	[Token(Token = "0x60082A3")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public CertificationDebugQuizSetting()
	{
	}
}
