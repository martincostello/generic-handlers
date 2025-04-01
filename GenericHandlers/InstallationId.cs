namespace GenericHandlers;

public readonly record struct InstallationId(long Value)
{
    public static implicit operator long(InstallationId value) => value.Value;

    public long ToInt64() => Value;
}
