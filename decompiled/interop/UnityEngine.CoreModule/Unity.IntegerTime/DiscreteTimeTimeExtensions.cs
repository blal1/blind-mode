using Il2CppSystem;

namespace Unity.IntegerTime;

public static class DiscreteTimeTimeExtensions
{
	public static DiscreteTime Abs(DiscreteTime lhs)
	{
		return DiscreteTime.FromTicks(Math.Abs(lhs.Value));
	}

	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
	{
		return DiscreteTime.FromTicks(Math.Min(lhs.Value, rhs.Value));
	}

	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
	{
		return DiscreteTime.FromTicks(Math.Max(lhs.Value, rhs.Value));
	}

	public static DiscreteTime Clamp(DiscreteTime x, DiscreteTime a, DiscreteTime b)
	{
		return Max(a, Min(b, x));
	}

	public static DiscreteTime Floor(DiscreteTime x)
	{
		return (DiscreteTime)Math.Floor((double)x);
	}

	public static DiscreteTime Select(DiscreteTime a, DiscreteTime b, bool c)
	{
		return DiscreteTime.FromTicks(c ? b.Value : a.Value);
	}
}
