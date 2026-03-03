using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Pool;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000175")]
internal class SetValueVisitor<TSrcValue> : PathVisitor
{
	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly UnityEngine.Pool.ObjectPool<SetValueVisitor<TSrcValue>> Pool;

	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x0")]
	public TSrcValue Value;

	[Token(Token = "0x170001F1")]
	public ConverterGroup group
	{
		[Token(Token = "0x6000B28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B29")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000B2A")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000B2B")]
	protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
	{
	}

	[Token(Token = "0x6000B2C")]
	public SetValueVisitor()
	{
	}
}
