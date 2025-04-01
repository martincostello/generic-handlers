namespace GenericHandlers;

public readonly record struct RepositoryId(long Value)
{
    public static implicit operator long(RepositoryId value) => value.Value;

    public long ToInt64() => Value;
}
