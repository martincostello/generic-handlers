namespace GenericHandlers;

public sealed class InstallationService
{
    public Task<bool> UserHasAccessToInstallationAsync(long installationId) => Task.FromResult(true);

    public Task<bool> UserHasAccessToRepositoryAsync(long installationId, long repositoryId) => Task.FromResult(true);
}
