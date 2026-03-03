using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000240")]
public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
{
	[Token(Token = "0x2000241")]
	public struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x0")]
		private List<StylePropertyName>.Enumerator m_Enumerator;

		[Token(Token = "0x170002E1")]
		public StylePropertyName Current
		{
			[Token(Token = "0x6000FC2")]
			[Address(RVA = "0x2B2A450", Offset = "0x2B29650", VA = "0x182B2A450", Slot = "4")]
			get
			{
				return default(StylePropertyName);
			}
		}

		[Token(Token = "0x170002E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FC3")]
			[Address(RVA = "0x2B2A3C0", Offset = "0x2B295C0", VA = "0x182B2A3C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x2B2A430", Offset = "0x2B29630", VA = "0x182B2A430")]
		internal Enumerator(List<StylePropertyName>.Enumerator enumerator)
		{
		}

		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x2B2A380", Offset = "0x2B29580", VA = "0x182B2A380", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x2B2A340", Offset = "0x2B29540", VA = "0x182B2A340", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x0")]
	internal List<StylePropertyName> propertiesList;

	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
	internal StylePropertyNameCollection(List<StylePropertyName> list)
	{
	}

	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x2B3B4A0", Offset = "0x2B3A6A0", VA = "0x182B3B4A0")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x2B3B540", Offset = "0x2B3A740", VA = "0x182B3B540", Slot = "4")]
	private IEnumerator<StylePropertyName> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EUIElements_002EStylePropertyName_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x2B3B600", Offset = "0x2B3A800", VA = "0x182B3B600", Slot = "5")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
